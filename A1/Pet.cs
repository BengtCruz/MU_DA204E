using System;

namespace Assignment1{

public class Pet
{
    private string name;
    private short age;
    private bool female;

    /* Constructor */
    //public Pet(string name, int age, bool gender)
    //{
    //    this.name = name;
    //    this.age = age;
    //    this.female = gender;
    //}

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

    private void displayResult(string name,short age, bool female)
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
        temp = Console.ReadLine();
        age = Convert.ToSByte(temp);
        Console.Write("Is your pet a female (y/n)? ");
        temp = Console.ReadLine();

        if(temp == "y")
            female = true;
        else
            female = false;         
    }

}
    
}