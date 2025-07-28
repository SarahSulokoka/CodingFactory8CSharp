namespace OutputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10_123_153;
            int num2 = 20_123_153;

            Console.WriteLine("Num: " + num1);
            Console.WriteLine("Num1: {0,6:N2}, Num2 : {1, C2} ", num1, num2);
            Console.WriteLine($"Num1: {num1}, Num2 : {num2}");
        }
    }
}
