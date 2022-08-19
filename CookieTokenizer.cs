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

	// RVA: 0x15265D0 Offset: 0x1524BD0 VA: 0x1815265D0
	internal void .ctor(string tokenStream) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	internal bool get_EndOfCookie() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1526620 Offset: 0x1524C20 VA: 0x181526620
	internal bool get_Eof() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_Name() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Name(string value) { }

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	internal bool get_Quoted() { }

	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
	internal void set_Quoted(bool value) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	internal CookieToken get_Token() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal string get_Value() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Value(string value) { }

	// RVA: 0x1525880 Offset: 0x1523E80 VA: 0x181525880
	internal string Extract() { }

	// RVA: 0x1525900 Offset: 0x1523F00 VA: 0x181525900
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1525B70 Offset: 0x1524170 VA: 0x181525B70
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1525D20 Offset: 0x1524320 VA: 0x181525D20
	internal void Reset() { }

	// RVA: 0x1525DA0 Offset: 0x15243A0 VA: 0x181525DA0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1526030 Offset: 0x1524630 VA: 0x181526030
	private static void .cctor() { }

}

private struct CookieTokenizer.RecognizedAttribute // TypeDefIndex: 2937
{	// Fields
	private string m_name; // 0x0
	private CookieToken m_token; // 0x8

	// Properties
	internal CookieToken Token { get; }

	// Methods

	// RVA: 0xF91E0 Offset: 0xF85E0 VA: 0x1800F91E0
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	internal CookieToken get_Token() { }

	// RVA: 0x1F1DF0 Offset: 0x1F11F0 VA: 0x1801F1DF0
	internal bool IsEqualTo(string value) { }

}

