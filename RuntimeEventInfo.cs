internal abstract class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 575
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D5FE0 Offset: 0x18D45E0 VA: 0x1818D5FE0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D5E10 Offset: 0x18D4410 VA: 0x1818D5E10
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D6080 Offset: 0x18D4680 VA: 0x1818D6080
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D5FE0 Offset: 0x18D45E0 VA: 0x1818D5FE0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D5EA0 Offset: 0x18D44A0 VA: 0x1818D5EA0 Slot: 21
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

