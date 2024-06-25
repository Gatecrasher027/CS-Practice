/*Question 1: Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the
original array.
Use a loop to read values from the original array and place them in the new array. Also
print out the contents of both arrays, to be sure everything copied correctly. */

using System;
int[] arr = new int[10];
Random random = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(1, 70);
}
int[] carr = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    carr[i] = arr[i];
}
Console.WriteLine("Original Array: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Copied Array: ");
for (int i = 0; i < carr.Length; i++)
{
    Console.Write(carr[i] + " ");
}

/*Question 2: 
*/
using System;
List<string> itemList = new List<string>();
            
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine();
    
    if (input.StartsWith("+"))
    {
        string itemAdded = input.Substring(2); 
        itemList.Add(itemAdded);
        Console.WriteLine($"Added: {itemAdded}");
    }
    else if (input.StartsWith("-"))
    {
        string itemToRemove = input.Substring(2);
        if (itemList.Remove(itemToRemove))
        {
            Console.WriteLine($"Removed: {itemToRemove}");
        }
        else
        {
            Console.WriteLine($"Item not found: {itemToRemove}");
        }
    }
    else if (input == "--")
    {

        itemList.Clear();
        Console.WriteLine("List cleared.");
    }else
    {
        Console.WriteLine("Invalid command. Please use + to add, - to remove, or -- to clear the list.");
    }
               
    Console.WriteLine("Current list contents:");
    foreach (string item in itemList)
    { Console.WriteLine(item);
    } Console.WriteLine();
}
