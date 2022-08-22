public static class BitConverter // TypeDefIndex: 178
{	// Fields
	public static readonly bool IsLittleEndian; // 0x13BF0

	// Methods

	// RVA: 0x155ED90 Offset: 0x155D390 VA: 0x18155ED90
	private static bool AmILittleEndian() { }

	// RVA: 0x155F190 Offset: 0x155D790 VA: 0x18155F190
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x155EFE0 Offset: 0x155D5E0 VA: 0x18155EFE0
	public static byte[] GetBytes(char value) { }

	// RVA: 0x155F1F0 Offset: 0x155D7F0 VA: 0x18155F1F0
	public static byte[] GetBytes(short value) { }

	// RVA: 0x155F130 Offset: 0x155D730 VA: 0x18155F130
	public static byte[] GetBytes(int value) { }

	// RVA: 0x155EDB0 Offset: 0x155D3B0 VA: 0x18155EDB0
	public static byte[] GetBytes(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155EF40 Offset: 0x155D540 VA: 0x18155EF40
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155EE10 Offset: 0x155D410 VA: 0x18155EE10
	public static byte[] GetBytes(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155F250 Offset: 0x155D850 VA: 0x18155F250
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x155EEA0 Offset: 0x155D4A0 VA: 0x18155EEA0
	public static byte[] GetBytes(float value) { }

	// RVA: 0x155F080 Offset: 0x155D680 VA: 0x18155F080
	public static byte[] GetBytes(double value) { }

	// RVA: 0x155F310 Offset: 0x155D910 VA: 0x18155F310
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x155F420 Offset: 0x155DA20 VA: 0x18155F420
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x155F560 Offset: 0x155DB60 VA: 0x18155F560
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155FB40 Offset: 0x155E140 VA: 0x18155FB40
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155FCE0 Offset: 0x155E2E0 VA: 0x18155FCE0
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x155FEB0 Offset: 0x155E4B0 VA: 0x18155FEB0
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x155F2F0 Offset: 0x155D8F0 VA: 0x18155F2F0
	private static char GetHexValue(int i) { }

	// RVA: 0x155F790 Offset: 0x155DD90 VA: 0x18155F790
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x155F700 Offset: 0x155DD00 VA: 0x18155F700
	public static string ToString(byte[] value) { }

	// RVA: 0xE5BF10 Offset: 0xE5A510 VA: 0x180E5BF10
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x155F300 Offset: 0x155D900 VA: 0x18155F300
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x155FF50 Offset: 0x155E550 VA: 0x18155FF50
	private static void .cctor() { }

}

