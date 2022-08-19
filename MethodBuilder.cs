public abstract class MethodBuilder : MethodInfo // TypeDefIndex: 608
{	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18CCC10 Offset: 0x18CB210 VA: 0x1818CCC10 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CCC60 Offset: 0x18CB260 VA: 0x1818CCC60 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CCCE0 Offset: 0x18CB2E0 VA: 0x1818CCCE0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CCB60 Offset: 0x18CB160 VA: 0x1818CCB60 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CCCB0 Offset: 0x18CB2B0 VA: 0x1818CCCB0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CCD30 Offset: 0x18CB330 VA: 0x1818CCD30 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CCAA0 Offset: 0x18CB0A0 VA: 0x1818CCAA0 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CCAD0 Offset: 0x18CB0D0 VA: 0x1818CCAD0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CCB00 Offset: 0x18CB100 VA: 0x1818CCB00 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CCB30 Offset: 0x18CB130 VA: 0x1818CCB30 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CCBB0 Offset: 0x18CB1B0 VA: 0x1818CCBB0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CCBE0 Offset: 0x18CB1E0 VA: 0x1818CCBE0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

