// File Name: MyClass.cs

using System;

public class MyClass
{
    // Class Variables
    private int number;
    private string name;

    // Constructor
    public MyClass(int number, string name)
    {
        this.number = number;
        this.name = name;
    }

    // Properties
    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine("Number: " + Number);
        Console.WriteLine("Name: " + Name);
    }

    // Main Method (entry point of the program)
    public static void Main(string[] args)
    {
        MyClass obj = new MyClass(42, "John");
        obj.DisplayInfo();
    }
}
