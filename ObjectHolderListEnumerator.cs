internal class ObjectHolderListEnumerator // TypeDefIndex: 1043
{	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x1293CC0 Offset: 0x12922C0 VA: 0x181293CC0
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x1293C10 Offset: 0x1292210 VA: 0x181293C10
	internal bool MoveNext() { }

	// RVA: 0x1293D30 Offset: 0x1292330 VA: 0x181293D30
	internal ObjectHolder get_Current() { }

}

