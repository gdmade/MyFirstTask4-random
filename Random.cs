using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Selection
{
    public class Random
    {
        static void Main(string[] args)
        {
            Selection_Sort selection = new Selection_Sort(3);
            selection.Sort();
        }
    }
    class Selection_Sort
    {
        private int[] data;
        private static Random generator = new Random();
            public Selection_Sort(int size)
            {
                data = new int[size];
                for (int i = 1; i < size; i++)
                {
                    data[i] = generator.Next(2,20);            
                }
            }
            public void Sort()
            {
                Console.Write("\nSorted Array Elements: (step by step )\n\n)");
                int smallest;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    smallest = i;

                    for (int index = i + 1; index < data.Length -1; index++)
                    {
                        if (data[index] < data[smallest])
                        {
                            smallest = index;
                        }
                        Console.Write("\n\n");
                    }
                }   
            }
    }
}