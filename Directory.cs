public static class Directory // TypeDefIndex: 618
{	// Methods

	// RVA: 0x137B540 Offset: 0x1379B40 VA: 0x18137B540
	public static string[] GetFiles(string path) { }

	// RVA: 0x137B340 Offset: 0x1379940 VA: 0x18137B340
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x137B410 Offset: 0x1379A10 VA: 0x18137B410
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B7E0 Offset: 0x1379DE0 VA: 0x18137B7E0
	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B1E0 Offset: 0x13797E0 VA: 0x18137B1E0
	public static string[] GetDirectories(string path) { }

	// RVA: 0x137B110 Offset: 0x1379710 VA: 0x18137B110
	public static string[] GetDirectories(string path, string searchPattern) { }

	// RVA: 0x137B6B0 Offset: 0x1379CB0 VA: 0x18137B6B0
	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B270 Offset: 0x1379870 VA: 0x18137B270
	public static string[] GetFileSystemEntries(string path, string searchPattern) { }

	// RVA: 0x137B7B0 Offset: 0x1379DB0 VA: 0x18137B7B0
	private static string[] InternalGetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B6E0 Offset: 0x1379CE0 VA: 0x18137B6E0
	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	// RVA: 0x137AD20 Offset: 0x1379320 VA: 0x18137AD20
	public static IEnumerable<string> EnumerateFiles(string path) { }

	// RVA: 0x137ABF0 Offset: 0x13791F0 VA: 0x18137ABF0
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B680 Offset: 0x1379C80 VA: 0x18137B680
	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137ABC0 Offset: 0x13791C0 VA: 0x18137ABC0
	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	// RVA: 0x137A6F0 Offset: 0x1378CF0 VA: 0x18137A6F0
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x137A540 Offset: 0x1378B40 VA: 0x18137A540
	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	// RVA: 0x137A920 Offset: 0x1378F20 VA: 0x18137A920
	public static void Delete(string path) { }

	// RVA: 0x137BB90 Offset: 0x137A190 VA: 0x18137BB90
	private static void RecursiveDelete(string path) { }

	// RVA: 0x137AB30 Offset: 0x1379130 VA: 0x18137AB30
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x137ADB0 Offset: 0x13793B0 VA: 0x18137ADB0
	public static bool Exists(string path) { }

	// RVA: 0x137AE70 Offset: 0x1379470 VA: 0x18137AE70
	public static string GetCurrentDirectory() { }

	// RVA: 0x137B5E0 Offset: 0x1379BE0 VA: 0x18137B5E0
	internal static string InsecureGetCurrentDirectory() { }

	// RVA: 0x137B5D0 Offset: 0x1379BD0 VA: 0x18137B5D0
	public static string[] GetLogicalDrives() { }

	// RVA: 0x137B810 Offset: 0x1379E10 VA: 0x18137B810
	public static void Move(string sourceDirName, string destDirName) { }

	// RVA: 0x137BDE0 Offset: 0x137A3E0 VA: 0x18137BDE0
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x137BDB0 Offset: 0x137A3B0 VA: 0x18137BDB0
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x137BE20 Offset: 0x137A420 VA: 0x18137BE20
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x137BDF0 Offset: 0x137A3F0 VA: 0x18137BDF0
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x137BE60 Offset: 0x137A460 VA: 0x18137BE60
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x137BE30 Offset: 0x137A430 VA: 0x18137BE30
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x137AF10 Offset: 0x1379510 VA: 0x18137AF10
	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

}

internal sealed class Directory.SearchData // TypeDefIndex: 619
{	// Fields
	public readonly string fullPath; // 0x10
	public readonly string userPath; // 0x18
	public readonly SearchOption searchOption; // 0x20

	// Methods

	// RVA: 0x13862C0 Offset: 0x13848C0 VA: 0x1813862C0
	public void .ctor(string fullPath, string userPath, SearchOption searchOption) { }

}

