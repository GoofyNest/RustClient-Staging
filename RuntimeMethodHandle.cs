public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 390
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DF560 Offset: 0x1DE960 VA: 0x1801DF560
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Value() { }

	// RVA: 0x1DF500 Offset: 0x1DE900 VA: 0x1801DF500 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1DF3F0 Offset: 0x1DE7F0 VA: 0x1801DF3F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1299730 Offset: 0x1297D30 VA: 0x181299730
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x1DF520 Offset: 0x1DE920 VA: 0x1801DF520
	internal bool IsNullHandle() { }

}

