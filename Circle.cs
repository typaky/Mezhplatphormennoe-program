using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public const double pi = 3.14159265359;

        public override double GetArea()
        {
            return Radius * pi;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Radius), (int)(Position.Y + Radius));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), new RectangleF(Position.X, Position.Y, (float)Radius*2, (float)Radius*2));
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
