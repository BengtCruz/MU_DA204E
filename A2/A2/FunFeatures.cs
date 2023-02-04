using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A2
{
    public class FunFeatures
    {
        private string? email = null;
        private string? name = null;

        private enum weekDays
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }


        public void Start()
        {

            Introduce();

            bool repeat = false;

            do
            {

                PredictMyDay();

                CalculateStringLength();

                repeat = RunAgain();

            } while (repeat);

        }
        private void Introduce()
        {

            Console.WriteLine("My name is Bengt and I am a Spring semester student!");
            Console.WriteLine("\nLet me know bout yourself!");

            /* Read User data */
            ReadName();
            ReadEmail();

            Console.WriteLine("\nNice to meet you " + name);
            Console.WriteLine("Your email is " + email);
        }

        private void ReadName()
        {


            Console.Write("Your first name please: ");
            name = Console.ReadLine();
            Console.Write("Your last name please: ");
            name = name.Insert(0, Console.ReadLine().ToUpper() + ", ");
        }

        private void ReadEmail()
        {
            Console.Write("Your email please: ");
            email = Console.ReadLine();
        }
        private void PredictMyDay()
        {

            Console.WriteLine("\n****** FORTUNE TELLER ******");
            Console.Write("Select a number between 1 and 7: ");
            Enum.TryParse<weekDays>(Console.ReadLine(), ignoreCase: true, out var choice);

            switch (choice)
            {
                case weekDays.Monday:
                    Console.WriteLine("\nKeep calm on Mondays! You can fall apart!");
                    break;
                case weekDays.Tuesday:
                    Console.WriteLine("\nTuesdays break your heart");
                    break;
                case weekDays.Wednesday:
                    Console.WriteLine("\nWednesday hmmmm, I would stay home!");
                    break;
                case weekDays.Thursday:
                    Console.WriteLine("\nThursday is your lucky day, don't wait for Friday");
                    break;
                case weekDays.Friday:
                    Console.WriteLine("\nFriday, you are in love");
                    break;
                case weekDays.Saturday:
                    Console.WriteLine("\nSaturday, do nothing and do plenty of it!");
                    break;
                case weekDays.Sunday:
                    Console.WriteLine("\nAnd Sunday always comes too soon");
                    break;
                default:
                    Console.WriteLine("\nNo day? is a good day but it doesn't exist");
                    break;
            }
        }

        private bool RunAgain()
        {
            Console.Write("Continue with another round? (y/n): ");
            string? val = Console.ReadLine();

            return (val == "y" || val == "y" || val == "yes" || val == "Yes");
        }

        private void CalculateStringLength()
        {

            Console.WriteLine("\n---- STRING LENGTH ----");
            Console.WriteLine("Write a text with any number of characters and press Enter.\n" +
                "You can even copy text from a file and paste it here!");
            string? text = Console.ReadLine();
            Console.WriteLine(text.ToUpper() + "\nNumber of chars = " + text.Length);

        }

    }
}
