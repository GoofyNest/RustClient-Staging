public sealed class IdnMapping // TypeDefIndex: 743
{	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x13829E0 Offset: 0x1380FE0 VA: 0x1813829E0
	public void .ctor() { }

	// RVA: 0x1381A20 Offset: 0x1380020 VA: 0x181381A20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1381CB0 Offset: 0x13802B0 VA: 0x181381CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1381BC0 Offset: 0x13801C0 VA: 0x181381BC0
	public string GetAscii(string unicode) { }

	// RVA: 0x1381AA0 Offset: 0x13800A0 VA: 0x181381AA0
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x13817D0 Offset: 0x137FDD0 VA: 0x1813817D0
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x1382010 Offset: 0x1380610 VA: 0x181382010
	private string ToAscii(string s, int offset) { }

	// RVA: 0x13824C0 Offset: 0x1380AC0 VA: 0x1813824C0
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x1381EE0 Offset: 0x13804E0 VA: 0x181381EE0
	private string NamePrep(string s, int offset) { }

	// RVA: 0x13825C0 Offset: 0x1380BC0 VA: 0x1813825C0
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x13827C0 Offset: 0x1380DC0 VA: 0x1813827C0
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x1381DF0 Offset: 0x13803F0 VA: 0x181381DF0
	public string GetUnicode(string ascii) { }

	// RVA: 0x1381CD0 Offset: 0x13802D0 VA: 0x181381CD0
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x1382320 Offset: 0x1380920 VA: 0x181382320
	private string ToUnicode(string s, int offset) { }

}

