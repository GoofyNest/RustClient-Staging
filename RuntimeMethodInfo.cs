internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 581
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D62F0 Offset: 0x18D48F0 VA: 0x1818D62F0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D64F0 Offset: 0x18D4AF0 VA: 0x1818D64F0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D5E40 Offset: 0x18D4440 VA: 0x1818D5E40 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D5E20 Offset: 0x18D4420 VA: 0x1818D5E20 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x18D6460 Offset: 0x18D4A60 VA: 0x1818D6460 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D62F0 Offset: 0x18D48F0 VA: 0x1818D62F0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D6120 Offset: 0x18D4720 VA: 0x1818D6120 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D63C0 Offset: 0x18D49C0 VA: 0x1818D63C0
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

