internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 577
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D5CF0 Offset: 0x18D42F0 VA: 0x1818D5CF0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D5AF0 Offset: 0x18D40F0 VA: 0x1818D5AF0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D5D90 Offset: 0x18D4390 VA: 0x1818D5D90
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D5CF0 Offset: 0x18D42F0 VA: 0x1818D5CF0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D5B80 Offset: 0x18D4180 VA: 0x1818D5B80 Slot: 32
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

