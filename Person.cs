using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        //public string Name;


        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        /*private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
*/


        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

       /* public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }*/
    }
}
