using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trump_game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlay = true;
            int[] number = { 0, 0, 0, 0 };
            int numberHolder = 0;
            int numberScanner = 0;
            int[] pareHolder = { 0, 0, 0 };
            int pareNumber = 0;
            while (isPlay)
            {
                //  カード番号を4回入力させる
                for (int i = 0; i < 4; i++)
                {
                    //  1度の入力で範囲内の値が入力されるまで繰り返す
                    while (true)
                    {
                        //  カード番号の入力
                        Console.Write($"{i + 1}番目の数字を入力してください。(1～4) > ");

                        //  入力内容のチェック
                        if (!int.TryParse(Console.ReadLine(), out int input))
                        {
                            //  範囲外の値が入力されたらエラー表示して再入力させる
                            Console.WriteLine("1～4の数値を入力してください。");
                            continue;
                        }
                        else
                        {
                            if (input >= 1 && input <= 4)
                            {
                                number[i] = input;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("1～4の数値を入力してください。");
                                continue;
                            }
                        }
                    }
                }
                Console.WriteLine("入力した番号は");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{number[j]} , ");
                }
                Console.WriteLine("\nです。");

                for (int k = 0; k < 3; k++)
                {
                    numberHolder = number[k];
                    for (int l = k + 1; l < 4; l++)
                    {
                        numberScanner = number[l];
                        if (numberHolder == numberScanner)
                        {
                            pareHolder[pareNumber] = numberHolder;
                            pareNumber++;
                            l = 4;
                        }
                    }
                }

                Console.Write("結果は、");
                if (pareHolder[0] != 0)
                {
                    if (pareHolder[1] != 0)
                    {
                        if (pareHolder[0] == pareHolder[1])
                        {
                            if (pareHolder[1] == pareHolder[2])
                            {
                                Console.Write("フォーカードです。");
                            }
                            else
                            {
                                Console.Write("スリーカードです。");
                            }
                        }
                        else
                        {
                            Console.Write("ツーペアです。");
                        }
                    }
                    else
                    {
                        Console.Write("ワンペアです。");
                    }
                }
                else
                {
                    Console.Write("ハイカードです。");
                }
                Console.Write("もう一度遊びますか？(y/それ以外)");
                string inputChar  = Console.ReadLine();
                isPlay = false;
                if(inputChar == "y" || inputChar == "Y")
                {
                    isPlay = true;
                }
            }
        }
    }
}
