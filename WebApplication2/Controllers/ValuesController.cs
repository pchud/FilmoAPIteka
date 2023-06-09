using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetDataFromExternalApi()
        {
            using HttpClient httpClient = new HttpClient();
                string apiUrl = "https://filmy.programdemo.pl/MyMovies"; // Adres URL zewnętrznego API

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
                    //var data = JsonSerializer.Deserialize<Dictionary<string, string>>(responseBody);
                    // Przetwarzanie otrzymanych danych
                    List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(responseBody, options);


                    return Ok(movies);
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
