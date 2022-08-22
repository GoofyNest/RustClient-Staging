internal sealed class BitConverterLE // TypeDefIndex: 47
{	// Methods

	// RVA: 0x1745050 Offset: 0x1743650 VA: 0x181745050
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x17451C0 Offset: 0x17437C0 VA: 0x1817451C0
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1745010 Offset: 0x1743610 VA: 0x181745010
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1745030 Offset: 0x1743630 VA: 0x181745030
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x1744FF0 Offset: 0x17435F0 VA: 0x181744FF0
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x1745590 Offset: 0x1743B90 VA: 0x181745590
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1745750 Offset: 0x1743D50 VA: 0x181745750
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1745560 Offset: 0x1743B60 VA: 0x181745560
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x1745460 Offset: 0x1743A60 VA: 0x181745460
	internal static double ToDouble(byte[] value, int startIndex) { }

}

internal sealed class BitConverterLE // TypeDefIndex: 1706
{	// Methods

	// RVA: 0x1AB0EF0 Offset: 0x1AAF4F0 VA: 0x181AB0EF0
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1AB1060 Offset: 0x1AAF660 VA: 0x181AB1060
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1AB0EB0 Offset: 0x1AAF4B0 VA: 0x181AB0EB0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1AB0ED0 Offset: 0x1AAF4D0 VA: 0x181AB0ED0
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1AB1600 Offset: 0x1AAFC00 VA: 0x181AB1600
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AB1440 Offset: 0x1AAFA40 VA: 0x181AB1440
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AB1300 Offset: 0x1AAF900 VA: 0x181AB1300
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1AB1410 Offset: 0x1AAFA10 VA: 0x181AB1410
	internal static uint ToUInt32(byte[] value, int startIndex) { }

}

