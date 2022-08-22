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

	// RVA: 0x2149D40 Offset: 0x2148340 VA: 0x182149D40
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x21499A0 Offset: 0x2147FA0 VA: 0x1821499A0
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x2149C50 Offset: 0x2148250 VA: 0x182149C50
	public void .ctor(int major, int minor) { }

	// RVA: 0x2149AF0 Offset: 0x21480F0 VA: 0x182149AF0
	public void .ctor(string version) { }

	// RVA: 0x2149970 Offset: 0x2147F70 VA: 0x182149970
	public void .ctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Major() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public int get_Minor() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Build() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public int get_Revision() { }

	// RVA: 0x2148630 Offset: 0x2146C30 VA: 0x182148630 Slot: 4
	public object Clone() { }

	// RVA: 0x21486B0 Offset: 0x2146CB0 VA: 0x1821486B0 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x2148810 Offset: 0x2146E10 VA: 0x182148810 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x21489B0 Offset: 0x2146FB0 VA: 0x1821489B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2148910 Offset: 0x2146F10 VA: 0x182148910 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x2148AB0 Offset: 0x21470B0 VA: 0x182148AB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2149100 Offset: 0x2147700 VA: 0x182149100 Slot: 3
	public override string ToString() { }

	// RVA: 0x2148BD0 Offset: 0x21471D0 VA: 0x182148BD0
	public string ToString(int fieldCount) { }

	// RVA: 0x21485A0 Offset: 0x2146BA0 VA: 0x1821485A0
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x2148AE0 Offset: 0x21470E0 VA: 0x182148AE0
	public static Version Parse(string input) { }

	// RVA: 0x2149280 Offset: 0x2147880 VA: 0x182149280
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x2149130 Offset: 0x2147730 VA: 0x182149130
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x2149EE0 Offset: 0x21484E0 VA: 0x182149EE0
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x214A060 Offset: 0x2148660 VA: 0x18214A060
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x214A1E0 Offset: 0x21487E0 VA: 0x18214A1E0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x214A160 Offset: 0x2148760 VA: 0x18214A160
	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2149FA0 Offset: 0x21485A0 VA: 0x182149FA0
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x21498F0 Offset: 0x2147EF0 VA: 0x1821498F0
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

