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

	// RVA: 0xB12B80 Offset: 0xB11180 VA: 0x180B12B80
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0xB11AF0 Offset: 0xB100F0 VA: 0x180B11AF0
	public NamespaceList Clone() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Excluded() { }

	// RVA: 0xB12E30 Offset: 0xB11430 VA: 0x180B12E30
	public ICollection get_Enumerate() { }

	// RVA: 0xB11A40 Offset: 0xB10040 VA: 0x180B11A40 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0xB11AC0 Offset: 0xB100C0 VA: 0x180B11AC0
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0xB12450 Offset: 0xB10A50 VA: 0x180B12450 Slot: 3
	public override string ToString() { }

	// RVA: 0xB12180 Offset: 0xB10780 VA: 0x180B12180
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0xB12760 Offset: 0xB10D60 VA: 0x180B12760
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB11C20 Offset: 0xB10220 VA: 0x180B11C20
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0xB11D70 Offset: 0xB10370 VA: 0x180B11D70
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0xB123F0 Offset: 0xB109F0 VA: 0x180B123F0
	private void RemoveNamespace(string tns) { }

}

public enum NamespaceList.ListType // TypeDefIndex: 2263
{	// Fields
	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;

}

