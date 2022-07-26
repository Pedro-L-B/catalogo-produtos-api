using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Produtos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    public string ListCategory()
    {
        return "Listar categorias";
    }

    [HttpPost]
    public string CreateCategory()
    {
        return "Criar categoria";
    }

    [HttpDelete("Id:int")]
    public string DeleteCategory(int id)
    {
        return "Deletar categoria";
    }

    [HttpPut("Id:int")]
    public string UpdateCategory(int id)
    {
        return "Atualizar categoria";
    }
}