public class ExceptionReporter : MonoBehaviour // TypeDefIndex: 6193
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <Disabled>k__BackingField; // 0x0
	private static readonly Stopwatch LastReportTime; // 0x8
	private static int _reportsSentCounter; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string <PublicKey>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string <SecretKey>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string <Host>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string <ProjectId>k__BackingField; // 0x30

	// Properties
	public static bool Disabled { get; set; }
	public static string PublicKey { get; set; }
	public static string SecretKey { get; set; }
	public static string Host { get; set; }
	public static string ProjectId { get; set; }
	private static Dictionary<string, string> Headers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B2C80 Offset: 0x14B1280 VA: 0x1814B2C80
	public static bool get_Disabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3380 Offset: 0x14B1980 VA: 0x1814B3380
	public static void set_Disabled(bool value) { }

	// RVA: 0x14B1D10 Offset: 0x14B0310 VA: 0x1814B1D10
	internal static void InstallHooks() { }

	// RVA: 0x14B1D70 Offset: 0x14B0370 VA: 0x1814B1D70
	private static void OnLogMessage(string message, string stackTrace, LogType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B32C0 Offset: 0x14B18C0 VA: 0x1814B32C0
	public static string get_PublicKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B34C0 Offset: 0x14B1AC0 VA: 0x1814B34C0
	private static void set_PublicKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3320 Offset: 0x14B1920 VA: 0x1814B3320
	public static string get_SecretKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3530 Offset: 0x14B1B30 VA: 0x1814B3530
	private static void set_SecretKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3140 Offset: 0x14B1740 VA: 0x1814B3140
	public static string get_Host() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B33E0 Offset: 0x14B19E0 VA: 0x1814B33E0
	private static void set_Host(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3200 Offset: 0x14B1800 VA: 0x1814B3200
	public static string get_ProjectId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3450 Offset: 0x14B1A50 VA: 0x1814B3450
	private static void set_ProjectId(string value) { }

	// RVA: 0x14B1A60 Offset: 0x14B0060 VA: 0x1814B1A60
	public static void InitializeFromUrl(string url) { }

	// RVA: 0x14B2240 Offset: 0x14B0840 VA: 0x1814B2240
	public static void SendReport(string exception, string stacktrace) { }

	// RVA: 0x14B2CE0 Offset: 0x14B12E0 VA: 0x1814B2CE0
	private static Dictionary<string, string> get_Headers() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x14B2C10 Offset: 0x14B1210 VA: 0x1814B2C10
	private static void .cctor() { }

}

