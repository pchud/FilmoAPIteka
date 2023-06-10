using Domain.Entieties;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly LibraryContext _context;

        public MovieRepository(LibraryContext context) 
        { 
            _context = context; 
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies;
        }

        public Movie GetById(int id)
        {
            return _context.Movies.SingleOrDefault(movie => movie.Id == id);
        }
        public Movie Add(Movie movie)
        {
            movie.Created = DateTime.UtcNow;
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return movie;
        }
        public void Update(Movie movie)
        {
            movie.LastModified = DateTime.UtcNow;
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

    }
}
