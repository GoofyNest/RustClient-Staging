internal static class ReflectionUtils // TypeDefIndex: 5965
{	// Fields
	public static readonly Type[] EmptyTypes; // 0x2B111D0

	// Methods

	// RVA: 0x1810B20 Offset: 0x180F120 VA: 0x181810B20
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1810460 Offset: 0x180EA60 VA: 0x181810460
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180CF30 Offset: 0x180B530 VA: 0x18180CF30
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x18103E0 Offset: 0x180E9E0 VA: 0x1818103E0
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0x180EFA0 Offset: 0x180D5A0 VA: 0x18180EFA0
	public static Type GetObjectType(object v) { }

	// RVA: 0x180F270 Offset: 0x180D870 VA: 0x18180F270
	public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder) { }

	// RVA: 0x1810530 Offset: 0x180EB30 VA: 0x181810530
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x180F460 Offset: 0x180DA60 VA: 0x18180F460
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x180D880 Offset: 0x180BE80 VA: 0x18180D880
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x180D750 Offset: 0x180BD50 VA: 0x18180D750
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x18100C0 Offset: 0x180E6C0 VA: 0x1818100C0
	public static bool IsNullable(Type t) { }

	// RVA: 0x180FFC0 Offset: 0x180E5C0 VA: 0x18180FFC0
	public static bool IsNullableType(Type t) { }

	// RVA: 0x180C800 Offset: 0x180AE00 VA: 0x18180C800
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x180FD50 Offset: 0x180E350 VA: 0x18180FD50
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x180F550 Offset: 0x180DB50 VA: 0x18180F550
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x180F5C0 Offset: 0x180DBC0 VA: 0x18180F5C0
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x180F990 Offset: 0x180DF90 VA: 0x18180F990
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x180FB90 Offset: 0x180E190 VA: 0x18180FB90
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x180F870 Offset: 0x180DE70 VA: 0x18180F870
	private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x180D460 Offset: 0x180BA60 VA: 0x18180D460
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0x180DB90 Offset: 0x180C190 VA: 0x18180DB90
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x180E8A0 Offset: 0x180CEA0 VA: 0x18180E8A0
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x180FE60 Offset: 0x180E460 VA: 0x18180FE60
	public static bool IsIndexedProperty(MemberInfo member) { }

	// RVA: 0x180FDB0 Offset: 0x180E3B0 VA: 0x18180FDB0
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x180EC20 Offset: 0x180D220 VA: 0x18180EC20
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x18106A0 Offset: 0x180ECA0 VA: 0x1818106A0
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x180C500 Offset: 0x180AB00 VA: 0x18180C500
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x180C670 Offset: 0x180AC70 VA: 0x18180C670
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x180DEA0 Offset: 0x180C4A0 VA: 0x18180DEA0
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x1810190 Offset: 0x180E790 VA: 0x181810190
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3B40 Offset: 0x5D2140 VA: 0x1805D3B40
	|-ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3AA0 Offset: 0x5D20A0 VA: 0x1805D3AA0
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3BA00 Offset: 0x1A3A000 VA: 0x181A3BA00
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x180C930 Offset: 0x180AF30 VA: 0x18180C930
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x1810990 Offset: 0x180EF90 VA: 0x181810990
	public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) { }

	// RVA: 0x180C870 Offset: 0x180AE70 VA: 0x18180C870
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x180E630 Offset: 0x180CC30 VA: 0x18180E630
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x180E3B0 Offset: 0x180C9B0 VA: 0x18180E3B0
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x180D000 Offset: 0x180B600 VA: 0x18180D000
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x180EFB0 Offset: 0x180D5B0 VA: 0x18180EFB0
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1810690 Offset: 0x180EC90 VA: 0x181810690
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x180D1B0 Offset: 0x180B7B0 VA: 0x18180D1B0
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x180D8E0 Offset: 0x180BEE0 VA: 0x18180D8E0
	public static object GetDefaultValue(Type type) { }

}

private sealed class ReflectionUtils.<>c // TypeDefIndex: 5966
{	// Fields
	public static readonly ReflectionUtils.<>c <>9; // 0x0
	public static Func<ConstructorInfo, bool> <>9__10_0; // 0x8
	public static Func<MemberInfo, string> <>9__29_0; // 0x10
	public static Func<ParameterInfo, Type> <>9__37_0; // 0x18
	public static Func<FieldInfo, bool> <>9__39_0; // 0x20

	// Methods

	// RVA: 0x1815910 Offset: 0x1813F10 VA: 0x181815910
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1814E50 Offset: 0x1813450 VA: 0x181814E50
	internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c) { }

	// RVA: 0x1814EB0 Offset: 0x18134B0 VA: 0x181814EB0
	internal string <GetFieldsAndProperties>b__29_0(MemberInfo m) { }

	// RVA: 0x1814EB0 Offset: 0x18134B0 VA: 0x181814EB0
	internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p) { }

	// RVA: 0x1814E30 Offset: 0x1813430 VA: 0x181814E30
	internal bool <GetChildPrivateFields>b__39_0(FieldInfo f) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass42_0 // TypeDefIndex: 5967
{	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x18154C0 Offset: 0x1813AC0 VA: 0x1818154C0
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0x1815530 Offset: 0x1813B30 VA: 0x181815530
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

	// RVA: 0x18155F0 Offset: 0x1813BF0 VA: 0x1818155F0
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass43_0 // TypeDefIndex: 5968
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

