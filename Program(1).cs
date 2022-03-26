using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №2 - Наследование");
            Console.WriteLine("Выполнил - Титов Александр\n");
            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник А",
                Width = 15.1,
                Height = 12.8
            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", a.Name, a.GetArea());
            
            Square b = new Square()
            {
                Name = "Квадрат Б",
                Width = 15.1,
                
            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", b.Name, b.GetArea());
            
            Circle c = new Circle()
            {
                Name = "Круг В",
                Radius = 15.1,

            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", c.Name, c.GetArea());
            
            Trangle t = new Trangle()
            {
                Name = "Треугольник Г",
                Height = 15.1,
                Osnovanie = 16.1

            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", t.Name, t.GetArea());
            
            Trapecia g = new Trapecia()
            {
                Name = "Трапеция Д",
                Height = 15.1,
                Osnovanie1 = 16.1,
                Osnovanie2 = 12.6

            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", g.Name, g.GetArea());
            
            Romb r = new Romb()
            {
                Name = "Ромб Е",
                
                Diogonal1 = 16.1,
                Diogonal2 = 12.6

            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", r.Name, r.GetArea());

            Para p = new Para()
            {
                Name = "Паралелограмм Ж",

                Storona = 16.1,
                Height = 12.6

            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", p.Name, p.GetArea());
            
            Pati l = new Pati()
            {
                Name = "Пятиугольник З",

                Radius = 16.1 
                

            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", l.Name, l.GetArea());
           
            Dec m = new Dec()
            {
                Name = "Десятиугольник И",

                Radius = 16.1


            };

            Console.WriteLine("Название фигуры: {0}\nПлощадь фигруры: {1}", m.Name, m.GetArea());




        }
    }
}
