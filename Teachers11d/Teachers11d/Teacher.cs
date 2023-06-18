using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Teachers11d
{
    public class Teacher:Inspectorate
    {
        private string teacherName;
        private string schoolName;
        private string classes;
        private string subject;
        private string contract;
        

        public string TeacherName
        {
            get { return teacherName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid teacher name!");
                }
                this.teacherName = value;
            }
        }

        public string SchoolName
        {
            get { return schoolName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter the name of the school!");
                }
                this.schoolName = value;
            }
            
        }

        public string Classes
        {
            get { return classes; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Classes must not be empty!");
                }
                this.classes = value;
            }
        }

        public string Subject
        {
            get { return subject ; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter teacher's subject!");
                }
                 this.subject = value;
            }
        }

        public string Contract
        {
            get { return contract; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Please enter the type of contract(fixed term/permanent)");
                }
                this.contract = value;
            }
        }

        public Teacher(string teacherName,string schoolName ,string classes, string subject, string contract, string inspectorateName ):base(inspectorateName)
        {
            this.TeacherName = teacherName;
            this.SchoolName = schoolName;
            this.Classes = classes;
            this.Subject = subject;
            this.Contract = contract;
        }

        public override void Print()
        {
            Console.WriteLine($"Teacher's name: {this.teacherName}, he is working in: {this.schoolName} and  in: {this.classes}, he is teaching{this.subject} and his contract is: {this.contract}");
        }

        public override void Count()
        {
           
        }

    }
}
