using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* GRADE B: TV Ad platform */

namespace A1_Higher_Grade
{
    internal class Tv
    {
        private string? tvBrand = null;
        /* Using ushort for memory optimization */
        private ushort inchSize;
        private string? displayType = null;
        private bool smartTv;
        private double price;


        private void classGreet()
        {
            Console.WriteLine("Welcome to your TV AD!");
        }

        private void readAndSaveTvData()
        {
            string temp;

            Console.Write("What is the TVs brand? ");
            tvBrand = Console.ReadLine();
            Console.Write("What is the TVs size (in inches)? ");
            inchSize = Convert.ToUInt16(Console.ReadLine());
            Console.Write("TV display type (OLED,QLED,LED...) ");
            displayType = Console.ReadLine();
            Console.Write("Is it a Smart TV (y/n)? ");
            temp = Console.ReadLine();
            Console.Write("How much are you whilling to sell it for (euros)? ");
            price = Convert.ToDouble(Console.ReadLine());
            
            /* Evaluate input and assing to smartTv */
            smartTv = (temp == "y" || temp == "Y"); 

        }

        private void displayData(string tvBrand, ushort inchSize, string displayType, bool smartTv, double price)
        {
            DateTime current_time = DateTime.Now; 

            Console.WriteLine("++++++++++++++++++++++++++++");
            Console.WriteLine("++         TV AD          ++");
            Console.WriteLine("++++++++++++++++++++++++++++\n");
            Console.WriteLine("Brand: " + tvBrand);
            Console.WriteLine("Size: " + inchSize.ToString()+"\"");
            Console.WriteLine("Display: " + displayType);
            Console.WriteLine("SmartTV: {0}",smartTv ? "Yes" : "No"); /* Testing Ternary operations */
            Console.WriteLine("Price: " + price.ToString("N2"));

            /* GRADE A: Display current time in which the ad was posted */
            Console.WriteLine("\n{0}",current_time);
            Console.WriteLine("\n++++++++++++++++++++++++++++");
        }

        public void start()
        {
            classGreet();
            readAndSaveTvData();
            displayData(tvBrand, inchSize, displayType, smartTv, price);
        }
    }
}
