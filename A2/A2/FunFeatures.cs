using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
    public class FunFeatures
    {
        private string? name = null;
        private string? email = null;


        public void Start()
        {

            Introduce();

            bool repeat = false;

            do
            {

                PredictMyDay();

                CalculateStrengthLength();

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
            Console.WriteLine("Your email is "+email);
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

        }

        private bool RunAgain()
        {
            return true;
        }

        private void CalculateStrengthLength()
        {

        }

    }
}
