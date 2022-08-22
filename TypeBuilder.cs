public abstract class TypeBuilder : TypeInfo // TypeDefIndex: 613
{
// Namespace: System.Reflection.Emit
public abstract class TypeBuilder : TypeInfo // TypeDefIndex: 613
	// Fields
	public const int UnspecifiedTypeSize = 0;

	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x18D7540 Offset: 0x18D5B40 VA: 0x1818D7540 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18D74F0 Offset: 0x18D5AF0 VA: 0x1818D74F0 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18D7590 Offset: 0x18D5B90 VA: 0x1818D7590 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18D75E0 Offset: 0x18D5BE0 VA: 0x1818D75E0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18D7630 Offset: 0x18D5C30 VA: 0x1818D7630 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D7680 Offset: 0x18D5C80 VA: 0x1818D7680 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D76D0 Offset: 0x18D5CD0 VA: 0x1818D76D0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18D7170 Offset: 0x18D5770 VA: 0x1818D7170 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18D7720 Offset: 0x18D5D20 VA: 0x1818D7720 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18D7080 Offset: 0x18D5680 VA: 0x1818D7080 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18D70B0 Offset: 0x18D56B0 VA: 0x1818D70B0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18D70E0 Offset: 0x18D56E0 VA: 0x1818D70E0 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18D7110 Offset: 0x18D5710 VA: 0x1818D7110 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D7140 Offset: 0x18D5740 VA: 0x1818D7140 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D71C0 Offset: 0x18D57C0 VA: 0x1818D71C0 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D71F0 Offset: 0x18D57F0 VA: 0x1818D71F0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7220 Offset: 0x18D5820 VA: 0x1818D7220 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18D7250 Offset: 0x18D5850 VA: 0x1818D7250 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18D7280 Offset: 0x18D5880 VA: 0x1818D7280 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D72B0 Offset: 0x18D58B0 VA: 0x1818D72B0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18D72E0 Offset: 0x18D58E0 VA: 0x1818D72E0 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7310 Offset: 0x18D5910 VA: 0x1818D7310 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18D7340 Offset: 0x18D5940 VA: 0x1818D7340 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D7370 Offset: 0x18D5970 VA: 0x1818D7370 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18D73A0 Offset: 0x18D59A0 VA: 0x1818D73A0 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18D73D0 Offset: 0x18D59D0 VA: 0x1818D73D0 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18D7400 Offset: 0x18D5A00 VA: 0x1818D7400 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18D7430 Offset: 0x18D5A30 VA: 0x1818D7430 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18D7460 Offset: 0x18D5A60 VA: 0x1818D7460 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D7490 Offset: 0x18D5A90 VA: 0x1818D7490 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18D74C0 Offset: 0x18D5AC0 VA: 0x1818D74C0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

