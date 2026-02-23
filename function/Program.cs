namespace function
{
    internal class Program
    {
        #region 比较两个数字大小,返回最大值
        static int FindMaxNum(int a, int b)
        {
            return a > b ? a : b;
        }
        #endregion

        #region 计算圆的面积和周长,返回打印
        static float[] CalcCircleMAL(float r)
        {
            return new float[] { (float)(Math.PI * r * r), (float)(2 * r * Math.PI) };
        }
        #endregion

        #region 求一个数组的总和,最大值,最小值,平均值
        static int[] FindArray(int[] arr)
        {
            if (arr.Length == 0) return arr;
            int sum = 0;
            int max = arr[0];
            int min = arr[0];
            //int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                max = max < arr[i] ? arr[i] : max;
                min = min > arr[i] ? arr[i] : min;
            }
            return new int[] { sum, max, min, sum / arr.Length };
        }
        #endregion

        #region 判断传入的参数是不是质数
        static void FindZhiShu(int a)
        {
            if (a <= 1) Console.WriteLine($"{a}不是质数");
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) Console.WriteLine($"{a}不是质数");
            }
            Console.WriteLine($"{a}是质数");
        }
        #endregion



        #region 判断输入的年份是否闰年
        static void FindRunYear(int year)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year}是闰年");
            }
            Console.WriteLine($"{year}不是闰年");
        }
        #endregion

        //ref out
        static bool LoginOpera(string username, string password, out string loginMsg)
        {
            if (username != "admin")
            {
                loginMsg = "用户名错误";
                return false;
            }
            if (password != "password")
            {
                loginMsg = "密码错误";
                return false;
            }
            loginMsg = "登录成功";
            return true;
        }
        //变长参数
        static void showParams(params int[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i]);
            }
        }
        //默认参数
        static void Speak(string str = "nothing to say")
        {
            Console.WriteLine(str);
        }

        //递归打印0-10
        static void RecurPrint10(int a)
        {
            if (a < 0) return;
            Console.WriteLine(a--);
            RecurPrint10(a);
        }
        //竹竿100m,每天砍一半,第十天长度
        static void BoobCut(int day,float bl)
        {
            if (day > 10) return;
            Console.WriteLine($"第{day}天,{bl}米.");
            BoobCut(++day, bl /= 2.0f);
        }
        //传一个值,求阶乘
        static int JieC(int num)
        {
            if (num <= 1) return 1;
            return num * JieC(--num);
        }
        //求一到10的阶乘和
        static int JieSum(int num)
        {
            if (num <= 1) return 1;
            return num * JieSum(--num)+0;
        }
        ////递归打印1-200 不用循环和条件语句
        static bool pring200(int num)
        {
            Console.WriteLine(num);
            return num >= 200 || pring200(++num);
        }
        static void Main(string[] args)
        {
            //xxxxxxxx
            bool flag = LoginOpera("admin", "pasasword", out string loginMsg);
            Console.WriteLine(flag);
            Console.WriteLine(loginMsg);
            showParams();
            showParams(1, 2, 3, 4, 5, 6, 7);
            Speak();
            Speak("666");
            Console.WriteLine("-----递归-----");
            RecurPrint10(10);
            Console.WriteLine("竹子");
            BoobCut(0, 100);
            int jnum = 5;
            Console.WriteLine(JieC(5));
            Console.WriteLine(JieSum(10));
            Console.WriteLine("----- 1-200 -----");
            pring200(1);
        }
    }
}

