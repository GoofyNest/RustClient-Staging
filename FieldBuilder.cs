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

	// RVA: 0x18C9350 Offset: 0x18C7950 VA: 0x1818C9350 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x18C93A0 Offset: 0x18C79A0 VA: 0x1818C93A0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C9420 Offset: 0x18C7A20 VA: 0x1818C9420 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18C9470 Offset: 0x18C7A70 VA: 0x1818C9470 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C92A0 Offset: 0x18C78A0 VA: 0x1818C92A0 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18C93F0 Offset: 0x18C79F0 VA: 0x1818C93F0 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x18C94C0 Offset: 0x18C7AC0 VA: 0x1818C94C0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C9240 Offset: 0x18C7840 VA: 0x1818C9240 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C9270 Offset: 0x18C7870 VA: 0x1818C9270 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C92F0 Offset: 0x18C78F0 VA: 0x1818C92F0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C9320 Offset: 0x18C7920 VA: 0x1818C9320 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

