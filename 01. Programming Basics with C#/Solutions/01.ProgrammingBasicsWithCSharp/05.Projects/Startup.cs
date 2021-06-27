namespace _05.Projects
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            int projectsCount = int.Parse(Console.ReadLine());

            int neededHours = projectsCount * 3;

            Console.WriteLine($"The architect {name} will need {neededHours} hours to complete {projectsCount} project/s");
        }
    }
}
