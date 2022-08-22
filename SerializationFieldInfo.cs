internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 1057
{	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0xBC8EB0 Offset: 0xBC74B0 VA: 0x180BC8EB0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0xBC8C90 Offset: 0xBC7290 VA: 0x180BC8C90 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x12A7270 Offset: 0x12A5870 VA: 0x1812A7270
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 8
	public override string get_Name() { }

	// RVA: 0xBC8E10 Offset: 0xBC7410 VA: 0x180BC8E10 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x12A6FB0 Offset: 0x12A55B0 VA: 0x1812A6FB0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x12A6F80 Offset: 0x12A5580 VA: 0x1812A6F80 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A7210 Offset: 0x12A5810 VA: 0x1812A7210 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x12A7320 Offset: 0x12A5920 VA: 0x1812A7320 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0xD65850 Offset: 0xD63E50 VA: 0x180D65850 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x12A6FE0 Offset: 0x12A55E0 VA: 0x1812A6FE0
	internal object InternalGetValue(object obj) { }

	// RVA: 0x12A7240 Offset: 0x12A5840 VA: 0x1812A7240 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x12A70D0 Offset: 0x12A56D0 VA: 0x1812A70D0
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xBC8F40 Offset: 0xBC7540 VA: 0x180BC8F40 Slot: 17
	public override FieldAttributes get_Attributes() { }

}

