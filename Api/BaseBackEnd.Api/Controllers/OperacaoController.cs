﻿using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestaoMonetariaApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperacaoController : BaseController<OperacaoEntity>
    {
        private readonly IOperacaoService _operacaoService;

        public OperacaoController(IOperacaoService operacaoService)
            : base(operacaoService)
        {
            this._operacaoService = operacaoService;
        }


    }
}
