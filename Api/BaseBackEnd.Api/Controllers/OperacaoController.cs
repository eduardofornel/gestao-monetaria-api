using AutoMapper;
using BaseBackEnd.Domain.ViewModel;
using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestaoMonetariaApi.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperacaoController : ControllerBase
    {
        private readonly IOperacaoService _operacaoService;
        private readonly IMapper _mapper;

        public OperacaoController(IOperacaoService operacaoService, IMapper mapper)
        {
            _operacaoService = operacaoService;
            _mapper = mapper;
        }

        // GET: api/Operacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperacaoViewModel>>> Get()
        {
            var entities = await _operacaoService.GetAllAsync();
            var viewModels = _mapper.Map<IEnumerable<OperacaoViewModel>>(entities);
            return Ok(viewModels);
        }

        // GET: api/Operacao/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<OperacaoViewModel>> Get(int id)
        {
            var entity = await _operacaoService.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            var viewModel = _mapper.Map<OperacaoViewModel>(entity);
            return Ok(viewModel);
        }

        // POST: api/Operacao
        [HttpPost]
        public async Task<ActionResult<OperacaoViewModel>> Post([FromBody] OperacaoViewModel operacaoViewModel)
        {
            try
            {
                if (operacaoViewModel == null)
                    return BadRequest("Operação inválida");

                // Mapeia a viewModel para a entidade
                var entity = _mapper.Map<OperacaoEntity>(operacaoViewModel);

                await _operacaoService.AddAsync(entity);

                // Após a inserção, o entity conterá o novo ID gerado
                var createdViewModel = _mapper.Map<OperacaoViewModel>(entity);
                return CreatedAtAction(nameof(Get), new { id = createdViewModel.Id }, createdViewModel);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
            
        }

        // PUT: api/Operacao/5
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, [FromBody] OperacaoViewModel operacaoViewModel)
        {
            if (operacaoViewModel == null)
                return BadRequest("Operação inválida");

            // Caso a viewModel possua o campo Id, verifique se é igual ao id da rota (opcional)
            if (operacaoViewModel.Id != 0 && operacaoViewModel.Id != id)
                return BadRequest("O ID da operação não coincide com o ID da rota");

            // Mapeia a viewModel para a entidade e força o ID recebido na rota
            var entity = _mapper.Map<OperacaoEntity>(operacaoViewModel);
            entity.Id = id;

            await _operacaoService.UpdateAsync(entity);
            return NoContent();
        }

        // DELETE: api/Operacao/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _operacaoService.GetByIdAsync(id);
            if (entity == null)
                return NotFound();

            await _operacaoService.RemoveAsync(entity);
            return NoContent();
        }
    }
}
