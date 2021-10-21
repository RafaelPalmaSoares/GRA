using GRA.Domain.Entities;
using GRA.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Service.Interfaces
{
    public interface IMovieService
    {
        void LoadCSV(string path);

        Task<IntervalDTO> GetWinnersInterval();
    }
}
