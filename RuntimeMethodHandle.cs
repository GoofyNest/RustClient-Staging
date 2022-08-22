public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 390
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DEEF0 Offset: 0x1DE2F0 VA: 0x1801DEEF0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Value() { }

	// RVA: 0x1DEE90 Offset: 0x1DE290 VA: 0x1801DEE90 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1DED80 Offset: 0x1DE180 VA: 0x1801DED80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1298DD0 Offset: 0x12973D0 VA: 0x181298DD0
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x1DEEB0 Offset: 0x1DE2B0 VA: 0x1801DEEB0
	internal bool IsNullHandle() { }

}

