using A1_Lower_Grade;


namespace A1_Lower_Grade
{
    class Program
    {
        static void Main(string[] args)
        {

            PrepareConsolesLook();

            Pet pet = new Pet();
            pet.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            TicketSeller ticket = new TicketSeller();
            ticket.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            Album album = new Album();
            album.Start();

        }
        static void PrepareConsolesLook()
        {
            //Arrange the Cosnole Window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";
        }

    }
}




