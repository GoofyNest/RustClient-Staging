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

	// RVA: 0xF41210 Offset: 0xF3F810 VA: 0x180F41210
	internal void Reactivate() { }

	// RVA: 0xF41220 Offset: 0xF3F820 VA: 0x180F41220
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0xF41080 Offset: 0xF3F680 VA: 0x180F41080
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0xF40D30 Offset: 0xF3F330 VA: 0x180F40D30 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0xF40ED0 Offset: 0xF3F4D0 VA: 0x180F40ED0
	public bool MoveToAttribute(string localname, string URN) { }

}

