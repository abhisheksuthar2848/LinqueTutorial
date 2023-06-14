using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.QuerySysntex
{
    public class LinqMethodSyntax
    {


        public void Example()
        {
            Console.WriteLine("----------- LinqMethodSyntax-----------");
            List<int> IntigerList = new List<int>() { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 9, 10 };

            var MethodSyntex = IntigerList.Where(x => x >=5).ToList();

            foreach (var item in MethodSyntex)
            {
                Console.WriteLine(item);
            }
        }


    }
}
