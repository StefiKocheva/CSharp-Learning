namespace Ranking
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            HashSet<string> inputData = new HashSet<string>();
            HashSet<string> contestsAndPasswords = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] info = command.Split(':');
                string contestsAndPasswordsInfo = info[0] + info[1];
                contestsAndPasswords.Add(contestsAndPasswordsInfo);
            
                inputData.Add(command);
            
                command = Console.ReadLine();
            }
            
            HashSet<string> submissionData = new HashSet<string>();
            
            string data = Console.ReadLine();
            
            while (data != "end of submissions")
            {
                submissionData.Add(data);
            
                data = Console.ReadLine();
            }
            
            foreach (var submission in submissionData)
            {
                var info = submission.Split("=>");
                var contestAndPassword = info[0] + info[1];
                var content = info[0];
                var username = info[2];
                var receivedPoints = info[3];
            
                if (contestsAndPasswords.Contains(contestAndPassword))
                {
                    
                }
            }
        }
    }
}
