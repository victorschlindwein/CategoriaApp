using Xunit;
using Application.Commands;
using Application.Handlers;

namespace Tests;

public class CadastrarCategoriaHandlerTests
{
    [Fact]
    public async Task Deve_Cadastrar_Categoria_Com_Sucesso()
    {
        var handler = new CadastrarCategoriaHandler();
        var command = new CadastrarCategoriaCommand("Teste");

        var result = await handler.Handle(command, default);

        Assert.Equal("Categoria cadastrada com sucesso!", result);
    }
}
