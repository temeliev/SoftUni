namespace _03.StringDisperser
{
    using System;

    class MainClass
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
            Console.WriteLine(stringDisperser);
        }
    }
}
