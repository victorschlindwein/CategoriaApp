using MediatR;

namespace Application.Commands;

public class CadastrarCategoriaCommand : IRequest<string>
{
    public string Nome { get; }

    public CadastrarCategoriaCommand(string nome)
    {
        Nome = nome;
    }
}
