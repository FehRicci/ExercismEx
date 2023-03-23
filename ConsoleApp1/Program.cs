using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine(Identifier.Clean("my   Id"));
        Console.WriteLine(Identifier.Clean("my\0Id"));
        Console.WriteLine(Identifier.Clean("à-ḃç"));
        Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
        Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));
        Console.WriteLine(Identifier.Clean("a-bc"));


    }
}