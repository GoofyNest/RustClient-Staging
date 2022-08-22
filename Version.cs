public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version> // TypeDefIndex: 334
{	// Fields
	private int _Major; // 0x10
	private int _Minor; // 0x14
	private int _Build; // 0x18
	private int _Revision; // 0x1C
	private static readonly char[] SeparatorsArray; // 0x0
	private const int ZERO_CHAR_VALUE = 48;

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }

	// Methods

	// RVA: 0x2149520 Offset: 0x2147B20 VA: 0x182149520
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x2149180 Offset: 0x2147780 VA: 0x182149180
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x2149430 Offset: 0x2147A30 VA: 0x182149430
	public void .ctor(int major, int minor) { }

	// RVA: 0x21492D0 Offset: 0x21478D0 VA: 0x1821492D0
	public void .ctor(string version) { }

	// RVA: 0x2149150 Offset: 0x2147750 VA: 0x182149150
	public void .ctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Major() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_Minor() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Build() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_Revision() { }

	// RVA: 0x2147E10 Offset: 0x2146410 VA: 0x182147E10 Slot: 4
	public object Clone() { }

	// RVA: 0x2147E90 Offset: 0x2146490 VA: 0x182147E90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x2147FF0 Offset: 0x21465F0 VA: 0x182147FF0 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x2148190 Offset: 0x2146790 VA: 0x182148190 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21480F0 Offset: 0x21466F0 VA: 0x1821480F0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x2148290 Offset: 0x2146890 VA: 0x182148290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21488E0 Offset: 0x2146EE0 VA: 0x1821488E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21483B0 Offset: 0x21469B0 VA: 0x1821483B0
	public string ToString(int fieldCount) { }

	// RVA: 0x2147D80 Offset: 0x2146380 VA: 0x182147D80
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x21482C0 Offset: 0x21468C0 VA: 0x1821482C0
	public static Version Parse(string input) { }

	// RVA: 0x2148A60 Offset: 0x2147060 VA: 0x182148A60
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x2148910 Offset: 0x2146F10 VA: 0x182148910
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x21496C0 Offset: 0x2147CC0 VA: 0x1821496C0
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x2149840 Offset: 0x2147E40 VA: 0x182149840
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x21499C0 Offset: 0x2147FC0 VA: 0x1821499C0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x2149940 Offset: 0x2147F40 VA: 0x182149940
	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2149780 Offset: 0x2147D80 VA: 0x182149780
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x21490D0 Offset: 0x21476D0 VA: 0x1821490D0
	private static void .cctor() { }

}

internal enum Version.ParseFailureKind // TypeDefIndex: 335
{	// Fields
	public int value__; // 0x0
	public const Version.ParseFailureKind ArgumentNullException = 0;
	public const Version.ParseFailureKind ArgumentException = 1;
	public const Version.ParseFailureKind ArgumentOutOfRangeException = 2;
	public const Version.ParseFailureKind FormatException = 3;

}

internal struct Version.VersionResult // TypeDefIndex: 336
{	// Fields
	internal Version m_parsedVersion; // 0x0
	internal Version.ParseFailureKind m_failure; // 0x8
	internal string m_exceptionArgument; // 0x10
	internal string m_argumentName; // 0x18
	internal bool m_canThrow; // 0x20

	// Methods

	// RVA: 0x234780 Offset: 0x233B80 VA: 0x180234780
	internal void Init(string argumentName, bool canThrow) { }

	// RVA: 0x2347A0 Offset: 0x233BA0 VA: 0x1802347A0
	internal void SetFailure(Version.ParseFailureKind failure) { }

	// RVA: 0x234790 Offset: 0x233B90 VA: 0x180234790
	internal void SetFailure(Version.ParseFailureKind failure, string argument) { }

	// RVA: 0x234770 Offset: 0x233B70 VA: 0x180234770
	internal Exception GetVersionParseException() { }

}

public static class Version // TypeDefIndex: 11555
{	// Fields
	public const int Current = 1510;

}

