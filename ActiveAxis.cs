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

	// RVA: 0xF40F50 Offset: 0xF3F550 VA: 0x180F40F50
	internal void Reactivate() { }

	// RVA: 0xF40F60 Offset: 0xF3F560 VA: 0x180F40F60
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0xF40DC0 Offset: 0xF3F3C0 VA: 0x180F40DC0
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0xF40A70 Offset: 0xF3F070 VA: 0x180F40A70 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0xF40C10 Offset: 0xF3F210 VA: 0x180F40C10
	public bool MoveToAttribute(string localname, string URN) { }

}

