namespace Domain.Entities;

public class Categoria
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Nome { get; private set; }

    public Categoria(string nome)
    {
        Nome = nome;
    }
}
