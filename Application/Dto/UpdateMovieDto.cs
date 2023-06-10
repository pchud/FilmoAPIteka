using Application.Mappings;
using AutoMapper;
using Domain.Entieties;

namespace Application.Dto
{
    public class UpdateMovieDto : IMap
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Rate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateMovieDto, Movie>();
        }
    }
}
