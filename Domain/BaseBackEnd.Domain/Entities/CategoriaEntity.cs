namespace GestaoMonetariaApi.Domain.Entities
{
    public class CategoriaEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<OperacaoEntity> Operacoes { get; set; }

    }
}
