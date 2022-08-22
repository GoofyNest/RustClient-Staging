internal static class ReflectionUtils // TypeDefIndex: 5965
{	// Fields
	public static readonly Type[] EmptyTypes; // 0x3362

	// Methods

	// RVA: 0x17FDF60 Offset: 0x17FC560 VA: 0x1817FDF60
	private static void .cctor() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FD8A0 Offset: 0x17FBEA0 VA: 0x1817FD8A0
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FA370 Offset: 0x17F8970 VA: 0x1817FA370
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x17FD820 Offset: 0x17FBE20 VA: 0x1817FD820
	public static bool IsPublic(PropertyInfo property) { }

	// RVA: 0x17FC3E0 Offset: 0x17FA9E0 VA: 0x1817FC3E0
	public static Type GetObjectType(object v) { }

	// RVA: 0x17FC6B0 Offset: 0x17FACB0 VA: 0x1817FC6B0
	public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder) { }

	// RVA: 0x17FD970 Offset: 0x17FBF70 VA: 0x1817FD970
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x17FC8A0 Offset: 0x17FAEA0 VA: 0x1817FC8A0
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x17FACC0 Offset: 0x17F92C0 VA: 0x1817FACC0
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x17FAB90 Offset: 0x17F9190 VA: 0x1817FAB90
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x17FD500 Offset: 0x17FBB00 VA: 0x1817FD500
	public static bool IsNullable(Type t) { }

	// RVA: 0x17FD400 Offset: 0x17FBA00 VA: 0x1817FD400
	public static bool IsNullableType(Type t) { }

	// RVA: 0x17F9C40 Offset: 0x17F8240 VA: 0x1817F9C40
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x17FD190 Offset: 0x17FB790 VA: 0x1817FD190
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x17FC990 Offset: 0x17FAF90 VA: 0x1817FC990
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x17FCA00 Offset: 0x17FB000 VA: 0x1817FCA00
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x17FCDD0 Offset: 0x17FB3D0 VA: 0x1817FCDD0
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x17FCFD0 Offset: 0x17FB5D0 VA: 0x1817FCFD0
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x17FCCB0 Offset: 0x17FB2B0 VA: 0x1817FCCB0
	private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x17FA8A0 Offset: 0x17F8EA0 VA: 0x1817FA8A0
	public static Type GetCollectionItemType(Type type) { }

	// RVA: 0x17FAFD0 Offset: 0x17F95D0 VA: 0x1817FAFD0
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x17FBCE0 Offset: 0x17FA2E0 VA: 0x1817FBCE0
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x17FD2A0 Offset: 0x17FB8A0 VA: 0x1817FD2A0
	public static bool IsIndexedProperty(MemberInfo member) { }

	// RVA: 0x17FD1F0 Offset: 0x17FB7F0 VA: 0x1817FD1F0
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x17FC060 Offset: 0x17FA660 VA: 0x1817FC060
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x17FDAE0 Offset: 0x17FC0E0 VA: 0x1817FDAE0
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x17F9940 Offset: 0x17F7F40 VA: 0x1817F9940
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x17F9AB0 Offset: 0x17F80B0 VA: 0x1817F9AB0
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x17FB2E0 Offset: 0x17F98E0 VA: 0x1817FB2E0
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x17FD5D0 Offset: 0x17FBBD0 VA: 0x1817FD5D0
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3AD0 Offset: 0x5D20D0 VA: 0x1805D3AD0
	|-ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3A30 Offset: 0x5D2030 VA: 0x1805D3A30
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3B120 Offset: 0x1A39720 VA: 0x181A3B120
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x17F9D70 Offset: 0x17F8370 VA: 0x1817F9D70
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x17FDDD0 Offset: 0x17FC3D0 VA: 0x1817FDDD0
	public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName) { }

	// RVA: 0x17F9CB0 Offset: 0x17F82B0 VA: 0x1817F9CB0
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x17FBA70 Offset: 0x17FA070 VA: 0x1817FBA70
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x17FB7F0 Offset: 0x17F9DF0 VA: 0x1817FB7F0
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x17FA440 Offset: 0x17F8A40 VA: 0x1817FA440
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x17FC3F0 Offset: 0x17FA9F0 VA: 0x1817FC3F0
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x17FDAD0 Offset: 0x17FC0D0 VA: 0x1817FDAD0
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x17FA5F0 Offset: 0x17F8BF0 VA: 0x1817FA5F0
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x17FAD20 Offset: 0x17F9320 VA: 0x1817FAD20
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

	// RVA: 0x1802D50 Offset: 0x1801350 VA: 0x181802D50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1802290 Offset: 0x1800890 VA: 0x181802290
	internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c) { }

	// RVA: 0x18022F0 Offset: 0x18008F0 VA: 0x1818022F0
	internal string <GetFieldsAndProperties>b__29_0(MemberInfo m) { }

	// RVA: 0x18022F0 Offset: 0x18008F0 VA: 0x1818022F0
	internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p) { }

	// RVA: 0x1802270 Offset: 0x1800870 VA: 0x181802270
	internal bool <GetChildPrivateFields>b__39_0(FieldInfo f) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass42_0 // TypeDefIndex: 5967
{	// Fields
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1802900 Offset: 0x1800F00 VA: 0x181802900
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	// RVA: 0x1802970 Offset: 0x1800F70 VA: 0x181802970
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }

	// RVA: 0x1802A30 Offset: 0x1801030 VA: 0x181802A30
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }

}

private sealed class ReflectionUtils.<>c__DisplayClass43_0 // TypeDefIndex: 5968
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

