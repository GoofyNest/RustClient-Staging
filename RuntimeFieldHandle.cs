public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 389
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DF270 Offset: 0x1DE670 VA: 0x1801DF270
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Value() { }

	// RVA: 0x1DF250 Offset: 0x1DE650 VA: 0x1801DF250 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1DF140 Offset: 0x1DE540 VA: 0x1801DF140 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1299720 Offset: 0x1297D20 VA: 0x181299720
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1299720 Offset: 0x1297D20 VA: 0x181299720
	internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x1299710 Offset: 0x1297D10 VA: 0x181299710
	internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }

}

