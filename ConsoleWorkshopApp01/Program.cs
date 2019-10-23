using System;

namespace ConsoleWorkshopApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string firstName = AskUserFor("first name");
            string lastName = AskUserFor("last name");
            int age = AskUserForNumber("age");

            Console.WriteLine($"Your full name is {firstName} {lastName} and you are {age} years old" );

            double result = 7.4 * AskUserForNumber();

            Console.WriteLine("7.4 * your munber is: " + result);
            */

            char aLetter = 'a';

            Console.WriteLine(aLetter + 1);
            Console.WriteLine(aLetter + "1");
        }

        static string AskUserFor(string forWhat)
        {
            Console.Write($"Pleace input {forWhat}: ");
            return Console.ReadLine();
        }

        static int AskUserForNumber(string forWhat)
        {
            return int.Parse(AskUserFor(forWhat));
        }

        static double AskUserForNumber()
        {
            return double.Parse(AskUserFor("decimal number"));
        }

        static void SomeDateTimeEx()
        {
            DateTime timeNow = DateTime.Now;

            Console.WriteLine(timeNow.Ticks);
            Console.WriteLine(timeNow.Date);
            Console.WriteLine(timeNow.ToLongDateString());
            Console.WriteLine(timeNow.ToShortDateString());
            Console.WriteLine(timeNow.ToString("MM-dd-yyyy"));
            Console.WriteLine(timeNow.Year);          
        }

        static void WorkingWithStrings()
        {
            string firstName = "Ulf";
            string lastName = "Bengtsson";


            Console.WriteLine("Hello " + firstName + " " + lastName);

            Console.WriteLine("Hello {0} {1}!", firstName, lastName);

            Console.WriteLine($"Hello {firstName} {lastName} !!!");

            Console.WriteLine($" 3 + 5 = { 3 + 5 }");
        }

    }
}
