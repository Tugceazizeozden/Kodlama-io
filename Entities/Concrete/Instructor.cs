using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities.Concrete
{
    public  class Instructor
    {
        public string  Name { get; set; }
        public string Email { get; set; }   
        public Instructor( string name , string email ) 
        {
        Name = name;
        Email = email;  
        
        } 


    }
}
