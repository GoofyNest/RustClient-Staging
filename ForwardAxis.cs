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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80
	internal bool get_IsAttribute() { }

	// RVA: 0xB10B90 Offset: 0xB0F190 VA: 0x180B10B90
	internal bool get_IsDss() { }

	// RVA: 0xB10BA0 Offset: 0xB0F1A0 VA: 0x180B10BA0
	internal bool get_IsSelfAxis() { }

	// RVA: 0xB10A50 Offset: 0xB0F050 VA: 0x180B10A50
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }

}

