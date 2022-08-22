public abstract class MethodBuilder : MethodInfo // TypeDefIndex: 608
{	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18CCE90 Offset: 0x18CB490 VA: 0x1818CCE90 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18CCEE0 Offset: 0x18CB4E0 VA: 0x1818CCEE0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18CCF60 Offset: 0x18CB560 VA: 0x1818CCF60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18CCDE0 Offset: 0x18CB3E0 VA: 0x1818CCDE0 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18CCF30 Offset: 0x18CB530 VA: 0x1818CCF30 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18CCFB0 Offset: 0x18CB5B0 VA: 0x1818CCFB0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18CCD20 Offset: 0x18CB320 VA: 0x1818CCD20 Slot: 41
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x18CCD50 Offset: 0x18CB350 VA: 0x1818CCD50 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CCD80 Offset: 0x18CB380 VA: 0x1818CCD80 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CCDB0 Offset: 0x18CB3B0 VA: 0x1818CCDB0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18CCE30 Offset: 0x18CB430 VA: 0x1818CCE30 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18CCE60 Offset: 0x18CB460 VA: 0x1818CCE60 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

