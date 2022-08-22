internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 292
{	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }

	// Methods

	// RVA: 0x12A3EF0 Offset: 0x12A24F0 VA: 0x1812A3EF0
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x12A3BB0 Offset: 0x12A21B0 VA: 0x1812A3BB0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x12A3DF0 Offset: 0x12A23F0 VA: 0x1812A3DF0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x129B950 Offset: 0x1299F50 VA: 0x18129B950
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x129BA90 Offset: 0x129A090 VA: 0x18129BA90
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x129B7B0 Offset: 0x1299DB0 VA: 0x18129B7B0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x129B150 Offset: 0x1299750 VA: 0x18129B150
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x129B830 Offset: 0x1299E30 VA: 0x18129B830
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x129B700 Offset: 0x1299D00 VA: 0x18129B700
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129B390 Offset: 0x1299990 VA: 0x18129B390
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129B440 Offset: 0x1299A40 VA: 0x18129B440
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x12A45F0 Offset: 0x12A2BF0 VA: 0x1812A45F0
	internal void .ctor() { }

	// RVA: 0x12A3210 Offset: 0x12A1810 VA: 0x1812A3210
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x129EBD0 Offset: 0x129D1D0 VA: 0x18129EBD0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129C070 Offset: 0x129A670 VA: 0x18129C070
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x12A0230 Offset: 0x129E830 VA: 0x1812A0230
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129D2F0 Offset: 0x129B8F0 VA: 0x18129D2F0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129DA90 Offset: 0x129C090 VA: 0x18129DA90
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129F480 Offset: 0x129DA80 VA: 0x18129F480
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129F3F0 Offset: 0x129D9F0 VA: 0x18129F3F0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x129C830 Offset: 0x129AE30 VA: 0x18129C830 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x12A01B0 Offset: 0x129E7B0 VA: 0x1812A01B0 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x129E3F0 Offset: 0x129C9F0 VA: 0x18129E3F0 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x129EE60 Offset: 0x129D460 VA: 0x18129EE60 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129C3D0 Offset: 0x129A9D0 VA: 0x18129C3D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x12A0500 Offset: 0x129EB00 VA: 0x1812A0500 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129D560 Offset: 0x129BB60 VA: 0x18129D560 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x129DD00 Offset: 0x129C300 VA: 0x18129DD00 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x129F790 Offset: 0x129DD90 VA: 0x18129F790 Slot: 60
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x129E830 Offset: 0x129CE30 VA: 0x18129E830 Slot: 63
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x1299B40 Offset: 0x1298140 VA: 0x181299B40 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x1299B40 Offset: 0x1298140 VA: 0x181299B40
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1299AD0 Offset: 0x12980D0 VA: 0x181299AD0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x1299AD0 Offset: 0x12980D0 VA: 0x181299AD0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x691EB0 Offset: 0x6904B0 VA: 0x180691EB0 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1299E80 Offset: 0x1298480 VA: 0x181299E80 Slot: 114
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A32F0 Offset: 0x12A18F0 VA: 0x1812A32F0 Slot: 113
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x12A1DB0 Offset: 0x12A03B0 VA: 0x1812A1DB0 Slot: 115
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x12A3150 Offset: 0x12A1750 VA: 0x1812A3150 Slot: 116
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x12A4670 Offset: 0x12A2C70 VA: 0x1812A4670 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x129BDC0 Offset: 0x129A3C0 VA: 0x18129BDC0
	private RuntimeType GetBaseType() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1299AE0 Offset: 0x12980E0 VA: 0x181299AE0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1299DD0 Offset: 0x12983D0 VA: 0x181299DD0 Slot: 101
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1299DB0 Offset: 0x12983B0 VA: 0x181299DB0 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x1299EC0 Offset: 0x12984C0 VA: 0x181299EC0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1299EB0 Offset: 0x12984B0 VA: 0x181299EB0 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x12A3480 Offset: 0x12A1A80 VA: 0x1812A3480 Slot: 93
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x12A4A00 Offset: 0x12A3000 VA: 0x1812A4A00 Slot: 76
	public override bool get_IsEnum() { }

	// RVA: 0x1299D40 Offset: 0x1298340 VA: 0x181299D40 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x12A48B0 Offset: 0x12A2EB0 VA: 0x1812A48B0 Slot: 65
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1299ED0 Offset: 0x12984D0 VA: 0x181299ED0 Slot: 79
	internal override bool get_IsSzArray() { }

	// RVA: 0x1299DA0 Offset: 0x12983A0 VA: 0x181299DA0 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x129BD30 Offset: 0x129A330 VA: 0x18129BD30 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1299B00 Offset: 0x1298100 VA: 0x181299B00 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x129CF90 Offset: 0x129B590 VA: 0x18129CF90 Slot: 107
	public override string[] GetEnumNames() { }

	// RVA: 0x129D140 Offset: 0x129B740 VA: 0x18129D140 Slot: 108
	public override Array GetEnumValues() { }

	// RVA: 0x129D080 Offset: 0x129B680 VA: 0x18129D080 Slot: 109
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x12A2BD0 Offset: 0x12A11D0 VA: 0x1812A2BD0 Slot: 110
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x129CDB0 Offset: 0x129B3B0 VA: 0x18129CDB0 Slot: 111
	public override string GetEnumName(object value) { }

	// RVA: 0x129E480 Offset: 0x129CA80 VA: 0x18129E480
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x129E500 Offset: 0x129CB00 VA: 0x18129E500 Slot: 104
	public override Type[] GetGenericArguments() { }

	// RVA: 0x12A36A0 Offset: 0x12A1CA0 VA: 0x1812A36A0 Slot: 100
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1299E60 Offset: 0x1298460 VA: 0x181299E60 Slot: 81
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1299E70 Offset: 0x1298470 VA: 0x181299E70 Slot: 82
	public override bool get_IsGenericParameter() { }

	// RVA: 0x12A4970 Offset: 0x12A2F70 VA: 0x1812A4970 Slot: 83
	public override int get_GenericParameterPosition() { }

	// RVA: 0x129E6B0 Offset: 0x129CCB0 VA: 0x18129E6B0 Slot: 105
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1299D80 Offset: 0x1298380 VA: 0x181299D80 Slot: 80
	public override bool get_IsGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x12A09E0 Offset: 0x129EFE0 VA: 0x1812A09E0 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x12922A0 Offset: 0x12908A0 VA: 0x1812922A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x12A4AF0 Offset: 0x12A30F0 VA: 0x1812A4AF0
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 123
	public object Clone() { }

	// RVA: 0x129FE40 Offset: 0x129E440 VA: 0x18129FE40 Slot: 122
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x129C8E0 Offset: 0x129AEE0 VA: 0x18129C8E0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x129C990 Offset: 0x129AF90 VA: 0x18129C990 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A2A60 Offset: 0x12A1060 VA: 0x1812A2A60 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x129C8D0 Offset: 0x129AED0 VA: 0x18129C8D0 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x129BB90 Offset: 0x129A190 VA: 0x18129BB90 Slot: 117
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x12A4A70 Offset: 0x12A3070 VA: 0x1812A4A70 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x4C2760 Offset: 0x4C0D60 VA: 0x1804C2760 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1299B30 Offset: 0x1298130 VA: 0x181299B30 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x129A150 Offset: 0x1298750 VA: 0x18129A150
	private void CreateInstanceCheckThis() { }

	// RVA: 0x129A630 Offset: 0x1298C30 VA: 0x18129A630
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x129A390 Offset: 0x1298990 VA: 0x18129A390
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x129CB00 Offset: 0x129B100 VA: 0x18129CB00
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x129CCD0 Offset: 0x129B2D0 VA: 0x18129CCD0
	private string GetDefaultMemberName() { }

	// RVA: 0x12A0770 Offset: 0x129ED70 VA: 0x1812A0770
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x129B110 Offset: 0x1299710 VA: 0x18129B110
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x129AE40 Offset: 0x1299440 VA: 0x18129AE40
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x1299F50 Offset: 0x1298550 VA: 0x181299F50
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x12A4040 Offset: 0x12A2640 VA: 0x1812A4040
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x12A1E90 Offset: 0x12A0490 VA: 0x1812A1E90
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x129BFF0 Offset: 0x129A5F0 VA: 0x18129BFF0
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x12A4AD0 Offset: 0x12A30D0 VA: 0x1812A4AD0
	private Type make_array_type(int rank) { }

	// RVA: 0x12A3590 Offset: 0x12A1B90 VA: 0x1812A3590 Slot: 20
	public override Type MakeArrayType() { }

	// RVA: 0x12A35A0 Offset: 0x12A1BA0 VA: 0x1812A35A0 Slot: 21
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x12A4AE0 Offset: 0x12A30E0 VA: 0x1812A4AE0
	private Type make_byref_type() { }

	// RVA: 0x12A3620 Offset: 0x12A1C20 VA: 0x1812A3620 Slot: 19
	public override Type MakeByRefType() { }

	// RVA: 0x12A3BA0 Offset: 0x12A21A0 VA: 0x1812A3BA0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x12A3B50 Offset: 0x12A2150 VA: 0x1812A3B50 Slot: 18
	public override Type MakePointerType() { }

	// RVA: 0x12A4680 Offset: 0x12A2C80 VA: 0x1812A4680 Slot: 84
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x129E5B0 Offset: 0x129CBB0 VA: 0x18129E5B0 Slot: 85
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x129A4A0 Offset: 0x1298AA0 VA: 0x18129A4A0
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x12A3690 Offset: 0x12A1C90 VA: 0x1812A3690
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x129F3E0 Offset: 0x129D9E0 VA: 0x18129F3E0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x129F100 Offset: 0x129D700 VA: 0x18129F100
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x12A01A0 Offset: 0x129E7A0 VA: 0x1812A01A0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x129C8C0 Offset: 0x129AEC0 VA: 0x18129C8C0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x129C5D0 Offset: 0x129ABD0 VA: 0x18129C5D0
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129FEC0 Offset: 0x129E4C0 VA: 0x18129FEC0
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x12A0990 Offset: 0x129EF90 VA: 0x1812A0990 Slot: 22
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x12A0980 Offset: 0x129EF80 VA: 0x1812A0980
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x12A4030 Offset: 0x12A2630 VA: 0x1812A4030 Slot: 3
	public override string ToString() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x129AE30 Offset: 0x1299430 VA: 0x18129AE30
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0 Slot: 17
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x12A4650 Offset: 0x12A2C50 VA: 0x1812A4650
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x129E4F0 Offset: 0x129CAF0 VA: 0x18129E4F0
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x129E570 Offset: 0x129CB70 VA: 0x18129E570
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x129E6A0 Offset: 0x129CCA0 VA: 0x18129E6A0
	private int GetGenericParameterPosition() { }

	// RVA: 0x129DA80 Offset: 0x129C080 VA: 0x18129DA80
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129E470 Offset: 0x129CA70 VA: 0x18129E470
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129E120 Offset: 0x129C720 VA: 0x18129E120
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129D7B0 Offset: 0x129BDB0 VA: 0x18129D7B0
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129E820 Offset: 0x129CE20 VA: 0x18129E820 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x129FE30 Offset: 0x129E430 VA: 0x18129FE30
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129FB00 Offset: 0x129E100 VA: 0x18129FB00
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x12A4660 Offset: 0x12A2C60 VA: 0x1812A4660 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x12A47A0 Offset: 0x12A2DA0 VA: 0x1812A47A0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x12A4AB0 Offset: 0x12A30B0 VA: 0x1812A4AB0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x12A4AC0 Offset: 0x12A30C0 VA: 0x1812A4AC0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x129E740 Offset: 0x129CD40 VA: 0x18129E740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x12A47B0 Offset: 0x12A2DB0 VA: 0x1812A47B0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x12A42D0 Offset: 0x12A28D0 VA: 0x1812A42D0
	private static void .cctor() { }

}

internal enum RuntimeType.MemberListType // TypeDefIndex: 293
{	// Fields
	public int value__; // 0x0
	public const RuntimeType.MemberListType All = 0;
	public const RuntimeType.MemberListType CaseSensitive = 1;
	public const RuntimeType.MemberListType CaseInsensitive = 2;
	public const RuntimeType.MemberListType HandleToInfo = 3;

}

private struct RuntimeType.ListBuilder<T> // TypeDefIndex: 294
{	// Fields
	private T[] _items; // 0x0
	private T _item; // 0x0
	private int _count; // 0x0
	private int _capacity; // 0x0

	// Properties
	public T Item { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3940 Offset: 0x1E2D40 VA: 0x1801E3940
	|-RuntimeType.ListBuilder<object>..ctor
	|-RuntimeType.ListBuilder<ConstructorInfo>..ctor
	|-RuntimeType.ListBuilder<EventInfo>..ctor
	|-RuntimeType.ListBuilder<FieldInfo>..ctor
	|-RuntimeType.ListBuilder<MethodInfo>..ctor
	|-RuntimeType.ListBuilder<PropertyInfo>..ctor
	|-RuntimeType.ListBuilder<Type>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3980 Offset: 0x1E2D80 VA: 0x1801E3980
	|-RuntimeType.ListBuilder<object>.get_Item
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Item
	|-RuntimeType.ListBuilder<MethodInfo>.get_Item
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3930 Offset: 0x1E2D30 VA: 0x1801E3930
	|-RuntimeType.ListBuilder<object>.ToArray
	|-RuntimeType.ListBuilder<ConstructorInfo>.ToArray
	|-RuntimeType.ListBuilder<EventInfo>.ToArray
	|-RuntimeType.ListBuilder<FieldInfo>.ToArray
	|-RuntimeType.ListBuilder<MethodInfo>.ToArray
	|-RuntimeType.ListBuilder<PropertyInfo>.ToArray
	|-RuntimeType.ListBuilder<Type>.ToArray
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3870 Offset: 0x1E2C70 VA: 0x1801E3870
	|-RuntimeType.ListBuilder<object>.CopyTo
	|-RuntimeType.ListBuilder<ConstructorInfo>.CopyTo
	|-RuntimeType.ListBuilder<EventInfo>.CopyTo
	|-RuntimeType.ListBuilder<FieldInfo>.CopyTo
	|-RuntimeType.ListBuilder<MethodInfo>.CopyTo
	|-RuntimeType.ListBuilder<PropertyInfo>.CopyTo
	|-RuntimeType.ListBuilder<Type>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	|-RuntimeType.ListBuilder<object>.get_Count
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Count
	|-RuntimeType.ListBuilder<EventInfo>.get_Count
	|-RuntimeType.ListBuilder<FieldInfo>.get_Count
	|-RuntimeType.ListBuilder<MethodInfo>.get_Count
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Count
	|-RuntimeType.ListBuilder<Type>.get_Count
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3860 Offset: 0x1E2C60 VA: 0x1801E3860
	|-RuntimeType.ListBuilder<object>.Add
	|-RuntimeType.ListBuilder<ConstructorInfo>.Add
	|-RuntimeType.ListBuilder<EventInfo>.Add
	|-RuntimeType.ListBuilder<FieldInfo>.Add
	|-RuntimeType.ListBuilder<MethodInfo>.Add
	|-RuntimeType.ListBuilder<PropertyInfo>.Add
	|-RuntimeType.ListBuilder<Type>.Add
	*/

}

