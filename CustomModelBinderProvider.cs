using CustomModelBinding.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomModelBinding
{
	public class CustomModelBinderProvider:IModelBinderProvider
	{
		public IModelBinder GetBinder(ModelBinderProviderContext context)
		{
			if (context.Metadata.ModelType == typeof(User))
				return new CustomModelBinder();

			return null;
		}

	}
}
