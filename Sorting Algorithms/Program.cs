namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long binær = 1;
            long kinesere = 1425295981;
            int antalDelinger = 0;
            do
            {
                kinesere = (kinesere/2);
                antalDelinger++;
                Console.WriteLine($"Delt {antalDelinger} gange - Kinesere: {kinesere}");
            } while (kinesere > 1);
            Console.WriteLine("Delt " + antalDelinger + " gange.");
        }
    }
}
