namespace BaseBackEnd.Fwk.Entities
{
    /// <summary>
    /// Classe base para criação de entidades mapeadas com banco de dados
    /// </summary>
    /// <typeparam name="TypeId">Tipo de dado do identificador da entidade (Id).</typeparam>
    public abstract class BaseEntity<TypeId>
    {
        public required TypeId Id { get; set; }

        public override bool Equals(object? obj)
            => obj is BaseEntity<TypeId> entity && Id!.Equals(entity.Id);

        public override int GetHashCode()
            => HashCode.Combine(Id!);

        public void Validate() { }
    }
}
