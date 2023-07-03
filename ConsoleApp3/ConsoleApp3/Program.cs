
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pleas Enter number1:");
            string number1 = Console.ReadLine();
            Console.WriteLine("please Enter number2:");
            string number2 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int num2 = Convert.ToInt32(number2);
            int sum = num1 + num2;
            Console.WriteLine("Is sum:" + sum);

        }
    }
}