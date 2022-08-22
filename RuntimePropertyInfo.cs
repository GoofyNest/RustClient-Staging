internal abstract class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 591
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D7060 Offset: 0x18D5660 VA: 0x1818D7060 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6E50 Offset: 0x18D5450 VA: 0x1818D6E50
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x18D7120 Offset: 0x18D5720 VA: 0x1818D7120
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D7060 Offset: 0x18D5660 VA: 0x1818D7060
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D7110 Offset: 0x18D5710 VA: 0x1818D7110 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6BA0 Offset: 0x18D51A0 VA: 0x1818D6BA0
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D6EE0 Offset: 0x18D54E0 VA: 0x1818D6EE0 Slot: 35
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D7100 Offset: 0x18D5700 VA: 0x1818D7100
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

