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

	// RVA: 0x2149420 Offset: 0x2147A20 VA: 0x182149420
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x2149080 Offset: 0x2147680 VA: 0x182149080
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x2149330 Offset: 0x2147930 VA: 0x182149330
	public void .ctor(int major, int minor) { }

	// RVA: 0x21491D0 Offset: 0x21477D0 VA: 0x1821491D0
	public void .ctor(string version) { }

	// RVA: 0x2149050 Offset: 0x2147650 VA: 0x182149050
	public void .ctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Major() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public int get_Minor() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Build() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public int get_Revision() { }

	// RVA: 0x2147D10 Offset: 0x2146310 VA: 0x182147D10 Slot: 4
	public object Clone() { }

	// RVA: 0x2147D90 Offset: 0x2146390 VA: 0x182147D90 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x2147EF0 Offset: 0x21464F0 VA: 0x182147EF0 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x2148090 Offset: 0x2146690 VA: 0x182148090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2147FF0 Offset: 0x21465F0 VA: 0x182147FF0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x2148190 Offset: 0x2146790 VA: 0x182148190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21487E0 Offset: 0x2146DE0 VA: 0x1821487E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x21482B0 Offset: 0x21468B0 VA: 0x1821482B0
	public string ToString(int fieldCount) { }

	// RVA: 0x2147C80 Offset: 0x2146280 VA: 0x182147C80
	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	// RVA: 0x21481C0 Offset: 0x21467C0 VA: 0x1821481C0
	public static Version Parse(string input) { }

	// RVA: 0x2148960 Offset: 0x2146F60 VA: 0x182148960
	private static bool TryParseVersion(string version, ref Version.VersionResult result) { }

	// RVA: 0x2148810 Offset: 0x2146E10 VA: 0x182148810
	private static bool TryParseComponent(string component, string componentName, ref Version.VersionResult result, out int parsedComponent) { }

	// RVA: 0x21495C0 Offset: 0x2147BC0 VA: 0x1821495C0
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x2149740 Offset: 0x2147D40 VA: 0x182149740
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x21498C0 Offset: 0x2147EC0 VA: 0x1821498C0
	public static bool op_LessThan(Version v1, Version v2) { }

	// RVA: 0x2149840 Offset: 0x2147E40 VA: 0x182149840
	public static bool op_LessThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2149680 Offset: 0x2147C80 VA: 0x182149680
	public static bool op_GreaterThanOrEqual(Version v1, Version v2) { }

	// RVA: 0x2148FD0 Offset: 0x21475D0 VA: 0x182148FD0
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

	// RVA: 0x234800 Offset: 0x233C00 VA: 0x180234800
	internal void Init(string argumentName, bool canThrow) { }

	// RVA: 0x234820 Offset: 0x233C20 VA: 0x180234820
	internal void SetFailure(Version.ParseFailureKind failure) { }

	// RVA: 0x234810 Offset: 0x233C10 VA: 0x180234810
	internal void SetFailure(Version.ParseFailureKind failure, string argument) { }

	// RVA: 0x2347F0 Offset: 0x233BF0 VA: 0x1802347F0
	internal Exception GetVersionParseException() { }

}

public static class Version // TypeDefIndex: 11555
{	// Fields
	public const int Current = 1510;

}

