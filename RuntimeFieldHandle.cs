public struct RuntimeFieldHandle : ISerializable // TypeDefIndex: 389
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DEC80 Offset: 0x1DE080 VA: 0x1801DEC80
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public IntPtr get_Value() { }

	// RVA: 0x1DEC60 Offset: 0x1DE060 VA: 0x1801DEC60 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1DEB50 Offset: 0x1DDF50 VA: 0x1801DEB50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C550 Offset: 0x14B950 VA: 0x18014C550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1298DC0 Offset: 0x12973C0 VA: 0x181298DC0
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x1298DC0 Offset: 0x12973C0 VA: 0x181298DC0
	internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	// RVA: 0x1298DB0 Offset: 0x12973B0 VA: 0x181298DB0
	internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }

}

