using System;

namespace DateTypeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables for each of the following values.Assign the values to them, make sure
            //to choose the data type that is the best fit for the value. Omit any commas, they are just
            //there to make the number easier to read.
            // Floating 


            //double number = 5.323423;
            //float number2 = 23423.2342f;
            //decimal number3 = 13.23423m;
            //decimal number4 = 14234.234234m;
            //Console.WriteLine(number4);
            //// casting
            //// explict casting
            //int newNum = (int)number4;
            //Console.WriteLine(newNum);

            //// implicit casting
            //double newNum2 = newNum;
            //Console.WriteLine(newNum2.GetType());

            float f1 = 123412.42342f;
            float f2 = (float)123412.42342;

            bool b = ((23432 < 1023 && 3942 > 2309342) || 2023 == 2342);
            Console.WriteLine(b);

            // num1 is greater than both 5 AND num2 OR num2 is less than - 3
            // num1 is greater than both 5 AND num2

            // num1 is great than 5
            // num 1 is greater than num2

            // num 2 is less than -3

            // num1 = 6, num2 = 5
            // num1 is greater than both 5 AND num2
            // //OR num2 is less than -3  // false
            int num1 = 6, num2 = 5;

            if ( num1 < 100 && num1 > 100 )
            {

            }
        }

        public static void GenerateNumbers()
        {
            Random rand = new Random();

            bool flag = true;

            while (flag)
            {

                if (rand.Next(2) == 1)
                {
                    Console.WriteLine("Whole Number: " + rand.Next());

                }
                else
                {
                    Console.WriteLine("Decimal Number: " + rand.Next() + rand.NextDouble());

                }


                if (Console.ReadLine() == "e")
                {
                    flag = false;
                }
            }

        }
    }
}
