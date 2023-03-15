using System;

/* GRADE D: Pet */

namespace A1_Lower_Grade{


    public class Pet
    {
        private string? name = null;
        private ushort age;
        private bool female;

        private void classGreet()
        {
            Console.WriteLine("Greetings from MyPet class!\n");
        }

        public void Start()
        {
            classGreet();

            readAndSavePetData();

            displayResult(name, age, female);
        }

        private void displayResult(string name,ushort age, bool female)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("Name: " +name+ " Age: "+age);
            if(!female)
                Console.WriteLine(name+" is a good boy!");
            else    
                Console.WriteLine(name+" is a good girl!");
                Console.WriteLine("++++++++++++++++++++++++++++++++");
    }

        private void readAndSavePetData()
        {
            string temp;

            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine();
            Console.Write("What is "+name+" age? ");
            age = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Is your pet a female (y/n)? ");
            temp = Console.ReadLine();

            /* Evaluate input and assign to female */
            female = (temp == "y" || temp == "Y");
           
        }

    }
    
}