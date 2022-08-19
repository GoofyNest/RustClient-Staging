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

	// RVA: 0x14BFBE0 Offset: 0x14BE1E0 VA: 0x1814BFBE0 Slot: 5
	public int get_Count() { }

	// RVA: 0x14BFC10 Offset: 0x14BE210 VA: 0x1814BFC10
	public Group get_Item(int groupnum) { }

	// RVA: 0x14BFC20 Offset: 0x14BE220 VA: 0x1814BFC20
	public Group get_Item(string groupname) { }

	// RVA: 0x14BFA70 Offset: 0x14BE070 VA: 0x1814BFA70
	internal Group GetGroup(int groupnum) { }

	// RVA: 0x14BF620 Offset: 0x14BDC20 VA: 0x1814BF620
	internal Group GetGroupImpl(int groupnum) { }

	// RVA: 0x14BF4D0 Offset: 0x14BDAD0 VA: 0x1814BF4D0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x14BF5B0 Offset: 0x14BDBB0 VA: 0x1814BF5B0 Slot: 7
	public IEnumerator GetEnumerator() { }

	// RVA: 0x14BFBB0 Offset: 0x14BE1B0 VA: 0x1814BFBB0
	internal void .ctor() { }

}

