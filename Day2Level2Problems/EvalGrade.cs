using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class EvalGrade
    {
        public static void evaluate()
        {
            Console.WriteLine("Enter Math marks:");
            double math = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter physics marks:");
            double physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks:");
            double chemistry = double.Parse(Console.ReadLine());
            double averageMarks = (math + chemistry + physics) / 3;
            char grade = 'o';
            string remark;
            if (averageMarks >= 80)
            {
                grade = 'A';
                remark = "Level 4, above agency-normalized standards";
            }
            else if(averageMarks >= 70 &&  averageMarks <= 79)
            {
                grade = 'B';
                remark = "Level 3, at agency-normalized standards";
            }
            else if(averageMarks >= 60 && averageMarks <= 69)
            {
                grade = 'C';
                remark = "Level 2, below, but approaching agency-normalized standards";
            }
            else if(averageMarks >= 50 && averageMarks <= 59)
            {
                grade = 'D';
                remark = "Level 1, well below agency-normalized standards";
            }
            else if(averageMarks >= 40 && averageMarks <= 49)
            {
                grade = 'E';
                remark = "Level 1-, too below agency-normalized standards";
            }
            else
            {
                remark = "Remedial Standards";
            }
            Console.WriteLine($"Average Marks: {averageMarks}\nGrade: {grade}\nremarks: {remark}");
        }
    }
}
