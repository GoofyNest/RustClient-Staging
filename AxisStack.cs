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

	// RVA: 0xB19040 Offset: 0xB17640 VA: 0x180B19040
	internal int get_Length() { }

	// RVA: 0xF43A40 Offset: 0xF42040 VA: 0x180F43A40
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0xF43990 Offset: 0xF41F90 VA: 0x180F43990
	internal void Push(int depth) { }

	// RVA: 0xF43940 Offset: 0xF41F40 VA: 0x180F43940
	internal void Pop() { }

	// RVA: 0xF431A0 Offset: 0xF417A0 VA: 0x180F431A0
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0xF43640 Offset: 0xF41C40 VA: 0x180F43640
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0xF43430 Offset: 0xF41A30 VA: 0x180F43430
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0xF43230 Offset: 0xF41830 VA: 0x180F43230
	internal bool MoveToAttribute(string name, string URN, int depth) { }

}

