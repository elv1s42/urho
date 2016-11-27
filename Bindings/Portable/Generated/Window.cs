// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Window.cs
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

namespace Urho.Gui
{
	/// <summary>
	/// %Window %UI element that can optionally by moved or resized.
	/// </summary>
	public unsafe partial class Window : BorderImage
	{
		[Preserve]
		public Window (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected Window (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Window_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Window_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Window_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Window_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Window_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Window));
			return new StringHash (Window_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Window_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Window));
			return Marshal.PtrToStringAnsi (Window_GetTypeNameStatic ());
		}

		public Window () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Window_Window (IntPtr context);

		public Window (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Window));
			handle = Window_Window ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Window));
			Window_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_OnHover (IntPtr handle, ref Urho.IntVector2 position, ref Urho.IntVector2 screenPosition, int buttons, int qualifiers, IntPtr cursor);

		/// <summary>
		/// React to mouse hover.
		/// </summary>
		public override void OnHover (Urho.IntVector2 position, Urho.IntVector2 screenPosition, int buttons, int qualifiers, Cursor cursor)
		{
			Runtime.ValidateRefCounted (this);
			Window_OnHover (handle, ref position, ref screenPosition, buttons, qualifiers, (object)cursor == null ? IntPtr.Zero : cursor.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetMovable (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether can be moved.
		/// </summary>
		private void SetMovable (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetMovable (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetResizable (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether can be resized.
		/// </summary>
		private void SetResizable (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetResizable (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetFixedWidthResizing (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether resizing width is fixed.
		/// </summary>
		private void SetFixedWidthResizing (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetFixedWidthResizing (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetFixedHeightResizing (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether resizing height is fixed.
		/// </summary>
		private void SetFixedHeightResizing (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetFixedHeightResizing (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetResizeBorder (IntPtr handle, ref Urho.IntRect rect);

		/// <summary>
		/// Set resize area width at edges.
		/// </summary>
		private void SetResizeBorder (Urho.IntRect rect)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetResizeBorder (handle, ref rect);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetModal (IntPtr handle, bool modal);

		/// <summary>
		/// Set modal flag. When the modal flag is set, the focused window needs to be dismissed first to allow other UI elements to gain focus.
		/// </summary>
		private void SetModal (bool modal)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetModal (handle, modal);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetModalShadeColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set modal shade color.
		/// </summary>
		private void SetModalShadeColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetModalShadeColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetModalFrameColor (IntPtr handle, ref Urho.Color color);

		/// <summary>
		/// Set modal frame color.
		/// </summary>
		private void SetModalFrameColor (Urho.Color color)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetModalFrameColor (handle, ref color);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetModalFrameSize (IntPtr handle, ref Urho.IntVector2 size);

		/// <summary>
		/// Set modal frame size.
		/// </summary>
		private void SetModalFrameSize (Urho.IntVector2 size)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetModalFrameSize (handle, ref size);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Window_SetModalAutoDismiss (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether model window can be dismissed with the escape key. Default true.
		/// </summary>
		private void SetModalAutoDismiss (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Window_SetModalAutoDismiss (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Window_IsMovable (IntPtr handle);

		/// <summary>
		/// Return whether is movable.
		/// </summary>
		private bool IsMovable ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_IsMovable (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Window_IsResizable (IntPtr handle);

		/// <summary>
		/// Return whether is resizable.
		/// </summary>
		private bool IsResizable ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_IsResizable (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Window_GetFixedWidthResizing (IntPtr handle);

		/// <summary>
		/// Return whether is resizing width is fixed.
		/// </summary>
		private bool GetFixedWidthResizing ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetFixedWidthResizing (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Window_GetFixedHeightResizing (IntPtr handle);

		/// <summary>
		/// Return whether is resizing height is fixed.
		/// </summary>
		private bool GetFixedHeightResizing ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetFixedHeightResizing (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntRect Window_GetResizeBorder (IntPtr handle);

		/// <summary>
		/// Return resize area width at edges.
		/// </summary>
		private Urho.IntRect GetResizeBorder ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetResizeBorder (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Window_IsModal (IntPtr handle);

		/// <summary>
		/// Return modal flag.
		/// </summary>
		private bool IsModal ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_IsModal (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Window_GetModalShadeColor (IntPtr handle);

		/// <summary>
		/// Get modal shade color.
		/// </summary>
		private Urho.Color GetModalShadeColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetModalShadeColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Color Window_GetModalFrameColor (IntPtr handle);

		/// <summary>
		/// Get modal frame color.
		/// </summary>
		private Urho.Color GetModalFrameColor ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetModalFrameColor (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Window_GetModalFrameSize (IntPtr handle);

		/// <summary>
		/// Get modal frame size.
		/// </summary>
		private Urho.IntVector2 GetModalFrameSize ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetModalFrameSize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Window_GetModalAutoDismiss (IntPtr handle);

		/// <summary>
		/// Return whether can be dismissed with escape key.
		/// </summary>
		private bool GetModalAutoDismiss ()
		{
			Runtime.ValidateRefCounted (this);
			return Window_GetModalAutoDismiss (handle);
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
		/// Return whether is movable.
		/// Or
		/// Set whether can be moved.
		/// </summary>
		public bool Movable {
			get {
				return IsMovable ();
			}
			set {
				SetMovable (value);
			}
		}

		/// <summary>
		/// Return whether is resizable.
		/// Or
		/// Set whether can be resized.
		/// </summary>
		public bool Resizable {
			get {
				return IsResizable ();
			}
			set {
				SetResizable (value);
			}
		}

		/// <summary>
		/// Return whether is resizing width is fixed.
		/// Or
		/// Set whether resizing width is fixed.
		/// </summary>
		public bool FixedWidthResizing {
			get {
				return GetFixedWidthResizing ();
			}
			set {
				SetFixedWidthResizing (value);
			}
		}

		/// <summary>
		/// Return whether is resizing height is fixed.
		/// Or
		/// Set whether resizing height is fixed.
		/// </summary>
		public bool FixedHeightResizing {
			get {
				return GetFixedHeightResizing ();
			}
			set {
				SetFixedHeightResizing (value);
			}
		}

		/// <summary>
		/// Return resize area width at edges.
		/// Or
		/// Set resize area width at edges.
		/// </summary>
		public Urho.IntRect ResizeBorder {
			get {
				return GetResizeBorder ();
			}
			set {
				SetResizeBorder (value);
			}
		}

		/// <summary>
		/// Return modal flag.
		/// Or
		/// Set modal flag. When the modal flag is set, the focused window needs to be dismissed first to allow other UI elements to gain focus.
		/// </summary>
		public bool Modal {
			get {
				return IsModal ();
			}
			set {
				SetModal (value);
			}
		}

		/// <summary>
		/// Get modal shade color.
		/// Or
		/// Set modal shade color.
		/// </summary>
		public Urho.Color ModalShadeColor {
			get {
				return GetModalShadeColor ();
			}
			set {
				SetModalShadeColor (value);
			}
		}

		/// <summary>
		/// Get modal frame color.
		/// Or
		/// Set modal frame color.
		/// </summary>
		public Urho.Color ModalFrameColor {
			get {
				return GetModalFrameColor ();
			}
			set {
				SetModalFrameColor (value);
			}
		}

		/// <summary>
		/// Get modal frame size.
		/// Or
		/// Set modal frame size.
		/// </summary>
		public Urho.IntVector2 ModalFrameSize {
			get {
				return GetModalFrameSize ();
			}
			set {
				SetModalFrameSize (value);
			}
		}

		/// <summary>
		/// Return whether can be dismissed with escape key.
		/// Or
		/// Set whether model window can be dismissed with the escape key. Default true.
		/// </summary>
		public bool ModalAutoDismiss {
			get {
				return GetModalAutoDismiss ();
			}
			set {
				SetModalAutoDismiss (value);
			}
		}
	}
}
