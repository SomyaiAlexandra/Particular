using System;

namespace _23_07_ex1
{
    class Program
    {
       
            static Random rnd = new Random();
            static void Main(string[] args)
            {
                int cr = 10;
                do
                {
                    int a = rnd.Next(0, 8);
                    int b = rnd.Next(0, 8);
                    int c = rnd.Next(0, 8);
                    cr--;
                    Console.WriteLine(a + " " + b + " " + c + " ");
                    Console.ReadKey();

                    if ((a == b) & (b == c))
                    {
                        Console.WriteLine("Cele 3 numere sunt identice");
                        cr = cr + 10;
                    }

                    else
                    {
                        if ((a == b) || (b == c) || (c == a))
                        {
                            Console.WriteLine("Doua dintre cele 3 numere sunt identice");
                            cr = cr + 2;
                        }
                        else
                        {
                            int t;

                            if (a > b)
                            {
                                t = a; a = b; b = t;
                            }
                            if (a > c)
                            {
                                t = a; a = c; c = t;
                            }
                            if (b > c)
                            {
                                t = b; b = c; c = t;
                            }

                            if ((c - b == b - a) & (c - b == 1))
                            {
                                Console.WriteLine("Numerele sunt in progresie artimetica si au ratia 1");
                                cr = cr + 1;
                            }
                            else
                                Console.WriteLine("None");
                        }
                    }
                    Console.WriteLine(cr);
                }
                while (cr > 0);
                Console.ReadKey();
            }
        }
    }

