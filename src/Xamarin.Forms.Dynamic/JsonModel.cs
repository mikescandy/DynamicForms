﻿using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Xamarin.Forms
{
	/// <summary>
	/// Dynamic data-bindable JSON-based model.
	/// </summary>
	public class JsonModel : JObject, IReflectableType
	{
		/// <summary>
		/// Creates the JSON-based model from content 
		/// objects from Linq to Json content.
		/// </summary>
		public JsonModel (params object[] content)
		{
		}

		/// <summary>
		/// Creates the JSON-based model from a loaded  
		/// Linq to Json object.
		/// </summary>
		public JsonModel (JObject other)
		{
		}

		/// <summary>
		/// Load a model from a string that contains JSON.
		/// </summary>
		/// <param name="json">A string that contains JSON.</param>
		/// <returns>A <see cref="JsonModel"/> populated from the string that contains JSON.</returns>
		public new static JsonModel Parse (string fileName, string json)
		{
			throw new NotImplementedException ();
		}

		/// <summary>
		/// Loads an model from a JSON reader.
		/// </summary>
		/// <param name="reader">A <see cref="JsonReader "/> that will be read for the content of the <see cref="JsonModel"/>.</param>
		/// <returns>A <see cref="JsonModel"/> that contains the JSON that was read from the specified <see cref="JsonReader"/>.</returns>
		public new static JsonModel Load (JsonReader reader)
		{
			throw new NotImplementedException ();
		}

		/// <summary>
		/// Retrieves an object that represents the type of this instance.
		/// </summary>
		public TypeInfo GetTypeInfo ()
		{
			throw new NotImplementedException ();
		}
	}
}
