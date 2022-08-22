internal struct NamespaceResolver // TypeDefIndex: 5839
{	// Fields
	private int scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration rover; // 0x10

	// Methods

	// RVA: 0x2376E0 Offset: 0x236AE0 VA: 0x1802376E0
	public void PushScope() { }

	// RVA: 0x2376D0 Offset: 0x236AD0 VA: 0x1802376D0
	public void PopScope() { }

	// RVA: 0x2376B0 Offset: 0x236AB0 VA: 0x1802376B0
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x2376A0 Offset: 0x236AA0 VA: 0x1802376A0
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x2376C0 Offset: 0x236AC0 VA: 0x1802376C0
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

