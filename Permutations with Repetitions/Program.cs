namespace task2
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
                HashSet<string> hashSet = new HashSet<string>
                {
                    permutate[index]
                };
                for (var i = index + 1; i < permutate.Length; i++)
                {
                    if (hashSet.Contains(permutate[i]))
                    {
                        continue;
                    }

                    hashSet.Add(permutate[i]);
                    Swap(i, index, permutate);
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