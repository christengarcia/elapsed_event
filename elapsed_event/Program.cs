/*
 * C# Program to Illustrate Elapsed Event
 */
using System;
using System.Timers;
public class Program
{
    private static System.Timers.Timer Tim;
    public static void Main()
    {
        Tim = new System.Timers.Timer(10);
        Tim.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        Tim.Interval = 1000;
        Tim.Enabled = true;
        Console.WriteLine("Press Any Key to Exit else Elapsed Event will be Raised ");
        Console.ReadLine();
    }
}
