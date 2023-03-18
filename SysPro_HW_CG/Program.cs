using SysPro_HW_CG;

internal class Program
{
    private static void Main(string[] args)
    {
        using (TestClass test = new())
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Что-то происходит");
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Опять что-то происходит");

        Console.ForegroundColor = ConsoleColor.White;
    }
}