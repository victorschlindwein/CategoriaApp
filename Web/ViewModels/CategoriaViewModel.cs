using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels;

public class CategoriaViewModel
{
    [Required(ErrorMessage = "Nome é obrigatório")]
    public string Nome { get; set; }
}
