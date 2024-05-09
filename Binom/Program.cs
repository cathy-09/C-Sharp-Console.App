namespace task7
{
    internal class Program
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Binom(n, k));
        }
        private static ulong Binom(int n, int k)
        {
            if (k > n)
            {
                return 0;
            }

            if (k == 0 || k == n)
            {
                return 1;
            }
            return Binom(n - 1, k - 1) + Binom(n - 1, k);
        }
    }
}