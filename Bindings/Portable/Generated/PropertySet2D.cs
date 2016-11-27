// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// PropertySet2D.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Urho2D
{
	/// <summary>
	/// Property set.
	/// </summary>
	public unsafe partial class PropertySet2D : RefCounted
	{
		[Preserve]
		public PropertySet2D (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected PropertySet2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr PropertySet2D_PropertySet2D ();

		public PropertySet2D () : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(PropertySet2D));
			handle = PropertySet2D_PropertySet2D ();
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PropertySet2D_Load (IntPtr handle, ref Urho.Resources.XmlElement element);

		/// <summary>
		/// Load from XML element.
		/// </summary>
		public void Load (Urho.Resources.XmlElement element)
		{
			Runtime.ValidateRefCounted (this);
			PropertySet2D_Load (handle, ref element);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PropertySet2D_HasProperty (IntPtr handle, string name);

		/// <summary>
		/// Return has property.
		/// </summary>
		public bool HasProperty (string name)
		{
			Runtime.ValidateRefCounted (this);
			return PropertySet2D_HasProperty (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr PropertySet2D_GetProperty (IntPtr handle, string name);

		/// <summary>
		/// Return property value.
		/// </summary>
		public string GetProperty (string name)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (PropertySet2D_GetProperty (handle, name));
		}
	}
}
