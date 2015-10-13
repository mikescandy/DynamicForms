using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection;

namespace Xamarin.Forms.Dynamic
{
    partial class DictionaryModel : IReflectableType
    {
		ConcurrentDictionary<string, PropertyInfo> infos = new ConcurrentDictionary<string, PropertyInfo>();

		/// <summary>
		/// Retrieves an object that represents the type of this instance.
		/// </summary>
		public TypeInfo GetTypeInfo ()
		{
			return new DynamicTypeInfo (name => infos.GetOrAdd (name, key => new DynamicPropertyInfo (
				  typeof (DictionaryModel),
				  key,
				  GetType (key),
				  obj => GetValue ((DictionaryModel)obj, key),
				  (obj, value) => SetValue ((DictionaryModel)obj, key, value))));
		}
	}
}
