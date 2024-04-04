namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            geeks1(x);
            Console.ReadKey();
        }
        static void geeks1(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} "); // First statement.
                geeks1(n - 1); // Second statement.
            }
        }
    }
}
