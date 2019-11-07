using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression...");
            string values = Console.ReadLine();
            Numbers nums = new Numbers();
            Operators ops = new Operators();
          
            for (int i = 0; i < values.Length; i++)
            {
                if (isNumber(values[i].ToString()))
                {
                    nums.push(values[i].ToString());
                } //else if (isOps(values[i].ToString()))
                /*{
                    ops.push(values[i].ToString());
                }*/
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(nums.pop());
            }

        }

        static bool isNumber(string chr)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return true;
        }

        static bool isOps(string chr)
        {
            return true;
        }
    }
}