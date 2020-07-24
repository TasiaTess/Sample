using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using StatisticsTestApp.Models;

namespace StatisticsTestApp.ModelBinder
{
    public class StatisticsModelBinder : IModelBinder
    {
        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            const string ownerProp = "seller";
            const string minCountProp = "minCount";
            var valueProvider = bindingContext.ValueProvider;
            var ownerValue = valueProvider.GetValue(ownerProp).FirstValue;
            var minCountValue = valueProvider.GetValue(minCountProp).FirstValue;
            var stat = new Stats
            {
                Owner = ownerValue,
                MinimumCountInStock = minCountValue
            };
            bindingContext.Result = ModelBindingResult.Success(stat);
            await Task.FromResult(Task.CompletedTask);
        }
    }
}
