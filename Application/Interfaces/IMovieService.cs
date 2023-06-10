using Application.Dto;
using Domain.Entieties;
using System.Collections;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IMovieService
    {

        IEnumerable<MovieDto> GetAllPosts();
        MovieDto GetMovieById(int id);
        MovieDto AddMovie(CreateMovieDto movie);
        void UpdateMovie(UpdateMovieDto updateMovie);
        void DeleteMovie(int id);
    }
}
