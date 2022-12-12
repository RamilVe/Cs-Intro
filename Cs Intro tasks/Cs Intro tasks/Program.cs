using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Cs_Intro_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21 - ə bölünən ədədlərin ədədi ortasını tapan proqram
            //Console.WriteLine("M: ");

            //var MStr = Console.ReadLine();
            //var M = Convert.ToInt32(MStr);

            //Console.WriteLine("N: ");

            //var NStr = Console.ReadLine();
            //var N = Convert.ToInt32(NStr);

            //var count = 0;
            //var sum = 0;
            //for (int i = 21; i < N; i++)
            //{
            //    if (i % 21 == 0)
            //    {
            //        sum += i;
            //        count++;
            //    }
            //}
            //if (count > 0)
            //{
            //    var result = sum / count;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("0-a bolunme yoxdur");
            //}

            //Task 2
            //Verilmiş ədədin rəqəmləri cəmini tapan proqram
            //Console.WriteLine("Eded daxil edin: ");

            //var numStr = Console.ReadLine();
            //var num = Convert.ToInt32(numStr);

            //var sum = 0;
            //var n = 0;
            //while (num != 0)
            //{
            //    n = num % 10;
            //    sum += n;
            //    num = (num - n) / 10;

            //}
            //Console.WriteLine(sum);


            //Task 3
            //Verilmiş ayın ədədinə görə hansı fəsil olduğunu tapan proqram
            //Console.WriteLine("Ededi daxil edin: ");

            //var numStr = Console.ReadLine();
            //var num = Convert.ToInt32(numStr);
            //if (num > 0 && num < 13)
            //{
            //    if (num >= 3 && num <= 5)
            //    {
            //        Console.WriteLine("Yaz feslidir");
            //    }
            //    if (num >= 6 && num <= 8)
            //    {
            //        Console.WriteLine("Yay feslidir");
            //    }
            //    if (num >= 9 && num <= 11)
            //    {
            //        Console.WriteLine("Payiz feslidir");
            //    }
            //    if (num < 3 || num == 12)
            //    {
            //        Console.WriteLine("Qis feslidir");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun eded yazin");
            //}

            //Task 4
            //Verilmiş yazıda rəqəm olmamasını yoxlayan proqram, əgər rəqəm varsa yenidən yazının daxil edilməsini istəməlidir ta ki rəqəmsiz daxil edilənədək.

            //Console.WriteLine("Yazin: ");
            //var notNumber = Console.ReadLine();
            //var notNum = Convert.ToInt32(notNumber);

            //while (notNum > 0 && notNum <= 9)
            //{
            //    Console.WriteLine("Yazin: ");
            //    notNumber = Console.ReadLine();
            //    notNum = Convert.ToInt32(notNumber);
            //}
            //Console.WriteLine("Reqem deyil: " + notNum);

            //Task 5
            //Verilmiş 2 ədəd üzərində verilmiş operator simvoluna uyğun riyazi əməliyyat aparan proqram. Misalçün consoledan 5,10 və + daxil edilsə 5 və 10 - u toplayıb nəticəsini göstərsin.Console - dan daxil edilən operator + , -, *, / operatorlarından biri deyilsə operator yanlışdır yazılsın.
            
        }
    }
}
