using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyInformationSystem
{
    class Graduate:Student
    {
        public Graduate()
        {

        }
        public Graduate(int id, string name, string lastName, string department) : base(id, name,lastName,department)
        {

        }

       
    }
}
