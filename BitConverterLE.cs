internal sealed class BitConverterLE // TypeDefIndex: 47
{	// Methods

	// RVA: 0x1744D90 Offset: 0x1743390 VA: 0x181744D90
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1744F00 Offset: 0x1743500 VA: 0x181744F00
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1744D50 Offset: 0x1743350 VA: 0x181744D50
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1744D70 Offset: 0x1743370 VA: 0x181744D70
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x1744D30 Offset: 0x1743330 VA: 0x181744D30
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x17452D0 Offset: 0x17438D0 VA: 0x1817452D0
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1745490 Offset: 0x1743A90 VA: 0x181745490
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x17452A0 Offset: 0x17438A0 VA: 0x1817452A0
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x17451A0 Offset: 0x17437A0 VA: 0x1817451A0
	internal static double ToDouble(byte[] value, int startIndex) { }

}

internal sealed class BitConverterLE // TypeDefIndex: 1706
{	// Methods

	// RVA: 0x1AB0C30 Offset: 0x1AAF230 VA: 0x181AB0C30
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1AB0DA0 Offset: 0x1AAF3A0 VA: 0x181AB0DA0
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1AB0BF0 Offset: 0x1AAF1F0 VA: 0x181AB0BF0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1AB0C10 Offset: 0x1AAF210 VA: 0x181AB0C10
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1AB1340 Offset: 0x1AAF940 VA: 0x181AB1340
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AB1180 Offset: 0x1AAF780 VA: 0x181AB1180
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AB1040 Offset: 0x1AAF640 VA: 0x181AB1040
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1AB1150 Offset: 0x1AAF750 VA: 0x181AB1150
	internal static uint ToUInt32(byte[] value, int startIndex) { }

}

