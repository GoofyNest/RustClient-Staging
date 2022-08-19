public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid> // TypeDefIndex: 241
{	// Fields
	public static readonly Guid Empty; // 0x0
	private int _a; // 0x0
	private short _b; // 0x4
	private short _c; // 0x6
	private byte _d; // 0x8
	private byte _e; // 0x9
	private byte _f; // 0xA
	private byte _g; // 0xB
	private byte _h; // 0xC
	private byte _i; // 0xD
	private byte _j; // 0xE
	private byte _k; // 0xF
	private static object _rngAccess; // 0x10
	private static RandomNumberGenerator _rng; // 0x18
	private static RandomNumberGenerator _fastRng; // 0x20

	// Methods

	// RVA: 0x1ECE60 Offset: 0x1EC260 VA: 0x1801ECE60
	public void .ctor(byte[] b) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1ECE10 Offset: 0x1EC210 VA: 0x1801ECE10
	public void .ctor(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ECE10 Offset: 0x1EC210 VA: 0x1801ECE10
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ECE70 Offset: 0x1EC270 VA: 0x1801ECE70
	public void .ctor(string g) { }

	// RVA: 0x137F8F0 Offset: 0x137DEF0 VA: 0x18137F8F0
	public static Guid Parse(string input) { }

	// RVA: 0x1381AD0 Offset: 0x13800D0 VA: 0x181381AD0
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x13818D0 Offset: 0x137FED0 VA: 0x1813818D0
	private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x1380D40 Offset: 0x137F340 VA: 0x181380D40
	private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1381490 Offset: 0x137FA90 VA: 0x181381490
	private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1380890 Offset: 0x137EE90 VA: 0x181380890
	private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x137FF40 Offset: 0x137E540 VA: 0x18137FF40
	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FE80 Offset: 0x137E480 VA: 0x18137FE80
	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FA30 Offset: 0x137E030 VA: 0x18137FA30
	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FC40 Offset: 0x137E240 VA: 0x18137FC40
	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FAD0 Offset: 0x137E0D0 VA: 0x18137FAD0
	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FCD0 Offset: 0x137E2D0 VA: 0x18137FCD0
	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FD60 Offset: 0x137E360 VA: 0x18137FD60
	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137F010 Offset: 0x137D610 VA: 0x18137F010
	private static string EatAllWhitespace(string str) { }

	// RVA: 0x137F5C0 Offset: 0x137DBC0 VA: 0x18137F5C0
	private static bool IsHexPrefix(string str, int i) { }

	// RVA: 0x1ECDA0 Offset: 0x1EC1A0 VA: 0x1801ECDA0
	public byte[] ToByteArray() { }

	// RVA: 0x1ECDB0 Offset: 0x1EC1B0 VA: 0x1801ECDB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ECD50 Offset: 0x1EC150 VA: 0x1801ECD50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ECAF0 Offset: 0x1EBEF0 VA: 0x1801ECAF0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1ECC60 Offset: 0x1EC060 VA: 0x1801ECC60 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x1ECD80 Offset: 0x1EC180 VA: 0x1801ECD80
	private int GetResult(uint me, uint them) { }

	// RVA: 0x1ECAC0 Offset: 0x1EBEC0 VA: 0x1801ECAC0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ECAD0 Offset: 0x1EBED0 VA: 0x1801ECAD0 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x13820A0 Offset: 0x13806A0 VA: 0x1813820A0
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x1382230 Offset: 0x1380830 VA: 0x181382230
	public static bool op_Inequality(Guid a, Guid b) { }

	// RVA: 0x1ECE00 Offset: 0x1EC200 VA: 0x1801ECE00
	public string ToString(string format) { }

	// RVA: 0x137F3B0 Offset: 0x137D9B0 VA: 0x18137F3B0
	private static char HexToChar(int a) { }

	// RVA: 0x137F3D0 Offset: 0x137D9D0 VA: 0x18137F3D0
	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	// RVA: 0x137F460 Offset: 0x137DA60 VA: 0x18137F460
	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	// RVA: 0x1ECDF0 Offset: 0x1EC1F0 VA: 0x1801ECDF0 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x137F6B0 Offset: 0x137DCB0 VA: 0x18137F6B0
	public static Guid NewGuid() { }

	// RVA: 0x1381C00 Offset: 0x1380200 VA: 0x181381C00
	private static void .cctor() { }

}

private enum Guid.GuidStyles // TypeDefIndex: 242
{	// Fields
	public int value__; // 0x0
	public const Guid.GuidStyles None = 0;
	public const Guid.GuidStyles AllowParenthesis = 1;
	public const Guid.GuidStyles AllowBraces = 2;
	public const Guid.GuidStyles AllowDashes = 4;
	public const Guid.GuidStyles AllowHexPrefix = 8;
	public const Guid.GuidStyles RequireParenthesis = 16;
	public const Guid.GuidStyles RequireBraces = 32;
	public const Guid.GuidStyles RequireDashes = 64;
	public const Guid.GuidStyles RequireHexPrefix = 128;
	public const Guid.GuidStyles HexFormat = 160;
	public const Guid.GuidStyles NumberFormat = 0;
	public const Guid.GuidStyles DigitFormat = 64;
	public const Guid.GuidStyles BraceFormat = 96;
	public const Guid.GuidStyles ParenthesisFormat = 80;
	public const Guid.GuidStyles Any = 15;

}

private enum Guid.GuidParseThrowStyle // TypeDefIndex: 243
{	// Fields
	public int value__; // 0x0
	public const Guid.GuidParseThrowStyle None = 0;
	public const Guid.GuidParseThrowStyle All = 1;
	public const Guid.GuidParseThrowStyle AllButOverflow = 2;

}

private enum Guid.ParseFailureKind // TypeDefIndex: 244
{	// Fields
	public int value__; // 0x0
	public const Guid.ParseFailureKind None = 0;
	public const Guid.ParseFailureKind ArgumentNull = 1;
	public const Guid.ParseFailureKind Format = 2;
	public const Guid.ParseFailureKind FormatWithParameter = 3;
	public const Guid.ParseFailureKind NativeException = 4;
	public const Guid.ParseFailureKind FormatWithInnerException = 5;

}

private struct Guid.GuidResult // TypeDefIndex: 245
{	// Fields
	internal Guid parsedGuid; // 0x0
	internal Guid.GuidParseThrowStyle throwStyle; // 0x10
	internal Guid.ParseFailureKind m_failure; // 0x14
	internal string m_failureMessageID; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal string m_failureArgumentName; // 0x28
	internal Exception m_innerException; // 0x30

	// Methods

	// RVA: 0x1ECA00 Offset: 0x1EBE00 VA: 0x1801ECA00
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x1ECA80 Offset: 0x1EBE80 VA: 0x1801ECA80
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x1ECA40 Offset: 0x1EBE40 VA: 0x1801ECA40
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1ECA10 Offset: 0x1EBE10 VA: 0x1801ECA10
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1ECA70 Offset: 0x1EBE70 VA: 0x1801ECA70
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x1EC9F0 Offset: 0x1EBDF0 VA: 0x1801EC9F0
	internal Exception GetGuidParseException() { }

}

