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

	// RVA: 0x12A3850 Offset: 0x12A1E50 VA: 0x1812A3850
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x12A3510 Offset: 0x12A1B10 VA: 0x1812A3510
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x12A3750 Offset: 0x12A1D50 VA: 0x1812A3750
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x129B2B0 Offset: 0x12998B0 VA: 0x18129B2B0
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x129B3F0 Offset: 0x12999F0 VA: 0x18129B3F0
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x129B110 Offset: 0x1299710 VA: 0x18129B110
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x129AAB0 Offset: 0x12990B0 VA: 0x18129AAB0
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x129B190 Offset: 0x1299790 VA: 0x18129B190
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x129B060 Offset: 0x1299660 VA: 0x18129B060
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129ACF0 Offset: 0x12992F0 VA: 0x18129ACF0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x129ADA0 Offset: 0x12993A0 VA: 0x18129ADA0
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x12A3F50 Offset: 0x12A2550 VA: 0x1812A3F50
	internal void .ctor() { }

	// RVA: 0x12A2B70 Offset: 0x12A1170 VA: 0x1812A2B70
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x129E530 Offset: 0x129CB30 VA: 0x18129E530
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129B9D0 Offset: 0x1299FD0 VA: 0x18129B9D0
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129FB90 Offset: 0x129E190 VA: 0x18129FB90
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x129CC50 Offset: 0x129B250 VA: 0x18129CC50
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129D3F0 Offset: 0x129B9F0 VA: 0x18129D3F0
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129EDE0 Offset: 0x129D3E0 VA: 0x18129EDE0
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x129ED50 Offset: 0x129D350 VA: 0x18129ED50 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x129C190 Offset: 0x129A790 VA: 0x18129C190 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x129FB10 Offset: 0x129E110 VA: 0x18129FB10 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x129DD50 Offset: 0x129C350 VA: 0x18129DD50 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x129E7C0 Offset: 0x129CDC0 VA: 0x18129E7C0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129BD30 Offset: 0x129A330 VA: 0x18129BD30 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129FE60 Offset: 0x129E460 VA: 0x18129FE60 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x129CEC0 Offset: 0x129B4C0 VA: 0x18129CEC0 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x129D660 Offset: 0x129BC60 VA: 0x18129D660 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x129F0F0 Offset: 0x129D6F0 VA: 0x18129F0F0 Slot: 60
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x129E190 Offset: 0x129C790 VA: 0x18129E190 Slot: 63
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x12994A0 Offset: 0x1297AA0 VA: 0x1812994A0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x12994A0 Offset: 0x1297AA0 VA: 0x1812994A0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1299430 Offset: 0x1297A30 VA: 0x181299430 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x1299430 Offset: 0x1297A30 VA: 0x181299430
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x691F20 Offset: 0x690520 VA: 0x180691F20 Slot: 25
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x12997E0 Offset: 0x1297DE0 VA: 0x1812997E0 Slot: 114
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x12A2C50 Offset: 0x12A1250 VA: 0x1812A2C50 Slot: 113
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x12A1710 Offset: 0x129FD10 VA: 0x1812A1710 Slot: 115
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x12A2AB0 Offset: 0x12A10B0 VA: 0x1812A2AB0 Slot: 116
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x12A3FD0 Offset: 0x12A25D0 VA: 0x1812A3FD0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x129B720 Offset: 0x1299D20 VA: 0x18129B720
	private RuntimeType GetBaseType() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1299440 Offset: 0x1297A40 VA: 0x181299440 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1299730 Offset: 0x1297D30 VA: 0x181299730 Slot: 101
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1299710 Offset: 0x1297D10 VA: 0x181299710 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x1299820 Offset: 0x1297E20 VA: 0x181299820 Slot: 98
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1299810 Offset: 0x1297E10 VA: 0x181299810 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x12A2DE0 Offset: 0x12A13E0 VA: 0x1812A2DE0 Slot: 93
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x12A4360 Offset: 0x12A2960 VA: 0x1812A4360 Slot: 76
	public override bool get_IsEnum() { }

	// RVA: 0x12996A0 Offset: 0x1297CA0 VA: 0x1812996A0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x12A4210 Offset: 0x12A2810 VA: 0x1812A4210 Slot: 65
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1299830 Offset: 0x1297E30 VA: 0x181299830 Slot: 79
	internal override bool get_IsSzArray() { }

	// RVA: 0x1299700 Offset: 0x1297D00 VA: 0x181299700 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x129B690 Offset: 0x1299C90 VA: 0x18129B690 Slot: 29
	public override int GetArrayRank() { }

	// RVA: 0x1299460 Offset: 0x1297A60 VA: 0x181299460 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x129C8F0 Offset: 0x129AEF0 VA: 0x18129C8F0 Slot: 107
	public override string[] GetEnumNames() { }

	// RVA: 0x129CAA0 Offset: 0x129B0A0 VA: 0x18129CAA0 Slot: 108
	public override Array GetEnumValues() { }

	// RVA: 0x129C9E0 Offset: 0x129AFE0 VA: 0x18129C9E0 Slot: 109
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x12A2530 Offset: 0x12A0B30 VA: 0x1812A2530 Slot: 110
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x129C710 Offset: 0x129AD10 VA: 0x18129C710 Slot: 111
	public override string GetEnumName(object value) { }

	// RVA: 0x129DDE0 Offset: 0x129C3E0 VA: 0x18129DDE0
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x129DE60 Offset: 0x129C460 VA: 0x18129DE60 Slot: 104
	public override Type[] GetGenericArguments() { }

	// RVA: 0x12A3000 Offset: 0x12A1600 VA: 0x1812A3000 Slot: 100
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x12997C0 Offset: 0x1297DC0 VA: 0x1812997C0 Slot: 81
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x12997D0 Offset: 0x1297DD0 VA: 0x1812997D0 Slot: 82
	public override bool get_IsGenericParameter() { }

	// RVA: 0x12A42D0 Offset: 0x12A28D0 VA: 0x1812A42D0 Slot: 83
	public override int get_GenericParameterPosition() { }

	// RVA: 0x129E010 Offset: 0x129C610 VA: 0x18129E010 Slot: 105
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x12996E0 Offset: 0x1297CE0 VA: 0x1812996E0 Slot: 80
	public override bool get_IsGenericType() { }

	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x12A0340 Offset: 0x129E940 VA: 0x1812A0340 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x1291C00 Offset: 0x1290200 VA: 0x181291C00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x12A4450 Offset: 0x12A2A50 VA: 0x1812A4450
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 123
	public object Clone() { }

	// RVA: 0x129F7A0 Offset: 0x129DDA0 VA: 0x18129F7A0 Slot: 122
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x129C240 Offset: 0x129A840 VA: 0x18129C240 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x129C2F0 Offset: 0x129A8F0 VA: 0x18129C2F0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A23C0 Offset: 0x12A09C0 VA: 0x1812A23C0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x129C230 Offset: 0x129A830 VA: 0x18129C230 Slot: 14
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x129B4F0 Offset: 0x1299AF0 VA: 0x18129B4F0 Slot: 117
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x12A43D0 Offset: 0x12A29D0 VA: 0x1812A43D0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x4C27D0 Offset: 0x4C0DD0 VA: 0x1804C27D0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1299490 Offset: 0x1297A90 VA: 0x181299490 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1299AB0 Offset: 0x12980B0 VA: 0x181299AB0
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1299F90 Offset: 0x1298590 VA: 0x181299F90
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[DebuggerHiddenAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1299CF0 Offset: 0x12982F0 VA: 0x181299CF0
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x129C460 Offset: 0x129AA60 VA: 0x18129C460
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x129C630 Offset: 0x129AC30 VA: 0x18129C630
	private string GetDefaultMemberName() { }

	// RVA: 0x12A00D0 Offset: 0x129E6D0 VA: 0x1812A00D0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x129AA70 Offset: 0x1299070 VA: 0x18129AA70
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x129A7A0 Offset: 0x1298DA0 VA: 0x18129A7A0
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x12998B0 Offset: 0x1297EB0 VA: 0x1812998B0
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x12A39A0 Offset: 0x12A1FA0 VA: 0x1812A39A0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x12A17F0 Offset: 0x129FDF0 VA: 0x1812A17F0
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x129B950 Offset: 0x1299F50 VA: 0x18129B950
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x12A4430 Offset: 0x12A2A30 VA: 0x1812A4430
	private Type make_array_type(int rank) { }

	// RVA: 0x12A2EF0 Offset: 0x12A14F0 VA: 0x1812A2EF0 Slot: 20
	public override Type MakeArrayType() { }

	// RVA: 0x12A2F00 Offset: 0x12A1500 VA: 0x1812A2F00 Slot: 21
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x12A4440 Offset: 0x12A2A40 VA: 0x1812A4440
	private Type make_byref_type() { }

	// RVA: 0x12A2F80 Offset: 0x12A1580 VA: 0x1812A2F80 Slot: 19
	public override Type MakeByRefType() { }

	// RVA: 0x12A3500 Offset: 0x12A1B00 VA: 0x1812A3500
	private static Type MakePointerType(Type type) { }

	// RVA: 0x12A34B0 Offset: 0x12A1AB0 VA: 0x1812A34B0 Slot: 18
	public override Type MakePointerType() { }

	// RVA: 0x12A3FE0 Offset: 0x12A25E0 VA: 0x1812A3FE0 Slot: 84
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x129DF10 Offset: 0x129C510 VA: 0x18129DF10 Slot: 85
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1299E00 Offset: 0x1298400 VA: 0x181299E00
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x12A2FF0 Offset: 0x12A15F0 VA: 0x1812A2FF0
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x129ED40 Offset: 0x129D340 VA: 0x18129ED40
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x129EA60 Offset: 0x129D060 VA: 0x18129EA60
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x129FB00 Offset: 0x129E100 VA: 0x18129FB00
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x129C220 Offset: 0x129A820 VA: 0x18129C220
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x129BF30 Offset: 0x129A530 VA: 0x18129BF30
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129F820 Offset: 0x129DE20 VA: 0x18129F820
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x12A02F0 Offset: 0x129E8F0 VA: 0x1812A02F0 Slot: 22
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x12A02E0 Offset: 0x129E8E0 VA: 0x1812A02E0
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x12A3990 Offset: 0x12A1F90 VA: 0x1812A3990 Slot: 3
	public override string ToString() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x129A790 Offset: 0x1298D90 VA: 0x18129A790
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0 Slot: 17
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x12A3FB0 Offset: 0x12A25B0 VA: 0x1812A3FB0
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x129DE50 Offset: 0x129C450 VA: 0x18129DE50
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x129DED0 Offset: 0x129C4D0 VA: 0x18129DED0
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x129E000 Offset: 0x129C600 VA: 0x18129E000
	private int GetGenericParameterPosition() { }

	// RVA: 0x129D3E0 Offset: 0x129B9E0 VA: 0x18129D3E0
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129DDD0 Offset: 0x129C3D0 VA: 0x18129DDD0
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129DA80 Offset: 0x129C080 VA: 0x18129DA80
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129D110 Offset: 0x129B710 VA: 0x18129D110
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x129E180 Offset: 0x129C780 VA: 0x18129E180 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x129F790 Offset: 0x129DD90 VA: 0x18129F790
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x129F460 Offset: 0x129DA60 VA: 0x18129F460
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x12A3FC0 Offset: 0x12A25C0 VA: 0x1812A3FC0 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x12A4100 Offset: 0x12A2700 VA: 0x1812A4100 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x12A4410 Offset: 0x12A2A10 VA: 0x1812A4410 Slot: 8
	public override string get_Name() { }

	// RVA: 0x12A4420 Offset: 0x12A2A20 VA: 0x1812A4420 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x129E0A0 Offset: 0x129C6A0 VA: 0x18129E0A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x12A4110 Offset: 0x12A2710 VA: 0x1812A4110 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x12A3C30 Offset: 0x12A2230 VA: 0x1812A3C30
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

