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

	// RVA: 0x1293330 Offset: 0x1291930 VA: 0x181293330
	internal void .ctor() { }

	// RVA: 0x1293390 Offset: 0x1291990 VA: 0x181293390
	internal void .ctor(int startingSize) { }

	// RVA: 0x12930A0 Offset: 0x12916A0 VA: 0x1812930A0
	internal void Add(long value) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Count() { }

	// RVA: 0x1293320 Offset: 0x1291920 VA: 0x181293320
	internal void StartEnumeration() { }

	// RVA: 0x1293220 Offset: 0x1291820 VA: 0x181293220
	internal bool MoveNext() { }

	// RVA: 0x1293400 Offset: 0x1291A00 VA: 0x181293400
	internal long get_Current() { }

	// RVA: 0x1293290 Offset: 0x1291890 VA: 0x181293290
	internal bool RemoveElement(long value) { }

	// RVA: 0x1293190 Offset: 0x1291790 VA: 0x181293190
	private void EnlargeArray() { }

}

