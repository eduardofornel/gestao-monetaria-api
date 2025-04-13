using GestaoMonetariaApi.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

[ApiController]
[Route("api/[controller]")]
public class BaseController<T> : ControllerBase where T : class, new()
{
    protected readonly IBaseService<T> _service;

    public BaseController(IBaseService<T> service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<T>>> Get()
    {
        var entities = await _service.GetAllAsync();
        return Ok(entities);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<T>> Get(int id)
    {
        var entity = await _service.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return Ok(entity);
    }

    [HttpPost]
    public async Task<ActionResult<T>> Post([FromBody] T entity)
    {
        await _service.AddAsync(entity);

        int newId = GetEntityId(entity);
        return CreatedAtAction(nameof(Get), new { id = newId }, entity);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id, [FromBody] T entity)
    {
        await _service.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _service.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        await _service.RemoveAsync(entity);
        return NoContent();
    }

    private int GetEntityId(T entity)
    {
        PropertyInfo prop = typeof(T).GetProperty("Id");
        if (prop != null)
        {
            object value = prop.GetValue(entity);
            return value != null ? (int)value : 0;
        }
        return 0;
    }
}
