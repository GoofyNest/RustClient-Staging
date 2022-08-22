public class GroupCollection : ICollection, IEnumerable // TypeDefIndex: 2617
{	// Fields
	internal Match _match; // 0x10
	internal Hashtable _captureMap; // 0x18
	internal Group[] _groups; // 0x20

	// Properties
	public object SyncRoot { get; }
	public int Count { get; }
	public Group Item { get; }
	public Group Item { get; }

	// Methods

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14BEF70 Offset: 0x14BD570 VA: 0x1814BEF70 Slot: 5
	public int get_Count() { }

	// RVA: 0x14BEFA0 Offset: 0x14BD5A0 VA: 0x1814BEFA0
	public Group get_Item(int groupnum) { }

	// RVA: 0x14BEFB0 Offset: 0x14BD5B0 VA: 0x1814BEFB0
	public Group get_Item(string groupname) { }

	// RVA: 0x14BEE00 Offset: 0x14BD400 VA: 0x1814BEE00
	internal Group GetGroup(int groupnum) { }

	// RVA: 0x14BE9B0 Offset: 0x14BCFB0 VA: 0x1814BE9B0
	internal Group GetGroupImpl(int groupnum) { }

	// RVA: 0x14BE860 Offset: 0x14BCE60 VA: 0x1814BE860 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14BE940 Offset: 0x14BCF40 VA: 0x1814BE940 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14BEF40 Offset: 0x14BD540 VA: 0x1814BEF40
	internal void .ctor() { }

}

