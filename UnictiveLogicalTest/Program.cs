using System.Reflection;

namespace UnictiveLogicalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Unictive = "Unictive";
            string UnictiveMedia = "Unictive Media";

            for (int i = 1; i <= 30; i++)
            {
                if (i % 14 == 0 && i % 4 == 0)
                {
                    Console.WriteLine(UnictiveMedia);
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine(Unictive);

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}