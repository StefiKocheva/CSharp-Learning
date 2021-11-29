using System;

namespace Threeuple
{
    public static class Startup
    {
        public static void Main()
        {
            string personInfo = Console.ReadLine();
            var personInfoSplit = personInfo.Split(" ");
            Threeuple<string> firstOne = new Threeuple<string>();
            firstOne.FirstElement = personInfoSplit[0];
            firstOne.SecondEleemnt = personInfoSplit[1];
            firstOne.ThirdElement = personInfoSplit[2];

            string drunkOrNot = Console.ReadLine();
            var drunkOrNotSplit = drunkOrNot.Split(" ");
            Threeuple<string> secondOne = new Threeuple<string>();
            secondOne.FirstElement = drunkOrNotSplit[0];
            secondOne.SecondEleemnt = drunkOrNotSplit[1];
            secondOne.ThirdElement = drunkOrNotSplit[2];

            string bankInfo = Console.ReadLine();
            var bankInfoSplit = bankInfo.Split(" ");
            Threeuple<string> thirdOne = new Threeuple<string>();
            thirdOne.FirstElement = bankInfoSplit[0];
            thirdOne.SecondEleemnt = bankInfoSplit[1];
            thirdOne.ThirdElement = bankInfoSplit[2];

            Console.WriteLine($"{firstOne.FirstElement} -> {firstOne.SecondEleemnt} -> {firstOne.ThirdElement}");
            Console.WriteLine($"{secondOne.FirstElement} -> {secondOne.SecondEleemnt} -> {secondOne.ThirdElement}");
            Console.WriteLine($"{thirdOne.FirstElement} -> {thirdOne.SecondEleemnt} -> {thirdOne.ThirdElement}");
        }
    }
}
