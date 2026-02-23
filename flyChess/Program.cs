using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using Color = System.ConsoleColor;
namespace flyChess
{
    internal class Program
    {
        #region 全局变量声明
        //游戏初始化
        static int width = 50;
        static int height = 30;
        static E_GameScene nowScene = E_GameScene.Select;
        //■ □ ‖ ● ¤ ★ ▲ ◎
        #endregion       

        #region 枚举变量声明
        enum E_GameScene
        {
            Select,
            Play,
            End,
        }
        enum E_GridType
        {
            Normal,
            Pause,
            Boob,
            Tunnel
        }

        enum E_PlayerType
        {
            Player,
            Computer
        }
        #endregion

        #region 结构体声明
        struct Vector2
        {
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct Grid
        {
            public E_GridType gType;
            public Vector2 pos;
            public Grid(E_GridType type, int x, int y)
            {
                gType = type;
                this.pos.x = x;
                this.pos.y = y;
            }
            public void Draw()
            {
                switch (gType)
                {
                    case E_GridType.Normal:
                        SetMsgInPosition(pos.x, pos.y, "□", Color.White);
                        break;
                    case E_GridType.Pause:
                        SetMsgInPosition(pos.x, pos.y, "‖", Color.Blue);
                        break;
                    case E_GridType.Boob:
                        SetMsgInPosition(pos.x, pos.y, "●", Color.Red);
                        break;
                    case E_GridType.Tunnel:
                        SetMsgInPosition(pos.x, pos.y, "¤", Color.Yellow);
                        break;
                }
            }
        }

        struct Map
        {
            public Grid[] grid;
            public Map(int initx, int inity, int length)
            {
                grid = new Grid[length];
                Random r = new Random();
                int indexx = 0;
                int indexy = 0;
                int stepNum = 2;
                for (int i = 0; i < length; i++)
                {
                    int rNum = r.Next(1, 101);
                    if (rNum <= 85 || i == 0 || i == length - 1)
                    {
                        grid[i].gType = E_GridType.Normal;
                    }
                    else if (rNum > 85 && rNum <= 90)
                    {
                        grid[i].gType = E_GridType.Boob;
                    }
                    else if (rNum > 90 && rNum <= 95)
                    {
                        grid[i].gType = E_GridType.Pause;
                    }
                    else if (rNum > 95 && rNum <= 100)
                    {
                        grid[i].gType = E_GridType.Tunnel;
                    }
                    grid[i].pos = new Vector2(initx, inity);
                    if (indexx == 10)
                    {
                        inity += 1;
                        indexy++;
                        if (indexy == 2)
                        {
                            indexx = 0;
                            indexy = 0;
                            stepNum = -stepNum;
                        }
                    }
                    else
                    {
                        initx += stepNum;
                        ++indexx;
                    }
                }
            }
            public void DrawMap()
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    grid[i].Draw();
                }
            }
        }

        struct Player
        {
            public int nowIndex;
            public E_PlayerType pType;
            public int isPause;
            public Player(int index, E_PlayerType type)
            {
                nowIndex = index;
                pType = type;
                isPause = 0;
            }
            public void Draw(Map map)
            {
                Grid g = map.grid[nowIndex];
                switch (pType)
                {
                    case E_PlayerType.Player:
                        SetMsgInPosition(g.pos.x, g.pos.y, "★", Color.Cyan);
                        break;
                    case E_PlayerType.Computer:
                        SetMsgInPosition(g.pos.x, g.pos.y, "▲", Color.Magenta);
                        break;
                }
            }
        }
        #endregion

        #region 游戏初始化设置控制台函数
        static void GameInit()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
        }
        #endregion
        #region 游戏更新函数
        static void GameUpdate()
        {


            while (true)
            {
                Console.Clear();
                switch (nowScene)
                {
                    case E_GameScene.Select:
                        GameSelectScene();
                        break;
                    case E_GameScene.Play:
                        GamePlayScene();
                        break;
                    case E_GameScene.End:
                        GameEndScene();
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 游戏选择场景
        static void GameSelectScene()
        {
            int flag = 0;
            SetMsgInPosition(width / 2 - 3, 6, "飞行棋");
            SetMsgInPosition(12, height - 1, "W : 上一选项  S : 下一选项  F : 确认");
            while (true)
            {
                SetMsgInPosition(width / 2 - 4, 10, "开始游戏", flag == 0 ? Color.Red : Color.White);
                SetMsgInPosition(width / 2 - 4, 12, "结束游戏", flag == 1 ? Color.Red : Color.White);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.F:
                        switch (flag)
                        {
                            case 0:
                                nowScene = E_GameScene.Play;
                                return;
                            case 1:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                    case ConsoleKey.S:
                        flag = ++flag > 1 ? 1 : flag;
                        break;
                    case ConsoleKey.W:
                        flag = --flag < 0 ? 0 : flag;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 游戏游玩场景
        static void GamePlayScene()
        {
            //画竖
            for (int i = 0; i < height; i++)
            {
                SetMsgInPosition(0, i, "■", Color.Red);
                SetMsgInPosition(width - 2, i, "■", Color.Red);
            }
            //画行
            for (int i = 2; i < width - 2; i += 2)
            {
                SetMsgInPosition(i, 0, "■", Color.Red);
                SetMsgInPosition(i, height - 11, "■", Color.Red);
                SetMsgInPosition(i, height - 6, "■", Color.Red);
                SetMsgInPosition(i, height - 1, "■", Color.Red);
            }
            //画提示
            SetMsgInPosition(2, height - 10, "□:普通棋盘", Color.White);
            SetMsgInPosition(2, height - 9, "‖:暂停[暂停1回合]", Color.Blue);
            SetMsgInPosition(26, height - 9, "●:炸弹[倒退5格]", Color.Red);
            SetMsgInPosition(2, height - 8, "¤:时空隧道[随机倒退,暂停或交换双方位置]", Color.Yellow);
            SetMsgInPosition(2, height - 7, "★:玩家", Color.Cyan);
            SetMsgInPosition(17, height - 7, "▲:电脑", Color.Magenta);
            SetMsgInPosition(32, height - 7, "◎:玩家电脑重合", Color.Green);
            SetMsgInPosition(2, height - 5, "按任意键[玩家]掷骰子", Color.Cyan);

            Map map = new Map(width / 2 - 11, 2, 96);
            map.DrawMap();
            Player player = new Player(0, E_PlayerType.Player);
            Player computer = new Player(0, E_PlayerType.Computer);
            DrawPlayers(player, computer, map);
            bool isWin = false;
            while (true)
            {
                isWin = DicePlay(ref player, map, ref computer);
                if (isWin)
                {
                    SetMsgInPosition(2, height - 5, "[玩家]到达终点,游戏胜利!", Color.Cyan);
                    SetMsgInPosition(2, height - 4, new string(' ', width - 4));
                    SetMsgInPosition(2, height - 4, "按任意键结束游戏", Color.White);
                    Console.ReadKey(true);
                    break ;
                }
                ;
                isWin = DicePlay(ref computer, map, ref player);
                if (isWin)
                {
                    SetMsgInPosition(2, height - 5, "[电脑]到达终点,游戏失败!", Color.Magenta);
                    SetMsgInPosition(2, height - 4, new string(' ', width - 4));
                    SetMsgInPosition(2, height - 4, "按任意键结束游戏", Color.White);
                    Console.ReadKey(true);
                    break;
                }
            }
            nowScene = E_GameScene.End;
        }
        #endregion

        #region 显示封装函数
        static void SetMsgInPosition(int x, int y, string msg, Color color = Color.White, bool isResetColor = true)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(msg);
            if (isResetColor) Console.ForegroundColor = Color.White;
        }
        #endregion

        #region 玩家电脑绘制
        static void DrawPlayers(Player player, Player computer, Map map)
        {
            if (player.nowIndex == computer.nowIndex)
            {
                Grid g = map.grid[player.nowIndex];
                SetMsgInPosition(g.pos.x, g.pos.y, "◎", Color.Green);
            }
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }
        }
        #endregion

        #region 掷骰子玩游戏
        static bool DicePlay(ref Player p, Map m, ref Player other)
        {
            if (p.isPause == 0)
            {
                string msg = p.pType == E_PlayerType.Player ? "玩家" : "电脑";
                Color c = p.pType == E_PlayerType.Player ? Color.Cyan : Color.Magenta;
                SetMsgInPosition(2, height - 5, $"按任意键[{msg}]掷骰子", c);
                Console.ReadKey(true);
                Random dice = new Random();
                int point = dice.Next(1, 7);
                if (p.nowIndex + point > m.grid.Length - 1)
                {
                    p.nowIndex = m.grid.Length - 1;
                }
                else
                {
                    p.nowIndex += point;
                }
                
                SetMsgInPosition(2, height - 4, $"[{msg}]掷出了{point}点,", c);
                switch (m.grid[p.nowIndex].gType)
                {
                    case E_GridType.Normal:
                        SetMsgInPosition(2, height - 3, new string(' ', width - 4));
                        SetMsgInPosition(2, height - 3, $"[{msg}]到达了安全的位置!,", c);
                        break;
                    case E_GridType.Pause:
                        SetMsgInPosition(2, height - 3, new string(' ', width - 4));
                        SetMsgInPosition(2, height - 3, $"[{msg}]暂停行动一回合!,", c);
                        p.isPause++;
                        break;
                    case E_GridType.Boob:
                        SetMsgInPosition(2, height - 3, new string(' ', width - 4));
                        SetMsgInPosition(2, height - 3, $"[{msg}]踩到了炸弹,后退5格!,", c);
                        p.nowIndex -= 5;
                        if (p.nowIndex < 0)
                        {
                            p.nowIndex = 0;
                        }
                        break;
                    case E_GridType.Tunnel:
                        int rA = dice.Next(0, 3);
                        string tunnelMsg = "";
                        switch (rA)
                        {
                            case 0:
                                int backGrid = dice.Next(3, 9);
                                tunnelMsg = $"后退{backGrid}格";
                                p.nowIndex -= backGrid;
                                if (p.nowIndex <0)
                                {
                                    p.nowIndex = 0;
                                }
                                break;
                            case 1:
                                int pauseTurn = dice.Next(1, 4);
                                tunnelMsg = $"暂停{pauseTurn}回合";
                                p.isPause += pauseTurn;
                                break;
                            case 2:
                                tunnelMsg = $"[玩家]与[电脑]交换位置";
                                int temp = 0;
                                temp = p.nowIndex;
                                p.nowIndex = other.nowIndex;
                                other.nowIndex = temp;
                                break;
                        }
                        SetMsgInPosition(2, height - 3, new string(' ', width - 4));
                        SetMsgInPosition(2, height - 3, $"[{msg}]触发了时空隧道,{tunnelMsg}!,", c);
                        break;
                }
                m.DrawMap();
                DrawPlayers(p, other, m);
                if (p.nowIndex == m.grid.Length - 1)
                {
                    SetMsgInPosition(2, height - 3, new string(' ', width - 4));
                    SetMsgInPosition(2, height - 3, $"[{msg}]到达了终点!,", c);
                    return true;
                } 
                else return false;
            }
            else
            {
                p.isPause--;
                return false;
            }
        }
        #endregion

        #region 游戏结束场景
        static void GameEndScene()
        {
            int flag = 0;
            SetMsgInPosition(width / 2 - 4, 6, "游戏结束");
            SetMsgInPosition(12, height - 1, "W : 上一选项  S : 下一选项  F : 确认");
            while (true)
            {
                SetMsgInPosition(width / 2 - 5, 10, "回到主菜单", flag == 0 ? Color.Red : Color.White);
                SetMsgInPosition(width / 2 - 4, 12, "退出游戏", flag == 1 ? Color.Red : Color.White);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.F:
                        switch (flag)
                        {
                            case 0:
                                nowScene = E_GameScene.Select;
                                return;
                            case 1:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                    case ConsoleKey.S:
                        flag = ++flag > 1 ? 1 : flag;
                        break;
                    case ConsoleKey.W:
                        flag = --flag < 0 ? 0 : flag;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            GameInit();
            GameUpdate();
        }
    }
}
