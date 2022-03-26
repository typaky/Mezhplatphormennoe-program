using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Student
    { 
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string HairColor { get; set; }
        public double Height { get; set; }

        public void Height_(Student x)
        {
            Height = (Height + x.Height) * 1.1;

        }
        public void SecondName_(Student x)
        {
            SecondName += x.SecondName;
        }
        public void Gender_(Student x)
        {
            Gender += x.Gender;
        }
    }
}
