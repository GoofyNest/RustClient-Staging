internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 583
{	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x18D5B40 Offset: 0x18D4140 VA: 0x1818D5B40 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D5B40 Offset: 0x18D4140 VA: 0x1818D5B40
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D5D80 Offset: 0x18D4380 VA: 0x1818D5D80
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D59B0 Offset: 0x18D3FB0 VA: 0x1818D59B0 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D5D60 Offset: 0x18D4360 VA: 0x1818D5D60
	internal string SerializationToString() { }

	// RVA: 0x18D5BE0 Offset: 0x18D41E0 VA: 0x1818D5BE0
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CE290 Offset: 0x18CC890 VA: 0x1818CE290
	protected void .ctor() { }

}

