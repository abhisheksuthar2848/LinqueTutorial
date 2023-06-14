using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.IEnumerable_and_IQueryable
{
    public class IEnumerableExample
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }

        public void Example()
        {
            Console.WriteLine("--------IQuerable-----------");

            List<Student> studentlist = new List<Student>()
            {
                new Student(){Id=1,Name="Abhishek",Gender="Male"},
                new Student(){Id=2,Name="Rakesh",Gender="Male"},
                new Student(){Id=3,Name="Aditi",Gender="Female"},                
                new Student(){Id=4,Name="Bhavesh",Gender="Male"},
                new Student(){Id=5,Name="Poonam",Gender="Female"}
            };

            IEnumerable<Student> QuerySyntex = (from st in studentlist
                                                where st.Name.ToLower().Contains("a")
                                                select st);


            foreach (var item in QuerySyntex)
            {
                Console.WriteLine("Name  : " + item.Name + " Gender : " + item.Gender);
            }

        }

    }
}
