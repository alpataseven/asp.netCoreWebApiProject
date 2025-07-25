﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.Concrete;
using Hotelier.DataAccessLayer.Repositories;
using Hotelier.EntityLayer.Concrete;

namespace Hotelier.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }
    }
}
