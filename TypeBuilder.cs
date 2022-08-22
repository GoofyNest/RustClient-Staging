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

	// RVA: 0x18D7E20 Offset: 0x18D6420 VA: 0x1818D7E20 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18D7DD0 Offset: 0x18D63D0 VA: 0x1818D7DD0 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18D7E70 Offset: 0x18D6470 VA: 0x1818D7E70 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18D7EC0 Offset: 0x18D64C0 VA: 0x1818D7EC0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18D7F10 Offset: 0x18D6510 VA: 0x1818D7F10 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D7F60 Offset: 0x18D6560 VA: 0x1818D7F60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D7FB0 Offset: 0x18D65B0 VA: 0x1818D7FB0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18D7A50 Offset: 0x18D6050 VA: 0x1818D7A50 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18D8000 Offset: 0x18D6600 VA: 0x1818D8000 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18D7960 Offset: 0x18D5F60 VA: 0x1818D7960 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18D7990 Offset: 0x18D5F90 VA: 0x1818D7990 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18D79C0 Offset: 0x18D5FC0 VA: 0x1818D79C0 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18D79F0 Offset: 0x18D5FF0 VA: 0x1818D79F0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D7A20 Offset: 0x18D6020 VA: 0x1818D7A20 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D7AA0 Offset: 0x18D60A0 VA: 0x1818D7AA0 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7AD0 Offset: 0x18D60D0 VA: 0x1818D7AD0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7B00 Offset: 0x18D6100 VA: 0x1818D7B00 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18D7B30 Offset: 0x18D6130 VA: 0x1818D7B30 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18D7B60 Offset: 0x18D6160 VA: 0x1818D7B60 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D7B90 Offset: 0x18D6190 VA: 0x1818D7B90 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18D7BC0 Offset: 0x18D61C0 VA: 0x1818D7BC0 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7BF0 Offset: 0x18D61F0 VA: 0x1818D7BF0 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18D7C20 Offset: 0x18D6220 VA: 0x1818D7C20 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D7C50 Offset: 0x18D6250 VA: 0x1818D7C50 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18D7C80 Offset: 0x18D6280 VA: 0x1818D7C80 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18D7CB0 Offset: 0x18D62B0 VA: 0x1818D7CB0 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18D7CE0 Offset: 0x18D62E0 VA: 0x1818D7CE0 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18D7D10 Offset: 0x18D6310 VA: 0x1818D7D10 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18D7D40 Offset: 0x18D6340 VA: 0x1818D7D40 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D7D70 Offset: 0x18D6370 VA: 0x1818D7D70 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18D7DA0 Offset: 0x18D63A0 VA: 0x1818D7DA0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

