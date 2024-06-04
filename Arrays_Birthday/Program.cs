namespace Arrays_Birthday
{
    internal class Program
    {
        //Задача 1. Да се състави програма, в която се въвежда масив от
        //    оценките на един ученик, пресмята се средния му успех, брой двойки, 
        //    брой тройки, брой четворки, брой петици, брой шестици, минимална и
        //    максимална оценка и се извежда.
        static async void Main(string[] args)
        {
            //arrays for subject
            int[] arrayGrade = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            double average = 0d;
            int min = int.MaxValue;
            int max = int.MinValue;
            int countOverAll = 0;
            int countF = 0;
            int countD = 0;
            int countC = 0;
            int countB = 0;
            int countA = 0;
            for (int i = 0; i < arrayGrade.Length; i++)
            {
                sum += arrayGrade[i];
                countOverAll++;
            }
            average = (double)sum / countOverAll;
            for (int i = 0; i < arrayGrade.Length; i++)
            {
                if (arrayGrade[i] > max)
                {
                    max = arrayGrade[i];
                }
            }
            for (int i = 0; i < arrayGrade.Length; i++)
            {
                if (arrayGrade[i] < min)
                {
                    min = arrayGrade[i];
                }
            }
            for (int i = 0; i < arrayGrade.Length; i++)
            {
                if (arrayGrade[i] == 2)
                {
                    countF++;
                }
                if (arrayGrade[i] == 3)
                {
                    countD++;
                }
                if (arrayGrade[i] == 4)
                {
                    countC++;
                }
                if (arrayGrade[i] == 5)
                {
                    countB++;
                }
                if (arrayGrade[i] == 6)
                {
                    countA++;
                }
            }
            Console.WriteLine($"Average: {Math.Round(average, 2)}");
            Console.WriteLine($"F: {countF}");
            Console.WriteLine($"C: {countC}");
            Console.WriteLine($"D: {countD}");
            Console.WriteLine($"B: {countB}");
            Console.WriteLine($"A: {countA}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}