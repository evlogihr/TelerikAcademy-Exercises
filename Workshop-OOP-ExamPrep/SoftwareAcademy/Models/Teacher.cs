namespace SoftwareAcademy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using SoftwareAcademy.Interfaces;

    public class Teacher: ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        // TODO: optimize code with StringBuilder
        public override string ToString()
        {
            string format = "Teacher: Name={0}";
            if (this.courses.Count > 0)
            {
                format += "; Courses=[{1}]";
            }

            var courseNames = this.courses.Select(x => x.Name);
            string result = string.Format(format, this.Name, string.Join(", ", courseNames));

            return result;
        }
    }
}
