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

	// RVA: 0x16BA780 Offset: 0x16B8D80 VA: 0x1816BA780
	internal static RegexCode Write(RegexTree t) { }

	// RVA: 0x16BA8A0 Offset: 0x16B8EA0 VA: 0x1816BA8A0
	private void .ctor() { }

	// RVA: 0x16BA070 Offset: 0x16B8670 VA: 0x1816BA070
	internal void PushInt(int I) { }

	// RVA: 0x14CB010 Offset: 0x14C9610 VA: 0x1814CB010
	internal bool EmptyStack() { }

	// RVA: 0x14CB070 Offset: 0x14C9670 VA: 0x1814CB070
	internal int PopInt() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal int CurPos() { }

	// RVA: 0x16BA030 Offset: 0x16B8630 VA: 0x1816BA030
	internal void PatchJump(int Offset, int jumpDest) { }

	// RVA: 0x16B9EA0 Offset: 0x16B84A0 VA: 0x1816B9EA0
	internal void Emit(int op) { }

	// RVA: 0x16B9D30 Offset: 0x16B8330 VA: 0x1816B9D30
	internal void Emit(int op, int opd1) { }

	// RVA: 0x16B9DD0 Offset: 0x16B83D0 VA: 0x1816B9DD0
	internal void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x16BA680 Offset: 0x16B8C80 VA: 0x1816BA680
	internal int StringCode(string str) { }

	// RVA: 0x16B9F10 Offset: 0x16B8510 VA: 0x1816B9F10
	internal ArgumentException MakeException(string message) { }

	// RVA: 0x16B9F70 Offset: 0x16B8570 VA: 0x1816B9F70
	internal int MapCapnum(int capnum) { }

	// RVA: 0x16BA150 Offset: 0x16B8750 VA: 0x1816BA150
	internal RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x16B92F0 Offset: 0x16B78F0 VA: 0x1816B92F0
	internal void EmitFragment(int nodetype, RegexNode node, int CurIndex) { }

}

