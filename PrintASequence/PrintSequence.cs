using System;

//Problem 9. Print a Sequence
namespace PrintASequence
{
    class PrintSequence
    {
        static void Main()
        {
            //using loop condition for
            for (int i = 2; i < 12; i++)
            {
                // making a check for even/odd number
                if (i % 2 == 0)
                {   
                    
                    Console.Write("{0},",i);
                }
                else
                {
                    Console.Write("{0},",-i);
                }
            }
            Console.WriteLine();
        }
    }
}
