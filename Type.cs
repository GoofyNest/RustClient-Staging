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

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	protected void .ctor() { }

	// RVA: 0xEDA480 Offset: 0xED8A80 VA: 0x180EDA480 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 17
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x2143250 Offset: 0x2141850 VA: 0x182143250
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x2144580 Offset: 0x2142B80 VA: 0x182144580 Slot: 18
	public virtual Type MakePointerType() { }

	// RVA: 0x21444C0 Offset: 0x2142AC0 VA: 0x1821444C0 Slot: 19
	public virtual Type MakeByRefType() { }

	// RVA: 0x2144420 Offset: 0x2142A20 VA: 0x182144420 Slot: 20
	public virtual Type MakeArrayType() { }

	// RVA: 0x2144470 Offset: 0x2142A70 VA: 0x182144470 Slot: 21
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x2142CA0 Offset: 0x21412A0 VA: 0x182142CA0
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x2142B40 Offset: 0x2141140 VA: 0x182142B40 Slot: 22
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: 0x21449C0 Offset: 0x2142FC0 VA: 0x1821449C0
	public static Binder get_DefaultBinder() { }

	// RVA: 0x2140AE0 Offset: 0x213F0E0 VA: 0x182140AE0
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract override Module get_Module();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract Assembly get_Assembly();

	// RVA: 0x2145300 Offset: 0x2143900 VA: 0x182145300 Slot: 25
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x2142D80 Offset: 0x2141380 VA: 0x182142D80
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_AssemblyQualifiedName();

	// RVA: 0x2140F50 Offset: 0x213F550 VA: 0x182140F50 Slot: 29
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_BaseType();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2141270 Offset: 0x213F870 VA: 0x182141270 Slot: 31
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2141110 Offset: 0x213F710 VA: 0x182141110 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x2140FC0 Offset: 0x213F5C0 VA: 0x182140FC0 Slot: 33
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x21413D0 Offset: 0x213F9D0 VA: 0x1821413D0 Slot: 35
	public ConstructorInfo[] GetConstructors() { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: -1 Offset: -1 Slot: 36
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x2142320 Offset: 0x2140920 VA: 0x182142320 Slot: 37
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2142180 Offset: 0x2140780 VA: 0x182142180 Slot: 38
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x21424D0 Offset: 0x2140AD0 VA: 0x1821424D0 Slot: 39
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2142580 Offset: 0x2140B80 VA: 0x182142580 Slot: 40
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x2142630 Offset: 0x2140C30 VA: 0x182142630 Slot: 42
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: 0x2141E90 Offset: 0x2140490 VA: 0x182141E90 Slot: 45
	public FieldInfo GetField(string name) { }

	// RVA: 0x2141EB0 Offset: 0x21404B0 VA: 0x182141EB0 Slot: 46
	public FieldInfo[] GetFields() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract Type[] GetInterfaces();

	// RVA: 0x2140CA0 Offset: 0x213F2A0 VA: 0x182140CA0 Slot: 49
	public virtual Type[] FindInterfaces(TypeFilter filter, object filterCriteria) { }

	// RVA: -1 Offset: -1 Slot: 50
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: 0x2142730 Offset: 0x2140D30 VA: 0x182142730 Slot: 51
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x2142920 Offset: 0x2140F20 VA: 0x182142920 Slot: 52
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x2142820 Offset: 0x2140E20 VA: 0x182142820 Slot: 53
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x21429D0 Offset: 0x2140FD0 VA: 0x1821429D0 Slot: 54
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x2142690 Offset: 0x2140C90 VA: 0x182142690 Slot: 55
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x2142670 Offset: 0x2140C70 VA: 0x182142670 Slot: 58
	public PropertyInfo[] GetProperties() { }

	// RVA: 0x2142650 Offset: 0x2140C50 VA: 0x182142650 Slot: 59
	public Type GetNestedType(string name) { }

	// RVA: -1 Offset: -1 Slot: 60
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x2142130 Offset: 0x2140730 VA: 0x182142130 Slot: 61
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x2142150 Offset: 0x2140750 VA: 0x182142150 Slot: 62
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x21420C0 Offset: 0x21406C0 VA: 0x1821420C0 Slot: 63
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x2144EE0 Offset: 0x21434E0 VA: 0x182144EE0
	public bool get_IsNested() { }

	// RVA: 0x2144840 Offset: 0x2142E40 VA: 0x182144840 Slot: 64
	public TypeAttributes get_Attributes() { }

	// RVA: 0x2144B30 Offset: 0x2143130 VA: 0x182144B30 Slot: 65
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x2145110 Offset: 0x2143710 VA: 0x182145110
	public bool get_IsVisible() { }

	// RVA: 0x2144F50 Offset: 0x2143550 VA: 0x182144F50 Slot: 66
	public bool get_IsNotPublic() { }

	// RVA: 0x2144FB0 Offset: 0x21435B0 VA: 0x182144FB0 Slot: 67
	public bool get_IsPublic() { }

	// RVA: 0x2144EC0 Offset: 0x21434C0 VA: 0x182144EC0 Slot: 68
	public bool get_IsNestedPublic() { }

	// RVA: 0x2144E90 Offset: 0x2143490 VA: 0x182144E90 Slot: 69
	public bool get_IsNestedAssembly() { }

	// RVA: 0x2144D80 Offset: 0x2143380 VA: 0x182144D80 Slot: 70
	public bool get_IsExplicitLayout() { }

	// RVA: 0x2144CA0 Offset: 0x21432A0 VA: 0x182144CA0 Slot: 71
	public bool get_IsClass() { }

	// RVA: 0x2144DA0 Offset: 0x21433A0 VA: 0x182144DA0 Slot: 72
	public bool get_IsInterface() { }

	// RVA: 0x21450F0 Offset: 0x21436F0 VA: 0x1821450F0 Slot: 73
	public bool get_IsValueType() { }

	// RVA: 0x2144C10 Offset: 0x2143210 VA: 0x182144C10 Slot: 74
	public bool get_IsAbstract() { }

	// RVA: 0x2144FD0 Offset: 0x21435D0 VA: 0x182144FD0 Slot: 75
	public bool get_IsSealed() { }

	// RVA: 0x2144D10 Offset: 0x2143310 VA: 0x182144D10 Slot: 76
	public virtual bool get_IsEnum() { }

	// RVA: 0x2145000 Offset: 0x2143600 VA: 0x182145000 Slot: 77
	public virtual bool get_IsSerializable() { }

	// RVA: 0x2144C40 Offset: 0x2143240 VA: 0x182144C40 Slot: 78
	public bool get_IsArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 79
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 80
	public virtual bool get_IsGenericType() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 81
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 82
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x2144B80 Offset: 0x2143180 VA: 0x182144B80 Slot: 83
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x2144860 Offset: 0x2142E60 VA: 0x182144860 Slot: 84
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x2141F40 Offset: 0x2140540 VA: 0x182141F40 Slot: 85
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x2144C60 Offset: 0x2143260 VA: 0x182144C60 Slot: 86
	public bool get_IsByRef() { }

	// RVA: 0x2144F70 Offset: 0x2143570 VA: 0x182144F70 Slot: 87
	public bool get_IsPointer() { }

	// RVA: 0x2144F90 Offset: 0x2143590 VA: 0x182144F90 Slot: 88
	public bool get_IsPrimitive() { }

	// RVA: 0x2144C80 Offset: 0x2143280 VA: 0x182144C80 Slot: 89
	public bool get_IsCOMObject() { }

	// RVA: 0x2144BF0 Offset: 0x21431F0 VA: 0x182144BF0 Slot: 90
	public bool get_HasElementType() { }

	// RVA: 0x2144CF0 Offset: 0x21432F0 VA: 0x182144CF0 Slot: 91
	public bool get_IsContextful() { }

	// RVA: 0x2144E70 Offset: 0x2143470 VA: 0x182144E70 Slot: 92
	public bool get_IsMarshalByRef() { }

	// RVA: 0x21443B0 Offset: 0x21429B0 VA: 0x1821443B0 Slot: 93
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

	// RVA: 0x2144510 Offset: 0x2142B10 VA: 0x182144510 Slot: 100
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x21437B0 Offset: 0x2141DB0 VA: 0x1821437B0 Slot: 101
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x2144210 Offset: 0x2142810 VA: 0x182144210 Slot: 102
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 103
	public abstract Type GetElementType();

	// RVA: 0x2141ED0 Offset: 0x21404D0 VA: 0x182141ED0 Slot: 104
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x2141FF0 Offset: 0x21405F0 VA: 0x182141FF0 Slot: 105
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 106
	protected abstract bool HasElementTypeImpl();

	// RVA: 0x2142AE0 Offset: 0x21410E0 VA: 0x182142AE0
	internal Type GetRootElementType() { }

	// RVA: 0x2141BC0 Offset: 0x21401C0 VA: 0x182141BC0 Slot: 107
	public virtual string[] GetEnumNames() { }

	// RVA: 0x2141DD0 Offset: 0x21403D0 VA: 0x182141DD0 Slot: 108
	public virtual Array GetEnumValues() { }

	// RVA: 0x2141C80 Offset: 0x2140280 VA: 0x182141C80
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x21413F0 Offset: 0x213F9F0 VA: 0x1821413F0
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x2141CB0 Offset: 0x21402B0 VA: 0x182141CB0 Slot: 109
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x2143880 Offset: 0x2141E80 VA: 0x182143880 Slot: 110
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x21418A0 Offset: 0x213FEA0 VA: 0x1821418A0 Slot: 111
	public virtual string GetEnumName(object value) { }

	// RVA: 0x21409B0 Offset: 0x213EFB0 VA: 0x1821409B0
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x2143F50 Offset: 0x2142550 VA: 0x182143F50
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x21442E0 Offset: 0x21428E0 VA: 0x1821442E0 Slot: 113
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x2143F10 Offset: 0x2142510 VA: 0x182143F10 Slot: 114
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x2143510 Offset: 0x2141B10 VA: 0x182143510 Slot: 115
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x2143EB0 Offset: 0x21424B0 VA: 0x182143EB0 Slot: 116
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x2143370 Offset: 0x2141970 VA: 0x182143370
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x2140EE0 Offset: 0x213F4E0 VA: 0x182140EE0
	internal string FormatTypeName() { }

	// RVA: 0x2140F00 Offset: 0x213F500 VA: 0x182140F00 Slot: 117
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x21445D0 Offset: 0x2142BD0 VA: 0x1821445D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2140C10 Offset: 0x213F210 VA: 0x182140C10 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2140BB0 Offset: 0x213F1B0 VA: 0x182140BB0 Slot: 118
	public virtual bool Equals(Type o) { }

	// RVA: 0xAE6170 Offset: 0xAE4770 VA: 0x180AE6170
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x12A4AF0 Offset: 0x12A30F0 VA: 0x1812A4AF0
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x2142060 Offset: 0x2140660 VA: 0x182142060 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DD3D0 Offset: 0x10DB9D0 VA: 0x1810DD3D0 Slot: 119
	public Type GetType() { }

	// RVA: 0x2145360 Offset: 0x2143960 VA: 0x182145360
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2143090 Offset: 0x2141690 VA: 0x182143090
	public static Type GetType(string typeName) { }

	// RVA: 0x2143000 Offset: 0x2141600 VA: 0x182143000
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x2142E70 Offset: 0x2141470 VA: 0x182142E70
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x2142D10 Offset: 0x2141310 VA: 0x182142D10
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x2145350 Offset: 0x2143950 VA: 0x182145350
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x2144620 Offset: 0x2142C20 VA: 0x182144620
	private static void .cctor() { }

}

