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
        int count1 = 0;
        int val;
        public int cover(int[] a, int[] b,int size)
        {
            for (int i = 0; i <a.Length; i++)
            {
                if (a[i] == 1)
                {
                    if (i < (size*size-1) && a[i + 1] == 1)
                    {
                        if ((i + 1) % size == 0)
                        {
                            count++;
                        }
                        else { }
                    }
                    else if ((i % size) != 0 && a[i - 1] == 1)
                    {
                        count++;
                    }
                    else if (i < (size*(size-1)) && a[i + size] != 1)
                    {
                        count++;
                    }
                    else if (i > (size * (size - 1)-1) && a[i - size] == 0)
                    {
                        if (i < (size*(size-1)) && a[i + size] == 0)
                        {
                            count++;
                        }
                    }
                    else if (i % size == 0 && (i < (size * (size - 1)) && a[i + size] == 0))
                    {
                        count++;
                    }

                }


                if (b[i] == 1)
                {
                    if (i < (size*size-1) && b[i + 1] == 1 && i + 1 % size != 0)
                    {
                        if ((i < (size * (size - 1)) && b[i + size] == 1) || (i > (size-1) && b[i - size] == 1))
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
            return val;
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
            Console.WriteLine(ob.cover(a, b,size));
        }

    }
}
