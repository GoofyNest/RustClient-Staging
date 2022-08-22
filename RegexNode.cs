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

	// RVA: 0x16AE2F0 Offset: 0x16AC8F0 VA: 0x1816AE2F0
	internal void .ctor(int type, RegexOptions options) { }

	// RVA: 0x16AE380 Offset: 0x16AC980 VA: 0x1816AE380
	internal void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x16AE330 Offset: 0x16AC930 VA: 0x1816AE330
	internal void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x16AE3D0 Offset: 0x16AC9D0 VA: 0x1816AE3D0
	internal void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x16AE2A0 Offset: 0x16AC8A0 VA: 0x1816AE2A0
	internal void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x16AE290 Offset: 0x16AC890 VA: 0x1816AE290
	internal bool UseOptionR() { }

	// RVA: 0x16AE130 Offset: 0x16AC730 VA: 0x1816AE130
	internal RegexNode ReverseLeft() { }

	// RVA: 0x16AD340 Offset: 0x16AB940 VA: 0x1816AD340
	internal void MakeRep(int type, int min, int max) { }

	// RVA: 0x16ADE90 Offset: 0x16AC490 VA: 0x1816ADE90
	internal RegexNode Reduce() { }

	// RVA: 0x16AE190 Offset: 0x16AC790 VA: 0x1816AE190
	internal RegexNode StripEnation(int emptyType) { }

	// RVA: 0x16ADAC0 Offset: 0x16AC0C0 VA: 0x1816ADAC0
	internal RegexNode ReduceGroup() { }

	// RVA: 0x16ADB30 Offset: 0x16AC130 VA: 0x1816ADB30
	internal RegexNode ReduceRep() { }

	// RVA: 0x16ADCF0 Offset: 0x16AC2F0 VA: 0x1816ADCF0
	internal RegexNode ReduceSet() { }

	// RVA: 0x16AD350 Offset: 0x16AB950 VA: 0x1816AD350
	internal RegexNode ReduceAlternation() { }

	// RVA: 0x16AD750 Offset: 0x16ABD50 VA: 0x1816AD750
	internal RegexNode ReduceConcatenation() { }

	// RVA: 0x16AD230 Offset: 0x16AB830 VA: 0x1816AD230
	internal RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x16AD0C0 Offset: 0x16AB6C0 VA: 0x1816AD0C0
	internal void AddChild(RegexNode newChild) { }

	// RVA: 0x16AD1D0 Offset: 0x16AB7D0 VA: 0x1816AD1D0
	internal RegexNode Child(int i) { }

	// RVA: 0x16AD190 Offset: 0x16AB790 VA: 0x1816AD190
	internal int ChildCount() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	internal int Type() { }

}

