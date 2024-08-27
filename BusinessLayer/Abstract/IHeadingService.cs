﻿using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IHeadingService
	{
		List<Heading> GetList();
		void HeadingAdd(Heading heading);
		Heading GetByID(int id);
		void HeadingDelete(Heading heading);
		void HeadingUpdate(Heading heading);

	}
}
