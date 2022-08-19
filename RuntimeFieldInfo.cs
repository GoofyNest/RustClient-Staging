internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 577
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6350 Offset: 0x18D4950 VA: 0x1818D6350 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6150 Offset: 0x18D4750 VA: 0x1818D6150
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D63F0 Offset: 0x18D49F0 VA: 0x1818D63F0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D6350 Offset: 0x18D4950 VA: 0x1818D6350
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D61E0 Offset: 0x18D47E0 VA: 0x1818D61E0 Slot: 32
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

