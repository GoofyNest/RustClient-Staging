internal sealed class RegexNode // TypeDefIndex: 2625
{	// Fields
	internal int _type; // 0x10
	internal List<RegexNode> _children; // 0x18
	internal string _str; // 0x20
	internal char _ch; // 0x28
	internal int _m; // 0x2C
	internal int _n; // 0x30
	internal RegexOptions _options; // 0x34
	internal RegexNode _next; // 0x38

	// Methods

	// RVA: 0x16B0440 Offset: 0x16AEA40 VA: 0x1816B0440
	internal void .ctor(int type, RegexOptions options) { }

	// RVA: 0x16B04D0 Offset: 0x16AEAD0 VA: 0x1816B04D0
	internal void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x16B0480 Offset: 0x16AEA80 VA: 0x1816B0480
	internal void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x16B0520 Offset: 0x16AEB20 VA: 0x1816B0520
	internal void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x16B03F0 Offset: 0x16AE9F0 VA: 0x1816B03F0
	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x16B03E0 Offset: 0x16AE9E0 VA: 0x1816B03E0
	internal bool UseOptionR() { }

	// RVA: 0x16B0280 Offset: 0x16AE880 VA: 0x1816B0280
	internal RegexNode ReverseLeft() { }

	// RVA: 0x16AF490 Offset: 0x16ADA90 VA: 0x1816AF490
	internal void MakeRep(int type, int min, int max) { }

	// RVA: 0x16AFFE0 Offset: 0x16AE5E0 VA: 0x1816AFFE0
	internal RegexNode Reduce() { }

	// RVA: 0x16B02E0 Offset: 0x16AE8E0 VA: 0x1816B02E0
	internal RegexNode StripEnation(int emptyType) { }

	// RVA: 0x16AFC10 Offset: 0x16AE210 VA: 0x1816AFC10
	internal RegexNode ReduceGroup() { }

	// RVA: 0x16AFC80 Offset: 0x16AE280 VA: 0x1816AFC80
	internal RegexNode ReduceRep() { }

	// RVA: 0x16AFE40 Offset: 0x16AE440 VA: 0x1816AFE40
	internal RegexNode ReduceSet() { }

	// RVA: 0x16AF4A0 Offset: 0x16ADAA0 VA: 0x1816AF4A0
	internal RegexNode ReduceAlternation() { }

	// RVA: 0x16AF8A0 Offset: 0x16ADEA0 VA: 0x1816AF8A0
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0x16AF380 Offset: 0x16AD980 VA: 0x1816AF380
	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x16AF210 Offset: 0x16AD810 VA: 0x1816AF210
	internal void AddChild(RegexNode newChild) { }

	// RVA: 0x16AF320 Offset: 0x16AD920 VA: 0x1816AF320
	internal RegexNode Child(int i) { }

	// RVA: 0x16AF2E0 Offset: 0x16AD8E0 VA: 0x1816AF2E0
	internal int ChildCount() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int Type() { }

}

