internal class LongList // TypeDefIndex: 1041
{	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x1293070 Offset: 0x1291670 VA: 0x181293070
	internal void .ctor() { }

	// RVA: 0x12930D0 Offset: 0x12916D0 VA: 0x1812930D0
	internal void .ctor(int startingSize) { }

	// RVA: 0x1292DE0 Offset: 0x12913E0 VA: 0x181292DE0
	internal void Add(long value) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Count() { }

	// RVA: 0x1293060 Offset: 0x1291660 VA: 0x181293060
	internal void StartEnumeration() { }

	// RVA: 0x1292F60 Offset: 0x1291560 VA: 0x181292F60
	internal bool MoveNext() { }

	// RVA: 0x1293140 Offset: 0x1291740 VA: 0x181293140
	internal long get_Current() { }

	// RVA: 0x1292FD0 Offset: 0x12915D0 VA: 0x181292FD0
	internal bool RemoveElement(long value) { }

	// RVA: 0x1292ED0 Offset: 0x12914D0 VA: 0x181292ED0
	private void EnlargeArray() { }

}

