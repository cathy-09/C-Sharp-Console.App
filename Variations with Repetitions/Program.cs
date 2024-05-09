namespace task4
{
    internal class Program
    {
        private static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(Console.ReadLine());
            int[] vectorVariations = new int[k];
            while (true)
            {
                Print(vectorVariations, input);
                int index = k - 1;
                while (index >= 0 && vectorVariations[index] == input.Length - 1)
                {
                    index--;
                }
                if (index < 0)
                {
                    break;
                }
                vectorVariations[index]++;
                for (var i = index + 1; i < vectorVariations.Length; i++)
                {
                    vectorVariations[i] = 0;
                }
            }
        }

        private static void Print(int[] vectorVariations, string[] input)
        {
            foreach (var index in vectorVariations)
            {
                Console.Write(input[index] + " ");
            }
            Console.WriteLine();
        }
    }
}