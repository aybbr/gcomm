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

        private static IDatabaseFactory dbf = new DatabaseFactory();
        public static IUnitOfWork ut = new UnitOfWork(dbf);
        //public PacksService(IUnitOfWork ut)
        //    : base(ut)
        //{
        //    this.ut = ut;

        //}
        public PacksService()
        {

            

        }

        public List<pack> getAllPacks()
        {
            return ut.getRepository<pack>().GetMany().ToList();
    }

        public pack GetPackById(int id)
        {
            return ut.getRepository<pack>().GetById(id);
        }
    }

    public interface IPacksService : IService<pack>
    {

    }

    
}
