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
	// RVA: 0x14B38F0 Offset: 0x14B1EF0 VA: 0x1814B38F0
	public static bool get_Disabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3FF0 Offset: 0x14B25F0 VA: 0x1814B3FF0
	public static void set_Disabled(bool value) { }

	// RVA: 0x14B2980 Offset: 0x14B0F80 VA: 0x1814B2980
	internal static void InstallHooks() { }

	// RVA: 0x14B29E0 Offset: 0x14B0FE0 VA: 0x1814B29E0
	private static void OnLogMessage(string message, string stackTrace, LogType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3F30 Offset: 0x14B2530 VA: 0x1814B3F30
	public static string get_PublicKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4130 Offset: 0x14B2730 VA: 0x1814B4130
	private static void set_PublicKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3F90 Offset: 0x14B2590 VA: 0x1814B3F90
	public static string get_SecretKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B41A0 Offset: 0x14B27A0 VA: 0x1814B41A0
	private static void set_SecretKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3DB0 Offset: 0x14B23B0 VA: 0x1814B3DB0
	public static string get_Host() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4050 Offset: 0x14B2650 VA: 0x1814B4050
	private static void set_Host(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B3E70 Offset: 0x14B2470 VA: 0x1814B3E70
	public static string get_ProjectId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B40C0 Offset: 0x14B26C0 VA: 0x1814B40C0
	private static void set_ProjectId(string value) { }

	// RVA: 0x14B26D0 Offset: 0x14B0CD0 VA: 0x1814B26D0
	public static void InitializeFromUrl(string url) { }

	// RVA: 0x14B2EB0 Offset: 0x14B14B0 VA: 0x1814B2EB0
	public static void SendReport(string exception, string stacktrace) { }

	// RVA: 0x14B3950 Offset: 0x14B1F50 VA: 0x1814B3950
	private static Dictionary<string, string> get_Headers() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x14B3880 Offset: 0x14B1E80 VA: 0x1814B3880
	private static void .cctor() { }

}

