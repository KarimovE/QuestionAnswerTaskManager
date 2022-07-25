using AutoMapper;
using QATask.DomainModels;
using QATask.DomainModels.DTOs;
using QATask.DomainModels.Entities;

namespace QATask.Services.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Answer, AnswerDto>().ReverseMap();


        }
    }
}
