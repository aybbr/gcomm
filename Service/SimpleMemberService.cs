using Data.Infrastructure;
using Data.Models;
using Domain.Entities;
using Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class SimpleMemberService : Service<simplemember>, ISimpleMemberService
    {


 
        //public ProductService(IUnitOfWork ut)
        //    : base(ut)
        //{
        //    this.ut = ut;

        //}
        public SimpleMemberService()
        {



        }
       
    }

   public interface ISimpleMemberService : IService<simplemember>
    {
       
   }
}
