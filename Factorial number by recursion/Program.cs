namespace Factorial_number_by_recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            Console.WriteLine($"The factorial  of { x} is { factorial(x) }"); 
            Console.ReadKey();
        }
        static int factorial(int num)
        {
            if (num == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (num * factorial(num - 1));
            }
        }
    }
}
