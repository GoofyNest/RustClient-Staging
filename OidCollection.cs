public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 2793
{	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x117C2C0 Offset: 0x117A8C0 VA: 0x18117C2C0
	public void .ctor() { }

	// RVA: 0x117BFC0 Offset: 0x117A5C0 VA: 0x18117BFC0
	public int Add(Oid oid) { }

	// RVA: 0x117C330 Offset: 0x117A930 VA: 0x18117C330
	public Oid get_Item(int index) { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 5
	public int get_Count() { }

	// RVA: 0x117C250 Offset: 0x117A850 VA: 0x18117C250 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x117BFF0 Offset: 0x117A5F0 VA: 0x18117BFF0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

}

