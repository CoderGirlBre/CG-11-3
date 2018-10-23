using System;

namespace StudentMinMax
{
    class Logic
    {
        public void Run()
        {
            Student student = new Student();
            Grade grade = new Grade();

            //Read a line of data in the .txt file and assign the value of the data to student.StudentData.
            student.StudentData = student.ReadData();
            student.StudentName = student.StudentData;
            student.StudentGrade = student.StudentData;
            student.StudentGrade2 = student.StudentData;
            
            while (student.StudentData != null)
            {
                //assign a value to student.StudentName by removing all numbers from the line of data
                //this should end up as being the student's name
                student.StudentName = student.FindStudentName();
                Console.Write(student.StudentName + " ");

                //assign a value to grade.Grades by removing the name
                //and separating the numbers into a list
                grade.Grades = grade.FindGrades(student.StudentGrade);
                student.StudentMin = grade.FindMinGrade();
                Console.Write(student.StudentMin + " ");

                grade.Grades = grade.FindGrades(student.StudentGrade2);

                student.StudentMax = grade.FindMaxGrade();
                Console.WriteLine(student.StudentMax + " ");
                
                //read a line of data in the .txt file and assign the value of the data to student.StudentData
                //we'll repeat this for each new student whose data we want to read
                student.StudentData = student.ReadData();

                //assign a value to the temporary strings like before
                student.StudentGrade = student.StudentData;
                student.StudentGrade2 = student.StudentData;
            }
        }
    }
}