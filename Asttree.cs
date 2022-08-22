internal class Asttree // TypeDefIndex: 2137
{	// Fields
	private ArrayList fAxisArray; // 0x10
	private string xpathexpr; // 0x18
	private bool isField; // 0x20
	private XmlNamespaceManager nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0xF42B90 Offset: 0xF41190 VA: 0x180F42B90
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF42A20 Offset: 0xF41020 VA: 0x180F42A20
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0xF429C0 Offset: 0xF40FC0 VA: 0x180F429C0
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0xF429F0 Offset: 0xF40FF0 VA: 0x180F429F0
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0xF42A50 Offset: 0xF41050 VA: 0x180F42A50
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0xF42120 Offset: 0xF40720 VA: 0x180F42120
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF42A80 Offset: 0xF41080 VA: 0x180F42A80
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

