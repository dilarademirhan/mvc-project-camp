﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class HeadingManager : IHeadingService
	{
		IHeadingDal _headingDal;

		public HeadingManager(IHeadingDal headingDal)
		{
			_headingDal = headingDal;
		}

		public Heading GetByID(int id)
		{
			return _headingDal.Get(x => x.HeadingId == id);
		}

		public List<Heading> GetList()
		{
			return _headingDal.List();
		}
        public List<Heading> GetListByWriter()
        {
            return _headingDal.List(x => x.WriterId == 4);
        }

        public void HeadingAdd(Heading heading)
		{
			_headingDal.Insert(heading);
		}

		public void HeadingDelete(Heading heading)
		{
			_headingDal.Update(heading);
		}

		public void HeadingUpdate(Heading heading)
		{
			_headingDal.Update(heading);
		}
	}
}
