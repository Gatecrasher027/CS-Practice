/*Try creating the two classes below, and make a simple program to work with them, as
described below
Create a Color class:
Create a Ball class:
Write some code in your Main method to create a few balls, throw them around a few
times, pop a few, and try to throw them again, and print out the number of times that the
balls have been thrown.*/

// Color class with the requirements
using System;
public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }
    public int Red
    {
        get { return red; }
        set { red = value; }
    }
    public int Green
    {
        get { return green; }
        set { green = value; }
    }
    public int Blue
    {
        get { return blue; }
        set { blue = value; }
    }
    public int Alpha
    {
        get { return alpha; }
        set { alpha = value; }
    }
    public int Grayscale()
    {
        return (red + green + blue) / 3;
    }
}

// Ball class with requirements

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }
    public void Pop()
    {
        size = 0;
    }
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }
    public int ThrowCount()
    {
        return throwCount;
    }
}

// Main method to throw the ball a few times around 

class Prg
{
    static void Main(string[] args)
    {
        Color redColor = new Color(255, 0, 0);
        Color greenColor = new Color(0, 255, 0);
        Color blueColor = new Color(0, 0, 255);
        Ball redBall = new Ball(45, redColor);
        Ball greenBall = new Ball(18, greenColor);
        Ball blueBall = new Ball(33, blueColor);
        redBall.Throw();
        blueBall.Throw();
        greenBall.Throw();
        redBall.Throw();
        blueBall.Throw();
        blueBall.Throw();
        redBall.Pop();
        blueBall.Pop();
        greenBall.Pop();
        Console.WriteLine($"Threw Red Ball Count: {redBall.ThrowCount()}");
        Console.WriteLine($"Threw Green Ball Count: {greenBall.ThrowCount()}");
        Console.WriteLine($"Threw Blue Ball Count: {blueBall.ThrowCount()}");
    }
}

