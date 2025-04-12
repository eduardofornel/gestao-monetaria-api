using BaseBackEnd.Application.Interfaces.Services;
using BaseBackEnd.Domain.Entities; // Onde OperacaoEntity está definido
using Microsoft.AspNetCore.Mvc;

namespace BaseBackEnd.Api.Controllers
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
