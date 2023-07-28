namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 5;

            if (number < 0)
            {
                Console.WriteLine(number);
            }
            else if (number > 0 && number < 10)
            {
                Console.WriteLine(++number);
            }
            else if (number > 10)
            {

                Console.WriteLine(--number);
            }

            else
            { Console.WriteLine("Sagol"); }
        }

    }
}