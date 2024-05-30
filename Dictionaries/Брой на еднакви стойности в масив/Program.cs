namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> result = new Dictionary<double, int>();
            foreach (var item in nums)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result[item] = 1;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times.");
            }
        }
    }
}