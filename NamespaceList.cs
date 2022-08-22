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

	// RVA: 0xB12E40 Offset: 0xB11440 VA: 0x180B12E40
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0xB11DB0 Offset: 0xB103B0 VA: 0x180B11DB0
	public NamespaceList Clone() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Excluded() { }

	// RVA: 0xB130F0 Offset: 0xB116F0 VA: 0x180B130F0
	public ICollection get_Enumerate() { }

	// RVA: 0xB11D00 Offset: 0xB10300 VA: 0x180B11D00 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0xB11D80 Offset: 0xB10380 VA: 0x180B11D80
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0xB12710 Offset: 0xB10D10 VA: 0x180B12710 Slot: 3
	public override string ToString() { }

	// RVA: 0xB12440 Offset: 0xB10A40 VA: 0x180B12440
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0xB12A20 Offset: 0xB11020 VA: 0x180B12A20
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB11EE0 Offset: 0xB104E0 VA: 0x180B11EE0
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0xB12030 Offset: 0xB10630 VA: 0x180B12030
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB126B0 Offset: 0xB10CB0 VA: 0x180B126B0
	private void RemoveNamespace(string tns) { }

}

public enum NamespaceList.ListType // TypeDefIndex: 2263
{	// Fields
	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;

}

