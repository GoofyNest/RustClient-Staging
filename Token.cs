internal struct Token // TypeDefIndex: 5781
{	// Fields
	public static readonly Token Empty; // 0x0
	private readonly Token.Type type; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <StartPosition>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <EndPosition>k__BackingField; // 0x8

	// Properties
	public int StartPosition { get; set; }
	public int EndPosition { get; set; }
	public Token.Type Kind { get; }

	// Methods

	// RVA: 0x19DFB0 Offset: 0x19D3B0 VA: 0x18019DFB0
	public void .ctor(Token.Type type, int startPosition, int endPosition) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x14B860 Offset: 0x14AC60 VA: 0x18014B860
	public int get_StartPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19DFE0 Offset: 0x19D3E0 VA: 0x18019DFE0
	private void set_StartPosition(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	public int get_EndPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19DFD0 Offset: 0x19D3D0 VA: 0x18019DFD0
	private void set_EndPosition(int value) { }

	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public Token.Type get_Kind() { }

	// RVA: 0xDE6620 Offset: 0xDE4C20 VA: 0x180DE6620
	public static Token.Type op_Implicit(Token token) { }

	// RVA: 0x19DF30 Offset: 0x19D330 VA: 0x18019DF30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1097680 Offset: 0x1095C80 VA: 0x181097680
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

