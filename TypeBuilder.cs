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

	// RVA: 0x18D7BA0 Offset: 0x18D61A0 VA: 0x1818D7BA0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18D7B50 Offset: 0x18D6150 VA: 0x1818D7B50 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18D7BF0 Offset: 0x18D61F0 VA: 0x1818D7BF0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18D7C40 Offset: 0x18D6240 VA: 0x1818D7C40 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18D7C90 Offset: 0x18D6290 VA: 0x1818D7C90 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D7CE0 Offset: 0x18D62E0 VA: 0x1818D7CE0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D7D30 Offset: 0x18D6330 VA: 0x1818D7D30 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18D77D0 Offset: 0x18D5DD0 VA: 0x1818D77D0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18D7D80 Offset: 0x18D6380 VA: 0x1818D7D80 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18D76E0 Offset: 0x18D5CE0 VA: 0x1818D76E0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18D7710 Offset: 0x18D5D10 VA: 0x1818D7710 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x18D7740 Offset: 0x18D5D40 VA: 0x1818D7740 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18D7770 Offset: 0x18D5D70 VA: 0x1818D7770 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D77A0 Offset: 0x18D5DA0 VA: 0x1818D77A0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D7820 Offset: 0x18D5E20 VA: 0x1818D7820 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7850 Offset: 0x18D5E50 VA: 0x1818D7850 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7880 Offset: 0x18D5E80 VA: 0x1818D7880 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18D78B0 Offset: 0x18D5EB0 VA: 0x1818D78B0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18D78E0 Offset: 0x18D5EE0 VA: 0x1818D78E0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D7910 Offset: 0x18D5F10 VA: 0x1818D7910 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18D7940 Offset: 0x18D5F40 VA: 0x1818D7940 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7970 Offset: 0x18D5F70 VA: 0x1818D7970 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18D79A0 Offset: 0x18D5FA0 VA: 0x1818D79A0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D79D0 Offset: 0x18D5FD0 VA: 0x1818D79D0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18D7A00 Offset: 0x18D6000 VA: 0x1818D7A00 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18D7A30 Offset: 0x18D6030 VA: 0x1818D7A30 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18D7A60 Offset: 0x18D6060 VA: 0x1818D7A60 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18D7A90 Offset: 0x18D6090 VA: 0x1818D7A90 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18D7AC0 Offset: 0x18D60C0 VA: 0x1818D7AC0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D7AF0 Offset: 0x18D60F0 VA: 0x1818D7AF0 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18D7B20 Offset: 0x18D6120 VA: 0x1818D7B20 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

