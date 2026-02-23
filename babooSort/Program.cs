namespace babooSort
{
    internal class Program
    {
        static int[] BabooSort(int[] arr, bool queue = true)
        {
            int[] arr1 = arr;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length - 1 - i; j++)
                {
                    if (queue? arr1[j] > arr1[j + 1]: arr1[j] < arr1[j + 1])
                    {
                        arr1[j] = arr1[j] + arr1[j + 1];
                        arr1[j + 1] = arr1[j] - arr1[j + 1];
                        arr1[j] = arr1[j] - arr1[j + 1];
                    }
                }
            }
            return arr1;
        }
        static void testc(int[] arr)
        {
            arr[0] = 999;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
            }
            //print
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine();
            //opera true
            int[] tarr = BabooSort(arr, true);
            //print
            for (int i = 0; i < tarr.Length; i++)
            {
                Console.Write($"{tarr[i]}  ");
            }
            Console.WriteLine();
            tarr = BabooSort(arr, false);
            //print
            for (int i = 0; i < tarr.Length; i++)
            {
                Console.Write($"{tarr[i]}  ");
            }
            Console.WriteLine();
        }
    }
}
