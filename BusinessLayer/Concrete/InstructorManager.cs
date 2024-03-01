using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class InstructorManager : IInstructorService
	{
		IInstructorDal _instructorDal;

		public InstructorManager(IInstructorDal instructorDal)
		{
			_instructorDal = instructorDal;
		}

		public void TAdd(Instructor t)
		{
			_instructorDal.Add(t);
		}

		public void TDelete(Instructor t)
		{
			_instructorDal.Delete(t);	
		}

		public Instructor TGetById(int id)
		{
		    return _instructorDal.GetById(id);	
		}

		public List<Instructor> TGetList()
		{
			return _instructorDal.GetList();
		}

		public List<Instructor> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Instructor t)
		{
			_instructorDal.Update(t);
		}
	}
}
