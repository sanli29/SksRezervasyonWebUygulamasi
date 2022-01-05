﻿using SksRezervasyon.DataAccess.Abstract;
using SksRezervasyon.DataAccess.Repositories;
using SksRezervasyon.Core.Repository;
using SksRezervasyon.Core.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SksRezervasyon.DataAccess.Concretes
{
    public class TesiRepository : EFRepository<Tesi>, ITesiRepository, IDisposable
    {
        public TesiRepository(SksRezervasyonDbContext context) : base(context)
        {


        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}


