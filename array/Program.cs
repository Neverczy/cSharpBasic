namespace array;

class Program
{
    static void Main(string[] args)
    {
        //数组声明方法
        //1.
        int[] arr1;
        //2.
        int[] arr2 = new int[5];
        //3.
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
        //4.
        int[] arr4 = new int[] { 6, 7, 8, 9, 10 };
        //5.
        int[] arr5 = { 1, 2, 3, 4, 5, 6 };

        //数组使用方法
        int[] arr0 = { 50, 60, 70, 80, 90, 100 };
        //1.数组的长度 
        System.Console.WriteLine("*****数组长度*****");
        System.Console.WriteLine($"长度为:{arr0.Length}");
        //2.获取数组中的元素 
        System.Console.WriteLine("*****获取元素*****");
        System.Console.WriteLine($"数组中第2个元素为{arr0[1]}");
        //3.修改数组中的元素
        arr0[1] = 666;
        //4.遍历数组 
        System.Console.WriteLine("*****遍历数组*****");
        for (int i = 0; i < arr0.Length; i++)
        {
            System.Console.WriteLine(arr0[i]);
        }
        //5.增加数组的元素
        System.Console.WriteLine("*****增加数组元素*****");
        int[] aarr = new int[7];
        for (int i = 0; i < arr0.Length; i++)
        {
            aarr[i] = arr0[i];
        }
        arr0 = aarr;
        System.Console.WriteLine("添加后");
        for (int i = 0; i < arr0.Length; i++)
        {
            System.Console.WriteLine(arr0[i]);
        }
        //6.删除数组的元素
        System.Console.WriteLine("*****删除数组元素*****");
        int[] darr = new int[6];
        for (int i = 0; i < darr.Length; i++)
        {
            darr[i] = arr0[i];
        }
        arr0 = darr;
        System.Console.WriteLine("删除后");
        for (int i = 0; i < arr0.Length; i++)
        {
            System.Console.WriteLine(arr0[i]);
        }
        //7.查找数组中的元素
        System.Console.WriteLine("*****查找数组元素*****");
        for (int i = 0; i < arr0.Length; i++)
        {
            if (80 == arr0[i])
            {
                System.Console.WriteLine($"80是位于数组中的第{i}个元素");
            }
        }
    }
}
