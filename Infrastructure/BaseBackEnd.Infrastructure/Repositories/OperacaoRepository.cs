using BaseBackEnd.Domain.Entities;
using BaseBackEnd.Domain.Interfaces.Repositories;
using BaseBackEnd.Infrastructure.Configurations.Fundation;

namespace BaseBackEnd.Infrastructure.Repositories
{
    public class OperacaoRepository : BaseRepository<OperacaoEntity>, IOperacaoRepository
    {
        public OperacaoRepository(ApplicationDbContext context)
            : base(context)
        {
        }

    }
}
