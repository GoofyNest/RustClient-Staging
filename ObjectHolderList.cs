internal class ObjectHolderList // TypeDefIndex: 1042
{	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x1294030 Offset: 0x1292630 VA: 0x181294030
	internal void .ctor() { }

	// RVA: 0x1293FC0 Offset: 0x12925C0 VA: 0x181293FC0
	internal void .ctor(int startingSize) { }

	// RVA: 0x1293D70 Offset: 0x1292370 VA: 0x181293D70 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x1293F30 Offset: 0x1292530 VA: 0x181293F30
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x1293EA0 Offset: 0x12924A0 VA: 0x181293EA0
	private void EnlargeArray() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal int get_Version() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	internal int get_Count() { }

}

