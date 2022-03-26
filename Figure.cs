using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace lab3
{
    class Figure
    {
        public string Name { get; set; }
        public System.Drawing.Color Color { get; set; }
        public System.Drawing.Point Position { get; set; }
        public virtual double GetArea()
        {
            return 0;
        }
        public virtual System.Drawing.Point GetCenter()
        {
            return new Point((int)(Position.X + 0), (int)(Position.Y + 0));
        }
        public virtual void Draw(Graphics gr) { }
    }
}
