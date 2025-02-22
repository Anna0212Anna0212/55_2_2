using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("輸入第一個數字(0-100)：");
                string onee = Console.ReadLine();
                Console.Write("輸入第二個數字(0-100)：");
                string twoo = Console.ReadLine();
                int one = int.Parse(onee);
                int two = int.Parse(twoo);
                if(one>100||one<0||two<0||two>100)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    int max = one > two ? one : two;
                    int min = one > two ? two : one;
                    for (int i = min; i > 0; i--)
                    {
                        if (max % i == 0 && min % i == 0)
                        {
                            Console.WriteLine("最大公因數為："+i);
                            Console.Write($"最小公倍數為：{(max/i)*(min/i)*i}");
                            break;
                        }
                    }
                    Console.Write("\n公因數為：");
                    for (int i = min; i > 0; i--)
                    {
                        if (max % i == 0 && min % i == 0)
                        {
                             Console.Write(i+" ");
                        }
                    }   
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();
        }
    }
}
