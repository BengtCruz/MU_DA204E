using System;

/* GRADE C: TicketSeller */

namespace A1_Lower_Grade
{
    public class TicketSeller
    {
        private string? name = null;
        private double price = 100.0;
        private ushort numOfAdults;
        private ushort numOfChildren;
        private double amountToPay;

        private void kidsFairGreet()
        {
            Console.Write("Welcome to KIDS' FAIR!\n");
            Console.WriteLine("Children get always 75% discount!");
        }

        private void takeGuest()
        {
            string temp;

            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
            Console.WriteLine("Number of adults:");
            numOfAdults = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Number of children:");
            numOfChildren = Convert.ToUInt16(Console.ReadLine());
        }

        private double calculateTotal()
        {
            double sum = 0;

            /* Iterate through number of adults and add to sum */
            for (int i = 0; i < numOfAdults; i++)
            {
                sum += price;
            }

            /* Iterate through number of childre calculate discount & add to sum */
            for (int i = 0; i < numOfChildren; i++)
            {
                sum += price - 75;
            }

            return sum;

        }

        private void printReceipt()
        {

            amountToPay = calculateTotal();
            Console.WriteLine("+++ Your Receipt +++");
            Console.WriteLine("+++ Total = "+ amountToPay.ToString("N2") +" +++");
            Console.WriteLine("+++ Thank you "+ name +" and please come back! +++");

            /* Reset for further use of the object, maybe after saving? practice only */
            numOfAdults = 0;
            numOfChildren = 0;
            name = "";
            amountToPay = 0.0;
        }

        public void Start()
        {
            kidsFairGreet();

            takeGuest();

            printReceipt();
        }

    }   

}