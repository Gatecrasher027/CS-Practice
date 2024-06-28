/*Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.*/

using System;
class Prg
{
    static void Main(string[] args)
    {
        Console.Write("How many elements in the array?");
        string ele = Console.ReadLine();
        int[] numbers = GenerateNumbers(int.Parse(ele));
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

/* Question 2: The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. So
the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
number: 2 + 3 = 5. This keeps going forever.
The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
Because one number is defined by the numbers before it, this sets up a perfect
opportunity for using recursion.
Your mission, should you choose to accept it, is to create a method called Fibonacci, which
takes in a number and returns that number of the Fibonacci sequence. So if someone calls
Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
someone calls Fibonacci(8), it would return 21.
In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
sequence and print them out. */

using System;

class Prg
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"({i}) = {Fibonacci(i)}");
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
