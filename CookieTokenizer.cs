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

	// RVA: 0x1526890 Offset: 0x1524E90 VA: 0x181526890
	internal void .ctor(string tokenStream) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	internal bool get_EndOfCookie() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x15268E0 Offset: 0x1524EE0 VA: 0x1815268E0
	internal bool get_Eof() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal string get_Name() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_Name(string value) { }

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	internal bool get_Quoted() { }

	// RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
	internal void set_Quoted(bool value) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	internal CookieToken get_Token() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	internal void set_Token(CookieToken value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal string get_Value() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_Value(string value) { }

	// RVA: 0x1525B40 Offset: 0x1524140 VA: 0x181525B40
	internal string Extract() { }

	// RVA: 0x1525BC0 Offset: 0x15241C0 VA: 0x181525BC0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1525E30 Offset: 0x1524430 VA: 0x181525E30
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1525FE0 Offset: 0x15245E0 VA: 0x181525FE0
	internal void Reset() { }

	// RVA: 0x1526060 Offset: 0x1524660 VA: 0x181526060
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x15262F0 Offset: 0x15248F0 VA: 0x1815262F0
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

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10
	internal CookieToken get_Token() { }

	// RVA: 0x1F1D70 Offset: 0x1F1170 VA: 0x1801F1D70
	internal bool IsEqualTo(string value) { }

}

