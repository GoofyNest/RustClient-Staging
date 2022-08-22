public static class Environment // TypeDefIndex: 340
{	// Fields
	private const int mono_corlib_version = 1051100001;
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	// Properties
	public static string CurrentDirectory { get; }
	public static int CurrentManagedThreadId { get; }
	public static bool HasShutdownStarted { get; }
	public static string MachineName { get; }
	public static string NewLine { get; }
	private static PlatformID Platform { get; }
	public static OperatingSystem OSVersion { get; }
	public static string StackTrace { get; }
	public static int TickCount { get; }
	public static string UserDomainName { get; }
	public static string UserName { get; }
	public static bool Is64BitProcess { get; }
	public static int ProcessorCount { get; }
	internal static bool IsRunningOnWindows { get; }
	internal static bool IsUnix { get; }

	// Methods

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	internal static string GetResourceString(string key) { }

	// RVA: 0x10DADF0 Offset: 0x10D93F0 VA: 0x1810DADF0
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x10DACF0 Offset: 0x10D92F0 VA: 0x1810DACF0
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x10DB880 Offset: 0x10D9E80 VA: 0x1810DB880
	public static string get_CurrentDirectory() { }

	// RVA: 0x10DB890 Offset: 0x10D9E90 VA: 0x1810DB890
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x10DB8C0 Offset: 0x10D9EC0 VA: 0x1810DB8C0
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x10DB940 Offset: 0x10D9F40 VA: 0x1810DB940
	public static string get_MachineName() { }

	// RVA: 0x10DACC0 Offset: 0x10D92C0 VA: 0x1810DACC0
	private static string GetNewLine() { }

	// RVA: 0x10DB950 Offset: 0x10D9F50 VA: 0x1810DB950
	public static string get_NewLine() { }

	// RVA: 0x10DBC40 Offset: 0x10DA240 VA: 0x1810DBC40
	private static PlatformID get_Platform() { }

	// RVA: 0x10DACD0 Offset: 0x10D92D0 VA: 0x1810DACD0
	internal static string GetOSVersionString() { }

	// RVA: 0x10DB9C0 Offset: 0x10D9FC0 VA: 0x1810DB9C0
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x10DA4D0 Offset: 0x10D8AD0 VA: 0x1810DA4D0
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x10DBC60 Offset: 0x10DA260 VA: 0x1810DBC60
	public static string get_StackTrace() { }

	// RVA: 0x10DBCD0 Offset: 0x10DA2D0 VA: 0x1810DBCD0
	public static int get_TickCount() { }

	// RVA: 0x10DB940 Offset: 0x10D9F40 VA: 0x1810DB940
	public static string get_UserDomainName() { }

	// RVA: 0x10DBCE0 Offset: 0x10DA2E0 VA: 0x1810DBCE0
	public static string get_UserName() { }

	// RVA: 0x10DA680 Offset: 0x10D8C80 VA: 0x1810DA680
	public static void Exit(int exitCode) { }

	// RVA: 0x10DA690 Offset: 0x10D8C90 VA: 0x1810DA690
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x10DAAF0 Offset: 0x10D90F0 VA: 0x1810DAAF0
	public static string[] GetCommandLineArgs() { }

	// RVA: 0x10DBDC0 Offset: 0x10DA3C0 VA: 0x1810DBDC0
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x10DBCF0 Offset: 0x10DA2F0 VA: 0x1810DBCF0
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x10DAB10 Offset: 0x10D9110 VA: 0x1810DAB10
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x10DAB20 Offset: 0x10D9120 VA: 0x1810DAB20
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x10DAC10 Offset: 0x10D9210 VA: 0x1810DAC10
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x10DAEF0 Offset: 0x10D94F0 VA: 0x1810DAEF0
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x10DAC50 Offset: 0x10D9250 VA: 0x1810DAC50
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10DAF10 Offset: 0x10D9510 VA: 0x1810DAF10
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x10DB400 Offset: 0x10D9A00 VA: 0x1810DB400
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10DACA0 Offset: 0x10D92A0 VA: 0x1810DACA0
	public static string[] GetLogicalDrives() { }

	// RVA: 0x10DB290 Offset: 0x10D9890 VA: 0x1810DB290
	public static void SetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10DAF00 Offset: 0x10D9500 VA: 0x1810DAF00
	internal static void InternalSetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10DAA40 Offset: 0x10D9040 VA: 0x1810DAA40
	public static void FailFast(string message) { }

	// RVA: 0x10DAA90 Offset: 0x10D9090 VA: 0x1810DAA90
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x10DB8D0 Offset: 0x10D9ED0 VA: 0x1810DB8D0
	public static bool get_Is64BitProcess() { }

	// RVA: 0x10DBC50 Offset: 0x10DA250 VA: 0x1810DBC50
	public static int get_ProcessorCount() { }

	// RVA: 0x10DB8F0 Offset: 0x10D9EF0 VA: 0x1810DB8F0
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x10DACA0 Offset: 0x10D92A0 VA: 0x1810DACA0
	private static string[] GetLogicalDrivesInternal() { }

	// RVA: 0x10DAB00 Offset: 0x10D9100 VA: 0x1810DAB00
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x10DACB0 Offset: 0x10D92B0 VA: 0x1810DACB0
	internal static string GetMachineConfigPath() { }

	// RVA: 0x10DBDD0 Offset: 0x10DA3D0 VA: 0x1810DBDD0
	internal static string internalGetHome() { }

	// RVA: 0x10DACE0 Offset: 0x10D92E0 VA: 0x1810DACE0
	internal static int GetPageSize() { }

	// RVA: 0x10DB910 Offset: 0x10D9F10 VA: 0x1810DB910
	internal static bool get_IsUnix() { }

	// RVA: 0x10DAE60 Offset: 0x10D9460 VA: 0x1810DAE60
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

}

public enum Environment.SpecialFolder // TypeDefIndex: 341
{	// Fields
	public int value__; // 0x0
	public const Environment.SpecialFolder MyDocuments = 5;
	public const Environment.SpecialFolder Desktop = 0;
	public const Environment.SpecialFolder MyComputer = 17;
	public const Environment.SpecialFolder Programs = 2;
	public const Environment.SpecialFolder Personal = 5;
	public const Environment.SpecialFolder Favorites = 6;
	public const Environment.SpecialFolder Startup = 7;
	public const Environment.SpecialFolder Recent = 8;
	public const Environment.SpecialFolder SendTo = 9;
	public const Environment.SpecialFolder StartMenu = 11;
	public const Environment.SpecialFolder MyMusic = 13;
	public const Environment.SpecialFolder DesktopDirectory = 16;
	public const Environment.SpecialFolder Templates = 21;
	public const Environment.SpecialFolder ApplicationData = 26;
	public const Environment.SpecialFolder LocalApplicationData = 28;
	public const Environment.SpecialFolder InternetCache = 32;
	public const Environment.SpecialFolder Cookies = 33;
	public const Environment.SpecialFolder History = 34;
	public const Environment.SpecialFolder CommonApplicationData = 35;
	public const Environment.SpecialFolder System = 37;
	public const Environment.SpecialFolder ProgramFiles = 38;
	public const Environment.SpecialFolder MyPictures = 39;
	public const Environment.SpecialFolder CommonProgramFiles = 43;
	public const Environment.SpecialFolder MyVideos = 14;
	public const Environment.SpecialFolder NetworkShortcuts = 19;
	public const Environment.SpecialFolder Fonts = 20;
	public const Environment.SpecialFolder CommonStartMenu = 22;
	public const Environment.SpecialFolder CommonPrograms = 23;
	public const Environment.SpecialFolder CommonStartup = 24;
	public const Environment.SpecialFolder CommonDesktopDirectory = 25;
	public const Environment.SpecialFolder PrinterShortcuts = 27;
	public const Environment.SpecialFolder Windows = 36;
	public const Environment.SpecialFolder UserProfile = 40;
	public const Environment.SpecialFolder SystemX86 = 41;
	public const Environment.SpecialFolder ProgramFilesX86 = 42;
	public const Environment.SpecialFolder CommonProgramFilesX86 = 44;
	public const Environment.SpecialFolder CommonTemplates = 45;
	public const Environment.SpecialFolder CommonDocuments = 46;
	public const Environment.SpecialFolder CommonAdminTools = 47;
	public const Environment.SpecialFolder AdminTools = 48;
	public const Environment.SpecialFolder CommonMusic = 53;
	public const Environment.SpecialFolder CommonPictures = 54;
	public const Environment.SpecialFolder CommonVideos = 55;
	public const Environment.SpecialFolder Resources = 56;
	public const Environment.SpecialFolder LocalizedResources = 57;
	public const Environment.SpecialFolder CommonOemLinks = 58;
	public const Environment.SpecialFolder CDBurning = 59;

}

public enum Environment.SpecialFolderOption // TypeDefIndex: 342
{	// Fields
	public int value__; // 0x0
	public const Environment.SpecialFolderOption None = 0;
	public const Environment.SpecialFolderOption DoNotVerify = 16384;
	public const Environment.SpecialFolderOption Create = 32768;

}

public class Environment : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6298
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long dateTime; // 0x18
	public float clouds; // 0x20
	public float fog; // 0x24
	public float wind; // 0x28
	public float rain; // 0x2C
	public float engineTime; // 0x30

	// Methods

	// RVA: 0x1D57E90 Offset: 0x1D56490 VA: 0x181D57E90
	public static void ResetToPool(Environment instance) { }

	// RVA: 0x1D57DD0 Offset: 0x1D563D0 VA: 0x181D57DD0
	public void ResetToPool() { }

	// RVA: 0x1D579D0 Offset: 0x1D55FD0 VA: 0x181D579D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D56490 Offset: 0x1D54A90 VA: 0x181D56490
	public void CopyTo(Environment instance) { }

	// RVA: 0x1D564D0 Offset: 0x1D54AD0 VA: 0x181D564D0
	public Environment Copy() { }

	// RVA: 0x1D56D30 Offset: 0x1D55330 VA: 0x181D56D30
	public static Environment Deserialize(Stream stream) { }

	// RVA: 0x1D56560 Offset: 0x1D54B60 VA: 0x181D56560
	public static Environment DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D56CA0 Offset: 0x1D552A0 VA: 0x181D56CA0
	public static Environment DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D57630 Offset: 0x1D55C30 VA: 0x181D57630
	public static Environment Deserialize(byte[] buffer) { }

	// RVA: 0x1D57B10 Offset: 0x1D56110 VA: 0x181D57B10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D58580 Offset: 0x1D56B80 VA: 0x181D58580 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D585A0 Offset: 0x1D56BA0 VA: 0x181D585A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Environment previous) { }

	// RVA: 0x1D57DB0 Offset: 0x1D563B0 VA: 0x181D57DB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D572B0 Offset: 0x1D558B0 VA: 0x181D572B0
	public static Environment Deserialize(byte[] buffer, Environment instance, bool isDelta = False) { }

	// RVA: 0x1D57010 Offset: 0x1D55610 VA: 0x181D57010
	public static Environment Deserialize(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D565E0 Offset: 0x1D54BE0 VA: 0x181D565E0
	public static Environment DeserializeLengthDelimited(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D56950 Offset: 0x1D54F50 VA: 0x181D56950
	public static Environment DeserializeLength(Stream stream, int length, Environment instance, bool isDelta) { }

	// RVA: 0x1D57F50 Offset: 0x1D56550 VA: 0x181D57F50
	public static void SerializeDelta(Stream stream, Environment instance, Environment previous) { }

	// RVA: 0x1D583D0 Offset: 0x1D569D0 VA: 0x181D583D0
	public static void Serialize(Stream stream, Environment instance) { }

	// RVA: 0x1D58570 Offset: 0x1D56B70 VA: 0x181D58570
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D58580 Offset: 0x1D56B80 VA: 0x181D58580
	public void ToProto(Stream stream) { }

	// RVA: 0x1D582C0 Offset: 0x1D568C0 VA: 0x181D582C0
	public static byte[] SerializeToBytes(Environment instance) { }

	// RVA: 0x1D58210 Offset: 0x1D56810 VA: 0x181D58210
	public static void SerializeLengthDelimited(Stream stream, Environment instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

