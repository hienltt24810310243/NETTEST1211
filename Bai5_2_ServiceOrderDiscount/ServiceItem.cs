namespace Bai5_2_ServiceOrderDiscount
{
    public class ServiceItem
    {
        public string ServiceId { get; set; } = string.Empty;
        public string ServiceName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public ServiceItem() { }

        public ServiceItem(string id, string name, string category, decimal price)
        {
            ServiceId = id;
            ServiceName = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ServiceName} ({Price:N0} VNĐ)";
        }
    }
}
