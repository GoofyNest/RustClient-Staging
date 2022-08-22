public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 389
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DEC00 Offset: 0x1DE000 VA: 0x1801DEC00
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Value() { }

	// RVA: 0x1DEBE0 Offset: 0x1DDFE0 VA: 0x1801DEBE0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1DEAD0 Offset: 0x1DDED0 VA: 0x1801DEAD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1298DC0 Offset: 0x12973C0 VA: 0x181298DC0
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1298DC0 Offset: 0x12973C0 VA: 0x181298DC0
	internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x1298DB0 Offset: 0x12973B0 VA: 0x181298DB0
	internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }

}

