public static class BitConverter // TypeDefIndex: 178
{	// Fields
	public static readonly bool IsLittleEndian; // 0x2B10394

	// Methods

	// RVA: 0x155DE60 Offset: 0x155C460 VA: 0x18155DE60
	private static bool AmILittleEndian() { }

	// RVA: 0x155E260 Offset: 0x155C860 VA: 0x18155E260
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x155E0B0 Offset: 0x155C6B0 VA: 0x18155E0B0
	public static byte[] GetBytes(char value) { }

	// RVA: 0x155E2C0 Offset: 0x155C8C0 VA: 0x18155E2C0
	public static byte[] GetBytes(short value) { }

	// RVA: 0x155E200 Offset: 0x155C800 VA: 0x18155E200
	public static byte[] GetBytes(int value) { }

	// RVA: 0x155DE80 Offset: 0x155C480 VA: 0x18155DE80
	public static byte[] GetBytes(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155E010 Offset: 0x155C610 VA: 0x18155E010
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155DEE0 Offset: 0x155C4E0 VA: 0x18155DEE0
	public static byte[] GetBytes(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155E320 Offset: 0x155C920 VA: 0x18155E320
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x155DF70 Offset: 0x155C570 VA: 0x18155DF70
	public static byte[] GetBytes(float value) { }

	// RVA: 0x155E150 Offset: 0x155C750 VA: 0x18155E150
	public static byte[] GetBytes(double value) { }

	// RVA: 0x155E3E0 Offset: 0x155C9E0 VA: 0x18155E3E0
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x155E4F0 Offset: 0x155CAF0 VA: 0x18155E4F0
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x155E630 Offset: 0x155CC30 VA: 0x18155E630
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155EC10 Offset: 0x155D210 VA: 0x18155EC10
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155EDB0 Offset: 0x155D3B0 VA: 0x18155EDB0
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155EF80 Offset: 0x155D580 VA: 0x18155EF80
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x155E3C0 Offset: 0x155C9C0 VA: 0x18155E3C0
	private static char GetHexValue(int i) { }

	// RVA: 0x155E860 Offset: 0x155CE60 VA: 0x18155E860
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x155E7D0 Offset: 0x155CDD0 VA: 0x18155E7D0
	public static string ToString(byte[] value) { }

	// RVA: 0xE5C9C0 Offset: 0xE5AFC0 VA: 0x180E5C9C0
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x155E3D0 Offset: 0x155C9D0 VA: 0x18155E3D0
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x155F020 Offset: 0x155D620 VA: 0x18155F020
	private static void .cctor() { }

}

