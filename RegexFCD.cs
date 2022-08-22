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

	// RVA: 0x14C9E40 Offset: 0x14C8440 VA: 0x1814C9E40
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0x14CA180 Offset: 0x14C8780 VA: 0x1814CA180
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x14C95F0 Offset: 0x14C7BF0 VA: 0x1814C95F0
	internal static int Anchors(RegexTree tree) { }

	// RVA: 0x14C9570 Offset: 0x14C7B70 VA: 0x1814C9570
	private static int AnchorFromType(int type) { }

	// RVA: 0x14CA8D0 Offset: 0x14C8ED0 VA: 0x1814CA8D0
	private void .ctor() { }

	// RVA: 0x14CA540 Offset: 0x14C8B40 VA: 0x1814CA540
	private void PushInt(int I) { }

	// RVA: 0x14CA0E0 Offset: 0x14C86E0 VA: 0x1814CA0E0
	private bool IntIsEmpty() { }

	// RVA: 0x14CA140 Offset: 0x14C8740 VA: 0x1814CA140
	private int PopInt() { }

	// RVA: 0x14CA420 Offset: 0x14C8A20 VA: 0x1814CA420
	private void PushFC(RegexFC fc) { }

	// RVA: 0xE9ECE0 Offset: 0xE9D2E0 VA: 0x180E9ECE0
	private bool FCIsEmpty() { }

	// RVA: 0x14CA0F0 Offset: 0x14C86F0 VA: 0x1814CA0F0
	private RegexFC PopFC() { }

	// RVA: 0x14CA890 Offset: 0x14C8E90 VA: 0x1814CA890
	private RegexFC TopFC() { }

	// RVA: 0x14CA620 Offset: 0x14C8C20 VA: 0x1814CA620
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x14CA880 Offset: 0x14C8E80 VA: 0x1814CA880
	private void SkipChild() { }

	// RVA: 0x14C97B0 Offset: 0x14C7DB0 VA: 0x1814C97B0
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

