using System;

namespace Project1.Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Person.Name = "Ali";
            student.Person.humain.Age = 21;
            //student.education.Degree = "inter";
            //student.education.Degree.Name = "inter";
            //student.education.Degree = new Degree()
            //{
            //    Name = "BSCS",
            //    Institute = "LGU",
            //    Year = 2017 - 21,
            //    GPA = 3.5f
            //};


            student.education.Degree.Add(new Degree
            {
                Name="Bscs",
                Institute="LGU",
                Year=2017-21,
                GPA=3.2f

            });
            
            Console.ReadKey();
        }
    }
}
