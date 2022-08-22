internal sealed class BitConverterLE // TypeDefIndex: 47
{	// Methods

	// RVA: 0x1742C10 Offset: 0x1741210 VA: 0x181742C10
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1742D80 Offset: 0x1741380 VA: 0x181742D80
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1742BD0 Offset: 0x17411D0 VA: 0x181742BD0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1742BF0 Offset: 0x17411F0 VA: 0x181742BF0
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x1742BB0 Offset: 0x17411B0 VA: 0x181742BB0
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x1743150 Offset: 0x1741750 VA: 0x181743150
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1743310 Offset: 0x1741910 VA: 0x181743310
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1743120 Offset: 0x1741720 VA: 0x181743120
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x1743020 Offset: 0x1741620 VA: 0x181743020
	internal static double ToDouble(byte[] value, int startIndex) { }

}

internal sealed class BitConverterLE // TypeDefIndex: 1706
{	// Methods

	// RVA: 0x1AB16E0 Offset: 0x1AAFCE0 VA: 0x181AB16E0
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1AB1850 Offset: 0x1AAFE50 VA: 0x181AB1850
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1AB16A0 Offset: 0x1AAFCA0 VA: 0x181AB16A0
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1AB16C0 Offset: 0x1AAFCC0 VA: 0x181AB16C0
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1AB1DF0 Offset: 0x1AB03F0 VA: 0x181AB1DF0
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AB1C30 Offset: 0x1AB0230 VA: 0x181AB1C30
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1AB1AF0 Offset: 0x1AB00F0 VA: 0x181AB1AF0
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1AB1C00 Offset: 0x1AB0200 VA: 0x181AB1C00
	internal static uint ToUInt32(byte[] value, int startIndex) { }

}

