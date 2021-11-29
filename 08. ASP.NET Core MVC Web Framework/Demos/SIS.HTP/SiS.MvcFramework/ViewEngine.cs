namespace SIS.MvcFramework
{
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    public partial class ViewEngine : IViewEngine
    {
        public string GetHtml(string templateHtml, object model, string user)
        {
            var methodCode = PrepareCSharpCode(templateHtml);
            var typeName = model?.GetType().FullName ?? "object"; // ?? - If that on left in null, then put that on right.

            if (model?.GetType().IsGenericType == true) // null/true/false bool?
            {
                typeName = model.GetType().Name.Replace("`1", string.Empty) + "<" 
                    + model.GetType().GenericTypeArguments.First().Name + ">";
            }

            var code = @$"using System;
using System.Text;
using System.Linq;
using SIS.MvcFramework
using System.Collections.Generic;
namespace AppViewNamespace
{{
    public class AppViewCode : IView
    {{
        public string GetHtml(object model, string user)
        {{
            var Model = model as {typeName};
            var User = user;
            var html = new StringBuilder();

{methodCode}

            return html.ToString();
        }}
    }}
}}";

            IView view = GetInstanceFromCode(code, model);
            string html = view.GetHtml(model, user);

            return html;
        }

        private IView GetInstanceFromCode(string code, object model)
        {
            var compilation = CSharpCompilation.Create("AppViewAssembly").WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)) // We add congigurations.
                .AddReferences(MetadataReference.CreateFromFile(typeof(IView).Assembly.Location))
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location));// compile timen - typeof()

            if (model != null)
            {
                compilation = compilation.AddReferences(MetadataReference.CreateFromFile(model.GetType().Assembly.Location)); // run time - GetType()
            }

            var libraries = Assembly.Load(new AssemblyName("netstandard")).GetReferencedAssemblies(); // netstandard (abstract) - it is empty, but has references to all other libraries that are part of that standard
            
            foreach (var library in libraries)
            {
                compilation = compilation.AddReferences(
                    MetadataReference.CreateFromFile(Assembly.Load(library).Location));
            }

            // What to compile our compilator.
            compilation = compilation.AddSyntaxTrees(SyntaxFactory.ParseSyntaxTree(code));

            using var memoryStream = new MemoryStream(); // The result is in the memory.
            // Emit() - add C# instruction list.
            var compilationResult = compilation.Emit(memoryStream);

            if (!compilationResult.Success)
            {
                return new ErrorView(compilationResult.Diagnostics
                    .Where(x => x.Severity == DiagnosticSeverity.Error) // Severity - dangeour level.
                    .Select(x => x.GetMessage())); 
            }

            memoryStream.Seek(0, SeekOrigin.Begin); // Return me in the start, that is how we can read the recorded part of the buffer. 
            var assemblyByteArray = memoryStream.ToArray();
            var assembbly = Assembly.Load(assemblyByteArray);
            var type = assembbly.GetType("AppViewNamespace.AppViewCode");
            var instance = Activator.CreateInstance(type) as IView; // Make instance of AppViewCode ( new AppViewCode ).
            return instance;
        }

        private string PrepareCSharpCode(string templateHtml)
        {
            var cSharpExpressionRegex = new Regex(@"[^\<\""\s]", RegexOptions.Compiled);
            var supportedOperators = new[] { "if", "for", "foreach", "else" };

            StringBuilder cSharpCode = new StringBuilder();
            StringReader reader = new StringReader(templateHtml);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.TrimStart().StartsWith("{") 
                    || line.TrimStart().StartsWith("}"))
                {
                    cSharpCode.AppendLine(line);
                }
                else if (supportedOperators.Any(x => line.StartsWith("@" + x)))
                {
                    var indexOfAt = line.IndexOf("@");
                    line = line.Remove(indexOfAt, 1);
                    cSharpCode.AppendLine(line);
                }
                else
                {
                    var currentCSharpLine = new StringBuilder("html.AppendLine(@\"");

                    while (line.Contains("@"))
                    {
                        var atSignLocation = line.IndexOf("@");
                        var before = line.Substring(0, atSignLocation);
                        currentCSharpLine.Append(before.Replace("\"", "\"\"") + "\" + ");
                        var cSharpAndEndOfLine = line.Substring(atSignLocation + 1);
                        var cSharpExpression = cSharpExpressionRegex.Match(cSharpAndEndOfLine);
                        currentCSharpLine.Append(cSharpExpression.Value + " + @\"");
                        var after = cSharpAndEndOfLine.Substring(cSharpAndEndOfLine.Length);
                        line = after;
                        // before => HTML => html.AppendLine
                        // @ => delete
                        // C# code => " + C# code + "
                        // line = after
                    }

                    currentCSharpLine.Append(line.Replace("\"", "\"\"") + "\";");
                    cSharpCode.AppendLine(currentCSharpLine.ToString());
                }
            }

            return cSharpCode.ToString();
        }
    }
}