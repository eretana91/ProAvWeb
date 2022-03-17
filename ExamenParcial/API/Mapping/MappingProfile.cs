using AutoMapper;
using data = DAL.DO.Objects;
using AutoMapper;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {
            public MappingProfile()
            {
                CreateMap<data.Autores, DataModels.Autores>().ReverseMap();
                CreateMap<data.Libros, DataModels.Libros>().ReverseMap();
            }
    }

}
