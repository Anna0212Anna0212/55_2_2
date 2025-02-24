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
                    Console.Write("\n因數為：");
                    for (int i = min; i > 0; i--)
                    {
                        if (max % i == 0 && min % i == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                    Console.Write($"\n{min}因數為：");
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
                    for (int i = 2; i <= min; i++)
                    {
                        bool isPrime = true;
                        int j = 2; // 由 2 開始判斷

                        while (j * j <= i) // 檢查 i 是否為質數
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                            j++;
                        }

                        if (isPrime) // 如果 i 是質數，才用來短除
                        {
                            while (min % i == 0 && max % i == 0)
                            {
                                Console.WriteLine($"{i} | {max} {min}");
                                max /= i;
                                min /= i;
                            }
                        }
                    }

                    Console.WriteLine($"  | {max} {min}"); // 最後剩餘的數
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
