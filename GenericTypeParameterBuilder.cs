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

	// RVA: 0x18C9DE0 Offset: 0x18C83E0 VA: 0x1818C9DE0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18C9D90 Offset: 0x18C8390 VA: 0x1818C9D90 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18C9E30 Offset: 0x18C8430 VA: 0x1818C9E30 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18C9E80 Offset: 0x18C8480 VA: 0x1818C9E80 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18C9ED0 Offset: 0x18C84D0 VA: 0x1818C9ED0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18C9F20 Offset: 0x18C8520 VA: 0x1818C9F20 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C9F70 Offset: 0x18C8570 VA: 0x1818C9F70 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18C9A10 Offset: 0x18C8010 VA: 0x1818C9A10 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18C9FC0 Offset: 0x18C85C0 VA: 0x1818C9FC0 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18C9920 Offset: 0x18C7F20 VA: 0x1818C9920 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18C9950 Offset: 0x18C7F50 VA: 0x1818C9950 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18C9980 Offset: 0x18C7F80 VA: 0x1818C9980 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18C99E0 Offset: 0x18C7FE0 VA: 0x1818C99E0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C99B0 Offset: 0x18C7FB0 VA: 0x1818C99B0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9A60 Offset: 0x18C8060 VA: 0x1818C9A60 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9A90 Offset: 0x18C8090 VA: 0x1818C9A90 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9AC0 Offset: 0x18C80C0 VA: 0x1818C9AC0 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18C9AF0 Offset: 0x18C80F0 VA: 0x1818C9AF0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18C9B20 Offset: 0x18C8120 VA: 0x1818C9B20 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9B50 Offset: 0x18C8150 VA: 0x1818C9B50 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18C9B80 Offset: 0x18C8180 VA: 0x1818C9B80 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9BB0 Offset: 0x18C81B0 VA: 0x1818C9BB0 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18C9BE0 Offset: 0x18C81E0 VA: 0x1818C9BE0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9C10 Offset: 0x18C8210 VA: 0x1818C9C10 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18C9C40 Offset: 0x18C8240 VA: 0x1818C9C40 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18C9C70 Offset: 0x18C8270 VA: 0x1818C9C70 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18C9CA0 Offset: 0x18C82A0 VA: 0x1818C9CA0 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18C9CD0 Offset: 0x18C82D0 VA: 0x1818C9CD0 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18C9D00 Offset: 0x18C8300 VA: 0x1818C9D00 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C9D30 Offset: 0x18C8330 VA: 0x1818C9D30 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18C9D60 Offset: 0x18C8360 VA: 0x1818C9D60 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

