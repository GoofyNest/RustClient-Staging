public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 605
{	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x18C9E20 Offset: 0x18C8420 VA: 0x1818C9E20 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18C9DD0 Offset: 0x18C83D0 VA: 0x1818C9DD0 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18C9E70 Offset: 0x18C8470 VA: 0x1818C9E70 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18C9EC0 Offset: 0x18C84C0 VA: 0x1818C9EC0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18C9F10 Offset: 0x18C8510 VA: 0x1818C9F10 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18C9F60 Offset: 0x18C8560 VA: 0x1818C9F60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C9FB0 Offset: 0x18C85B0 VA: 0x1818C9FB0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18C9A50 Offset: 0x18C8050 VA: 0x1818C9A50 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18CA000 Offset: 0x18C8600 VA: 0x1818CA000 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18C9960 Offset: 0x18C7F60 VA: 0x1818C9960 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18C9990 Offset: 0x18C7F90 VA: 0x1818C9990 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
	// RVA: 0x18C99C0 Offset: 0x18C7FC0 VA: 0x1818C99C0 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18C9A20 Offset: 0x18C8020 VA: 0x1818C9A20 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C99F0 Offset: 0x18C7FF0 VA: 0x1818C99F0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9AA0 Offset: 0x18C80A0 VA: 0x1818C9AA0 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9AD0 Offset: 0x18C80D0 VA: 0x1818C9AD0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9B00 Offset: 0x18C8100 VA: 0x1818C9B00 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18C9B30 Offset: 0x18C8130 VA: 0x1818C9B30 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18C9B60 Offset: 0x18C8160 VA: 0x1818C9B60 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9B90 Offset: 0x18C8190 VA: 0x1818C9B90 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18C9BC0 Offset: 0x18C81C0 VA: 0x1818C9BC0 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9BF0 Offset: 0x18C81F0 VA: 0x1818C9BF0 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18C9C20 Offset: 0x18C8220 VA: 0x1818C9C20 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9C50 Offset: 0x18C8250 VA: 0x1818C9C50 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18C9C80 Offset: 0x18C8280 VA: 0x1818C9C80 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18C9CB0 Offset: 0x18C82B0 VA: 0x1818C9CB0 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18C9CE0 Offset: 0x18C82E0 VA: 0x1818C9CE0 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18C9D10 Offset: 0x18C8310 VA: 0x1818C9D10 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18C9D40 Offset: 0x18C8340 VA: 0x1818C9D40 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C9D70 Offset: 0x18C8370 VA: 0x1818C9D70 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18C9DA0 Offset: 0x18C83A0 VA: 0x1818C9DA0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

