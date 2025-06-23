using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Commands;
using Web.ViewModels;

namespace Web.Controllers;

public class CategoriaController : Controller
{
    private readonly IMediator _mediator;

    public CategoriaController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Cadastrar(CategoriaViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var command = new CadastrarCategoriaCommand(model.Nome);
        var resultado = await _mediator.Send(command);

        ViewBag.Mensagem = resultado;
        return View();
    }
}
