namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");
            //声明方法
            //1.
            int[][] jarr1;
            //2
            int[][] jarr2 = new int[2][];
            //3
            int[][] jarr3 = new int[2][]{ [1, 2, 3], [4,5] };
            //4
            int[][] jarr4 = { [1, 2, 3], [4, 5], [6] };
            //数组长度
            Console.WriteLine(jarr4.GetLength(0));
            Console.WriteLine(jarr4[1].Length);
            //遍历
            for (int i = 0; i < jarr4.GetLength(0); i++)
            {
                for(int j =0;j < jarr4[i].Length;j++)
                {
                    Console.Write($"{jarr4[i][j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
