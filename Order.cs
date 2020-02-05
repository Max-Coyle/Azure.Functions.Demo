namespace Azure.Functions.Demo
{
    public class Order
    {
        public string PartitionKey { get; set; }

        public string RowKey { get; set; }

        public string OrderId { get; set; }

        public string ProductId { get; set; }

        public string Email { get; set; }

        public string Price { get; set; }
    }
}