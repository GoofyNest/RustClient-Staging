public static class Convert // TypeDefIndex: 196
{	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x14572C0 Offset: 0x14558C0 VA: 0x1814572C0
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x1457330 Offset: 0x1455930 VA: 0x181457330
	public static bool IsDBNull(object value) { }

	// RVA: 0x1454500 Offset: 0x1452B00 VA: 0x181454500
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x1455AA0 Offset: 0x14540A0 VA: 0x181455AA0
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x1455770 Offset: 0x1453D70 VA: 0x181455770
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x1454960 Offset: 0x1452F60 VA: 0x181454960
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1457EA0 Offset: 0x14564A0 VA: 0x181457EA0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1457FB0 Offset: 0x14565B0 VA: 0x181457FB0
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x1457FB0 Offset: 0x14565B0 VA: 0x181457FB0
	public static bool ToBoolean(byte value) { }

	// RVA: 0x1457DE0 Offset: 0x14563E0 VA: 0x181457DE0
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1457DE0 Offset: 0x14563E0 VA: 0x181457DE0
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x1457E10 Offset: 0x1456410 VA: 0x181457E10
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1457E10 Offset: 0x1456410 VA: 0x181457E10
	public static bool ToBoolean(uint value) { }

	// RVA: 0x682990 Offset: 0x680F90 VA: 0x180682990
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x682990 Offset: 0x680F90 VA: 0x180682990
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x1457F50 Offset: 0x1456550 VA: 0x181457F50
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x1457FC0 Offset: 0x14565C0 VA: 0x181457FC0
	public static bool ToBoolean(float value) { }

	// RVA: 0x1457DF0 Offset: 0x14563F0 VA: 0x181457DF0
	public static bool ToBoolean(double value) { }

	// RVA: 0x1457E20 Offset: 0x1456420 VA: 0x181457E20
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x1458A50 Offset: 0x1457050 VA: 0x181458A50
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14588D0 Offset: 0x1456ED0 VA: 0x1814588D0
	public static char ToChar(sbyte value) { }

	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static char ToChar(byte value) { }

	// RVA: 0x1458B00 Offset: 0x1457100 VA: 0x181458B00
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static char ToChar(ushort value) { }

	// RVA: 0x1458950 Offset: 0x1456F50 VA: 0x181458950
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458850 Offset: 0x1456E50 VA: 0x181458850
	public static char ToChar(uint value) { }

	// RVA: 0x14589D0 Offset: 0x1456FD0 VA: 0x1814589D0
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458C40 Offset: 0x1457240 VA: 0x181458C40
	public static char ToChar(ulong value) { }

	// RVA: 0x1458B80 Offset: 0x1457180 VA: 0x181458B80
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AE30 Offset: 0x1459430 VA: 0x18145AE30
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1457FB0 Offset: 0x14565B0 VA: 0x181457FB0
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AD20 Offset: 0x1459320 VA: 0x18145AD20
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B1C0 Offset: 0x14597C0 VA: 0x18145B1C0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B2D0 Offset: 0x14598D0 VA: 0x18145B2D0
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B040 Offset: 0x1459640 VA: 0x18145B040
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B140 Offset: 0x1459740 VA: 0x18145B140
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AFC0 Offset: 0x14595C0 VA: 0x18145AFC0
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145ADA0 Offset: 0x14593A0 VA: 0x18145ADA0
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B0C0 Offset: 0x14596C0 VA: 0x18145B0C0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B360 Offset: 0x1459960 VA: 0x18145B360
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AEE0 Offset: 0x14594E0 VA: 0x18145AEE0
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B240 Offset: 0x1459840 VA: 0x18145B240
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B2C0 Offset: 0x14598C0 VA: 0x18145B2C0
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x14582B0 Offset: 0x14568B0 VA: 0x1814582B0
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x1457FB0 Offset: 0x14565B0 VA: 0x181457FB0
	public static byte ToByte(bool value) { }

	// RVA: 0x1458760 Offset: 0x1456D60 VA: 0x181458760
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458360 Offset: 0x1456960 VA: 0x181458360
	public static byte ToByte(sbyte value) { }

	// RVA: 0x1457FD0 Offset: 0x14565D0 VA: 0x181457FD0
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458050 Offset: 0x1456650 VA: 0x181458050
	public static byte ToByte(ushort value) { }

	// RVA: 0x14586C0 Offset: 0x1456CC0 VA: 0x1814586C0
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14580D0 Offset: 0x14566D0 VA: 0x1814580D0
	public static byte ToByte(uint value) { }

	// RVA: 0x1458150 Offset: 0x1456750 VA: 0x181458150
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458530 Offset: 0x1456B30 VA: 0x181458530
	public static byte ToByte(ulong value) { }

	// RVA: 0x14585B0 Offset: 0x1456BB0 VA: 0x1814585B0
	public static byte ToByte(float value) { }

	// RVA: 0x14583E0 Offset: 0x14569E0 VA: 0x1814583E0
	public static byte ToByte(double value) { }

	// RVA: 0x14584B0 Offset: 0x1456AB0 VA: 0x1814584B0
	public static byte ToByte(Decimal value) { }

	// RVA: 0x14587E0 Offset: 0x1456DE0 VA: 0x1814587E0
	public static byte ToByte(string value) { }

	// RVA: 0x1458740 Offset: 0x1456D40 VA: 0x181458740
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x1459D70 Offset: 0x1458370 VA: 0x181459D70
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x145A090 Offset: 0x1458690 VA: 0x18145A090
	public static short ToInt16(bool value) { }

	// RVA: 0x1459E20 Offset: 0x1458420 VA: 0x181459E20
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459BC0 Offset: 0x14581C0 VA: 0x181459BC0
	public static short ToInt16(sbyte value) { }

	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459BD0 Offset: 0x14581D0 VA: 0x181459BD0
	public static short ToInt16(ushort value) { }

	// RVA: 0x14599B0 Offset: 0x1457FB0 VA: 0x1814599B0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A0A0 Offset: 0x14586A0 VA: 0x18145A0A0
	public static short ToInt16(uint value) { }

	// RVA: 0x1459B10 Offset: 0x1458110 VA: 0x181459B10
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459F20 Offset: 0x1458520 VA: 0x181459F20
	public static short ToInt16(ulong value) { }

	// RVA: 0x1459C50 Offset: 0x1458250 VA: 0x181459C50
	public static short ToInt16(float value) { }

	// RVA: 0x1459A30 Offset: 0x1458030 VA: 0x181459A30
	public static short ToInt16(double value) { }

	// RVA: 0x1459EA0 Offset: 0x14584A0 VA: 0x181459EA0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x1459BA0 Offset: 0x14581A0 VA: 0x181459BA0
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BE30 Offset: 0x145A430 VA: 0x18145BE30
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A090 Offset: 0x1458690 VA: 0x18145A090
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BC10 Offset: 0x145A210 VA: 0x18145BC10
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BC90 Offset: 0x145A290 VA: 0x18145BC90
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BD10 Offset: 0x145A310 VA: 0x18145BD10
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BB90 Offset: 0x145A190 VA: 0x18145BB90
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BD90 Offset: 0x145A390 VA: 0x18145BD90
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BFB0 Offset: 0x145A5B0 VA: 0x18145BFB0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BA80 Offset: 0x145A080 VA: 0x18145BA80
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BEE0 Offset: 0x145A4E0 VA: 0x18145BEE0
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BA00 Offset: 0x145A000 VA: 0x18145BA00
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BE10 Offset: 0x145A410 VA: 0x18145BE10
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x145A680 Offset: 0x1458C80 VA: 0x18145A680
	public static int ToInt32(object value) { }

	// RVA: 0x145A3B0 Offset: 0x14589B0 VA: 0x18145A3B0
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x145A230 Offset: 0x1458830 VA: 0x18145A230
	public static int ToInt32(bool value) { }

	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static int ToInt32(char value) { }

	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static int ToInt32(byte value) { }

	// RVA: 0x145A650 Offset: 0x1458C50 VA: 0x18145A650
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A570 Offset: 0x1458B70 VA: 0x18145A570
	public static int ToInt32(uint value) { }

	// RVA: 0x145A320 Offset: 0x1458920 VA: 0x18145A320
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A2A0 Offset: 0x14588A0 VA: 0x18145A2A0
	public static int ToInt32(ulong value) { }

	// RVA: 0x145A5F0 Offset: 0x1458BF0 VA: 0x18145A5F0
	public static int ToInt32(float value) { }

	// RVA: 0x145A120 Offset: 0x1458720 VA: 0x18145A120
	public static int ToInt32(double value) { }

	// RVA: 0x145A240 Offset: 0x1458840 VA: 0x18145A240
	public static int ToInt32(Decimal value) { }

	// RVA: 0x145A500 Offset: 0x1458B00 VA: 0x18145A500
	public static int ToInt32(string value) { }

	// RVA: 0x145A660 Offset: 0x1458C60 VA: 0x18145A660
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C230 Offset: 0x145A830 VA: 0x18145C230
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C450 Offset: 0x145AA50 VA: 0x18145C450
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A230 Offset: 0x1458830 VA: 0x18145A230
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C2D0 Offset: 0x145A8D0 VA: 0x18145C2D0
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C5D0 Offset: 0x145ABD0 VA: 0x18145C5D0
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C3D0 Offset: 0x145A9D0 VA: 0x18145C3D0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C670 Offset: 0x145AC70 VA: 0x18145C670
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C350 Offset: 0x145A950 VA: 0x18145C350
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C6F0 Offset: 0x145ACF0 VA: 0x18145C6F0
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C500 Offset: 0x145AB00 VA: 0x18145C500
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C110 Offset: 0x145A710 VA: 0x18145C110
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C650 Offset: 0x145AC50 VA: 0x18145C650
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x145A7E0 Offset: 0x1458DE0 VA: 0x18145A7E0
	public static long ToInt64(object value) { }

	// RVA: 0x145AB60 Offset: 0x1459160 VA: 0x18145AB60
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x145AC10 Offset: 0x1459210 VA: 0x18145AC10
	public static long ToInt64(bool value) { }

	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AC20 Offset: 0x1459220 VA: 0x18145AC20
	public static long ToInt64(sbyte value) { }

	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static long ToInt64(byte value) { }

	// RVA: 0x145A720 Offset: 0x1458D20 VA: 0x18145A720
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static long ToInt64(ushort value) { }

	// RVA: 0x145A880 Offset: 0x1458E80 VA: 0x18145A880
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A730 Offset: 0x1458D30 VA: 0x18145A730
	public static long ToInt64(ulong value) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static long ToInt64(long value) { }

	// RVA: 0x145A990 Offset: 0x1458F90 VA: 0x18145A990
	public static long ToInt64(float value) { }

	// RVA: 0x145A890 Offset: 0x1458E90 VA: 0x18145A890
	public static long ToInt64(double value) { }

	// RVA: 0x145A910 Offset: 0x1458F10 VA: 0x18145A910
	public static long ToInt64(Decimal value) { }

	// RVA: 0x145AAF0 Offset: 0x14590F0 VA: 0x18145AAF0
	public static long ToInt64(string value) { }

	// RVA: 0x145A7C0 Offset: 0x1458DC0 VA: 0x18145A7C0
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CB60 Offset: 0x145B160 VA: 0x18145CB60
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A230 Offset: 0x1458830 VA: 0x18145A230
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C800 Offset: 0x145AE00 VA: 0x18145C800
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125CF10 Offset: 0x125B510 VA: 0x18125CF10
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CA40 Offset: 0x145B040 VA: 0x18145CA40
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x136FB00 Offset: 0x136E100 VA: 0x18136FB00
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C880 Offset: 0x145AE80 VA: 0x18145C880
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CCF0 Offset: 0x145B2F0 VA: 0x18145CCF0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CC10 Offset: 0x145B210 VA: 0x18145CC10
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CAC0 Offset: 0x145B0C0 VA: 0x18145CAC0
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C900 Offset: 0x145AF00 VA: 0x18145C900
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C980 Offset: 0x145AF80 VA: 0x18145C980
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x145B580 Offset: 0x1459B80 VA: 0x18145B580
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B4E0 Offset: 0x1459AE0 VA: 0x18145B4E0
	public static float ToSingle(sbyte value) { }

	// RVA: 0x145B480 Offset: 0x1459A80 VA: 0x18145B480
	public static float ToSingle(byte value) { }

	// RVA: 0x145B4A0 Offset: 0x1459AA0 VA: 0x18145B4A0
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B660 Offset: 0x1459C60 VA: 0x18145B660
	public static float ToSingle(ushort value) { }

	// RVA: 0x145B4B0 Offset: 0x1459AB0 VA: 0x18145B4B0
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B4F0 Offset: 0x1459AF0 VA: 0x18145B4F0
	public static float ToSingle(uint value) { }

	// RVA: 0x145B490 Offset: 0x1459A90 VA: 0x18145B490
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B630 Offset: 0x1459C30 VA: 0x18145B630
	public static float ToSingle(ulong value) { }

	// RVA: 0x145B570 Offset: 0x1459B70 VA: 0x18145B570
	public static float ToSingle(double value) { }

	// RVA: 0x145B510 Offset: 0x1459B10 VA: 0x18145B510
	public static float ToSingle(Decimal value) { }

	// RVA: 0x145B4C0 Offset: 0x1459AC0 VA: 0x18145B4C0
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x145B500 Offset: 0x1459B00 VA: 0x18145B500
	public static float ToSingle(bool value) { }

	// RVA: 0x1459880 Offset: 0x1457E80 VA: 0x181459880
	public static double ToDouble(object value) { }

	// RVA: 0x14596C0 Offset: 0x1457CC0 VA: 0x1814596C0
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14597A0 Offset: 0x1457DA0 VA: 0x1814597A0
	public static double ToDouble(sbyte value) { }

	// RVA: 0x14599A0 Offset: 0x1457FA0 VA: 0x1814599A0
	public static double ToDouble(byte value) { }

	// RVA: 0x1459860 Offset: 0x1457E60 VA: 0x181459860
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14597B0 Offset: 0x1457DB0 VA: 0x1814597B0
	public static double ToDouble(ushort value) { }

	// RVA: 0x1459920 Offset: 0x1457F20 VA: 0x181459920
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459870 Offset: 0x1457E70 VA: 0x181459870
	public static double ToDouble(uint value) { }

	// RVA: 0x14597C0 Offset: 0x1457DC0 VA: 0x1814597C0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459770 Offset: 0x1457D70 VA: 0x181459770
	public static double ToDouble(ulong value) { }

	// RVA: 0x14597D0 Offset: 0x1457DD0 VA: 0x1814597D0
	public static double ToDouble(float value) { }

	// RVA: 0x1459930 Offset: 0x1457F30 VA: 0x181459930
	public static double ToDouble(Decimal value) { }

	// RVA: 0x14597E0 Offset: 0x1457DE0 VA: 0x1814597E0
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x1459990 Offset: 0x1457F90 VA: 0x181459990
	public static double ToDouble(bool value) { }

	// RVA: 0x1458F80 Offset: 0x1457580 VA: 0x181458F80
	public static Decimal ToDecimal(object value) { }

	// RVA: 0x1459310 Offset: 0x1457910 VA: 0x181459310
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14590F0 Offset: 0x14576F0 VA: 0x1814590F0
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x1458EA0 Offset: 0x14574A0 VA: 0x181458EA0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x1459490 Offset: 0x1457A90 VA: 0x181459490
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459650 Offset: 0x1457C50 VA: 0x181459650
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x1459160 Offset: 0x1457760 VA: 0x181459160
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458F10 Offset: 0x1457510 VA: 0x181458F10
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x1459500 Offset: 0x1457B00 VA: 0x181459500
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14592A0 Offset: 0x14578A0 VA: 0x1814592A0
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x1458E30 Offset: 0x1457430 VA: 0x181458E30
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x14595E0 Offset: 0x1457BE0 VA: 0x1814595E0
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x14591D0 Offset: 0x14577D0 VA: 0x1814591D0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x1459570 Offset: 0x1457B70 VA: 0x181459570
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x1458CC0 Offset: 0x14572C0 VA: 0x181458CC0
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x1458DA0 Offset: 0x14573A0 VA: 0x181458DA0
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x145B800 Offset: 0x1459E00 VA: 0x18145B800
	public static string ToString(object value) { }

	// RVA: 0x145B690 Offset: 0x1459C90 VA: 0x18145B690
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x145B7E0 Offset: 0x1459DE0 VA: 0x18145B7E0
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x145B670 Offset: 0x1459C70 VA: 0x18145B670
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x14581D0 Offset: 0x14567D0 VA: 0x1814581D0
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AC30 Offset: 0x1459230 VA: 0x18145AC30
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x1459FA0 Offset: 0x14585A0 VA: 0x181459FA0
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C030 Offset: 0x145A630 VA: 0x18145C030
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x145A460 Offset: 0x1458A60 VA: 0x18145A460
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C190 Offset: 0x145A790 VA: 0x18145C190
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x145AA50 Offset: 0x1459050 VA: 0x18145AA50
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C9A0 Offset: 0x145AFA0 VA: 0x18145C9A0
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x145B960 Offset: 0x1459F60 VA: 0x18145B960
	public static string ToString(int value, int toBase) { }

	// RVA: 0x1457C50 Offset: 0x1456250 VA: 0x181457C50
	public static string ToBase64String(byte[] inArray) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1457BA0 Offset: 0x14561A0 VA: 0x181457BA0
	public static string ToBase64String(byte[] inArray, Base64FormattingOptions options) { }

	// RVA: 0x1457B20 Offset: 0x1456120 VA: 0x181457B20
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1457830 Offset: 0x1455E30 VA: 0x181457830
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x14573D0 Offset: 0x14559D0 VA: 0x1814573D0
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1457460 Offset: 0x1455A60 VA: 0x181457460
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x1455800 Offset: 0x1453E00 VA: 0x181455800
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x1457CF0 Offset: 0x14562F0 VA: 0x181457CF0
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x1456E30 Offset: 0x1455430 VA: 0x181456E30
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x1456AC0 Offset: 0x14550C0 VA: 0x181456AC0
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x1456C60 Offset: 0x1455260 VA: 0x181456C60
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x1456FC0 Offset: 0x14555C0 VA: 0x181456FC0
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x1456EE0 Offset: 0x14554E0 VA: 0x181456EE0
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x145CD70 Offset: 0x145B370 VA: 0x18145CD70
	private static void .cctor() { }

}

