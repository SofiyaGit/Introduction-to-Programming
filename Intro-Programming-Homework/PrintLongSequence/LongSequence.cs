using System;

//Problem 16.* Print Long Sequence
namespace PrintLongSequence
{
    class LongSequence
    {
        static void Main()
        {
            //using loop condition for
            for (int i = 2; i < 1002; i++)
            {
                // making a check for even/odd number
                if (i % 2 == 0)
                {

                    Console.Write("{0},\t", i);
                }
                else
                {
                    Console.Write("{0},\t", -i);
                }
            }
            Console.WriteLine();
        }
    }
}
