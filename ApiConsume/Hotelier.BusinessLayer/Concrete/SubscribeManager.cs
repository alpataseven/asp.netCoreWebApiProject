﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.EntityLayer.Concrete;

namespace Hotelier.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe TGetByID(int id)
        {
            return _subscribeDal.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
            return _subscribeDal.GetList();
        }

        public void TInsert(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}
