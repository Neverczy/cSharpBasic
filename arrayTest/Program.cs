namespace arrayTest;

class Program
{
    static void Main(string[] args)
    {
        //1.请创建一个一维数组并赋值，让其值与下标一样，长度为100
        // int[] arra = new int[100];
        // for (int i = 0; i < arra.Length; i++)
        // {
        //     arra[i] = i;
        // }
        // for (int i = 0; i < arra.Length; i++)
        // {
        //     System.Console.WriteLine(arra[i]);
        // }
        //2.创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中
        // int[] arrb = arra;
        // for (int i = 0; i < arrb.Length; i++)
        // {
        //     arrb[i] *= 2;
        // }
        // for (int i = 0; i < arrb.Length; i++)
        // {
        //     System.Console.WriteLine(arrb[i]);
        // }
        //3.随机(0~100)生成1个长度为10的整数数组
        // Random r = new Random();
        // int[] arrc = new int[10];
        // for (int i = 0; i < arrc.Length; i++)
        // {
        //     arrc[i] = r.Next(0, 101);
        // }
        // for (int i = 0; i < arrc.Length; i++)
        // {
        //     System.Console.WriteLine(arrc[i]);
        // }
        //4.从一个整数数组中找出最大值、最小值、总合、平均值(可以使用随机数1~100)
        // Random r = new Random();
        // int[] arrd = new int[100];
        // for (int i = 0; i < arrd.Length; i++)
        // {
        //     arrd[i] = r.Next(100, 1000);
        // }
        // System.Console.Write("遍历 : [ ");
        // for (int i = 0; i < arrd.Length; i++)
        // {
        //     System.Console.Write($"{arrd[i]},");
        // }
        // System.Console.WriteLine(" ]");
        // int maxn = arrd[0];
        // int minn = arrd[0];
        // int sumn = 0;
        // int avgn = 0;
        // for (int i = 0; i < arrd.Length; i++)
        // {
        //     if (maxn < arrd[i])
        //     {
        //         maxn = arrd[i];
        //     }
        //     if (minn > arrd[i])
        //     {
        //         minn = arrd[i];
        //     }
        //     sumn += arrd[i];
        // }
        // avgn = sumn / arrd.Length;
        // System.Console.WriteLine($"最大值为 : {maxn}");
        // System.Console.WriteLine($"最小值为 : {minn}");
        // System.Console.WriteLine($"总和值为 : {sumn}");
        // System.Console.WriteLine($"平均值为 : {avgn}");
        //5.交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印
        // int[] arre = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // System.Console.WriteLine("之前");
        // for (int i = 0; i < arre.Length; i++)
        // {
        //     System.Console.Write($"{arre[i]},");
        // }
        // for (int i = 0; i < arre.Length / 2; i++)
        // {
        //     int temp = 0;
        //     temp = arre[i];
        //     arre[i] = arre[arre.Length - 1 - i];
        //     arre[arre.Length - 1 - i] = temp;
        // }
        // System.Console.WriteLine("\n之后");
        // for (int i = 0; i < arre.Length; i++)
        // {
        //     System.Console.Write($"{arre[i]},");
        // }
        /*6.将一个整数数组的每一个元素进行如下的处理:
        如果元素是正数则将这个位置的元素值加1;
        如果元素是负数则将这个位置的元素值减1;
        如果元素是0，则不变*/
        // int[] arrf = { 0, -2, 3, -4, 5, -6, 7, -8 };
        // System.Console.WriteLine("之前");
        // for (int i = 0; i < arrf.Length; i++)
        // {
        //     System.Console.Write($"{arrf[i]},");
        // }
        // System.Console.WriteLine("\n之后");
        // for (int i = 0; i < arrf.Length; i++)
        // {
        //     if (arrf[i] > 0)
        //     {
        //         arrf[i] += 1;
        //     }
        //     else if (arrf[i] < 0)
        //     {
        //         arrf[i] -= 1;
        //     }
        // }
        // for (int i = 0; i < arrf.Length; i++)
        // {
        //     System.Console.Write($"{arrf[i]},");
        // }
        /*7.定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，
        将成绩依次存入数组，然后分别求出最高分和最低分，并且求出10名同学的数学平均成绩*/
        // int[] scores = new int[10];
        // int avgs = 0;
        // int sums = 0;
        // for (int i = 0; i < scores.Length; i++)
        // {
        //     System.Console.Write($"请输入第{i + 1}个同学的成绩 : ");
        //     try
        //     {
        //         int score = int.Parse(Console.ReadLine());
        //         scores[i] = score;
        //     }
        //     catch
        //     {
        //         System.Console.WriteLine("请输入数字!");
        //         --i;
        //     }
        // }
        // System.Console.WriteLine("查看:");
        // for (int i = 0; i < scores.Length; i++)
        // {
        //     System.Console.Write($"{scores[i]},");
        // }
        // System.Console.WriteLine();
        // int maxs = scores[0];
        // int mins = scores[0];
        // for (int i = 0; i < scores.Length; i++)
        // {
        //     if (maxs < scores[i])
        //     {
        //         maxs = scores[i];
        //     }
        //     if (mins > scores[i])
        //     {
        //         mins = scores[i];
        //     }ß
        //     sums += scores[i];
        // }
        // avgs = sums / scores.Length;
        // System.Console.WriteLine($"最高分为 : {maxs}");
        // System.Console.WriteLine($"最低分为 : {mins}");
        // System.Console.WriteLine($"平均分为 : {avgs}");
        //8.声明字符串数字大小25,打印正方形
        string[] stra = { "▪️", "♦️", "▪️", "♦️", "▪️", "♦️", "▪️",
        "♦️", "▪️", "♦️", "▪️", "♦️", "▪️", "♦️", "▪️", "♦️", "▪️",
        "♦️", "▪️", "♦️", "▪️", "♦️", "▪️", "♦️", "▪️" };
        for (int i = 0; i < stra.Length; i++)
        {
            System.Console.Write(stra[i]);
            if ((i + 1) % 5 == 0)
            {
                System.Console.WriteLine();
            }
        }
    }
}
