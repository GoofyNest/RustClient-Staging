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

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14BFEA0 Offset: 0x14BE4A0 VA: 0x1814BFEA0 Slot: 5
	public int get_Count() { }

	// RVA: 0x14BFED0 Offset: 0x14BE4D0 VA: 0x1814BFED0
	public Group get_Item(int groupnum) { }

	// RVA: 0x14BFEE0 Offset: 0x14BE4E0 VA: 0x1814BFEE0
	public Group get_Item(string groupname) { }

	// RVA: 0x14BFD30 Offset: 0x14BE330 VA: 0x1814BFD30
	internal Group GetGroup(int groupnum) { }

	// RVA: 0x14BF8E0 Offset: 0x14BDEE0 VA: 0x1814BF8E0
	internal Group GetGroupImpl(int groupnum) { }

	// RVA: 0x14BF790 Offset: 0x14BDD90 VA: 0x1814BF790 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14BF870 Offset: 0x14BDE70 VA: 0x1814BF870 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14BFE70 Offset: 0x14BE470 VA: 0x1814BFE70
	internal void .ctor() { }

}

