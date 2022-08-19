public class DefaultContractResolver : IContractResolver // TypeDefIndex: 5991
{	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly JsonConverter[] BuiltInConverters; // 0x8
	private static readonly object TypeContractCacheLock; // 0x10
	private static readonly DefaultContractResolverState _sharedState; // 0x18
	private readonly DefaultContractResolverState _instanceState; // 0x10
	private readonly bool _sharedCache; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x21
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x22

	// Properties
	internal static IContractResolver Instance { get; }
	[ObsoleteAttribute] // RVA: 0x7F610 Offset: 0x7EA10 VA: 0x18007F610
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }

	// Methods

	// RVA: 0xE2FFC0 Offset: 0xE2E5C0 VA: 0x180E2FFC0
	internal static IContractResolver get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xB10410 Offset: 0xB0EA10 VA: 0x180B10410
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE30020 Offset: 0xE2E620 VA: 0x180E30020
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xE2FF50 Offset: 0xE2E550 VA: 0x180E2FF50
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7F460 Offset: 0x7E860 VA: 0x18007F460
	// RVA: 0xE2FEC0 Offset: 0xE2E4C0 VA: 0x180E2FEC0
	public void .ctor(bool shareCache) { }

	// RVA: 0xE2D880 Offset: 0xE2BE80 VA: 0x180E2D880
	internal DefaultContractResolverState GetState() { }

	// RVA: 0xE2E840 Offset: 0xE2CE40 VA: 0x180E2E840 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xE2D1A0 Offset: 0xE2B7A0 VA: 0x180E2D1A0 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xE2FAE0 Offset: 0xE2E0E0 VA: 0x180E2FAE0
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xE2B0D0 Offset: 0xE296D0 VA: 0x180E2B0D0 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xE2CF10 Offset: 0xE2B510 VA: 0x180E2CF10
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xE2EA90 Offset: 0xE2D090 VA: 0x180E2EA90
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xE2C0B0 Offset: 0xE2A6B0 VA: 0x180E2C0B0
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xE2D0E0 Offset: 0xE2B6E0 VA: 0x180E2D0E0
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xE2A200 Offset: 0xE28800 VA: 0x180E2A200 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xE2B950 Offset: 0xE29F50 VA: 0x180E2B950 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xE2E7E0 Offset: 0xE2CDE0 VA: 0x180E2E7E0 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xE2CE70 Offset: 0xE2B470 VA: 0x180E2CE70
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xE2D8F0 Offset: 0xE2BEF0 VA: 0x180E2D8F0
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xE2E650 Offset: 0xE2CC50 VA: 0x180E2E650
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xE2C4B0 Offset: 0xE2AAB0 VA: 0x180E2C4B0
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xE2CBC0 Offset: 0xE2B1C0 VA: 0x180E2CBC0
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xE2A960 Offset: 0xE28F60 VA: 0x180E2A960 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xE29EF0 Offset: 0xE284F0 VA: 0x180E29EF0 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xE2B560 Offset: 0xE29B60 VA: 0x180E2B560 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xE2B000 Offset: 0xE29600 VA: 0x180E2B000 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xE2ADE0 Offset: 0xE293E0 VA: 0x180E2ADE0 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xE2C040 Offset: 0xE2A640 VA: 0x180E2C040 Slot: 16
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xE2A3D0 Offset: 0xE289D0 VA: 0x180E2A3D0 Slot: 17
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xE2DE60 Offset: 0xE2C460 VA: 0x180E2DE60
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xE2DCE0 Offset: 0xE2C2E0 VA: 0x180E2DCE0
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xE29CD0 Offset: 0xE282D0 VA: 0x180E29CD0
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xE2DED0 Offset: 0xE2C4D0 VA: 0x180E2DED0
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0xE2CCA0 Offset: 0xE2B2A0 VA: 0x180E2CCA0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xE2B5D0 Offset: 0xE29BD0 VA: 0x180E2B5D0 Slot: 18
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xE2B070 Offset: 0xE29670 VA: 0x180E2B070 Slot: 19
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xE2BC20 Offset: 0xE2A220 VA: 0x180E2BC20 Slot: 20
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xE2F5D0 Offset: 0xE2DBD0 VA: 0x180E2F5D0
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0xE2BE40 Offset: 0xE2A440 VA: 0x180E2BE40
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xE2F310 Offset: 0xE2D910 VA: 0x180E2F310
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80 Slot: 21
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xE2D180 Offset: 0xE2B780 VA: 0x180E2D180 Slot: 22
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xE2D180 Offset: 0xE2B780 VA: 0x180E2D180
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xE2FBF0 Offset: 0xE2E1F0 VA: 0x180E2FBF0
	private static void .cctor() { }

}

private sealed class DefaultContractResolver.<>c // TypeDefIndex: 5994
{
// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue> // TypeDefIndex: 5993

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x1409210 Offset: 0x1407810 VA: 0x181409210
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14089C0 Offset: 0x1406FC0 VA: 0x1814089C0
	internal bool <GetSerializableMembers>b__30_0(MemberInfo m) { }

	// RVA: 0x1408A20 Offset: 0x1407020 VA: 0x181408A20
	internal bool <GetSerializableMembers>b__30_1(MemberInfo m) { }

	// RVA: 0x14084B0 Offset: 0x1406AB0 VA: 0x1814084B0
	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType) { }

	// RVA: 0x1408570 Offset: 0x1406B70 VA: 0x181408570
	internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m) { }

	// RVA: 0x1408420 Offset: 0x1406A20 VA: 0x181408420
	internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c) { }

	// RVA: 0x14083D0 Offset: 0x14069D0 VA: 0x1814083D0
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

	// RVA: 0x1408A80 Offset: 0x1407080 VA: 0x181408A80
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_2 // TypeDefIndex: 5997
{	// Fields
	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408CE0 Offset: 0x14072E0 VA: 0x181408CE0
	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass64_0 // TypeDefIndex: 5998
{	// Fields
	public MethodCall<object, object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408E30 Offset: 0x1407430 VA: 0x181408E30
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass65_0 // TypeDefIndex: 5999
{	// Fields
	public Func<object, object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408ED0 Offset: 0x14074D0 VA: 0x181408ED0
	internal bool <SetIsSpecifiedActions>b__0(object o) { }

}

