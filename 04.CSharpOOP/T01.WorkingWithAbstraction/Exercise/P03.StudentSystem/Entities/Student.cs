using System.Text;

namespace P03.StudentSystem.Entities
{
    public class Student
    {
        //конструктор
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        //пропъртита
        public string Name { get; set; }

        public int Age { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            var student = new StringBuilder();
            student.Append( $"{this.Name} is {this.Age} years old.");

            if (this.Grade >= 5.00)
            {
                student.Append(" Excellent student.");
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                student.Append(" Average student.");
            }
            else
            {
                student.Append(" Very nice person.");
            }
            return student.ToString().TrimEnd() ;
        }
    }
}

