namespace Bai5_3_ProductManager
{
    public class Product
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; } = string.Empty;

        public decimal TotalAmount => UnitPrice * Quantity;

        public Product() { }

        public Product(string productId, string productName, decimal unitPrice, int quantity, string category)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Category = category;
        }
    }
}
