using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale()
        {
            
        }
        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman
            , Customer customer) : base(id)
        {
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Customer = customer;
            Salesman = salesman;
            SaleItens = new List<SaleItem>();
        }
        public DateTime SaleDate { get; set; }

        public decimal SaleTotal { get; set; }

        public User Salesman { get; set; }

        public Customer Customer { get; set; }

        public List<SaleItem>SaleItens { get; set; }
    }
    public class SaleItem : BaseEntity<int>
    {
        public SaleItem()
        {
            
        }
        public SaleItem(int id, Sale sale, Product product, decimal quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }

        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
