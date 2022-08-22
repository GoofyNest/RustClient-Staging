internal class TimedBlock : IComparable<TimedBlock> // TypeDefIndex: 5634
{	// Fields
	public readonly DateTime deadline; // 0x10
	public readonly Action block; // 0x18
	public readonly string blockName; // 0x20

	// Methods

	// RVA: 0x13CC580 Offset: 0x13CAB80 VA: 0x1813CC580
	public void .ctor(DateTime deadline, Action block, string blockName) { }

	// RVA: 0x13CC2D0 Offset: 0x13CA8D0 VA: 0x1813CC2D0 Slot: 4
	public int CompareTo(TimedBlock other) { }

	// RVA: 0x13CC300 Offset: 0x13CA900 VA: 0x1813CC300 Slot: 3
	public override string ToString() { }

}

