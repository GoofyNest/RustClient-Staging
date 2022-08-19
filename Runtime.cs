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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static bool <Initialized>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static IntegrityDescriptor <Integrity>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static HostValidationResult <HostValidation>k__BackingField; // 0x50

	// Properties
	public static bool Initialized { get; set; }
	private static IntegrityDescriptor Integrity { set; }
	private static HostValidationResult HostValidation { set; }
	public static INetProtect NetProtect { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E8380 Offset: 0x22E6980 VA: 0x1822E8380
	public static bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E84A0 Offset: 0x22E6AA0 VA: 0x1822E84A0
	private static void set_Initialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E8500 Offset: 0x22E6B00 VA: 0x1822E8500
	private static void set_Integrity(IntegrityDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E8440 Offset: 0x22E6A40 VA: 0x1822E8440
	private static void set_HostValidation(HostValidationResult value) { }

	// RVA: 0x22E6FF0 Offset: 0x22E55F0 VA: 0x1822E6FF0
	public static void Initialize(EventHandler<StateChangedEventArgs> onStateChanged, EventHandler<LoadCompletedEventArgs> onCompleted, EventHandler<LoadProgressEventArgs> onProgress) { }

	// RVA: 0x22E7280 Offset: 0x22E5880 VA: 0x1822E7280
	public static bool IsActive() { }

	// RVA: 0x22E7FD0 Offset: 0x22E65D0 VA: 0x1822E7FD0
	public static void Release() { }

	// RVA: 0x22E8140 Offset: 0x22E6740 VA: 0x1822E8140
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E6F30 Offset: 0x22E5530 VA: 0x1822E6F30
	public static void ConnectionReset() { }

	// RVA: 0x22E7CF0 Offset: 0x22E62F0 VA: 0x1822E7CF0
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E7E70 Offset: 0x22E6470 VA: 0x1822E7E70
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E7B80 Offset: 0x22E6180 VA: 0x1822E7B80
	public static void PollStatus() { }

	// RVA: 0x22E83E0 Offset: 0x22E69E0 VA: 0x1822E83E0
	public static INetProtect get_NetProtect() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E7A60 Offset: 0x22E6060 VA: 0x1822E7A60
	private static uint OnInternalProgress(uint Progress, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E7840 Offset: 0x22E5E40 VA: 0x1822E7840
	private static void OnInternalEvent(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E75A0 Offset: 0x22E5BA0 VA: 0x1822E75A0
	private static uint OnIntegrityViolation(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22E7330 Offset: 0x22E5930 VA: 0x1822E7330
	private static bool OnHostValidation(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E82A0 Offset: 0x22E68A0 VA: 0x1822E82A0
	private static void .cctor() { }

}

private sealed class Runtime.<>c__DisplayClass19_0 // TypeDefIndex: 7163
{	// Fields
	public EventHandler<LoadCompletedEventArgs> onCompleted; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22E85F0 Offset: 0x22E6BF0 VA: 0x1822E85F0
	internal void <Initialize>b__0(object s, LoadCompletedEventArgs args) { }

}

