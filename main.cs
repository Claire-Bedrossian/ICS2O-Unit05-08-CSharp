using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function does division
        double numA;
        double numB;
        double counter = 0;

        Console.Write("This program does division.");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Formula: a / b = c");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Enter value a:");
        numA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value b:");
        numB = Convert.ToDouble(Console.ReadLine());

        double remainder = numA;

        while (remainder >= numB)
        {
            remainder = remainder - numB;
            counter++;
        }
        Console.WriteLine("");
        Console.Write("The sum is " + counter + " R " + remainder + ".");
        Console.WriteLine("");
        Console.Write("/Done");
    }
}