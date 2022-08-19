internal struct NamespaceResolver // TypeDefIndex: 5839
{	// Fields
	private int scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration rover; // 0x10

	// Methods

	// RVA: 0x237760 Offset: 0x236B60 VA: 0x180237760
	public void PushScope() { }

	// RVA: 0x237750 Offset: 0x236B50 VA: 0x180237750
	public void PopScope() { }

	// RVA: 0x237730 Offset: 0x236B30 VA: 0x180237730
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x237720 Offset: 0x236B20 VA: 0x180237720
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x237740 Offset: 0x236B40 VA: 0x180237740
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

}

private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 5840
{	// Fields
	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceResolver.NamespaceDeclaration prev; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

