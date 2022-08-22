internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 62
{	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0x105CF40 Offset: 0x105B540 VA: 0x18105CF40
	public void .ctor() { }

	// RVA: 0x1568EF0 Offset: 0x15674F0 VA: 0x181568EF0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1568EC0 Offset: 0x15674C0 VA: 0x181568EC0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1720
{	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x105CF40 Offset: 0x105B540 VA: 0x18105CF40
	public void .ctor() { }

	// RVA: 0x22816E0 Offset: 0x227FCE0 VA: 0x1822816E0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2281520 Offset: 0x227FB20 VA: 0x182281520
	public int IndexOf(string oid) { }

	// RVA: 0x1568EC0 Offset: 0x15674C0 VA: 0x181568EC0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2281800 Offset: 0x227FE00 VA: 0x182281800
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

	// RVA: 0x14DA8A0 Offset: 0x14D8EA0 VA: 0x1814DA8A0
	internal void .ctor(X509Certificate cert) { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14DAD10 Offset: 0x14D9310 VA: 0x1814DAD10
	public X509Extension get_Item(string oid) { }

	// RVA: 0x14DA6A0 Offset: 0x14D8CA0 VA: 0x1814DA6A0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14DA610 Offset: 0x14D8C10 VA: 0x1814DA610
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x14DA7C0 Offset: 0x14D8DC0 VA: 0x1814DA7C0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14DA850 Offset: 0x14D8E50 VA: 0x1814DA850
	private static void .cctor() { }

}

