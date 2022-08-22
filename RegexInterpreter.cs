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

	// RVA: 0x16ACB70 Offset: 0x16AB170 VA: 0x1816ACB70
	internal void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x16AC170 Offset: 0x16AA770 VA: 0x1816AC170 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x16A9190 Offset: 0x16A7790 VA: 0x1816A9190
	private void Advance() { }

	// RVA: 0x16A9110 Offset: 0x16A7710 VA: 0x1816A9110
	private void Advance(int i) { }

	// RVA: 0x16AC0E0 Offset: 0x16AA6E0 VA: 0x1816AC0E0
	private void Goto(int newpos) { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	private void Textto(int newpos) { }

	// RVA: 0x16ACB50 Offset: 0x16AB150 VA: 0x1816ACB50
	private void Trackto(int newpos) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	private int Textstart() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	private int Textpos() { }

	// RVA: 0x16ACB30 Offset: 0x16AB130 VA: 0x1816ACB30
	private int Trackpos() { }

	// RVA: 0x16AC970 Offset: 0x16AAF70 VA: 0x1816AC970
	private void TrackPush() { }

	// RVA: 0x16AC9C0 Offset: 0x16AAFC0 VA: 0x1816AC9C0
	private void TrackPush(int I1) { }

	// RVA: 0x16AC8C0 Offset: 0x16AAEC0 VA: 0x1816AC8C0
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x16ACA40 Offset: 0x16AB040 VA: 0x1816ACA40
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x16AC780 Offset: 0x16AAD80 VA: 0x1816AC780
	private void TrackPush2(int I1) { }

	// RVA: 0x16AC800 Offset: 0x16AAE00 VA: 0x1816AC800
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x16A91A0 Offset: 0x16A77A0 VA: 0x1816A91A0
	private void Backtrack() { }

	// RVA: 0x16AC3B0 Offset: 0x16AA9B0 VA: 0x1816AC3B0
	private void SetOperator(int op) { }

	// RVA: 0x16AC770 Offset: 0x16AAD70 VA: 0x1816AC770
	private void TrackPop() { }

	// RVA: 0x16AC760 Offset: 0x16AAD60 VA: 0x1816AC760
	private void TrackPop(int framesize) { }

	// RVA: 0x16AC6E0 Offset: 0x16AACE0 VA: 0x1816AC6E0
	private int TrackPeek() { }

	// RVA: 0x16AC720 Offset: 0x16AAD20 VA: 0x1816AC720
	private int TrackPeek(int i) { }

	// RVA: 0x16AC500 Offset: 0x16AAB00 VA: 0x1816AC500
	private void StackPush(int I1) { }

	// RVA: 0x16AC480 Offset: 0x16AAA80 VA: 0x1816AC480
	private void StackPush(int I1, int I2) { }

	// RVA: 0x16AC470 Offset: 0x16AAA70 VA: 0x1816AC470
	private void StackPop() { }

	// RVA: 0x16AC460 Offset: 0x16AAA60 VA: 0x1816AC460
	private void StackPop(int framesize) { }

	// RVA: 0x16AC3E0 Offset: 0x16AA9E0 VA: 0x1816AC3E0
	private int StackPeek() { }

	// RVA: 0x16AC420 Offset: 0x16AAA20 VA: 0x1816AC420
	private int StackPeek(int i) { }

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0
	private int Operator() { }

	// RVA: 0x16AC1B0 Offset: 0x16AA7B0 VA: 0x1816AC1B0
	private int Operand(int i) { }

	// RVA: 0x16AC1A0 Offset: 0x16AA7A0 VA: 0x1816AC1A0
	private int Leftchars() { }

	// RVA: 0x16AC3A0 Offset: 0x16AA9A0 VA: 0x1816AC3A0
	private int Rightchars() { }

	// RVA: 0x16A92B0 Offset: 0x16A78B0 VA: 0x1816A92B0
	private int Bump() { }

	// RVA: 0x16A97D0 Offset: 0x16A7DD0 VA: 0x1816A97D0
	private int Forwardchars() { }

	// RVA: 0x16A9720 Offset: 0x16A7D20 VA: 0x1816A9720
	private char Forwardcharnext() { }

	// RVA: 0x16AC550 Offset: 0x16AAB50 VA: 0x1816AC550
	private bool Stringmatch(string str) { }

	// RVA: 0x16AC200 Offset: 0x16AA800 VA: 0x1816AC200
	private bool Refmatch(int index, int len) { }

	// RVA: 0x16A9290 Offset: 0x16A7890 VA: 0x1816A9290
	private void Backwardnext() { }

	// RVA: 0x16A92D0 Offset: 0x16A78D0 VA: 0x1816A92D0
	private char CharAt(int j) { }

	// RVA: 0x16A92F0 Offset: 0x16A78F0 VA: 0x1816A92F0 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x16A97F0 Offset: 0x16A7DF0 VA: 0x1816A97F0 Slot: 4
	protected override void Go() { }

}

