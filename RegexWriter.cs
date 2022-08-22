internal sealed class RegexWriter // TypeDefIndex: 2632
{	// Fields
	internal int[] _intStack; // 0x10
	internal int _depth; // 0x18
	internal int[] _emitted; // 0x20
	internal int _curpos; // 0x28
	internal Dictionary<string, int> _stringhash; // 0x30
	internal List<string> _stringtable; // 0x38
	internal bool _counting; // 0x40
	internal int _count; // 0x44
	internal int _trackcount; // 0x48
	internal Hashtable _caps; // 0x50

	// Methods

	// RVA: 0x16B8370 Offset: 0x16B6970 VA: 0x1816B8370
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0x16B8490 Offset: 0x16B6A90 VA: 0x1816B8490
	private void .ctor() { }

	// RVA: 0x16B7C60 Offset: 0x16B6260 VA: 0x1816B7C60
	internal void PushInt(int I) { }

	// RVA: 0x14CA0E0 Offset: 0x14C86E0 VA: 0x1814CA0E0
	internal bool EmptyStack() { }

	// RVA: 0x14CA140 Offset: 0x14C8740 VA: 0x1814CA140
	internal int PopInt() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	internal int CurPos() { }

	// RVA: 0x16B7C20 Offset: 0x16B6220 VA: 0x1816B7C20
	internal void PatchJump(int Offset, int jumpDest) { }

	// RVA: 0x16B7A90 Offset: 0x16B6090 VA: 0x1816B7A90
	internal void Emit(int op) { }

	// RVA: 0x16B7920 Offset: 0x16B5F20 VA: 0x1816B7920
	internal void Emit(int op, int opd1) { }

	// RVA: 0x16B79C0 Offset: 0x16B5FC0 VA: 0x1816B79C0
	internal void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x16B8270 Offset: 0x16B6870 VA: 0x1816B8270
	internal int StringCode(string str) { }

	// RVA: 0x16B7B00 Offset: 0x16B6100 VA: 0x1816B7B00
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x16B7B60 Offset: 0x16B6160 VA: 0x1816B7B60
	internal int MapCapnum(int capnum) { }

	// RVA: 0x16B7D40 Offset: 0x16B6340 VA: 0x1816B7D40
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x16B6EE0 Offset: 0x16B54E0 VA: 0x1816B6EE0
	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }

}

