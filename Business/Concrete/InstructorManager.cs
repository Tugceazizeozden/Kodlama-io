using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {

        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Add(IInstructorService instructor)
        {
            throw new NotImplementedException();
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public void Delete(IInstructorService instructor)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public IList<IInstructorService> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        public void Update(IInstructorService instructor)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Business
{
    public class IInstructorDal
    {
        public  void Add(Concrete.Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public  void Delete(Concrete.Instructor instructor)
        {
            throw new NotImplementedException();
        }

        public  List<Concrete.Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public  void Update(Concrete.Instructor instructor)
        {
            throw new NotImplementedException();
        }
    }
}