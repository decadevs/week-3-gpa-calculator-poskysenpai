using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment
{
    internal class Course
    {
        public string Courses { get; set; }
        public int CourseUnit { get; set; }
        public int Score { get; set; }
        public char Grade { get; set; }

        public int GradeUnit { get; set; }
        public int QualityPoint { get; set; }

        public Course(string courses, int courseUnit, int score, char grade,int gradeUnit, int qualityPoint)
        {
            Courses = courses;
            CourseUnit = courseUnit;
            Score = score;
            Grade = grade;
            GradeUnit = gradeUnit;
            QualityPoint = qualityPoint;

        }
    }
}
