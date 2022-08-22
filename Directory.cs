public static class Directory // TypeDefIndex: 618
{	// Methods

	// RVA: 0x137A640 Offset: 0x1378C40 VA: 0x18137A640
	public static string[] GetFiles(string path) { }

	// RVA: 0x137A440 Offset: 0x1378A40 VA: 0x18137A440
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x137A510 Offset: 0x1378B10 VA: 0x18137A510
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137A8E0 Offset: 0x1378EE0 VA: 0x18137A8E0
	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137A2E0 Offset: 0x13788E0 VA: 0x18137A2E0
	public static string[] GetDirectories(string path) { }

	// RVA: 0x137A210 Offset: 0x1378810 VA: 0x18137A210
	public static string[] GetDirectories(string path, string searchPattern) { }

	// RVA: 0x137A7B0 Offset: 0x1378DB0 VA: 0x18137A7B0
	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137A370 Offset: 0x1378970 VA: 0x18137A370
	public static string[] GetFileSystemEntries(string path, string searchPattern) { }

	// RVA: 0x137A8B0 Offset: 0x1378EB0 VA: 0x18137A8B0
	private static string[] InternalGetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137A7E0 Offset: 0x1378DE0 VA: 0x18137A7E0
	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	// RVA: 0x1379E20 Offset: 0x1378420 VA: 0x181379E20
	public static IEnumerable<string> EnumerateFiles(string path) { }

	// RVA: 0x1379CF0 Offset: 0x13782F0 VA: 0x181379CF0
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137A780 Offset: 0x1378D80 VA: 0x18137A780
	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1379CC0 Offset: 0x13782C0 VA: 0x181379CC0
	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	// RVA: 0x13797F0 Offset: 0x1377DF0 VA: 0x1813797F0
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x1379640 Offset: 0x1377C40 VA: 0x181379640
	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	// RVA: 0x1379A20 Offset: 0x1378020 VA: 0x181379A20
	public static void Delete(string path) { }

	// RVA: 0x137AC90 Offset: 0x1379290 VA: 0x18137AC90
	private static void RecursiveDelete(string path) { }

	// RVA: 0x1379C30 Offset: 0x1378230 VA: 0x181379C30
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x1379EB0 Offset: 0x13784B0 VA: 0x181379EB0
	public static bool Exists(string path) { }

	// RVA: 0x1379F70 Offset: 0x1378570 VA: 0x181379F70
	public static string GetCurrentDirectory() { }

	// RVA: 0x137A6E0 Offset: 0x1378CE0 VA: 0x18137A6E0
	internal static string InsecureGetCurrentDirectory() { }

	// RVA: 0x137A6D0 Offset: 0x1378CD0 VA: 0x18137A6D0
	public static string[] GetLogicalDrives() { }

	// RVA: 0x137A910 Offset: 0x1378F10 VA: 0x18137A910
	public static void Move(string sourceDirName, string destDirName) { }

	// RVA: 0x137AEE0 Offset: 0x13794E0 VA: 0x18137AEE0
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x137AEB0 Offset: 0x13794B0 VA: 0x18137AEB0
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x137AF20 Offset: 0x1379520 VA: 0x18137AF20
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x137AEF0 Offset: 0x13794F0 VA: 0x18137AEF0
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x137AF60 Offset: 0x1379560 VA: 0x18137AF60
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x137AF30 Offset: 0x1379530 VA: 0x18137AF30
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x137A010 Offset: 0x1378610 VA: 0x18137A010
	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

}

internal sealed class Directory.SearchData // TypeDefIndex: 619
{	// Fields
	public readonly string fullPath; // 0x10
	public readonly string userPath; // 0x18
	public readonly SearchOption searchOption; // 0x20

	// Methods

	// RVA: 0x13853C0 Offset: 0x13839C0 VA: 0x1813853C0
	public void .ctor(string fullPath, string userPath, SearchOption searchOption) { }

}

