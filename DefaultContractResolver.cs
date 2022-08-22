public class DefaultContractResolver : IContractResolver // TypeDefIndex: 5991
{	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly JsonConverter[] BuiltInConverters; // 0x8
	private static readonly object TypeContractCacheLock; // 0x10
	private static readonly DefaultContractResolverState _sharedState; // 0x18
	private readonly DefaultContractResolverState _instanceState; // 0x10
	private readonly bool _sharedCache; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x22

	// Properties
	internal static IContractResolver Instance { get; }
	[ObsoleteAttribute] // RVA: 0x7F6E0 Offset: 0x7EAE0 VA: 0x18007F6E0
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }

	// Methods

	// RVA: 0xE30280 Offset: 0xE2E880 VA: 0x180E30280
	internal static IContractResolver get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106C0 Offset: 0xB0ECC0 VA: 0x180B106C0
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB106D0 Offset: 0xB0ECD0 VA: 0x180B106D0
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE302E0 Offset: 0xE2E8E0 VA: 0x180E302E0
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xE30210 Offset: 0xE2E810 VA: 0x180E30210
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7F530 Offset: 0x7E930 VA: 0x18007F530
	// RVA: 0xE30180 Offset: 0xE2E780 VA: 0x180E30180
	public void .ctor(bool shareCache) { }

	// RVA: 0xE2DB40 Offset: 0xE2C140 VA: 0x180E2DB40
	internal DefaultContractResolverState GetState() { }

	// RVA: 0xE2EB00 Offset: 0xE2D100 VA: 0x180E2EB00 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xE2D460 Offset: 0xE2BA60 VA: 0x180E2D460 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xE2FDA0 Offset: 0xE2E3A0 VA: 0x180E2FDA0
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xE2B390 Offset: 0xE29990 VA: 0x180E2B390 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xE2D1D0 Offset: 0xE2B7D0 VA: 0x180E2D1D0
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xE2ED50 Offset: 0xE2D350 VA: 0x180E2ED50
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xE2C370 Offset: 0xE2A970 VA: 0x180E2C370
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xE2D3A0 Offset: 0xE2B9A0 VA: 0x180E2D3A0
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xE2A4C0 Offset: 0xE28AC0 VA: 0x180E2A4C0 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xE2BC10 Offset: 0xE2A210 VA: 0x180E2BC10 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xE2EAA0 Offset: 0xE2D0A0 VA: 0x180E2EAA0 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xE2D130 Offset: 0xE2B730 VA: 0x180E2D130
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xE2DBB0 Offset: 0xE2C1B0 VA: 0x180E2DBB0
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xE2E910 Offset: 0xE2CF10 VA: 0x180E2E910
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xE2C770 Offset: 0xE2AD70 VA: 0x180E2C770
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xE2CE80 Offset: 0xE2B480 VA: 0x180E2CE80
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xE2AC20 Offset: 0xE29220 VA: 0x180E2AC20 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xE2A1B0 Offset: 0xE287B0 VA: 0x180E2A1B0 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xE2B820 Offset: 0xE29E20 VA: 0x180E2B820 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xE2B2C0 Offset: 0xE298C0 VA: 0x180E2B2C0 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xE2B0A0 Offset: 0xE296A0 VA: 0x180E2B0A0 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xE2C300 Offset: 0xE2A900 VA: 0x180E2C300 Slot: 16
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xE2A690 Offset: 0xE28C90 VA: 0x180E2A690 Slot: 17
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xE2E120 Offset: 0xE2C720 VA: 0x180E2E120
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xE2DFA0 Offset: 0xE2C5A0 VA: 0x180E2DFA0
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xE29F90 Offset: 0xE28590 VA: 0x180E29F90
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xE2E190 Offset: 0xE2C790 VA: 0x180E2E190
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0xE2CF60 Offset: 0xE2B560 VA: 0x180E2CF60
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xE2B890 Offset: 0xE29E90 VA: 0x180E2B890 Slot: 18
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xE2B330 Offset: 0xE29930 VA: 0x180E2B330 Slot: 19
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xE2BEE0 Offset: 0xE2A4E0 VA: 0x180E2BEE0 Slot: 20
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xE2F890 Offset: 0xE2DE90 VA: 0x180E2F890
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0xE2C100 Offset: 0xE2A700 VA: 0x180E2C100
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xE2F5D0 Offset: 0xE2DBD0 VA: 0x180E2F5D0
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90 Slot: 21
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xE2D440 Offset: 0xE2BA40 VA: 0x180E2D440 Slot: 22
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xE2D440 Offset: 0xE2BA40 VA: 0x180E2D440
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xE2FEB0 Offset: 0xE2E4B0 VA: 0x180E2FEB0
	private static void .cctor() { }

}

private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue> // TypeDefIndex: 5993

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
[Serializable]
private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
	// Fields
	public static readonly DefaultContractResolver.<>c <>9; // 0x0
	public static Func<MemberInfo, bool> <>9__30_0; // 0x8
	public static Func<MemberInfo, bool> <>9__30_1; // 0x10
	public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0; // 0x18
	public static Func<MemberInfo, bool> <>9__33_1; // 0x20
	public static Func<ConstructorInfo, bool> <>9__36_0; // 0x28
	public static Func<JsonProperty, int> <>9__60_0; // 0x30

	// Methods

	// RVA: 0x14094D0 Offset: 0x1407AD0 VA: 0x1814094D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408C80 Offset: 0x1407280 VA: 0x181408C80
	internal bool <GetSerializableMembers>b__30_0(MemberInfo m) { }

	// RVA: 0x1408CE0 Offset: 0x14072E0 VA: 0x181408CE0
	internal bool <GetSerializableMembers>b__30_1(MemberInfo m) { }

	// RVA: 0x1408770 Offset: 0x1406D70 VA: 0x181408770
	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType) { }

	// RVA: 0x1408830 Offset: 0x1406E30 VA: 0x181408830
	internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m) { }

	// RVA: 0x14086E0 Offset: 0x1406CE0 VA: 0x1814086E0
	internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c) { }

	// RVA: 0x1408690 Offset: 0x1406C90 VA: 0x181408690
	internal int <CreateProperties>b__60_0(JsonProperty p) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_0 // TypeDefIndex: 5995
{	// Fields
	public Func<object, object> getExtensionDataDictionary; // 0x10
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_1 // TypeDefIndex: 5996
{	// Fields
	public Action<object, object> setExtensionDataDictionary; // 0x10
	public Func<object> createExtensionDataDictionary; // 0x18
	public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408D40 Offset: 0x1407340 VA: 0x181408D40
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_2 // TypeDefIndex: 5997
{	// Fields
	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408FA0 Offset: 0x14075A0 VA: 0x181408FA0
	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass64_0 // TypeDefIndex: 5998
{	// Fields
	public MethodCall<object, object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14090F0 Offset: 0x14076F0 VA: 0x1814090F0
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass65_0 // TypeDefIndex: 5999
{	// Fields
	public Func<object, object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1409190 Offset: 0x1407790 VA: 0x181409190
	internal bool <SetIsSpecifiedActions>b__0(object o) { }

}

