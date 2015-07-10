using System;
 
namespace _04.GenericListVersion
{
    using System.Reflection;

    using _03.GenericList;

    class MainClass
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(GenericList<>);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }

        }
    }
}
