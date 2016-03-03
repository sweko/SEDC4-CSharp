using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC
{
    public class Subject
    {
        public string Name { get; set; }
        public Proffesor Lecturer { get; set; }
        public Assistant Assistant { get; set; }
        public List<Student> Students { get; set; }
    }
}
