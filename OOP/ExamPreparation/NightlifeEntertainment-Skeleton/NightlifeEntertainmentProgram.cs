﻿namespace NightlifeEntertainment
{
    using System;
    using System.Globalization;
    using System.Threading;

    using NightlifeEntertainment.Engine;

    public class NightlifeEntertainmentProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            ExtendedCinemaEngine engine = new ExtendedCinemaEngine();
            StartOperations(engine);
        }

        private static void StartOperations(CinemaEngine engine)
        {
            string line = Console.ReadLine();
            while (line != "end")
            {
                engine.ParseCommand(line);
                line = Console.ReadLine();
            }

            Console.Write(engine.Output);
        }
    }
}
