using AutoMapper;
using Application.Mappings;
using System.Collections.Generic;
using Application.Interfaces;
using Domain.Interfaces;
using Application.Dto;
using Domain.Entieties;
using System;

namespace Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }
        public IEnumerable<MovieDto> GetAllPosts()
        {
            var movies = _movieRepository.GetAll();
            return _mapper.Map<IEnumerable<MovieDto>>(movies);
        }

        public MovieDto GetMovieById(int id)
        {
            var movie = _movieRepository.GetById(id);
            return _mapper.Map<MovieDto>(movie);
        }

        public MovieDto AddMovie(CreateMovieDto newMovie)
        {
            if (string.IsNullOrEmpty(newMovie.Title))
            {
                throw new Exception("Post can not have an empty title.");
            }

            var movie = _mapper.Map<Movie>(newMovie);
            _movieRepository.Add(movie);
            return _mapper.Map<MovieDto>(movie);
        }
        public MovieDto AddMovie(CreateExtMovieDto newMovie)
        {
            if (string.IsNullOrEmpty(newMovie.Title))
            {
                throw new Exception("Post can not have an empty title.");
            }

            var movie = _mapper.Map<Movie>(newMovie);
            _movieRepository.Add(movie);
            return _mapper.Map<MovieDto>(movie);
        }
        public MovieDto UpdateMovie(UpdateMovieDto updateMovie)
        {
            var existingMovie = _movieRepository.GetById(updateMovie.Id);
            var movie = _mapper.Map(updateMovie, existingMovie);
            _movieRepository.Update(movie);
            return _mapper.Map<MovieDto>(movie);
        }

        public void DeleteMovie(int id)
        {
            var movie= _movieRepository.GetById(id);
            _movieRepository.Delete(movie);
        }

    }
}
