using DevOpsForAzureSQL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace DevOpsForAzureSQL.Tests
{
    public class CustomersTests
    {
        private DevOpsForAzureSQLContext _dbContext;

        private void TestInitialize()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            var connString = config.GetConnectionString("DevOpsForAzureSQLDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<DevOpsForAzureSQLContext>();
            optionsBuilder.UseSqlServer(connString);

            _dbContext = new DevOpsForAzureSQLContext(optionsBuilder.Options);
        }

        [Fact]
        [Trait("Category", "Integration")]
        public void Customers_GetAll_ReturnsListOf4()
        {
            TestInitialize();

            var customers = _dbContext.Customers.ToList();
            Assert.NotNull(customers);
            Assert.Equal(4, customers.Count);
        }

        [Fact]
        [Trait("Category", "Integration")]
        public void Customers_GetId_ReturnsSpecificCustomer()
        {
            TestInitialize();

            var customer = _dbContext.Customers.Find(104);
            Assert.NotNull(customer);
            Assert.Equal("Wichita", customer.City);
        }

    }
}