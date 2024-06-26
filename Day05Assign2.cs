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

/*Question 2: Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop. Each time through the loop, ask the user to perform an
operation, and then show the current contents of their list. The operations available should
be Add, Remove, and Clear.
*/

string[] itemList = new string[55];
int itemCount = 0;
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine();
    if (input.StartsWith("+ "))
    {
        string itemAdded = input.Substring(2);
        itemList[itemCount++] = itemAdded;
        Console.WriteLine($"Added: {itemAdded}");
    }
    else if (input.StartsWith("- "))
    {
        string itemRemoved = input.Substring(2);
        bool found = false;
        for (int i = 0; i < itemCount; i++)
        {
            if (itemList[i] == itemRemoved)
            {
                found = true;
                for (int j = i; j < itemCount - 1; j++)
                {
                    itemList[j] = itemList[j + 1];
                }
                itemList[--itemCount] = null;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine($"Removed: {itemRemoved}");
        }
        else
        {
            Console.WriteLine($"Item not found: {itemRemoved}");
        }
    }
    else if (input == "--")
    {
        Array.Clear(itemList, 0, itemCount);
        itemCount = 0;
        Console.WriteLine("List cleared.");
    }
    else
    {
        Console.WriteLine("Invalid command.");
    }
    Console.WriteLine("List contents:");
    if (itemCount > 0)
    {
        for (int i = 0; i < itemCount; i++)
        {
            Console.WriteLine(itemList[i]);
        }
    }
    else
    {
        Console.WriteLine("List is empty.");
    }
}

/*Question 3: Write a method that calculates all prime numbers in given range and returns them as array
of integers.*/

class Program
{
    static void Main(string[] args)
    {
        int startNum = 4;
        int endNum = 89;
        int[] primes = FindPrimesInRange(startNum, endNum);

        for (int i = 0; i < primes.Length; i++)
        {
            Console.WriteLine(primes[i]);
        }
    }
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        int primeCount = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primeCount++;
            }
        }
        int[] primes = new int[primeCount];
        int index = 0;

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes[index++] = i;
            }
        }
        return primes;
        bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}

/*Question 4: Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1*/

using System;
Console.WriteLine("Enter the elements:");
string[] input = Console.ReadLine().Split();
int[] arr = Array.ConvertAll(input, int.Parse);
Console.WriteLine("Enter the value of k:");
int k = int.Parse(Console.ReadLine());
int n = arr.Length;
int[] sum = new int[n];
for (int r = 1; r <= k; r++)
{
    int[] rotated = new int[n];
    for (int i = 0; i < n; i++)
    {
        rotated[(i + r) % n] = arr[i];
    }
    for (int i = 0; i < n; i++)
    {
        sum[i] += rotated[i];
    }
}
Console.WriteLine("Sum of arrays after each rotation:");
for (int g = 0; g < sum.Length; g++)
{
    Console.WriteLine(sum[g]);
}

/*Question 5: Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one. */

using System;
Console.WriteLine("Enter the elements:");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int loStart = 0;
int loLength = 1;
int cStart = 0;
int cLength = 1;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i - 1])
    {
        cLength++;
    }
    else
    {
        if (cLength > loLength)
        {
            loLength = cLength;
            loStart = cStart;
        }
        cStart = i;
        cLength = 1;
    }
}
if (cLength > loLength)
{
    loLength = cLength;
    loStart = cStart;
}
Console.WriteLine("Longest sequence of equal elements:");
for (int i = 0; i < loLength; i++)
{
    Console.Write(arr[loStart] + " ");
}

/*Question 7: Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them */

using System;
Console.WriteLine("Enter the elements:");
string[] input = Console.ReadLine().Split();
int[] arr = new int[input.Length];
for (int i = 0; i < input.Length; i++)
{
    arr[i] = int.Parse(input[i]);
}
int mostFreqNum = arr[0];
int maxFreq = 1;
for (int i = 0; i < arr.Length; i++)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
    }
    if (count > maxFreq)
    {
        mostFreqNum = arr[i];
        maxFreq = count;
    }
    else if (count == maxFreq)
    {
        for (int k = 0; k < i; k++)
        {
            if (arr[k] == mostFreqNum)
            {
                break;
            }
            if (arr[k] == arr[i])
            {
                mostFreqNum = arr[i];
                break;
            }
        }
    }
}
Console.WriteLine($"The number {mostFreqNum} is the most frequent (occurs {maxFreq} times).");

Practice Strings

/*Question 1: Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways
Convert the string to char array, reverse it, then convert it to string again
Print the letters of the string in back direction (from the last to the first) in a for-loop*/

using System;
Console.WriteLine("Input String:");
string input = Console.ReadLine();
Console.WriteLine("Reversed string:");
for (int i = input.Length - 1; i >= 0; i--)
{
    Console.Write(input[i]);
}

/*Question 2: Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are
considered valid words.
The sentences always start by word and end by separator.*/

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input sentence:");
        string input = Console.ReadLine();
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        string[] parts = SplitInput(input, separators);
        string result = RevW(parts, separators);
        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(result);
    }

    static string[] SplitInput(string input, char[] separators)
    {
        string[] parts = new string[input.Length];
        int partIndex = 0;
        string currPart = "";
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (Array.IndexOf(separators, c) >= 0)
            {
                if (currPart != "")
                {
                    parts[partIndex++] = currPart;
                    currPart = "";
                }
                parts[partIndex++] = c.ToString();
            }
            else
            {
                currPart += c;
            }
        }
        if (currPart != "")
        {
            parts[partIndex++] = currPart;
        }
        Array.Resize(ref parts, partIndex);
        return parts;
    }
    static string RevW(string[] parts, char[] separators)
    {
        string[] words = new string[parts.Length];
        int wordCount = 0;
        for (int i = 0; i < parts.Length; i++)
        {
            if (Array.IndexOf(separators, parts[i][0]) < 0)
            {
                words[wordCount++] = parts[i];
            }
        }
        string result = "";
        int wordIndex = wordCount - 1;
        for (int i = 0; i < parts.Length; i++)
        {
            if (Array.IndexOf(separators, parts[i][0]) >= 0)
            {
                result += parts[i];
            }
            else
            {
                if (wordIndex >= 0)
                {
                    result += words[wordIndex--];
                }
            }
        }
        return result;
    }
}

/*Question 3: Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted*/

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input Sentence:");
        string input = Console.ReadLine();
        string[] wrds = Ext(input);
        string[] pals = new string[wrds.Length];
        int pCnt = 0;

        for (int i = 0; i < wrds.Length; i++)
        {
            if (IsPal(wrds[i]) && !ArrContains(pals, wrds[i], pCnt))
            {
                pals[pCnt++] = wrds[i];
            }
        }
        Array.Sort(pals, 0, pCnt, StringComparer.OrdinalIgnoreCase);
        for (int i = 0; i < pCnt; i++)
        {
            if (i > 0) Console.Write(", ");
            Console.Write(pals[i]);
        }
    }
    static string[] Ext(string input)
    {
        string[] wrds = new string[input.Length];
        int wIdx = 0;
        string currWrd = "";

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (char.IsLetterOrDigit(c))
            {
                currWrd += c;
            }
            else
            {
                if (currWrd != "")
                {
                    wrds[wIdx++] = currWrd;
                    currWrd = "";
                }
            }
        }
        if (currWrd != "")
        {
            wrds[wIdx++] = currWrd;
        }
        Array.Resize(ref wrds, wIdx);
        return wrds;
    }
    static bool IsPal(string wrd)
    {
        int l = 0;
        int r = wrd.Length - 1;
        while (l < r)
        {
            if (char.ToLower(wrd[l]) != char.ToLower(wrd[r]))
            {
                return false;
            }
            l++;
            r--;
        }
        return wrd.Length > 0;
    }
    static bool ArrContains(string[] arr, string val, int cnt)
    {
        for (int i = 0; i < cnt; i++)
        {
            if (string.Equals(arr[i], val, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
}

/*Question 4: Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional.*/

class URLClass
{
    static void Main()
    {
        Console.WriteLine("URL:");
        string url = Console.ReadLine();
        string proto, srv, res;
        PrsURL(url, out proto, out srv, out res);
        Console.WriteLine("[protocol] = \"" + proto + "\"");
        Console.WriteLine("[server] = \"" + srv + "\"");
        Console.WriteLine("[resource] = \"" + res + "\"");
    }
    static void PrsURL(string url, out string proto, out string srv, out string res)
    {
        proto = "";
        srv = "";
        res = "";
        int protoEnd = url.IndexOf("://");
        if (protoEnd != -1)
        {
            proto = url.Substring(0, protoEnd);
            url = url.Substring(protoEnd + 3);
        }
        int resStart = url.IndexOf('/');
        if (resStart != -1)
        {
            srv = url.Substring(0, resStart);
            res = url.Substring(resStart + 1);
        }
        else
        {
            srv = url;
        }
    }
}
