using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab3
{
    class Program
    {
        public static Figure[] figures = 
        {
            new Rectangle()
            {
                Name = "Прямоугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(1200, 25),
                Width = 50,
                Height = 150
            },
            new Square()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(900, 150),
                Side = 125
            },
            new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(1300, 25),
                LeftSide = 50,
                RightSide = 50,
                BottomSide = 100
            },
            new TrapezoidRectangular()
            {
                Name = "Прямоугольная трапеция",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(800, 25),
                MainTop = 25,
                MainBottom = 60,
                LeftSide = 40,
                RightSide = 30
            },
            new TrapezoidEquilateral()
            {
                Name = "Равнобедренная трапеция",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(900, 25),
                MainTop = 50,
                MainBottom = 120,
                LeftSide = 80,
                RightSide = 80
            },
            new Rhombus()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(900, 350),
                Side = 300,
                Height = 225
            },
            new Pentagon()
            {
                Name = "Правильный пятиугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(25, 25),
                Radius = 350
            },
            new Parallelogram()
            {
                Name = "Параллелограм",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(1200, 250),
                TopSide = 100,
                LeftSide = 80,
                Height = 70
            },
            new Decagon()
            {
                Name = "Правильный десятиугольник",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(25, 25),
                Radius = 350
            },
            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Black,
                Position = new System.Drawing.Point(25, 25),
                Radius = 350
            }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3 - Полиморфизм");
            Console.WriteLine("Выполнил - Сергей Чумак\n");

            Form frm = new Form()
            {
                Text = "Лабораторная №3 - Полиморфизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine("Фигура: " + figures[i].Name);
                Console.WriteLine("Площадь: " + figures[i].GetArea());
                Console.WriteLine("Цвет: " + figures[i].Color);
                Console.WriteLine("Положение фигуры: " + figures[i].Position);
                Console.WriteLine("Координаты центра: " + figures[i].GetCenter() + "\n");
            }

            frm.Paint += Frm_Paint;
            Application.Run(frm);

        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
