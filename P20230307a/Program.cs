using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * 這是我用來示範如何利用C#計算BMI的程式範例
 * 作者：何敏煌 
 * 日期：2023/3/7
 */
namespace P20230307a
{
    class Program
    {
        static void Main(string[] args)
        {
            // float Weight = 65.0F, Height = 1.85F;

            // 下面這行是用來顯示文字
            // Console.Write("BMI:");
            // 底下用來計算BMI，公式：BMI = weight / (height*height)
            // Console.WriteLine(Math.Round(60 / (1.9*1.9),2));
            // Console.WriteLine(60 / Math.Pow(1.9, 2));

            double Weight, Height;

            Console.Write("身高（公尺）：");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("體重（公斤）：");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Round(Weight / Math.Pow(Height,2)));

            //int x, y, z;
            //x = y = z = 100;
            //Console.WriteLine(x);



        }
    }
}
