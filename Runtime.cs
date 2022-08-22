public static class Runtime // TypeDefIndex: 4
{	// Methods

	// RVA: 0x164A560 Offset: 0x1648B60 VA: 0x18164A560
	private static void mono_runtime_install_handlers() { }

	// RVA: 0x164A560 Offset: 0x1648B60 VA: 0x18164A560
	public static void InstallSignalHandlers() { }

	// RVA: 0x164A570 Offset: 0x1648B70 VA: 0x18164A570
	private static void mono_runtime_cleanup_handlers() { }

	// RVA: 0x164A570 Offset: 0x1648B70 VA: 0x18164A570
	public static void RemoveSignalHandlers() { }

	// RVA: 0x164A550 Offset: 0x1648B50 VA: 0x18164A550
	public static string GetDisplayName() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private static string GetNativeStackTrace(Exception exception) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public static bool SetGCAllowSynchronousMajor(bool flag) { }

}

public static class Runtime // TypeDefIndex: 7162
{	// Fields
	private static readonly NativeClient.CallbackProgress nogc_AntiCheatProgress; // 0x0
	private static readonly NativeClient.CallbackFinished nogc_AntiCheatEvent; // 0x8
	private static bool initializeCalled; // 0x10
	private static EventHandler<StateChangedEventArgs> onStateChanged; // 0x18
	private static EventHandler<LoadCompletedEventArgs> onLoadCompleted; // 0x20
	private static EventHandler<LoadProgressEventArgs> onProgress; // 0x28
	private static NetProtect _NetProtect; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <Initialized>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static IntegrityDescriptor <Integrity>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static HostValidationResult <HostValidation>k__BackingField; // 0x50

	// Properties
	public static bool Initialized { get; set; }
	private static IntegrityDescriptor Integrity { set; }
	private static HostValidationResult HostValidation { set; }
	public static INetProtect NetProtect { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E81C0 Offset: 0x22E67C0 VA: 0x1822E81C0
	public static bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E82E0 Offset: 0x22E68E0 VA: 0x1822E82E0
	private static void set_Initialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8340 Offset: 0x22E6940 VA: 0x1822E8340
	private static void set_Integrity(IntegrityDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8280 Offset: 0x22E6880 VA: 0x1822E8280
	private static void set_HostValidation(HostValidationResult value) { }

	// RVA: 0x22E6E30 Offset: 0x22E5430 VA: 0x1822E6E30
	public static void Initialize(EventHandler<StateChangedEventArgs> onStateChanged, EventHandler<LoadCompletedEventArgs> onCompleted, EventHandler<LoadProgressEventArgs> onProgress) { }

	// RVA: 0x22E70C0 Offset: 0x22E56C0 VA: 0x1822E70C0
	public static bool IsActive() { }

	// RVA: 0x22E7E10 Offset: 0x22E6410 VA: 0x1822E7E10
	public static void Release() { }

	// RVA: 0x22E7F80 Offset: 0x22E6580 VA: 0x1822E7F80
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E6D70 Offset: 0x22E5370 VA: 0x1822E6D70
	public static void ConnectionReset() { }

	// RVA: 0x22E7B30 Offset: 0x22E6130 VA: 0x1822E7B30
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E7CB0 Offset: 0x22E62B0 VA: 0x1822E7CB0
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E79C0 Offset: 0x22E5FC0 VA: 0x1822E79C0
	public static void PollStatus() { }

	// RVA: 0x22E8220 Offset: 0x22E6820 VA: 0x1822E8220
	public static INetProtect get_NetProtect() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E78A0 Offset: 0x22E5EA0 VA: 0x1822E78A0
	private static uint OnInternalProgress(uint Progress, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7680 Offset: 0x22E5C80 VA: 0x1822E7680
	private static void OnInternalEvent(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E73E0 Offset: 0x22E59E0 VA: 0x1822E73E0
	private static uint OnIntegrityViolation(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7170 Offset: 0x22E5770 VA: 0x1822E7170
	private static bool OnHostValidation(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E80E0 Offset: 0x22E66E0 VA: 0x1822E80E0
	private static void .cctor() { }

}

private sealed class Runtime.<>c__DisplayClass19_0 // TypeDefIndex: 7163
{	// Fields
	public EventHandler<LoadCompletedEventArgs> onCompleted; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22E8430 Offset: 0x22E6A30 VA: 0x1822E8430
	internal void <Initialize>b__0(object s, LoadCompletedEventArgs args) { }

}

