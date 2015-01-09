using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibreryApp
{
    class Student
    {
        public string Name { set; get; }
        public string Id { set; get; }
        public string Department { set; get; }

        public Librery StudentLibrery { set; get; }
    }
}
