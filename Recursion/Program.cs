namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long fibonacci = Fibonacci(n);
            Console.WriteLine("Fibonacci: " + fibonacci);

            int num = int.Parse(Console.ReadLine());
            long factorial = Factorial(num);
            Console.WriteLine("Factorial: " + factorial);

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int nodDevide = NODDevide(number1, number2);
            Console.WriteLine("Nod Devide: " + nodDevide);

            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            int nodSubtraction = NODSubtraction(number3, number4);
            Console.WriteLine("Nod Subtraction: " + nodSubtraction);

            //int N = int.Parse(Console.ReadLine());
            //DecimalToBinarySystem(N);
        }
        public static int NODDevide(int number1, int number2)
        {
            if (number2 == 0)
            {
                return number1;
            }
            return NODDevide(number2, number1 % number2);
        }
        public static int NODSubtraction(int number1, int number2)
        {
            if (number1 == number2)
            {
                return number1;
            }
            if (number1 > number2)
            {
                return NODSubtraction(number1 - number2, number2);
            }
            return NODSubtraction(number1, number2 - number1);
        }
        public static long Fibonacci(int n)
        {
            if (n == 1 || n == 2) 
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static long Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1); 
        }
        public static void DecimalToBinarySystem(int n)
        {
            if (n == 0)
            {
                Console.Write('0');
            }
            DecimalToBinarySystem(n / 2);
            Console.Write(n % 2);
        }
    }
}