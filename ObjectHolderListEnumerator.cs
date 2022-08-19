internal class ObjectHolderListEnumerator // TypeDefIndex: 1043
{	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x1293360 Offset: 0x1291960 VA: 0x181293360
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x12932B0 Offset: 0x12918B0 VA: 0x1812932B0
	internal bool MoveNext() { }

	// RVA: 0x12933D0 Offset: 0x12919D0 VA: 0x1812933D0
	internal ObjectHolder get_Current() { }

}

