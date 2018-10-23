using System.IO;

namespace StudentMinMax
{
    class Student
    {
        public string StudentData { get; set; }
        public string StudentGrade { get; set; }
        public string StudentGrade2 { get; set; }
        public string StudentName { get; set; }
        public int StudentMin { get; set; }
        public int StudentMax { get; set; }
     
        StreamReader sr = new StreamReader(@"c:\users\breon\source\repos\StudentMinMax\StudentMinMax\studentdata.txt");
        
        //Storing streamreader data.
        public string ReadData()
        {
            StudentData = sr.ReadLine();
            return StudentData;
        }

        //Replacing all the numbers and spaces in the string with empty strings.
        public string FindStudentName()
        {
            for (int i = 0; i < StudentData.Length; i++)
            {
                if (StudentData[i] == '1')
                {
                    StudentData = StudentData.Replace("1", "");
                    i--;
                }
                else if (StudentData[i] == '2')
                {
                    StudentData = StudentData.Replace("2", "");
                    i--;
                }
                else if (StudentData[i] == '3')
                {
                    StudentData = StudentData.Replace("3", "");
                    i--;
                }
                else if (StudentData[i] == '4')
                {
                    StudentData = StudentData.Replace("4", "");
                    i--;
                }
                else if (StudentData[i] == '5')
                {
                    StudentData = StudentData.Replace("5", "");
                    i--;
                }
                else if (StudentData[i] == '6')
                {
                    StudentData = StudentData.Replace("6", "");
                    i--;
                }
                else if (StudentData[i] == '7')
                {
                    StudentData = StudentData.Replace("7", "");
                    i--;
                }
                else if (StudentData[i] == '8')
                {
                    StudentData = StudentData.Replace("8", "");
                    i--;
                }
                else if (StudentData[i] == '9')
                {
                    StudentData = StudentData.Replace("9", "");
                    i--;
                }
                else if (StudentData[i] == '0')
                {
                    StudentData = StudentData.Replace("0", "");
                    i--;
                }
                else if (StudentData[i] == ' ')
                {
                    StudentData = StudentData.Replace(" ", "");
                    i--;
                }
                else
                {
                }
            }
            return StudentData;
        }
    }
}
