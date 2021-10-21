using System;
using System.Collections.Generic;

namespace dz_GC_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tStart = DateTime.Now;
            DateTime tEnd ;
            Console.WriteLine($"Start - {tStart}");
            int cool = 10000000 ;
            using( Listt listUser= new Listt()){
            for (var i = 0; i < cool; i++){
                listUser.ADD(new User ("FirstName"+i.ToString(),"LastName"+i.ToString(),"MiddleName"+i.ToString(),18));
                }
            }
            // listUser.ForEach(Console.WriteLine);
            Console.WriteLine(DateTime.Now);
            GC.Collect();
            tEnd = DateTime.Now;
            Console.WriteLine($"End - {tEnd}");


            Console.WriteLine("difference - " + (tEnd.Subtract(tStart)).ToString());
            

        }
    }
}
