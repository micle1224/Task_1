using System;

namespace Figures
{
    /// <summary>
    /// Класс Circle описывающий окружность
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// автосвойство отвечающее за радиус окружности
        /// </summary>
        public double R { private set; get; }

        /// <summary>
        /// конструктор класса с радиусом
        /// </summary>
        /// <param name="R">радиус R</param>
        public Circle(double R)
        {
            this.R = R;
        }
        /// <summary>
        /// метод проверяющий возможность существования данной окружности
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (R <= 0)
                return false;
            return true;
        }
        /// <summary>
        /// метод подсчитывающий площадь круга(у окружности площадь отсутствует)
        /// </summary>
        /// <returns></returns>
        public double Circle_Square()
        {
            if (!Check())
                return -1;
            return Math.PI * R * R;
        
        }
        /// <summary>
        /// метод подсчитывающий периметр окружности
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            if (!Check())
                return -1;
            return 2 * Math.PI * R;
        }
        
    }
}
