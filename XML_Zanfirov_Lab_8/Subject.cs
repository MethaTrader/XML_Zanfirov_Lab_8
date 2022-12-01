using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Zanfirov_Lab_8
{
    //[Serializable]
    public class Subject
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string Department { get; set; }
        public int Course { get; set; } 
        public int Semester { get; set; }
        public int Hours { get; set; }

        public Subject() { }

        public Subject(string name, string teacher, string department, int course, int semester, int hours)
        {
            Name = name;
            Teacher = teacher;
            Department = department;
            Course = course;
            Semester = semester;
            Hours = hours;
        }

        public override string ToString()
        {
            return $"Назва дисципліни: {Name}\n" +
                $"Викладач: {Teacher}\n" +
                $"Кафедра: {Department}\n" +
                $"Курс: {Course}\n" +
                $"Семестр: {Semester}";
        }
    }

}
