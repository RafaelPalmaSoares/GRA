using CsvHelper;
using GRA.Domain.Entities;
using GRA.Domain.Mappers;
using GRA.Infra.Interfaces;
using GRA.Service.DTO;
using GRA.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Service.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IntervalDTO> GetWinnersInterval()
        {
            var interval = _movieRepository.GetWinners().Result.GroupBy(producers => producers.Producers)
                      .Select(x => new ProducerDTO
                      {
                          Producer = x.Key,
                          Interval = x.Max(y => y.Year) - x.Min(y => y.Year),
                          PreviousWin = x.Min(y => y.Year),
                          FollowingWin = x.Max(y => y.Year)
                      }).ToList();

            return CalculateInterval(interval);
        }

        public void LoadCSV(string path)
        {
            var records = new List<Movie>();
            using (var fs = new StreamReader(path, Encoding.Default))
            using (var csv = new CsvReader(fs))
            {
                csv.Configuration.RegisterClassMap<MovieMap>();
                records = csv.GetRecords<Movie>().ToList();
            }

            if (records.Any())
            {
                records.ForEach(item =>
                {
                    if (item.Validate())
                        _movieRepository.Create(item);
                });
            }
        }

        private IntervalDTO CalculateInterval(List<ProducerDTO> lstProducers)
        {
            var intervalDTO = new IntervalDTO();

            var max = lstProducers.Where(x => x.Interval == lstProducers.Max(t => t.Interval)).Select(p => p).ToList();
            lstProducers.RemoveAll(producers => max.Any(max => producers.Producer.Equals(max.Producer)));
            var min = lstProducers.Where(x => x.Interval > 0).Select(p => p).ToList();

            intervalDTO.Max.AddRange(max);
            intervalDTO.Min.AddRange(min);

            return intervalDTO;
        }
    }
}
