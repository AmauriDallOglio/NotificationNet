using System.Collections.Concurrent;

namespace CadastroUsuario.Shared.Notificacoes
{
    public class NotificacaoDominio : INotificacaoDominio
    {
        private readonly ConcurrentBag<Notificacao> _notificacoes = new();

        public void AdicionarNotificacao(string chave, string mensagem)
        {
            _notificacoes.Add(new Notificacao(chave, mensagem));
        }

        public bool PossuiNotificacoes()
        {
            return _notificacoes.Any();
        }

        public IEnumerable<Notificacao> ObterNotificacoes()
        {
            return _notificacoes.ToList();
        }
    }
}
