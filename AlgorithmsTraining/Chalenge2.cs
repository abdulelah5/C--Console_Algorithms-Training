using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining
{
    class Chalenge2
    {
        public Chalenge2()
        {
            int linesNumber;
            do
            {
                Console.Write("Enter lines number: ");
                linesNumber = int.Parse(Console.ReadLine());
            }
            while (linesNumber <= 0);

            Console.WriteLine();

            //Chalenge 2 Training 1
            Console.WriteLine("Chalenge 2 Training 1: ");
            for(int i=1; i<=linesNumber; i++)
            {
                for(int k=1; k<i; k++)
                {
                    Console.Write(" ");
                }

                for(int j=1; j<=linesNumber*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Chalenge 2 Training 2
            Console.WriteLine("Chalenge 2 Training 2: ");
            for (int i = 1; i <= linesNumber; i++)
            {
                for (int k = 1; k < linesNumber-i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (i * 2) -1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Chalenge 2 Training 3
            Console.WriteLine("Chalenge 2 Training 3: ");
            for (int i = linesNumber; i >= 1; i--)
            {
                for (int k = linesNumber; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (i * 2) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Chalenge 2 Training 4 -- its required linesNumber to be even not odd number -- (linesNumber % 2 == 0)
            Console.WriteLine("Chalenge 2 Training 4: ");
            for (int i=1; i<=linesNumber; i++)
            {
                if(i <= linesNumber/2)
                {
                    for(int k=1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j < linesNumber - i + 2; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
