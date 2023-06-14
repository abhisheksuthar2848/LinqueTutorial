using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.QuerySysntex
{
    public class LinqQuerySyntax
    {
        public void Example()
        {
            List<int> IntigerList = new List<int>() { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("----------- LinqQuerySyntax-----------");

            var querySyntex = from obj in IntigerList
                              where obj > 5
                              select obj;

            foreach (var item in querySyntex)
            {
                Console.WriteLine(item);

            }
        }
    }
}
