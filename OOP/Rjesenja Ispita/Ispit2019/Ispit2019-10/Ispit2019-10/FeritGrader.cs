using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ispit2019_10
{
    class FeritGrader : IGrader
    {
        public double MinScore { get; private set; }
        public double MinAttendace { get; private set; }
        public FeritGrader(double minScore, double minAttendance)
        {
            if (minScore > 1.0 || minAttendance > 1.0) throw new ArgumentOutOfRangeException();
            if (minScore < 0.0 || minAttendance < 0.0) throw new ArgumentOutOfRangeException();
            MinScore = minScore;
            MinAttendace = minAttendance;
        }

        public Student[] Graded(Student[] studenti)
        {
            List<Student> lista = new List<Student>();
            for (int i = 0; i < studenti.Length; i++)
            {
                if(studenti[i].AttendancePercent>MinAttendace && studenti[i].ExamPercent>MinScore)
                {
                    lista.Add(studenti[i]);
                }
            }
            return lista.Cast<Student>().ToArray();
        }
        public double AverageGrade(Student[] studenti)
        {
            double averageScore = 0;
            Student[] studentiGraded = Graded(studenti);
            for (int i = 0; i < studentiGraded.Length; i++)
            {
                averageScore += studentiGraded[i].ExamPercent;
            }
            return averageScore / studentiGraded.Length;
        }
    }
}
