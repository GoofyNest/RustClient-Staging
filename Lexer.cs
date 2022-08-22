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

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(string stream) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Position() { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	public void set_Position(int value) { }

	// RVA: 0x1091810 Offset: 0x108FE10 VA: 0x181091810
	public string GetStringValue(Token token) { }

	// RVA: 0x10917E0 Offset: 0x108FDE0 VA: 0x1810917E0
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x1091770 Offset: 0x108FD70 VA: 0x181091770
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x10917B0 Offset: 0x108FDB0 VA: 0x1810917B0
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x1091840 Offset: 0x108FE40 VA: 0x181091840
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x1092260 Offset: 0x1090860 VA: 0x181092260
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x10921A0 Offset: 0x10907A0 VA: 0x1810921A0
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x1092320 Offset: 0x1090920 VA: 0x181092320
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x1091FD0 Offset: 0x10905D0 VA: 0x181091FD0
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x1091EE0 Offset: 0x10904E0 VA: 0x181091EE0
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x10920C0 Offset: 0x10906C0 VA: 0x1810920C0
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x1091940 Offset: 0x108FF40 VA: 0x181091940
	public static bool IsValidToken(string input) { }

	// RVA: 0x1091880 Offset: 0x108FE80 VA: 0x181091880
	public static bool IsValidCharacter(char input) { }

	// RVA: 0x1091760 Offset: 0x108FD60 VA: 0x181091760
	public void EatChar() { }

	// RVA: 0x10919F0 Offset: 0x108FFF0 VA: 0x1810919F0
	public int PeekChar() { }

	// RVA: 0x1091A30 Offset: 0x1090030 VA: 0x181091A30
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x1091B90 Offset: 0x1090190 VA: 0x181091B90
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x1092470 Offset: 0x1090A70 VA: 0x181092470
	private static void .cctor() { }

}

