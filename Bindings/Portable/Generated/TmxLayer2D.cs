// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// TmxLayer2D.cs
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
	/// Tmx layer.
	/// </summary>
	public unsafe partial class TmxLayer2D : RefCounted
	{
		[Preserve]
		public TmxLayer2D (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected TmxLayer2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxLayer2D_TmxLayer2D (IntPtr tmxFile, TileMapLayerType2D type);

		public TmxLayer2D (TmxFile2D tmxFile, TileMapLayerType2D type) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(TmxLayer2D));
			handle = TmxLayer2D_TmxLayer2D ((object)tmxFile == null ? IntPtr.Zero : tmxFile.Handle, type);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxLayer2D_GetTmxFile (IntPtr handle);

		/// <summary>
		/// Return tmx file.
		/// </summary>
		private TmxFile2D GetTmxFile ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<TmxFile2D> (TmxLayer2D_GetTmxFile (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern TileMapLayerType2D TmxLayer2D_GetType (IntPtr handle);

		/// <summary>
		/// Return type.
		/// </summary>
		private TileMapLayerType2D UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxLayer2D_GetType (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxLayer2D_GetName (IntPtr handle);

		/// <summary>
		/// Return name.
		/// </summary>
		private string GetName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (TmxLayer2D_GetName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int TmxLayer2D_GetWidth (IntPtr handle);

		/// <summary>
		/// Return width.
		/// </summary>
		private int GetWidth ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxLayer2D_GetWidth (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int TmxLayer2D_GetHeight (IntPtr handle);

		/// <summary>
		/// Return height.
		/// </summary>
		private int GetHeight ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxLayer2D_GetHeight (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxLayer2D_IsVisible (IntPtr handle);

		/// <summary>
		/// Return is visible.
		/// </summary>
		private bool IsVisible ()
		{
			Runtime.ValidateRefCounted (this);
			return TmxLayer2D_IsVisible (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool TmxLayer2D_HasProperty (IntPtr handle, string name);

		/// <summary>
		/// Return has property (use for script).
		/// </summary>
		public bool HasProperty (string name)
		{
			Runtime.ValidateRefCounted (this);
			return TmxLayer2D_HasProperty (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr TmxLayer2D_GetProperty (IntPtr handle, string name);

		/// <summary>
		/// Return property value (use for script).
		/// </summary>
		public string GetProperty (string name)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (TmxLayer2D_GetProperty (handle, name));
		}

		/// <summary>
		/// Return tmx file.
		/// </summary>
		public TmxFile2D TmxFile {
			get {
				return GetTmxFile ();
			}
		}

		/// <summary>
		/// Return type.
		/// </summary>
		public TileMapLayerType2D Type {
			get {
				return UrhoGetType ();
			}
		}

		/// <summary>
		/// Return name.
		/// </summary>
		public string Name {
			get {
				return GetName ();
			}
		}

		/// <summary>
		/// Return width.
		/// </summary>
		public int Width {
			get {
				return GetWidth ();
			}
		}

		/// <summary>
		/// Return height.
		/// </summary>
		public int Height {
			get {
				return GetHeight ();
			}
		}

		/// <summary>
		/// Return is visible.
		/// </summary>
		public bool Visible {
			get {
				return IsVisible ();
			}
		}
	}
}
