internal class CookieTokenizer // TypeDefIndex: 2936
{	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1525960 Offset: 0x1523F60 VA: 0x181525960
	internal void .ctor(string tokenStream) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	internal bool get_EndOfCookie() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x15259B0 Offset: 0x1523FB0 VA: 0x1815259B0
	internal bool get_Eof() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_Name() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Name(string value) { }

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	internal bool get_Quoted() { }

	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	internal void set_Quoted(bool value) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	internal CookieToken get_Token() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	internal void set_Token(CookieToken value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal string get_Value() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_Value(string value) { }

	// RVA: 0x1524C10 Offset: 0x1523210 VA: 0x181524C10
	internal string Extract() { }

	// RVA: 0x1524C90 Offset: 0x1523290 VA: 0x181524C90
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1524F00 Offset: 0x1523500 VA: 0x181524F00
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x15250B0 Offset: 0x15236B0 VA: 0x1815250B0
	internal void Reset() { }

	// RVA: 0x1525130 Offset: 0x1523730 VA: 0x181525130
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x15253C0 Offset: 0x15239C0 VA: 0x1815253C0
	private static void .cctor() { }

}

private struct CookieTokenizer.RecognizedAttribute // TypeDefIndex: 2937
{	// Fields
	private string m_name; // 0x0
	private CookieToken m_token; // 0x8

	// Properties
	internal CookieToken Token { get; }

	// Methods

	// RVA: 0xF9160 Offset: 0xF8560 VA: 0x1800F9160
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	internal CookieToken get_Token() { }

	// RVA: 0x1F2190 Offset: 0x1F1590 VA: 0x1801F2190
	internal bool IsEqualTo(string value) { }

}

