using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }

        //Сложение
        public void Add(Complex x)
        {
            Real += x.Real;
            Imag += x.Imag;
        }
        //Вычитание
        public void Substract(Complex x)
        {
            Real -= x.Real;
            Imag -= x.Imag;
        }
        //Умножение
        public void Multiply(Complex x)
        {
            Real = Real * x.Real - Imag * x.Imag;
            Imag = Imag * x.Real + Real * x.Imag;

        }

        //Деление
        public void Divide(Complex x)
        {
            Real = (Real * x.Real + Imag * x.Imag) / (x.Real * x.Real + x.Imag * x.Imag);
            Imag = (Imag * x.Real - Real * x.Imag) / (x.Real * x.Real + x.Imag * x.Imag);
        }
    }
}
