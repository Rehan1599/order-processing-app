using Xunit;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Tests
{
    public class OrderTests
    {
        [Fact]
        public void LoyalCustomer_Above100_Gets10PercentDiscount()
        {
            var order = new Order { OrderAmount = 150, CustomerType = "Loyal" };
            order.CalculateDiscount();

            Assert.Equal(15, order.Discount);
            Assert.Equal(135, order.FinalTotal);
        }

        [Fact]
        public void NewCustomer_NoDiscount()
        {
            var order = new Order { OrderAmount = 150, CustomerType = "New" };
            order.CalculateDiscount();

            Assert.Equal(0, order.Discount);
            Assert.Equal(150, order.FinalTotal);
        }
    }
}
