internal sealed class RegexFCD // TypeDefIndex: 2613
{	// Fields
	private int[] _intStack; // 0x10
	private int _intDepth; // 0x18
	private RegexFC[] _fcStack; // 0x20
	private int _fcDepth; // 0x28
	private bool _skipAllChildren; // 0x2C
	private bool _skipchild; // 0x2D
	private bool _failed; // 0x2E

	// Methods

	// RVA: 0x14CAAB0 Offset: 0x14C90B0 VA: 0x1814CAAB0
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0x14CADF0 Offset: 0x14C93F0 VA: 0x1814CADF0
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x14CA260 Offset: 0x14C8860 VA: 0x1814CA260
	internal static int Anchors(RegexTree tree) { }

	// RVA: 0x14CA1E0 Offset: 0x14C87E0 VA: 0x1814CA1E0
	private static int AnchorFromType(int type) { }

	// RVA: 0x14CB540 Offset: 0x14C9B40 VA: 0x1814CB540
	private void .ctor() { }

	// RVA: 0x14CB1B0 Offset: 0x14C97B0 VA: 0x1814CB1B0
	private void PushInt(int I) { }

	// RVA: 0x14CAD50 Offset: 0x14C9350 VA: 0x1814CAD50
	private bool IntIsEmpty() { }

	// RVA: 0x14CADB0 Offset: 0x14C93B0 VA: 0x1814CADB0
	private int PopInt() { }

	// RVA: 0x14CB090 Offset: 0x14C9690 VA: 0x1814CB090
	private void PushFC(RegexFC fc) { }

	// RVA: 0xE9DF70 Offset: 0xE9C570 VA: 0x180E9DF70
	private bool FCIsEmpty() { }

	// RVA: 0x14CAD60 Offset: 0x14C9360 VA: 0x1814CAD60
	private RegexFC PopFC() { }

	// RVA: 0x14CB500 Offset: 0x14C9B00 VA: 0x1814CB500
	private RegexFC TopFC() { }

	// RVA: 0x14CB290 Offset: 0x14C9890 VA: 0x1814CB290
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x14CB4F0 Offset: 0x14C9AF0 VA: 0x1814CB4F0
	private void SkipChild() { }

	// RVA: 0x14CA420 Offset: 0x14C8A20 VA: 0x1814CA420
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

