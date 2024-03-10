using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment
{
    internal class GPAcalculator
    {
        List<Course> courselist = new List<Course>(){};
        public void UserInput()
        {
                Console.WriteLine("Please input your Course name (e.g: Maths-101)");
    string courseName = Console.ReadLine();
    again:
    Console.WriteLine("Please input your Course code (e.g: 101)");
    int courseCode;
    if (!int.TryParse(Console.ReadLine(), out courseCode))
    {
        Console.WriteLine("The input is invalid, Please enter a positive integer greater than Zero");
        goto again;
    }
    
    string courses = courseName + " " + courseCode.ToString();
Goback:
    Console.WriteLine("Please input your Course Unit?");
    int courseUnit;
    if (!int.TryParse(Console.ReadLine(), out courseUnit))
    {
        Console.WriteLine("The input is invalid, Please enter a positive integer greater than Zero");
        goto Goback;
    }
decide:
    Console.WriteLine("Please input what you scored?");
    int score;
    if(!int.TryParse(Console.ReadLine(),out score))
    {
        Console.WriteLine("The input is invalid, Please enter a positive integer greater than Zero");
        goto decide;
    }
    int gradeUnit = GradeUnit(score);
    int qualityPoint = CalcQualityPoint(courseUnit, gradeUnit);
    char grade = Grade(score);
    //var course = new Course(courseName, courseUnit, score, grade, gradeUnit,qualityPoint);  
    courselist.Add(new Course(courses,courseUnit,score,grade,gradeUnit,qualityPoint));

        }

        public void CreateTable()
        {
            var newTable = new ConsoleTable("Course Name", "Course Unit", "Score", "Grade", "Grade Unit");
            foreach (var course in courselist)
            {
                newTable.AddRow(course.CourseName,course.CourseUnit,course.Score,course.Grade,course.GradeUnit);
            }
            newTable.Write();
          
        }

        public int GradeUnit(int score)
        {
            int gradeUnit;
            if (score >= 70 && score <= 100)
            {
                char grade = 'A';
                 gradeUnit = 5;
            }
            else if (score >= 60)
            {
                char grade = 'B';
                gradeUnit = 4;
            }
            else if (score >= 50)
            {
                char grade = 'C';
                 gradeUnit = 3;
            }
            else if (score >= 45)
            {
                char grade = 'D';
                 gradeUnit = 2;
            }
            else if (score >= 40)
            {
                char grade = 'E';
                 gradeUnit = 1;
            }
            else
            {
                char grade = 'F';
                 gradeUnit = 0;
            }
            return gradeUnit;
        }
        public char Grade(int score)
        {
            char grade;
            if (score >= 70 && score <= 100)
            {
                grade = 'A';
               
            }
            else if (score >= 60)
            {
                grade = 'B';
                
            }
            else if (score >= 50)
            {
                 grade = 'C';
               
            }
            else if (score >= 45)
            {
               grade = 'D';
               
            }
            else if (score >= 40)
            {
                grade = 'E';
              
            }
            else
            {
                grade = 'F';
                
            }
            return grade;
        }
        public int CalcQualityPoint(int courseUnit, int gradeUnit)
        {
            int qualityPoint = courseUnit * gradeUnit;

            return qualityPoint;
        }
        public double GPAcalc()
        {
            int totalQualityPoint = 0;
            int totalCourseUnit = 0;
            foreach(Course cl in courselist)
            {
                totalQualityPoint += cl.QualityPoint;
                totalCourseUnit += cl.CourseUnit;
            }

            double GPA = totalQualityPoint / totalCourseUnit; 
           
            return GPA;
        }

        public void Result()
        {
           /* foreach (Course course in courselist)
            {
                Console.WriteLine("CourseName:{0},",course.CourseName);
                Console.WriteLine("CourseUnit: {0}", course.CourseUnit);
                Console.WriteLine("Score: {0}", course.Score);
                Console.WriteLine("Grade: {0}", course.Grade);
                Console.WriteLine("Grade Unit: {0}", course.GradeUnit);
            }*/
           double gpa = GPAcalc();
            Console.WriteLine("Your G.P.A for this semester is {0:N2}", gpa);
        }
    }

}

