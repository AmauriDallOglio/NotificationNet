using CadastroUsuario.Shared.Notificacoes;

namespace CadastroUsuario.Shared.Validador
{
    public class UsuarioValidador
    {
        private readonly INotificacaoDominio _notificacoes;

        public UsuarioValidador(INotificacaoDominio notificacoes)
        {
            _notificacoes = notificacoes;
        }

        public bool RegistrarUsuario(string nome, string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(nome))
                _notificacoes.AdicionarNotificacao("Nome", "O nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                _notificacoes.AdicionarNotificacao("Email", "E-mail inválido.");

            if (string.IsNullOrWhiteSpace(senha) || senha.Length < 6)
                _notificacoes.AdicionarNotificacao("Senha", "A senha deve ter pelo menos 6 caracteres.");

            return !_notificacoes.PossuiNotificacoes();
        }
    }
}
