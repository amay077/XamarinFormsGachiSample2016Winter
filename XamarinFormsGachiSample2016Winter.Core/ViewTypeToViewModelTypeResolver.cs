using System;
using System.Reflection;

namespace XamarinFormsGachiSample2016Winter
{
    public static class ViewTypeToViewModelTypeResolver
    {
        private static readonly Assembly LocalAssembly = typeof(ViewTypeToViewModelTypeResolver).GetTypeInfo().Assembly;
        public static Type Resolve(Type viewType)
        {
            if (viewType == null) throw new ArgumentNullException(nameof(viewType));

            var vmTypeName = $"{viewType.Namespace.Replace("Views", "ViewModels")}.{viewType.Name}ViewModel";
            return LocalAssembly.GetType(vmTypeName);
        }
    }
}