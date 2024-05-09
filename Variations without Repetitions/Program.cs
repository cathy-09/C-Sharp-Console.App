namespace task3
{
    internal class Program
    {
        private static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(Console.ReadLine());
            Gen(input, new string[k], new bool[input.Length], k, 0);
        }

        private static void Gen(string[] input,
            string[] vectorVariations,
            bool[] used,
            int k,
            int index)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", vectorVariations));
            }
            else
            {
                for (var i = 0; i < input.Length; i++)
                {
                    if (used[i])
                    {
                        continue;
                    }
                    used[i] = true;
                    vectorVariations[index] = input[i];
                    Gen(input, vectorVariations, used, k, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}