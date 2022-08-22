internal abstract class RuntimeFieldInfo : FieldInfo, ISerializable // TypeDefIndex: 577
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D65D0 Offset: 0x18D4BD0 VA: 0x1818D65D0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D63D0 Offset: 0x18D49D0 VA: 0x1818D63D0
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D6670 Offset: 0x18D4C70 VA: 0x1818D6670
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D65D0 Offset: 0x18D4BD0 VA: 0x1818D65D0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D6460 Offset: 0x18D4A60 VA: 0x1818D6460 Slot: 32
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

