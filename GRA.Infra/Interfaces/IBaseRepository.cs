using GRA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        void Create(T obj);
    }
}
