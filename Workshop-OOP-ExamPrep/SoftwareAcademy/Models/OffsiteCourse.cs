
namespace SoftwareAcademy.Models
{
    using System;
    using SoftwareAcademy.Interfaces;

    public class OffsiteCourse : Course, IOffsiteCourse, ICourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            :base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}; Town={1}", base.ToString(), this.Town);
        }
    }
}
