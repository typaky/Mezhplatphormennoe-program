using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Титов Александр");


            //Создадим комплексные числа и сразу присвоим значения
            // действительной и мнимой частям
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };
            Complex c = new Complex() { Real = 4, Imag = 0.2 };
            Complex d = new Complex() { Real = 5, Imag = 0.6 };

            // К числу а прибавим  число б
            a.Add(b);

            // Из числа b вычтем  число a
            b.Substract(a);

            //Число c умножаем на число d
            c.Multiply(d);

            //Число c делим на число d
            c.Divide(d);

            //Выведем результат
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            Console.WriteLine("c = {0} + {1}i", c.Real, c.Imag);
            Console.WriteLine("d = {0} + {1}i", d.Real, d.Imag);

            Console.WriteLine("Задание 2");

            Student f = new Student() { Name = "Alexander", Age = 54, Gender = "Male", Height = 1.82, SecondName = "Petrov", HairColor = "Pink" };
            Student M = new Student() { Name = "Petr", Age = 85, Gender = "Male", Height = 1.57, SecondName = "Ivanov", HairColor = "White" };
            Student j = new Student() { Name = "Anna", Age = 44, Gender = "Female", Height = 1.63, SecondName = "Sidorova", HairColor = "Brown" };
            Student k = new Student() { Name = "Boris", Age = 33, Gender = "Male", Height = 1.95, SecondName = "Serkov", HairColor = "red" };

            f.Height_(M);
            j.Gender_(k);
            M.SecondName_(k);

            //Выведем результат
            Console.WriteLine("New Alexander height = {0}", f.Height);
            Console.WriteLine("New Anna's gender = {0}", j.Gender );
            Console.WriteLine("New Boris's secondname = {0}", M.SecondName );


        }
    }
}