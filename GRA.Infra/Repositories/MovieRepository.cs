using GRA.Domain.Entities;
using GRA.Infra.Context;
using GRA.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Infra.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        private readonly DataBaseContext _context;
        public MovieRepository(DataBaseContext ctx) : base(ctx)
        {
            _context = ctx;
        }

        public async Task<List<Movie>> GetWinners()
        {
            return await _context.Movies.Where
                (
                    x => x.Winner.Equals("yes")
                )
                .AsNoTracking()
                .ToListAsync();


        }
    }
}
