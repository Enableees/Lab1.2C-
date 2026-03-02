namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите элементы:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            bool S = true;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    S = false;
                    break;
                }
            }

            if (S)
                Console.WriteLine("Последовательность упорядочена по возрастанию");
            else
                Console.WriteLine("Последовательность не упорядочена по возрастанию");
        }
    }
}