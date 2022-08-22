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

	// RVA: 0x1ECDE0 Offset: 0x1EC1E0 VA: 0x1801ECDE0
	public void .ctor(byte[] b) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1ECD90 Offset: 0x1EC190 VA: 0x1801ECD90
	public void .ctor(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ECD90 Offset: 0x1EC190 VA: 0x1801ECD90
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x1ECDF0 Offset: 0x1EC1F0 VA: 0x1801ECDF0
	public void .ctor(string g) { }

	// RVA: 0x137FBB0 Offset: 0x137E1B0 VA: 0x18137FBB0
	public static Guid Parse(string input) { }

	// RVA: 0x1381D90 Offset: 0x1380390 VA: 0x181381D90
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x1381B90 Offset: 0x1380190 VA: 0x181381B90
	private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x1381000 Offset: 0x137F600 VA: 0x181381000
	private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1381750 Offset: 0x137FD50 VA: 0x181381750
	private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1380B50 Offset: 0x137F150 VA: 0x181380B50
	private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x1380200 Offset: 0x137E800 VA: 0x181380200
	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1380140 Offset: 0x137E740 VA: 0x181380140
	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FCF0 Offset: 0x137E2F0 VA: 0x18137FCF0
	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FF00 Offset: 0x137E500 VA: 0x18137FF00
	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FD90 Offset: 0x137E390 VA: 0x18137FD90
	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137FF90 Offset: 0x137E590 VA: 0x18137FF90
	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x1380020 Offset: 0x137E620 VA: 0x181380020
	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x137F2D0 Offset: 0x137D8D0 VA: 0x18137F2D0
	private static string EatAllWhitespace(string str) { }

	// RVA: 0x137F880 Offset: 0x137DE80 VA: 0x18137F880
	private static bool IsHexPrefix(string str, int i) { }

	// RVA: 0x1ECD20 Offset: 0x1EC120 VA: 0x1801ECD20
	public byte[] ToByteArray() { }

	// RVA: 0x1ECD30 Offset: 0x1EC130 VA: 0x1801ECD30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ECCD0 Offset: 0x1EC0D0 VA: 0x1801ECCD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ECA70 Offset: 0x1EBE70 VA: 0x1801ECA70 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1ECBE0 Offset: 0x1EBFE0 VA: 0x1801ECBE0 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x1ECD00 Offset: 0x1EC100 VA: 0x1801ECD00
	private int GetResult(uint me, uint them) { }

	// RVA: 0x1ECA40 Offset: 0x1EBE40 VA: 0x1801ECA40 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ECA50 Offset: 0x1EBE50 VA: 0x1801ECA50 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x1382360 Offset: 0x1380960 VA: 0x181382360
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x13824F0 Offset: 0x1380AF0 VA: 0x1813824F0
	public static bool op_Inequality(Guid a, Guid b) { }

	// RVA: 0x1ECD80 Offset: 0x1EC180 VA: 0x1801ECD80
	public string ToString(string format) { }

	// RVA: 0x137F670 Offset: 0x137DC70 VA: 0x18137F670
	private static char HexToChar(int a) { }

	// RVA: 0x137F690 Offset: 0x137DC90 VA: 0x18137F690
	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	// RVA: 0x137F720 Offset: 0x137DD20 VA: 0x18137F720
	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	// RVA: 0x1ECD70 Offset: 0x1EC170 VA: 0x1801ECD70 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x137F970 Offset: 0x137DF70 VA: 0x18137F970
	public static Guid NewGuid() { }

	// RVA: 0x1381EC0 Offset: 0x13804C0 VA: 0x181381EC0
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

	// RVA: 0x1EC980 Offset: 0x1EBD80 VA: 0x1801EC980
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x1ECA00 Offset: 0x1EBE00 VA: 0x1801ECA00
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x1EC9C0 Offset: 0x1EBDC0 VA: 0x1801EC9C0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x1EC990 Offset: 0x1EBD90 VA: 0x1801EC990
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x1EC9F0 Offset: 0x1EBDF0 VA: 0x1801EC9F0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x1EC970 Offset: 0x1EBD70 VA: 0x1801EC970
	internal Exception GetGuidParseException() { }

}

