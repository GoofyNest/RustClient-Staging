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

	// RVA: 0x10DAB30 Offset: 0x10D9130 VA: 0x1810DAB30
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x10DAA30 Offset: 0x10D9030 VA: 0x1810DAA30
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x10DB5C0 Offset: 0x10D9BC0 VA: 0x1810DB5C0
	public static string get_CurrentDirectory() { }

	// RVA: 0x10DB5D0 Offset: 0x10D9BD0 VA: 0x1810DB5D0
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x10DB600 Offset: 0x10D9C00 VA: 0x1810DB600
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x10DB680 Offset: 0x10D9C80 VA: 0x1810DB680
	public static string get_MachineName() { }

	// RVA: 0x10DAA00 Offset: 0x10D9000 VA: 0x1810DAA00
	private static string GetNewLine() { }

	// RVA: 0x10DB690 Offset: 0x10D9C90 VA: 0x1810DB690
	public static string get_NewLine() { }

	// RVA: 0x10DB980 Offset: 0x10D9F80 VA: 0x1810DB980
	private static PlatformID get_Platform() { }

	// RVA: 0x10DAA10 Offset: 0x10D9010 VA: 0x1810DAA10
	internal static string GetOSVersionString() { }

	// RVA: 0x10DB700 Offset: 0x10D9D00 VA: 0x1810DB700
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x10DA210 Offset: 0x10D8810 VA: 0x1810DA210
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x10DB9A0 Offset: 0x10D9FA0 VA: 0x1810DB9A0
	public static string get_StackTrace() { }

	// RVA: 0x10DBA10 Offset: 0x10DA010 VA: 0x1810DBA10
	public static int get_TickCount() { }

	// RVA: 0x10DB680 Offset: 0x10D9C80 VA: 0x1810DB680
	public static string get_UserDomainName() { }

	// RVA: 0x10DBA20 Offset: 0x10DA020 VA: 0x1810DBA20
	public static string get_UserName() { }

	// RVA: 0x10DA3C0 Offset: 0x10D89C0 VA: 0x1810DA3C0
	public static void Exit(int exitCode) { }

	// RVA: 0x10DA3D0 Offset: 0x10D89D0 VA: 0x1810DA3D0
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x10DA830 Offset: 0x10D8E30 VA: 0x1810DA830
	public static string[] GetCommandLineArgs() { }

	// RVA: 0x10DBB00 Offset: 0x10DA100 VA: 0x1810DBB00
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x10DBA30 Offset: 0x10DA030 VA: 0x1810DBA30
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x10DA850 Offset: 0x10D8E50 VA: 0x1810DA850
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x10DA860 Offset: 0x10D8E60 VA: 0x1810DA860
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x10DA950 Offset: 0x10D8F50 VA: 0x1810DA950
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x10DAC30 Offset: 0x10D9230 VA: 0x1810DAC30
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x10DA990 Offset: 0x10D8F90 VA: 0x1810DA990
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10DAC50 Offset: 0x10D9250 VA: 0x1810DAC50
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x10DB140 Offset: 0x10D9740 VA: 0x1810DB140
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10DA9E0 Offset: 0x10D8FE0 VA: 0x1810DA9E0
	public static string[] GetLogicalDrives() { }

	// RVA: 0x10DAFD0 Offset: 0x10D95D0 VA: 0x1810DAFD0
	public static void SetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10DAC40 Offset: 0x10D9240 VA: 0x1810DAC40
	internal static void InternalSetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10DA780 Offset: 0x10D8D80 VA: 0x1810DA780
	public static void FailFast(string message) { }

	// RVA: 0x10DA7D0 Offset: 0x10D8DD0 VA: 0x1810DA7D0
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x10DB610 Offset: 0x10D9C10 VA: 0x1810DB610
	public static bool get_Is64BitProcess() { }

	// RVA: 0x10DB990 Offset: 0x10D9F90 VA: 0x1810DB990
	public static int get_ProcessorCount() { }

	// RVA: 0x10DB630 Offset: 0x10D9C30 VA: 0x1810DB630
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x10DA9E0 Offset: 0x10D8FE0 VA: 0x1810DA9E0
	private static string[] GetLogicalDrivesInternal() { }

	// RVA: 0x10DA840 Offset: 0x10D8E40 VA: 0x1810DA840
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x10DA9F0 Offset: 0x10D8FF0 VA: 0x1810DA9F0
	internal static string GetMachineConfigPath() { }

	// RVA: 0x10DBB10 Offset: 0x10DA110 VA: 0x1810DBB10
	internal static string internalGetHome() { }

	// RVA: 0x10DAA20 Offset: 0x10D9020 VA: 0x1810DAA20
	internal static int GetPageSize() { }

	// RVA: 0x10DB650 Offset: 0x10D9C50 VA: 0x1810DB650
	internal static bool get_IsUnix() { }

	// RVA: 0x10DABA0 Offset: 0x10D91A0 VA: 0x1810DABA0
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

	// RVA: 0x1D57BD0 Offset: 0x1D561D0 VA: 0x181D57BD0
	public static void ResetToPool(Environment instance) { }

	// RVA: 0x1D57B10 Offset: 0x1D56110 VA: 0x181D57B10
	public void ResetToPool() { }

	// RVA: 0x1D57710 Offset: 0x1D55D10 VA: 0x181D57710 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D561D0 Offset: 0x1D547D0 VA: 0x181D561D0
	public void CopyTo(Environment instance) { }

	// RVA: 0x1D56210 Offset: 0x1D54810 VA: 0x181D56210
	public Environment Copy() { }

	// RVA: 0x1D56A70 Offset: 0x1D55070 VA: 0x181D56A70
	public static Environment Deserialize(Stream stream) { }

	// RVA: 0x1D562A0 Offset: 0x1D548A0 VA: 0x181D562A0
	public static Environment DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D569E0 Offset: 0x1D54FE0 VA: 0x181D569E0
	public static Environment DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D57370 Offset: 0x1D55970 VA: 0x181D57370
	public static Environment Deserialize(byte[] buffer) { }

	// RVA: 0x1D57850 Offset: 0x1D55E50 VA: 0x181D57850
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D582C0 Offset: 0x1D568C0 VA: 0x181D582C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D582E0 Offset: 0x1D568E0 VA: 0x181D582E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Environment previous) { }

	// RVA: 0x1D57AF0 Offset: 0x1D560F0 VA: 0x181D57AF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D56FF0 Offset: 0x1D555F0 VA: 0x181D56FF0
	public static Environment Deserialize(byte[] buffer, Environment instance, bool isDelta = False) { }

	// RVA: 0x1D56D50 Offset: 0x1D55350 VA: 0x181D56D50
	public static Environment Deserialize(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D56320 Offset: 0x1D54920 VA: 0x181D56320
	public static Environment DeserializeLengthDelimited(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D56690 Offset: 0x1D54C90 VA: 0x181D56690
	public static Environment DeserializeLength(Stream stream, int length, Environment instance, bool isDelta) { }

	// RVA: 0x1D57C90 Offset: 0x1D56290 VA: 0x181D57C90
	public static void SerializeDelta(Stream stream, Environment instance, Environment previous) { }

	// RVA: 0x1D58110 Offset: 0x1D56710 VA: 0x181D58110
	public static void Serialize(Stream stream, Environment instance) { }

	// RVA: 0x1D582B0 Offset: 0x1D568B0 VA: 0x181D582B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D582C0 Offset: 0x1D568C0 VA: 0x181D582C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D58000 Offset: 0x1D56600 VA: 0x181D58000
	public static byte[] SerializeToBytes(Environment instance) { }

	// RVA: 0x1D57F50 Offset: 0x1D56550 VA: 0x181D57F50
	public static void SerializeLengthDelimited(Stream stream, Environment instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

