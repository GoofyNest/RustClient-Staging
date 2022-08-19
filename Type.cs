public abstract class Type : MemberInfo, _Type // TypeDefIndex: 322
{	// Fields
	public static readonly MemberFilter FilterAttribute; // 0x0
	public static readonly MemberFilter FilterName; // 0x8
	public static readonly MemberFilter FilterNameIgnoreCase; // 0x10
	public static readonly object Missing; // 0x18
	public static readonly char Delimiter; // 0x20
	public static readonly Type[] EmptyTypes; // 0x28
	private static Binder defaultBinder; // 0x30
	private const BindingFlags DefaultLookup = 28;
	internal const BindingFlags DeclaredOnlyLookup = 62;
	internal RuntimeTypeHandle _impl; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public override Type DeclaringType { get; }
	public virtual MethodBase DeclaringMethod { get; }
	public override Type ReflectedType { get; }
	public static Binder DefaultBinder { get; }
	public abstract override Module Module { get; }
	public abstract Assembly Assembly { get; }
	public virtual RuntimeTypeHandle TypeHandle { get; }
	public abstract string FullName { get; }
	public abstract string Namespace { get; }
	public abstract string AssemblyQualifiedName { get; }
	public abstract Type BaseType { get; }
	public bool IsNested { get; }
	public TypeAttributes Attributes { get; }
	public virtual GenericParameterAttributes GenericParameterAttributes { get; }
	public bool IsVisible { get; }
	public bool IsNotPublic { get; }
	public bool IsPublic { get; }
	public bool IsNestedPublic { get; }
	public bool IsNestedAssembly { get; }
	public bool IsExplicitLayout { get; }
	public bool IsClass { get; }
	public bool IsInterface { get; }
	public bool IsValueType { get; }
	public bool IsAbstract { get; }
	public bool IsSealed { get; }
	public virtual bool IsEnum { get; }
	public virtual bool IsSerializable { get; }
	public bool IsArray { get; }
	internal virtual bool IsSzArray { get; }
	public virtual bool IsGenericType { get; }
	public virtual bool IsGenericTypeDefinition { get; }
	public virtual bool IsGenericParameter { get; }
	public virtual int GenericParameterPosition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public bool IsByRef { get; }
	public bool IsPointer { get; }
	public bool IsPrimitive { get; }
	public bool IsCOMObject { get; }
	public bool HasElementType { get; }
	public bool IsContextful { get; }
	public bool IsMarshalByRef { get; }
	public abstract Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

	// RVA: 0xED9710 Offset: 0xED7D10 VA: 0x180ED9710 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2142930 Offset: 0x2140F30 VA: 0x182142930
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x2143C60 Offset: 0x2142260 VA: 0x182143C60 Slot: 18
	public virtual Type MakePointerType() { }

	// RVA: 0x2143BA0 Offset: 0x21421A0 VA: 0x182143BA0 Slot: 19
	public virtual Type MakeByRefType() { }

	// RVA: 0x2143B00 Offset: 0x2142100 VA: 0x182143B00 Slot: 20
	public virtual Type MakeArrayType() { }

	// RVA: 0x2143B50 Offset: 0x2142150 VA: 0x182143B50 Slot: 21
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x2142380 Offset: 0x2140980 VA: 0x182142380
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x2142220 Offset: 0x2140820 VA: 0x182142220 Slot: 22
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: 0x21440A0 Offset: 0x21426A0 VA: 0x1821440A0
	public static Binder get_DefaultBinder() { }

	// RVA: 0x21401C0 Offset: 0x213E7C0 VA: 0x1821401C0
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract override Module get_Module();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Assembly get_Assembly();

	// RVA: 0x21449E0 Offset: 0x2142FE0 VA: 0x1821449E0 Slot: 25
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x2142460 Offset: 0x2140A60 VA: 0x182142460
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_AssemblyQualifiedName();

	// RVA: 0x2140630 Offset: 0x213EC30 VA: 0x182140630 Slot: 29
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_BaseType();

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x2140950 Offset: 0x213EF50 VA: 0x182140950 Slot: 31
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x21407F0 Offset: 0x213EDF0 VA: 0x1821407F0 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x21406A0 Offset: 0x213ECA0 VA: 0x1821406A0 Slot: 33
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x2140AB0 Offset: 0x213F0B0 VA: 0x182140AB0 Slot: 35
	public ConstructorInfo[] GetConstructors() { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: -1 Offset: -1 Slot: 36
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x2141A00 Offset: 0x2140000 VA: 0x182141A00 Slot: 37
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2141860 Offset: 0x213FE60 VA: 0x182141860 Slot: 38
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x2141BB0 Offset: 0x21401B0 VA: 0x182141BB0 Slot: 39
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2141C60 Offset: 0x2140260 VA: 0x182141C60 Slot: 40
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x2141D10 Offset: 0x2140310 VA: 0x182141D10 Slot: 42
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: 0x2141570 Offset: 0x213FB70 VA: 0x182141570 Slot: 45
	public FieldInfo GetField(string name) { }

	// RVA: 0x2141590 Offset: 0x213FB90 VA: 0x182141590 Slot: 46
	public FieldInfo[] GetFields() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract Type[] GetInterfaces();

	// RVA: 0x2140380 Offset: 0x213E980 VA: 0x182140380 Slot: 49
	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) { }

	// RVA: -1 Offset: -1 Slot: 50
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: 0x2141E10 Offset: 0x2140410 VA: 0x182141E10 Slot: 51
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2142000 Offset: 0x2140600 VA: 0x182142000 Slot: 52
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2141F00 Offset: 0x2140500 VA: 0x182141F00 Slot: 53
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x21420B0 Offset: 0x21406B0 VA: 0x1821420B0 Slot: 54
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x2141D70 Offset: 0x2140370 VA: 0x182141D70 Slot: 55
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x2141D50 Offset: 0x2140350 VA: 0x182141D50 Slot: 58
	public PropertyInfo[] GetProperties() { }

	// RVA: 0x2141D30 Offset: 0x2140330 VA: 0x182141D30 Slot: 59
	public Type GetNestedType(string name) { }

	// RVA: -1 Offset: -1 Slot: 60
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x2141810 Offset: 0x213FE10 VA: 0x182141810 Slot: 61
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x2141830 Offset: 0x213FE30 VA: 0x182141830 Slot: 62
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x21417A0 Offset: 0x213FDA0 VA: 0x1821417A0 Slot: 63
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x21445C0 Offset: 0x2142BC0 VA: 0x1821445C0
	public bool get_IsNested() { }

	// RVA: 0x2143F20 Offset: 0x2142520 VA: 0x182143F20 Slot: 64
	public TypeAttributes get_Attributes() { }

	// RVA: 0x2144210 Offset: 0x2142810 VA: 0x182144210 Slot: 65
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x21447F0 Offset: 0x2142DF0 VA: 0x1821447F0
	public bool get_IsVisible() { }

	// RVA: 0x2144630 Offset: 0x2142C30 VA: 0x182144630 Slot: 66
	public bool get_IsNotPublic() { }

	// RVA: 0x2144690 Offset: 0x2142C90 VA: 0x182144690 Slot: 67
	public bool get_IsPublic() { }

	// RVA: 0x21445A0 Offset: 0x2142BA0 VA: 0x1821445A0 Slot: 68
	public bool get_IsNestedPublic() { }

	// RVA: 0x2144570 Offset: 0x2142B70 VA: 0x182144570 Slot: 69
	public bool get_IsNestedAssembly() { }

	// RVA: 0x2144460 Offset: 0x2142A60 VA: 0x182144460 Slot: 70
	public bool get_IsExplicitLayout() { }

	// RVA: 0x2144380 Offset: 0x2142980 VA: 0x182144380 Slot: 71
	public bool get_IsClass() { }

	// RVA: 0x2144480 Offset: 0x2142A80 VA: 0x182144480 Slot: 72
	public bool get_IsInterface() { }

	// RVA: 0x21447D0 Offset: 0x2142DD0 VA: 0x1821447D0 Slot: 73
	public bool get_IsValueType() { }

	// RVA: 0x21442F0 Offset: 0x21428F0 VA: 0x1821442F0 Slot: 74
	public bool get_IsAbstract() { }

	// RVA: 0x21446B0 Offset: 0x2142CB0 VA: 0x1821446B0 Slot: 75
	public bool get_IsSealed() { }

	// RVA: 0x21443F0 Offset: 0x21429F0 VA: 0x1821443F0 Slot: 76
	public virtual bool get_IsEnum() { }

	// RVA: 0x21446E0 Offset: 0x2142CE0 VA: 0x1821446E0 Slot: 77
	public virtual bool get_IsSerializable() { }

	// RVA: 0x2144320 Offset: 0x2142920 VA: 0x182144320 Slot: 78
	public bool get_IsArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 79
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 80
	public virtual bool get_IsGenericType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 81
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 82
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x2144260 Offset: 0x2142860 VA: 0x182144260 Slot: 83
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x2143F40 Offset: 0x2142540 VA: 0x182143F40 Slot: 84
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x2141620 Offset: 0x213FC20 VA: 0x182141620 Slot: 85
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x2144340 Offset: 0x2142940 VA: 0x182144340 Slot: 86
	public bool get_IsByRef() { }

	// RVA: 0x2144650 Offset: 0x2142C50 VA: 0x182144650 Slot: 87
	public bool get_IsPointer() { }

	// RVA: 0x2144670 Offset: 0x2142C70 VA: 0x182144670 Slot: 88
	public bool get_IsPrimitive() { }

	// RVA: 0x2144360 Offset: 0x2142960 VA: 0x182144360 Slot: 89
	public bool get_IsCOMObject() { }

	// RVA: 0x21442D0 Offset: 0x21428D0 VA: 0x1821442D0 Slot: 90
	public bool get_HasElementType() { }

	// RVA: 0x21443D0 Offset: 0x21429D0 VA: 0x1821443D0 Slot: 91
	public bool get_IsContextful() { }

	// RVA: 0x2144550 Offset: 0x2142B50 VA: 0x182144550 Slot: 92
	public bool get_IsMarshalByRef() { }

	// RVA: 0x2143A90 Offset: 0x2142090 VA: 0x182143A90 Slot: 93
	protected virtual bool IsValueTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 94
	protected abstract TypeAttributes GetAttributeFlagsImpl();

	// RVA: -1 Offset: -1 Slot: 95
	protected abstract bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 96
	protected abstract bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 97
	protected abstract bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 98
	protected abstract bool IsPrimitiveImpl();

	// RVA: -1 Offset: -1 Slot: 99
	protected abstract bool IsCOMObjectImpl();

	// RVA: 0x2143BF0 Offset: 0x21421F0 VA: 0x182143BF0 Slot: 100
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x2142E90 Offset: 0x2141490 VA: 0x182142E90 Slot: 101
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x21438F0 Offset: 0x2141EF0 VA: 0x1821438F0 Slot: 102
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 103
	public abstract Type GetElementType();

	// RVA: 0x21415B0 Offset: 0x213FBB0 VA: 0x1821415B0 Slot: 104
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x21416D0 Offset: 0x213FCD0 VA: 0x1821416D0 Slot: 105
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 106
	protected abstract bool HasElementTypeImpl();

	// RVA: 0x21421C0 Offset: 0x21407C0 VA: 0x1821421C0
	internal Type GetRootElementType() { }

	// RVA: 0x21412A0 Offset: 0x213F8A0 VA: 0x1821412A0 Slot: 107
	public virtual string[] GetEnumNames() { }

	// RVA: 0x21414B0 Offset: 0x213FAB0 VA: 0x1821414B0 Slot: 108
	public virtual Array GetEnumValues() { }

	// RVA: 0x2141360 Offset: 0x213F960 VA: 0x182141360
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x2140AD0 Offset: 0x213F0D0 VA: 0x182140AD0
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x2141390 Offset: 0x213F990 VA: 0x182141390 Slot: 109
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x2142F60 Offset: 0x2141560 VA: 0x182142F60 Slot: 110
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x2140F80 Offset: 0x213F580 VA: 0x182140F80 Slot: 111
	public virtual string GetEnumName(object value) { }

	// RVA: 0x2140090 Offset: 0x213E690 VA: 0x182140090
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x2143630 Offset: 0x2141C30 VA: 0x182143630
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x21439C0 Offset: 0x2141FC0 VA: 0x1821439C0 Slot: 113
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x21435F0 Offset: 0x2141BF0 VA: 0x1821435F0 Slot: 114
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x2142BF0 Offset: 0x21411F0 VA: 0x182142BF0 Slot: 115
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x2143590 Offset: 0x2141B90 VA: 0x182143590 Slot: 116
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x2142A50 Offset: 0x2141050 VA: 0x182142A50
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x21405C0 Offset: 0x213EBC0 VA: 0x1821405C0
	internal string FormatTypeName() { }

	// RVA: 0x21405E0 Offset: 0x213EBE0 VA: 0x1821405E0 Slot: 117
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x2143CB0 Offset: 0x21422B0 VA: 0x182143CB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21402F0 Offset: 0x213E8F0 VA: 0x1821402F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2140290 Offset: 0x213E890 VA: 0x182140290 Slot: 118
	public virtual bool Equals(Type o) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x12A4190 Offset: 0x12A2790 VA: 0x1812A4190
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x2141740 Offset: 0x213FD40 VA: 0x182141740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DC6A0 Offset: 0x10DACA0 VA: 0x1810DC6A0 Slot: 119
	public Type GetType() { }

	// RVA: 0x2144A40 Offset: 0x2143040 VA: 0x182144A40
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2142770 Offset: 0x2140D70 VA: 0x182142770
	public static Type GetType(string typeName) { }

	// RVA: 0x21426E0 Offset: 0x2140CE0 VA: 0x1821426E0
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x2142550 Offset: 0x2140B50 VA: 0x182142550
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x21423F0 Offset: 0x21409F0 VA: 0x1821423F0
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x2144A30 Offset: 0x2143030 VA: 0x182144A30
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x2143D00 Offset: 0x2142300 VA: 0x182143D00
	private static void .cctor() { }

}

