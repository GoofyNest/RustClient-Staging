internal static class Statics // TypeDefIndex: 1577
{	// Fields
	public static readonly TraceLoggingDataType IntPtrType; // 0x0
	public static readonly TraceLoggingDataType UIntPtrType; // 0x4
	public static readonly TraceLoggingDataType HexIntPtrType; // 0x8

	// Methods

	// RVA: 0x10E6A30 Offset: 0x10E5030 VA: 0x1810E6A30
	public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize) { }

	// RVA: 0x10E5E10 Offset: 0x10E4410 VA: 0x1810E5E10
	public static void EncodeTags(int tags, ref int pos, byte[] metadata) { }

	// RVA: 0x10E5DE0 Offset: 0x10E43E0 VA: 0x1810E5DE0
	public static byte Combine(int settingValue, byte defaultValue) { }

	// RVA: 0x10E5DD0 Offset: 0x10E43D0 VA: 0x1810E5DD0
	public static int Combine(int settingValue1, int settingValue2) { }

	// RVA: 0x10E5D50 Offset: 0x10E4350 VA: 0x1810E5D50
	public static void CheckName(string name) { }

	// RVA: 0x10E6C40 Offset: 0x10E5240 VA: 0x1810E6C40
	public static bool ShouldOverrideFieldName(string fieldName) { }

	// RVA: 0x10E6A20 Offset: 0x10E5020 VA: 0x1810E6A20
	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format) { }

	// RVA: 0x10E6360 Offset: 0x10E4960 VA: 0x1810E6360
	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E6190 Offset: 0x10E4790 VA: 0x1810E6190
	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E6230 Offset: 0x10E4830 VA: 0x1810E6230
	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E62E0 Offset: 0x10E48E0 VA: 0x1810E62E0
	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E6410 Offset: 0x10E4A10 VA: 0x1810E6410
	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E5E00 Offset: 0x10E4400 VA: 0x1810E5E00
	public static object CreateInstance(Type type, object[] parameters) { }

	// RVA: 0x10E6A00 Offset: 0x10E5000 VA: 0x1810E6A00
	public static bool IsValueType(Type type) { }

	// RVA: 0x10E68C0 Offset: 0x10E4EC0 VA: 0x1810E68C0
	public static bool IsEnum(Type type) { }

	// RVA: 0x10E6530 Offset: 0x10E4B30 VA: 0x1810E6530
	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	// RVA: 0x10E6510 Offset: 0x10E4B10 VA: 0x1810E6510
	public static MethodInfo GetGetMethod(PropertyInfo propInfo) { }

	// RVA: 0x10E64C0 Offset: 0x10E4AC0 VA: 0x1810E64C0
	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name) { }

	// RVA: 0x10E6880 Offset: 0x10E4E80 VA: 0x1810E6880
	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType) { }

	// RVA: -1 Offset: -1
	public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F310 Offset: 0x125D910 VA: 0x18125F310
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F200 Offset: 0x125D800 VA: 0x18125F200
	|-Statics.GetCustomAttribute<EventDataAttribute>
	|-Statics.GetCustomAttribute<object>
	|-Statics.GetCustomAttribute<CompilerGeneratedAttribute>
	*/

	// RVA: 0x10E64E0 Offset: 0x10E4AE0 VA: 0x1810E64E0
	public static Type[] GetGenericArguments(Type type) { }

	// RVA: 0x10E5E80 Offset: 0x10E4480 VA: 0x1810E5E80
	public static Type FindEnumerableElementType(Type type) { }

	// RVA: 0x10E68F0 Offset: 0x10E4EF0 VA: 0x1810E68F0
	public static bool IsGenericMatch(Type type, object openType) { }

	// RVA: 0x10E5DF0 Offset: 0x10E43F0 VA: 0x1810E5DF0
	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo) { }

	// RVA: 0x10E6550 Offset: 0x10E4B50 VA: 0x1810E6550
	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck) { }

	// RVA: -1 Offset: -1
	public static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF9C0 Offset: 0x12ADFC0 VA: 0x1812AF9C0
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12B18F0 Offset: 0x12AFEF0 VA: 0x1812B18F0
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12B3820 Offset: 0x12B1E20 VA: 0x1812B3820
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12C1270 Offset: 0x12BF870 VA: 0x1812C1270
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B7680 Offset: 0x12B5C80 VA: 0x1812B7680
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12B5750 Offset: 0x12B3D50 VA: 0x1812B5750
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B95B0 Offset: 0x12B7BB0 VA: 0x1812B95B0
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12BD410 Offset: 0x12BBA10 VA: 0x1812BD410
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12BB4E0 Offset: 0x12B9AE0 VA: 0x1812BB4E0
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12BF340 Offset: 0x12BD940 VA: 0x1812BF340
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B1A840 Offset: 0x1B18E40 VA: 0x181B1A840
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B1C770 Offset: 0x1B1AD70 VA: 0x181B1C770
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B1E6A0 Offset: 0x1B1CCA0 VA: 0x181B1E6A0
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B205D0 Offset: 0x1B1EBD0 VA: 0x181B205D0
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B22500 Offset: 0x1B20B00 VA: 0x181B22500
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B24430 Offset: 0x1B22A30 VA: 0x181B24430
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B26360 Offset: 0x1B24960 VA: 0x181B26360
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B28290 Offset: 0x1B26890 VA: 0x181B28290
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B2A1C0 Offset: 0x1B287C0 VA: 0x181B2A1C0
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B2C0F0 Offset: 0x1B2A6F0 VA: 0x181B2C0F0
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B2E020 Offset: 0x1B2C620 VA: 0x181B2E020
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B2FF50 Offset: 0x1B2E550 VA: 0x181B2FF50
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	// RVA: 0x10E6C80 Offset: 0x10E5280 VA: 0x1810E6C80
	private static void .cctor() { }

}

