﻿using SignalR.DataAccsessLayer.Abstract;
using SignalR.DataAccsessLayer.Concrete;
using SignalR.DataAccsessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccsessLayer.EntityFramework
{
    public class EFSocialMediaDal : GenericRepository<SocailMedia>, ISocialMediaDal
    {
        public EFSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}
