using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace A2
{
    /// <summary>
    /// Working Schedule CLI
    /// </summary>
    public class WorkingSchedule
    {

        private enum Choices
        {
            Exit,
            Weekends,
            Nights
        }

        /// <summary>
        /// Stop execution and ask the user to continue execution to the menu again.
        /// </summary>
        /// <returns>void</returns>
        private static void Continue()
        {
            Console.WriteLine("\nPRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
        }


        /// <summary>
        /// Take use request and print information based on the users request. Either Night or Weekends.
        /// </summary>
        /// <param name="request">Choice based on weekends or nights</param>
        /// <returns>void</returns>
        void RequestAndShowList(Choices request)
        {
            const int max_weeks = 52;
            
            if(request == Choices.Weekends)
            {
                int count = 0;
                int newLine = 0;

                for(int i = 1; i <= max_weeks; i++)
                {
                    if(i == 1 || count == 2)
                    {
                        Console.Write($"Week {i,2} \t");
                        count = 0;
                        newLine++;

                        if (newLine == 4)
                        {
                            Console.WriteLine();
                            newLine = 0;
                        }
                    }

                    count++;

                }
            }

            if (request == Choices.Nights)
            {
                int count = 0;
                int newLine = 0;

                for (int i = 1; i <= max_weeks; i++)
                {
                    if (i == 1 || count == 4)
                    {
                        Console.Write($"Week {i,5} \t");
                        count = 0;
                        newLine++;

                        if (newLine == 4)
                        { 
                            Console.WriteLine();
                            newLine = 0;
                        }
                    }

                    count++;

                }
            }

            Console.WriteLine();

        }

        /// <summary>
        /// Display the series of options the user
        /// can take and execute the program further.
        /// </summary>
        /// <returns>void</returns>
        private void ShowMenu()
        {

            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("               WORK SCEHDULE             \n");
            Console.WriteLine("-----------------------------------------\n");

            Console.WriteLine("        Show list of weekends to work  : 1");
            Console.WriteLine("        Show list of nights to work    : 2");
            Console.WriteLine("        Exit                           : 0");

            Console.WriteLine("-----------------------------------------\n");
            Console.Write("Your choice: ");
        }


        /// <summary>
        /// Call methods in the class to start the Working Schedule CLI.
        /// </summary>
        /// <returns>void</returns>
        public void Start()
        {
            bool done = false;

            do
            {
                ShowMenu();
                Enum.TryParse<Choices>(Console.ReadLine(), ignoreCase: true, out var choice);
                Console.WriteLine();

                switch (choice)
                {
                    case Choices.Weekends:
                        RequestAndShowList(Choices.Weekends);
                        Continue();
                        break;
                    case Choices.Nights:
                        RequestAndShowList(Choices.Nights);
                        Continue();
                        break;
                    case Choices.Exit:
                        done = true;
                        break;
                }

            } while (!done);
        }

    }
}
