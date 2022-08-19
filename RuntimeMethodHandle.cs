public struct RuntimeMethodHandle : ISerializable // TypeDefIndex: 390
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1DEF70 Offset: 0x1DE370 VA: 0x1801DEF70
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public IntPtr get_Value() { }

	// RVA: 0x1DEF10 Offset: 0x1DE310 VA: 0x1801DEF10 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1DEE00 Offset: 0x1DE200 VA: 0x1801DEE00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C550 Offset: 0x14B950 VA: 0x18014C550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1298DD0 Offset: 0x12973D0 VA: 0x181298DD0
	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format) { }

	// RVA: 0x1DEF30 Offset: 0x1DE330 VA: 0x1801DEF30
	internal bool IsNullHandle() { }

}

