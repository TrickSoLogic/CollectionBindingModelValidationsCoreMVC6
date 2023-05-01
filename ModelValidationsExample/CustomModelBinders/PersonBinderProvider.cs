using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using CollectionBindingModelValidationsCoreMVC6.Models;

namespace CollectionBindingModelValidationsCoreMVC6.CustomModelBinders
{
  public class PersonBinderProvider : IModelBinderProvider
  {
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
      if (context.Metadata.ModelType == typeof(Person))
      {
        return new BinderTypeModelBinder(typeof(PersonModelBinder));
      }
      return null;
    }
  }
}
