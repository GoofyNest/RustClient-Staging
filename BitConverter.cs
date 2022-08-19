public static class BitConverter // TypeDefIndex: 178
{	// Fields
	public static readonly bool IsLittleEndian; // 0x13BF0

	// Methods

	// RVA: 0x155EAD0 Offset: 0x155D0D0 VA: 0x18155EAD0
	private static bool AmILittleEndian() { }

	// RVA: 0x155EED0 Offset: 0x155D4D0 VA: 0x18155EED0
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x155ED20 Offset: 0x155D320 VA: 0x18155ED20
	public static byte[] GetBytes(char value) { }

	// RVA: 0x155EF30 Offset: 0x155D530 VA: 0x18155EF30
	public static byte[] GetBytes(short value) { }

	// RVA: 0x155EE70 Offset: 0x155D470 VA: 0x18155EE70
	public static byte[] GetBytes(int value) { }

	// RVA: 0x155EAF0 Offset: 0x155D0F0 VA: 0x18155EAF0
	public static byte[] GetBytes(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x155EC80 Offset: 0x155D280 VA: 0x18155EC80
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x155EB50 Offset: 0x155D150 VA: 0x18155EB50
	public static byte[] GetBytes(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x155EF90 Offset: 0x155D590 VA: 0x18155EF90
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x155EBE0 Offset: 0x155D1E0 VA: 0x18155EBE0
	public static byte[] GetBytes(float value) { }

	// RVA: 0x155EDC0 Offset: 0x155D3C0 VA: 0x18155EDC0
	public static byte[] GetBytes(double value) { }

	// RVA: 0x155F050 Offset: 0x155D650 VA: 0x18155F050
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x155F160 Offset: 0x155D760 VA: 0x18155F160
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x155F2A0 Offset: 0x155D8A0 VA: 0x18155F2A0
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x155F880 Offset: 0x155DE80 VA: 0x18155F880
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x155FA20 Offset: 0x155E020 VA: 0x18155FA20
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x155FBF0 Offset: 0x155E1F0 VA: 0x18155FBF0
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x155F030 Offset: 0x155D630 VA: 0x18155F030
	private static char GetHexValue(int i) { }

	// RVA: 0x155F4D0 Offset: 0x155DAD0 VA: 0x18155F4D0
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x155F440 Offset: 0x155DA40 VA: 0x18155F440
	public static string ToString(byte[] value) { }

	// RVA: 0xE5BC50 Offset: 0xE5A250 VA: 0x180E5BC50
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x155F040 Offset: 0x155D640 VA: 0x18155F040
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x155FC90 Offset: 0x155E290 VA: 0x18155FC90
	private static void .cctor() { }

}

