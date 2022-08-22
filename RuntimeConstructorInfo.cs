internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 583
{	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x18D5520 Offset: 0x18D3B20 VA: 0x1818D5520 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D5520 Offset: 0x18D3B20 VA: 0x1818D5520
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D5760 Offset: 0x18D3D60 VA: 0x1818D5760
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D5390 Offset: 0x18D3990 VA: 0x1818D5390 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D5740 Offset: 0x18D3D40 VA: 0x1818D5740
	internal string SerializationToString() { }

	// RVA: 0x18D55C0 Offset: 0x18D3BC0 VA: 0x1818D55C0
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CDC70 Offset: 0x18CC270 VA: 0x1818CDC70
	protected void .ctor() { }

}

