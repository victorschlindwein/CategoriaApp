using MediatR;
using Application.Commands;
using Domain.Entities;

namespace Application.Handlers;

public class CadastrarCategoriaHandler : IRequestHandler<CadastrarCategoriaCommand, string>
{
    public Task<string> Handle(CadastrarCategoriaCommand request, CancellationToken cancellationToken)
    {
        var categoria = new Categoria(request.Nome);
        Console.WriteLine($"Categoria criada: {categoria.Nome}");
        return Task.FromResult("Categoria cadastrada com sucesso!");
    }
}
