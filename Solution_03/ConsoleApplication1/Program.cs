﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciao sono Marco!");
            int[] array = new int[] { 6, 3, 9, 8 };
            int tmp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }

                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.ReadLine();
        }
    }
}
