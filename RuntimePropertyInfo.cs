internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 591
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D7320 Offset: 0x18D5920 VA: 0x1818D7320 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D7110 Offset: 0x18D5710 VA: 0x1818D7110
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D73E0 Offset: 0x18D59E0 VA: 0x1818D73E0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D7320 Offset: 0x18D5920 VA: 0x1818D7320
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D73D0 Offset: 0x18D59D0 VA: 0x1818D73D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6E60 Offset: 0x18D5460 VA: 0x1818D6E60
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D71A0 Offset: 0x18D57A0 VA: 0x1818D71A0 Slot: 35
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D73C0 Offset: 0x18D59C0 VA: 0x1818D73C0
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

