namespace IFSPStoreDomain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        protected BaseEntity(TId id)
        {
            Id = id;
        }


        public TId Id { get; set; }

        /*
        private string Nome;
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        */
    }
}
