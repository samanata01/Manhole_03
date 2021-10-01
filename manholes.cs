using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manholes
{
    class manhole_soln
    {
        int count = 0;
        int x = 0;
        public int cover(int[] a, int[] b)
        {
            for (int i = 0; i < 16; i++)
            {
                if (a[i] == 1)
                {
                    if (i < 15 && a[i + 1] == 1)
                    {
                        if ((i + 1) % 4 == 0)
                        {
                            count++;
                        }
                        else { }
                    }
                    else if ((i % 4) != 0 && a[i - 1] == 1)
                    {
                        count++;
                    }
                    else if (i < 12 && a[i + 4] != 1)
                    {
                        count++;
                    }
                    else if (i > 11 && a[i - 4] == 0)
                    {
                        if (i < 12 && a[i + 4] == 0)
                        {
                            count++;
                        }
                    }
                    else if (i % 4 == 0 && (i < 12 && a[i + 4] == 0))
                    {
                        count++;
                    }

                }


                if (b[i] == 1)
                {
                    if (i < 15 && b[i + 1] == 1 && i + 1 % 4 != 0)
                    {
                        if ((i < 12 && b[i + 4] == 1) || (i > 3 && b[i - 4] == 1))
                        {

                        }
                        else
                        {
                            x = 1;
                        }

                    }
                    else if (x == 1)
                    {
                        count++;
                        x = 0;
                    }
                }
            }
            return count;
        }
    }


    class manholes
    {
        static void Main(string[] args)
        {
            manhole_soln ob = new manhole_soln();
            int size;
            Console.WriteLine("Enter the matrix size");
            size = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[size, size];
            int[] a = new int[size * size];
            int[] b = new int[size * size];
            int k = 0;
            Console.WriteLine("Enter matrix elements");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("The array elements = ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                    a[k] = arr[i, j];
                    b[k] = arr[j, i];
                    k++;
                }
                Console.WriteLine();
            }
            Console.WriteLine(ob.cover(a, b));
        }

    }
}