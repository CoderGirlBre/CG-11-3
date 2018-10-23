using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentMinMax
{
    class Grade
    {
        public List<int> Grades { get; set; }
        public int MinGrade { get; set; }
        public int MaxGrade { get; set; }
        
        public List<int> FindGrades(string studentdata)
        {
            //Seperating names from #'s.
            studentdata = studentdata.Substring(studentdata.IndexOf(' ') + 1);

            //Seprating each number into an item in the list.
            List<int> grades = new List<int>(Array.ConvertAll(studentdata.Split(' '), int.Parse));
            Grades = grades;
            return Grades;
        }

        public int FindMinGrade()
        {
            for (int i = 0; i < (Grades.Count - 1); i++)
            {
                //if the current grade is less than the next grade.
                if (Grades[i] >= Grades[i + 1])
                {
                    Grades.RemoveAt(i);
                    i--;
                }
                else
                {
                    Grades.RemoveAt(i + 1);
                    i--;
                }
            }
            int temp = Convert.ToInt32(Grades.Average());
            return temp;
        }
        
        public int FindMaxGrade()
        {
            for (int i = 0; i < (Grades.Count - 1); i++)
            {
                //if the current grade is more than the next grade.
                if (Grades[i] <= Grades[i + 1])
                {
                    Grades.RemoveAt(i);
                    i--;
                }
                else
                {
                    Grades.RemoveAt(i + 1);
                    i--;
                }
            }
            int temp = Convert.ToInt32(Grades.Average());
            return temp;
        }
    }
}
