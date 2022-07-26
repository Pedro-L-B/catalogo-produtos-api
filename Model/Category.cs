namespace Catalogo.Produtos.Api.Model;

public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public string? Initials { get; set; }
    public bool IsActive { get; set; }
    public DateTime RegistrationDate { get; set; }
}