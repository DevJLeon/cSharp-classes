using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace OOPPractice
{
    public class User
    {
        public string Name {get; set;}
        public string Id {get; set;}

        public User (string name , string id){
            this.Name = name;
            this.Id = id;
        }
    }
}