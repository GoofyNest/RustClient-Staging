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

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	internal static string GetResourceString(string key) { }

	// RVA: 0x10DB860 Offset: 0x10D9E60 VA: 0x1810DB860
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x10DB760 Offset: 0x10D9D60 VA: 0x1810DB760
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x10DC2F0 Offset: 0x10DA8F0 VA: 0x1810DC2F0
	public static string get_CurrentDirectory() { }

	// RVA: 0x10DC300 Offset: 0x10DA900 VA: 0x1810DC300
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x10DC330 Offset: 0x10DA930 VA: 0x1810DC330
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x10DC3B0 Offset: 0x10DA9B0 VA: 0x1810DC3B0
	public static string get_MachineName() { }

	// RVA: 0x10DB730 Offset: 0x10D9D30 VA: 0x1810DB730
	private static string GetNewLine() { }

	// RVA: 0x10DC3C0 Offset: 0x10DA9C0 VA: 0x1810DC3C0
	public static string get_NewLine() { }

	// RVA: 0x10DC6B0 Offset: 0x10DACB0 VA: 0x1810DC6B0
	private static PlatformID get_Platform() { }

	// RVA: 0x10DB740 Offset: 0x10D9D40 VA: 0x1810DB740
	internal static string GetOSVersionString() { }

	// RVA: 0x10DC430 Offset: 0x10DAA30 VA: 0x1810DC430
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x10DAF40 Offset: 0x10D9540 VA: 0x1810DAF40
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x10DC6D0 Offset: 0x10DACD0 VA: 0x1810DC6D0
	public static string get_StackTrace() { }

	// RVA: 0x10DC740 Offset: 0x10DAD40 VA: 0x1810DC740
	public static int get_TickCount() { }

	// RVA: 0x10DC3B0 Offset: 0x10DA9B0 VA: 0x1810DC3B0
	public static string get_UserDomainName() { }

	// RVA: 0x10DC750 Offset: 0x10DAD50 VA: 0x1810DC750
	public static string get_UserName() { }

	// RVA: 0x10DB0F0 Offset: 0x10D96F0 VA: 0x1810DB0F0
	public static void Exit(int exitCode) { }

	// RVA: 0x10DB100 Offset: 0x10D9700 VA: 0x1810DB100
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x10DB560 Offset: 0x10D9B60 VA: 0x1810DB560
	public static string[] GetCommandLineArgs() { }

	// RVA: 0x10DC830 Offset: 0x10DAE30 VA: 0x1810DC830
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x10DC760 Offset: 0x10DAD60 VA: 0x1810DC760
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x10DB580 Offset: 0x10D9B80 VA: 0x1810DB580
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x10DB590 Offset: 0x10D9B90 VA: 0x1810DB590
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x10DB680 Offset: 0x10D9C80 VA: 0x1810DB680
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x10DB960 Offset: 0x10D9F60 VA: 0x1810DB960
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x10DB6C0 Offset: 0x10D9CC0 VA: 0x1810DB6C0
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10DB980 Offset: 0x10D9F80 VA: 0x1810DB980
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x10DBE70 Offset: 0x10DA470 VA: 0x1810DBE70
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10DB710 Offset: 0x10D9D10 VA: 0x1810DB710
	public static string[] GetLogicalDrives() { }

	// RVA: 0x10DBD00 Offset: 0x10DA300 VA: 0x1810DBD00
	public static void SetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10DB970 Offset: 0x10D9F70 VA: 0x1810DB970
	internal static void InternalSetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10DB4B0 Offset: 0x10D9AB0 VA: 0x1810DB4B0
	public static void FailFast(string message) { }

	// RVA: 0x10DB500 Offset: 0x10D9B00 VA: 0x1810DB500
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x10DC340 Offset: 0x10DA940 VA: 0x1810DC340
	public static bool get_Is64BitProcess() { }

	// RVA: 0x10DC6C0 Offset: 0x10DACC0 VA: 0x1810DC6C0
	public static int get_ProcessorCount() { }

	// RVA: 0x10DC360 Offset: 0x10DA960 VA: 0x1810DC360
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x10DB710 Offset: 0x10D9D10 VA: 0x1810DB710
	private static string[] GetLogicalDrivesInternal() { }

	// RVA: 0x10DB570 Offset: 0x10D9B70 VA: 0x1810DB570
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x10DB720 Offset: 0x10D9D20 VA: 0x1810DB720
	internal static string GetMachineConfigPath() { }

	// RVA: 0x10DC840 Offset: 0x10DAE40 VA: 0x1810DC840
	internal static string internalGetHome() { }

	// RVA: 0x10DB750 Offset: 0x10D9D50 VA: 0x1810DB750
	internal static int GetPageSize() { }

	// RVA: 0x10DC380 Offset: 0x10DA980 VA: 0x1810DC380
	internal static bool get_IsUnix() { }

	// RVA: 0x10DB8D0 Offset: 0x10D9ED0 VA: 0x1810DB8D0
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

	// RVA: 0x1D58680 Offset: 0x1D56C80 VA: 0x181D58680
	public static void ResetToPool(Environment instance) { }

	// RVA: 0x1D585C0 Offset: 0x1D56BC0 VA: 0x181D585C0
	public void ResetToPool() { }

	// RVA: 0x1D581C0 Offset: 0x1D567C0 VA: 0x181D581C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D56C80 Offset: 0x1D55280 VA: 0x181D56C80
	public void CopyTo(Environment instance) { }

	// RVA: 0x1D56CC0 Offset: 0x1D552C0 VA: 0x181D56CC0
	public Environment Copy() { }

	// RVA: 0x1D57520 Offset: 0x1D55B20 VA: 0x181D57520
	public static Environment Deserialize(Stream stream) { }

	// RVA: 0x1D56D50 Offset: 0x1D55350 VA: 0x181D56D50
	public static Environment DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D57490 Offset: 0x1D55A90 VA: 0x181D57490
	public static Environment DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D57E20 Offset: 0x1D56420 VA: 0x181D57E20
	public static Environment Deserialize(byte[] buffer) { }

	// RVA: 0x1D58300 Offset: 0x1D56900 VA: 0x181D58300
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D58D70 Offset: 0x1D57370 VA: 0x181D58D70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D58D90 Offset: 0x1D57390 VA: 0x181D58D90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Environment previous) { }

	// RVA: 0x1D585A0 Offset: 0x1D56BA0 VA: 0x181D585A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D57AA0 Offset: 0x1D560A0 VA: 0x181D57AA0
	public static Environment Deserialize(byte[] buffer, Environment instance, bool isDelta = False) { }

	// RVA: 0x1D57800 Offset: 0x1D55E00 VA: 0x181D57800
	public static Environment Deserialize(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D56DD0 Offset: 0x1D553D0 VA: 0x181D56DD0
	public static Environment DeserializeLengthDelimited(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D57140 Offset: 0x1D55740 VA: 0x181D57140
	public static Environment DeserializeLength(Stream stream, int length, Environment instance, bool isDelta) { }

	// RVA: 0x1D58740 Offset: 0x1D56D40 VA: 0x181D58740
	public static void SerializeDelta(Stream stream, Environment instance, Environment previous) { }

	// RVA: 0x1D58BC0 Offset: 0x1D571C0 VA: 0x181D58BC0
	public static void Serialize(Stream stream, Environment instance) { }

	// RVA: 0x1D58D60 Offset: 0x1D57360 VA: 0x181D58D60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D58D70 Offset: 0x1D57370 VA: 0x181D58D70
	public void ToProto(Stream stream) { }

	// RVA: 0x1D58AB0 Offset: 0x1D570B0 VA: 0x181D58AB0
	public static byte[] SerializeToBytes(Environment instance) { }

	// RVA: 0x1D58A00 Offset: 0x1D57000 VA: 0x181D58A00
	public static void SerializeLengthDelimited(Stream stream, Environment instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

