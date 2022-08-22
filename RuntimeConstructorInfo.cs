internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 583
{	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x18D5E00 Offset: 0x18D4400 VA: 0x1818D5E00 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D5E00 Offset: 0x18D4400 VA: 0x1818D5E00
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6040 Offset: 0x18D4640 VA: 0x1818D6040
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D5C70 Offset: 0x18D4270 VA: 0x1818D5C70 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D6020 Offset: 0x18D4620 VA: 0x1818D6020
	internal string SerializationToString() { }

	// RVA: 0x18D5EA0 Offset: 0x18D44A0 VA: 0x1818D5EA0
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CE550 Offset: 0x18CCB50 VA: 0x1818CE550
	protected void .ctor() { }

}

