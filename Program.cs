using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //swapNumber();
            //multiplication();

            //arithmaticOp();

            //threeNumbers();

            //displayInDiffForms();

            // percentageCalc();

            //maxMin();

            //temperatureConversion();
            //triples();

            //absoluteDiffernce();

            //ConvertDaysToWeeks();
            Console.Read();


        }

        private static void ConvertDaysToWeeks()
        {
            Console.WriteLine("Enter the Days:");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {days}");
        }

        private static void absoluteDiffernce()
        {
            Console.WriteLine("Input the first Integer:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Integer:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            double absoluteDifference = Math.Abs(n1 - n2);
            if (n1 > n2)
            {
                double doubleabsoluteDifference = 2 * absoluteDifference;
                Console.WriteLine($"Absolute Difference={doubleabsoluteDifference}");
            }
            else
            {
                Console.WriteLine($"Absolute Difference={absoluteDifference}");
            }
        }

        private static void triples()
        {
            Console.WriteLine("Input the first Integer:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Integer:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;

            if (n1 == n2)
            {
                int sum2 = sum * sum * sum;
                Console.WriteLine($"Triples={sum2}");
            }
        }

        private static void temperatureConversion()
        {
            Console.WriteLine("Enter the amount of Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert to Kelvin
            double kelvin = celsius + 273.15;

            // Convert to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }

        private static void maxMin()
        {
            Console.WriteLine("Input the first Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine($"{n1} is greater");
                Console.WriteLine($"{n2} is smaller");

            }
            else
            {
                Console.WriteLine($"{n2} is greater");
                Console.WriteLine($"{n1} is smaller");
            }
        }

        private static void percentageCalc()
        {
            Console.WriteLine("Input the Marks1:");
            int mark1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Mark2:");
            int mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Mark3");
            int mark3 = Convert.ToInt32(Console.ReadLine());

            int tot = mark1 + mark2 + mark3;
            float per = tot / 3;

            if (per >= 60)
            {
                Console.WriteLine("First");
            }
            else if (per < 60 && per >= 45)
            {
                Console.WriteLine("Second");
            }
            else if (per < 45 && per >= 35)
            {
                Console.WriteLine("Third");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        private static void displayInDiffForms()
        {
            Console.WriteLine("Enter a digit: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // First set of lines
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);

            // Second set of lines
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
        }

        private static void threeNumbers()
        {
            Console.WriteLine("Input the first number:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second number:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Third number:");
            int z = Convert.ToInt32(Console.ReadLine());

            int res1 = (x + y) * z;
            int res2 = x * y + x * z;

            Console.WriteLine($"Result of (x + y) * z={res1}");
            Console.WriteLine($"Result of x * y + x * z={res2}");
        }

        private static void arithmaticOp()
        {
            Console.WriteLine("Input the first Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int add = n1 + n2;
            int sub = n1 - n2;
            int mul = n1 * n2;
            int div = n1 / n2;
            int mod = n1 % n2;

            Console.WriteLine($"{n1}+{n2}={add}");
            Console.WriteLine($"{n1}-{n2}={sub}");
            Console.WriteLine($"{n1}*{n2}={mul}");
            Console.WriteLine($"{n1}/{n2}={div}");
            Console.WriteLine($"{n1}%{n2}={mod}");
        }

        private static void multiplication()
        {
            Console.WriteLine("Input the first number to multiply:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second number to multiply:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Third number to multiply:");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int res = n1 * n2 * n3;

            Console.WriteLine($"{n1}*{n2}*{n3}={res}");
        }

        private static void swapNumber()
        {
            Console.WriteLine("Input the First Number :");
            int fno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Second Number :");
            int sno = Convert.ToInt32(Console.ReadLine());

            int temp;
            temp = fno;
            fno = sno;
            sno = temp;

            Console.WriteLine("After Swapping :");
            Console.WriteLine($"First Number : {fno}");
            Console.WriteLine($"Second Number : {sno}");
        }
    }
}
