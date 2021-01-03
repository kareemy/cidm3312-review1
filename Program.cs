using System;
using System.Collections.Generic; // Needed to use lists

namespace Review
{
    class Program
    {
        // The method named Instructions
        // This method returns void (nothing) and takes one parameter - a string name
        static void Instructions(string name)
        {
            Console.WriteLine($"Hello, {name}. Here are the instructions.");
        }

        // This method is named Product. It returns an int
        // It accepts two int parameters x and y
        static int Product(int x, int y)
        {
            return x * y; // Returns x * y
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 10;
            int[] myArray = {10, 20, 30};

            // Creating a new empty list called yyList
            // myList can only store ints
            List<int> myList = new List<int>();

            // Another list created with an initializer list.
            // This list stores strings
            List<string> listOfStrings = new List<string>() {"red", "yellow", "green"};

            // Loop through the list using an foreach loop
            // string element represents each item in the list - a string
            // foreach can only read the contents of a list, it cannot modify them
            foreach (string element in listOfStrings)
            {
                Console.WriteLine(element);
            }

            // A for loop can also be used. It can also modify a string
            for (int i = 0; i < listOfStrings.Count; i++)
            {
                Console.WriteLine(listOfStrings[i]);
                listOfStrings[i] = "purple"; // Example of modifying the list
            }

            // Add or Remove elements in a string with the .Add() and .Remove() methods
            listOfStrings.Add("blue");
            listOfStrings.Remove("blue");

            // Here we use .Contains() to check if a specific element is in a list or not
            // .Contains() returns true if the element is in the list, otherwise false
            if (listOfStrings.Contains("red"))
            {
                Console.WriteLine("red is in your list!");
            }
            else
            {
                Console.WriteLine("red is not in the list!");
            }

            // .Clear() will empty a list
            listOfStrings.Clear();

            // .Count is a property that will return the number of items or elements in the list
            Console.WriteLine($"List of strings contains {listOfStrings.Count} elements");

            // Finally - we call all our methods here
            Instructions("Kareem");

            int result = Product(2, 5);
            Console.WriteLine(result);
        }
    }
}
