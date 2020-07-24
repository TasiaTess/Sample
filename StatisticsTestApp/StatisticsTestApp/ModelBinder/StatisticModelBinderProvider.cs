using Microsoft.AspNetCore.Mvc.ModelBinding;
using StatisticsTestApp.Models;

namespace StatisticsTestApp.ModelBinder
{
    public class StatisticModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(Stats))
            {
                return new StatisticModelBinder();
            }

            return null;
        }
    }
}
