internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 62
{	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0x105D9B0 Offset: 0x105BFB0 VA: 0x18105D9B0
	public void .ctor() { }

	// RVA: 0x1567FC0 Offset: 0x15665C0 VA: 0x181567FC0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1567F90 Offset: 0x1566590 VA: 0x181567F90 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1720
{	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x105D9B0 Offset: 0x105BFB0 VA: 0x18105D9B0
	public void .ctor() { }

	// RVA: 0x2281F00 Offset: 0x2280500 VA: 0x182281F00
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x2281D40 Offset: 0x2280340 VA: 0x182281D40
	public int IndexOf(string oid) { }

	// RVA: 0x1567F90 Offset: 0x1566590 VA: 0x181567F90 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2282020 Offset: 0x2280620 VA: 0x182282020
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

	// RVA: 0x14D9970 Offset: 0x14D7F70 VA: 0x1814D9970
	internal void .ctor(X509Certificate cert) { }

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14D9DE0 Offset: 0x14D83E0 VA: 0x1814D9DE0
	public X509Extension get_Item(string oid) { }

	// RVA: 0x14D9770 Offset: 0x14D7D70 VA: 0x1814D9770 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14D96E0 Offset: 0x14D7CE0 VA: 0x1814D96E0
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x14D9890 Offset: 0x14D7E90 VA: 0x1814D9890 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14D9920 Offset: 0x14D7F20 VA: 0x1814D9920
	private static void .cctor() { }

}

