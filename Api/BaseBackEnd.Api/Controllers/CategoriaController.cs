using GestaoMonetariaApi.Application.Interfaces.Services;
using GestaoMonetariaApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GestaoMonetariaApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriaController : BaseController<CategoriaEntity>
{
    public CategoriaController(ICategoriaService categoriaService)
        : base(categoriaService)
    {
    }
}
