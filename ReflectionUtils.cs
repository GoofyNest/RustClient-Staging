internal static class ReflectionUtils // TypeDefIndex: 5965
{	// Fields
	public static readonly Type[] EmptyTypes; // 0x2B11170

	// Methods

	// RVA: 0x1810860 Offset: 0x180EE60 VA: 0x181810860
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18101A0 Offset: 0x180E7A0 VA: 0x1818101A0
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x180CC70 Offset: 0x180B270 VA: 0x18180CC70
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x1810120 Offset: 0x180E720 VA: 0x181810120
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0x180ECE0 Offset: 0x180D2E0 VA: 0x18180ECE0
	public static Type GetObjectType(object v) { }

	// RVA: 0x180EFB0 Offset: 0x180D5B0 VA: 0x18180EFB0
	public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder) { }

	// RVA: 0x1810270 Offset: 0x180E870 VA: 0x181810270
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x180F1A0 Offset: 0x180D7A0 VA: 0x18180F1A0
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x180D5C0 Offset: 0x180BBC0 VA: 0x18180D5C0
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x180D490 Offset: 0x180BA90 VA: 0x18180D490
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x180FE00 Offset: 0x180E400 VA: 0x18180FE00
	public static bool IsNullable(Type t) { }

	// RVA: 0x180FD00 Offset: 0x180E300 VA: 0x18180FD00
	public static bool IsNullableType(Type t) { }

	// RVA: 0x180C540 Offset: 0x180AB40 VA: 0x18180C540
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x180FA90 Offset: 0x180E090 VA: 0x18180FA90
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x180F290 Offset: 0x180D890 VA: 0x18180F290
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x180F300 Offset: 0x180D900 VA: 0x18180F300
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x180F6D0 Offset: 0x180DCD0 VA: 0x18180F6D0
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x180F8D0 Offset: 0x180DED0 VA: 0x18180F8D0
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x180F5B0 Offset: 0x180DBB0 VA: 0x18180F5B0
	private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x180D1A0 Offset: 0x180B7A0 VA: 0x18180D1A0
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0x180D8D0 Offset: 0x180BED0 VA: 0x18180D8D0
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x180E5E0 Offset: 0x180CBE0 VA: 0x18180E5E0
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x180FBA0 Offset: 0x180E1A0 VA: 0x18180FBA0
	public static bool IsIndexedProperty(MemberInfo member) { }

	// RVA: 0x180FAF0 Offset: 0x180E0F0 VA: 0x18180FAF0
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x180E960 Offset: 0x180CF60 VA: 0x18180E960
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x18103E0 Offset: 0x180E9E0 VA: 0x1818103E0
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x180C240 Offset: 0x180A840 VA: 0x18180C240
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x180C3B0 Offset: 0x180A9B0 VA: 0x18180C3B0
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x180DBE0 Offset: 0x180C1E0 VA: 0x18180DBE0
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x180FED0 Offset: 0x180E4D0 VA: 0x18180FED0
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
	|-RVA: 0x1A3B780 Offset: 0x1A39D80 VA: 0x181A3B780
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x180C670 Offset: 0x180AC70 VA: 0x18180C670
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x18106D0 Offset: 0x180ECD0 VA: 0x1818106D0
	public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) { }

	// RVA: 0x180C5B0 Offset: 0x180ABB0 VA: 0x18180C5B0
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x180E370 Offset: 0x180C970 VA: 0x18180E370
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x180E0F0 Offset: 0x180C6F0 VA: 0x18180E0F0
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x180CD40 Offset: 0x180B340 VA: 0x18180CD40
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x180ECF0 Offset: 0x180D2F0 VA: 0x18180ECF0
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18103D0 Offset: 0x180E9D0 VA: 0x1818103D0
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x180CEF0 Offset: 0x180B4F0 VA: 0x18180CEF0
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x180D620 Offset: 0x180BC20 VA: 0x18180D620
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

	// RVA: 0x1815650 Offset: 0x1813C50 VA: 0x181815650
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1814B90 Offset: 0x1813190 VA: 0x181814B90
	internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c) { }

	// RVA: 0x1814BF0 Offset: 0x18131F0 VA: 0x181814BF0
	internal string <GetFieldsAndProperties>b__29_0(MemberInfo m) { }

	// RVA: 0x1814BF0 Offset: 0x18131F0 VA: 0x181814BF0
	internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p) { }

	// RVA: 0x1814B70 Offset: 0x1813170 VA: 0x181814B70
	internal bool <GetChildPrivateFields>b__39_0(FieldInfo f) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass42_0 // TypeDefIndex: 5967
{	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1815200 Offset: 0x1813800 VA: 0x181815200
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0x1815270 Offset: 0x1813870 VA: 0x181815270
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

	// RVA: 0x1815330 Offset: 0x1813930 VA: 0x181815330
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass43_0 // TypeDefIndex: 5968
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

