using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ispit2019_10
{
    class Program
    {
        public static List<Student> NoAttendanceRemover(List<Student> studenti)
        {
            for (int i = studenti.Count-1; i>=0;i--)
            {
                if(studenti[i].AttendancePercent < 0.001)
                {
                    studenti.RemoveAt(i);
                }
            }
            return studenti;
        }
        static void Main(string[] args)
        {
            List<Student> students = RetrieveStudentsFromISVU();
            if(students.Count/2 > NoAttendanceRemover(students).Count )
            {
                Console.WriteLine("Vise od pola studenata nije dolazilo na nastavu!");
            }

        }
    }
}
