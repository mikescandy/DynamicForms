using System;
using System.Reflection;

namespace Xamarin.Forms.Dynamic
{
	partial class DictionaryModel : IReflectableType
	{
		/// <summary>
		/// Retrieves an object that represents the type of this instance.
		/// </summary>
		public TypeInfo GetTypeInfo ()
		{
			throw new NotSupportedException ("Windows Phone does not support dynamic property syntax. You must use indexer notation for bindings, like [MyProperty].");
		}
	}
}
