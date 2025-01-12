// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        var num = int.Parse(args[1]);
        
        System.Console.WriteLine("Hello, " + args[0] + "!");
        System.Console.WriteLine(args[1] + " squared is " + (num * num));
    }
}