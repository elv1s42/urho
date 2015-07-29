using System;
using System.Runtime.InteropServices;

namespace Urho {

	[StructLayout(LayoutKind.Sequential)]
	public struct StringHash {
		public int Code;
		public StringHash (int code)
		{
			this.Code = code;
		}

		public StringHash (string str)
		{
			this.Code = urho_stringhash_from_string (str);
		}

		[DllImport ("mono-urho")]
		extern static int urho_stringhash_from_string (string str);
		
		public override string ToString ()
		{
			return $"StringHash({Code:x})";
		}
	}

	// Points to a StringHash
	public struct StringHashRef {
		IntPtr ptr;
		public StringHashRef (IntPtr ptr)
		{
			this.ptr = ptr;
		}

		public static implicit operator StringHash (StringHashRef r)
		{
			return new StringHash (Marshal.ReadInt32 (r.ptr));
		}
	}
}
