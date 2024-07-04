using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (i != 9)
            {
                int choice;
                do
                {
                    Console.WriteLine("=========================================");
                    Console.Write("Enter chalenge number or 9 to exit: ");
                    choice = int.Parse(Console.ReadLine());
                }
                while (choice <= 0);

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Chalenge1 t1 = new Chalenge1();
                        break;
                    case 2:
                        Chalenge2 t2 = new Chalenge2();
                        break;
                    case 9:
                        i = 9;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
