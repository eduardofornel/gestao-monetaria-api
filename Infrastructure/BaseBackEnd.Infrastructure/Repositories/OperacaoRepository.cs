﻿using GestaoMonetariaApi.Domain.Entities;
using GestaoMonetariaApi.Domain.Interfaces.Repositories;
using GestaoMonetariaApi.Infrastructure.Configurations.Fundation;

namespace GestaoMonetariaApi.Infrastructure.Repositories
{
    public class OperacaoRepository : BaseRepository<OperacaoEntity>, IOperacaoRepository
    {
        public OperacaoRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
