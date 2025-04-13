namespace BaseBackEnd.Domain.ViewModel
{
    public class OperacaoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public bool FlagDebito { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataOperacao { get; set; }
    }
}
