using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public abstract double GetArea();

    }
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }

    }
    class Square : Figure
    {
        public double Width { get; set; }
        

        public override double GetArea()
        {
            return Width * Width;
        }
    }
    class Circle : Figure
    {
        public double Radius { get; set; }


        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
    class Trangle : Figure
    {
        public double Height { get; set; }
        public double Osnovanie { get; set; }


        public override double GetArea()
        {
            return 0.5 * Height *Osnovanie;
        }
    }
    class Trapecia : Figure
    {
        public double Height { get; set; }
        public double Osnovanie1 { get; set; }
        public double Osnovanie2 { get; set; }


        public override double GetArea()
        {
            return 0.5 * Height * (Osnovanie1 * Osnovanie2);
        }
    }
    class Romb : Figure
    {
        
        public double Diogonal1 { get; set; }
        public double Diogonal2 { get; set; }


        public override double GetArea()
        {
            return  Diogonal1 * Diogonal2 / 2;
        }
    }
    class Para : Figure
    {

        public double Storona { get; set; }
        public double Height { get; set; }


        public override double GetArea()
        {
            return Storona * Height;
        }
    }
    class Pati : Figure
    {

        public double Radius { get; set; }
       

        public override double GetArea()
        {
            return 5 * Math.Pow(Radius,2) * Math.Tan(Math.PI / 5);
        }
    }
    class Dec : Figure
    {

        public double Radius { get; set; }


        public override double GetArea()
        {
            return 10 * Math.Pow(Radius, 2) * Math.Tan(Math.PI / 10);
        }
    }
}

