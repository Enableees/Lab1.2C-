namespace Lab1._2
{
    public class Logic
    {
        public static bool CheckOrder(int[] arr)
        {
            bool S = true;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    S = false;
                    break;
                }
            }

            return S;
        }

        public static string GetResultMessage(bool S)
        {
            if (S)
                return "Последовательность упорядочена по возрастанию";
            else
                return "Последовательность не упорядочена по возрастанию";
        }
    }

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

            bool S = Logic.CheckOrder(arr);
            string resultMessage = Logic.GetResultMessage(S);

            Console.WriteLine(resultMessage);
        }
    }
}