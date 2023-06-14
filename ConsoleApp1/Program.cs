using ConsoleApp1.IEnumerable_and_IQueryable;
using ConsoleApp1.QuerySysntex;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinqQuerySyntax linqQuerySyntax = new LinqQuerySyntax();
            linqQuerySyntax.Example();


            LinqMethodSyntax linqMethodSyntax = new LinqMethodSyntax();
            linqMethodSyntax.Example();

            LinqMixSyntax linqMixSyntax = new LinqMixSyntax();
            linqMixSyntax.Example();


            IEnumerableExample objEnumerableExample=new IEnumerableExample();
            objEnumerableExample.Example();

            IQueryableExample queryableExample=new IQueryableExample();
            queryableExample.Example();







            Console.ReadKey();

        }
    }
}
