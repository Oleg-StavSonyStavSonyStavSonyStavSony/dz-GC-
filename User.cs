using System;

namespace dz_GC_
{
    public class User : IDisposable{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public User (string first, string last, string middle, int age){
            FirstName = first;
            LastName = last;
            MiddleName = middle;
            Age = age;
        }
        public override string ToString(){
            return $"{FirstName}-{LastName}-{MiddleName}";
        }
        public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }
        
    }

}