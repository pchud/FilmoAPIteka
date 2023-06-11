using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;
using Domain.Entieties;
using Application.Interfaces;
using Infrastructure.Repositories;
using Application.Dto;

namespace MyMoviesAPI.Controllers
{
    [ApiController]
    [Route("api/extMovies")]
    public class ExternalMoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        private string apiUrl = "https://filmy.programdemo.pl/MyMovies"; 

        public ExternalMoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDataFromExternalApi()
        {
            
            using HttpClient httpClient = new HttpClient();
                
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {       
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    List<CreateExtMovieDto> Movies = JsonSerializer.Deserialize<List<CreateExtMovieDto>>(responseBody, options);
                    List<MovieDto> AddedMovies = new List<MovieDto>();

                    foreach(CreateExtMovieDto Movie in Movies)
                    {
                        var allMovies = _movieService.GetAllPosts();
                        if(!allMovies.Any(movieDb => movieDb.ExtId == Movie.ExtId))
                            AddedMovies.Add(_movieService.AddMovie(Movie));
                    }
                        return Ok(AddedMovies);
                }
                else
                {
                    // Jeśli odpowiedź z API ma status inny niż 2xx
                    return StatusCode((int)response.StatusCode, "Błąd wewnętrzny API");
                }
            }
            catch (HttpRequestException)
            {
                // Obsługa błędów sieciowych
                return StatusCode(500, "Błąd sieci");
            }
            }

    }   



}
