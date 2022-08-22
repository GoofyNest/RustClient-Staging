internal static class Statics // TypeDefIndex: 1577
{	public static readonly TraceLoggingDataType IntPtrType; // 0x0
	public static readonly TraceLoggingDataType UIntPtrType; // 0x4
	public static readonly TraceLoggingDataType HexIntPtrType; // 0x8


	public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize) { }

	public static void EncodeTags(int tags, ref int pos, byte[] metadata) { }

	public static byte Combine(int settingValue, byte defaultValue) { }

	public static int Combine(int settingValue1, int settingValue2) { }

	public static void CheckName(string name) { }

	public static bool ShouldOverrideFieldName(string fieldName) { }

	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format) { }

	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native) { }

	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native) { }

	public static object CreateInstance(Type type, object[] parameters) { }

	public static bool IsValueType(Type type) { }

	public static bool IsEnum(Type type) { }

	public static IEnumerable<PropertyInfo> GetProperties(Type type) { }

	public static MethodInfo GetGetMethod(PropertyInfo propInfo) { }

	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name) { }

	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType) { }

	public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F9B0 Offset: 0x125DFB0 VA: 0x18125F9B0
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F8A0 Offset: 0x125DEA0 VA: 0x18125F8A0
	|-Statics.GetCustomAttribute<EventDataAttribute>
	|-Statics.GetCustomAttribute<object>
	|-Statics.GetCustomAttribute<CompilerGeneratedAttribute>
	*/

	public static Type[] GetGenericArguments(Type type) { }

	public static Type FindEnumerableElementType(Type type) { }

	public static bool IsGenericMatch(Type type, object openType) { }

	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo) { }

	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck) { }

	public static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12B0060 Offset: 0x12AE660 VA: 0x1812B0060
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12B1F90 Offset: 0x12B0590 VA: 0x1812B1F90
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12B3EC0 Offset: 0x12B24C0 VA: 0x1812B3EC0
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12C1910 Offset: 0x12BFF10 VA: 0x1812C1910
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B7D20 Offset: 0x12B6320 VA: 0x1812B7D20
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12B5DF0 Offset: 0x12B43F0 VA: 0x1812B5DF0
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B9C50 Offset: 0x12B8250 VA: 0x1812B9C50
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12BDAB0 Offset: 0x12BC0B0 VA: 0x1812BDAB0
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12BBB80 Offset: 0x12BA180 VA: 0x1812BBB80
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12BF9E0 Offset: 0x12BDFE0 VA: 0x1812BF9E0
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B1B030 Offset: 0x1B19630 VA: 0x181B1B030
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B1CF60 Offset: 0x1B1B560 VA: 0x181B1CF60
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B1EE90 Offset: 0x1B1D490 VA: 0x181B1EE90
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B20DC0 Offset: 0x1B1F3C0 VA: 0x181B20DC0
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B22CF0 Offset: 0x1B212F0 VA: 0x181B22CF0
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B24C20 Offset: 0x1B23220 VA: 0x181B24C20
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B26B50 Offset: 0x1B25150 VA: 0x181B26B50
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B28A80 Offset: 0x1B27080 VA: 0x181B28A80
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B2A9B0 Offset: 0x1B28FB0 VA: 0x181B2A9B0
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B2C8E0 Offset: 0x1B2AEE0 VA: 0x181B2C8E0
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B2E810 Offset: 0x1B2CE10 VA: 0x181B2E810
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B30740 Offset: 0x1B2ED40 VA: 0x181B30740
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	private static void .cctor() { }

}

