using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.MentorGroup
{
    public class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Student> studentInfo = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of dates")
                {
                    break;
                }
            
                string[] dateInfo = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                

                List<DateTime> attDateList = new List<DateTime>();
                for (int i = 1; i < dateInfo.Length; i++)
                {
                    attDateList.Add(DateTime.ParseExact(dateInfo[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                string name = dateInfo[0];
                Student student = new Student();
                student.Name = name;
                student.Dates = new List<DateTime>();
                student.Dates = attDateList;
                if (studentInfo.Any(s => s.Name == name))
                {
                    Student existingStud = studentInfo.First(s => s.Name == name);
                    existingStud.Dates = existingStud.Dates.Concat(attDateList).ToList();
                }
                else
                {
                    studentInfo.Add(student);
                }
            }
            
            while (true)
            {
                string inputCommets = Console.ReadLine();
                if (inputCommets == "end of comments")
                {
                    break;
                }
                
                string[] commentsInfo = inputCommets.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!studentInfo.Any(s => s.Name == commentsInfo[0])) { continue; }

                string name = commentsInfo[0];
                string comment = commentsInfo[1];
                foreach (var stud in studentInfo.Where(s => s.Name == name))
                {
                    if (stud.Comments != null)
                    {
                        stud.Comments.Add(comment);
                    }
                    else
                    {
                        stud.Comments = new List<string>();
                        stud.Comments.Add(comment);
                    }
                }
                
                
            }
            foreach (var student in studentInfo.OrderBy(s => s.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comments != null)
                {
                    foreach (var comm in student.Comments)
                    {
                        Console.WriteLine("- {0}", comm);
                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(d => d))
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}
