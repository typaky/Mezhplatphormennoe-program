using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Triangle : Figure
    {
        public double LeftSide { get; set; }
        public double RightSide { get; set; }
        public double BottomSide { get; set; }
        public string TypeOfTriangle()
        {
            double eps = 0.01;
            String TypeOfTriangle = "unknown";
            if (this.LeftSide - this.RightSide < eps && this.LeftSide - this.BottomSide < eps)
            {
                TypeOfTriangle = "Равносторонний";
            }
            else if (this.LeftSide - this.RightSide < eps)
            {
                TypeOfTriangle = "Равнобедренный";
            }
            else if (Math.Pow(this.LeftSide, 2) + Math.Pow(this.BottomSide, 2) - Math.Pow(this.LeftSide, 2) < eps)
            {
                TypeOfTriangle = "Прямоугольный";
            }
            else
            {
                TypeOfTriangle = "Разносторонний";
            }
            return TypeOfTriangle;
        }
        private double GetHeight()
        {
            double Height = 0;
            string TriangleType = this.TypeOfTriangle();
            if (TriangleType == "Разносторонний")
            {
                Height = 2 * this.GetArea() / this.BottomSide;
            }
            else if (TriangleType == "Равнобедренный")
            {
                Height = Math.Sqrt(Math.Pow(this.LeftSide, 2) - (Math.Pow(this.BottomSide, 2)) / 4);
            }
            else if (TriangleType == "Прямоугольный")
            {
                Height = this.LeftSide * this.BottomSide / this.RightSide;
            }
            else if (TriangleType == "Равносторонний")
            {
                Height = (this.LeftSide * Math.Sqrt(3)) / 2;
            }
            return Height;
        }
        /*Необходимость для нахождения точки с индексом [1] */
        private double FindHalfBottomSide()
        {
            double Height = GetHeight();
            double Half_bottom_side = Math.Sqrt(Math.Pow(this.LeftSide, 2) - Math.Pow(Height, 2));
            return Half_bottom_side;
        }
        private Point[] GetPoints()
        {
            double Height = GetHeight();
            double HalfBottomSide = this.FindHalfBottomSide();

            Point[] points = new Point[3];
            points[0] = new Point(this.Position.X, this.Position.Y);
            points[1] = new Point(this.Position.X + (int)HalfBottomSide, this.Position.Y + (int)Height);
            points[2] = new Point(this.Position.X + (int)this.BottomSide, this.Position.Y);
            return points;
        }
        public override double GetArea()
        {
            double p = (LeftSide + RightSide + BottomSide) / 2;
            return Math.Sqrt(p * (p - LeftSide) * (p - RightSide) * (p - BottomSide));
        }
        public override Point GetCenter()
        {
            double Height = GetHeight();
            double HalfBottomSide = FindHalfBottomSide();
            double PointX = (this.Position.X + this.Position.X + HalfBottomSide + this.Position.X + this.BottomSide) / 3;
            double PointY = (this.Position.Y + this.Position.Y + (int)Height + this.Position.Y) / 3;
            return new Point((int)(PointX), (int)(PointY));
        }
        public override void Draw(Graphics gr)
        {
            Point[] points = this.GetPoints();
            gr.DrawLine(new Pen(Color), points[0], points[1]);
            gr.DrawLine(new Pen(Color), points[1], points[2]);
            gr.DrawLine(new Pen(Color), points[0], points[2]);
            gr.DrawString(this.GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, this.GetCenter());
        }
    }
}
