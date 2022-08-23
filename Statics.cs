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
	|-RVA: 0x125FAF0 Offset: 0x125E0F0 VA: 0x18125FAF0
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F9E0 Offset: 0x125DFE0 VA: 0x18125F9E0
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
	|-RVA: 0x12B01A0 Offset: 0x12AE7A0 VA: 0x1812B01A0
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12B20D0 Offset: 0x12B06D0 VA: 0x1812B20D0
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12B4000 Offset: 0x12B2600 VA: 0x1812B4000
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12C1A50 Offset: 0x12C0050 VA: 0x1812C1A50
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B7E60 Offset: 0x12B6460 VA: 0x1812B7E60
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12B5F30 Offset: 0x12B4530 VA: 0x1812B5F30
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B9D90 Offset: 0x12B8390 VA: 0x1812B9D90
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12BDBF0 Offset: 0x12BC1F0 VA: 0x1812BDBF0
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12BBCC0 Offset: 0x12BA2C0 VA: 0x1812BBCC0
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12BFB20 Offset: 0x12BE120 VA: 0x1812BFB20
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B1B170 Offset: 0x1B19770 VA: 0x181B1B170
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B1D0A0 Offset: 0x1B1B6A0 VA: 0x181B1D0A0
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B1EFD0 Offset: 0x1B1D5D0 VA: 0x181B1EFD0
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B20F00 Offset: 0x1B1F500 VA: 0x181B20F00
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B22E30 Offset: 0x1B21430 VA: 0x181B22E30
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B24D60 Offset: 0x1B23360 VA: 0x181B24D60
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B26C90 Offset: 0x1B25290 VA: 0x181B26C90
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B28BC0 Offset: 0x1B271C0 VA: 0x181B28BC0
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B2AAF0 Offset: 0x1B290F0 VA: 0x181B2AAF0
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B2CA20 Offset: 0x1B2B020 VA: 0x181B2CA20
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B2E950 Offset: 0x1B2CF50 VA: 0x181B2E950
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B30880 Offset: 0x1B2EE80 VA: 0x181B30880
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	private static void .cctor() { }

}

