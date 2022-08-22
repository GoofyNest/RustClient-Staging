public static class Path // TypeDefIndex: 678
{	// Fields
	[ObsoleteAttribute] // RVA: 0xA7F40 Offset: 0xA7340 VA: 0x1800A7F40
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Properties
	internal static string DirectorySeparatorCharAsString { get; }
	internal static char[] TrimEndChars { get; }

	// Methods

	// RVA: 0x162A220 Offset: 0x1628820 VA: 0x18162A220
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x162ABE0 Offset: 0x16291E0 VA: 0x18162ABE0
	public static string Combine(string path1, string path2) { }

	// RVA: 0x162A6F0 Offset: 0x1628CF0 VA: 0x18162A6F0
	internal static string CleanPath(string s) { }

	// RVA: 0x162B470 Offset: 0x1629A70 VA: 0x18162B470
	public static string GetDirectoryName(string path) { }

	// RVA: 0x162B880 Offset: 0x1629E80 VA: 0x18162B880
	public static string GetExtension(string path) { }

	// RVA: 0x162B9F0 Offset: 0x1629FF0 VA: 0x18162B9F0
	public static string GetFileName(string path) { }

	// RVA: 0x162B990 Offset: 0x1629F90 VA: 0x18162B990
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x162BF00 Offset: 0x162A500 VA: 0x18162BF00
	public static string GetFullPath(string path) { }

	// RVA: 0x162BB00 Offset: 0x162A100 VA: 0x18162BB00
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x162BB60 Offset: 0x162A160 VA: 0x18162BB60
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x162BC40 Offset: 0x162A240 VA: 0x18162BC40
	internal static string GetFullPathName(string path) { }

	// RVA: 0x162DFA0 Offset: 0x162C5A0 VA: 0x18162DFA0
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x162CC80 Offset: 0x162B280 VA: 0x18162CC80
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x162D6B0 Offset: 0x162BCB0 VA: 0x18162D6B0
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x162C070 Offset: 0x162A670 VA: 0x18162C070
	public static string GetPathRoot(string path) { }

	// RVA: 0x162C7E0 Offset: 0x162ADE0 VA: 0x18162C7E0
	public static string GetTempFileName() { }

	// RVA: 0x162CB60 Offset: 0x162B160 VA: 0x18162CB60
	public static string GetTempPath() { }

	// RVA: 0x162E690 Offset: 0x162CC90 VA: 0x18162E690
	private static string get_temp_path() { }

	// RVA: 0x162D740 Offset: 0x162BD40 VA: 0x18162D740
	public static bool IsPathRooted(string path) { }

	// RVA: 0x162BF60 Offset: 0x162A560 VA: 0x18162BF60
	public static char[] GetInvalidFileNameChars() { }

	// RVA: 0x162C000 Offset: 0x162A600 VA: 0x18162C000
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x162E4F0 Offset: 0x162CAF0 VA: 0x18162E4F0
	private static int findExtension(string path) { }

	// RVA: 0x162E250 Offset: 0x162C850 VA: 0x18162E250
	private static void .cctor() { }

	// RVA: 0x162C5A0 Offset: 0x162ABA0 VA: 0x18162C5A0
	private static string GetServerAndShare(string path) { }

	// RVA: 0x162D910 Offset: 0x162BF10 VA: 0x18162D910
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x16299F0 Offset: 0x1627FF0 VA: 0x1816299F0
	private static string CanonicalizePath(string path) { }

	// RVA: 0x162B120 Offset: 0x1629720 VA: 0x18162B120
	public static string Combine(string[] paths) { }

	// RVA: 0x162AEE0 Offset: 0x16294E0 VA: 0x18162AEE0
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x162DC40 Offset: 0x162C240 VA: 0x18162DC40
	internal static void Validate(string path) { }

	// RVA: 0x162DE10 Offset: 0x162C410 VA: 0x18162DE10
	internal static void Validate(string path, string parameterName) { }

	// RVA: 0x162E590 Offset: 0x162CB90 VA: 0x18162E590
	internal static string get_DirectorySeparatorCharAsString() { }

	// RVA: 0x162E5F0 Offset: 0x162CBF0 VA: 0x18162E5F0
	internal static char[] get_TrimEndChars() { }

	// RVA: 0x162A540 Offset: 0x1628B40 VA: 0x18162A540
	internal static void CheckSearchPattern(string searchPattern) { }

	// RVA: 0x162A430 Offset: 0x1628A30 VA: 0x18162A430
	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	// RVA: 0x162D3C0 Offset: 0x162B9C0 VA: 0x18162D3C0
	internal static string InternalCombine(string path1, string path2) { }

}

