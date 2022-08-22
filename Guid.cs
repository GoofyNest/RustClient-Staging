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

	// RVA: 0x1ED200 Offset: 0x1EC600 VA: 0x1801ED200
	public void .ctor(byte[] b) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1ED1B0 Offset: 0x1EC5B0 VA: 0x1801ED1B0
	public void .ctor(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ED1B0 Offset: 0x1EC5B0 VA: 0x1801ED1B0
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ED210 Offset: 0x1EC610 VA: 0x1801ED210
	public void .ctor(string g) { }

	// RVA: 0x137ECB0 Offset: 0x137D2B0 VA: 0x18137ECB0
	public static Guid Parse(string input) { }

	// RVA: 0x1380E90 Offset: 0x137F490 VA: 0x181380E90
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x1380C90 Offset: 0x137F290 VA: 0x181380C90
	private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x1380100 Offset: 0x137E700 VA: 0x181380100
	private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1380850 Offset: 0x137EE50 VA: 0x181380850
	private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x137FC50 Offset: 0x137E250 VA: 0x18137FC50
	private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x137F300 Offset: 0x137D900 VA: 0x18137F300
	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137F240 Offset: 0x137D840 VA: 0x18137F240
	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137EDF0 Offset: 0x137D3F0 VA: 0x18137EDF0
	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137F000 Offset: 0x137D600 VA: 0x18137F000
	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137EE90 Offset: 0x137D490 VA: 0x18137EE90
	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137F090 Offset: 0x137D690 VA: 0x18137F090
	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137F120 Offset: 0x137D720 VA: 0x18137F120
	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137E3D0 Offset: 0x137C9D0 VA: 0x18137E3D0
	private static string EatAllWhitespace(string str) { }

	// RVA: 0x137E980 Offset: 0x137CF80 VA: 0x18137E980
	private static bool IsHexPrefix(string str, int i) { }

	// RVA: 0x1ED140 Offset: 0x1EC540 VA: 0x1801ED140
	public byte[] ToByteArray() { }

	// RVA: 0x1ED150 Offset: 0x1EC550 VA: 0x1801ED150 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ED0F0 Offset: 0x1EC4F0 VA: 0x1801ED0F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ECE90 Offset: 0x1EC290 VA: 0x1801ECE90 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1ED000 Offset: 0x1EC400 VA: 0x1801ED000 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x1ED120 Offset: 0x1EC520 VA: 0x1801ED120
	private int GetResult(uint me, uint them) { }

	// RVA: 0x1ECE60 Offset: 0x1EC260 VA: 0x1801ECE60 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ECE70 Offset: 0x1EC270 VA: 0x1801ECE70 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x1381460 Offset: 0x137FA60 VA: 0x181381460
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x13815F0 Offset: 0x137FBF0 VA: 0x1813815F0
	public static bool op_Inequality(Guid a, Guid b) { }

	// RVA: 0x1ED1A0 Offset: 0x1EC5A0 VA: 0x1801ED1A0
	public string ToString(string format) { }

	// RVA: 0x137E770 Offset: 0x137CD70 VA: 0x18137E770
	private static char HexToChar(int a) { }

	// RVA: 0x137E790 Offset: 0x137CD90 VA: 0x18137E790
	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	// RVA: 0x137E820 Offset: 0x137CE20 VA: 0x18137E820
	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	// RVA: 0x1ED190 Offset: 0x1EC590 VA: 0x1801ED190 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x137EA70 Offset: 0x137D070 VA: 0x18137EA70
	public static Guid NewGuid() { }

	// RVA: 0x1380FC0 Offset: 0x137F5C0 VA: 0x181380FC0
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

	// RVA: 0x1ECDA0 Offset: 0x1EC1A0 VA: 0x1801ECDA0
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x1ECE20 Offset: 0x1EC220 VA: 0x1801ECE20
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x1ECDE0 Offset: 0x1EC1E0 VA: 0x1801ECDE0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1ECDB0 Offset: 0x1EC1B0 VA: 0x1801ECDB0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1ECE10 Offset: 0x1EC210 VA: 0x1801ECE10
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x1ECD90 Offset: 0x1EC190 VA: 0x1801ECD90
	internal Exception GetGuidParseException() { }

}

