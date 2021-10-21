using System;
using System.Collections.Generic;

namespace dz_GC_
{
    public class Listt : IDisposable{
        public List<User> listUser;
        public Listt(){
            listUser = new List<User>();
        }
        public void ADD(User user){
            listUser.Add(user);

        }



         public  void Dispose(){
            GC.Collect(GC.GetGeneration(this));
        }
    }

}