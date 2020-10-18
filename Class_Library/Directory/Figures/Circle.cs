using System;

namespace Figures
{
    /// <summary>
    /// Класс Circle описывающий окружность
    /// </summary>
    public class Circle
    {
        private double Radius;
        public void set_info(double Radius) { this.Radius = Radius; }
        public double get_radius() { return this.Radius; }
        /// <summary>
        /// метод проверяющий возможность существования данной окружности
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (Radius <= 0)
                return false;
            return true;
        }
        /// <summary>
        /// метод подсчитывающий площадь круга(у окружности площадь отсутствует)
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            if (!Check())
                return -1;
            return Math.PI * Radius * Radius;

        }
        /// <summary>
        /// метод подсчитывающий периметр окружности
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            if (!Check())
                return -1;
            return 2 * Math.PI * Radius;
        }

    }
}
