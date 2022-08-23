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
	|-RVA: 0x125FAB0 Offset: 0x125E0B0 VA: 0x18125FAB0
	|-Statics.GetCustomAttribute<EventFieldAttribute>
	|-Statics.GetCustomAttribute<object>
	*/

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F9A0 Offset: 0x125DFA0 VA: 0x18125F9A0
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
	|-RVA: 0x12B0160 Offset: 0x12AE760 VA: 0x1812B0160
	|-Statics.CreateDefaultTypeInfo<bool>
	|
	|-RVA: 0x12B2090 Offset: 0x12B0690 VA: 0x1812B2090
	|-Statics.CreateDefaultTypeInfo<byte>
	|
	|-RVA: 0x12B3FC0 Offset: 0x12B25C0 VA: 0x1812B3FC0
	|-Statics.CreateDefaultTypeInfo<char>
	|
	|-RVA: 0x12C1A10 Offset: 0x12C0010 VA: 0x1812C1A10
	|-Statics.CreateDefaultTypeInfo<KeyValuePair<object, object>>
	|
	|-RVA: 0x12B7E20 Offset: 0x12B6420 VA: 0x1812B7E20
	|-Statics.CreateDefaultTypeInfo<DateTime>
	|
	|-RVA: 0x12B5EF0 Offset: 0x12B44F0 VA: 0x1812B5EF0
	|-Statics.CreateDefaultTypeInfo<DateTimeOffset>
	|
	|-RVA: 0x12B9D50 Offset: 0x12B8350 VA: 0x1812B9D50
	|-Statics.CreateDefaultTypeInfo<Decimal>
	|
	|-RVA: 0x12BDBB0 Offset: 0x12BC1B0 VA: 0x1812BDBB0
	|-Statics.CreateDefaultTypeInfo<EmptyStruct>
	|
	|-RVA: 0x12BBC80 Offset: 0x12BA280 VA: 0x1812BBC80
	|-Statics.CreateDefaultTypeInfo<double>
	|
	|-RVA: 0x12BFAE0 Offset: 0x12BE0E0 VA: 0x1812BFAE0
	|-Statics.CreateDefaultTypeInfo<Guid>
	|
	|-RVA: 0x1B1B130 Offset: 0x1B19730 VA: 0x181B1B130
	|-Statics.CreateDefaultTypeInfo<short>
	|
	|-RVA: 0x1B1D060 Offset: 0x1B1B660 VA: 0x181B1D060
	|-Statics.CreateDefaultTypeInfo<int>
	|
	|-RVA: 0x1B1EF90 Offset: 0x1B1D590 VA: 0x181B1EF90
	|-Statics.CreateDefaultTypeInfo<long>
	|
	|-RVA: 0x1B20EC0 Offset: 0x1B1F4C0 VA: 0x181B20EC0
	|-Statics.CreateDefaultTypeInfo<IntPtr>
	|
	|-RVA: 0x1B22DF0 Offset: 0x1B213F0 VA: 0x181B22DF0
	|-Statics.CreateDefaultTypeInfo<object>
	|
	|-RVA: 0x1B24D20 Offset: 0x1B23320 VA: 0x181B24D20
	|-Statics.CreateDefaultTypeInfo<sbyte>
	|
	|-RVA: 0x1B26C50 Offset: 0x1B25250 VA: 0x181B26C50
	|-Statics.CreateDefaultTypeInfo<float>
	|
	|-RVA: 0x1B28B80 Offset: 0x1B27180 VA: 0x181B28B80
	|-Statics.CreateDefaultTypeInfo<TimeSpan>
	|
	|-RVA: 0x1B2AAB0 Offset: 0x1B290B0 VA: 0x181B2AAB0
	|-Statics.CreateDefaultTypeInfo<ushort>
	|
	|-RVA: 0x1B2C9E0 Offset: 0x1B2AFE0 VA: 0x181B2C9E0
	|-Statics.CreateDefaultTypeInfo<uint>
	|
	|-RVA: 0x1B2E910 Offset: 0x1B2CF10 VA: 0x181B2E910
	|-Statics.CreateDefaultTypeInfo<ulong>
	|
	|-RVA: 0x1B30840 Offset: 0x1B2EE40 VA: 0x181B30840
	|-Statics.CreateDefaultTypeInfo<UIntPtr>
	*/

	private static void .cctor() { }

}

