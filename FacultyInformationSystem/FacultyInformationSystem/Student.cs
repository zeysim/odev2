using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    abstract class Student
    {
        private int id;
        private string name,lastName,department;
        
        public int getId
        {
            get { return id; }
        }

        public string getName
        {
            get { return name; }
        }

        public string getLastName
        {
            get { return lastName; }
        }

        public string getDepartment
        {
            get { return department; }
            set { department = value; }
        }
        public Student()
        {

        }
        public Student(int id, string name, string lastName, string department)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.department = department;
        }
    }
}
