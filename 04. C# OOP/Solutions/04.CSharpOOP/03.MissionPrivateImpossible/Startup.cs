﻿namespace _03.MissionPrivateImpossible
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(result);
        }
    }
}

