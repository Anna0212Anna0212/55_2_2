using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_2_2
{
    internal class Program
    {
        public static bool trfa = true;
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
                if (one > 100 || one < 0 || two < 0 || two > 100)
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
                            Console.WriteLine("最大公因數為：" + i);
                            Console.Write($"最小公倍數為：{(max / i) * (min / i) * i}");
                            break;
                        }
                    }
                    Console.Write("\n公因數為：");
                    for (int i = min; i > 0; i--)
                    {
                        if (max % i == 0 && min % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.Write($"\n{min}公因數為：");
                    for (int i = min; i > 0; i--)
                    {
                        if (min % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.Write($"\n{max}公因數為：");
                    for (int i = max; i > 0; i--)
                    {
                        if (max % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.Write($"\n短除法：\n");
                    int j = 2;
                    for (int i = 2; i < min; i++)
                    {
                        j = 2;
                        trfa = true;
                        do
                        {
                            if (i % j == 0 || j >= i)
                            {
                                trfa = false;
                            }
                            j++;
                        } while (trfa);
                        if (trfa)
                        {
                            while (min % i == 0 && max % i == 0)
                            {
                                for(int k = 0; k < i; k++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write($"{min % i} | {max}  {min}");
                                Console.Write("___________");
                                min /= i;
                                max /= i;
                            }
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
