public abstract class MethodBuilder : MethodInfo // TypeDefIndex: 608
{	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18CC5B0 Offset: 0x18CABB0 VA: 0x1818CC5B0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CC600 Offset: 0x18CAC00 VA: 0x1818CC600 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CC680 Offset: 0x18CAC80 VA: 0x1818CC680 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CC500 Offset: 0x18CAB00 VA: 0x1818CC500 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CC650 Offset: 0x18CAC50 VA: 0x1818CC650 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CC6D0 Offset: 0x18CACD0 VA: 0x1818CC6D0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CC440 Offset: 0x18CAA40 VA: 0x1818CC440 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CC470 Offset: 0x18CAA70 VA: 0x1818CC470 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CC4A0 Offset: 0x18CAAA0 VA: 0x1818CC4A0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CC4D0 Offset: 0x18CAAD0 VA: 0x1818CC4D0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CC550 Offset: 0x18CAB50 VA: 0x1818CC550 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CC580 Offset: 0x18CAB80 VA: 0x1818CC580 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

