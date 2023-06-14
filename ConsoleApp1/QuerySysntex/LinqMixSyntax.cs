using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.QuerySysntex
{
    public class LinqMixSyntax
    {

        public void Example()
        {
            Console.WriteLine("------------LinqMixSyntax----------");
            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11};

            var MixSyntax= (from obj in list
                            where obj > 4
                            select obj).Sum();

            Console.WriteLine(MixSyntax);

        }
    }
}
