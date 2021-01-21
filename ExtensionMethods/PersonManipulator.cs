using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class PersonManipulator
    {
        public static int GetCalculatedAge(this Person person)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - person.BirthDate.Year;

            if (now.Month < person.BirthDate.Month || (now.Month == person.BirthDate.Month && now.Day < person.BirthDate.Day))
                age--;

            return age;
        }

        public static string GetCompleteName(this Person person)
        {
            return person.Name + " "  + person.LastName1 + " "  + person.LastName2;
        }
    }
}
