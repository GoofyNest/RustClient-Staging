internal class AxisElement // TypeDefIndex: 2132
{	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0xF43410 Offset: 0xF41A10 VA: 0x180F43410
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0xF43400 Offset: 0xF41A00 VA: 0x180F43400
	internal void SetDepth(int depth) { }

	// RVA: 0xF432E0 Offset: 0xF418E0 VA: 0x180F432E0
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0xF43150 Offset: 0xF41750 VA: 0x180F43150
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }

}

