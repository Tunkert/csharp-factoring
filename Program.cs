using System;

namespace factoring
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Enter the value of b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of c: ");
            int c = Int32.Parse(Console.ReadLine());
            bool alreadySol = false;
            // int x1 = 0;
            // int x2 = 0;
            if (b <= 0 || c <= 0)
            {
                return;
            }
            for (int i = 1; i < c; i++)
            {
                if (c % i == 0)
                {
                    int j = c / i;
                    if (i + j == b)
                    {
                        if (!alreadySol)
                        {
                            Console.WriteLine("The factored solution is (x + " +
                            i + ")(x + " + j + ").");
                            alreadySol = true;
                        }
                    }
                }
            }
            // Console.WriteLine("The factored solution is (x + " + x1 + ")(x + " + x2 + ")");
        }
    }

    class Program : NewBaseType
    {
    }
}
