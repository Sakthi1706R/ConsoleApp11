// See https://aka.ms/new-console-template for more information


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Enter the number for which you want a multiplication table: ");
//        if (int.TryParse(Console.ReadLine(), out int number))
//        {
//            Console.WriteLine($"\nMultiplication Table for {number}:\n");

//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine($"{number} x {i} = {number * i}");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input! Please enter a valid integer.");
//        }

//        Console.WriteLine("\nPress any key to exit...");
//        Console.ReadKey();
//    }
//}

using System;

// Initialize an array
int[] originalArray = { 1, 2, 3, 4, 5 };

// Display the original array
Console.WriteLine("Original Array:");
foreach (int num in originalArray)
{
    Console.Write(num + " ");
}
Console.WriteLine();

// Specify the item to insert and the index
Console.Write("Enter the value to insert: ");
int itemToInsert = int.Parse(Console.ReadLine());

Console.Write("Enter the index to insert at: ");
int index = int.Parse(Console.ReadLine());

// Check if the index is valid
if (index < 0 || index > originalArray.Length)
{
    Console.WriteLine("Index out of range.");
    return;
}

// Create a new array with one additional size
int[] newArray = new int[originalArray.Length + 1];

// Copy elements to the new array with insertion
for (int i = 0, j = 0; i < newArray.Length; i++)
{
    if (i == index)
    {
        newArray[i] = itemToInsert; // Insert the new item
    }
    else
    {
        newArray[i] = originalArray[j]; // Copy from the original array
        j++;
    }
}

// Display the new array
Console.WriteLine("Array after insertion:");
foreach (int num in newArray)
{
    Console.Write(num + " ");
}

