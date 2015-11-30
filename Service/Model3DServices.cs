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
    public class Model3DServices : Service<model3d>, IModel3DService
    {

        public Model3DServices()

        {



        }

      
    }
    public interface IModel3DService : IService<model3d>
    {

    }
}
