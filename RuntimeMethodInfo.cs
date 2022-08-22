internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 581
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6910 Offset: 0x18D4F10 VA: 0x1818D6910 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6B10 Offset: 0x18D5110 VA: 0x1818D6B10
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D6460 Offset: 0x18D4A60 VA: 0x1818D6460 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D6440 Offset: 0x18D4A40 VA: 0x1818D6440 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x18D6A80 Offset: 0x18D5080 VA: 0x1818D6A80 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6910 Offset: 0x18D4F10 VA: 0x1818D6910
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D6740 Offset: 0x18D4D40 VA: 0x1818D6740 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D69E0 Offset: 0x18D4FE0 VA: 0x1818D69E0
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

