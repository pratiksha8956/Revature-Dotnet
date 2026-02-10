using System;


namespace LinqJoinDemo
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
    }

    class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public decimal OrderAmount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer { CustomerId = 1, CustomerName = "Alice" },
                new Customer { CustomerId = 2, CustomerName = "Bob" },
                new Customer { CustomerId = 3, CustomerName = "Charlie" }
            };

            var orders = new List<Order>
            {
                new Order { OrderId = 101, CustomerId = 1, OrderAmount = 500 },
                new Order { OrderId = 102, CustomerId = 1, OrderAmount = 300 },
                new Order { OrderId = 103, CustomerId = 2, OrderAmount = 700 }
            };

            var result =
                from c in customers
                join o in orders on c.CustomerId equals o.CustomerId into custOrders
                select new
                {
                    CustomerName = c.CustomerName,
                    OrderCount = custOrders.Count(),
                    TotalAmount = custOrders.Sum(x => x.OrderAmount)
                };

            foreach (var item in result)
            {
                Console.WriteLine(
                    $"{item.CustomerName} placed {item.OrderCount} orders, Total Amount = {item.TotalAmount}"
                );
            }
        }
    }
}
