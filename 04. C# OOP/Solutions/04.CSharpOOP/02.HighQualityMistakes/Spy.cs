namespace _02.HighQualityMistakes
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();

            Type classType = Type.GetType($"_02.HighQualityMistakes.{className}");

            FieldInfo[] fields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            MethodInfo[] methods = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            foreach (var field in fields)
            {
                if (field.IsPublic)
                {
                    sb.AppendLine($"{field.Name} must be private!");
                }
            }

            foreach (var method in methods)
            {
                if (method.Name.StartsWith("get"))
                {
                    if (method.IsPrivate)
                    {
                        sb.AppendLine($"{method.Name} have to be public!");
                    }
                }
            }

            foreach (var method in methods)
            {
                if (method.Name.StartsWith("set"))
                {
                    if (method.IsPublic)
                    {
                        sb.AppendLine($"{method.Name} have to be private!");
                    }
                }
            }

            return sb.ToString();
        }
    }
}

