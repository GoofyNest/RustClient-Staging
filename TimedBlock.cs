internal class TimedBlock : IComparable<TimedBlock> // TypeDefIndex: 5634
{	// Fields
	public readonly DateTime deadline; // 0x10
	public readonly Action block; // 0x18
	public readonly string blockName; // 0x20

	// Methods

	// RVA: 0x13CB680 Offset: 0x13C9C80 VA: 0x1813CB680
	public void .ctor(DateTime deadline, Action block, string blockName) { }

	// RVA: 0x13CB3D0 Offset: 0x13C99D0 VA: 0x1813CB3D0 Slot: 4
	public int CompareTo(TimedBlock other) { }

	// RVA: 0x13CB400 Offset: 0x13C9A00 VA: 0x1813CB400 Slot: 3
	public override string ToString() { }

}

