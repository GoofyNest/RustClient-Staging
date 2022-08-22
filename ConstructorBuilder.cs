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

	// RVA: 0x18C6570 Offset: 0x18C4B70 VA: 0x1818C6570 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C65C0 Offset: 0x18C4BC0 VA: 0x1818C65C0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C6640 Offset: 0x18C4C40 VA: 0x1818C6640 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C6490 Offset: 0x18C4A90 VA: 0x1818C6490 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C6610 Offset: 0x18C4C10 VA: 0x1818C6610 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C6690 Offset: 0x18C4C90 VA: 0x1818C6690 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C6400 Offset: 0x18C4A00 VA: 0x1818C6400 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C6430 Offset: 0x18C4A30 VA: 0x1818C6430 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C6460 Offset: 0x18C4A60 VA: 0x1818C6460 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C64E0 Offset: 0x18C4AE0 VA: 0x1818C64E0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C6510 Offset: 0x18C4B10 VA: 0x1818C6510 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C6540 Offset: 0x18C4B40 VA: 0x1818C6540 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

