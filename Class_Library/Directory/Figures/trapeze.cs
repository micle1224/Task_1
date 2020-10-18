using System;


namespace Figures
{
    /// <summary>
    /// класс Trapeze описывающий трапецию
    /// </summary>
    public class Trapeze
    {
        private double B, D, H, C, G;
        public void set_info(double B, double D, double H, double C, double G) { this.B = B; this.D = D; this.H = H; this.C = C; this.G = G; }
        public double get_B() { return this.B; }
        public double get_D() { return this.D; }
        public double get_H() { return this.H; }
        public double get_C() { return this.C; }
        public double get_G() { return this.G; }
        /// <summary>
        /// метод проверяющий возможность существования данной трапеции
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (B <= 0 || D <= 0 || H <= 0 || C <= 0 || G <= 0)
                return false;
            return true;
        }
        /// <summary>
        /// метод подсчитывающий площадь трапеции
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            if (!Check())
                return -1;
            return 0.5 * H * (D + B);
        }
        /// <summary>
        /// метод подсчитывающий периметр трапеции
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            if (!Check())
                return -1;
            return B + D + C + G;
        }
    }
}
