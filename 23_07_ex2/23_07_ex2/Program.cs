using System;

namespace _23_07_ex2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {

            int t;
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);
            int c = rnd.Next(1, 10);
            int d = rnd.Next(1, 10);
            int e = rnd.Next(1, 10);

            Console.WriteLine("Numarul este " + a + " " + b + " " + c + " " + d + " " + e + " ");
            Console.ReadKey();

            if (a > b)
            {
                t = a; a = b; b = t;
            }
            if (a > c)
            {
                t = a; a = c; c = t;
            }
            if (a > d)
            {
                t = a; a = d; d = t;
            }
            if (a > e)
            {
                t = a; a = e; e = t;
            }
            if (b > c)
            {
                t = b; b = c; c = t;
            }
            if (b > d)
            {
                t = b; b = d; d = t;
            }
            if (b > e)
            {
                t = b; b = e; e = t;
            }
            if (c > d)
            {
                t = c; c = d; d = t;
            }
            if (c > e)
            {
                t = c; c = e; e = t;
            }
            if (d > e)
            {
                t = d; d = e; e = t;
            }

            Console.WriteLine("Numarul aranjat este " + a + " " + b + " " + c + " " + d + " " + e + " ");

            if ((a == b) && (a == c) && (a == d) && (a == e))
                Console.WriteLine("Toate cifrele sunt identice");
            else

                if (((a == b) && (a == c) && (a == d)) || ((b == c) && (b == d) && (b == e)))
            {
                Console.WriteLine("Sunt identice 4 cifre");
            }
            if (((a == b) && (a == c) && (d == e)) || ((a == b) && (c == d) && (c == e)))
            {
                Console.WriteLine("Sunt identice 3 cu 2");
            }
            if (((a == b) && (a == c)) || ((b == c) && (b == d)) || (c == d) && (c == e))
            {
                Console.WriteLine("Sunt identice 3 cifre");
            }
            if (((a == b) && (c == d)) || ((b == c) && (d == e)) || ((a == b) & (d == e)))
            {
                Console.WriteLine("Sunt identice 2 cate 2");
            }
            if ((a == b) || (b == c) || (c == d) || (d == e))
            {
                Console.WriteLine("Sunt identice 2 cifre");
            }


            else
                Console.WriteLine("Numerele nu sunt identice");

            Console.ReadKey();
        }
    }
}
  