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
	|-RVA: 0x125F9F0 Offset: 0x125DFF0 VA: 0x18125F9F0
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F8E0 Offset: 0x125DEE0 VA: 0x18125F8E0
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
	|-RVA: 0x12B00A0 Offset: 0x12AE6A0 VA: 0x1812B00A0
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12B1FD0 Offset: 0x12B05D0 VA: 0x1812B1FD0
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12B3F00 Offset: 0x12B2500 VA: 0x1812B3F00
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12C1950 Offset: 0x12BFF50 VA: 0x1812C1950
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B7D60 Offset: 0x12B6360 VA: 0x1812B7D60
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12B5E30 Offset: 0x12B4430 VA: 0x1812B5E30
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B9C90 Offset: 0x12B8290 VA: 0x1812B9C90
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12BDAF0 Offset: 0x12BC0F0 VA: 0x1812BDAF0
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12BBBC0 Offset: 0x12BA1C0 VA: 0x1812BBBC0
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12BFA20 Offset: 0x12BE020 VA: 0x1812BFA20
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B1B070 Offset: 0x1B19670 VA: 0x181B1B070
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B1CFA0 Offset: 0x1B1B5A0 VA: 0x181B1CFA0
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B1EED0 Offset: 0x1B1D4D0 VA: 0x181B1EED0
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B20E00 Offset: 0x1B1F400 VA: 0x181B20E00
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B22D30 Offset: 0x1B21330 VA: 0x181B22D30
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B24C60 Offset: 0x1B23260 VA: 0x181B24C60
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B26B90 Offset: 0x1B25190 VA: 0x181B26B90
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B28AC0 Offset: 0x1B270C0 VA: 0x181B28AC0
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B2A9F0 Offset: 0x1B28FF0 VA: 0x181B2A9F0
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B2C920 Offset: 0x1B2AF20 VA: 0x181B2C920
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B2E850 Offset: 0x1B2CE50 VA: 0x181B2E850
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B30780 Offset: 0x1B2ED80 VA: 0x181B30780
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	private static void .cctor() { }

}

