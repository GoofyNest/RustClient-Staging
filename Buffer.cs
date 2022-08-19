public static class Buffer // TypeDefIndex: 180
{	// Methods

	// RVA: 0x1560930 Offset: 0x155EF30 VA: 0x181560930
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x1560870 Offset: 0x155EE70 VA: 0x181560870
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x1560CE0 Offset: 0x155F2E0 VA: 0x181560CE0
	private static int _ByteLength(Array array) { }

	// RVA: 0x1560CC0 Offset: 0x155F2C0 VA: 0x181560CC0
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1560B20 Offset: 0x155F120 VA: 0x181560B20
	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1560940 Offset: 0x155EF40 VA: 0x181560940
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x15607B0 Offset: 0x155EDB0 VA: 0x1815607B0
	public static int ByteLength(Array array) { }

	// RVA: 0x1560580 Offset: 0x155EB80 VA: 0x181560580
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1560B60 Offset: 0x155F160 VA: 0x181560B60
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x1560E20 Offset: 0x155F420 VA: 0x181560E20
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x1560DA0 Offset: 0x155F3A0 VA: 0x181560DA0
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x1560CF0 Offset: 0x155F2F0 VA: 0x181560CF0
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x1560980 Offset: 0x155EF80 VA: 0x181560980
	internal static void Memcpy(byte* dest, byte* src, int size) { }

}

