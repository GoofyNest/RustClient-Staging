internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 2619
{	// Fields
	internal int runoperator; // 0x80
	internal int[] runcodes; // 0x88
	internal int runcodepos; // 0x90
	internal string[] runstrings; // 0x98
	internal RegexCode runcode; // 0xA0
	internal RegexPrefix runfcPrefix; // 0xA8
	internal RegexBoyerMoore runbmPrefix; // 0xB0
	internal int runanchors; // 0xB8
	internal bool runrtl; // 0xBC
	internal bool runci; // 0xBD
	internal CultureInfo runculture; // 0xC0

	// Methods

	// RVA: 0x16AECC0 Offset: 0x16AD2C0 VA: 0x1816AECC0
	internal void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x16AE2C0 Offset: 0x16AC8C0 VA: 0x1816AE2C0 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x16AB2E0 Offset: 0x16A98E0 VA: 0x1816AB2E0
	private void Advance() { }

	// RVA: 0x16AB260 Offset: 0x16A9860 VA: 0x1816AB260
	private void Advance(int i) { }

	// RVA: 0x16AE230 Offset: 0x16AC830 VA: 0x1816AE230
	private void Goto(int newpos) { }

	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	private void Textto(int newpos) { }

	// RVA: 0x16AECA0 Offset: 0x16AD2A0 VA: 0x1816AECA0
	private void Trackto(int newpos) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	private int Textstart() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	private int Textpos() { }

	// RVA: 0x16AEC80 Offset: 0x16AD280 VA: 0x1816AEC80
	private int Trackpos() { }

	// RVA: 0x16AEAC0 Offset: 0x16AD0C0 VA: 0x1816AEAC0
	private void TrackPush() { }

	// RVA: 0x16AEB10 Offset: 0x16AD110 VA: 0x1816AEB10
	private void TrackPush(int I1) { }

	// RVA: 0x16AEA10 Offset: 0x16AD010 VA: 0x1816AEA10
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x16AEB90 Offset: 0x16AD190 VA: 0x1816AEB90
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x16AE8D0 Offset: 0x16ACED0 VA: 0x1816AE8D0
	private void TrackPush2(int I1) { }

	// RVA: 0x16AE950 Offset: 0x16ACF50 VA: 0x1816AE950
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x16AB2F0 Offset: 0x16A98F0 VA: 0x1816AB2F0
	private void Backtrack() { }

	// RVA: 0x16AE500 Offset: 0x16ACB00 VA: 0x1816AE500
	private void SetOperator(int op) { }

	// RVA: 0x16AE8C0 Offset: 0x16ACEC0 VA: 0x1816AE8C0
	private void TrackPop() { }

	// RVA: 0x16AE8B0 Offset: 0x16ACEB0 VA: 0x1816AE8B0
	private void TrackPop(int framesize) { }

	// RVA: 0x16AE830 Offset: 0x16ACE30 VA: 0x1816AE830
	private int TrackPeek() { }

	// RVA: 0x16AE870 Offset: 0x16ACE70 VA: 0x1816AE870
	private int TrackPeek(int i) { }

	// RVA: 0x16AE650 Offset: 0x16ACC50 VA: 0x1816AE650
	private void StackPush(int I1) { }

	// RVA: 0x16AE5D0 Offset: 0x16ACBD0 VA: 0x1816AE5D0
	private void StackPush(int I1, int I2) { }

	// RVA: 0x16AE5C0 Offset: 0x16ACBC0 VA: 0x1816AE5C0
	private void StackPop() { }

	// RVA: 0x16AE5B0 Offset: 0x16ACBB0 VA: 0x1816AE5B0
	private void StackPop(int framesize) { }

	// RVA: 0x16AE530 Offset: 0x16ACB30 VA: 0x1816AE530
	private int StackPeek() { }

	// RVA: 0x16AE570 Offset: 0x16ACB70 VA: 0x1816AE570
	private int StackPeek(int i) { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	private int Operator() { }

	// RVA: 0x16AE300 Offset: 0x16AC900 VA: 0x1816AE300
	private int Operand(int i) { }

	// RVA: 0x16AE2F0 Offset: 0x16AC8F0 VA: 0x1816AE2F0
	private int Leftchars() { }

	// RVA: 0x16AE4F0 Offset: 0x16ACAF0 VA: 0x1816AE4F0
	private int Rightchars() { }

	// RVA: 0x16AB400 Offset: 0x16A9A00 VA: 0x1816AB400
	private int Bump() { }

	// RVA: 0x16AB920 Offset: 0x16A9F20 VA: 0x1816AB920
	private int Forwardchars() { }

	// RVA: 0x16AB870 Offset: 0x16A9E70 VA: 0x1816AB870
	private char Forwardcharnext() { }

	// RVA: 0x16AE6A0 Offset: 0x16ACCA0 VA: 0x1816AE6A0
	private bool Stringmatch(string str) { }

	// RVA: 0x16AE350 Offset: 0x16AC950 VA: 0x1816AE350
	private bool Refmatch(int index, int len) { }

	// RVA: 0x16AB3E0 Offset: 0x16A99E0 VA: 0x1816AB3E0
	private void Backwardnext() { }

	// RVA: 0x16AB420 Offset: 0x16A9A20 VA: 0x1816AB420
	private char CharAt(int j) { }

	// RVA: 0x16AB440 Offset: 0x16A9A40 VA: 0x1816AB440 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x16AB940 Offset: 0x16A9F40 VA: 0x1816AB940 Slot: 4
	protected override void Go() { }

}

