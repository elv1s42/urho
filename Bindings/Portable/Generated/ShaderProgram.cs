// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ShaderProgram.cs
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
	/// Linked shader program on the GPU.
	/// </summary>
	public unsafe partial class ShaderProgram : RefCounted
	{
		[Preserve]
		public ShaderProgram (IntPtr handle) : base (handle)
		{
		}

		[Preserve]
		protected ShaderProgram (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ShaderProgram_ShaderProgram (IntPtr graphics, IntPtr vertexShader, IntPtr pixelShader);

		public ShaderProgram (Graphics graphics, ShaderVariation vertexShader, ShaderVariation pixelShader) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ShaderProgram));
			handle = ShaderProgram_ShaderProgram ((object)graphics == null ? IntPtr.Zero : graphics.Handle, (object)vertexShader == null ? IntPtr.Zero : vertexShader.Handle, (object)pixelShader == null ? IntPtr.Zero : pixelShader.Handle);
			Runtime.RegisterObject (this);
		}
	}
}
