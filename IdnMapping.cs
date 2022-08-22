public sealed class IdnMapping // TypeDefIndex: 743
{	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x13838E0 Offset: 0x1381EE0 VA: 0x1813838E0
	public void .ctor() { }

	// RVA: 0x1382920 Offset: 0x1380F20 VA: 0x181382920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1382BB0 Offset: 0x13811B0 VA: 0x181382BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1382AC0 Offset: 0x13810C0 VA: 0x181382AC0
	public string GetAscii(string unicode) { }

	// RVA: 0x13829A0 Offset: 0x1380FA0 VA: 0x1813829A0
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x13826D0 Offset: 0x1380CD0 VA: 0x1813826D0
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x1382F10 Offset: 0x1381510 VA: 0x181382F10
	private string ToAscii(string s, int offset) { }

	// RVA: 0x13833C0 Offset: 0x13819C0 VA: 0x1813833C0
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x1382DE0 Offset: 0x13813E0 VA: 0x181382DE0
	private string NamePrep(string s, int offset) { }

	// RVA: 0x13834C0 Offset: 0x1381AC0 VA: 0x1813834C0
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x13836C0 Offset: 0x1381CC0 VA: 0x1813836C0
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x1382CF0 Offset: 0x13812F0 VA: 0x181382CF0
	public string GetUnicode(string ascii) { }

	// RVA: 0x1382BD0 Offset: 0x13811D0 VA: 0x181382BD0
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x1383220 Offset: 0x1381820 VA: 0x181383220
	private string ToUnicode(string s, int offset) { }

}

