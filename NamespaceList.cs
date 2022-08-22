internal class NamespaceList // TypeDefIndex: 2262
{	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xB13310 Offset: 0xB11910 VA: 0x180B13310
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0xB12280 Offset: 0xB10880 VA: 0x180B12280
	public NamespaceList Clone() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Excluded() { }

	// RVA: 0xB135C0 Offset: 0xB11BC0 VA: 0x180B135C0
	public ICollection get_Enumerate() { }

	// RVA: 0xB121D0 Offset: 0xB107D0 VA: 0x180B121D0 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0xB12250 Offset: 0xB10850 VA: 0x180B12250
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0xB12BE0 Offset: 0xB111E0 VA: 0x180B12BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0xB12910 Offset: 0xB10F10 VA: 0x180B12910
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0xB12EF0 Offset: 0xB114F0 VA: 0x180B12EF0
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB123B0 Offset: 0xB109B0 VA: 0x180B123B0
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0xB12500 Offset: 0xB10B00 VA: 0x180B12500
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB12B80 Offset: 0xB11180 VA: 0x180B12B80
	private void RemoveNamespace(string tns) { }

}

public enum NamespaceList.ListType // TypeDefIndex: 2263
{	// Fields
	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;

}

