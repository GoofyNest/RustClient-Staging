internal abstract class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 581
{	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x18D6BD0 Offset: 0x18D51D0 VA: 0x1818D6BD0 Slot: 16
	public override Module get_Module() { }

	// RVA: 0x18D6DD0 Offset: 0x18D53D0 VA: 0x1818D6DD0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x18D6720 Offset: 0x18D4D20 VA: 0x1818D6720 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x18D6700 Offset: 0x18D4D00 VA: 0x1818D6700 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x18D6D40 Offset: 0x18D5340 VA: 0x1818D6D40 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D6BD0 Offset: 0x18D51D0 VA: 0x1818D6BD0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x18D6A00 Offset: 0x18D5000 VA: 0x1818D6A00 Slot: 46
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D6CA0 Offset: 0x18D52A0 VA: 0x1818D6CA0
	internal string SerializationToString() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

