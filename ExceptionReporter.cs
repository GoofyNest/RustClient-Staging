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
	// RVA: 0x14B3BB0 Offset: 0x14B21B0 VA: 0x1814B3BB0
	public static bool get_Disabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B42B0 Offset: 0x14B28B0 VA: 0x1814B42B0
	public static void set_Disabled(bool value) { }

	// RVA: 0x14B2C40 Offset: 0x14B1240 VA: 0x1814B2C40
	internal static void InstallHooks() { }

	// RVA: 0x14B2CA0 Offset: 0x14B12A0 VA: 0x1814B2CA0
	private static void OnLogMessage(string message, string stackTrace, LogType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B41F0 Offset: 0x14B27F0 VA: 0x1814B41F0
	public static string get_PublicKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B43F0 Offset: 0x14B29F0 VA: 0x1814B43F0
	private static void set_PublicKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4250 Offset: 0x14B2850 VA: 0x1814B4250
	public static string get_SecretKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4460 Offset: 0x14B2A60 VA: 0x1814B4460
	private static void set_SecretKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4070 Offset: 0x14B2670 VA: 0x1814B4070
	public static string get_Host() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4310 Offset: 0x14B2910 VA: 0x1814B4310
	private static void set_Host(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4130 Offset: 0x14B2730 VA: 0x1814B4130
	public static string get_ProjectId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14B4380 Offset: 0x14B2980 VA: 0x1814B4380
	private static void set_ProjectId(string value) { }

	// RVA: 0x14B2990 Offset: 0x14B0F90 VA: 0x1814B2990
	public static void InitializeFromUrl(string url) { }

	// RVA: 0x14B3170 Offset: 0x14B1770 VA: 0x1814B3170
	public static void SendReport(string exception, string stacktrace) { }

	// RVA: 0x14B3C10 Offset: 0x14B2210 VA: 0x1814B3C10
	private static Dictionary<string, string> get_Headers() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x14B3B40 Offset: 0x14B2140 VA: 0x1814B3B40
	private static void .cctor() { }

}

