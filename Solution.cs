using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, sum = 0, add;

            Console.Write("Insert a number to check for Armstrong: ");
            x = int.Parse(Console.ReadLine());
            a = x.ToString().Length;

            add = x;

            while (x > 0)
            {
                y = x % 10;
                sum = sum + (int)Math.Pow(y, a);
                x = x / 10;
            }

            if (add == sum)
            {
                Console.Write("This is an ARMSTRONG number!");
            }
            else
            {
                Console.Write("This is NOT an ARMSTRING number");
            }
            Console.ReadKey();

            Console.WriteLine("Log" );

            numbersArmstrong();
        }
    
        public static void numbersArmstrong()
        {
            Console.WriteLine("Some Armstrong numbers: ");
            for (int i = 1; i <= 2000000000; i++)
            {
                int num = i;
                int sum = 0;
                int lenght = (int)Math.Floor(Math.Log10(num)) + 1; // wzór używany do określenia ilości liczb w ciągu + 1 bo przy 4 liczbach jest 3, a przy liczbach do 10 jest 0
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += (int)Math.Pow(digit, lenght);
                    num /= 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
