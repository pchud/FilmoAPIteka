using Application.Mappings;
using AutoMapper;
using Domain.Entieties;
using System.Text.Json.Serialization;

namespace Application.Dto
{
    public class MovieDto : IMap
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Rate { get; set; }
        public int ExtId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Movie, MovieDto>();
        }
    }
}
