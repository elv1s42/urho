// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Sprite2D.cs
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
	/// Sprite.
	/// </summary>
	public unsafe partial class Sprite2D : Resource
	{
		[Preserve]
		public Sprite2D (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected Sprite2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Sprite2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Sprite2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Sprite2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Sprite2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Sprite2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Sprite2D));
			return new StringHash (Sprite2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Sprite2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Sprite2D));
			return Marshal.PtrToStringAnsi (Sprite2D_GetTypeNameStatic ());
		}

		public Sprite2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Sprite2D_Sprite2D (IntPtr context);

		public Sprite2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Sprite2D));
			handle = Sprite2D_Sprite2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Sprite2D));
			Sprite2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Sprite2D_BeginLoad_File (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (File source)
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_BeginLoad_File (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Sprite2D_BeginLoad_MemoryBuffer (IntPtr handle, IntPtr source);

		/// <summary>
		/// Load resource from stream. May be called from a worker thread. Return true if successful.
		/// </summary>
		public override bool BeginLoad (MemoryBuffer source)
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_BeginLoad_MemoryBuffer (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Sprite2D_EndLoad (IntPtr handle);

		/// <summary>
		/// Finish resource loading. Always called from the main thread. Return true if successful.
		/// </summary>
		public override bool EndLoad ()
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_EndLoad (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_SetTexture (IntPtr handle, IntPtr texture);

		/// <summary>
		/// Set texture.
		/// </summary>
		private void SetTexture (Texture2D texture)
		{
			Runtime.ValidateRefCounted (this);
			Sprite2D_SetTexture (handle, (object)texture == null ? IntPtr.Zero : texture.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_SetRectangle (IntPtr handle, ref Urho.IntRect rectangle);

		/// <summary>
		/// Set rectangle.
		/// </summary>
		private void SetRectangle (Urho.IntRect rectangle)
		{
			Runtime.ValidateRefCounted (this);
			Sprite2D_SetRectangle (handle, ref rectangle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_SetHotSpot (IntPtr handle, ref Urho.Vector2 hotSpot);

		/// <summary>
		/// Set hot spot.
		/// </summary>
		private void SetHotSpot (Urho.Vector2 hotSpot)
		{
			Runtime.ValidateRefCounted (this);
			Sprite2D_SetHotSpot (handle, ref hotSpot);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_SetOffset (IntPtr handle, ref Urho.IntVector2 offset);

		/// <summary>
		/// Set offset.
		/// </summary>
		private void SetOffset (Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Sprite2D_SetOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_SetTextureEdgeOffset (IntPtr handle, float offset);

		/// <summary>
		/// Set texture edge offset in pixels. This affects the left/right and top/bottom edges equally to prevent edge sampling artifacts. Default 0.
		/// </summary>
		private void SetTextureEdgeOffset (float offset)
		{
			Runtime.ValidateRefCounted (this);
			Sprite2D_SetTextureEdgeOffset (handle, offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Sprite2D_SetSpriteSheet (IntPtr handle, IntPtr spriteSheet);

		/// <summary>
		/// Set sprite sheet.
		/// </summary>
		private void SetSpriteSheet (SpriteSheet2D spriteSheet)
		{
			Runtime.ValidateRefCounted (this);
			Sprite2D_SetSpriteSheet (handle, (object)spriteSheet == null ? IntPtr.Zero : spriteSheet.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Sprite2D_GetTexture (IntPtr handle);

		/// <summary>
		/// Return texture.
		/// </summary>
		private Texture2D GetTexture ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Texture2D> (Sprite2D_GetTexture (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntRect Sprite2D_GetRectangle (IntPtr handle);

		/// <summary>
		/// Return rectangle.
		/// </summary>
		private Urho.IntRect GetRectangle ()
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_GetRectangle (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 Sprite2D_GetHotSpot (IntPtr handle);

		/// <summary>
		/// Return hot spot.
		/// </summary>
		private Urho.Vector2 GetHotSpot ()
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_GetHotSpot (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Sprite2D_GetOffset (IntPtr handle);

		/// <summary>
		/// Return offset.
		/// </summary>
		private Urho.IntVector2 GetOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_GetOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Sprite2D_GetTextureEdgeOffset (IntPtr handle);

		/// <summary>
		/// Return texture edge offset.
		/// </summary>
		private float GetTextureEdgeOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Sprite2D_GetTextureEdgeOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Sprite2D_GetSpriteSheet (IntPtr handle);

		/// <summary>
		/// Return sprite sheet.
		/// </summary>
		private SpriteSheet2D GetSpriteSheet ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<SpriteSheet2D> (Sprite2D_GetSpriteSheet (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ResourceRef Sprite2D_SaveToResourceRef (IntPtr sprite);

		/// <summary>
		/// Save sprite to ResourceRef.
		/// </summary>
		public static ResourceRef SaveToResourceRef (Sprite2D sprite)
		{
			Runtime.Validate (typeof(Sprite2D));
			return Sprite2D_SaveToResourceRef ((object)sprite == null ? IntPtr.Zero : sprite.Handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return texture.
		/// Or
		/// Set texture.
		/// </summary>
		public Texture2D Texture {
			get {
				return GetTexture ();
			}
			set {
				SetTexture (value);
			}
		}

		/// <summary>
		/// Return rectangle.
		/// Or
		/// Set rectangle.
		/// </summary>
		public Urho.IntRect Rectangle {
			get {
				return GetRectangle ();
			}
			set {
				SetRectangle (value);
			}
		}

		/// <summary>
		/// Return hot spot.
		/// Or
		/// Set hot spot.
		/// </summary>
		public Urho.Vector2 HotSpot {
			get {
				return GetHotSpot ();
			}
			set {
				SetHotSpot (value);
			}
		}

		/// <summary>
		/// Return offset.
		/// Or
		/// Set offset.
		/// </summary>
		public Urho.IntVector2 Offset {
			get {
				return GetOffset ();
			}
			set {
				SetOffset (value);
			}
		}

		/// <summary>
		/// Return texture edge offset.
		/// Or
		/// Set texture edge offset in pixels. This affects the left/right and top/bottom edges equally to prevent edge sampling artifacts. Default 0.
		/// </summary>
		public float TextureEdgeOffset {
			get {
				return GetTextureEdgeOffset ();
			}
			set {
				SetTextureEdgeOffset (value);
			}
		}

		/// <summary>
		/// Return sprite sheet.
		/// Or
		/// Set sprite sheet.
		/// </summary>
		public SpriteSheet2D SpriteSheet {
			get {
				return GetSpriteSheet ();
			}
			set {
				SetSpriteSheet (value);
			}
		}
	}
}
