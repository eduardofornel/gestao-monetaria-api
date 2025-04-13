using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Domain.Entities;
using GestaoMonetariaApi.Domain.Interfaces.Repositories;

namespace GestaoMonetariaApi.Application.Services
{
    public class CategoriaService : BaseService<CategoriaEntity>, ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}
