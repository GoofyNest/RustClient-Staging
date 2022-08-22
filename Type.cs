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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	protected void .ctor() { }

	// RVA: 0xED99D0 Offset: 0xED7FD0 VA: 0x180ED99D0 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 17
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2142A30 Offset: 0x2141030 VA: 0x182142A30
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x2143D60 Offset: 0x2142360 VA: 0x182143D60 Slot: 18
	public virtual Type MakePointerType() { }

	// RVA: 0x2143CA0 Offset: 0x21422A0 VA: 0x182143CA0 Slot: 19
	public virtual Type MakeByRefType() { }

	// RVA: 0x2143C00 Offset: 0x2142200 VA: 0x182143C00 Slot: 20
	public virtual Type MakeArrayType() { }

	// RVA: 0x2143C50 Offset: 0x2142250 VA: 0x182143C50 Slot: 21
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x2142480 Offset: 0x2140A80 VA: 0x182142480
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x2142320 Offset: 0x2140920 VA: 0x182142320 Slot: 22
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: 0x21441A0 Offset: 0x21427A0 VA: 0x1821441A0
	public static Binder get_DefaultBinder() { }

	// RVA: 0x21402C0 Offset: 0x213E8C0 VA: 0x1821402C0
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract override Module get_Module();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Assembly get_Assembly();

	// RVA: 0x2144AE0 Offset: 0x21430E0 VA: 0x182144AE0 Slot: 25
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x2142560 Offset: 0x2140B60 VA: 0x182142560
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_AssemblyQualifiedName();

	// RVA: 0x2140730 Offset: 0x213ED30 VA: 0x182140730 Slot: 29
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_BaseType();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2140A50 Offset: 0x213F050 VA: 0x182140A50 Slot: 31
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x21408F0 Offset: 0x213EEF0 VA: 0x1821408F0 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x21407A0 Offset: 0x213EDA0 VA: 0x1821407A0 Slot: 33
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2140BB0 Offset: 0x213F1B0 VA: 0x182140BB0 Slot: 35
	public ConstructorInfo[] GetConstructors() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: -1 Offset: -1 Slot: 36
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x2141B00 Offset: 0x2140100 VA: 0x182141B00 Slot: 37
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2141960 Offset: 0x213FF60 VA: 0x182141960 Slot: 38
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x2141CB0 Offset: 0x21402B0 VA: 0x182141CB0 Slot: 39
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2141D60 Offset: 0x2140360 VA: 0x182141D60 Slot: 40
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x2141E10 Offset: 0x2140410 VA: 0x182141E10 Slot: 42
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: 0x2141670 Offset: 0x213FC70 VA: 0x182141670 Slot: 45
	public FieldInfo GetField(string name) { }

	// RVA: 0x2141690 Offset: 0x213FC90 VA: 0x182141690 Slot: 46
	public FieldInfo[] GetFields() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract Type[] GetInterfaces();

	// RVA: 0x2140480 Offset: 0x213EA80 VA: 0x182140480 Slot: 49
	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) { }

	// RVA: -1 Offset: -1 Slot: 50
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: 0x2141F10 Offset: 0x2140510 VA: 0x182141F10 Slot: 51
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2142100 Offset: 0x2140700 VA: 0x182142100 Slot: 52
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2142000 Offset: 0x2140600 VA: 0x182142000 Slot: 53
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x21421B0 Offset: 0x21407B0 VA: 0x1821421B0 Slot: 54
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x2141E70 Offset: 0x2140470 VA: 0x182141E70 Slot: 55
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x2141E50 Offset: 0x2140450 VA: 0x182141E50 Slot: 58
	public PropertyInfo[] GetProperties() { }

	// RVA: 0x2141E30 Offset: 0x2140430 VA: 0x182141E30 Slot: 59
	public Type GetNestedType(string name) { }

	// RVA: -1 Offset: -1 Slot: 60
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x2141910 Offset: 0x213FF10 VA: 0x182141910 Slot: 61
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x2141930 Offset: 0x213FF30 VA: 0x182141930 Slot: 62
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x21418A0 Offset: 0x213FEA0 VA: 0x1821418A0 Slot: 63
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x21446C0 Offset: 0x2142CC0 VA: 0x1821446C0
	public bool get_IsNested() { }

	// RVA: 0x2144020 Offset: 0x2142620 VA: 0x182144020 Slot: 64
	public TypeAttributes get_Attributes() { }

	// RVA: 0x2144310 Offset: 0x2142910 VA: 0x182144310 Slot: 65
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x21448F0 Offset: 0x2142EF0 VA: 0x1821448F0
	public bool get_IsVisible() { }

	// RVA: 0x2144730 Offset: 0x2142D30 VA: 0x182144730 Slot: 66
	public bool get_IsNotPublic() { }

	// RVA: 0x2144790 Offset: 0x2142D90 VA: 0x182144790 Slot: 67
	public bool get_IsPublic() { }

	// RVA: 0x21446A0 Offset: 0x2142CA0 VA: 0x1821446A0 Slot: 68
	public bool get_IsNestedPublic() { }

	// RVA: 0x2144670 Offset: 0x2142C70 VA: 0x182144670 Slot: 69
	public bool get_IsNestedAssembly() { }

	// RVA: 0x2144560 Offset: 0x2142B60 VA: 0x182144560 Slot: 70
	public bool get_IsExplicitLayout() { }

	// RVA: 0x2144480 Offset: 0x2142A80 VA: 0x182144480 Slot: 71
	public bool get_IsClass() { }

	// RVA: 0x2144580 Offset: 0x2142B80 VA: 0x182144580 Slot: 72
	public bool get_IsInterface() { }

	// RVA: 0x21448D0 Offset: 0x2142ED0 VA: 0x1821448D0 Slot: 73
	public bool get_IsValueType() { }

	// RVA: 0x21443F0 Offset: 0x21429F0 VA: 0x1821443F0 Slot: 74
	public bool get_IsAbstract() { }

	// RVA: 0x21447B0 Offset: 0x2142DB0 VA: 0x1821447B0 Slot: 75
	public bool get_IsSealed() { }

	// RVA: 0x21444F0 Offset: 0x2142AF0 VA: 0x1821444F0 Slot: 76
	public virtual bool get_IsEnum() { }

	// RVA: 0x21447E0 Offset: 0x2142DE0 VA: 0x1821447E0 Slot: 77
	public virtual bool get_IsSerializable() { }

	// RVA: 0x2144420 Offset: 0x2142A20 VA: 0x182144420 Slot: 78
	public bool get_IsArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 79
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 80
	public virtual bool get_IsGenericType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 81
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 82
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x2144360 Offset: 0x2142960 VA: 0x182144360 Slot: 83
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x2144040 Offset: 0x2142640 VA: 0x182144040 Slot: 84
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x2141720 Offset: 0x213FD20 VA: 0x182141720 Slot: 85
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x2144440 Offset: 0x2142A40 VA: 0x182144440 Slot: 86
	public bool get_IsByRef() { }

	// RVA: 0x2144750 Offset: 0x2142D50 VA: 0x182144750 Slot: 87
	public bool get_IsPointer() { }

	// RVA: 0x2144770 Offset: 0x2142D70 VA: 0x182144770 Slot: 88
	public bool get_IsPrimitive() { }

	// RVA: 0x2144460 Offset: 0x2142A60 VA: 0x182144460 Slot: 89
	public bool get_IsCOMObject() { }

	// RVA: 0x21443D0 Offset: 0x21429D0 VA: 0x1821443D0 Slot: 90
	public bool get_HasElementType() { }

	// RVA: 0x21444D0 Offset: 0x2142AD0 VA: 0x1821444D0 Slot: 91
	public bool get_IsContextful() { }

	// RVA: 0x2144650 Offset: 0x2142C50 VA: 0x182144650 Slot: 92
	public bool get_IsMarshalByRef() { }

	// RVA: 0x2143B90 Offset: 0x2142190 VA: 0x182143B90 Slot: 93
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

	// RVA: 0x2143CF0 Offset: 0x21422F0 VA: 0x182143CF0 Slot: 100
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x2142F90 Offset: 0x2141590 VA: 0x182142F90 Slot: 101
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x21439F0 Offset: 0x2141FF0 VA: 0x1821439F0 Slot: 102
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 103
	public abstract Type GetElementType();

	// RVA: 0x21416B0 Offset: 0x213FCB0 VA: 0x1821416B0 Slot: 104
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x21417D0 Offset: 0x213FDD0 VA: 0x1821417D0 Slot: 105
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 106
	protected abstract bool HasElementTypeImpl();

	// RVA: 0x21422C0 Offset: 0x21408C0 VA: 0x1821422C0
	internal Type GetRootElementType() { }

	// RVA: 0x21413A0 Offset: 0x213F9A0 VA: 0x1821413A0 Slot: 107
	public virtual string[] GetEnumNames() { }

	// RVA: 0x21415B0 Offset: 0x213FBB0 VA: 0x1821415B0 Slot: 108
	public virtual Array GetEnumValues() { }

	// RVA: 0x2141460 Offset: 0x213FA60 VA: 0x182141460
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x2140BD0 Offset: 0x213F1D0 VA: 0x182140BD0
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x2141490 Offset: 0x213FA90 VA: 0x182141490 Slot: 109
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x2143060 Offset: 0x2141660 VA: 0x182143060 Slot: 110
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x2141080 Offset: 0x213F680 VA: 0x182141080 Slot: 111
	public virtual string GetEnumName(object value) { }

	// RVA: 0x2140190 Offset: 0x213E790 VA: 0x182140190
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x2143730 Offset: 0x2141D30 VA: 0x182143730
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2143AC0 Offset: 0x21420C0 VA: 0x182143AC0 Slot: 113
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x21436F0 Offset: 0x2141CF0 VA: 0x1821436F0 Slot: 114
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x2142CF0 Offset: 0x21412F0 VA: 0x182142CF0 Slot: 115
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x2143690 Offset: 0x2141C90 VA: 0x182143690 Slot: 116
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x2142B50 Offset: 0x2141150 VA: 0x182142B50
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x21406C0 Offset: 0x213ECC0 VA: 0x1821406C0
	internal string FormatTypeName() { }

	// RVA: 0x21406E0 Offset: 0x213ECE0 VA: 0x1821406E0 Slot: 117
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x2143DB0 Offset: 0x21423B0 VA: 0x182143DB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21403F0 Offset: 0x213E9F0 VA: 0x1821403F0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2140390 Offset: 0x213E990 VA: 0x182140390 Slot: 118
	public virtual bool Equals(Type o) { }

	// RVA: 0xAE5CA0 Offset: 0xAE42A0 VA: 0x180AE5CA0
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x12A4450 Offset: 0x12A2A50 VA: 0x1812A4450
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x2141840 Offset: 0x213FE40 VA: 0x182141840 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DC960 Offset: 0x10DAF60 VA: 0x1810DC960 Slot: 119
	public Type GetType() { }

	// RVA: 0x2144B40 Offset: 0x2143140 VA: 0x182144B40
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2142870 Offset: 0x2140E70 VA: 0x182142870
	public static Type GetType(string typeName) { }

	// RVA: 0x21427E0 Offset: 0x2140DE0 VA: 0x1821427E0
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x2142650 Offset: 0x2140C50 VA: 0x182142650
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x21424F0 Offset: 0x2140AF0 VA: 0x1821424F0
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x2144B30 Offset: 0x2143130 VA: 0x182144B30
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x2143E00 Offset: 0x2142400 VA: 0x182143E00
	private static void .cctor() { }

}

