internal class ObjectHolderListEnumerator // TypeDefIndex: 1043
{	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x1293620 Offset: 0x1291C20 VA: 0x181293620
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x1293570 Offset: 0x1291B70 VA: 0x181293570
	internal bool MoveNext() { }

	// RVA: 0x1293690 Offset: 0x1291C90 VA: 0x181293690
	internal ObjectHolder get_Current() { }

}

