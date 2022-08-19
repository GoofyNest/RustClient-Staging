internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 2147
{	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0xEEF240 Offset: 0xEED840 VA: 0x180EEF240
	public int get_lastDepth() { }

	// RVA: 0xEEF1B0 Offset: 0xEED7B0 VA: 0x180EEF1B0
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0xEEEC20 Offset: 0xEED220 VA: 0x180EEEC20 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0xEEEE20 Offset: 0xEED420 VA: 0x180EEEE20
	public int PushKS(int errline, int errcol) { }

	// RVA: 0xEEED40 Offset: 0xEED340 VA: 0x180EEED40
	public KeySequence PopKS() { }

}

