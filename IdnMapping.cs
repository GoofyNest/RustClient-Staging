public sealed class IdnMapping // TypeDefIndex: 743
{	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x1383620 Offset: 0x1381C20 VA: 0x181383620
	public void .ctor() { }

	// RVA: 0x1382660 Offset: 0x1380C60 VA: 0x181382660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x13828F0 Offset: 0x1380EF0 VA: 0x1813828F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1382800 Offset: 0x1380E00 VA: 0x181382800
	public string GetAscii(string unicode) { }

	// RVA: 0x13826E0 Offset: 0x1380CE0 VA: 0x1813826E0
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x1382410 Offset: 0x1380A10 VA: 0x181382410
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x1382C50 Offset: 0x1381250 VA: 0x181382C50
	private string ToAscii(string s, int offset) { }

	// RVA: 0x1383100 Offset: 0x1381700 VA: 0x181383100
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x1382B20 Offset: 0x1381120 VA: 0x181382B20
	private string NamePrep(string s, int offset) { }

	// RVA: 0x1383200 Offset: 0x1381800 VA: 0x181383200
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x1383400 Offset: 0x1381A00 VA: 0x181383400
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x1382A30 Offset: 0x1381030 VA: 0x181382A30
	public string GetUnicode(string ascii) { }

	// RVA: 0x1382910 Offset: 0x1380F10 VA: 0x181382910
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x1382F60 Offset: 0x1381560 VA: 0x181382F60
	private string ToUnicode(string s, int offset) { }

}

