public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 2793
{	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1180EA0 Offset: 0x117F4A0 VA: 0x181180EA0
	public void .ctor() { }

	// RVA: 0x1180BA0 Offset: 0x117F1A0 VA: 0x181180BA0
	public int Add(Oid oid) { }

	// RVA: 0x1180F10 Offset: 0x117F510 VA: 0x181180F10
	public Oid get_Item(int index) { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x1180E30 Offset: 0x117F430 VA: 0x181180E30 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1180BD0 Offset: 0x117F1D0 VA: 0x181180BD0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 6
	public object get_SyncRoot() { }

}

