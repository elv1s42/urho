// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// EventReceiverGroup.cs
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

namespace Urho
{
	/// <summary>
	/// Tracking structure for event receivers.
	/// </summary>
	public unsafe partial class EventReceiverGroup : RefCounted
	{
		[Preserve]
		public EventReceiverGroup (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected EventReceiverGroup (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr EventReceiverGroup_EventReceiverGroup ();

		public EventReceiverGroup () : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(EventReceiverGroup));
			handle = EventReceiverGroup_EventReceiverGroup ();
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void EventReceiverGroup_BeginSendEvent (IntPtr handle);

		/// <summary>
		/// Begin event send. When receivers are removed during send, group has to be cleaned up afterward.
		/// </summary>
		public void BeginSendEvent ()
		{
			Runtime.ValidateRefCounted (this);
			EventReceiverGroup_BeginSendEvent (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void EventReceiverGroup_EndSendEvent (IntPtr handle);

		/// <summary>
		/// End event send. Clean up if necessary.
		/// </summary>
		public void EndSendEvent ()
		{
			Runtime.ValidateRefCounted (this);
			EventReceiverGroup_EndSendEvent (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void EventReceiverGroup_Add (IntPtr handle, IntPtr @object);

		/// <summary>
		/// Add receiver. Same receiver must not be double-added!
		/// </summary>
		public void Add (Urho.UrhoObject @object)
		{
			Runtime.ValidateRefCounted (this);
			EventReceiverGroup_Add (handle, (object)@object == null ? IntPtr.Zero : @object.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void EventReceiverGroup_Remove (IntPtr handle, IntPtr @object);

		/// <summary>
		/// Remove receiver. Leave holes during send, which requires later cleanup.
		/// </summary>
		public void Remove (Urho.UrhoObject @object)
		{
			Runtime.ValidateRefCounted (this);
			EventReceiverGroup_Remove (handle, (object)@object == null ? IntPtr.Zero : @object.Handle);
		}
	}
}
