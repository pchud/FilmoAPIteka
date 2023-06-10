using AutoMapper;
using Application.Dto;
using Domain.Entieties;

namespace Application.Mappings
{
    public static class AutoMapperConfig 
    {
        public static IMapper Initialize() => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Movie, MovieDto>();
            cfg.CreateMap<CreateMovieDto, Movie>();
            cfg.CreateMap<UpdateMovieDto, Movie>();
        })
        .CreateMapper();
    }
}
