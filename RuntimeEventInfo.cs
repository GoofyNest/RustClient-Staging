internal abstract class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 575
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D59C0 Offset: 0x18D3FC0 VA: 0x1818D59C0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D57F0 Offset: 0x18D3DF0 VA: 0x1818D57F0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D5A60 Offset: 0x18D4060 VA: 0x1818D5A60
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D59C0 Offset: 0x18D3FC0 VA: 0x1818D59C0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D5880 Offset: 0x18D3E80 VA: 0x1818D5880 Slot: 21
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

