internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 591
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6A40 Offset: 0x18D5040 VA: 0x1818D6A40 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6830 Offset: 0x18D4E30 VA: 0x1818D6830
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D6B00 Offset: 0x18D5100 VA: 0x1818D6B00
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D6A40 Offset: 0x18D5040 VA: 0x1818D6A40
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D6AF0 Offset: 0x18D50F0 VA: 0x1818D6AF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6580 Offset: 0x18D4B80 VA: 0x1818D6580
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D68C0 Offset: 0x18D4EC0 VA: 0x1818D68C0 Slot: 35
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D6AE0 Offset: 0x18D50E0 VA: 0x1818D6AE0
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

