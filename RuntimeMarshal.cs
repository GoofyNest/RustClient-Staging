internal static class RuntimeMarshal // TypeDefIndex: 11
{	// Methods

	// RVA: 0x16379F0 Offset: 0x1635FF0 VA: 0x1816379F0
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x1637990 Offset: 0x1635F90 VA: 0x181637990
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x1637900 Offset: 0x1635F00 VA: 0x181637900
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x1637810 Offset: 0x1635E10 VA: 0x181637810
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x16377F0 Offset: 0x1635DF0 VA: 0x1816377F0
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x1637980 Offset: 0x1635F80 VA: 0x181637980
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

}

