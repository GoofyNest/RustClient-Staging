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

	// RVA: 0x12939D0 Offset: 0x1291FD0 VA: 0x1812939D0
	internal void .ctor() { }

	// RVA: 0x1293A30 Offset: 0x1292030 VA: 0x181293A30
	internal void .ctor(int startingSize) { }

	// RVA: 0x1293740 Offset: 0x1291D40 VA: 0x181293740
	internal void Add(long value) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal int get_Count() { }

	// RVA: 0x12939C0 Offset: 0x1291FC0 VA: 0x1812939C0
	internal void StartEnumeration() { }

	// RVA: 0x12938C0 Offset: 0x1291EC0 VA: 0x1812938C0
	internal bool MoveNext() { }

	// RVA: 0x1293AA0 Offset: 0x12920A0 VA: 0x181293AA0
	internal long get_Current() { }

	// RVA: 0x1293930 Offset: 0x1291F30 VA: 0x181293930
	internal bool RemoveElement(long value) { }

	// RVA: 0x1293830 Offset: 0x1291E30 VA: 0x181293830
	private void EnlargeArray() { }

}

