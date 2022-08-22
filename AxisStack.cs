internal class AxisStack // TypeDefIndex: 2133
{	// Fields
	private ArrayList stack; // 0x10
	private ForwardAxis subtree; // 0x18
	private ActiveAxis parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal ForwardAxis get_Subtree() { }

	// RVA: 0xB19300 Offset: 0xB17900 VA: 0x180B19300
	internal int get_Length() { }

	// RVA: 0xF43D00 Offset: 0xF42300 VA: 0x180F43D00
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0xF43C50 Offset: 0xF42250 VA: 0x180F43C50
	internal void Push(int depth) { }

	// RVA: 0xF43C00 Offset: 0xF42200 VA: 0x180F43C00
	internal void Pop() { }

	// RVA: 0xF43460 Offset: 0xF41A60 VA: 0x180F43460
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0xF43900 Offset: 0xF41F00 VA: 0x180F43900
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0xF436F0 Offset: 0xF41CF0 VA: 0x180F436F0
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0xF434F0 Offset: 0xF41AF0 VA: 0x180F434F0
	internal bool MoveToAttribute(string name, string URN, int depth) { }

}

