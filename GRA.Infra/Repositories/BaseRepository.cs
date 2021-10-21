using GRA.Domain.Entities;
using GRA.Infra.Context;
using GRA.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly DataBaseContext _context;

        public BaseRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void Create(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
