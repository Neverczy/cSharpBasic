namespace selectSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
            }

            //ss

            for (int i = 0; i < arr.Length; i++)
            {
                int index = 0;
                for (int j = 1; j < arr.Length - i; j++)
                {
                    if (arr[index] < arr[j])
                    {
                        index = j;
                    }
                }
                if (index != arr.Length - 1 - i)
                {
                    int temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }
    }
}
