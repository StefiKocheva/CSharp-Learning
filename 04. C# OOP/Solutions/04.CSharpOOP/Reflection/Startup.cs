namespace Reflection
{
    using System;
    using System.Reflection;

    public static class Startup
    {
        public static void Main()
        {
            Cat cat = new Cat("Macinka", 2);

            // Reflection get only public members, if you want to get non public ones you need to use binding flags like following.
            FieldInfo[] fields = cat.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            MethodInfo[] methods = cat.GetType().GetMethods();

            MethodInfo method = cat.GetType().GetMethod("Eat");

            PropertyInfo[] properties = cat.GetType().GetProperties();

            ConstructorInfo[] constructors = cat.GetType().GetConstructors();
        }
    }
}
