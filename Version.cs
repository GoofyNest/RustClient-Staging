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

	// RVA: 0x2149260 Offset: 0x2147860 VA: 0x182149260
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x2148EC0 Offset: 0x21474C0 VA: 0x182148EC0
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x2149170 Offset: 0x2147770 VA: 0x182149170
	public void .ctor(int major, int minor) { }

	// RVA: 0x2149010 Offset: 0x2147610 VA: 0x182149010
	public void .ctor(string version) { }

	// RVA: 0x2148E90 Offset: 0x2147490 VA: 0x182148E90
	public void .ctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Major() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_Minor() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Build() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_Revision() { }

	// RVA: 0x2147B50 Offset: 0x2146150 VA: 0x182147B50 Slot: 4
	public object Clone() { }

	// RVA: 0x2147BD0 Offset: 0x21461D0 VA: 0x182147BD0 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x2147D30 Offset: 0x2146330 VA: 0x182147D30 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x2147ED0 Offset: 0x21464D0 VA: 0x182147ED0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2147E30 Offset: 0x2146430 VA: 0x182147E30 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x2147FD0 Offset: 0x21465D0 VA: 0x182147FD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2148620 Offset: 0x2146C20 VA: 0x182148620 Slot: 3
	public override string ToString() { }

	// RVA: 0x21480F0 Offset: 0x21466F0 VA: 0x1821480F0
	public string ToString(int fieldCount) { }

	// RVA: 0x2147AC0 Offset: 0x21460C0 VA: 0x182147AC0
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x2148000 Offset: 0x2146600 VA: 0x182148000
	public static Version Parse(string input) { }

	// RVA: 0x21487A0 Offset: 0x2146DA0 VA: 0x1821487A0
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x2148650 Offset: 0x2146C50 VA: 0x182148650
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x2149400 Offset: 0x2147A00 VA: 0x182149400
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x2149580 Offset: 0x2147B80 VA: 0x182149580
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x2149700 Offset: 0x2147D00 VA: 0x182149700
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x2149680 Offset: 0x2147C80 VA: 0x182149680
	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x21494C0 Offset: 0x2147AC0 VA: 0x1821494C0
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2148E10 Offset: 0x2147410 VA: 0x182148E10
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

