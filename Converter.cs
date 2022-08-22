internal sealed class Converter // TypeDefIndex: 1090
{	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x11F18F0 Offset: 0x11EFEF0 VA: 0x1811F18F0
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x11F1780 Offset: 0x11EFD80 VA: 0x1811F1780
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x11F1F20 Offset: 0x11F0520 VA: 0x1811F1F20
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x11F17F0 Offset: 0x11EFDF0 VA: 0x1811F17F0
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x11F03D0 Offset: 0x11EE9D0 VA: 0x1811F03D0
	private static void InitTypeA() { }

	// RVA: 0x11EF9C0 Offset: 0x11EDFC0 VA: 0x1811EF9C0
	private static void InitArrayTypeA() { }

	// RVA: 0x11F1E20 Offset: 0x11F0420 VA: 0x1811F1E20
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x11EF6E0 Offset: 0x11EDCE0 VA: 0x1811EF6E0
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x11F1430 Offset: 0x11EFA30 VA: 0x1811F1430
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x11F0D80 Offset: 0x11EF380 VA: 0x1811F0D80
	private static void InitValueA() { }

	// RVA: 0x11F1B40 Offset: 0x11F0140 VA: 0x1811F1B40
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x11F0AE0 Offset: 0x11EF0E0 VA: 0x1811F0AE0
	private static void InitTypeCodeA() { }

	// RVA: 0x11F1D30 Offset: 0x11F0330 VA: 0x1811F1D30
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x11F00F0 Offset: 0x11EE6F0 VA: 0x1811F00F0
	private static void InitCodeA() { }

	// RVA: 0x11F1C40 Offset: 0x11F0240 VA: 0x1811F1C40
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x11EF810 Offset: 0x11EDE10 VA: 0x1811EF810
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x11F1FA0 Offset: 0x11F05A0 VA: 0x1811F1FA0
	private static void .cctor() { }

}

