namespace myEnum
{

    enum E_Gender
    {
        Male,
        Female
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            E_Gender gender = E_Gender.Male;
            System.Console.WriteLine(gender);
            gender = E_Gender.Female;
            int f = (int)gender;
            System.Console.WriteLine($"{gender}\t{f}");
            //字符串转枚举写法
            gender = (E_Gender)Enum.Parse(typeof(E_Gender), "Male");
            System.Console.WriteLine(gender);
        }
    }
}
