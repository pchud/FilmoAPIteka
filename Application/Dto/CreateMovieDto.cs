using Application.Mappings;
using AutoMapper;
using Domain.Entieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class CreateMovieDto : IMap
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public int Rate { get; set; }
        [JsonPropertyName("Id")]
        public int ExtId { get; set; }  

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateMovieDto, Movie>();
        }
    }
}
