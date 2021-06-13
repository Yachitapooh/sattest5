using System;

namespace sattestfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ5
            int item = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string type = Console.ReadLine();
            string mode = Console.ReadLine();
            while (mode == "ShowAll")
            {
                if (mode == "ShowAll")
                {
                    Console.WriteLine("{0}", name);
                    Console.WriteLine("{0}", type);
                    Console.WriteLine();
                }
                else if (mode == "item") 
                {
                    Console.WriteLine("{0}", name);
                    Console.WriteLine("{0}", type);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("End");
                }
            }

            Console.ReadLine(); 



        }
    }
}
