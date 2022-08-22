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

	// RVA: 0x12A3590 Offset: 0x12A1B90 VA: 0x1812A3590
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x12A3250 Offset: 0x12A1850 VA: 0x1812A3250
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x12A3490 Offset: 0x12A1A90 VA: 0x1812A3490
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x129AFF0 Offset: 0x12995F0 VA: 0x18129AFF0
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x129B130 Offset: 0x1299730 VA: 0x18129B130
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x129AE50 Offset: 0x1299450 VA: 0x18129AE50
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x129A7F0 Offset: 0x1298DF0 VA: 0x18129A7F0
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x129AED0 Offset: 0x12994D0 VA: 0x18129AED0
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x129ADA0 Offset: 0x12993A0 VA: 0x18129ADA0
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129AA30 Offset: 0x1299030 VA: 0x18129AA30
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129AAE0 Offset: 0x12990E0 VA: 0x18129AAE0
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x12A3C90 Offset: 0x12A2290 VA: 0x1812A3C90
	internal void .ctor() { }

	// RVA: 0x12A28B0 Offset: 0x12A0EB0 VA: 0x1812A28B0
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x129E270 Offset: 0x129C870 VA: 0x18129E270
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129B710 Offset: 0x1299D10 VA: 0x18129B710
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129F8D0 Offset: 0x129DED0 VA: 0x18129F8D0
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129C990 Offset: 0x129AF90 VA: 0x18129C990
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129D130 Offset: 0x129B730 VA: 0x18129D130
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129EB20 Offset: 0x129D120 VA: 0x18129EB20
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129EA90 Offset: 0x129D090 VA: 0x18129EA90 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x129BED0 Offset: 0x129A4D0 VA: 0x18129BED0 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x129F850 Offset: 0x129DE50 VA: 0x18129F850 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x129DA90 Offset: 0x129C090 VA: 0x18129DA90 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x129E500 Offset: 0x129CB00 VA: 0x18129E500 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129BA70 Offset: 0x129A070 VA: 0x18129BA70 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129FBA0 Offset: 0x129E1A0 VA: 0x18129FBA0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129CC00 Offset: 0x129B200 VA: 0x18129CC00 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x129D3A0 Offset: 0x129B9A0 VA: 0x18129D3A0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x129EE30 Offset: 0x129D430 VA: 0x18129EE30 Slot: 60
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x129DED0 Offset: 0x129C4D0 VA: 0x18129DED0 Slot: 63
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x12991E0 Offset: 0x12977E0 VA: 0x1812991E0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x12991E0 Offset: 0x12977E0 VA: 0x1812991E0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1299170 Offset: 0x1297770 VA: 0x181299170 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x1299170 Offset: 0x1297770 VA: 0x181299170
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x691E10 Offset: 0x690410 VA: 0x180691E10 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1299520 Offset: 0x1297B20 VA: 0x181299520 Slot: 114
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A2990 Offset: 0x12A0F90 VA: 0x1812A2990 Slot: 113
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x12A1450 Offset: 0x129FA50 VA: 0x1812A1450 Slot: 115
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x12A27F0 Offset: 0x12A0DF0 VA: 0x1812A27F0 Slot: 116
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x12A3D10 Offset: 0x12A2310 VA: 0x1812A3D10 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x129B460 Offset: 0x1299A60 VA: 0x18129B460
	private RuntimeType GetBaseType() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1299180 Offset: 0x1297780 VA: 0x181299180 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1299470 Offset: 0x1297A70 VA: 0x181299470 Slot: 101
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1299450 Offset: 0x1297A50 VA: 0x181299450 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x1299560 Offset: 0x1297B60 VA: 0x181299560 Slot: 98
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1299550 Offset: 0x1297B50 VA: 0x181299550 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x12A2B20 Offset: 0x12A1120 VA: 0x1812A2B20 Slot: 93
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x12A40A0 Offset: 0x12A26A0 VA: 0x1812A40A0 Slot: 76
	public override bool get_IsEnum() { }

	// RVA: 0x12993E0 Offset: 0x12979E0 VA: 0x1812993E0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x12A3F50 Offset: 0x12A2550 VA: 0x1812A3F50 Slot: 65
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1299570 Offset: 0x1297B70 VA: 0x181299570 Slot: 79
	internal override bool get_IsSzArray() { }

	// RVA: 0x1299440 Offset: 0x1297A40 VA: 0x181299440 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x129B3D0 Offset: 0x12999D0 VA: 0x18129B3D0 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x12991A0 Offset: 0x12977A0 VA: 0x1812991A0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x129C630 Offset: 0x129AC30 VA: 0x18129C630 Slot: 107
	public override string[] GetEnumNames() { }

	// RVA: 0x129C7E0 Offset: 0x129ADE0 VA: 0x18129C7E0 Slot: 108
	public override Array GetEnumValues() { }

	// RVA: 0x129C720 Offset: 0x129AD20 VA: 0x18129C720 Slot: 109
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x12A2270 Offset: 0x12A0870 VA: 0x1812A2270 Slot: 110
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x129C450 Offset: 0x129AA50 VA: 0x18129C450 Slot: 111
	public override string GetEnumName(object value) { }

	// RVA: 0x129DB20 Offset: 0x129C120 VA: 0x18129DB20
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x129DBA0 Offset: 0x129C1A0 VA: 0x18129DBA0 Slot: 104
	public override Type[] GetGenericArguments() { }

	// RVA: 0x12A2D40 Offset: 0x12A1340 VA: 0x1812A2D40 Slot: 100
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1299500 Offset: 0x1297B00 VA: 0x181299500 Slot: 81
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1299510 Offset: 0x1297B10 VA: 0x181299510 Slot: 82
	public override bool get_IsGenericParameter() { }

	// RVA: 0x12A4010 Offset: 0x12A2610 VA: 0x1812A4010 Slot: 83
	public override int get_GenericParameterPosition() { }

	// RVA: 0x129DD50 Offset: 0x129C350 VA: 0x18129DD50 Slot: 105
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1299420 Offset: 0x1297A20 VA: 0x181299420 Slot: 80
	public override bool get_IsGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x12A0080 Offset: 0x129E680 VA: 0x1812A0080 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x12A4190 Offset: 0x12A2790 VA: 0x1812A4190
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 123
	public object Clone() { }

	// RVA: 0x129F4E0 Offset: 0x129DAE0 VA: 0x18129F4E0 Slot: 122
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x129BF80 Offset: 0x129A580 VA: 0x18129BF80 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x129C030 Offset: 0x129A630 VA: 0x18129C030 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A2100 Offset: 0x12A0700 VA: 0x1812A2100 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x129BF70 Offset: 0x129A570 VA: 0x18129BF70 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x129B230 Offset: 0x1299830 VA: 0x18129B230 Slot: 117
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x12A4110 Offset: 0x12A2710 VA: 0x1812A4110 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x12991D0 Offset: 0x12977D0 VA: 0x1812991D0 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x12997F0 Offset: 0x1297DF0 VA: 0x1812997F0
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1299CD0 Offset: 0x12982D0 VA: 0x181299CD0
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1299A30 Offset: 0x1298030 VA: 0x181299A30
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x129C1A0 Offset: 0x129A7A0 VA: 0x18129C1A0
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x129C370 Offset: 0x129A970 VA: 0x18129C370
	private string GetDefaultMemberName() { }

	// RVA: 0x129FE10 Offset: 0x129E410 VA: 0x18129FE10
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x129A7B0 Offset: 0x1298DB0 VA: 0x18129A7B0
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x129A4E0 Offset: 0x1298AE0 VA: 0x18129A4E0
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x12995F0 Offset: 0x1297BF0 VA: 0x1812995F0
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x12A36E0 Offset: 0x12A1CE0 VA: 0x1812A36E0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x12A1530 Offset: 0x129FB30 VA: 0x1812A1530
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x129B690 Offset: 0x1299C90 VA: 0x18129B690
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x12A4170 Offset: 0x12A2770 VA: 0x1812A4170
	private Type make_array_type(int rank) { }

	// RVA: 0x12A2C30 Offset: 0x12A1230 VA: 0x1812A2C30 Slot: 20
	public override Type MakeArrayType() { }

	// RVA: 0x12A2C40 Offset: 0x12A1240 VA: 0x1812A2C40 Slot: 21
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x12A4180 Offset: 0x12A2780 VA: 0x1812A4180
	private Type make_byref_type() { }

	// RVA: 0x12A2CC0 Offset: 0x12A12C0 VA: 0x1812A2CC0 Slot: 19
	public override Type MakeByRefType() { }

	// RVA: 0x12A3240 Offset: 0x12A1840 VA: 0x1812A3240
	private static Type MakePointerType(Type type) { }

	// RVA: 0x12A31F0 Offset: 0x12A17F0 VA: 0x1812A31F0 Slot: 18
	public override Type MakePointerType() { }

	// RVA: 0x12A3D20 Offset: 0x12A2320 VA: 0x1812A3D20 Slot: 84
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x129DC50 Offset: 0x129C250 VA: 0x18129DC50 Slot: 85
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1299B40 Offset: 0x1298140 VA: 0x181299B40
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x12A2D30 Offset: 0x12A1330 VA: 0x1812A2D30
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x129EA80 Offset: 0x129D080 VA: 0x18129EA80
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x129E7A0 Offset: 0x129CDA0 VA: 0x18129E7A0
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x129F840 Offset: 0x129DE40 VA: 0x18129F840
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x129BF60 Offset: 0x129A560 VA: 0x18129BF60
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x129BC70 Offset: 0x129A270 VA: 0x18129BC70
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129F560 Offset: 0x129DB60 VA: 0x18129F560
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x12A0030 Offset: 0x129E630 VA: 0x1812A0030 Slot: 22
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x12A0020 Offset: 0x129E620 VA: 0x1812A0020
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x12A36D0 Offset: 0x12A1CD0 VA: 0x1812A36D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x129A4D0 Offset: 0x1298AD0 VA: 0x18129A4D0
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30 Slot: 17
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x12A3CF0 Offset: 0x12A22F0 VA: 0x1812A3CF0
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x129DB90 Offset: 0x129C190 VA: 0x18129DB90
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x129DC10 Offset: 0x129C210 VA: 0x18129DC10
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x129DD40 Offset: 0x129C340 VA: 0x18129DD40
	private int GetGenericParameterPosition() { }

	// RVA: 0x129D120 Offset: 0x129B720 VA: 0x18129D120
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129DB10 Offset: 0x129C110 VA: 0x18129DB10
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129D7C0 Offset: 0x129BDC0 VA: 0x18129D7C0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129CE50 Offset: 0x129B450 VA: 0x18129CE50
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129DEC0 Offset: 0x129C4C0 VA: 0x18129DEC0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x129F4D0 Offset: 0x129DAD0 VA: 0x18129F4D0
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129F1A0 Offset: 0x129D7A0 VA: 0x18129F1A0
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x12A3D00 Offset: 0x12A2300 VA: 0x1812A3D00 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x12A3E40 Offset: 0x12A2440 VA: 0x1812A3E40 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x12A4150 Offset: 0x12A2750 VA: 0x1812A4150 Slot: 8
	public override string get_Name() { }

	// RVA: 0x12A4160 Offset: 0x12A2760 VA: 0x1812A4160 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x129DDE0 Offset: 0x129C3E0 VA: 0x18129DDE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x12A3E50 Offset: 0x12A2450 VA: 0x1812A3E50 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x12A3970 Offset: 0x12A1F70 VA: 0x1812A3970
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
	|-RVA: 0x1E3520 Offset: 0x1E2920 VA: 0x1801E3520
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
	|-RVA: 0x1E3560 Offset: 0x1E2960 VA: 0x1801E3560
	|-RuntimeType.ListBuilder<object>.get_Item
	|-RuntimeType.ListBuilder<ConstructorInfo>.get_Item
	|-RuntimeType.ListBuilder<MethodInfo>.get_Item
	|-RuntimeType.ListBuilder<PropertyInfo>.get_Item
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3510 Offset: 0x1E2910 VA: 0x1801E3510
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
	|-RVA: 0x1E3450 Offset: 0x1E2850 VA: 0x1801E3450
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
	|-RVA: 0x1E3440 Offset: 0x1E2840 VA: 0x1801E3440
	|-RuntimeType.ListBuilder<object>.Add
	|-RuntimeType.ListBuilder<ConstructorInfo>.Add
	|-RuntimeType.ListBuilder<EventInfo>.Add
	|-RuntimeType.ListBuilder<FieldInfo>.Add
	|-RuntimeType.ListBuilder<MethodInfo>.Add
	|-RuntimeType.ListBuilder<PropertyInfo>.Add
	|-RuntimeType.ListBuilder<Type>.Add
	*/

}

