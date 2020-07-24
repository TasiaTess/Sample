using System.Collections.Generic;
using System.Data;
using StatisticsTestApp.Models;
using Dapper;

namespace StatisticsTestApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        public ProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> Get(Stats stats)
        {
            string productQueryStr = "SELECT * FROM Product WHERE Owner = @Owner and CountInStock >= @minCount";
            var products = _connection.Query<Product>(productQueryStr, new { Owner = stats.Owner, MinCount = stats.MinimumCountInStock });
            return products;
        }

    }
}
