using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FibPractice
{
    public class Fib
    {
        public int startingX;
        public int startingY;
        private int returnValue;

        public Fib()
        {
            startingX = 0;
            startingY = 0;
        }
        public void CalculateFib(int numberOfLoops)
        {
            startingX = 0;
            startingY = 1;
            Console.WriteLine("Starting x: " + startingX);
            Console.WriteLine("Starting y: " + startingY);

            for (int i = 0; i < numberOfLoops; i++)
            {
                int sum = startingX + startingY;
                
                float ratio;
                if (startingX > startingY)
                {
                    ratio = (float)startingX/(float)startingY;
                }
                else
                {
                    ratio = (float)startingY/(float)startingX;
                }

                Console.WriteLine("Loop: " + i + "          Index: " + (i + 3) + "          Sum: " + sum + "            Ratio: " + ratio);

                if (i % 2 == 0)
                {
                    startingX = sum;
                }
                else
                {
                    startingY = sum;
                }
            }

            Console.ReadKey(true);
        }

        public void ValueAtIndex(int index)
        {
            startingX = 0;
            startingY = 1;
            if (index == 1)
            {
                Console.WriteLine("Value at " + index + " : " + 0);
                return;
            }
            else if (index == 2)
            {
                Console.WriteLine("Value at " + index + " : " + 1);
                return;
            }

            for (int i = 0; i < index - 2; i++)
            {
                int sum = startingX + startingY;

                if (i % 2 == 0)
                {
                    startingX = sum;
                }
                else
                {
                    startingY = sum;
                }

                returnValue = sum;
            }

            Console.WriteLine("Value at " + index + " : " + returnValue);
            Console.ReadKey(true);
        }
    }


}
