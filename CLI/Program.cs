namespace CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Errore: devono essere passati due parametri.");
                return;
            }

            string var1 = args[0];
            string var2 = args[1];


            Console.WriteLine($"Il primo parametro è: {var1}");
            Console.WriteLine($"Il secondo parametro è: {var2}");
        }
    }
}