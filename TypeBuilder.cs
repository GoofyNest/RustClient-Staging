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

	// RVA: 0x18D7B60 Offset: 0x18D6160 VA: 0x1818D7B60 Slot: 24
	public override Assembly get_Assembly() { }

	// RVA: 0x18D7B10 Offset: 0x18D6110 VA: 0x1818D7B10 Slot: 28
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x18D7BB0 Offset: 0x18D61B0 VA: 0x1818D7BB0 Slot: 30
	public override Type get_BaseType() { }

	// RVA: 0x18D7C00 Offset: 0x18D6200 VA: 0x1818D7C00 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x18D7C50 Offset: 0x18D6250 VA: 0x1818D7C50 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D7CA0 Offset: 0x18D62A0 VA: 0x1818D7CA0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D7CF0 Offset: 0x18D62F0 VA: 0x1818D7CF0 Slot: 27
	public override string get_Namespace() { }

	// RVA: 0x18D7790 Offset: 0x18D5D90 VA: 0x1818D7790 Slot: 103
	public override Type GetElementType() { }

	// RVA: 0x18D7D40 Offset: 0x18D6340 VA: 0x1818D7D40 Slot: 112
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x18D76A0 Offset: 0x18D5CA0 VA: 0x1818D76A0 Slot: 94
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x18D76D0 Offset: 0x18D5CD0 VA: 0x1818D76D0 Slot: 34
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	// RVA: 0x18D7700 Offset: 0x18D5D00 VA: 0x1818D7700 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x18D7730 Offset: 0x18D5D30 VA: 0x1818D7730 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D7760 Offset: 0x18D5D60 VA: 0x1818D7760 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D77E0 Offset: 0x18D5DE0 VA: 0x1818D77E0 Slot: 50
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7810 Offset: 0x18D5E10 VA: 0x1818D7810 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7840 Offset: 0x18D5E40 VA: 0x1818D7840 Slot: 47
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x18D7870 Offset: 0x18D5E70 VA: 0x1818D7870 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x18D78A0 Offset: 0x18D5EA0 VA: 0x1818D78A0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D78D0 Offset: 0x18D5ED0 VA: 0x1818D78D0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x18D7900 Offset: 0x18D5F00 VA: 0x1818D7900 Slot: 60
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x18D7930 Offset: 0x18D5F30 VA: 0x1818D7930 Slot: 57
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x18D7960 Offset: 0x18D5F60 VA: 0x1818D7960 Slot: 56
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x18D7990 Offset: 0x18D5F90 VA: 0x1818D7990 Slot: 106
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x18D79C0 Offset: 0x18D5FC0 VA: 0x1818D79C0 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x18D79F0 Offset: 0x18D5FF0 VA: 0x1818D79F0 Slot: 95
	protected override bool IsArrayImpl() { }

	// RVA: 0x18D7A20 Offset: 0x18D6020 VA: 0x1818D7A20 Slot: 96
	protected override bool IsByRefImpl() { }

	// RVA: 0x18D7A50 Offset: 0x18D6050 VA: 0x1818D7A50 Slot: 99
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x18D7A80 Offset: 0x18D6080 VA: 0x1818D7A80 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D7AB0 Offset: 0x18D60B0 VA: 0x1818D7AB0 Slot: 97
	protected override bool IsPointerImpl() { }

	// RVA: 0x18D7AE0 Offset: 0x18D60E0 VA: 0x1818D7AE0 Slot: 98
	protected override bool IsPrimitiveImpl() { }

}

