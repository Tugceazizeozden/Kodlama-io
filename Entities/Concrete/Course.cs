using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities.Concrete
{
    public  class Course
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; } 
        public string Author { get; set; }  
        public Course( int ıd, string name, string description, string author ) 
        {
         Id=ıd
        ;Name=name; 
         Description=description;   
         Author=author;  
        
        
        } 



    }
}
