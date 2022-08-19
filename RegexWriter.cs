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

	// RVA: 0x16BA4C0 Offset: 0x16B8AC0 VA: 0x1816BA4C0
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0x16BA5E0 Offset: 0x16B8BE0 VA: 0x1816BA5E0
	private void .ctor() { }

	// RVA: 0x16B9DB0 Offset: 0x16B83B0 VA: 0x1816B9DB0
	internal void PushInt(int I) { }

	// RVA: 0x14CAD50 Offset: 0x14C9350 VA: 0x1814CAD50
	internal bool EmptyStack() { }

	// RVA: 0x14CADB0 Offset: 0x14C93B0 VA: 0x1814CADB0
	internal int PopInt() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal int CurPos() { }

	// RVA: 0x16B9D70 Offset: 0x16B8370 VA: 0x1816B9D70
	internal void PatchJump(int Offset, int jumpDest) { }

	// RVA: 0x16B9BE0 Offset: 0x16B81E0 VA: 0x1816B9BE0
	internal void Emit(int op) { }

	// RVA: 0x16B9A70 Offset: 0x16B8070 VA: 0x1816B9A70
	internal void Emit(int op, int opd1) { }

	// RVA: 0x16B9B10 Offset: 0x16B8110 VA: 0x1816B9B10
	internal void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x16BA3C0 Offset: 0x16B89C0 VA: 0x1816BA3C0
	internal int StringCode(string str) { }

	// RVA: 0x16B9C50 Offset: 0x16B8250 VA: 0x1816B9C50
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x16B9CB0 Offset: 0x16B82B0 VA: 0x1816B9CB0
	internal int MapCapnum(int capnum) { }

	// RVA: 0x16B9E90 Offset: 0x16B8490 VA: 0x1816B9E90
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x16B9030 Offset: 0x16B7630 VA: 0x1816B9030
	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }

}

