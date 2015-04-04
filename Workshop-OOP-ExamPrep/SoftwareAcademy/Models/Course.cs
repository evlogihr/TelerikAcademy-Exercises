namespace SoftwareAcademy.Models
{
    using System;
    using System.Collections.Generic;

    using SoftwareAcademy.Interfaces;

    public abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private ICollection<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get { return this.teacher; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            string result = string.Format("{0}: Name={1}", this.GetType().Name, this.Name);

            if (this.Teacher != null)
            {
                result += string.Format("; Teacher={0}", this.Teacher.Name);
            }

            if (this.topics.Count > 0)
            {
                result += string.Format("; Topics=[{0}]", string.Join(", ", this.topics));
            }

            return result;
        }
    }
}
