using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities.Concrete
{
    public  class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public Category( int ıd, string name ) 
        {
            Id=ıd; 
            Name=name;
        
        
        }


    }
}
