using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTraining
{
    class Chalenge1
    {
        public Chalenge1()
        {
            int linesNumber;
            do
            {
                Console.Write("Enter lines number: ");
                linesNumber = int.Parse(Console.ReadLine());
            }
            while (linesNumber <= 0);

            Console.WriteLine();

            //Chalenge 1 Training 1
            Console.WriteLine("Chalenge 1 Training 1: ");
            for (int i = 0; i < linesNumber; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            //Chalenge 1 Training 2
            Console.WriteLine("Chalenge 1 Training 2: ");
            for (int i=1; i<=linesNumber; i++)
            {
                for (int k = 1; k <= linesNumber - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {                   
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Chalenge 1 Training 3
            Console.WriteLine("Chalenge 1 Training 3: ");
            for (int i = linesNumber; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Chalenge 1 Training 4
            //West of time its same training 3 by appliyng idea of training 2

            //Chalenge 1 Training 5
            Console.WriteLine("Chalenge 1 Training 5: ");
            for (int i=1; i<=linesNumber;i++)
            {
                for (int k = 1; k <= linesNumber - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= linesNumber*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
