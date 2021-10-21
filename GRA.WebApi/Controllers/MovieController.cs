using GRA.Domain.Entities;
using GRA.Service.DTO;
using GRA.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.WebApi.Controllers
{

    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        /// <summary>
        /// Intervalo de prêmios
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getwinnersinterval")]
        public async Task<IActionResult> GetWinnersInterval()
        {
            try
            {
                return Ok(await _movieService.GetWinnersInterval());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
