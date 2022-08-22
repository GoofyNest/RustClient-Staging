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

	// RVA: 0xE30D30 Offset: 0xE2F330 VA: 0x180E30D30
	internal static IContractResolver get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xB10BA0 Offset: 0xB0F1A0 VA: 0x180B10BA0
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE30D90 Offset: 0xE2F390 VA: 0x180E30D90
	public void set_IgnoreSerializableAttribute(bool value) { }

	// RVA: 0xE30CC0 Offset: 0xE2F2C0 VA: 0x180E30CC0
	public void .ctor() { }

	[ObsoleteAttribute] // RVA: 0x7F530 Offset: 0x7E930 VA: 0x18007F530
	// RVA: 0xE30C30 Offset: 0xE2F230 VA: 0x180E30C30
	public void .ctor(bool shareCache) { }

	// RVA: 0xE2E5F0 Offset: 0xE2CBF0 VA: 0x180E2E5F0
	internal DefaultContractResolverState GetState() { }

	// RVA: 0xE2F5B0 Offset: 0xE2DBB0 VA: 0x180E2F5B0 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0xE2DF10 Offset: 0xE2C510 VA: 0x180E2DF10 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0xE30850 Offset: 0xE2EE50 VA: 0x180E30850
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0xE2BE40 Offset: 0xE2A440 VA: 0x180E2BE40 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0xE2DC80 Offset: 0xE2C280 VA: 0x180E2DC80
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0xE2F800 Offset: 0xE2DE00 VA: 0x180E2F800
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0xE2CE20 Offset: 0xE2B420 VA: 0x180E2CE20
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0xE2DE50 Offset: 0xE2C450 VA: 0x180E2DE50
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0xE2AF70 Offset: 0xE29570 VA: 0x180E2AF70 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0xE2C6C0 Offset: 0xE2ACC0 VA: 0x180E2C6C0 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0xE2F550 Offset: 0xE2DB50 VA: 0x180E2F550 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0xE2DBE0 Offset: 0xE2C1E0 VA: 0x180E2DBE0
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0xE2E660 Offset: 0xE2CC60 VA: 0x180E2E660
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0xE2F3C0 Offset: 0xE2D9C0 VA: 0x180E2F3C0
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0xE2D220 Offset: 0xE2B820 VA: 0x180E2D220
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0xE2D930 Offset: 0xE2BF30 VA: 0x180E2D930
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0xE2B6D0 Offset: 0xE29CD0 VA: 0x180E2B6D0 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0xE2AC60 Offset: 0xE29260 VA: 0x180E2AC60 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0xE2C2D0 Offset: 0xE2A8D0 VA: 0x180E2C2D0 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0xE2BD70 Offset: 0xE2A370 VA: 0x180E2BD70 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0xE2BB50 Offset: 0xE2A150 VA: 0x180E2BB50 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0xE2CDB0 Offset: 0xE2B3B0 VA: 0x180E2CDB0 Slot: 16
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0xE2B140 Offset: 0xE29740 VA: 0x180E2B140 Slot: 17
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0xE2EBD0 Offset: 0xE2D1D0 VA: 0x180E2EBD0
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0xE2EA50 Offset: 0xE2D050 VA: 0x180E2EA50
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0xE2AA40 Offset: 0xE29040 VA: 0x180E2AA40
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0xE2EC40 Offset: 0xE2D240 VA: 0x180E2EC40
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0xE2DA10 Offset: 0xE2C010 VA: 0x180E2DA10
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0xE2C340 Offset: 0xE2A940 VA: 0x180E2C340 Slot: 18
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0xE2BDE0 Offset: 0xE2A3E0 VA: 0x180E2BDE0 Slot: 19
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0xE2C990 Offset: 0xE2AF90 VA: 0x180E2C990 Slot: 20
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0xE30340 Offset: 0xE2E940 VA: 0x180E30340
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0xE2CBB0 Offset: 0xE2B1B0 VA: 0x180E2CBB0
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0xE30080 Offset: 0xE2E680 VA: 0x180E30080
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380 Slot: 21
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0xE2DEF0 Offset: 0xE2C4F0 VA: 0x180E2DEF0 Slot: 22
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0xE2DEF0 Offset: 0xE2C4F0 VA: 0x180E2DEF0
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0xE30960 Offset: 0xE2EF60 VA: 0x180E30960
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

	// RVA: 0x14085B0 Offset: 0x1406BB0 VA: 0x1814085B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1407D60 Offset: 0x1406360 VA: 0x181407D60
	internal bool <GetSerializableMembers>b__30_0(MemberInfo m) { }

	// RVA: 0x1407DC0 Offset: 0x14063C0 VA: 0x181407DC0
	internal bool <GetSerializableMembers>b__30_1(MemberInfo m) { }

	// RVA: 0x1407850 Offset: 0x1405E50 VA: 0x181407850
	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType) { }

	// RVA: 0x1407910 Offset: 0x1405F10 VA: 0x181407910
	internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m) { }

	// RVA: 0x14077C0 Offset: 0x1405DC0 VA: 0x1814077C0
	internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c) { }

	// RVA: 0x1407770 Offset: 0x1405D70 VA: 0x181407770
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

	// RVA: 0x1407E20 Offset: 0x1406420 VA: 0x181407E20
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass34_2 // TypeDefIndex: 5997
{	// Fields
	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	public DefaultContractResolver.<>c__DisplayClass34_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408080 Offset: 0x1406680 VA: 0x181408080
	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass64_0 // TypeDefIndex: 5998
{	// Fields
	public MethodCall<object, object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14081D0 Offset: 0x14067D0 VA: 0x1814081D0
	internal bool <CreateShouldSerializeTest>b__0(object o) { }

}

private sealed class DefaultContractResolver.<>c__DisplayClass65_0 // TypeDefIndex: 5999
{	// Fields
	public Func<object, object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1408270 Offset: 0x1406870 VA: 0x181408270
	internal bool <SetIsSpecifiedActions>b__0(object o) { }

}

