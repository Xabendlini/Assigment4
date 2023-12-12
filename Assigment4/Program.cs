namespace Assigment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 9999)
            {
                Console.WriteLine("Enter the number");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine(Number.ConvertToWords(number));
            }
        }
    }
}
