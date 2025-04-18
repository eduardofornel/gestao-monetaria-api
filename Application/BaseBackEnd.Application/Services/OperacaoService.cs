﻿using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Domain.Entities;
using GestaoMonetariaApi.Domain.Interfaces.Repositories;

namespace GestaoMonetariaApi.Application.Services
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
