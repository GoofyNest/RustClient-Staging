internal struct Token // TypeDefIndex: 5781
{	// Fields
	public static readonly Token Empty; // 0x0
	private readonly Token.Type type; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <StartPosition>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <EndPosition>k__BackingField; // 0x8

	// Properties
	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }

	// Methods

	// RVA: 0x19DC20 Offset: 0x19D020 VA: 0x18019DC20
	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public int get_StartPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DC50 Offset: 0x19D050 VA: 0x18019DC50
	private void set_StartPosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x122C30 Offset: 0x122030 VA: 0x180122C30
	public int get_EndPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DC40 Offset: 0x19D040 VA: 0x18019DC40
	private void set_EndPosition(int value) { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public Token.Type get_Kind() { }

	// RVA: 0xDE7390 Offset: 0xDE5990 VA: 0x180DE7390
	public static Token.Type op_Implicit(Token token) { }

	// RVA: 0x19DBA0 Offset: 0x19CFA0 VA: 0x18019DBA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x10983B0 Offset: 0x10969B0 VA: 0x1810983B0
	private static void .cctor() { }

}

public enum Token.Type // TypeDefIndex: 5782
{	// Fields
	public int value__; // 0x0
	public const Token.Type Error = 0;
	public const Token.Type End = 1;
	public const Token.Type Token = 2;
	public const Token.Type QuotedString = 3;
	public const Token.Type SeparatorEqual = 4;
	public const Token.Type SeparatorSemicolon = 5;
	public const Token.Type SeparatorSlash = 6;
	public const Token.Type SeparatorDash = 7;
	public const Token.Type SeparatorComma = 8;
	public const Token.Type OpenParens = 9;

}

