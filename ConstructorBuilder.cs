public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 600
{
// Namespace: System.Reflection.Emit
public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 600
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18C6830 Offset: 0x18C4E30 VA: 0x1818C6830 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C6880 Offset: 0x18C4E80 VA: 0x1818C6880 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C6900 Offset: 0x18C4F00 VA: 0x1818C6900 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C6750 Offset: 0x18C4D50 VA: 0x1818C6750 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C68D0 Offset: 0x18C4ED0 VA: 0x1818C68D0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C6950 Offset: 0x18C4F50 VA: 0x1818C6950 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C66C0 Offset: 0x18C4CC0 VA: 0x1818C66C0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C66F0 Offset: 0x18C4CF0 VA: 0x1818C66F0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C6720 Offset: 0x18C4D20 VA: 0x1818C6720 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C67A0 Offset: 0x18C4DA0 VA: 0x1818C67A0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C67D0 Offset: 0x18C4DD0 VA: 0x1818C67D0 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C6800 Offset: 0x18C4E00 VA: 0x1818C6800 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

