internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 581
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6950 Offset: 0x18D4F50 VA: 0x1818D6950 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6B50 Offset: 0x18D5150 VA: 0x1818D6B50
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D64A0 Offset: 0x18D4AA0 VA: 0x1818D64A0 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D6480 Offset: 0x18D4A80 VA: 0x1818D6480 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x18D6AC0 Offset: 0x18D50C0 VA: 0x1818D6AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6950 Offset: 0x18D4F50 VA: 0x1818D6950
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D6780 Offset: 0x18D4D80 VA: 0x1818D6780 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D6A20 Offset: 0x18D5020 VA: 0x1818D6A20
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

