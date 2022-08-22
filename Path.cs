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

	// RVA: 0x1617540 Offset: 0x1615B40 VA: 0x181617540
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x1617F00 Offset: 0x1616500 VA: 0x181617F00
	public static string Combine(string path1, string path2) { }

	// RVA: 0x1617A10 Offset: 0x1616010 VA: 0x181617A10
	internal static string CleanPath(string s) { }

	// RVA: 0x1618790 Offset: 0x1616D90 VA: 0x181618790
	public static string GetDirectoryName(string path) { }

	// RVA: 0x1618BA0 Offset: 0x16171A0 VA: 0x181618BA0
	public static string GetExtension(string path) { }

	// RVA: 0x1618D10 Offset: 0x1617310 VA: 0x181618D10
	public static string GetFileName(string path) { }

	// RVA: 0x1618CB0 Offset: 0x16172B0 VA: 0x181618CB0
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x1619220 Offset: 0x1617820 VA: 0x181619220
	public static string GetFullPath(string path) { }

	// RVA: 0x1618E20 Offset: 0x1617420 VA: 0x181618E20
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x1618E80 Offset: 0x1617480 VA: 0x181618E80
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x1618F60 Offset: 0x1617560 VA: 0x181618F60
	internal static string GetFullPathName(string path) { }

	// RVA: 0x161B2C0 Offset: 0x16198C0 VA: 0x18161B2C0
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x1619FA0 Offset: 0x16185A0 VA: 0x181619FA0
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x161A9D0 Offset: 0x1618FD0 VA: 0x18161A9D0
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x1619390 Offset: 0x1617990 VA: 0x181619390
	public static string GetPathRoot(string path) { }

	// RVA: 0x1619B00 Offset: 0x1618100 VA: 0x181619B00
	public static string GetTempFileName() { }

	// RVA: 0x1619E80 Offset: 0x1618480 VA: 0x181619E80
	public static string GetTempPath() { }

	// RVA: 0x161B9B0 Offset: 0x1619FB0 VA: 0x18161B9B0
	private static string get_temp_path() { }

	// RVA: 0x161AA60 Offset: 0x1619060 VA: 0x18161AA60
	public static bool IsPathRooted(string path) { }

	// RVA: 0x1619280 Offset: 0x1617880 VA: 0x181619280
	public static char[] GetInvalidFileNameChars() { }

	// RVA: 0x1619320 Offset: 0x1617920 VA: 0x181619320
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x161B810 Offset: 0x1619E10 VA: 0x18161B810
	private static int findExtension(string path) { }

	// RVA: 0x161B570 Offset: 0x1619B70 VA: 0x18161B570
	private static void .cctor() { }

	// RVA: 0x16198C0 Offset: 0x1617EC0 VA: 0x1816198C0
	private static string GetServerAndShare(string path) { }

	// RVA: 0x161AC30 Offset: 0x1619230 VA: 0x18161AC30
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x1616D10 Offset: 0x1615310 VA: 0x181616D10
	private static string CanonicalizePath(string path) { }

	// RVA: 0x1618440 Offset: 0x1616A40 VA: 0x181618440
	public static string Combine(string[] paths) { }

	// RVA: 0x1618200 Offset: 0x1616800 VA: 0x181618200
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x161AF60 Offset: 0x1619560 VA: 0x18161AF60
	internal static void Validate(string path) { }

	// RVA: 0x161B130 Offset: 0x1619730 VA: 0x18161B130
	internal static void Validate(string path, string parameterName) { }

	// RVA: 0x161B8B0 Offset: 0x1619EB0 VA: 0x18161B8B0
	internal static string get_DirectorySeparatorCharAsString() { }

	// RVA: 0x161B910 Offset: 0x1619F10 VA: 0x18161B910
	internal static char[] get_TrimEndChars() { }

	// RVA: 0x1617860 Offset: 0x1615E60 VA: 0x181617860
	internal static void CheckSearchPattern(string searchPattern) { }

	// RVA: 0x1617750 Offset: 0x1615D50 VA: 0x181617750
	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	// RVA: 0x161A6E0 Offset: 0x1618CE0 VA: 0x18161A6E0
	internal static string InternalCombine(string path1, string path2) { }

}

