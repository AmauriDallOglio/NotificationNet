namespace CadastroUsuario.Shared.Resultados
{
    public class ResultadoOperacaoGenerico<T> : ResultadoOperacao
    {
        public T Dados { get; }

        protected ResultadoOperacaoGenerico(bool sucesso, T dados, IEnumerable<string> erros, string mensagemSucesso) : base(sucesso, erros, mensagemSucesso)
        {
            Dados = dados;
        }

        public static ResultadoOperacaoGenerico<T> GerarSucesso(T dados, string mensagemSucesso)
        {
            return new(true, dados, Array.Empty<string>(), mensagemSucesso);
        }

        public static ResultadoOperacaoGenerico<T> GerarFalha(IEnumerable<Notificacoes.Notificacao> notificacoes)
        {
            return new(false, default, notificacoes.Select(n => $"{n.Chave}: {n.Mensagem}"), null);
        }
    }

}
