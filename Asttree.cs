internal class Asttree // TypeDefIndex: 2137
{	// Fields
	private ArrayList fAxisArray; // 0x10
	private string xpathexpr; // 0x18
	private bool isField; // 0x20
	private XmlNamespaceManager nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0xF43630 Offset: 0xF41C30 VA: 0x180F43630
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF434C0 Offset: 0xF41AC0 VA: 0x180F434C0
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0xF43460 Offset: 0xF41A60 VA: 0x180F43460
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0xF43490 Offset: 0xF41A90 VA: 0x180F43490
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0xF434F0 Offset: 0xF41AF0 VA: 0x180F434F0
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0xF42BC0 Offset: 0xF411C0 VA: 0x180F42BC0
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0xF43520 Offset: 0xF41B20 VA: 0x180F43520
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }

}

