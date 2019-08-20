using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Education
{
    public class Degree
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public float GPA { get; set; }
        public string Institute { get; set; }

        public static implicit operator List<object>(Degree v)
        {
            throw new NotImplementedException();
        }
    }
}
