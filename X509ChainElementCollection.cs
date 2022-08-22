public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 2824
{	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x14D2EB0 Offset: 0x14D14B0 VA: 0x1814D2EB0
	internal void .ctor() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 5
	public int get_Count() { }

	// RVA: 0x14D2F20 Offset: 0x14D1520 VA: 0x1814D2F20
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x1348FD0 Offset: 0x13475D0 VA: 0x181348FD0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14D2DE0 Offset: 0x14D13E0 VA: 0x1814D2DE0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14D2D40 Offset: 0x14D1340 VA: 0x1814D2D40
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x14D2E10 Offset: 0x14D1410 VA: 0x1814D2E10 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14D2B20 Offset: 0x14D1120 VA: 0x1814D2B20
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0xBC8580 Offset: 0xBC6B80 VA: 0x180BC8580
	internal void Clear() { }

	// RVA: 0x14D2BF0 Offset: 0x14D11F0 VA: 0x1814D2BF0
	internal bool Contains(X509Certificate2 certificate) { }

}

