using System;

//Problem 15.* Age after 10 Years
namespace AgeAfterTenYears
{
    class CalculateAge
    {
        static void Main()
        {  
            Console.WriteLine("Enter your birthday dd.mm.yyyy :");

            //reading from the console 
            string birtDay = Console.ReadLine();

            //initializing with the current date 
            DateTime today = DateTime.Today;

            //converting from type string to type int
            DateTime birtDayInt = DateTime.Parse(birtDay);

            int ageNow = today.Year - birtDayInt.Year;

            int ageLater = ageNow + 10;

            //making a check for month and day
            if (today.Month > birtDayInt.Month || today.Day > birtDayInt.Day)
            {
                Console.WriteLine("Your age now is {0}:", ageNow);

                Console.WriteLine("Your age after 10 year is {0} :", ageLater);
            }

            else 
            {
                ageNow -= 1;
                Console.WriteLine("Your age now is {0}:", ageNow);

                
                Console.WriteLine("Your age after 10 year is {0} :", ageLater);
            }
         
        }
    }
}
