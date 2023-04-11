using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class PhoneBook
    {

        private string[] names = { "Friend1", "Friend2", "Adam", "Malcom", "Friend5" };
        private string[] phones = { "040-1231", "040-1232", "040-1233", "040-1234", "040-1235" };

        private string[,] phoneList;

        /// <summary>
        /// Default Constructor (constructor with no parameter)
        /// </summary>
        public PhoneBook()
        {
            Console.Clear();

            //1
            DisplayList();
            Console.WriteLine();

            //2
            SortByName();
            Console.WriteLine("\n\nSorted List:\n");
            DisplayList();

            //3 Two-dimensional array
            int count = names.Length;
            phoneList = new string[count, 2]; 
            FillTable();

            Console.WriteLine("\n\nUsing a 2d array insead of two 1d arrays:\n");
            DisplayTable();
        }

        /// <summary>
        /// Display each of the 1d arraya. names & lengths
        /// </summary>
        private void DisplayList()
        {
            for (int i = 0; i < (phones.Length); i++)
            {
                Console.WriteLine("{0,-10}         {1,-10}", names[i], phones[i]);
            }
        }

        /// <summary>
        /// Displays a table using the values in the phoneList 2d array.
        /// </summary>
        private void DisplayTable()
        {
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Row {0}   {1,-10}         {2,-10}",i, phoneList[i, 0], phoneList[i, 1]);
            }
        }

        /// <summary>
        /// Fills out phoneList 2d array to later print as a table.
        /// </summary>
        private void FillTable()
        {
            for(int i = 0; i < names.Length; i++)
            {
                phoneList[i,0] = names[i];
                phoneList[i,1] = phones[i];
            }
        }

        /// <summary>
        /// Sorts both 1d arrays, names and phones. In decreasing order.
        /// </summary>
        private void SortByName()
        {

            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < names.Length - 1; j++)
                {
                    if (names[j].CompareTo(names[j + 1]) > 0)
                    {
                        SwapValues(j);
                    }
                }
            }
        }

        /// <summary>
        /// Swaps values in 1d arrays during SortByName function.
        /// </summary>
        /// <param name="pos">Current position</param>
        private void SwapValues(int pos)
        {
            string temp;
            string tempP;
            temp = names[pos + 1];
            tempP = phones[pos + 1];

            names[pos + 1] = names[pos];
            phones[pos + 1] = phones[pos];

            names[pos] = temp;
            phones[pos] = tempP;
        }
    }
}
