using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProducRepository : IRepository<Product>
    {
       
    }
    public class ProducRepository: RepositoryBase<Product>, IProducRepository
    {
        public ProducRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }

       
    }
}
