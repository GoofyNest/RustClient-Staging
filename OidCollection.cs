public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 2793
{	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x117C580 Offset: 0x117AB80 VA: 0x18117C580
	public void .ctor() { }

	// RVA: 0x117C280 Offset: 0x117A880 VA: 0x18117C280
	public int Add(Oid oid) { }

	// RVA: 0x117C5F0 Offset: 0x117ABF0 VA: 0x18117C5F0
	public Oid get_Item(int index) { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 5
	public int get_Count() { }

	// RVA: 0x117C510 Offset: 0x117AB10 VA: 0x18117C510 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x117C2B0 Offset: 0x117A8B0 VA: 0x18117C2B0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

}

