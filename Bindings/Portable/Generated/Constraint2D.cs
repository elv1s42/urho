// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Constraint2D.cs
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
	/// 2D physics constraint component.
	/// </summary>
	public unsafe partial class Constraint2D : Component
	{
		[Preserve]
		public Constraint2D (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected Constraint2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Constraint2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Constraint2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Constraint2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Constraint2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Constraint2D));
			return new StringHash (Constraint2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Constraint2D));
			return Marshal.PtrToStringAnsi (Constraint2D_GetTypeNameStatic ());
		}

		public Constraint2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint2D_Constraint2D (IntPtr context);

		public Constraint2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Constraint2D));
			handle = Constraint2D_Constraint2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Constraint2D));
			Constraint2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_OnSetEnabled (IntPtr handle);

		/// <summary>
		/// Handle enabled/disabled state change.
		/// </summary>
		public override void OnSetEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint2D_OnSetEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_CreateJoint (IntPtr handle);

		/// <summary>
		/// Create joint.
		/// </summary>
		public void CreateJoint ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint2D_CreateJoint (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_ReleaseJoint (IntPtr handle);

		/// <summary>
		/// Release joint.
		/// </summary>
		public void ReleaseJoint ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint2D_ReleaseJoint (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_SetOtherBody (IntPtr handle, IntPtr body);

		/// <summary>
		/// Set other rigid body.
		/// </summary>
		private void SetOtherBody (RigidBody2D body)
		{
			Runtime.ValidateRefCounted (this);
			Constraint2D_SetOtherBody (handle, (object)body == null ? IntPtr.Zero : body.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_SetCollideConnected (IntPtr handle, bool collideConnected);

		/// <summary>
		/// Set collide connected.
		/// </summary>
		private void SetCollideConnected (bool collideConnected)
		{
			Runtime.ValidateRefCounted (this);
			Constraint2D_SetCollideConnected (handle, collideConnected);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint2D_SetAttachedConstraint (IntPtr handle, IntPtr constraint);

		/// <summary>
		/// Set attached constriant (for gear).
		/// </summary>
		private void SetAttachedConstraint (Constraint2D constraint)
		{
			Runtime.ValidateRefCounted (this);
			Constraint2D_SetAttachedConstraint (handle, (object)constraint == null ? IntPtr.Zero : constraint.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint2D_GetOwnerBody (IntPtr handle);

		/// <summary>
		/// Return owner body.
		/// </summary>
		private RigidBody2D GetOwnerBody ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<RigidBody2D> (Constraint2D_GetOwnerBody (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint2D_GetOtherBody (IntPtr handle);

		/// <summary>
		/// Return other body.
		/// </summary>
		private RigidBody2D GetOtherBody ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<RigidBody2D> (Constraint2D_GetOtherBody (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Constraint2D_GetCollideConnected (IntPtr handle);

		/// <summary>
		/// Return collide connected.
		/// </summary>
		private bool GetCollideConnected ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint2D_GetCollideConnected (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint2D_GetAttachedConstraint (IntPtr handle);

		/// <summary>
		/// Return attached constraint (for gear).
		/// </summary>
		private Constraint2D GetAttachedConstraint ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Constraint2D> (Constraint2D_GetAttachedConstraint (handle));
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
		/// Return other body.
		/// Or
		/// Set other rigid body.
		/// </summary>
		public RigidBody2D OtherBody {
			get {
				return GetOtherBody ();
			}
			set {
				SetOtherBody (value);
			}
		}

		/// <summary>
		/// Return collide connected.
		/// Or
		/// Set collide connected.
		/// </summary>
		public bool CollideConnected {
			get {
				return GetCollideConnected ();
			}
			set {
				SetCollideConnected (value);
			}
		}

		/// <summary>
		/// Return attached constraint (for gear).
		/// Or
		/// Set attached constriant (for gear).
		/// </summary>
		public Constraint2D AttachedConstraint {
			get {
				return GetAttachedConstraint ();
			}
			set {
				SetAttachedConstraint (value);
			}
		}

		/// <summary>
		/// Return owner body.
		/// </summary>
		public RigidBody2D OwnerBody {
			get {
				return GetOwnerBody ();
			}
		}
	}
}
