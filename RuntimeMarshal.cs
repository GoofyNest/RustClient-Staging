internal static class RuntimeMarshal // TypeDefIndex: 11
{	// Methods

	// RVA: 0x164A6D0 Offset: 0x1648CD0 VA: 0x18164A6D0
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x164A670 Offset: 0x1648C70 VA: 0x18164A670
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x164A5E0 Offset: 0x1648BE0 VA: 0x18164A5E0
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x164A4F0 Offset: 0x1648AF0 VA: 0x18164A4F0
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x164A4D0 Offset: 0x1648AD0 VA: 0x18164A4D0
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x164A660 Offset: 0x1648C60 VA: 0x18164A660
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

}

