using System;

namespace Figures
{
    public class ConsoleGUI
    {
        public void Input()
        {
            Circle circle;
            double R;
            do
            {
                Console.WriteLine("Введите радиус окружности(R): ");
                string r = Console.ReadLine();
                if (Double.TryParse(r, out R))
                    break;
                else
                    Console.WriteLine("Введите числа! ");
            } while (true);
            circle = new Circle(R);
        }
    }
}
