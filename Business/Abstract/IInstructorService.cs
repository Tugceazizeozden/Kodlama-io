using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IInstructorService
    {
        void Update (IInstructorService instructor);   
        void Delete (IInstructorService instructor);   
        void Add (IInstructorService instructor);  
        public IList<IInstructorService> GetList();


    }
}
