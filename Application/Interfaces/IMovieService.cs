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
        MovieDto AddMovie(CreateExtMovieDto movie);
        MovieDto UpdateMovie(UpdateMovieDto updateMovie);
        void DeleteMovie(int id);
    }
}
