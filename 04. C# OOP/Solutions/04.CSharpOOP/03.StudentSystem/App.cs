namespace _03.StudentSystem
{
    using System;

    public static class App
    {
        private static readonly StudentSystem studentSystem = new StudentSystem();

        public static void Run()
        {
            string input = Console.ReadLine();

            while (input != "Exit")
            {
                var studentInfo = input.Split();

                switch (studentInfo[0])
                {
                    case "Create":
                        studentSystem.Create(studentInfo);
                        break;
                    case "Show":
                        studentSystem.Show(studentInfo);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}