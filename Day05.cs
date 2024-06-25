1. What type would you choose for the following “numbers”?
A person’s telephone number: String
A person’s height: Float
A person’s age: int
A person’s gender (Male, Female, Prefer Not To Answer): String
A person’s salary: decimal or float
A book’s ISBN: string
A book’s price: float
A book’s shipping weight: float or double
A country’s population: long
The number of stars in the universe: ulong
The number of employees in each of the small or medium businesses in the
United Kingdom (up to about 50,000 employees per business): int
2. What are the difference between value type and reference type variables? What is
boxing and unboxing?
  Value type variables store the actual data whereas the reference type variables store the reference to the objects they may refer to. 
  Value type variables are stored in the stack whereas reference types are stored in the heap section.
  Examples of value type: int, bool, char. Examples of reference type: array, class
  Boxing is converting value type variable to reference type. Example: int i = 20; object o = i;
  Unboxing is converting a reference type variable to a value type. Example: object o = 20; int i = (int)o;
3. What is meant by the terms managed resource and unmanaged resource in .NET
  Managed resources are those that are managed by the .NET runtime's garbage collector.
  Examples: instances of classes, arrays.
  Unmanaged resources are those that are not managed by the garbage collector.
  Examples: file handles, database connections.
4. Whats the purpose of Garbage Collector in .NET?
  The Garbage Collector (GC) in .NET handles automatic memory management by reclaiming memory used by objects that are no longer in use, thereby preventing memory leaks. 
  It tracks object references and periodically frees up memory that is no longer accessible, optimizing the allocation and deallocation of memory in managed applications.

Practice number sizes and ranges
using System;

Console.WriteLine($"The sbyte type uses {sizeof(sbyte)} byte(s) in memory and has a range from {sbyte.MinValue} to {sbyte.MaxValue}."); 
Console.WriteLine($"The byte type uses {sizeof(byte)} byte(s) in memory and has a range from {byte.MinValue} to {byte.MaxValue}."); 
Console.WriteLine($"The short type uses {sizeof(short)} byte(s) in memory and has a range from {short.MinValue} to {short.MaxValue}."); 
Console.WriteLine($"The ushort type uses {sizeof(ushort)} byte(s) in memory and has a range from {ushort.MinValue} to {ushort.MaxValue}."); 
Console.WriteLine($"The int type uses {sizeof(int)} byte(s) in memory and has a range from {int.MinValue} to {int.MaxValue}."); 
Console.WriteLine($"The uint type uses {sizeof(uint)} byte(s) in memory and has a range from {uint.MinValue} to {uint.MaxValue}."); 
Console.WriteLine($"The long type uses {sizeof(long)} byte(s) in memory and has a range from {long.MinValue} to {long.MaxValue}."); 
Console.WriteLine($"The ulong type uses {sizeof(ulong)} byte(s) in memory and has a range from {ulong.MinValue} to {ulong.MaxValue}."); 
Console.WriteLine($"The float type uses {sizeof(float)} byte(s) in memory and has a range from {float.MinValue} to {float.MaxValue}."); 
Console.WriteLine($"The double type uses {sizeof(double)} byte(s) in memory and has a range from {double.MinValue} to {double.MaxValue}."); 
Console.WriteLine($"The decimal type uses {sizeof(decimal)} byte(s) in memory and has a range from {decimal.MinValue} to {decimal.MaxValue}.");

Conversion of Integer Centuries to years, months, days, etc.

using System;

Console.Write("Enter the number of centuries: ");
int centuries = int.Parse(Console.ReadLine());
int years = centuries * 100;
int days = (int)(years * 365);
long hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
long milliseconds = seconds * 1000;
long microseconds = milliseconds * 1000;
long nanoseconds = microseconds * 1000;
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

Controlling Flow and Converting Types
Test your Knowledge
1. What happens when you divide an int variable by 0?
  If we divide an int variable by 0 it results in a System.DivideByZeroException. 
2. What happens when you divide a double variable by 0?
  Dividing double by 0 results in (Infinity or -Infinity) depending on the sign of the numerator. If both the numerator and denominator are zero, the result is NaN.
3. What happens when you overflow an int variable, that is, set it to a value beyond its
range?
  When an int variable overflows, it takes the minimum value. For example, if you increment int.MaxValue by 1, it becomes int.MinValue. If overflow checking is enabled, a System.OverflowException is thrown.
4. What is the difference between x = y++; and x = ++y;?
  x = y++ is (Post-increment) which means that the current value of y is assigned to x, then y is incremented by 1.
  x = ++y is (Pre-increment) which means that y is incremented by 1, then the new value of y is assigned to x.
5. What is the difference between break, continue, and return when used inside a loop
statement?
  break: Exits the loop or switch statement immediately.
  continue: Skips the remaining code in the current iteration of the loop and moves to the next iteration.
  return: Exits the current method and optionally returns a value to the caller, ending the loop and any further execution of the method.
6. What are the three parts of a for statement and which of them are required?
  The three parts of a for statement are:
  Initialization (int i = 0)
  Condition (i < 5)
  Iteration (i++)
  Only the condition part is required. If omitted, the loop runs indefinitely. The initialization and iteration parts are optional but used for clarity and control of the loop.
7. What is the difference between the = and == operators?
  The = operator is the assignment operator, used to assign a value to a variable.
  The == operator is the equality operator, used to compare two values for equality.
8. Does the following statement compile? for ( ; true; ) ;
  Yes, the statement compiles. It represents an infinite loop because the condition true always evaluates to true.
9. What does the underscore _ represent in a switch expression?
  The underscore _ in a switch expression represents a default case. It matches any value that has not been matched by previous case patterns.
10. What interface must an object implement to be enumerated over by using the foreach statement?
  To be enumerated over by using the foreach statement, an object must implement the IEnumerable interface or IEnumerable<T> interface for collections.

Practice Loops and Operators
using System;
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

What will happen if this code executes?
  The loop prints numbers from 0 to 255 and then starts again from 0, printing indefinitely due to the overflow.
What code could you add (don’t change any of the preceding code) to warn us about the
problem?
  int max = 500;
  for (byte i = 0; i < max; i++)
  {
      Console.WriteLine(i);
      if (i == byte.MaxValue)
      {
          Console.WriteLine("Warning Overflow");
          break;
      }
  }
  This will break the loop when i becomes 256 and give a warning.

Random Number Generator and Guess the Number

  int correctNumber = new Random().Next(3) + 1;        
  Console.WriteLine("Guess the number (between 1 and 3):");
  int guessedNumber = int.Parse(Console.ReadLine());
  if (guessedNumber < 1 || guessedNumber > 3)
  {
      Console.WriteLine("Your guess is outside the valid range of numbers (1 to 3).");
  }
  else if (guessedNumber < correctNumber)
  {
      Console.WriteLine("Your guess is too low.");
  }
  else if (guessedNumber > correctNumber)
  {
      Console.WriteLine("Your guess is too high.");
  }
  else
  {
      Console.WriteLine("Correct number.");
  }

Print-a-Pyramid

using System;
Console.Write("Number of lines for the pyramid: ");
int lines = int.Parse(Console.ReadLine());
for (int i = 1; i <= lines; i++)
{
    for (int j = 0; j < lines - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < (2 * i - 1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

3. Write a program that generates a random number between 1 and 3....
  Already done above.

4. Write a program that defines a variable representing birthdate and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);

  using System;
  Console.Write("Enter your birth date (yyyy-mm-dd): ");
  DateTime birthDate = DateTime.Parse(Console.ReadLine());
  DateTime currentDate = new DateTime(2024, 6, 25);
  int ageInDays = (currentDate - birthDate).Days;
  int daysToNextAnniversary = 10000 - (ageInDays % 10000);
  DateTime nextAnniversaryDate = currentDate.AddDays(daysToNextAnniversary);
  Console.WriteLine($"You are {ageInDays} days old.");
  Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversaryDate.ToShortDateString()}.");

5. Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings:
"Good Morning"
"Good Afternoon"
"Good Evening"
"Good Night"
It's up to you which times should serve as the starting and ending ranges for each of the
greetings. If you need a refresher on how to get the current time, see DateTime
Formatting. When testing your program, you'll probably want to use a DateTime variable
you define, rather than the current time. Once you're confident the program works
correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
assign DateTime.Now as its value, which is often a better approach)

  using System;
  DateTime currentTime = DateTime.Now;
  int currentHour = currentTime.Hour;
  if (currentHour >= 5 && currentHour < 12)
  {
      Console.WriteLine("Good Morning");
  }
  if (currentHour >= 12 && currentHour < 17)
  {
      Console.WriteLine("Good Afternoon");
  }
  if (currentHour >= 17 && currentHour < 21)
  {
      Console.WriteLine("Good Evening");
  }
  if ((currentHour >= 21 && currentHour <= 23) || (currentHour >= 0 && currentHour < 5))
  {
      Console.WriteLine("Good Night");
  }

6. Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
loop control variable/ from the outer loop. This means the incrementing in the /
afterthought/ expression will be based on a variable.

  using System;
  for (int increment = 1; increment <= 4; increment++)
  {
      for (int i = 0; i <= 24; i += increment)
      {
          Console.Write(i);
          if (i + increment <= 24)
          {
              Console.Write(", ");
          }
      }
      Console.WriteLine();
  }
