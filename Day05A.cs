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
