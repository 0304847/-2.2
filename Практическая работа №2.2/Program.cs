using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L1, x1, a1, c1,e1;
            Console.WriteLine("задача №1");
            Console.WriteLine("введите значение x");
            x1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение e");
            e1 = Convert.ToDouble(Console.ReadLine());

            L1 = (Math.Sqrt(Math.Exp(x1) - Math.Pow(Math.Cos(Math.Pow(x1, 2) * Math.Pow(a1, 5)), 4)) + Math.Pow(Math.Atan(a1 - Math.Pow(x1, 5)), 4)) / (Math.Pow(Math.Sqrt(Math.Abs(a1 + x1 * Math.Pow(c1, 4))), e1));
            Console.WriteLine($"решение задачи №1={L1}");

            double L2, c2, x2, t2;

            Console.WriteLine("задача №2");
            Console.WriteLine("введите значение c");
            c2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение t");
            t2 = Convert.ToDouble(Console.ReadLine());

            L2 = Math.Pow(Math.Tan(c2), 2) + (2 * Math.Pow(x2, 2) + 5) / (Math.Sqrt(c2 + t2));
            Console.WriteLine($"решение задачи №2={L2}");

            double A3, y3, h3;

            Console.WriteLine("задача №3");
            Console.WriteLine("введите значение y");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение h");
            h3 = Convert.ToDouble(Console.ReadLine());

            A3 = (Math.Tan(Math.Pow(y3, 3) - Math.Pow(h3, 4)) + Math.Pow(h3, 2)) / (Math.Pow(Math.Sin(h3), 3) + y3);
            Console.WriteLine($"решение задачи №3={A3}");

            double F4, y4, x4;

            Console.WriteLine("задача №4");
            Console.WriteLine("введите значение y");
           y4 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("введите значение x");
            x4 = Convert.ToDouble(Console.ReadLine());

            F4 = (Math.Sqrt(Math.Pow(2 + y4, 2) + Math.Pow(Math.Sqrt(Math.Sin(y4 + 5)), 4))) / (Math.Log10(x4 + 1) - Math.Pow(y4, 3));
            Console.WriteLine($"решение задачи №4={F4}");

            double G5, x5, z5, y5, c5;

            Console.WriteLine("задача №5");
             Console.WriteLine("введите значение x");
            x5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение z");
            z5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c");
            c5 = Convert.ToDouble(Console.ReadLine());

            G5 = (Math.Tan(Math.Pow(x5, 4) - 6) - Math.Pow(Math.Cos(z5 + x5 * y5), 3)) / (Math.Pow(Math.Cos(Math.Pow(x5, 3) * Math.Pow(c5, 2)), 4));
            Console.WriteLine($"решение задачи №5={G5}");

            double K6, x6, b6, a6, y6;

            Console.WriteLine("задача №6");
            Console.WriteLine("введите значение x");
            x6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение b");
            b6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y6 = Convert.ToDouble(Console.ReadLine());

            K6 = (Math.Sqrt(x6 + b6 - a6) + Math.Log10(y6)) / (Math.Atan(b6 + a6));
            Console.WriteLine($"решение задачи №6={K6}");

            double D7, x7, y7, a7;

            Console.WriteLine("задача №7");
            Console.WriteLine("введите значение x");
            x7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a7 = Convert.ToDouble(Console.ReadLine());

            D7 = (Math.Cos(Math.Pow(x7, 3) + 6) - Math.Sin(y7 - a7)) / (Math.Log10(Math.Pow(x7, 4)) - 2 * Math.Pow(Math.Sin(x7), 5));
            Console.WriteLine($"решение задачи №7={D7}");

            double P8, a8, y8, c8, x8;

            Console.WriteLine("задача №8");
            Console.WriteLine("введите значение a");
            a8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c");
            c8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x8 = Convert.ToDouble(Console.ReadLine());

            P8 = (Math.Pow(a8, 5) + Math.Pow(Math.Sin(y8 - c8), 4)) / (Math.Pow(Math.Sin(x8 + y8), 3) + Math.Abs(x8 - y8));
            Console.WriteLine($"решение задачи №8={P8}");

            double R9, y9, x9, d9;

            Console.WriteLine("задача №9");
            Console.WriteLine("введите значение y");
            y9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение d");
            d9 = Convert.ToDouble(Console.ReadLine());

            R9 = (Math.Pow(Math.Cos(y9), 3) + Math.Pow(2, x9) * d9) / (Math.Exp(y9) + Math.Log10(Math.Pow(Math.Sin(x9), 2) + 7.4));
            Console.WriteLine($"решение задачи №9={R9}");

            double U10, x10, y10;

            Console.WriteLine("задача №10");
            Console.WriteLine("введите значение x");
            x10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y10 = Convert.ToDouble(Console.ReadLine());

            U10 = (Math.Exp(Math.Pow(x10, 3)) + Math.Pow(Math.Cos(x10 - 4), 2) / (Math.Atan(x10) + 5.2 * y10));
            Console.WriteLine($"решение задачи №10={U10}");

            double I11, y11, x11;

            Console.WriteLine("задача №11");
            Console.WriteLine("введите значение y");
            y11= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x11 = Convert.ToDouble(Console.ReadLine());

            I11 = (2.33 * Math.Log10(Math.Sqrt(1 + Math.Pow(Math.Cos(y11), 2)))) / (Math.Exp(y11) + Math.Pow(Math.Sin(x11), 2));
            Console.WriteLine($"решение задачи №11={I11}");

            double G12, y12, x12, a12;

            Console.WriteLine("задача №12");
            Console.WriteLine("введите значение y");
            y12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x12 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a12 = Convert.ToDouble(Console.ReadLine());

            G12 = (Math.Pow(Math.Cos(Math.Abs(y12 + x12)), 3) - (x12 + y12)) / (Math.Pow(Math.Atan(x12 + a12), 4) * Math.Pow(x12, 5));
            Console.WriteLine($"решение задачи №12={G12}");

            double R13, a13, x13, b13;

            Console.WriteLine("задача №13");
            Console.WriteLine("введите значение a");
            a13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение b");
            b13 = Convert.ToDouble(Console.ReadLine());

            R13 = (a13 / (x13 - a13)) + ((Math.Pow(b13, x13) + Math.Pow(Math.Cos(x13), 3)) / (Math.Pow(Math.Log(a13), 3) + 4.5));
            Console.WriteLine($"решение задачи №13={R13}");

            double R14, x14;

            Console.WriteLine("задача №14");
            Console.WriteLine("введите значение x");
            x14 = Convert.ToDouble(Console.ReadLine());

            R14 = (Math.Sin(Math.Pow(Math.Pow(x14, 2) + 4), 3) + 4.3) / (Math.Pow(Math.Sin(Math.Pow(x14, 4)), 3));
            Console.WriteLine($"решение задачи №14={R14}");

            double N15, m15, y15;

            Console.WriteLine("задача №15");
            Console.WriteLine("введите занчение m");
            m15 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение y");
            y15 = Convert.ToDouble(Console.ReadLine());

            N15 = (Math.Pow(m15, 2) + 2.8 * m16 + 0.355) / (Math.Cos(2 * y15) + 3.6);
            Console.WriteLine($"решение задачи №15={N15}");




            double P16, x16, y16, t16;

            Console.WriteLine("задача №16");
            Console.WriteLine("введите значение x");
            x16 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y16 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение t");
            t16 = Convert.ToDouble(Console.ReadLine());

            P16 = (Math.Pow(Math.Sin(x16), 3) + Math.Log10(2 * y16 + 3 * x16)) / (Math.Pow(t16, 2) + Math.Sqrt(x16));
            Console.WriteLine($"решение задачи №16={P16}");

            double T17, x17, b17, a17, y17;

            Console.WriteLine("задача №17");
            Console.WriteLine("введите значение x");
            x17 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y17 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение b");
            b17 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a17 = Convert.ToDouble(Console.ReadLine());

            T17 = (Math.Sqrt(x17 + b17 - a17) + Math.Log10(y17)) / (Math.Atan(b17 + a17));
            Console.WriteLine($"решение задачи №17={T17}");

            double S18, y18, t18;

            Console.WriteLine("задача №18");
            Console.WriteLine("введите значение y");
            y18 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение t");
            t18 = Convert.ToDouble(Console.ReadLine());

            S18 = (4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log10(t18)) / (Math.Sqrt(Math.Cos(2 * y18) + 4.351));
            Console.WriteLine($"решение задачи №18={S18}");

            double D19, K19, a19, b19, x19, y19;

            Console.WriteLine("задача №19 ");
            Console.WriteLine("Введите значение K");
            K19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение a");
            a19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение b");
            b19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение x");
            x19 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение y");
            y19 = Convert.ToDouble(Console.ReadLine());

            D19 = (Math.Pow(K19, -x19) - a19 * Math.Sqrt(6) - Math.Cos(3 * a19 * b19)) / (Math.Pow(Math.Sin(a19 * Math.Asin(x19) + Math.Log10(y19)), 2));
            Console.WriteLine($"решение задачи №19={D19}");

            double U20, y20, x20, b20, c20, a20;

            Console.WriteLine("задача №20");
            Console.WriteLine("введите занчение y");
            y20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение x");
            x20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение b");
            b20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение c");
            c20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение a");
            a20 = Convert.ToDouble(Console.ReadLine());

            U20 = (Math.Pow(Math.Tan(y20), 3) + Math.Pow(Math.Sin(x20 * Math.Sqrt(b20 - c20)), 5)) / (Math.Sqrt(a20 - b20 + c20));
            Console.WriteLine($"решение задачи №20={U20}");

            double N21, z21, x21, a21;

            Console.WriteLine("задача №21");
            Console.WriteLine("введите занчение z");
            z21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение x");
            x21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение a");
            a21 = Convert.ToDouble(Console.ReadLine());

            N21 = (Math.Pow(Math.Sqrt(z21 + Math.Sqrt(z21 * x21)), 5)) / (Math.Exp(x21) + Math.Pow(a21, 5) * Math.Atan(x21));
            Console.WriteLine($"решение задачи №21={N21}");

            double F22, x22, y22;

            Console.WriteLine("задача №22");
            Console.WriteLine("введите занчение x");
            x22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите занчение y");
            y22 = Convert.ToDouble(Console.ReadLine());

            F22 = Math.Cos(Math.Pow(x22, 2) + 2) + (3.5 * Math.Pow(x22, 2) + 1) / (Math.Pow(Math.Cos(y22), 2));
            Console.WriteLine($"решение задачи №22={F22}");

            double F23, x23, z23, a23, b23;

            Console.WriteLine("задача №23");
            Console.WriteLine("введите значение x");
            x23 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение z");
            z23 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a23 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение b");
            b23 = Convert.ToDouble(Console.ReadLine());

            F23 = (Math.Sqrt(Math.Abs(x23) + Math.Pow(Math.Cos(x23), 4) + Math.Pow(z23, 4))) / (Math.Log10(x23) - Math.Asin(b23 * x23 - a23));
            Console.WriteLine($"решение задачи №23={F23}");

            double F24, b24, x24, a24, z24;

            Console.WriteLine("заадча №24");
            Console.WriteLine("введите значение b");
            b24 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x24 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение a");
            a24 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение z");
            z24 = Convert.ToDouble(Console.ReadLine());

            F24 = (Math.Pow(Math.Cos(b24 * Math.Pow(x24, 5)), 7)) - (Math.Sin(Math.Pow(a24, 2)) + Math.Cos(Math.Pow(x24, 3) + Math.Pow(z24, 5) - Math.Pow(a24, 2))) / (Math.Asin(Math.Pow(a24, 2)) + Math.Acos(Math.Pow(x24, 7) - Math.Pow(a24, 2)));
            Console.WriteLine($"решение задачи №24={F24}");

            double J25, a25, x25, y25;

            Console.WriteLine("задача №25");
            Console.WriteLine("введите значение a");
            a25 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x25 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y25 = Convert.ToDouble(Console.ReadLine());

            J25 = (Math.Pow(Math.Tanh(Math.Pow(a25, 3)), 3) + Math.Pow(Math.Atan(a25), 2)) / (Math.Sqrt(Math.Pow(y25, Math.Tan(x25))));
            Console.WriteLine($"решение задачи №25={J25}");

            double U26, x26, y26, k26;

            Console.WriteLine("задача№26");
            Console.WriteLine("введите значение x");
            x26 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y26 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение k");
            k26 = Convert.ToDouble(Console.ReadLine());

            U26 = (Math.Log10(Math.Pow(x26, 3) + y26) - Math.Pow(y26, 4)) / (Math.Exp(y26) + 5.4 * Math.Pow(k26, 3));
            Console.WriteLine($"решение задачи №26={U26}");

            double P27, a27, x27, y27, c27;

            Console.WriteLine("задача №27");
            Console.WriteLine("введите значение a");
            a27 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x27 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y27 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c");
            c27 = Convert.ToDouble(Console.ReadLine());

            P27 = (Math.Pow(a27, 5) + Math.Acos(a27 + Math.Pow(x27, 3)) - Math.Pow(Math.Sin(y27 - c27), 4)) / (Math.Pow(Math.Sin(x27 + y27), 3) + Math.Abs(x27 + y27));
            Console.WriteLine($"решение задачи №27={P27}");

            double G28, x28, z28, y28, c28;

            Console.WriteLine("задача №28");
            Console.WriteLine("введите значение x");
            x28 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение z");
            z28 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение y");
            y28 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c");
            c28 = Convert.ToDouble(Console.ReadLine());

            G28 = (Math.Tan(Math.Pow(x28, 4) - 6) - Math.Pow(Math.Cos(z28 + Math.Pow(x28, 3) * y28), 3 * x28)) / (Math.Pow(Math.Cos(Math.Pow(x28, 3) * Math.Pow(c28, 2)), 2));
            Console.WriteLine($"решение задачи №28={G28}");

            double R29, y29, d29, x29;

            Console.WriteLine("задача №29");
            Console.WriteLine("введите значение y");
            y29 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение c");
            d29 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите значение x");
            x29 = Convert.ToDouble(Console.ReadLine());

            R29 = (Math.Pow(Math.Cos(y29), 2) + 2.4 * d29) / (Math.Exp(y29) + Math.Log10(Math.Pow(Math.Sin(x29), 2) + 6));
            Console.WriteLine($"решение задачи №29={R29}");

            double K30, x30;

            Console.WriteLine("задача №30");
            Console.WriteLine("введите значение x");
            x30 = Convert.ToDouble(Console.ReadLine());

            K30 = (Math.Sqrt(Math.Pow(3 + x30, 6) - Math.Log10(x30))) / Math.Exp(0) + Math.Asin(6 * Math.Pow(x30, 2));
            Console.WriteLine($"решение задачи №30={K30}");
            Console.WriteLine("нажмите любую клавишу чтобы закрыть");
            Console.ReadKey();
        }
    }
}
