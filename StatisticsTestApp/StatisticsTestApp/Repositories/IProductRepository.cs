using System.Collections.Generic;
using StatisticsTestApp.Models;

namespace StatisticsTestApp.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get(Stats stats);
    }
}
