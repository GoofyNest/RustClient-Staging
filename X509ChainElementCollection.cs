public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 2824
{	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x14D2BF0 Offset: 0x14D11F0 VA: 0x1814D2BF0
	internal void .ctor() { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 5
	public int get_Count() { }

	// RVA: 0x14D2C60 Offset: 0x14D1260 VA: 0x1814D2C60
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x1348D10 Offset: 0x1347310 VA: 0x181348D10 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14D2B20 Offset: 0x14D1120 VA: 0x1814D2B20 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14D2A80 Offset: 0x14D1080 VA: 0x1814D2A80
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x14D2B50 Offset: 0x14D1150 VA: 0x1814D2B50 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14D2860 Offset: 0x14D0E60 VA: 0x1814D2860
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0xBC82C0 Offset: 0xBC68C0 VA: 0x180BC82C0
	internal void Clear() { }

	// RVA: 0x14D2930 Offset: 0x14D0F30 VA: 0x1814D2930
	internal bool Contains(X509Certificate2 certificate) { }

}

