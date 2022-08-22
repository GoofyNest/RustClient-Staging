internal class AxisElement // TypeDefIndex: 2132
{	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0xF43EB0 Offset: 0xF424B0 VA: 0x180F43EB0
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0xF43EA0 Offset: 0xF424A0 VA: 0x180F43EA0
	internal void SetDepth(int depth) { }

	// RVA: 0xF43D80 Offset: 0xF42380 VA: 0x180F43D80
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0xF43BF0 Offset: 0xF421F0 VA: 0x180F43BF0
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

}

