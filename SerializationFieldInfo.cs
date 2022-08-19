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

	// RVA: 0xBC8BF0 Offset: 0xBC71F0 VA: 0x180BC8BF0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0xBC89D0 Offset: 0xBC6FD0 VA: 0x180BC89D0 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x12A6FB0 Offset: 0x12A55B0 VA: 0x1812A6FB0
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 8
	public override string get_Name() { }

	// RVA: 0xBC8B50 Offset: 0xBC7150 VA: 0x180BC8B50 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x12A6CF0 Offset: 0x12A52F0 VA: 0x1812A6CF0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x12A6CC0 Offset: 0x12A52C0 VA: 0x1812A6CC0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A6F50 Offset: 0x12A5550 VA: 0x1812A6F50 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x12A7060 Offset: 0x12A5660 VA: 0x1812A7060 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0xD65590 Offset: 0xD63B90 VA: 0x180D65590 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x12A6D20 Offset: 0x12A5320 VA: 0x1812A6D20
	internal object InternalGetValue(object obj) { }

	// RVA: 0x12A6F80 Offset: 0x12A5580 VA: 0x1812A6F80 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x12A6E10 Offset: 0x12A5410 VA: 0x1812A6E10
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xBC8C80 Offset: 0xBC7280 VA: 0x180BC8C80 Slot: 17
	public override FieldAttributes get_Attributes() { }

}

