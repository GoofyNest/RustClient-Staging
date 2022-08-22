public static class Buffer // TypeDefIndex: 180
{	// Methods

	// RVA: 0x1560BF0 Offset: 0x155F1F0 VA: 0x181560BF0
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x1560B30 Offset: 0x155F130 VA: 0x181560B30
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x1560FA0 Offset: 0x155F5A0 VA: 0x181560FA0
	private static int _ByteLength(Array array) { }

	// RVA: 0x1560F80 Offset: 0x155F580 VA: 0x181560F80
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1560DE0 Offset: 0x155F3E0 VA: 0x181560DE0
	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1560C00 Offset: 0x155F200 VA: 0x181560C00
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x1560A70 Offset: 0x155F070 VA: 0x181560A70
	public static int ByteLength(Array array) { }

	// RVA: 0x1560840 Offset: 0x155EE40 VA: 0x181560840
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1560E20 Offset: 0x155F420 VA: 0x181560E20
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x15610E0 Offset: 0x155F6E0 VA: 0x1815610E0
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x1561060 Offset: 0x155F660 VA: 0x181561060
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x1560FB0 Offset: 0x155F5B0 VA: 0x181560FB0
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x1560C40 Offset: 0x155F240 VA: 0x181560C40
	internal static void Memcpy(byte* dest, byte* src, int size) { }

}

