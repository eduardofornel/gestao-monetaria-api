using BaseBackEnd.Application.Interfaces.Services;
using BaseBackEnd.Domain.Entities;
using BaseBackEnd.Domain.Interfaces.Repositories;

namespace BaseBackEnd.Application.Services
{
    public class OperacaoService : BaseService<OperacaoEntity>, IOperacaoService
    {
        private readonly IOperacaoRepository _repository;

        public OperacaoService(IOperacaoRepository repository)
            : base(repository)
        {
            this._repository = repository;
        }
    }
}
