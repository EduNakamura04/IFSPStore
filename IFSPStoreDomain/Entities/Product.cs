using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product(int id, string name, decimal price, decimal quantity, DateTime purchasedate, string salesunit, Category category) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            PurchaseDate = purchasedate;
            SalesUnit = salesunit;
            Category = category;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SalesUnit { get; set; }
        public Category Category { get; set; }

    }
}
