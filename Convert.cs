public static class Convert // TypeDefIndex: 196
{	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x1457F30 Offset: 0x1456530 VA: 0x181457F30
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x1457FA0 Offset: 0x14565A0 VA: 0x181457FA0
	public static bool IsDBNull(object value) { }

	// RVA: 0x1455170 Offset: 0x1453770 VA: 0x181455170
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x1456710 Offset: 0x1454D10 VA: 0x181456710
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x14563E0 Offset: 0x14549E0 VA: 0x1814563E0
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x14555D0 Offset: 0x1453BD0 VA: 0x1814555D0
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1458B10 Offset: 0x1457110 VA: 0x181458B10
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458C20 Offset: 0x1457220 VA: 0x181458C20
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x1458C20 Offset: 0x1457220 VA: 0x181458C20
	public static bool ToBoolean(byte value) { }

	// RVA: 0x1458A50 Offset: 0x1457050 VA: 0x181458A50
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458A50 Offset: 0x1457050 VA: 0x181458A50
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x1458A80 Offset: 0x1457080 VA: 0x181458A80
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458A80 Offset: 0x1457080 VA: 0x181458A80
	public static bool ToBoolean(uint value) { }

	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x1458BC0 Offset: 0x14571C0 VA: 0x181458BC0
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x1458C30 Offset: 0x1457230 VA: 0x181458C30
	public static bool ToBoolean(float value) { }

	// RVA: 0x1458A60 Offset: 0x1457060 VA: 0x181458A60
	public static bool ToBoolean(double value) { }

	// RVA: 0x1458A90 Offset: 0x1457090 VA: 0x181458A90
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x14596C0 Offset: 0x1457CC0 VA: 0x1814596C0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459540 Offset: 0x1457B40 VA: 0x181459540
	public static char ToChar(sbyte value) { }

	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static char ToChar(byte value) { }

	// RVA: 0x1459770 Offset: 0x1457D70 VA: 0x181459770
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static char ToChar(ushort value) { }

	// RVA: 0x14595C0 Offset: 0x1457BC0 VA: 0x1814595C0
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14594C0 Offset: 0x1457AC0 VA: 0x1814594C0
	public static char ToChar(uint value) { }

	// RVA: 0x1459640 Offset: 0x1457C40 VA: 0x181459640
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14598B0 Offset: 0x1457EB0 VA: 0x1814598B0
	public static char ToChar(ulong value) { }

	// RVA: 0x14597F0 Offset: 0x1457DF0 VA: 0x1814597F0
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BAA0 Offset: 0x145A0A0 VA: 0x18145BAA0
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458C20 Offset: 0x1457220 VA: 0x181458C20
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B990 Offset: 0x1459F90 VA: 0x18145B990
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BE30 Offset: 0x145A430 VA: 0x18145BE30
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BF40 Offset: 0x145A540 VA: 0x18145BF40
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BCB0 Offset: 0x145A2B0 VA: 0x18145BCB0
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BDB0 Offset: 0x145A3B0 VA: 0x18145BDB0
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BC30 Offset: 0x145A230 VA: 0x18145BC30
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BA10 Offset: 0x145A010 VA: 0x18145BA10
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BD30 Offset: 0x145A330 VA: 0x18145BD30
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BFD0 Offset: 0x145A5D0 VA: 0x18145BFD0
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BB50 Offset: 0x145A150 VA: 0x18145BB50
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BEB0 Offset: 0x145A4B0 VA: 0x18145BEB0
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BF30 Offset: 0x145A530 VA: 0x18145BF30
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x1458F20 Offset: 0x1457520 VA: 0x181458F20
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x1458C20 Offset: 0x1457220 VA: 0x181458C20
	public static byte ToByte(bool value) { }

	// RVA: 0x14593D0 Offset: 0x14579D0 VA: 0x1814593D0
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458FD0 Offset: 0x14575D0 VA: 0x181458FD0
	public static byte ToByte(sbyte value) { }

	// RVA: 0x1458C40 Offset: 0x1457240 VA: 0x181458C40
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458CC0 Offset: 0x14572C0 VA: 0x181458CC0
	public static byte ToByte(ushort value) { }

	// RVA: 0x1459330 Offset: 0x1457930 VA: 0x181459330
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458D40 Offset: 0x1457340 VA: 0x181458D40
	public static byte ToByte(uint value) { }

	// RVA: 0x1458DC0 Offset: 0x14573C0 VA: 0x181458DC0
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x14591A0 Offset: 0x14577A0 VA: 0x1814591A0
	public static byte ToByte(ulong value) { }

	// RVA: 0x1459220 Offset: 0x1457820 VA: 0x181459220
	public static byte ToByte(float value) { }

	// RVA: 0x1459050 Offset: 0x1457650 VA: 0x181459050
	public static byte ToByte(double value) { }

	// RVA: 0x1459120 Offset: 0x1457720 VA: 0x181459120
	public static byte ToByte(Decimal value) { }

	// RVA: 0x1459450 Offset: 0x1457A50 VA: 0x181459450
	public static byte ToByte(string value) { }

	// RVA: 0x14593B0 Offset: 0x14579B0 VA: 0x1814593B0
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x145A9E0 Offset: 0x1458FE0 VA: 0x18145A9E0
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x145AD00 Offset: 0x1459300 VA: 0x18145AD00
	public static short ToInt16(bool value) { }

	// RVA: 0x145AA90 Offset: 0x1459090 VA: 0x18145AA90
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A830 Offset: 0x1458E30 VA: 0x18145A830
	public static short ToInt16(sbyte value) { }

	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A840 Offset: 0x1458E40 VA: 0x18145A840
	public static short ToInt16(ushort value) { }

	// RVA: 0x145A620 Offset: 0x1458C20 VA: 0x18145A620
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AD10 Offset: 0x1459310 VA: 0x18145AD10
	public static short ToInt16(uint value) { }

	// RVA: 0x145A780 Offset: 0x1458D80 VA: 0x18145A780
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AB90 Offset: 0x1459190 VA: 0x18145AB90
	public static short ToInt16(ulong value) { }

	// RVA: 0x145A8C0 Offset: 0x1458EC0 VA: 0x18145A8C0
	public static short ToInt16(float value) { }

	// RVA: 0x145A6A0 Offset: 0x1458CA0 VA: 0x18145A6A0
	public static short ToInt16(double value) { }

	// RVA: 0x145AB10 Offset: 0x1459110 VA: 0x18145AB10
	public static short ToInt16(Decimal value) { }

	// RVA: 0x145A810 Offset: 0x1458E10 VA: 0x18145A810
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CAA0 Offset: 0x145B0A0 VA: 0x18145CAA0
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AD00 Offset: 0x1459300 VA: 0x18145AD00
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C880 Offset: 0x145AE80 VA: 0x18145C880
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C900 Offset: 0x145AF00 VA: 0x18145C900
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C980 Offset: 0x145AF80 VA: 0x18145C980
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C800 Offset: 0x145AE00 VA: 0x18145C800
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CA00 Offset: 0x145B000 VA: 0x18145CA00
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CC20 Offset: 0x145B220 VA: 0x18145CC20
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C6F0 Offset: 0x145ACF0 VA: 0x18145C6F0
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CB50 Offset: 0x145B150 VA: 0x18145CB50
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C670 Offset: 0x145AC70 VA: 0x18145C670
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CA80 Offset: 0x145B080 VA: 0x18145CA80
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x145B2F0 Offset: 0x14598F0 VA: 0x18145B2F0
	public static int ToInt32(object value) { }

	// RVA: 0x145B020 Offset: 0x1459620 VA: 0x18145B020
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x145AEA0 Offset: 0x14594A0 VA: 0x18145AEA0
	public static int ToInt32(bool value) { }

	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static int ToInt32(char value) { }

	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static int ToInt32(byte value) { }

	// RVA: 0x145B2C0 Offset: 0x14598C0 VA: 0x18145B2C0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B1E0 Offset: 0x14597E0 VA: 0x18145B1E0
	public static int ToInt32(uint value) { }

	// RVA: 0x145AF90 Offset: 0x1459590 VA: 0x18145AF90
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AF10 Offset: 0x1459510 VA: 0x18145AF10
	public static int ToInt32(ulong value) { }

	// RVA: 0x145B260 Offset: 0x1459860 VA: 0x18145B260
	public static int ToInt32(float value) { }

	// RVA: 0x145AD90 Offset: 0x1459390 VA: 0x18145AD90
	public static int ToInt32(double value) { }

	// RVA: 0x145AEB0 Offset: 0x14594B0 VA: 0x18145AEB0
	public static int ToInt32(Decimal value) { }

	// RVA: 0x145B170 Offset: 0x1459770 VA: 0x18145B170
	public static int ToInt32(string value) { }

	// RVA: 0x145B2D0 Offset: 0x14598D0 VA: 0x18145B2D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CEA0 Offset: 0x145B4A0 VA: 0x18145CEA0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D0C0 Offset: 0x145B6C0 VA: 0x18145D0C0
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AEA0 Offset: 0x14594A0 VA: 0x18145AEA0
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CF40 Offset: 0x145B540 VA: 0x18145CF40
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D240 Offset: 0x145B840 VA: 0x18145D240
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D040 Offset: 0x145B640 VA: 0x18145D040
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D2E0 Offset: 0x145B8E0 VA: 0x18145D2E0
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CFC0 Offset: 0x145B5C0 VA: 0x18145CFC0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D360 Offset: 0x145B960 VA: 0x18145D360
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D170 Offset: 0x145B770 VA: 0x18145D170
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CD80 Offset: 0x145B380 VA: 0x18145CD80
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D2C0 Offset: 0x145B8C0 VA: 0x18145D2C0
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x145B450 Offset: 0x1459A50 VA: 0x18145B450
	public static long ToInt64(object value) { }

	// RVA: 0x145B7D0 Offset: 0x1459DD0 VA: 0x18145B7D0
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x145B880 Offset: 0x1459E80 VA: 0x18145B880
	public static long ToInt64(bool value) { }

	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B890 Offset: 0x1459E90 VA: 0x18145B890
	public static long ToInt64(sbyte value) { }

	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static long ToInt64(byte value) { }

	// RVA: 0x145B390 Offset: 0x1459990 VA: 0x18145B390
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static long ToInt64(ushort value) { }

	// RVA: 0x145B4F0 Offset: 0x1459AF0 VA: 0x18145B4F0
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B3A0 Offset: 0x14599A0 VA: 0x18145B3A0
	public static long ToInt64(ulong value) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static long ToInt64(long value) { }

	// RVA: 0x145B600 Offset: 0x1459C00 VA: 0x18145B600
	public static long ToInt64(float value) { }

	// RVA: 0x145B500 Offset: 0x1459B00 VA: 0x18145B500
	public static long ToInt64(double value) { }

	// RVA: 0x145B580 Offset: 0x1459B80 VA: 0x18145B580
	public static long ToInt64(Decimal value) { }

	// RVA: 0x145B760 Offset: 0x1459D60 VA: 0x18145B760
	public static long ToInt64(string value) { }

	// RVA: 0x145B430 Offset: 0x1459A30 VA: 0x18145B430
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D7D0 Offset: 0x145BDD0 VA: 0x18145D7D0
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AEA0 Offset: 0x14594A0 VA: 0x18145AEA0
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D470 Offset: 0x145BA70 VA: 0x18145D470
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125C5B0 Offset: 0x125ABB0 VA: 0x18125C5B0
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D6B0 Offset: 0x145BCB0 VA: 0x18145D6B0
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370740 Offset: 0x136ED40 VA: 0x181370740
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D4F0 Offset: 0x145BAF0 VA: 0x18145D4F0
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D960 Offset: 0x145BF60 VA: 0x18145D960
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D880 Offset: 0x145BE80 VA: 0x18145D880
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D730 Offset: 0x145BD30 VA: 0x18145D730
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D570 Offset: 0x145BB70 VA: 0x18145D570
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D5F0 Offset: 0x145BBF0 VA: 0x18145D5F0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x145C1F0 Offset: 0x145A7F0 VA: 0x18145C1F0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C150 Offset: 0x145A750 VA: 0x18145C150
	public static float ToSingle(sbyte value) { }

	// RVA: 0x145C0F0 Offset: 0x145A6F0 VA: 0x18145C0F0
	public static float ToSingle(byte value) { }

	// RVA: 0x145C110 Offset: 0x145A710 VA: 0x18145C110
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C2D0 Offset: 0x145A8D0 VA: 0x18145C2D0
	public static float ToSingle(ushort value) { }

	// RVA: 0x145C120 Offset: 0x145A720 VA: 0x18145C120
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C160 Offset: 0x145A760 VA: 0x18145C160
	public static float ToSingle(uint value) { }

	// RVA: 0x145C100 Offset: 0x145A700 VA: 0x18145C100
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C2A0 Offset: 0x145A8A0 VA: 0x18145C2A0
	public static float ToSingle(ulong value) { }

	// RVA: 0x145C1E0 Offset: 0x145A7E0 VA: 0x18145C1E0
	public static float ToSingle(double value) { }

	// RVA: 0x145C180 Offset: 0x145A780 VA: 0x18145C180
	public static float ToSingle(Decimal value) { }

	// RVA: 0x145C130 Offset: 0x145A730 VA: 0x18145C130
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x145C170 Offset: 0x145A770 VA: 0x18145C170
	public static float ToSingle(bool value) { }

	// RVA: 0x145A4F0 Offset: 0x1458AF0 VA: 0x18145A4F0
	public static double ToDouble(object value) { }

	// RVA: 0x145A330 Offset: 0x1458930 VA: 0x18145A330
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A410 Offset: 0x1458A10 VA: 0x18145A410
	public static double ToDouble(sbyte value) { }

	// RVA: 0x145A610 Offset: 0x1458C10 VA: 0x18145A610
	public static double ToDouble(byte value) { }

	// RVA: 0x145A4D0 Offset: 0x1458AD0 VA: 0x18145A4D0
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A420 Offset: 0x1458A20 VA: 0x18145A420
	public static double ToDouble(ushort value) { }

	// RVA: 0x145A590 Offset: 0x1458B90 VA: 0x18145A590
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A4E0 Offset: 0x1458AE0 VA: 0x18145A4E0
	public static double ToDouble(uint value) { }

	// RVA: 0x145A430 Offset: 0x1458A30 VA: 0x18145A430
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A3E0 Offset: 0x14589E0 VA: 0x18145A3E0
	public static double ToDouble(ulong value) { }

	// RVA: 0x145A440 Offset: 0x1458A40 VA: 0x18145A440
	public static double ToDouble(float value) { }

	// RVA: 0x145A5A0 Offset: 0x1458BA0 VA: 0x18145A5A0
	public static double ToDouble(Decimal value) { }

	// RVA: 0x145A450 Offset: 0x1458A50 VA: 0x18145A450
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x145A600 Offset: 0x1458C00 VA: 0x18145A600
	public static double ToDouble(bool value) { }

	// RVA: 0x1459BF0 Offset: 0x14581F0 VA: 0x181459BF0
	public static Decimal ToDecimal(object value) { }

	// RVA: 0x1459F80 Offset: 0x1458580 VA: 0x181459F80
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459D60 Offset: 0x1458360 VA: 0x181459D60
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x1459B10 Offset: 0x1458110 VA: 0x181459B10
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x145A100 Offset: 0x1458700 VA: 0x18145A100
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A2C0 Offset: 0x14588C0 VA: 0x18145A2C0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x1459DD0 Offset: 0x14583D0 VA: 0x181459DD0
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459B80 Offset: 0x1458180 VA: 0x181459B80
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x145A170 Offset: 0x1458770 VA: 0x18145A170
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459F10 Offset: 0x1458510 VA: 0x181459F10
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x1459AA0 Offset: 0x14580A0 VA: 0x181459AA0
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x145A250 Offset: 0x1458850 VA: 0x18145A250
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x1459E40 Offset: 0x1458440 VA: 0x181459E40
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x145A1E0 Offset: 0x14587E0 VA: 0x18145A1E0
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x1459930 Offset: 0x1457F30 VA: 0x181459930
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x1459A10 Offset: 0x1458010 VA: 0x181459A10
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x145C470 Offset: 0x145AA70 VA: 0x18145C470
	public static string ToString(object value) { }

	// RVA: 0x145C300 Offset: 0x145A900 VA: 0x18145C300
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x145C450 Offset: 0x145AA50 VA: 0x18145C450
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x145C2E0 Offset: 0x145A8E0 VA: 0x18145C2E0
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x1458E40 Offset: 0x1457440 VA: 0x181458E40
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B8A0 Offset: 0x1459EA0 VA: 0x18145B8A0
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x145AC10 Offset: 0x1459210 VA: 0x18145AC10
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CCA0 Offset: 0x145B2A0 VA: 0x18145CCA0
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x145B0D0 Offset: 0x14596D0 VA: 0x18145B0D0
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CE00 Offset: 0x145B400 VA: 0x18145CE00
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x145B6C0 Offset: 0x1459CC0 VA: 0x18145B6C0
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D610 Offset: 0x145BC10 VA: 0x18145D610
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x145C5D0 Offset: 0x145ABD0 VA: 0x18145C5D0
	public static string ToString(int value, int toBase) { }

	// RVA: 0x14588C0 Offset: 0x1456EC0 VA: 0x1814588C0
	public static string ToBase64String(byte[] inArray) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1458810 Offset: 0x1456E10 VA: 0x181458810
	public static string ToBase64String(byte[] inArray, Base64FormattingOptions options) { }

	// RVA: 0x1458790 Offset: 0x1456D90 VA: 0x181458790
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x14584A0 Offset: 0x1456AA0 VA: 0x1814584A0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x1458040 Offset: 0x1456640 VA: 0x181458040
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x14580D0 Offset: 0x14566D0 VA: 0x1814580D0
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x1456470 Offset: 0x1454A70 VA: 0x181456470
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x1458960 Offset: 0x1456F60 VA: 0x181458960
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x1457AA0 Offset: 0x14560A0 VA: 0x181457AA0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x1457730 Offset: 0x1455D30 VA: 0x181457730
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x14578D0 Offset: 0x1455ED0 VA: 0x1814578D0
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x1457C30 Offset: 0x1456230 VA: 0x181457C30
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x1457B50 Offset: 0x1456150 VA: 0x181457B50
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x145D9E0 Offset: 0x145BFE0 VA: 0x18145D9E0
	private static void .cctor() { }

}

