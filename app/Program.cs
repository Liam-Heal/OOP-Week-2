using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Greeter.Greeting("Liam Healey", "105923500"));
    }
}

public static class Greeter
{
    public static string Greeting(string name, string id)
    {
        return $"{name}, {id}!";
    }
}
