using System;

namespace Assignment1
{
    public class TicketSeller
    {
        private string name;
        private double price = 100.0;
        private short numOfAdults;
        private short numOfChildren;
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
            temp = Console.ReadLine();
            numOfAdults = Convert.ToSByte(temp);
            Console.WriteLine("Number of children:");
            temp = Console.ReadLine();
            numOfChildren = Convert.ToSByte(temp);
        }

        private double calculateTotal()
        {
            double sum = 0;

            for (int i = 0; i < numOfAdults; i++)
            {
                sum += price;
            }

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

            numOfAdults = 0;
            numOfChildren = 0;
            name = null;
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