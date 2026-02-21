namespace enum_test;

enum E_Qstate
{
    online,
    hide,
    offline
}
enum E_CoffeeType
{
    medium,
    big,
    large
}
class Program
{
    static void Main(string[] args)
    {
        #region qq state
        //定义 QQ 状态的枚举，并提示用户选择一个在线状态，我们接受输入的数字，并将其转换成枚举类型
        // while (true)
        // {
        //     Console.Clear();
        //     System.Console.Write("please input state : ");
        //     try
        //     {
        //         E_Qstate Qstate;
        //         int iptn = int.Parse(Console.ReadLine());
        //         Qstate = (E_Qstate)iptn;
        //         System.Console.WriteLine($"Current State is : {Qstate}");
        //         Console.ReadKey();
        //     }
        //     catch
        //     {
        //         System.Console.WriteLine("require input a number");
        //     }

        // }
        #endregion
        #region buy coffee
        //用户去星巴克买咖啡，分为中杯（35元），大杯（40元），超大杯（43元），
        // 请用户选择要购买的类型，用户选择后，打印：您购买了xxx咖啡，花费了xx元 
        // 如：你购买了中杯咖啡，花费了35元
        while (true)
        {
            Console.Clear();
            System.Console.Write("Menu\n0.medium\n1.big\n2.large\nPlease Select :");
            try
            {
                int iptn = int.Parse(Console.ReadLine());
                E_CoffeeType coffeeType = (E_CoffeeType)iptn;
                switch (coffeeType)
                {
                    case E_CoffeeType.medium:
                        System.Console.WriteLine($"you bought {coffeeType},cost 35$");
                        break;
                    case E_CoffeeType.big:
                        System.Console.WriteLine($"you bought {coffeeType},cost 40$");
                        break;
                    case E_CoffeeType.large:
                        System.Console.WriteLine($"you bought {coffeeType},cost 43$");
                        break;
                    default:
                        System.Console.WriteLine("coffee not included");
                        break;
                }
            }
            catch
            {
                System.Console.WriteLine("require input a number");
            }
            Console.ReadKey();
        }
        #endregion
    }
}
