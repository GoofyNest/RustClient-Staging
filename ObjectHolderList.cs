internal class ObjectHolderList // TypeDefIndex: 1042
{	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x12936D0 Offset: 0x1291CD0 VA: 0x1812936D0
	internal void .ctor() { }

	// RVA: 0x1293660 Offset: 0x1291C60 VA: 0x181293660
	internal void .ctor(int startingSize) { }

	// RVA: 0x1293410 Offset: 0x1291A10 VA: 0x181293410 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x12935D0 Offset: 0x1291BD0 VA: 0x1812935D0
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x1293540 Offset: 0x1291B40 VA: 0x181293540
	private void EnlargeArray() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Version() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Count() { }

}

