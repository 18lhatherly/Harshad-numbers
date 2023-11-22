using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harshad_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int hNum = 0;
            int count = 0;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());


            while (hNum < n) {
                //Console.WriteLine("Count is");
                count += 1;
                if (isHarshad(count))
                {
                    hNum += 1;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
        static bool isHarshad(int inputNum)
        {
            string inputStr = inputNum.ToString();
            int sumOfDigits = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                sumOfDigits += Convert.ToInt32(inputNum.ToString()[i]) - 48;
                
            }
            if (inputNum % sumOfDigits == 0)
            {

                return true;
            }else
            {
                return false;
            }
        }
    }
}
