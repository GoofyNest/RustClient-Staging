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

	// RVA: 0x18C5F50 Offset: 0x18C4550 VA: 0x1818C5F50 Slot: 21
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x18C5FA0 Offset: 0x18C45A0 VA: 0x1818C5FA0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C6020 Offset: 0x18C4620 VA: 0x1818C6020 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C5E70 Offset: 0x18C4470 VA: 0x1818C5E70 Slot: 18
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x18C5FF0 Offset: 0x18C45F0 VA: 0x1818C5FF0 Slot: 20
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x18C6070 Offset: 0x18C4670 VA: 0x1818C6070 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C5DE0 Offset: 0x18C43E0 VA: 0x1818C5DE0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C5E10 Offset: 0x18C4410 VA: 0x1818C5E10 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C5E40 Offset: 0x18C4440 VA: 0x1818C5E40 Slot: 19
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x18C5EC0 Offset: 0x18C44C0 VA: 0x1818C5EC0 Slot: 22
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C5EF0 Offset: 0x18C44F0 VA: 0x1818C5EF0 Slot: 40
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x18C5F20 Offset: 0x18C4520 VA: 0x1818C5F20 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

}

