using A1_Higher_Grade;

namespace A1_Higher_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrepareConsolesLook();

            Tv tv = new Tv();
            tv.start();
        }


        static void PrepareConsolesLook()
        {
            //Arrange the Cosnole Window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Sell your TV today!!";
        }

    }


}


