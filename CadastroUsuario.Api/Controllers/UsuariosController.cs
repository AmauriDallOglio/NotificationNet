using CadastroUsuario.Shared.Comando;
using CadastroUsuario.Shared.Notificacoes;
using CadastroUsuario.Shared.Validador;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuario.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : BaseController
    {
        private readonly UsuarioValidador _usuarioServico;

        public UsuariosController(INotificacaoDominio notificacoes, UsuarioValidador usuarioServico) : base(notificacoes)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpPost("registrar")]
        public IActionResult Registrar([FromBody] RegistrarUsuarioDto comando)
        {
            var sucesso = _usuarioServico.RegistrarUsuario(comando.Nome, comando.Email, comando.Senha);
            return CriarResposta(comando, sucesso ? "Usuário registrado com sucesso." : null);
        }
    }
}
