namespace HomeWork1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("请输入一个整数");
            string s=Console.ReadLine();
            num=int.Parse(s);
            getVector(num);
        }

        static void getVector(int i)
        {
            string s = "该数的素数因子有：";
            for (int j = 2; j < Math.Sqrt(i); j++) 
            { 
                if (i % j == 0)
                {
                    if (judge(j))
                    {
                        s += j;
                        s+= "  ";
                    }
                }
            }
            Console.WriteLine(s);
        }

        static bool judge(int i)
        {
            for(int j = 2; j < Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}