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

	// RVA: 0x18C97C0 Offset: 0x18C7DC0 VA: 0x1818C97C0 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18C9770 Offset: 0x18C7D70 VA: 0x1818C9770 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18C9810 Offset: 0x18C7E10 VA: 0x1818C9810 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18C9860 Offset: 0x18C7E60 VA: 0x1818C9860 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18C98B0 Offset: 0x18C7EB0 VA: 0x1818C98B0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18C9900 Offset: 0x18C7F00 VA: 0x1818C9900 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C9950 Offset: 0x18C7F50 VA: 0x1818C9950 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18C93F0 Offset: 0x18C79F0 VA: 0x1818C93F0 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18C99A0 Offset: 0x18C7FA0 VA: 0x1818C99A0 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18C9300 Offset: 0x18C7900 VA: 0x1818C9300 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18C9330 Offset: 0x18C7930 VA: 0x1818C9330 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18C9360 Offset: 0x18C7960 VA: 0x1818C9360 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18C93C0 Offset: 0x18C79C0 VA: 0x1818C93C0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C9390 Offset: 0x18C7990 VA: 0x1818C9390 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9440 Offset: 0x18C7A40 VA: 0x1818C9440 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9470 Offset: 0x18C7A70 VA: 0x1818C9470 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C94A0 Offset: 0x18C7AA0 VA: 0x1818C94A0 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18C94D0 Offset: 0x18C7AD0 VA: 0x1818C94D0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18C9500 Offset: 0x18C7B00 VA: 0x1818C9500 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C9530 Offset: 0x18C7B30 VA: 0x1818C9530 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18C9560 Offset: 0x18C7B60 VA: 0x1818C9560 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18C9590 Offset: 0x18C7B90 VA: 0x1818C9590 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18C95C0 Offset: 0x18C7BC0 VA: 0x1818C95C0 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18C95F0 Offset: 0x18C7BF0 VA: 0x1818C95F0 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18C9620 Offset: 0x18C7C20 VA: 0x1818C9620 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18C9650 Offset: 0x18C7C50 VA: 0x1818C9650 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18C9680 Offset: 0x18C7C80 VA: 0x1818C9680 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18C96B0 Offset: 0x18C7CB0 VA: 0x1818C96B0 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18C96E0 Offset: 0x18C7CE0 VA: 0x1818C96E0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C9710 Offset: 0x18C7D10 VA: 0x1818C9710 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18C9740 Offset: 0x18C7D40 VA: 0x1818C9740 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

