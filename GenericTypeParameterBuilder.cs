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

	// RVA: 0x18CA0A0 Offset: 0x18C86A0 VA: 0x1818CA0A0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18CA050 Offset: 0x18C8650 VA: 0x1818CA050 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18CA0F0 Offset: 0x18C86F0 VA: 0x1818CA0F0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18CA140 Offset: 0x18C8740 VA: 0x1818CA140 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18CA190 Offset: 0x18C8790 VA: 0x1818CA190 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18CA1E0 Offset: 0x18C87E0 VA: 0x1818CA1E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CA230 Offset: 0x18C8830 VA: 0x1818CA230 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18C9CD0 Offset: 0x18C82D0 VA: 0x1818C9CD0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18CA280 Offset: 0x18C8880 VA: 0x1818CA280 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18C9BE0 Offset: 0x18C81E0 VA: 0x1818C9BE0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18C9C10 Offset: 0x18C8210 VA: 0x1818C9C10 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18C9C40 Offset: 0x18C8240 VA: 0x1818C9C40 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18C9CA0 Offset: 0x18C82A0 VA: 0x1818C9CA0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C9C70 Offset: 0x18C8270 VA: 0x1818C9C70 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9D20 Offset: 0x18C8320 VA: 0x1818C9D20 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9D50 Offset: 0x18C8350 VA: 0x1818C9D50 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9D80 Offset: 0x18C8380 VA: 0x1818C9D80 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18C9DB0 Offset: 0x18C83B0 VA: 0x1818C9DB0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18C9DE0 Offset: 0x18C83E0 VA: 0x1818C9DE0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9E10 Offset: 0x18C8410 VA: 0x1818C9E10 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18C9E40 Offset: 0x18C8440 VA: 0x1818C9E40 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9E70 Offset: 0x18C8470 VA: 0x1818C9E70 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18C9EA0 Offset: 0x18C84A0 VA: 0x1818C9EA0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9ED0 Offset: 0x18C84D0 VA: 0x1818C9ED0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18C9F00 Offset: 0x18C8500 VA: 0x1818C9F00 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18C9F30 Offset: 0x18C8530 VA: 0x1818C9F30 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18C9F60 Offset: 0x18C8560 VA: 0x1818C9F60 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18C9F90 Offset: 0x18C8590 VA: 0x1818C9F90 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18C9FC0 Offset: 0x18C85C0 VA: 0x1818C9FC0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C9FF0 Offset: 0x18C85F0 VA: 0x1818C9FF0 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18CA020 Offset: 0x18C8620 VA: 0x1818CA020 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

