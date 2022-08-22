internal static class Statics // TypeDefIndex: 1577
{	// Fields
	public static readonly TraceLoggingDataType IntPtrType; // 0x0
	public static readonly TraceLoggingDataType UIntPtrType; // 0x4
	public static readonly TraceLoggingDataType HexIntPtrType; // 0x8

	// Methods

	// RVA: 0x10E6770 Offset: 0x10E4D70 VA: 0x1810E6770
	public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize) { }

	// RVA: 0x10E5B50 Offset: 0x10E4150 VA: 0x1810E5B50
	public static void EncodeTags(int tags, ref int pos, byte[] metadata) { }

	// RVA: 0x10E5B20 Offset: 0x10E4120 VA: 0x1810E5B20
	public static byte Combine(int settingValue, byte defaultValue) { }

	// RVA: 0x10E5B10 Offset: 0x10E4110 VA: 0x1810E5B10
	public static int Combine(int settingValue1, int settingValue2) { }

	// RVA: 0x10E5A90 Offset: 0x10E4090 VA: 0x1810E5A90
	public static void CheckName(string name) { }

	// RVA: 0x10E6980 Offset: 0x10E4F80 VA: 0x1810E6980
	public static bool ShouldOverrideFieldName(string fieldName) { }

	// RVA: 0x10E6760 Offset: 0x10E4D60 VA: 0x1810E6760
	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format) { }

	// RVA: 0x10E60A0 Offset: 0x10E46A0 VA: 0x1810E60A0
	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E5ED0 Offset: 0x10E44D0 VA: 0x1810E5ED0
	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E5F70 Offset: 0x10E4570 VA: 0x1810E5F70
	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E6020 Offset: 0x10E4620 VA: 0x1810E6020
	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E6150 Offset: 0x10E4750 VA: 0x1810E6150
	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native) { }

	// RVA: 0x10E5B40 Offset: 0x10E4140 VA: 0x1810E5B40
	public static object CreateInstance(Type type, object[] parameters) { }

	// RVA: 0x10E6740 Offset: 0x10E4D40 VA: 0x1810E6740
	public static bool IsValueType(Type type) { }

	// RVA: 0x10E6600 Offset: 0x10E4C00 VA: 0x1810E6600
	public static bool IsEnum(Type type) { }

	// RVA: 0x10E6270 Offset: 0x10E4870 VA: 0x1810E6270
	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	// RVA: 0x10E6250 Offset: 0x10E4850 VA: 0x1810E6250
	public static MethodInfo GetGetMethod(PropertyInfo propInfo) { }

	// RVA: 0x10E6200 Offset: 0x10E4800 VA: 0x1810E6200
	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name) { }

	// RVA: 0x10E65C0 Offset: 0x10E4BC0 VA: 0x1810E65C0
	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType) { }

	// RVA: -1 Offset: -1
	public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F050 Offset: 0x125D650 VA: 0x18125F050
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125EF40 Offset: 0x125D540 VA: 0x18125EF40
	|-Statics.GetCustomAttribute<EventDataAttribute>
	|-Statics.GetCustomAttribute<object>
	|-Statics.GetCustomAttribute<CompilerGeneratedAttribute>
	*/

	// RVA: 0x10E6220 Offset: 0x10E4820 VA: 0x1810E6220
	public static Type[] GetGenericArguments(Type type) { }

	// RVA: 0x10E5BC0 Offset: 0x10E41C0 VA: 0x1810E5BC0
	public static Type FindEnumerableElementType(Type type) { }

	// RVA: 0x10E6630 Offset: 0x10E4C30 VA: 0x1810E6630
	public static bool IsGenericMatch(Type type, object openType) { }

	// RVA: 0x10E5B30 Offset: 0x10E4130 VA: 0x1810E5B30
	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo) { }

	// RVA: 0x10E6290 Offset: 0x10E4890 VA: 0x1810E6290
	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck) { }

	// RVA: -1 Offset: -1
	public static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AF700 Offset: 0x12ADD00 VA: 0x1812AF700
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12B1630 Offset: 0x12AFC30 VA: 0x1812B1630
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12B3560 Offset: 0x12B1B60 VA: 0x1812B3560
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12C0FB0 Offset: 0x12BF5B0 VA: 0x1812C0FB0
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B73C0 Offset: 0x12B59C0 VA: 0x1812B73C0
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12B5490 Offset: 0x12B3A90 VA: 0x1812B5490
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B92F0 Offset: 0x12B78F0 VA: 0x1812B92F0
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12BD150 Offset: 0x12BB750 VA: 0x1812BD150
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12BB220 Offset: 0x12B9820 VA: 0x1812BB220
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12BF080 Offset: 0x12BD680 VA: 0x1812BF080
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B1A580 Offset: 0x1B18B80 VA: 0x181B1A580
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B1C4B0 Offset: 0x1B1AAB0 VA: 0x181B1C4B0
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B1E3E0 Offset: 0x1B1C9E0 VA: 0x181B1E3E0
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B20310 Offset: 0x1B1E910 VA: 0x181B20310
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B22240 Offset: 0x1B20840 VA: 0x181B22240
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B24170 Offset: 0x1B22770 VA: 0x181B24170
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B260A0 Offset: 0x1B246A0 VA: 0x181B260A0
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B27FD0 Offset: 0x1B265D0 VA: 0x181B27FD0
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B29F00 Offset: 0x1B28500 VA: 0x181B29F00
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B2BE30 Offset: 0x1B2A430 VA: 0x181B2BE30
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B2DD60 Offset: 0x1B2C360 VA: 0x181B2DD60
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B2FC90 Offset: 0x1B2E290 VA: 0x181B2FC90
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	// RVA: 0x10E69C0 Offset: 0x10E4FC0 VA: 0x1810E69C0
	private static void .cctor() { }

}

