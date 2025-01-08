using CadastroUsuario.Shared.Notificacoes;
using CadastroUsuario.Shared.Resultados;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuario.Api.Controllers
{

    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected readonly INotificacaoDominio _notificacoes;

        protected BaseController(INotificacaoDominio notificacoes)
        {
            _notificacoes = notificacoes;
        }

        [NonAction]
        protected IActionResult CriarResposta<T>(T dados, string mensagemSucesso)
        {
            if (!_notificacoes.PossuiNotificacoes())
                return Ok(ResultadoOperacaoGenerico<T>.GerarSucesso(dados, mensagemSucesso));

            return BadRequest(ResultadoOperacaoGenerico<T>.GerarFalha(_notificacoes.ObterNotificacoes()));

 

        }
    }
}
