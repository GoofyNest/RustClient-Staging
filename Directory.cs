public static class Directory // TypeDefIndex: 618
{	// Methods

	// RVA: 0x137B280 Offset: 0x1379880 VA: 0x18137B280
	public static string[] GetFiles(string path) { }

	// RVA: 0x137B080 Offset: 0x1379680 VA: 0x18137B080
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x137B150 Offset: 0x1379750 VA: 0x18137B150
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B520 Offset: 0x1379B20 VA: 0x18137B520
	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137AF20 Offset: 0x1379520 VA: 0x18137AF20
	public static string[] GetDirectories(string path) { }

	// RVA: 0x137AE50 Offset: 0x1379450 VA: 0x18137AE50
	public static string[] GetDirectories(string path, string searchPattern) { }

	// RVA: 0x137B3F0 Offset: 0x13799F0 VA: 0x18137B3F0
	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137AFB0 Offset: 0x13795B0 VA: 0x18137AFB0
	public static string[] GetFileSystemEntries(string path, string searchPattern) { }

	// RVA: 0x137B4F0 Offset: 0x1379AF0 VA: 0x18137B4F0
	private static string[] InternalGetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B420 Offset: 0x1379A20 VA: 0x18137B420
	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	// RVA: 0x137AA60 Offset: 0x1379060 VA: 0x18137AA60
	public static IEnumerable<string> EnumerateFiles(string path) { }

	// RVA: 0x137A930 Offset: 0x1378F30 VA: 0x18137A930
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137B3C0 Offset: 0x13799C0 VA: 0x18137B3C0
	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x137A900 Offset: 0x1378F00 VA: 0x18137A900
	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	// RVA: 0x137A430 Offset: 0x1378A30 VA: 0x18137A430
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x137A280 Offset: 0x1378880 VA: 0x18137A280
	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	// RVA: 0x137A660 Offset: 0x1378C60 VA: 0x18137A660
	public static void Delete(string path) { }

	// RVA: 0x137B8D0 Offset: 0x1379ED0 VA: 0x18137B8D0
	private static void RecursiveDelete(string path) { }

	// RVA: 0x137A870 Offset: 0x1378E70 VA: 0x18137A870
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x137AAF0 Offset: 0x13790F0 VA: 0x18137AAF0
	public static bool Exists(string path) { }

	// RVA: 0x137ABB0 Offset: 0x13791B0 VA: 0x18137ABB0
	public static string GetCurrentDirectory() { }

	// RVA: 0x137B320 Offset: 0x1379920 VA: 0x18137B320
	internal static string InsecureGetCurrentDirectory() { }

	// RVA: 0x137B310 Offset: 0x1379910 VA: 0x18137B310
	public static string[] GetLogicalDrives() { }

	// RVA: 0x137B550 Offset: 0x1379B50 VA: 0x18137B550
	public static void Move(string sourceDirName, string destDirName) { }

	// RVA: 0x137BB20 Offset: 0x137A120 VA: 0x18137BB20
	public static void SetCreationTime(string path, DateTime creationTime) { }

	// RVA: 0x137BAF0 Offset: 0x137A0F0 VA: 0x18137BAF0
	public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc) { }

	// RVA: 0x137BB60 Offset: 0x137A160 VA: 0x18137BB60
	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	// RVA: 0x137BB30 Offset: 0x137A130 VA: 0x18137BB30
	public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) { }

	// RVA: 0x137BBA0 Offset: 0x137A1A0 VA: 0x18137BBA0
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x137BB70 Offset: 0x137A170 VA: 0x18137BB70
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x137AC50 Offset: 0x1379250 VA: 0x18137AC50
	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

}

internal sealed class Directory.SearchData // TypeDefIndex: 619
{	// Fields
	public readonly string fullPath; // 0x10
	public readonly string userPath; // 0x18
	public readonly SearchOption searchOption; // 0x20

	// Methods

	// RVA: 0x1386000 Offset: 0x1384600 VA: 0x181386000
	public void .ctor(string fullPath, string userPath, SearchOption searchOption) { }

}

