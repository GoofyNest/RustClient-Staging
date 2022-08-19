internal static class RuntimeMarshal // TypeDefIndex: 11
{	// Methods

	// RVA: 0x164A410 Offset: 0x1648A10 VA: 0x18164A410
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x164A3B0 Offset: 0x16489B0 VA: 0x18164A3B0
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x164A320 Offset: 0x1648920 VA: 0x18164A320
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x164A230 Offset: 0x1648830 VA: 0x18164A230
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x164A210 Offset: 0x1648810 VA: 0x18164A210
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x164A3A0 Offset: 0x16489A0 VA: 0x18164A3A0
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

}

