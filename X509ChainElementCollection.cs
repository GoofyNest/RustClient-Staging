public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 2824
{	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x14D1F80 Offset: 0x14D0580 VA: 0x1814D1F80
	internal void .ctor() { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x14D1FF0 Offset: 0x14D05F0 VA: 0x1814D1FF0
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x13480D0 Offset: 0x13466D0 VA: 0x1813480D0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14D1EB0 Offset: 0x14D04B0 VA: 0x1814D1EB0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14D1E10 Offset: 0x14D0410 VA: 0x1814D1E10
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x14D1EE0 Offset: 0x14D04E0 VA: 0x1814D1EE0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14D1BF0 Offset: 0x14D01F0 VA: 0x1814D1BF0
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0xBC8A50 Offset: 0xBC7050 VA: 0x180BC8A50
	internal void Clear() { }

	// RVA: 0x14D1CC0 Offset: 0x14D02C0 VA: 0x1814D1CC0
	internal bool Contains(X509Certificate2 certificate) { }

}

