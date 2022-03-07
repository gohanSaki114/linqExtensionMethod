using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linqprac
{

    public class linqcheck
    {


        public void bringDecending(List<string> cities)
        {
            IEnumerable ts = cities.OrderByDescending(c => c);  
            Console.WriteLine("By Decending" + "\n");
            foreach (string s in ts)
            {
                Console.WriteLine(s);

            }

            Console.WriteLine("");
        }

        public void bringAcecending(List<string> cities)
        {
            IEnumerable ts = cities.OrderBy(c => c);    
            Console.WriteLine("By Ascending" + "\n");
            foreach (string s in ts)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");
        }

        public void bringDecendingOrderBylength(List<string> cities)
        {
            IEnumerable resultset = cities.OrderByDescending(x => x.Length);
           
            Console.WriteLine("Decending order by length" + "\n");
            foreach (string s in resultset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public void bringAcecendingOrderBylength(List<string> cities)
        {

            var ts1 = cities.OrderBy(c => c.Length);    
            Console.WriteLine("Acecending order by length" + "\n");

            foreach (string s in ts1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public void getNamewithVandD(List<string> cities)
        {
            IEnumerable resultset = cities.Where(c => c.StartsWith("V") || c.StartsWith("D"));
            Console.WriteLine("Bring Data that starts with V and D");
            foreach (string s in resultset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public void getNameStartsWithA(List<string> cities)
        {
            IEnumerable<string> resultset = cities.Where(c => c.StartsWith("A"));


            Console.WriteLine("number of results that start with A");

            Console.WriteLine(resultset.Count());
            Console.WriteLine();
        }

        private void getOrderedCityNamebyFirstletter(List<string> cities)
        {
            var result = cities.GroupBy(c => c[0]);
            //Console.WriteLine(Format("");

            foreach (IGrouping<char, string> Group in result)
            {
                Console.WriteLine(("GroupID = " + Group.Key));
                foreach (var cx in Group)
                {
                    Console.WriteLine(cx);
                }
            }
        }
        public static void Main(string[] args)
        {

            List<string> cities = new List<string>
              {
               "Mumbai",
               "Delhi",
               "Ahmedabad",
               "Surat",
               "Valsad",
               "Varanasi",
               "Chennai",
               "Bhopal",
               "Darjeeling",
               };
            linqcheck linqc = new linqcheck();
            linqc.bringDecending(cities);
            linqc.bringAcecending(cities);
            linqc.bringDecendingOrderBylength(cities);
            linqc.bringAcecendingOrderBylength(cities);
            linqc.getNamewithVandD(cities);
            linqc.getNameStartsWithA(cities);
            linqc.getOrderedCityNamebyFirstletter(cities);

        }

        
    }




}

