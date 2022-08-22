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

	// RVA: 0x18C8A70 Offset: 0x18C7070 VA: 0x1818C8A70 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x18C8AC0 Offset: 0x18C70C0 VA: 0x1818C8AC0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C8B40 Offset: 0x18C7140 VA: 0x1818C8B40 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18C8B90 Offset: 0x18C7190 VA: 0x1818C8B90 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C89C0 Offset: 0x18C6FC0 VA: 0x1818C89C0 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18C8B10 Offset: 0x18C7110 VA: 0x1818C8B10 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x18C8BE0 Offset: 0x18C71E0 VA: 0x1818C8BE0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C8960 Offset: 0x18C6F60 VA: 0x1818C8960 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C8990 Offset: 0x18C6F90 VA: 0x1818C8990 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C8A10 Offset: 0x18C7010 VA: 0x1818C8A10 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C8A40 Offset: 0x18C7040 VA: 0x1818C8A40 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

