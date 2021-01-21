using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public DateTime BirthDate { get; set; }

        public string NickName
        {
            get
            {
                return Name + " " + LastName1;
            }
        }

    }
}
