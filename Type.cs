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

	// RVA: 0x2142770 Offset: 0x2140D70 VA: 0x182142770
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x2143AA0 Offset: 0x21420A0 VA: 0x182143AA0 Slot: 18
	public virtual Type MakePointerType() { }

	// RVA: 0x21439E0 Offset: 0x2141FE0 VA: 0x1821439E0 Slot: 19
	public virtual Type MakeByRefType() { }

	// RVA: 0x2143940 Offset: 0x2141F40 VA: 0x182143940 Slot: 20
	public virtual Type MakeArrayType() { }

	// RVA: 0x2143990 Offset: 0x2141F90 VA: 0x182143990 Slot: 21
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x21421C0 Offset: 0x21407C0 VA: 0x1821421C0
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x2142060 Offset: 0x2140660 VA: 0x182142060 Slot: 22
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: 0x2143EE0 Offset: 0x21424E0 VA: 0x182143EE0
	public static Binder get_DefaultBinder() { }

	// RVA: 0x2140000 Offset: 0x213E600 VA: 0x182140000
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract override Module get_Module();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Assembly get_Assembly();

	// RVA: 0x2144820 Offset: 0x2142E20 VA: 0x182144820 Slot: 25
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x21422A0 Offset: 0x21408A0 VA: 0x1821422A0
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_AssemblyQualifiedName();

	// RVA: 0x2140470 Offset: 0x213EA70 VA: 0x182140470 Slot: 29
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_BaseType();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2140790 Offset: 0x213ED90 VA: 0x182140790 Slot: 31
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2140630 Offset: 0x213EC30 VA: 0x182140630 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x21404E0 Offset: 0x213EAE0 VA: 0x1821404E0 Slot: 33
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x21408F0 Offset: 0x213EEF0 VA: 0x1821408F0 Slot: 35
	public ConstructorInfo[] GetConstructors() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: -1 Offset: -1 Slot: 36
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x2141840 Offset: 0x213FE40 VA: 0x182141840 Slot: 37
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x21416A0 Offset: 0x213FCA0 VA: 0x1821416A0 Slot: 38
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x21419F0 Offset: 0x213FFF0 VA: 0x1821419F0 Slot: 39
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2141AA0 Offset: 0x21400A0 VA: 0x182141AA0 Slot: 40
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x2141B50 Offset: 0x2140150 VA: 0x182141B50 Slot: 42
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: 0x21413B0 Offset: 0x213F9B0 VA: 0x1821413B0 Slot: 45
	public FieldInfo GetField(string name) { }

	// RVA: 0x21413D0 Offset: 0x213F9D0 VA: 0x1821413D0 Slot: 46
	public FieldInfo[] GetFields() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract Type[] GetInterfaces();

	// RVA: 0x21401C0 Offset: 0x213E7C0 VA: 0x1821401C0 Slot: 49
	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) { }

	// RVA: -1 Offset: -1 Slot: 50
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: 0x2141C50 Offset: 0x2140250 VA: 0x182141C50 Slot: 51
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2141E40 Offset: 0x2140440 VA: 0x182141E40 Slot: 52
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2141D40 Offset: 0x2140340 VA: 0x182141D40 Slot: 53
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x2141EF0 Offset: 0x21404F0 VA: 0x182141EF0 Slot: 54
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x2141BB0 Offset: 0x21401B0 VA: 0x182141BB0 Slot: 55
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x2141B90 Offset: 0x2140190 VA: 0x182141B90 Slot: 58
	public PropertyInfo[] GetProperties() { }

	// RVA: 0x2141B70 Offset: 0x2140170 VA: 0x182141B70 Slot: 59
	public Type GetNestedType(string name) { }

	// RVA: -1 Offset: -1 Slot: 60
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x2141650 Offset: 0x213FC50 VA: 0x182141650 Slot: 61
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x2141670 Offset: 0x213FC70 VA: 0x182141670 Slot: 62
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x21415E0 Offset: 0x213FBE0 VA: 0x1821415E0 Slot: 63
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x2144400 Offset: 0x2142A00 VA: 0x182144400
	public bool get_IsNested() { }

	// RVA: 0x2143D60 Offset: 0x2142360 VA: 0x182143D60 Slot: 64
	public TypeAttributes get_Attributes() { }

	// RVA: 0x2144050 Offset: 0x2142650 VA: 0x182144050 Slot: 65
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x2144630 Offset: 0x2142C30 VA: 0x182144630
	public bool get_IsVisible() { }

	// RVA: 0x2144470 Offset: 0x2142A70 VA: 0x182144470 Slot: 66
	public bool get_IsNotPublic() { }

	// RVA: 0x21444D0 Offset: 0x2142AD0 VA: 0x1821444D0 Slot: 67
	public bool get_IsPublic() { }

	// RVA: 0x21443E0 Offset: 0x21429E0 VA: 0x1821443E0 Slot: 68
	public bool get_IsNestedPublic() { }

	// RVA: 0x21443B0 Offset: 0x21429B0 VA: 0x1821443B0 Slot: 69
	public bool get_IsNestedAssembly() { }

	// RVA: 0x21442A0 Offset: 0x21428A0 VA: 0x1821442A0 Slot: 70
	public bool get_IsExplicitLayout() { }

	// RVA: 0x21441C0 Offset: 0x21427C0 VA: 0x1821441C0 Slot: 71
	public bool get_IsClass() { }

	// RVA: 0x21442C0 Offset: 0x21428C0 VA: 0x1821442C0 Slot: 72
	public bool get_IsInterface() { }

	// RVA: 0x2144610 Offset: 0x2142C10 VA: 0x182144610 Slot: 73
	public bool get_IsValueType() { }

	// RVA: 0x2144130 Offset: 0x2142730 VA: 0x182144130 Slot: 74
	public bool get_IsAbstract() { }

	// RVA: 0x21444F0 Offset: 0x2142AF0 VA: 0x1821444F0 Slot: 75
	public bool get_IsSealed() { }

	// RVA: 0x2144230 Offset: 0x2142830 VA: 0x182144230 Slot: 76
	public virtual bool get_IsEnum() { }

	// RVA: 0x2144520 Offset: 0x2142B20 VA: 0x182144520 Slot: 77
	public virtual bool get_IsSerializable() { }

	// RVA: 0x2144160 Offset: 0x2142760 VA: 0x182144160 Slot: 78
	public bool get_IsArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 79
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 80
	public virtual bool get_IsGenericType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 81
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 82
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x21440A0 Offset: 0x21426A0 VA: 0x1821440A0 Slot: 83
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x2143D80 Offset: 0x2142380 VA: 0x182143D80 Slot: 84
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x2141460 Offset: 0x213FA60 VA: 0x182141460 Slot: 85
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x2144180 Offset: 0x2142780 VA: 0x182144180 Slot: 86
	public bool get_IsByRef() { }

	// RVA: 0x2144490 Offset: 0x2142A90 VA: 0x182144490 Slot: 87
	public bool get_IsPointer() { }

	// RVA: 0x21444B0 Offset: 0x2142AB0 VA: 0x1821444B0 Slot: 88
	public bool get_IsPrimitive() { }

	// RVA: 0x21441A0 Offset: 0x21427A0 VA: 0x1821441A0 Slot: 89
	public bool get_IsCOMObject() { }

	// RVA: 0x2144110 Offset: 0x2142710 VA: 0x182144110 Slot: 90
	public bool get_HasElementType() { }

	// RVA: 0x2144210 Offset: 0x2142810 VA: 0x182144210 Slot: 91
	public bool get_IsContextful() { }

	// RVA: 0x2144390 Offset: 0x2142990 VA: 0x182144390 Slot: 92
	public bool get_IsMarshalByRef() { }

	// RVA: 0x21438D0 Offset: 0x2141ED0 VA: 0x1821438D0 Slot: 93
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

	// RVA: 0x2143A30 Offset: 0x2142030 VA: 0x182143A30 Slot: 100
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x2142CD0 Offset: 0x21412D0 VA: 0x182142CD0 Slot: 101
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x2143730 Offset: 0x2141D30 VA: 0x182143730 Slot: 102
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 103
	public abstract Type GetElementType();

	// RVA: 0x21413F0 Offset: 0x213F9F0 VA: 0x1821413F0 Slot: 104
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x2141510 Offset: 0x213FB10 VA: 0x182141510 Slot: 105
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 106
	protected abstract bool HasElementTypeImpl();

	// RVA: 0x2142000 Offset: 0x2140600 VA: 0x182142000
	internal Type GetRootElementType() { }

	// RVA: 0x21410E0 Offset: 0x213F6E0 VA: 0x1821410E0 Slot: 107
	public virtual string[] GetEnumNames() { }

	// RVA: 0x21412F0 Offset: 0x213F8F0 VA: 0x1821412F0 Slot: 108
	public virtual Array GetEnumValues() { }

	// RVA: 0x21411A0 Offset: 0x213F7A0 VA: 0x1821411A0
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x2140910 Offset: 0x213EF10 VA: 0x182140910
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x21411D0 Offset: 0x213F7D0 VA: 0x1821411D0 Slot: 109
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x2142DA0 Offset: 0x21413A0 VA: 0x182142DA0 Slot: 110
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x2140DC0 Offset: 0x213F3C0 VA: 0x182140DC0 Slot: 111
	public virtual string GetEnumName(object value) { }

	// RVA: 0x213FED0 Offset: 0x213E4D0 VA: 0x18213FED0
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x2143470 Offset: 0x2141A70 VA: 0x182143470
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2143800 Offset: 0x2141E00 VA: 0x182143800 Slot: 113
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x2143430 Offset: 0x2141A30 VA: 0x182143430 Slot: 114
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x2142A30 Offset: 0x2141030 VA: 0x182142A30 Slot: 115
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x21433D0 Offset: 0x21419D0 VA: 0x1821433D0 Slot: 116
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x2142890 Offset: 0x2140E90 VA: 0x182142890
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x2140400 Offset: 0x213EA00 VA: 0x182140400
	internal string FormatTypeName() { }

	// RVA: 0x2140420 Offset: 0x213EA20 VA: 0x182140420 Slot: 117
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x2143AF0 Offset: 0x21420F0 VA: 0x182143AF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2140130 Offset: 0x213E730 VA: 0x182140130 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x21400D0 Offset: 0x213E6D0 VA: 0x1821400D0 Slot: 118
	public virtual bool Equals(Type o) { }

	// RVA: 0xAE59E0 Offset: 0xAE3FE0 VA: 0x180AE59E0
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x12A4190 Offset: 0x12A2790 VA: 0x1812A4190
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x2141580 Offset: 0x213FB80 VA: 0x182141580 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DC6A0 Offset: 0x10DACA0 VA: 0x1810DC6A0 Slot: 119
	public Type GetType() { }

	// RVA: 0x2144880 Offset: 0x2142E80 VA: 0x182144880
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x21425B0 Offset: 0x2140BB0 VA: 0x1821425B0
	public static Type GetType(string typeName) { }

	// RVA: 0x2142520 Offset: 0x2140B20 VA: 0x182142520
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x2142390 Offset: 0x2140990 VA: 0x182142390
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2142230 Offset: 0x2140830 VA: 0x182142230
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x2144870 Offset: 0x2142E70 VA: 0x182144870
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x2143B40 Offset: 0x2142140 VA: 0x182143B40
	private static void .cctor() { }

}

