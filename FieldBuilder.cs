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

	// RVA: 0x18C90D0 Offset: 0x18C76D0 VA: 0x1818C90D0 Slot: 17
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x18C9120 Offset: 0x18C7720 VA: 0x1818C9120 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18C91A0 Offset: 0x18C77A0 VA: 0x1818C91A0 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0x18C91F0 Offset: 0x18C77F0 VA: 0x1818C91F0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18C9020 Offset: 0x18C7620 VA: 0x1818C9020 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x18C9170 Offset: 0x18C7770 VA: 0x1818C9170 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x18C9240 Offset: 0x18C7840 VA: 0x1818C9240 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18C8FC0 Offset: 0x18C75C0 VA: 0x1818C8FC0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18C8FF0 Offset: 0x18C75F0 VA: 0x1818C8FF0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18C9070 Offset: 0x18C7670 VA: 0x1818C9070 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18C90A0 Offset: 0x18C76A0 VA: 0x1818C90A0 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

