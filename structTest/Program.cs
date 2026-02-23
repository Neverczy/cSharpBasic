namespace structTest
{
    #region 结构体描述矩形
    struct Rect
    {
        public float width;
        public float height;
        public Rect(float width,float height)
        {
            this.width = width;
            this.height = height;
        }
        public void GetInfo()
        {
            Console.WriteLine($"长:{this.width},宽:{this.height},面积:{this.width*this.height},周长:{(this.width+this.height)*2}");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(100f,50f);
            rect.GetInfo();
        }
    }
}
