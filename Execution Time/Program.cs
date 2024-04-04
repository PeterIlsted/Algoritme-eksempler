namespace Execution_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
            }

            watch.Stop();

            Console.WriteLine($"Loop 1 Execution Time: {watch.ElapsedMilliseconds} ms");

            // some code here..

            if (!watch.IsRunning)
                watch.Restart(); // Reset time to 0 and start measuring

            for (int j = 0; j < 100; j++)
            {
                Console.Write(j);
            }

            watch.Stop();
            Console.WriteLine($"Loop 2 Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
