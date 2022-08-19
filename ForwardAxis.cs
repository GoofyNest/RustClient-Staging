internal class ForwardAxis // TypeDefIndex: 2136
{	// Fields
	private DoubleLinkAxis topNode; // 0x10
	private DoubleLinkAxis rootNode; // 0x18
	private bool isAttribute; // 0x20
	private bool isDss; // 0x21
	private bool isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0
	internal bool get_IsAttribute() { }

	// RVA: 0xB10400 Offset: 0xB0EA00 VA: 0x180B10400
	internal bool get_IsDss() { }

	// RVA: 0xB10410 Offset: 0xB0EA10 VA: 0x180B10410
	internal bool get_IsSelfAxis() { }

	// RVA: 0xB102C0 Offset: 0xB0E8C0 VA: 0x180B102C0
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

}

