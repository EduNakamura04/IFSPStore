using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class City : BaseEntity<int>
    {
        public City(int id, string name, string state) : base(id)
        {
            Name = name;
            State = state;
        }

        public string Name { get; set; }
        public string State { get; set; }

    }
}
