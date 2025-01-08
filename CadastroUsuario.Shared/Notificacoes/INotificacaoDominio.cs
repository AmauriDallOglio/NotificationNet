namespace CadastroUsuario.Shared.Notificacoes
{
    public interface INotificacaoDominio
    {
        void AdicionarNotificacao(string chave, string mensagem);
        bool PossuiNotificacoes();
        IEnumerable<Notificacao> ObterNotificacoes();
    }
}
