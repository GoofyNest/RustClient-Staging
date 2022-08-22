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

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	public void set_Position(int value) { }

	// RVA: 0x1090DA0 Offset: 0x108F3A0 VA: 0x181090DA0
	public string GetStringValue(Token token) { }

	// RVA: 0x1090D70 Offset: 0x108F370 VA: 0x181090D70
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x1090D00 Offset: 0x108F300 VA: 0x181090D00
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x1090D40 Offset: 0x108F340 VA: 0x181090D40
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x1090DD0 Offset: 0x108F3D0 VA: 0x181090DD0
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x10917F0 Offset: 0x108FDF0 VA: 0x1810917F0
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x1091730 Offset: 0x108FD30 VA: 0x181091730
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x10918B0 Offset: 0x108FEB0 VA: 0x1810918B0
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x1091560 Offset: 0x108FB60 VA: 0x181091560
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x1091470 Offset: 0x108FA70 VA: 0x181091470
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x1091650 Offset: 0x108FC50 VA: 0x181091650
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x1090ED0 Offset: 0x108F4D0 VA: 0x181090ED0
	public static bool IsValidToken(string input) { }

	// RVA: 0x1090E10 Offset: 0x108F410 VA: 0x181090E10
	public static bool IsValidCharacter(char input) { }

	// RVA: 0x1090CF0 Offset: 0x108F2F0 VA: 0x181090CF0
	public void EatChar() { }

	// RVA: 0x1090F80 Offset: 0x108F580 VA: 0x181090F80
	public int PeekChar() { }

	// RVA: 0x1090FC0 Offset: 0x108F5C0 VA: 0x181090FC0
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x1091120 Offset: 0x108F720 VA: 0x181091120
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x1091A00 Offset: 0x1090000 VA: 0x181091A00
	private static void .cctor() { }

}

