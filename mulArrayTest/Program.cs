namespace mulArrayTest;

class Program
{
    static void Main(string[] args)
    {
        #region 1.1-1000-赋值给二维数组[100,100]
        // int[,] ma1 = new int[100, 100];
        // int counter = 1;
        // for (int i = 0; i < ma1.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma1.GetLength(1); j++)
        //     {
        //         ma1[i, j] = counter;
        //         counter++;
        //     }
        // }
        // //print
        // for (int i = 0; i < ma1.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma1.GetLength(1); j++)
        //     {
        //         System.Console.Write(ma1[i, j] + ",");
        //     }
        //     System.Console.WriteLine();
        // }
        #endregion

        #region 2.将二维数组4行4列的右上半部分置零
        // int[,] ma2 = new int[4, 4];
        // Random r = new Random();
        // for (int i = 0; i < ma2.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma2.GetLength(1); j++)
        //     {
        //         ma2[i, j] = r.Next(1, 101);
        //     }
        // }
        // //print
        // for (int i = 0; i < ma2.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma2.GetLength(1); j++)
        //     {
        //         System.Console.Write($"{ma2[i, j]}  ");
        //     }
        //     System.Console.WriteLine();
        // }
        // //operation
        // for (int i = 0; i < ma2.GetLength(0) / 2; i++)
        // { //0,1
        //     for (int j = ma2.GetLength(1) / 2; j < ma2.GetLength(1); j++)
        //     {//2,3
        //         ma2[i, j] = 0;
        //     }
        // }
        // System.Console.WriteLine("----------");
        // //print
        // for (int i = 0; i < ma2.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma2.GetLength(1); j++)
        //     {
        //         System.Console.Write($"{ma2[i, j]}  ");
        //     }
        //     System.Console.WriteLine();
        // }
        #endregion

        #region 3.二维数字3行3列对角线元素的和
        //init
        // int[,] ma3 = new int[3, 3];
        // Random r = new Random();
        // for (int i = 0; i < ma3.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma3.GetLength(1); j++)
        //     {
        //         ma3[i, j] = r.Next(1, 11);
        //     }
        // }
        // //print
        // for (int i = 0; i < ma3.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma3.GetLength(1); j++)
        //     {
        //         System.Console.Write($"{ma3[i, j]}  ");
        //     }
        //     System.Console.WriteLine();
        // }
        // //operation
        // int ltrSum = 0;
        // int rtlSum = 0;
        // for (int i = 0; i < ma3.GetLength(0); i++)
        // {
        //     ltrSum += ma3[i, i];
        // }
        // for (int i = 0; i < ma3.GetLength(0); i++)
        // {
        //     rtlSum += ma3[i, ma3.GetLength(0) - 1 - i];
        // }
        // System.Console.WriteLine($"左右对角线和:{ltrSum},右左对角线和:{rtlSum},全和:{ltrSum + rtlSum}");
        #endregion
        //[0,0] [1,1],[2,2]
        //[0,2],[1,1],[2,0]
        #region 4.二位数组5行5列,找最大元素值及其行号(随机1-500)
        // Random r = new Random();
        // int[,] ma4 = new int[5, 5];
        // for (int i = 0; i < ma4.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma4.GetLength(1); j++)
        //     {
        //         ma4[i, j] = r.Next(1, 501);
        //     }
        // }
        // //print
        // for (int i = 0; i < ma4.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma4.GetLength(1); j++)
        //     {
        //         System.Console.Write($"{ma4[i, j]}  ");
        //     }
        //     System.Console.WriteLine();
        // }
        // //operation
        // int maxnum = 0;
        // int indexRow = 0;
        // int indexCol = 0;
        // for (int i = 0; i < ma4.GetLength(0); i++)
        // {
        //     for (int j = 0; j < ma4.GetLength(1); j++)
        //     {
        //         if (maxnum < ma4[i, j])
        //         {
        //             maxnum = ma4[i, j];
        //             indexRow = i;
        //             indexCol = j;
        //         }
        //     }
        // }
        // System.Console.WriteLine($"最大值{maxnum},下标[{indexRow},{indexCol}]");
        #endregion

        #region 5.给m*n行列的二维数组,值0,1,要求含有1的行和列全部转为1
        Random r = new Random();
        int[,] ma5 = new int[r.Next(5, 11), r.Next(5, 11)];
        for (int i = 0; i < ma5.GetLength(0); i++)
        {
            for (int j = 0; j < ma5.GetLength(1); j++)
            {
                ma5[i, j] = r.Next(0, 10);
                ma5[i, j] = ma5[i, j] > 1 ? 0 : ma5[i, j];
                System.Console.Write($"{ma5[i, j]}\t");
            }
            System.Console.WriteLine();
        }
        //operation
        for (int i = 0; i < ma5.GetLength(0); i++)
        {
            for (int j = 0; j < ma5.GetLength(1); j++)
            {
                if (ma5[i, j] == 1)
                {
                    int ii = i;
                    int ij = j;
                    for (int fj = 0; fj < ma5.GetLength(1); fj++)
                    {
                        ma5[ii, fj] = 2;
                    }
                    for (int fi = 0; fi < ma5.GetLength(0); fi++)
                    {
                        ma5[fi, ij] = 2;
                    }
                }
            }
        }
        //print
        System.Console.WriteLine("--------------------");
        for (int i = 0; i < ma5.GetLength(0); i++)
        {
            for (int j = 0; j < ma5.GetLength(1); j++)
            {
                System.Console.Write($"{ma5[i, j]}\t");
            }
            System.Console.WriteLine();
        }
        #endregion
    }
}
