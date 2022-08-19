public static class Path // TypeDefIndex: 678
{	// Fields
	[ObsoleteAttribute] // RVA: 0xA7F20 Offset: 0xA7320 VA: 0x1800A7F20
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

	// RVA: 0x1629F60 Offset: 0x1628560 VA: 0x181629F60
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x162A920 Offset: 0x1628F20 VA: 0x18162A920
	public static string Combine(string path1, string path2) { }

	// RVA: 0x162A430 Offset: 0x1628A30 VA: 0x18162A430
	internal static string CleanPath(string s) { }

	// RVA: 0x162B1B0 Offset: 0x16297B0 VA: 0x18162B1B0
	public static string GetDirectoryName(string path) { }

	// RVA: 0x162B5C0 Offset: 0x1629BC0 VA: 0x18162B5C0
	public static string GetExtension(string path) { }

	// RVA: 0x162B730 Offset: 0x1629D30 VA: 0x18162B730
	public static string GetFileName(string path) { }

	// RVA: 0x162B6D0 Offset: 0x1629CD0 VA: 0x18162B6D0
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x162BC40 Offset: 0x162A240 VA: 0x18162BC40
	public static string GetFullPath(string path) { }

	// RVA: 0x162B840 Offset: 0x1629E40 VA: 0x18162B840
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x162B8A0 Offset: 0x1629EA0 VA: 0x18162B8A0
	private static extern int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull) { }

	// RVA: 0x162B980 Offset: 0x1629F80 VA: 0x18162B980
	internal static string GetFullPathName(string path) { }

	// RVA: 0x162DCE0 Offset: 0x162C2E0 VA: 0x18162DCE0
	internal static string WindowsDriveAdjustment(string path) { }

	// RVA: 0x162C9C0 Offset: 0x162AFC0 VA: 0x18162C9C0
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x162D3F0 Offset: 0x162B9F0 VA: 0x18162D3F0
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x162BDB0 Offset: 0x162A3B0 VA: 0x18162BDB0
	public static string GetPathRoot(string path) { }

	// RVA: 0x162C520 Offset: 0x162AB20 VA: 0x18162C520
	public static string GetTempFileName() { }

	// RVA: 0x162C8A0 Offset: 0x162AEA0 VA: 0x18162C8A0
	public static string GetTempPath() { }

	// RVA: 0x162E3D0 Offset: 0x162C9D0 VA: 0x18162E3D0
	private static string get_temp_path() { }

	// RVA: 0x162D480 Offset: 0x162BA80 VA: 0x18162D480
	public static bool IsPathRooted(string path) { }

	// RVA: 0x162BCA0 Offset: 0x162A2A0 VA: 0x18162BCA0
	public static char[] GetInvalidFileNameChars() { }

	// RVA: 0x162BD40 Offset: 0x162A340 VA: 0x18162BD40
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x162E230 Offset: 0x162C830 VA: 0x18162E230
	private static int findExtension(string path) { }

	// RVA: 0x162DF90 Offset: 0x162C590 VA: 0x18162DF90
	private static void .cctor() { }

	// RVA: 0x162C2E0 Offset: 0x162A8E0 VA: 0x18162C2E0
	private static string GetServerAndShare(string path) { }

	// RVA: 0x162D650 Offset: 0x162BC50 VA: 0x18162D650
	private static bool SameRoot(string root, string path) { }

	// RVA: 0x1629730 Offset: 0x1627D30 VA: 0x181629730
	private static string CanonicalizePath(string path) { }

	// RVA: 0x162AE60 Offset: 0x1629460 VA: 0x18162AE60
	public static string Combine(string[] paths) { }

	// RVA: 0x162AC20 Offset: 0x1629220 VA: 0x18162AC20
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x162D980 Offset: 0x162BF80 VA: 0x18162D980
	internal static void Validate(string path) { }

	// RVA: 0x162DB50 Offset: 0x162C150 VA: 0x18162DB50
	internal static void Validate(string path, string parameterName) { }

	// RVA: 0x162E2D0 Offset: 0x162C8D0 VA: 0x18162E2D0
	internal static string get_DirectorySeparatorCharAsString() { }

	// RVA: 0x162E330 Offset: 0x162C930 VA: 0x18162E330
	internal static char[] get_TrimEndChars() { }

	// RVA: 0x162A280 Offset: 0x1628880 VA: 0x18162A280
	internal static void CheckSearchPattern(string searchPattern) { }

	// RVA: 0x162A170 Offset: 0x1628770 VA: 0x18162A170
	internal static void CheckInvalidPathChars(string path, bool checkAdditional = False) { }

	// RVA: 0x162D100 Offset: 0x162B700 VA: 0x18162D100
	internal static string InternalCombine(string path1, string path2) { }

}

