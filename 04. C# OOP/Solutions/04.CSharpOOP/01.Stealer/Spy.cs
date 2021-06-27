namespace _01.Stealer
{
    using System;
    using System.Text;
    using System.Reflection;

    public class Spy
    {
        public string StealFieldInfo(string name, params string[] fields)
        {
            StringBuilder sb = new StringBuilder();

            Type classType = Type.GetType($"_01.Stealer.{name}");

            sb.AppendLine($"Class under investigation: {classType.Name}");

            object instance = Activator.CreateInstance(classType);

            foreach (var field in fields)
            {
                var value = classType
                    .GetField(
                    field, 
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                    .GetValue(instance);

                sb.AppendLine($"{field} = {value}");
            }

            return sb.ToString();
        }
    }
}
