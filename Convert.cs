public static class Convert // TypeDefIndex: 196
{	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x14581F0 Offset: 0x14567F0 VA: 0x1814581F0
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x1458260 Offset: 0x1456860 VA: 0x181458260
	public static bool IsDBNull(object value) { }

	// RVA: 0x1455430 Offset: 0x1453A30 VA: 0x181455430
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x14569D0 Offset: 0x1454FD0 VA: 0x1814569D0
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x14566A0 Offset: 0x1454CA0 VA: 0x1814566A0
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x1455890 Offset: 0x1453E90 VA: 0x181455890
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x1458DD0 Offset: 0x14573D0 VA: 0x181458DD0
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458EE0 Offset: 0x14574E0 VA: 0x181458EE0
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x1458EE0 Offset: 0x14574E0 VA: 0x181458EE0
	public static bool ToBoolean(byte value) { }

	// RVA: 0x1458D10 Offset: 0x1457310 VA: 0x181458D10
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458D10 Offset: 0x1457310 VA: 0x181458D10
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x1458D40 Offset: 0x1457340 VA: 0x181458D40
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458D40 Offset: 0x1457340 VA: 0x181458D40
	public static bool ToBoolean(uint value) { }

	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x682A00 Offset: 0x681000 VA: 0x180682A00
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x1458E80 Offset: 0x1457480 VA: 0x181458E80
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x1458EF0 Offset: 0x14574F0 VA: 0x181458EF0
	public static bool ToBoolean(float value) { }

	// RVA: 0x1458D20 Offset: 0x1457320 VA: 0x181458D20
	public static bool ToBoolean(double value) { }

	// RVA: 0x1458D50 Offset: 0x1457350 VA: 0x181458D50
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x1459980 Offset: 0x1457F80 VA: 0x181459980
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459800 Offset: 0x1457E00 VA: 0x181459800
	public static char ToChar(sbyte value) { }

	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static char ToChar(byte value) { }

	// RVA: 0x1459A30 Offset: 0x1458030 VA: 0x181459A30
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static char ToChar(ushort value) { }

	// RVA: 0x1459880 Offset: 0x1457E80 VA: 0x181459880
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459780 Offset: 0x1457D80 VA: 0x181459780
	public static char ToChar(uint value) { }

	// RVA: 0x1459900 Offset: 0x1457F00 VA: 0x181459900
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459B70 Offset: 0x1458170 VA: 0x181459B70
	public static char ToChar(ulong value) { }

	// RVA: 0x1459AB0 Offset: 0x14580B0 VA: 0x181459AB0
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BD60 Offset: 0x145A360 VA: 0x18145BD60
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458EE0 Offset: 0x14574E0 VA: 0x181458EE0
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BC50 Offset: 0x145A250 VA: 0x18145BC50
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C0F0 Offset: 0x145A6F0 VA: 0x18145C0F0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C200 Offset: 0x145A800 VA: 0x18145C200
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BF70 Offset: 0x145A570 VA: 0x18145BF70
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C070 Offset: 0x145A670 VA: 0x18145C070
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BEF0 Offset: 0x145A4F0 VA: 0x18145BEF0
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BCD0 Offset: 0x145A2D0 VA: 0x18145BCD0
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BFF0 Offset: 0x145A5F0 VA: 0x18145BFF0
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C290 Offset: 0x145A890 VA: 0x18145C290
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BE10 Offset: 0x145A410 VA: 0x18145BE10
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C170 Offset: 0x145A770 VA: 0x18145C170
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C1F0 Offset: 0x145A7F0 VA: 0x18145C1F0
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x14591E0 Offset: 0x14577E0 VA: 0x1814591E0
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x1458EE0 Offset: 0x14574E0 VA: 0x181458EE0
	public static byte ToByte(bool value) { }

	// RVA: 0x1459690 Offset: 0x1457C90 VA: 0x181459690
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459290 Offset: 0x1457890 VA: 0x181459290
	public static byte ToByte(sbyte value) { }

	// RVA: 0x1458F00 Offset: 0x1457500 VA: 0x181458F00
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1458F80 Offset: 0x1457580 VA: 0x181458F80
	public static byte ToByte(ushort value) { }

	// RVA: 0x14595F0 Offset: 0x1457BF0 VA: 0x1814595F0
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459000 Offset: 0x1457600 VA: 0x181459000
	public static byte ToByte(uint value) { }

	// RVA: 0x1459080 Offset: 0x1457680 VA: 0x181459080
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459460 Offset: 0x1457A60 VA: 0x181459460
	public static byte ToByte(ulong value) { }

	// RVA: 0x14594E0 Offset: 0x1457AE0 VA: 0x1814594E0
	public static byte ToByte(float value) { }

	// RVA: 0x1459310 Offset: 0x1457910 VA: 0x181459310
	public static byte ToByte(double value) { }

	// RVA: 0x14593E0 Offset: 0x14579E0 VA: 0x1814593E0
	public static byte ToByte(Decimal value) { }

	// RVA: 0x1459710 Offset: 0x1457D10 VA: 0x181459710
	public static byte ToByte(string value) { }

	// RVA: 0x1459670 Offset: 0x1457C70 VA: 0x181459670
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x145ACA0 Offset: 0x14592A0 VA: 0x18145ACA0
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x145AFC0 Offset: 0x14595C0 VA: 0x18145AFC0
	public static short ToInt16(bool value) { }

	// RVA: 0x145AD50 Offset: 0x1459350 VA: 0x18145AD50
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AAF0 Offset: 0x14590F0 VA: 0x18145AAF0
	public static short ToInt16(sbyte value) { }

	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AB00 Offset: 0x1459100 VA: 0x18145AB00
	public static short ToInt16(ushort value) { }

	// RVA: 0x145A8E0 Offset: 0x1458EE0 VA: 0x18145A8E0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AFD0 Offset: 0x14595D0 VA: 0x18145AFD0
	public static short ToInt16(uint value) { }

	// RVA: 0x145AA40 Offset: 0x1459040 VA: 0x18145AA40
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AE50 Offset: 0x1459450 VA: 0x18145AE50
	public static short ToInt16(ulong value) { }

	// RVA: 0x145AB80 Offset: 0x1459180 VA: 0x18145AB80
	public static short ToInt16(float value) { }

	// RVA: 0x145A960 Offset: 0x1458F60 VA: 0x18145A960
	public static short ToInt16(double value) { }

	// RVA: 0x145ADD0 Offset: 0x14593D0 VA: 0x18145ADD0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x145AAD0 Offset: 0x14590D0 VA: 0x18145AAD0
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CD60 Offset: 0x145B360 VA: 0x18145CD60
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145AFC0 Offset: 0x14595C0 VA: 0x18145AFC0
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CB40 Offset: 0x145B140 VA: 0x18145CB40
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CBC0 Offset: 0x145B1C0 VA: 0x18145CBC0
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CC40 Offset: 0x145B240 VA: 0x18145CC40
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CAC0 Offset: 0x145B0C0 VA: 0x18145CAC0
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CCC0 Offset: 0x145B2C0 VA: 0x18145CCC0
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CEE0 Offset: 0x145B4E0 VA: 0x18145CEE0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C9B0 Offset: 0x145AFB0 VA: 0x18145C9B0
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CE10 Offset: 0x145B410 VA: 0x18145CE10
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C930 Offset: 0x145AF30 VA: 0x18145C930
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CD40 Offset: 0x145B340 VA: 0x18145CD40
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x145B5B0 Offset: 0x1459BB0 VA: 0x18145B5B0
	public static int ToInt32(object value) { }

	// RVA: 0x145B2E0 Offset: 0x14598E0 VA: 0x18145B2E0
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x145B160 Offset: 0x1459760 VA: 0x18145B160
	public static int ToInt32(bool value) { }

	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static int ToInt32(char value) { }

	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static int ToInt32(byte value) { }

	// RVA: 0x145B580 Offset: 0x1459B80 VA: 0x18145B580
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B4A0 Offset: 0x1459AA0 VA: 0x18145B4A0
	public static int ToInt32(uint value) { }

	// RVA: 0x145B250 Offset: 0x1459850 VA: 0x18145B250
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B1D0 Offset: 0x14597D0 VA: 0x18145B1D0
	public static int ToInt32(ulong value) { }

	// RVA: 0x145B520 Offset: 0x1459B20 VA: 0x18145B520
	public static int ToInt32(float value) { }

	// RVA: 0x145B050 Offset: 0x1459650 VA: 0x18145B050
	public static int ToInt32(double value) { }

	// RVA: 0x145B170 Offset: 0x1459770 VA: 0x18145B170
	public static int ToInt32(Decimal value) { }

	// RVA: 0x145B430 Offset: 0x1459A30 VA: 0x18145B430
	public static int ToInt32(string value) { }

	// RVA: 0x145B590 Offset: 0x1459B90 VA: 0x18145B590
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D160 Offset: 0x145B760 VA: 0x18145D160
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D380 Offset: 0x145B980 VA: 0x18145D380
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B160 Offset: 0x1459760 VA: 0x18145B160
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D200 Offset: 0x145B800 VA: 0x18145D200
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D500 Offset: 0x145BB00 VA: 0x18145D500
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D300 Offset: 0x145B900 VA: 0x18145D300
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D5A0 Offset: 0x145BBA0 VA: 0x18145D5A0
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D280 Offset: 0x145B880 VA: 0x18145D280
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D620 Offset: 0x145BC20 VA: 0x18145D620
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D430 Offset: 0x145BA30 VA: 0x18145D430
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D040 Offset: 0x145B640 VA: 0x18145D040
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D580 Offset: 0x145BB80 VA: 0x18145D580
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x145B710 Offset: 0x1459D10 VA: 0x18145B710
	public static long ToInt64(object value) { }

	// RVA: 0x145BA90 Offset: 0x145A090 VA: 0x18145BA90
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x145BB40 Offset: 0x145A140 VA: 0x18145BB40
	public static long ToInt64(bool value) { }

	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BB50 Offset: 0x145A150 VA: 0x18145BB50
	public static long ToInt64(sbyte value) { }

	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static long ToInt64(byte value) { }

	// RVA: 0x145B650 Offset: 0x1459C50 VA: 0x18145B650
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static long ToInt64(ushort value) { }

	// RVA: 0x145B7B0 Offset: 0x1459DB0 VA: 0x18145B7B0
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B660 Offset: 0x1459C60 VA: 0x18145B660
	public static long ToInt64(ulong value) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static long ToInt64(long value) { }

	// RVA: 0x145B8C0 Offset: 0x1459EC0 VA: 0x18145B8C0
	public static long ToInt64(float value) { }

	// RVA: 0x145B7C0 Offset: 0x1459DC0 VA: 0x18145B7C0
	public static long ToInt64(double value) { }

	// RVA: 0x145B840 Offset: 0x1459E40 VA: 0x18145B840
	public static long ToInt64(Decimal value) { }

	// RVA: 0x145BA20 Offset: 0x145A020 VA: 0x18145BA20
	public static long ToInt64(string value) { }

	// RVA: 0x145B6F0 Offset: 0x1459CF0 VA: 0x18145B6F0
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145DA90 Offset: 0x145C090 VA: 0x18145DA90
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145B160 Offset: 0x1459760 VA: 0x18145B160
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D730 Offset: 0x145BD30 VA: 0x18145D730
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x125C870 Offset: 0x125AE70 VA: 0x18125C870
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D970 Offset: 0x145BF70 VA: 0x18145D970
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1370A00 Offset: 0x136F000 VA: 0x181370A00
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D7B0 Offset: 0x145BDB0 VA: 0x18145D7B0
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145DC20 Offset: 0x145C220 VA: 0x18145DC20
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145DB40 Offset: 0x145C140 VA: 0x18145DB40
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D9F0 Offset: 0x145BFF0 VA: 0x18145D9F0
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D830 Offset: 0x145BE30 VA: 0x18145D830
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D8B0 Offset: 0x145BEB0 VA: 0x18145D8B0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x145C4B0 Offset: 0x145AAB0 VA: 0x18145C4B0
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C410 Offset: 0x145AA10 VA: 0x18145C410
	public static float ToSingle(sbyte value) { }

	// RVA: 0x145C3B0 Offset: 0x145A9B0 VA: 0x18145C3B0
	public static float ToSingle(byte value) { }

	// RVA: 0x145C3D0 Offset: 0x145A9D0 VA: 0x18145C3D0
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C590 Offset: 0x145AB90 VA: 0x18145C590
	public static float ToSingle(ushort value) { }

	// RVA: 0x145C3E0 Offset: 0x145A9E0 VA: 0x18145C3E0
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C420 Offset: 0x145AA20 VA: 0x18145C420
	public static float ToSingle(uint value) { }

	// RVA: 0x145C3C0 Offset: 0x145A9C0 VA: 0x18145C3C0
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145C560 Offset: 0x145AB60 VA: 0x18145C560
	public static float ToSingle(ulong value) { }

	// RVA: 0x145C4A0 Offset: 0x145AAA0 VA: 0x18145C4A0
	public static float ToSingle(double value) { }

	// RVA: 0x145C440 Offset: 0x145AA40 VA: 0x18145C440
	public static float ToSingle(Decimal value) { }

	// RVA: 0x145C3F0 Offset: 0x145A9F0 VA: 0x18145C3F0
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x145C430 Offset: 0x145AA30 VA: 0x18145C430
	public static float ToSingle(bool value) { }

	// RVA: 0x145A7B0 Offset: 0x1458DB0 VA: 0x18145A7B0
	public static double ToDouble(object value) { }

	// RVA: 0x145A5F0 Offset: 0x1458BF0 VA: 0x18145A5F0
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A6D0 Offset: 0x1458CD0 VA: 0x18145A6D0
	public static double ToDouble(sbyte value) { }

	// RVA: 0x145A8D0 Offset: 0x1458ED0 VA: 0x18145A8D0
	public static double ToDouble(byte value) { }

	// RVA: 0x145A790 Offset: 0x1458D90 VA: 0x18145A790
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A6E0 Offset: 0x1458CE0 VA: 0x18145A6E0
	public static double ToDouble(ushort value) { }

	// RVA: 0x145A850 Offset: 0x1458E50 VA: 0x18145A850
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A7A0 Offset: 0x1458DA0 VA: 0x18145A7A0
	public static double ToDouble(uint value) { }

	// RVA: 0x145A6F0 Offset: 0x1458CF0 VA: 0x18145A6F0
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A6A0 Offset: 0x1458CA0 VA: 0x18145A6A0
	public static double ToDouble(ulong value) { }

	// RVA: 0x145A700 Offset: 0x1458D00 VA: 0x18145A700
	public static double ToDouble(float value) { }

	// RVA: 0x145A860 Offset: 0x1458E60 VA: 0x18145A860
	public static double ToDouble(Decimal value) { }

	// RVA: 0x145A710 Offset: 0x1458D10 VA: 0x18145A710
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x145A8C0 Offset: 0x1458EC0 VA: 0x18145A8C0
	public static double ToDouble(bool value) { }

	// RVA: 0x1459EB0 Offset: 0x14584B0 VA: 0x181459EB0
	public static Decimal ToDecimal(object value) { }

	// RVA: 0x145A240 Offset: 0x1458840 VA: 0x18145A240
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A020 Offset: 0x1458620 VA: 0x18145A020
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x1459DD0 Offset: 0x14583D0 VA: 0x181459DD0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x145A3C0 Offset: 0x14589C0 VA: 0x18145A3C0
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A580 Offset: 0x1458B80 VA: 0x18145A580
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x145A090 Offset: 0x1458690 VA: 0x18145A090
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1459E40 Offset: 0x1458440 VA: 0x181459E40
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x145A430 Offset: 0x1458A30 VA: 0x18145A430
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145A1D0 Offset: 0x14587D0 VA: 0x18145A1D0
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x1459D60 Offset: 0x1458360 VA: 0x181459D60
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x145A510 Offset: 0x1458B10 VA: 0x18145A510
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x145A100 Offset: 0x1458700 VA: 0x18145A100
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x145A4A0 Offset: 0x1458AA0 VA: 0x18145A4A0
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x1459BF0 Offset: 0x14581F0 VA: 0x181459BF0
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x1459CD0 Offset: 0x14582D0 VA: 0x181459CD0
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x145C730 Offset: 0x145AD30 VA: 0x18145C730
	public static string ToString(object value) { }

	// RVA: 0x145C5C0 Offset: 0x145ABC0 VA: 0x18145C5C0
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x145C710 Offset: 0x145AD10 VA: 0x18145C710
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x145C5A0 Offset: 0x145ABA0 VA: 0x18145C5A0
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x1459100 Offset: 0x1457700 VA: 0x181459100
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145BB60 Offset: 0x145A160 VA: 0x18145BB60
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x145AED0 Offset: 0x14594D0 VA: 0x18145AED0
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145CF60 Offset: 0x145B560 VA: 0x18145CF60
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x145B390 Offset: 0x1459990 VA: 0x18145B390
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D0C0 Offset: 0x145B6C0 VA: 0x18145D0C0
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x145B980 Offset: 0x1459F80 VA: 0x18145B980
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x145D8D0 Offset: 0x145BED0 VA: 0x18145D8D0
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x145C890 Offset: 0x145AE90 VA: 0x18145C890
	public static string ToString(int value, int toBase) { }

	// RVA: 0x1458B80 Offset: 0x1457180 VA: 0x181458B80
	public static string ToBase64String(byte[] inArray) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1458AD0 Offset: 0x14570D0 VA: 0x181458AD0
	public static string ToBase64String(byte[] inArray, Base64FormattingOptions options) { }

	// RVA: 0x1458A50 Offset: 0x1457050 VA: 0x181458A50
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1458760 Offset: 0x1456D60 VA: 0x181458760
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x1458300 Offset: 0x1456900 VA: 0x181458300
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1458390 Offset: 0x1456990 VA: 0x181458390
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x1456730 Offset: 0x1454D30 VA: 0x181456730
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x1458C20 Offset: 0x1457220 VA: 0x181458C20
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x1457D60 Offset: 0x1456360 VA: 0x181457D60
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x14579F0 Offset: 0x1455FF0 VA: 0x1814579F0
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x1457B90 Offset: 0x1456190 VA: 0x181457B90
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x1457EF0 Offset: 0x14564F0 VA: 0x181457EF0
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x1457E10 Offset: 0x1456410 VA: 0x181457E10
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x145DCA0 Offset: 0x145C2A0 VA: 0x18145DCA0
	private static void .cctor() { }

}

