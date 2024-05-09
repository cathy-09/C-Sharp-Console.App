namespace task5
{
    internal class Program
    {
        private static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(Console.ReadLine());
            Gen(new string[k], input, 0, 0);
        }
        private static void Gen(string[] vectorCombinations,
            string[] input,
            int originalIndex,
            int customI)
        {
            if (originalIndex >= vectorCombinations.Length)
            {
                Console.WriteLine(string.Join(" ", vectorCombinations));
            }
            else
            {
                for (var i = customI; i < input.Length; i++)
                {
                    vectorCombinations[originalIndex] = input[i];
                    Gen(vectorCombinations, input, originalIndex + 1, i + 1);
                }
            }
        }
    }
}