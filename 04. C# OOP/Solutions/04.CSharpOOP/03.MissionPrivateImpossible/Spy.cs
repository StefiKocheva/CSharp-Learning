namespace _03.MissionPrivateImpossible
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");

            Type classType = Type.GetType($"_03.MissionPrivateImpossible.{className}");

            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            MethodInfo[] methods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var method in methods)
            {
                sb.AppendLine($"{method.Name}");
            }

            return sb.ToString();
        }
    }
}

