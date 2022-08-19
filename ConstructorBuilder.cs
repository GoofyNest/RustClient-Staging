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

	// RVA: 0x18C65B0 Offset: 0x18C4BB0 VA: 0x1818C65B0 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C6600 Offset: 0x18C4C00 VA: 0x1818C6600 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C6680 Offset: 0x18C4C80 VA: 0x1818C6680 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C64D0 Offset: 0x18C4AD0 VA: 0x1818C64D0 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C6650 Offset: 0x18C4C50 VA: 0x1818C6650 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C66D0 Offset: 0x18C4CD0 VA: 0x1818C66D0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C6440 Offset: 0x18C4A40 VA: 0x1818C6440 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C6470 Offset: 0x18C4A70 VA: 0x1818C6470 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C64A0 Offset: 0x18C4AA0 VA: 0x1818C64A0 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C6520 Offset: 0x18C4B20 VA: 0x1818C6520 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C6550 Offset: 0x18C4B50 VA: 0x1818C6550 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C6580 Offset: 0x18C4B80 VA: 0x1818C6580 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

