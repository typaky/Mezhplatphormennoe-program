using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Pentagon : Figure
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return (5/2) * Math.Pow(Radius, 2) * Math.Sin(1.25664);
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Radius), (int)(Position.Y + Radius));
        }
        public override void Draw(Graphics gr)
        {
            List<Point> Points = GetPoints();
            gr.DrawPolygon(Pens.Black, Points.ToArray());
            gr.DrawString(this.GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, this.GetCenter());
        }
        protected List<Point> GetPoints()
        {
            List<Point> Points = new List<Point>();
            for (int i = 0; i < 360; i += 72)
            {
                double rad = (double)i / 180.0 * 3.14;
                double x = Position.X + (int)(Radius * Math.Cos(rad));
                double y = Position.Y + (int)(Radius * Math.Sin(rad));

                Points.Add(new Point((int)x + (int)Radius, (int)y + (int)Radius));
            }
            return Points;
        }
    }
}
