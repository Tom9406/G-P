using AutoMapper;
using G_P.Dto;
using G_P.Entities;

namespace G_P.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MatrimoniosDTO, matrimonios>().ReverseMap();
            CreateMap<MatrimoniosCreationDTO, matrimonios>();

            CreateMap<InscrbirDTO, inscribir_matrimoio>().ReverseMap();
            CreateMap<InscribirCreationDTO, inscribir_matrimoio>();
        }
    }
}
