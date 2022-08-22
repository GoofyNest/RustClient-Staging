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

	// RVA: 0x16B0700 Offset: 0x16AED00 VA: 0x1816B0700
	internal void .ctor(int type, RegexOptions options) { }

	// RVA: 0x16B0790 Offset: 0x16AED90 VA: 0x1816B0790
	internal void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x16B0740 Offset: 0x16AED40 VA: 0x1816B0740
	internal void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x16B07E0 Offset: 0x16AEDE0 VA: 0x1816B07E0
	internal void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x16B06B0 Offset: 0x16AECB0 VA: 0x1816B06B0
	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x16B06A0 Offset: 0x16AECA0 VA: 0x1816B06A0
	internal bool UseOptionR() { }

	// RVA: 0x16B0540 Offset: 0x16AEB40 VA: 0x1816B0540
	internal RegexNode ReverseLeft() { }

	// RVA: 0x16AF750 Offset: 0x16ADD50 VA: 0x1816AF750
	internal void MakeRep(int type, int min, int max) { }

	// RVA: 0x16B02A0 Offset: 0x16AE8A0 VA: 0x1816B02A0
	internal RegexNode Reduce() { }

	// RVA: 0x16B05A0 Offset: 0x16AEBA0 VA: 0x1816B05A0
	internal RegexNode StripEnation(int emptyType) { }

	// RVA: 0x16AFED0 Offset: 0x16AE4D0 VA: 0x1816AFED0
	internal RegexNode ReduceGroup() { }

	// RVA: 0x16AFF40 Offset: 0x16AE540 VA: 0x1816AFF40
	internal RegexNode ReduceRep() { }

	// RVA: 0x16B0100 Offset: 0x16AE700 VA: 0x1816B0100
	internal RegexNode ReduceSet() { }

	// RVA: 0x16AF760 Offset: 0x16ADD60 VA: 0x1816AF760
	internal RegexNode ReduceAlternation() { }

	// RVA: 0x16AFB60 Offset: 0x16AE160 VA: 0x1816AFB60
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0x16AF640 Offset: 0x16ADC40 VA: 0x1816AF640
	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x16AF4D0 Offset: 0x16ADAD0 VA: 0x1816AF4D0
	internal void AddChild(RegexNode newChild) { }

	// RVA: 0x16AF5E0 Offset: 0x16ADBE0 VA: 0x1816AF5E0
	internal RegexNode Child(int i) { }

	// RVA: 0x16AF5A0 Offset: 0x16ADBA0 VA: 0x1816AF5A0
	internal int ChildCount() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int Type() { }

}

