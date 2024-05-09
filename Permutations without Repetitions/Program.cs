namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split();
            GeneratePermutate(0, elements);
        }
        public static void GeneratePermutate(int index, string[] permutate)
        {
            if (index >= permutate.Length)
            {
                Console.WriteLine(string.Join(" ", permutate));
            }
            else
            {
                GeneratePermutate(index + 1, permutate);

                for (int i = index + 1; i < permutate.Length; i++)
                {
                    Swap(index, i, permutate);
                    GeneratePermutate(index + 1, permutate);
                    Swap(i, index, permutate);
                }
            }
            static void Swap(int i, int j, string[] permutate)
            {
                string temp = permutate[i];
                permutate[i] = permutate[j];
                permutate[j] = temp;
            }
        }
    }
}
