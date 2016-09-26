// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Skeleton.cs
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
	/// Hierarchical collection of bones.
	/// </summary>
	public unsafe partial class Skeleton
	{
		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Skeleton_Load (IntPtr handle, IntPtr source);

		/// <summary>
		/// Read from a stream. Return true if successful.
		/// </summary>
		public bool Load (File source)
		{
			Runtime.ValidateObject (this);
			return Skeleton_Load (handle, (object)source == null ? IntPtr.Zero : source.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Skeleton_Save (IntPtr handle, IntPtr dest);

		/// <summary>
		/// Write to a stream. Return true if successful.
		/// </summary>
		public bool Save (File dest)
		{
			Runtime.ValidateObject (this);
			return Skeleton_Save (handle, (object)dest == null ? IntPtr.Zero : dest.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Skeleton_SetRootBoneIndex (IntPtr handle, uint index);

		/// <summary>
		/// Set root bone's index.
		/// </summary>
		public void SetRootBoneIndex (uint index)
		{
			Runtime.ValidateObject (this);
			Skeleton_SetRootBoneIndex (handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Skeleton_ClearBones (IntPtr handle);

		/// <summary>
		/// Clear bones.
		/// </summary>
		public void ClearBones ()
		{
			Runtime.ValidateObject (this);
			Skeleton_ClearBones (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Skeleton_Reset (IntPtr handle);

		/// <summary>
		/// Reset all animating bones to initial positions.
		/// </summary>
		public void Reset ()
		{
			Runtime.ValidateObject (this);
			Skeleton_Reset (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint Skeleton_GetNumBones (IntPtr handle);

		/// <summary>
		/// Return number of bones.
		/// </summary>
		private uint GetNumBones ()
		{
			Runtime.ValidateObject (this);
			return Skeleton_GetNumBones (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Bone* Skeleton_GetRootBone (IntPtr handle);

		/// <summary>
		/// Return root bone.
		/// </summary>
		private Bone* GetRootBone ()
		{
			Runtime.ValidateObject (this);
			return Skeleton_GetRootBone (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Bone* Skeleton_GetBone (IntPtr handle, uint index);

		/// <summary>
		/// Return bone by index.
		/// </summary>
		public Bone* GetBone (uint index)
		{
			Runtime.ValidateObject (this);
			return Skeleton_GetBone (handle, index);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Bone* Skeleton_GetBone0 (IntPtr handle, int boneNameHash);

		/// <summary>
		/// Return bone by name hash.
		/// </summary>
		public Bone* GetBone (StringHash boneNameHash)
		{
			Runtime.ValidateObject (this);
			return Skeleton_GetBone0 (handle, boneNameHash.Code);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Skeleton_ResetSilent (IntPtr handle);

		/// <summary>
		/// Reset all animating bones to initial positions without marking the nodes dirty. Requires the node dirtying to be performed later.
		/// </summary>
		public void ResetSilent ()
		{
			Runtime.ValidateObject (this);
			Skeleton_ResetSilent (handle);
		}

		/// <summary>
		/// Return number of bones.
		/// </summary>
		public uint NumBones {
			get {
				return GetNumBones ();
			}
		}

		/// <summary>
		/// Return root bone.
		/// </summary>
		public Bone* RootBone {
			get {
				return GetRootBone ();
			}
		}
	}
}