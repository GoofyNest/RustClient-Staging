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

	// RVA: 0x16AEF80 Offset: 0x16AD580 VA: 0x1816AEF80
	internal void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x16AE580 Offset: 0x16ACB80 VA: 0x1816AE580 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x16AB5A0 Offset: 0x16A9BA0 VA: 0x1816AB5A0
	private void Advance() { }

	// RVA: 0x16AB520 Offset: 0x16A9B20 VA: 0x1816AB520
	private void Advance(int i) { }

	// RVA: 0x16AE4F0 Offset: 0x16ACAF0 VA: 0x1816AE4F0
	private void Goto(int newpos) { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	private void Textto(int newpos) { }

	// RVA: 0x16AEF60 Offset: 0x16AD560 VA: 0x1816AEF60
	private void Trackto(int newpos) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	private int Textstart() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	private int Textpos() { }

	// RVA: 0x16AEF40 Offset: 0x16AD540 VA: 0x1816AEF40
	private int Trackpos() { }

	// RVA: 0x16AED80 Offset: 0x16AD380 VA: 0x1816AED80
	private void TrackPush() { }

	// RVA: 0x16AEDD0 Offset: 0x16AD3D0 VA: 0x1816AEDD0
	private void TrackPush(int I1) { }

	// RVA: 0x16AECD0 Offset: 0x16AD2D0 VA: 0x1816AECD0
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x16AEE50 Offset: 0x16AD450 VA: 0x1816AEE50
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x16AEB90 Offset: 0x16AD190 VA: 0x1816AEB90
	private void TrackPush2(int I1) { }

	// RVA: 0x16AEC10 Offset: 0x16AD210 VA: 0x1816AEC10
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x16AB5B0 Offset: 0x16A9BB0 VA: 0x1816AB5B0
	private void Backtrack() { }

	// RVA: 0x16AE7C0 Offset: 0x16ACDC0 VA: 0x1816AE7C0
	private void SetOperator(int op) { }

	// RVA: 0x16AEB80 Offset: 0x16AD180 VA: 0x1816AEB80
	private void TrackPop() { }

	// RVA: 0x16AEB70 Offset: 0x16AD170 VA: 0x1816AEB70
	private void TrackPop(int framesize) { }

	// RVA: 0x16AEAF0 Offset: 0x16AD0F0 VA: 0x1816AEAF0
	private int TrackPeek() { }

	// RVA: 0x16AEB30 Offset: 0x16AD130 VA: 0x1816AEB30
	private int TrackPeek(int i) { }

	// RVA: 0x16AE910 Offset: 0x16ACF10 VA: 0x1816AE910
	private void StackPush(int I1) { }

	// RVA: 0x16AE890 Offset: 0x16ACE90 VA: 0x1816AE890
	private void StackPush(int I1, int I2) { }

	// RVA: 0x16AE880 Offset: 0x16ACE80 VA: 0x1816AE880
	private void StackPop() { }

	// RVA: 0x16AE870 Offset: 0x16ACE70 VA: 0x1816AE870
	private void StackPop(int framesize) { }

	// RVA: 0x16AE7F0 Offset: 0x16ACDF0 VA: 0x1816AE7F0
	private int StackPeek() { }

	// RVA: 0x16AE830 Offset: 0x16ACE30 VA: 0x1816AE830
	private int StackPeek(int i) { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940
	private int Operator() { }

	// RVA: 0x16AE5C0 Offset: 0x16ACBC0 VA: 0x1816AE5C0
	private int Operand(int i) { }

	// RVA: 0x16AE5B0 Offset: 0x16ACBB0 VA: 0x1816AE5B0
	private int Leftchars() { }

	// RVA: 0x16AE7B0 Offset: 0x16ACDB0 VA: 0x1816AE7B0
	private int Rightchars() { }

	// RVA: 0x16AB6C0 Offset: 0x16A9CC0 VA: 0x1816AB6C0
	private int Bump() { }

	// RVA: 0x16ABBE0 Offset: 0x16AA1E0 VA: 0x1816ABBE0
	private int Forwardchars() { }

	// RVA: 0x16ABB30 Offset: 0x16AA130 VA: 0x1816ABB30
	private char Forwardcharnext() { }

	// RVA: 0x16AE960 Offset: 0x16ACF60 VA: 0x1816AE960
	private bool Stringmatch(string str) { }

	// RVA: 0x16AE610 Offset: 0x16ACC10 VA: 0x1816AE610
	private bool Refmatch(int index, int len) { }

	// RVA: 0x16AB6A0 Offset: 0x16A9CA0 VA: 0x1816AB6A0
	private void Backwardnext() { }

	// RVA: 0x16AB6E0 Offset: 0x16A9CE0 VA: 0x1816AB6E0
	private char CharAt(int j) { }

	// RVA: 0x16AB700 Offset: 0x16A9D00 VA: 0x1816AB700 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x16ABC00 Offset: 0x16AA200 VA: 0x1816ABC00 Slot: 4
	protected override void Go() { }

}

