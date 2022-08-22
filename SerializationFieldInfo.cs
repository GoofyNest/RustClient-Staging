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

	// RVA: 0xBC9380 Offset: 0xBC7980 VA: 0x180BC9380 Slot: 16
	public override Module get_Module() { }

	// RVA: 0xBC9160 Offset: 0xBC7760 VA: 0x180BC9160 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x12A7910 Offset: 0x12A5F10 VA: 0x1812A7910
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 8
	public override string get_Name() { }

	// RVA: 0xBC92E0 Offset: 0xBC78E0 VA: 0x180BC92E0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0xBC9350 Offset: 0xBC7950 VA: 0x180BC9350 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x12A7650 Offset: 0x12A5C50 VA: 0x1812A7650 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x12A7620 Offset: 0x12A5C20 VA: 0x1812A7620 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A78B0 Offset: 0x12A5EB0 VA: 0x1812A78B0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x12A79C0 Offset: 0x12A5FC0 VA: 0x1812A79C0 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0xD66200 Offset: 0xD64800 VA: 0x180D66200 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x12A7680 Offset: 0x12A5C80 VA: 0x1812A7680
	internal object InternalGetValue(object obj) { }

	// RVA: 0x12A78E0 Offset: 0x12A5EE0 VA: 0x1812A78E0 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x12A7770 Offset: 0x12A5D70 VA: 0x1812A7770
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xBC9410 Offset: 0xBC7A10 VA: 0x180BC9410 Slot: 17
	public override FieldAttributes get_Attributes() { }

}

