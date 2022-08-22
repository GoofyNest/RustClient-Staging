internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 577
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6310 Offset: 0x18D4910 VA: 0x1818D6310 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6110 Offset: 0x18D4710 VA: 0x1818D6110
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D63B0 Offset: 0x18D49B0 VA: 0x1818D63B0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D6310 Offset: 0x18D4910 VA: 0x1818D6310
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D61A0 Offset: 0x18D47A0 VA: 0x1818D61A0 Slot: 32
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

