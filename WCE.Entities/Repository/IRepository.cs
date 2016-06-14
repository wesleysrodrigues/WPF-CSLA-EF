using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCE.Entities
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
       IList<TEntity> GetAll();

       TEntity GetById(int id);
    }
}
