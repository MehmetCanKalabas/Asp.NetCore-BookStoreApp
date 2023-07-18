using AutoMapper;
using Entities.DTO_s;
using Entities.Models;
using System.Xml.Linq;

namespace WebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDtoForUpdate, Book>();
        }
    }
}
