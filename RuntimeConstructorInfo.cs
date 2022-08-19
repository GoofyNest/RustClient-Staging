internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 583
{	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x18D5B80 Offset: 0x18D4180 VA: 0x1818D5B80 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D5B80 Offset: 0x18D4180 VA: 0x1818D5B80
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D5DC0 Offset: 0x18D43C0 VA: 0x1818D5DC0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D59F0 Offset: 0x18D3FF0 VA: 0x1818D59F0 Slot: 41
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D5DA0 Offset: 0x18D43A0 VA: 0x1818D5DA0
	internal string SerializationToString() { }

	// RVA: 0x18D5C20 Offset: 0x18D4220 VA: 0x1818D5C20
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CE2D0 Offset: 0x18CC8D0 VA: 0x1818CE2D0
	protected void .ctor() { }

}

