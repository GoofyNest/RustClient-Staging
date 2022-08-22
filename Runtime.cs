public static class Runtime // TypeDefIndex: 4
{	// Methods

	// RVA: 0x164A820 Offset: 0x1648E20 VA: 0x18164A820
	private static void mono_runtime_install_handlers() { }

	// RVA: 0x164A820 Offset: 0x1648E20 VA: 0x18164A820
	public static void InstallSignalHandlers() { }

	// RVA: 0x164A830 Offset: 0x1648E30 VA: 0x18164A830
	private static void mono_runtime_cleanup_handlers() { }

	// RVA: 0x164A830 Offset: 0x1648E30 VA: 0x18164A830
	public static void RemoveSignalHandlers() { }

	// RVA: 0x164A810 Offset: 0x1648E10 VA: 0x18164A810
	public static string GetDisplayName() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
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
	// RVA: 0x22E8480 Offset: 0x22E6A80 VA: 0x1822E8480
	public static bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E85A0 Offset: 0x22E6BA0 VA: 0x1822E85A0
	private static void set_Initialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8600 Offset: 0x22E6C00 VA: 0x1822E8600
	private static void set_Integrity(IntegrityDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8540 Offset: 0x22E6B40 VA: 0x1822E8540
	private static void set_HostValidation(HostValidationResult value) { }

	// RVA: 0x22E70F0 Offset: 0x22E56F0 VA: 0x1822E70F0
	public static void Initialize(EventHandler<StateChangedEventArgs> onStateChanged, EventHandler<LoadCompletedEventArgs> onCompleted, EventHandler<LoadProgressEventArgs> onProgress) { }

	// RVA: 0x22E7380 Offset: 0x22E5980 VA: 0x1822E7380
	public static bool IsActive() { }

	// RVA: 0x22E80D0 Offset: 0x22E66D0 VA: 0x1822E80D0
	public static void Release() { }

	// RVA: 0x22E8240 Offset: 0x22E6840 VA: 0x1822E8240
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E7030 Offset: 0x22E5630 VA: 0x1822E7030
	public static void ConnectionReset() { }

	// RVA: 0x22E7DF0 Offset: 0x22E63F0 VA: 0x1822E7DF0
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E7F70 Offset: 0x22E6570 VA: 0x1822E7F70
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E7C80 Offset: 0x22E6280 VA: 0x1822E7C80
	public static void PollStatus() { }

	// RVA: 0x22E84E0 Offset: 0x22E6AE0 VA: 0x1822E84E0
	public static INetProtect get_NetProtect() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7B60 Offset: 0x22E6160 VA: 0x1822E7B60
	private static uint OnInternalProgress(uint Progress, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7940 Offset: 0x22E5F40 VA: 0x1822E7940
	private static void OnInternalEvent(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E76A0 Offset: 0x22E5CA0 VA: 0x1822E76A0
	private static uint OnIntegrityViolation(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7430 Offset: 0x22E5A30 VA: 0x1822E7430
	private static bool OnHostValidation(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E83A0 Offset: 0x22E69A0 VA: 0x1822E83A0
	private static void .cctor() { }

}

private sealed class Runtime.<>c__DisplayClass19_0 // TypeDefIndex: 7163
{	// Fields
	public EventHandler<LoadCompletedEventArgs> onCompleted; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22E86F0 Offset: 0x22E6CF0 VA: 0x1822E86F0
	internal void <Initialize>b__0(object s, LoadCompletedEventArgs args) { }

}

