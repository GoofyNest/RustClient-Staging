internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 591
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D70A0 Offset: 0x18D56A0 VA: 0x1818D70A0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6E90 Offset: 0x18D5490 VA: 0x1818D6E90
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D7160 Offset: 0x18D5760 VA: 0x1818D7160
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D70A0 Offset: 0x18D56A0 VA: 0x1818D70A0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D7150 Offset: 0x18D5750 VA: 0x1818D7150 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6BE0 Offset: 0x18D51E0 VA: 0x1818D6BE0
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D6F20 Offset: 0x18D5520 VA: 0x1818D6F20 Slot: 35
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D7140 Offset: 0x18D5740 VA: 0x1818D7140
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

