internal class Lexer // TypeDefIndex: 5783
{	// Fields
	private static readonly bool[] token_chars; // 0x0
	private static readonly int last_token_char; // 0x8
	private static readonly string[] dt_formats; // 0x10
	private readonly string s; // 0x10
	private int pos; // 0x18

	// Properties
	public int Position { get; set; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(string stream) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Position() { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	public void set_Position(int value) { }

	// RVA: 0x1090AE0 Offset: 0x108F0E0 VA: 0x181090AE0
	public string GetStringValue(Token token) { }

	// RVA: 0x1090AB0 Offset: 0x108F0B0 VA: 0x181090AB0
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x1090A40 Offset: 0x108F040 VA: 0x181090A40
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x1090A80 Offset: 0x108F080 VA: 0x181090A80
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x1090B10 Offset: 0x108F110 VA: 0x181090B10
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x1091530 Offset: 0x108FB30 VA: 0x181091530
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x1091470 Offset: 0x108FA70 VA: 0x181091470
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x10915F0 Offset: 0x108FBF0 VA: 0x1810915F0
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x10912A0 Offset: 0x108F8A0 VA: 0x1810912A0
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x10911B0 Offset: 0x108F7B0 VA: 0x1810911B0
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x1091390 Offset: 0x108F990 VA: 0x181091390
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x1090C10 Offset: 0x108F210 VA: 0x181090C10
	public static bool IsValidToken(string input) { }

	// RVA: 0x1090B50 Offset: 0x108F150 VA: 0x181090B50
	public static bool IsValidCharacter(char input) { }

	// RVA: 0x1090A30 Offset: 0x108F030 VA: 0x181090A30
	public void EatChar() { }

	// RVA: 0x1090CC0 Offset: 0x108F2C0 VA: 0x181090CC0
	public int PeekChar() { }

	// RVA: 0x1090D00 Offset: 0x108F300 VA: 0x181090D00
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x1090E60 Offset: 0x108F460 VA: 0x181090E60
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x1091740 Offset: 0x108FD40 VA: 0x181091740
	private static void .cctor() { }

}

