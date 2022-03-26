using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Parallelogram : Figure
    {
        public double TopSide { get; set; }
        public double LeftSide { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return TopSide * Height;
        }
        public override Point GetCenter()
        {
            double Section = GetSection();
            return new Point((int)(Position.X + (TopSide - Section) / 2), (int)(Position.Y + Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            Point[] Points = GetPoints();
            gr.DrawLine(new Pen(Color), Points[0], Points[1]);
            gr.DrawLine(new Pen(Color), Points[1], Points[2]);
            gr.DrawLine(new Pen(Color), Points[2], Points[3]);
            gr.DrawLine(new Pen(Color), Points[0], Points[3]);
            gr.DrawString(this.GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, this.GetCenter());
        }
        protected Point[] GetPoints()
        {
            double Section = GetSection();
            Point[] Points = new Point[4];
            Points[0] = new Point(this.Position.X, this.Position.Y);
            Points[1] = new Point(this.Position.X - (int)Section, this.Position.Y + (int)Height);
            Points[2] = new Point(this.Position.X - (int)Section + (int)TopSide, this.Position.Y + (int)Height);
            Points[3] = new Point(this.Position.X + (int)this.TopSide, this.Position.Y);
            return Points;
        }
        protected double GetSection()
        {
            double Section = Math.Sqrt(Math.Pow(LeftSide, 2) - Math.Pow(Height, 2));
            return Section;
        }
    }
}
