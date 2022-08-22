public abstract class MethodBuilder : MethodInfo // TypeDefIndex: 608
{	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18CCBD0 Offset: 0x18CB1D0 VA: 0x1818CCBD0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CCC20 Offset: 0x18CB220 VA: 0x1818CCC20 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CCCA0 Offset: 0x18CB2A0 VA: 0x1818CCCA0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CCB20 Offset: 0x18CB120 VA: 0x1818CCB20 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CCC70 Offset: 0x18CB270 VA: 0x1818CCC70 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CCCF0 Offset: 0x18CB2F0 VA: 0x1818CCCF0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CCA60 Offset: 0x18CB060 VA: 0x1818CCA60 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CCA90 Offset: 0x18CB090 VA: 0x1818CCA90 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CCAC0 Offset: 0x18CB0C0 VA: 0x1818CCAC0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CCAF0 Offset: 0x18CB0F0 VA: 0x1818CCAF0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CCB70 Offset: 0x18CB170 VA: 0x1818CCB70 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CCBA0 Offset: 0x18CB1A0 VA: 0x1818CCBA0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

