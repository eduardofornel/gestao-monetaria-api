using GestaoMonetariaApi.Domain.Entities;
using GestaoMonetariaApi.Domain.Interfaces.Repositories;
using GestaoMonetariaApi.Infrastructure.Configurations.Fundation;

namespace GestaoMonetariaApi.Infrastructure.Repositories
{
    public class CategoriaRepository : BaseRepository<CategoriaEntity>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
