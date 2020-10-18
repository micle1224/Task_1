using System;

namespace Figures
{
    /// <summary>
    /// класс описывающий квадрат
    /// </summary>
    public class Square
    {
        private double A;
        public void set_info(double A) { this.A = A; }
        public double get_radius() { return this.A; }
        /// <summary>
        /// метод проверяющий возможность существования данного квадрата
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (A <= 0)
                return false;
            return true;
        }
        /// <summary>
        /// метод подсчитывающий площадь квадрата
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            if (!Check())
                return -1;
            return A * A;
        }
        /// <summary>
        /// метод подсчитывающий периметр квадрата
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            if (!Check())
                return -1;
            return A+A;
        }
    }
}
