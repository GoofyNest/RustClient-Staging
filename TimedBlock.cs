internal class TimedBlock : IComparable<TimedBlock> // TypeDefIndex: 5634
{	// Fields
	public readonly DateTime deadline; // 0x10
	public readonly Action block; // 0x18
	public readonly string blockName; // 0x20

	// Methods

	// RVA: 0x13CC2C0 Offset: 0x13CA8C0 VA: 0x1813CC2C0
	public void .ctor(DateTime deadline, Action block, string blockName) { }

	// RVA: 0x13CC010 Offset: 0x13CA610 VA: 0x1813CC010 Slot: 4
	public int CompareTo(TimedBlock other) { }

	// RVA: 0x13CC040 Offset: 0x13CA640 VA: 0x1813CC040 Slot: 3
	public override string ToString() { }

}

