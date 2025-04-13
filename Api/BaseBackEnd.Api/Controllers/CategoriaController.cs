using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestaoMonetaria.Api.Controllers.Categoria
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : BaseController<CategoriaEntity>
    {
        private readonly ICategoriaService _operacaoService;

        public CategoriaController(ICategoriaService operacaoService)
            : base(operacaoService)
        {
            _operacaoService = operacaoService;
        }


    }
}
