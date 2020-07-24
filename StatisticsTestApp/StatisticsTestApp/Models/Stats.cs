using Microsoft.AspNetCore.Mvc;
using StatisticsTestApp.ModelBinder;

namespace StatisticsTestApp.Models
{
    [ModelBinder(typeof(StatisticsModelBinder))]
    public class Stats
    {
        public string Owner { get; set; } // seller
        public string MinimumCountInStock { get; set; }
    }
}
