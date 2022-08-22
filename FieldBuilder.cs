public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 604
{
// Namespace: System.Reflection.Emit
public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 604
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18C9090 Offset: 0x18C7690 VA: 0x1818C9090 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x18C90E0 Offset: 0x18C76E0 VA: 0x1818C90E0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C9160 Offset: 0x18C7760 VA: 0x1818C9160 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18C91B0 Offset: 0x18C77B0 VA: 0x1818C91B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C8FE0 Offset: 0x18C75E0 VA: 0x1818C8FE0 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18C9130 Offset: 0x18C7730 VA: 0x1818C9130 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x18C9200 Offset: 0x18C7800 VA: 0x1818C9200 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C8F80 Offset: 0x18C7580 VA: 0x1818C8F80 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C8FB0 Offset: 0x18C75B0 VA: 0x1818C8FB0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9030 Offset: 0x18C7630 VA: 0x1818C9030 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C9060 Offset: 0x18C7660 VA: 0x1818C9060 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

