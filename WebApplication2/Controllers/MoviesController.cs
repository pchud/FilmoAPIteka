using Application.Dto;
using Application.Interfaces;
using Domain.Entieties;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MyMoviesAPI.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [SwaggerOperation(Summary = "Retrives all movies")]
        [HttpGet]
        public IActionResult Get()
        {
            var movies = _movieService.GetAllPosts();
            return Ok(movies);
        }

        [SwaggerOperation(Summary = "Retrives a specific movie by unique id")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if(movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [SwaggerOperation(Summary = "Add a new movie")]
        [HttpPost]
        public IActionResult Add(CreateMovieDto newMovie)
        {
            var movie = _movieService.AddMovie(newMovie);
            return Created($"api/movies/{movie.Id}", movie);
        }

        [SwaggerOperation(Summary = "Update a existing movie")]
        [HttpPut]
        public IActionResult Update(UpdateMovieDto updateMovie)
            {
            var movie = _movieService.UpdateMovie(updateMovie);
            return Ok(movie);
        }

        [SwaggerOperation(Summary = "Delete a existing movie")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _movieService.DeleteMovie(id);
            return NoContent();
        }
    }
}
