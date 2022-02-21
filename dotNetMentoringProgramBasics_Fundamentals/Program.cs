public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
            Console.WriteLine("Please, enter your name");

        var name = string.Join(' ', args);

        Console.WriteLine($"Hello, {name}");

        Console.WriteLine(HelloWorldLib.HelloWorldHelper.SayHello(name));
    }
}

