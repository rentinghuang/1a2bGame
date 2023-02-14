using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1a2b遊戲
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[4];//設定陣列儲存
            for (int i = 0; i < 4; i++)
            {
                int num = random.Next(0, 9);
                while (Array.IndexOf(numbers, num) >= 0)//讓數字不重複
                {
                    num = random.Next(0, 9);
                }
                numbers[i] = num;
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～\r\n");
            Console.WriteLine("------");
            while (true)
            {
                Console.Write("請輸入 4 個數字：");
                string input = Console.ReadLine();
                int[] guess = new int[4];//設定陣列儲存
                for (int i = 0; i < 4; i++)
                {
                    guess[i] = int.Parse(input[i].ToString());

                }


                int A = 0;
                int B = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == numbers[i])
                    {
                        A++;
                    }
                    else if (Array.IndexOf(numbers, guess[i]) >= 0)
                    {
                        B++;
                    }
                }

                if (A == 4)
                {
                    Console.WriteLine("恭喜您，猜對了！");
                    Console.WriteLine("你要繼續玩嗎？(y/n):");
                    string no = Console.ReadLine();
                    if (no == "n")
                    {
                        Console.WriteLine("遊戲結束，下次再來玩喔～");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"判定結果：{A}A{B}B");
                    Console.WriteLine("------");
                }
            }

            Console.ReadLine();
        }
    }
}
