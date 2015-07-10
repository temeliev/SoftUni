namespace _02.Custom
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            Customer cust1 = new Customer("Ivan", "Petkanov", "Petkanov", 12345, "testAdress", "+3592323", "test@ate.bg", CustomerType.Regular, new List<Payment>() { new Payment("test", 222) });
            Customer cust2 = new Customer("Andrei", "Petkanov", "Petkanov", 12345, "testAdress", "+3592323", "test@ate.bg", CustomerType.Regular, new List<Payment>());

            if (cust1 != cust2)
            {
                Console.WriteLine(true);
            }

            Customer test = (Customer)cust1.Clone();

            if (test == cust1)
            {
                Console.WriteLine(true);
            }

            if (cust1.CompareTo(cust2) < 0)
            {
                Console.WriteLine(cust1);
            }
            else
            {
                Console.WriteLine(cust2);
            }
        }
    }
}
