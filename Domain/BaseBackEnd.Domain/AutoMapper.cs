using AutoMapper;
using BaseBackEnd.Domain.ViewModel;
using GestaoMonetariaApi.Domain.Entities;

namespace BaseBackEnd.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeia CategoriaViewModel para CategoriaEntity (e vice-versa)
            CreateMap<CategoriaViewModel, CategoriaEntity>()
                .ReverseMap();

            // Mapeia OperacaoViewModel para OperacaoEntity (e vice-versa)
            CreateMap<OperacaoViewModel, OperacaoEntity>()
                .ReverseMap();
        }
    }
}
