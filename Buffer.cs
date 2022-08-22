public static class Buffer // TypeDefIndex: 180
{	// Methods

	// RVA: 0x155FCC0 Offset: 0x155E2C0 VA: 0x18155FCC0
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x155FC00 Offset: 0x155E200 VA: 0x18155FC00
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x1560070 Offset: 0x155E670 VA: 0x181560070
	private static int _ByteLength(Array array) { }

	// RVA: 0x1560050 Offset: 0x155E650 VA: 0x181560050
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x155FEB0 Offset: 0x155E4B0 VA: 0x18155FEB0
	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x155FCD0 Offset: 0x155E2D0 VA: 0x18155FCD0
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x155FB40 Offset: 0x155E140 VA: 0x18155FB40
	public static int ByteLength(Array array) { }

	// RVA: 0x155F910 Offset: 0x155DF10 VA: 0x18155F910
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155FEF0 Offset: 0x155E4F0 VA: 0x18155FEF0
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x15601B0 Offset: 0x155E7B0 VA: 0x1815601B0
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x1560130 Offset: 0x155E730 VA: 0x181560130
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x1560080 Offset: 0x155E680 VA: 0x181560080
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x155FD10 Offset: 0x155E310 VA: 0x18155FD10
	internal static void Memcpy(byte* dest, byte* src, int size) { }

}

