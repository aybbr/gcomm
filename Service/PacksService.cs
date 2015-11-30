using Data.Infrastructure;
using Domain.Entities;
using Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PacksService : Service<pack>, IPacksService
    {


      
        //public ProductService(IUnitOfWork ut)
        //    : base(ut)
        //{
        //    this.ut = ut;

        //}
        public PacksService()
        {

            

        }
    }

    public interface IPacksService : IService<pack>
    {

    }
}
