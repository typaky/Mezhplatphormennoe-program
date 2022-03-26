using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    abstract class Trapezoid : Figure
    {
        public double MainTop { get; set; }
        public double MainBottom { get; set; }
        public double LeftSide { get; set; }
        public double RightSide { get; set; }
        protected double GetHeight()
        {
            double Height;
            Height = Math.Sqrt(Math.Pow(LeftSide, 2) - Math.Pow(((Math.Pow(this.MainBottom - this.MainTop, 2) +
                    Math.Pow(this.LeftSide, 2) - Math.Pow(this.RightSide, 2)) / (2 * (this.MainBottom - this.MainTop))), 2));
            return Height;
        }
        public override double GetArea()
        {
            double Height = GetHeight();
            return (MainBottom + MainTop) / 2 * Height;
        }
        public override void Draw(Graphics gr)
        {
            Point[] Points = SetPoints();
            gr.DrawLine(new Pen(Color), Points[0], Points[1]);
            gr.DrawLine(new Pen(Color), Points[1], Points[2]);
            gr.DrawLine(new Pen(Color), Points[2], Points[3]);
            gr.DrawLine(new Pen(Color), Points[0], Points[3]);
            gr.DrawString(this.GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, this.GetCenter());
        }
        public abstract Point[] SetPoints();
    }
    
    class TrapezoidRectangular : Trapezoid
    {
        public override Point[] SetPoints()
        {
            double Height = GetHeight();
            Point[] Points = new Point[4];
            Points[0] = new Point(this.Position.X, this.Position.Y);
            Points[1] = new Point(this.Position.X, this.Position.Y + (int)Height);
            Points[2] = new Point(this.Position.X + (int)MainTop, this.Position.Y + (int)Height);
            Points[3] = new Point(this.Position.X + (int)this.MainBottom, this.Position.Y);
            return Points;
        }
        public override Point GetCenter()
        {
            double Height = GetHeight();
            return new Point((int)(Position.X + MainTop / 2), (int)(Position.Y + Height / 2));
        }
    }

    class TrapezoidEquilateral : Trapezoid
    {
        private double GetSection()
        {
            double Section = (MainBottom - MainTop) / 2;
            return Section;
        }
        public override Point[] SetPoints()
        {
            double Height = GetHeight();
            double Section = GetSection();
            Point[] Points = new Point[4];
            Points[0] = new Point(this.Position.X, this.Position.Y);
            Points[1] = new Point(this.Position.X + (int)Section, this.Position.Y + (int)Height);
            Points[2] = new Point(this.Position.X + (int)Section + (int)MainTop, this.Position.Y + (int)Height);
            Points[3] = new Point(this.Position.X + (int)this.MainBottom, this.Position.Y);
            return Points;
        }
        public override Point GetCenter()
        {
            double Height = GetHeight();
            return new Point((int)(Position.X + MainBottom / 2), (int)(Position.Y + Height / 2));
        }
    }
}
