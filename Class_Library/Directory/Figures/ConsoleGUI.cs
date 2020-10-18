using System;

namespace Figures
{
    /// <summary>
    /// класс отвечающий за консольный интерфейс
    /// </summary>
    public class ConsoleGUI
    {
        Circle[] circle = new Circle[3];
        Trapeze[] trapeze = new Trapeze[2];
        Square[] square = new Square[3];
        /// <summary>
        /// метод с вводом данных
        /// </summary>
        public void Input()
        {
            double Radius, A_side, B_side, D_side, H_height, C_side, G_side;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nВведите радиус окружности N {i} (Radius): ");
                Radius = double.Parse(Console.ReadLine());
                circle[i] = new Circle();
                circle[i].set_info(Radius);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nВведите длину стороны квадрата N {i} (A_side): ");
                A_side = double.Parse(Console.ReadLine());
                square[i] = new Square();
                square[i].set_info(A_side);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nВведите длину основания трапеции N {i} (B_side): ");
                B_side = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nВведите длину основания трапеции N {i} (D_side): ");
                D_side = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nВведите длину высоты трапеции N {i} (H_side): ");
                H_height = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nВведите длину стороны трапеции N {i} (C_side): ");
                C_side = double.Parse(Console.ReadLine());
                Console.WriteLine($"\nВведите длину стороны трапеции N {i} (G_side): ");
                G_side = double.Parse(Console.ReadLine());
                trapeze[i] = new Trapeze();
                trapeze[i].set_info(B_side, D_side, H_height, C_side, G_side);
            }
        }
        /// <summary>
        /// метод отвечающий за вывод данных
        /// </summary>
        public void Output()
        {
            for (int i = 0; i < 3; i++)
            {
                if (circle[i].Area() != -1)
                {
                    Console.WriteLine($"\nПлощадь круга N {i}={circle[i].Area()} ");
                    Console.WriteLine($"\nПериметр окружности N {i}={circle[i].Perimeter()} ");
                }
                else
                    Console.WriteLine($"\nбыл введен не корректный радиус для окружности N {i} ");
            }

            for (int i = 0; i < 3; i++)
            {
                if (square[i].Area() != -1)
                {
                    Console.WriteLine($"\nПлощадь квадрата N {i}={square[i].Area()} ");
                    Console.WriteLine($"\nПериметр квадрата N {i}={square[i].Perimeter()} ");
                }
                else
                    Console.WriteLine($"\nбыла введена не корректная сторона для квадрата N {i} ");
            }
            for (int i = 0; i < 2; i++)
            {
                if (trapeze[i].Area() != -1)
                {
                    Console.WriteLine($"\nПлощадь трапеции N {i}={trapeze[i].Area()} ");
                    Console.WriteLine($"\nПериметр трапеции N {i}={trapeze[i].Perimeter()} ");
                }
                else
                    Console.WriteLine($"\nбыли введены не корретные данные для трапеции N {i} ");
            }
        }
        /// <summary>
        /// метод сравнивающий площади фигур и выводящий фигуру с наибольшей площадью
        /// </summary>
        public void Area_Compare()
        {
            double max = 0, a = 0;
            string name = "";
            for (int i = 0; i < 3; i++)
            {
                if (max < circle[i].Area())
                {
                    max = circle[i].Area();
                    a = i;
                    name = "Круг";
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (max < square[i].Area())
                {
                    max = square[i].Area();
                    a = i;
                    name = "Квадрат";
                }
            }
            for (int i = 0; i < 2; i++)
            {
                if (max < trapeze[i].Area())
                {
                    max = trapeze[i].Area();
                    a = i;
                    name = "Трапеция";
                }
            }
            Console.WriteLine($"Наибольшая площадь у фигуры {name} N {a} , которая равна {max}");
        }
        /// <summary>
        /// метод сравнивающий средние периметры фигур и выводящий тип фигуры с наибольшим значением среднего периметра
        /// </summary>
        public void Perimeter_Compare()
        {
            double sum=0,a,b,c;
            for (int i = 0; i < 3; i++)
            {
                sum=sum+ circle[i].Perimeter();
            }
            a = sum / 3;
            sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum = sum + square[i].Perimeter();
            }            
            b = sum / 3;
            sum = 0;
            for (int i = 0; i < 2; i++)
            {
                sum = sum + trapeze[i].Perimeter();
            }
            c = sum / 2;
            if(a>b&&a>c)
                Console.WriteLine("Тип фигуры с наибольшим значением среднего периметра-Круг");
            else if(b>a&&b>c)
                Console.WriteLine("Тип фигуры с наибольшим значением среднего периметра-Квадрат");
            else if(c>a&&c>b)
                Console.WriteLine("Тип фигуры с наибольшим значением среднего периметра-Трапеция");
            else
                Console.WriteLine("Тип фигуры с наибольшим значением периметра не выявлен,имеется два или более типа фигур с одинаковым значением среднего периметра ");
        }
    }
}
