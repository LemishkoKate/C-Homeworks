namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Матриця 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 101);
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }

            int[] arr = new int[25];
            int index = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    arr[index++] = matrix[i, j];

            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex]) minIndex = i;
                if (arr[i] > arr[maxIndex]) maxIndex = i;
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);
            int sum = 0;

            for (int i = start + 1; i < end; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Min = {arr[minIndex]} (index {minIndex})");
            Console.WriteLine($"Max = {arr[maxIndex]} (index {maxIndex})");
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
