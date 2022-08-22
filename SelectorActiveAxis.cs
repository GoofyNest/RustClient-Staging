internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 2147
{	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0xEEFFB0 Offset: 0xEEE5B0 VA: 0x180EEFFB0
	public int get_lastDepth() { }

	// RVA: 0xEEFF20 Offset: 0xEEE520 VA: 0x180EEFF20
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0xEEF990 Offset: 0xEEDF90 VA: 0x180EEF990 Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0xEEFB90 Offset: 0xEEE190 VA: 0x180EEFB90
	public int PushKS(int errline, int errcol) { }

	// RVA: 0xEEFAB0 Offset: 0xEEE0B0 VA: 0x180EEFAB0
	public KeySequence PopKS() { }

}

