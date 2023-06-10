using Domain.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        Movie Add(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);

    }
}
