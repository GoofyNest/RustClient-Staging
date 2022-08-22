internal class ActiveAxis // TypeDefIndex: 2134
{	// Fields
	private int currentDepth; // 0x10
	private bool isActive; // 0x14
	private Asttree axisTree; // 0x18
	private ArrayList axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_CurrentDepth() { }

	// RVA: 0xF41CB0 Offset: 0xF402B0 VA: 0x180F41CB0
	internal void Reactivate() { }

	// RVA: 0xF41CC0 Offset: 0xF402C0 VA: 0x180F41CC0
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0xF41B20 Offset: 0xF40120 VA: 0x180F41B20
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0xF417D0 Offset: 0xF3FDD0 VA: 0x180F417D0 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0xF41970 Offset: 0xF3FF70 VA: 0x180F41970
	public bool MoveToAttribute(string localname, string URN) { }

}

