internal class ObjectHolderList // TypeDefIndex: 1042
{	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1293990 Offset: 0x1291F90 VA: 0x181293990
	internal void .ctor() { }

	// RVA: 0x1293920 Offset: 0x1291F20 VA: 0x181293920
	internal void .ctor(int startingSize) { }

	// RVA: 0x12936D0 Offset: 0x1291CD0 VA: 0x1812936D0 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x1293890 Offset: 0x1291E90 VA: 0x181293890
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x1293800 Offset: 0x1291E00 VA: 0x181293800
	private void EnlargeArray() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Version() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	internal int get_Count() { }

}

