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

	// RVA: 0x14CAD70 Offset: 0x14C9370 VA: 0x1814CAD70
	internal static RegexPrefix FirstChars(RegexTree t) { }

	// RVA: 0x14CB0B0 Offset: 0x14C96B0 VA: 0x1814CB0B0
	internal static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x14CA520 Offset: 0x14C8B20 VA: 0x1814CA520
	internal static int Anchors(RegexTree tree) { }

	// RVA: 0x14CA4A0 Offset: 0x14C8AA0 VA: 0x1814CA4A0
	private static int AnchorFromType(int type) { }

	// RVA: 0x14CB800 Offset: 0x14C9E00 VA: 0x1814CB800
	private void .ctor() { }

	// RVA: 0x14CB470 Offset: 0x14C9A70 VA: 0x1814CB470
	private void PushInt(int I) { }

	// RVA: 0x14CB010 Offset: 0x14C9610 VA: 0x1814CB010
	private bool IntIsEmpty() { }

	// RVA: 0x14CB070 Offset: 0x14C9670 VA: 0x1814CB070
	private int PopInt() { }

	// RVA: 0x14CB350 Offset: 0x14C9950 VA: 0x1814CB350
	private void PushFC(RegexFC fc) { }

	// RVA: 0xE9E230 Offset: 0xE9C830 VA: 0x180E9E230
	private bool FCIsEmpty() { }

	// RVA: 0x14CB020 Offset: 0x14C9620 VA: 0x1814CB020
	private RegexFC PopFC() { }

	// RVA: 0x14CB7C0 Offset: 0x14C9DC0 VA: 0x1814CB7C0
	private RegexFC TopFC() { }

	// RVA: 0x14CB550 Offset: 0x14C9B50 VA: 0x1814CB550
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x14CB7B0 Offset: 0x14C9DB0 VA: 0x1814CB7B0
	private void SkipChild() { }

	// RVA: 0x14CA6E0 Offset: 0x14C8CE0 VA: 0x1814CA6E0
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }

}

