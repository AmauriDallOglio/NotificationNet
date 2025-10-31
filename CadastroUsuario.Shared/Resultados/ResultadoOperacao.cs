namespace CadastroUsuario.Shared.Resultados
{
    public class ResultadoOperacao
    {
        public bool Sucesso { get; }
        public string MensagemSucesso { get; }
        public IEnumerable<string> Erros { get; }


        protected ResultadoOperacao(bool sucesso, IEnumerable<string> erros, string mensagemSucesso)
        {
            Sucesso = sucesso;
            Erros = erros;
            MensagemSucesso = mensagemSucesso;
        }

        public static ResultadoOperacao GerarSucesso()
        {
            return new(true, Array.Empty<string>(), null);
        }

        public static ResultadoOperacao GerarFalha(IEnumerable<Notificacoes.Notificacao> notificacoes)
        {
            return new(false, notificacoes.Select(n => $"{n.Chave}: {n.Mensagem}"), null);
        }
    }
}
