internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 62
{	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0x105CC80 Offset: 0x105B280 VA: 0x18105CC80
	public void .ctor() { }

	// RVA: 0x1568C30 Offset: 0x1567230 VA: 0x181568C30
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1568C00 Offset: 0x1567200 VA: 0x181568C00 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1720
{	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x105CC80 Offset: 0x105B280 VA: 0x18105CC80
	public void .ctor() { }

	// RVA: 0x2281420 Offset: 0x227FA20 VA: 0x182281420
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2281260 Offset: 0x227F860 VA: 0x182281260
	public int IndexOf(string oid) { }

	// RVA: 0x1568C00 Offset: 0x1567200 VA: 0x181568C00 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2281540 Offset: 0x227FB40 VA: 0x182281540
	public X509Extension get_Item(string oid) { }

}

public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 2832
{	// Fields
	private static byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x14DA5E0 Offset: 0x14D8BE0 VA: 0x1814DA5E0
	internal void .ctor(X509Certificate cert) { }

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14DAA50 Offset: 0x14D9050 VA: 0x1814DAA50
	public X509Extension get_Item(string oid) { }

	// RVA: 0x14DA3E0 Offset: 0x14D89E0 VA: 0x1814DA3E0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14DA350 Offset: 0x14D8950 VA: 0x1814DA350
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x14DA500 Offset: 0x14D8B00 VA: 0x1814DA500 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14DA590 Offset: 0x14D8B90 VA: 0x1814DA590
	private static void .cctor() { }

}

