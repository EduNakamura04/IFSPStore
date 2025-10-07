using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
