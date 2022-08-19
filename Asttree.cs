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

	// RVA: 0xF428D0 Offset: 0xF40ED0 VA: 0x180F428D0
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF42760 Offset: 0xF40D60 VA: 0x180F42760
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0xF42700 Offset: 0xF40D00 VA: 0x180F42700
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0xF42730 Offset: 0xF40D30 VA: 0x180F42730
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0xF42790 Offset: 0xF40D90 VA: 0x180F42790
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0xF41E60 Offset: 0xF40460 VA: 0x180F41E60
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF427C0 Offset: 0xF40DC0 VA: 0x180F427C0
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

