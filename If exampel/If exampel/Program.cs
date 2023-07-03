namespace If_exampel
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("Pleas Enter Name:");
            name = Console.ReadLine();
            name = name.ToLower();
            if (name == "Mahshid") 
            {
                Console.WriteLine("Hello Mahshid Behmanesh...");
                Console.WriteLine("Is boss");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Hello User...");
            }
            
        }
    }
}