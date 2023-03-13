using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019_10
{
    interface IGrader
    {
        public Student[] Graded(Student[] studenti);
        public double AverageGrade(Student[] studenti);
    }
}
