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

	// RVA: 0xB197D0 Offset: 0xB17DD0 VA: 0x180B197D0
	internal int get_Length() { }

	// RVA: 0xF447A0 Offset: 0xF42DA0 VA: 0x180F447A0
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0xF446F0 Offset: 0xF42CF0 VA: 0x180F446F0
	internal void Push(int depth) { }

	// RVA: 0xF446A0 Offset: 0xF42CA0 VA: 0x180F446A0
	internal void Pop() { }

	// RVA: 0xF43F00 Offset: 0xF42500 VA: 0x180F43F00
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0xF443A0 Offset: 0xF429A0 VA: 0x180F443A0
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0xF44190 Offset: 0xF42790 VA: 0x180F44190
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0xF43F90 Offset: 0xF42590 VA: 0x180F43F90
	internal bool MoveToAttribute(string name, string URN, int depth) { }

}

