using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019_10
{
    class Student
    {
        public double ExamPercent { get; private set; }
        public double AttendancePercent { get; private set; }
        public Student(double examPercent, double attendancePercent)
        {
            if (examPercent > 1.0 || attendancePercent > 1.0) throw new ArgumentOutOfRangeException();
            if (examPercent < 0.0 || attendancePercent < 0.0) throw new ArgumentOutOfRangeException();
            ExamPercent = examPercent;
            AttendancePercent = attendancePercent;
        }
    }
}
