using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOThreeTier
{
    class Class1
    {
        
        void Sum()
        {
            int[] numbers = { 2, 5, 10 };
            var result = numbers.Sum(); //Linq method  
            Console.WriteLine(result);
        }
        void DisplayNames()
        {
                // Data source  
                string[] names = { "Bill", "Steve", "James", "Mohan", "Kavin", "Kanav" };
                // LINQ Query  
                var myLinqQuery = from ename in names
                                  where ename.Contains('a')
                                  orderby ename descending
                                  select ename;
                var myLinqQuery2 = from n in names
                                   where n.Contains('K')
                                   select n;
                // Query execution  
                foreach (var name in myLinqQuery2)
                    Console.Write(name + " ");
         }
            void Score()
            {
                // Specify the data source.  
                int[] scores = new int[] { 97, 92, 81, 60, 100, 99, 23 };
                // Define the query expression.  
                var scoreQuery =
                from s in scores
                where s > 80
                select s;
                // Execute the query.  
                foreach (int i in scoreQuery)
                {
                    Console.Write(i + " ");
                }
            }
        
    }
}