internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 2147
{	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0xEEF500 Offset: 0xEEDB00 VA: 0x180EEF500
	public int get_lastDepth() { }

	// RVA: 0xEEF470 Offset: 0xEEDA70 VA: 0x180EEF470
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0xEEEEE0 Offset: 0xEED4E0 VA: 0x180EEEEE0 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0xEEF0E0 Offset: 0xEED6E0 VA: 0x180EEF0E0
	public int PushKS(int errline, int errcol) { }

	// RVA: 0xEEF000 Offset: 0xEED600 VA: 0x180EEF000
	public KeySequence PopKS() { }

}

