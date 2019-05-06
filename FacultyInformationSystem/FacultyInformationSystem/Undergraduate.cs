using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Undergraduate:Student
    {
        public Undergraduate()
        {

        }
        public Undergraduate(int id, string name, string lastName, string department) : base(id,name,lastName,department)
        {

        }
        
    }
}
