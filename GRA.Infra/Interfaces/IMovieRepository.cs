using GRA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Infra.Interfaces
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
        public Task<List<Movie>> GetWinners();
    }
}
