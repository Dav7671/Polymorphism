using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            var teachers = new List<Teacher>
            {
             new MathTeacher(),
             new PhysicsTeacher(),
             new HistoryTeacher()
            };

            foreach (var teacher in teachers)
            {
                teacher.ToTeach();
            }

            Console.ReadKey();
        }

        public class Teacher
        {
            private string Name { get; set; }
            private string Subject { get; set; }

            public virtual void ToTeach()
            {
                Console.WriteLine("Teaches");
            }
        }

        public class MathTeacher : Teacher
        {
            public override void ToTeach()
            {      
                Console.WriteLine("Teaches mathematics");
                base.ToTeach();
            }
        }

        public class PhysicsTeacher : Teacher
        {
            public override void ToTeach()
            {
                Console.WriteLine("Teaches mathematics");
                base.ToTeach();
            }
        }

        public class HistoryTeacher : Teacher
        {
            public override void ToTeach()
            {
                Console.WriteLine("Teaches history");
                base.ToTeach();
            }
        }
    }




}
