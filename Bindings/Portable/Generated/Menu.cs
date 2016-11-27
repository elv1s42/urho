// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Menu.cs
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
	/// %Menu %UI element that optionally shows a popup.
	/// </summary>
	public unsafe partial class Menu : Button
	{
		[Preserve]
		public Menu (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected Menu (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Menu_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Menu_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Menu_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Menu_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Menu_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Menu));
			return new StringHash (Menu_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Menu_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Menu));
			return Marshal.PtrToStringAnsi (Menu_GetTypeNameStatic ());
		}

		public Menu () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Menu_Menu (IntPtr context);

		public Menu (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Menu));
			handle = Menu_Menu ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Menu));
			Menu_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Menu_LoadXML (IntPtr handle, ref Urho.Resources.XmlElement source, IntPtr styleFile, bool setInstanceDefault);

		/// <summary>
		/// Load from XML data with style. Return true if successful.
		/// </summary>
		public override bool LoadXml (Urho.Resources.XmlElement source, Urho.Resources.XmlFile styleFile, bool setInstanceDefault)
		{
			Runtime.ValidateRefCounted (this);
			return Menu_LoadXML (handle, ref source, (object)styleFile == null ? IntPtr.Zero : styleFile.Handle, setInstanceDefault);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Menu_SaveXML (IntPtr handle, ref Urho.Resources.XmlElement dest);

		/// <summary>
		/// Save as XML data. Return true if successful.
		/// </summary>
		public override bool SaveXml (Urho.Resources.XmlElement dest)
		{
			Runtime.ValidateRefCounted (this);
			return Menu_SaveXML (handle, ref dest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_Update (IntPtr handle, float timeStep);

		/// <summary>
		/// Perform UI element update.
		/// </summary>
		public override void Update (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			Menu_Update (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_OnHover (IntPtr handle, ref Urho.IntVector2 position, ref Urho.IntVector2 screenPosition, int buttons, int qualifiers, IntPtr cursor);

		/// <summary>
		/// React to mouse hover.
		/// </summary>
		public override void OnHover (Urho.IntVector2 position, Urho.IntVector2 screenPosition, int buttons, int qualifiers, Cursor cursor)
		{
			Runtime.ValidateRefCounted (this);
			Menu_OnHover (handle, ref position, ref screenPosition, buttons, qualifiers, (object)cursor == null ? IntPtr.Zero : cursor.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_OnShowPopup (IntPtr handle);

		/// <summary>
		/// React to the popup being shown.
		/// </summary>
		public virtual void OnShowPopup ()
		{
			Runtime.ValidateRefCounted (this);
			Menu_OnShowPopup (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_OnHidePopup (IntPtr handle);

		/// <summary>
		/// React to the popup being hidden.
		/// </summary>
		public virtual void OnHidePopup ()
		{
			Runtime.ValidateRefCounted (this);
			Menu_OnHidePopup (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_SetPopup (IntPtr handle, IntPtr element);

		/// <summary>
		/// Set popup element to show on selection.
		/// </summary>
		private void SetPopup (UIElement element)
		{
			Runtime.ValidateRefCounted (this);
			Menu_SetPopup (handle, (object)element == null ? IntPtr.Zero : element.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_SetPopupOffset (IntPtr handle, ref Urho.IntVector2 offset);

		/// <summary>
		/// Set popup element offset.
		/// </summary>
		private void SetPopupOffset (Urho.IntVector2 offset)
		{
			Runtime.ValidateRefCounted (this);
			Menu_SetPopupOffset (handle, ref offset);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_SetPopupOffset0 (IntPtr handle, int x, int y);

		/// <summary>
		/// Set popup element offset.
		/// </summary>
		public void SetPopupOffset (int x, int y)
		{
			Runtime.ValidateRefCounted (this);
			Menu_SetPopupOffset0 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_ShowPopup (IntPtr handle, bool enable);

		/// <summary>
		/// Force the popup to show or hide.
		/// </summary>
		public void ShowPopup (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			Menu_ShowPopup (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Menu_SetAccelerator (IntPtr handle, int key, int qualifiers);

		/// <summary>
		/// Set accelerator key (set zero key code to disable.)
		/// </summary>
		public void SetAccelerator (int key, int qualifiers)
		{
			Runtime.ValidateRefCounted (this);
			Menu_SetAccelerator (handle, key, qualifiers);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Menu_GetPopup (IntPtr handle);

		/// <summary>
		/// Return popup element.
		/// </summary>
		private UIElement GetPopup ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<UIElement> (Menu_GetPopup (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.IntVector2 Menu_GetPopupOffset (IntPtr handle);

		/// <summary>
		/// Return popup element offset.
		/// </summary>
		private Urho.IntVector2 GetPopupOffset ()
		{
			Runtime.ValidateRefCounted (this);
			return Menu_GetPopupOffset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Menu_GetShowPopup (IntPtr handle);

		/// <summary>
		/// Return whether popup is open.
		/// </summary>
		private bool GetShowPopup ()
		{
			Runtime.ValidateRefCounted (this);
			return Menu_GetShowPopup (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Menu_GetAcceleratorKey (IntPtr handle);

		/// <summary>
		/// Return accelerator key code, 0 if disabled.
		/// </summary>
		private int GetAcceleratorKey ()
		{
			Runtime.ValidateRefCounted (this);
			return Menu_GetAcceleratorKey (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Menu_GetAcceleratorQualifiers (IntPtr handle);

		/// <summary>
		/// Return accelerator qualifiers.
		/// </summary>
		private int GetAcceleratorQualifiers ()
		{
			Runtime.ValidateRefCounted (this);
			return Menu_GetAcceleratorQualifiers (handle);
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
		/// Return popup element.
		/// Or
		/// Set popup element to show on selection.
		/// </summary>
		public UIElement Popup {
			get {
				return GetPopup ();
			}
			set {
				SetPopup (value);
			}
		}

		/// <summary>
		/// Return popup element offset.
		/// Or
		/// Set popup element offset.
		/// </summary>
		public Urho.IntVector2 PopupOffset {
			get {
				return GetPopupOffset ();
			}
			set {
				SetPopupOffset (value);
			}
		}

		/// <summary>
		/// Return whether popup is open.
		/// </summary>
		public bool IsPopupShown {
			get {
				return GetShowPopup ();
			}
		}

		/// <summary>
		/// Return accelerator key code, 0 if disabled.
		/// </summary>
		public int AcceleratorKey {
			get {
				return GetAcceleratorKey ();
			}
		}

		/// <summary>
		/// Return accelerator qualifiers.
		/// </summary>
		public int AcceleratorQualifiers {
			get {
				return GetAcceleratorQualifiers ();
			}
		}
	}
}
