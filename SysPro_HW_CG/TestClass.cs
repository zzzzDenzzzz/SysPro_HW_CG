namespace SysPro_HW_CG
{
    internal class TestClass : IDisposable
    {
        public TestClass()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("I am an object of class TestClass");
        }
        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GC dispose object of class TestClass");
        }
    }
}
