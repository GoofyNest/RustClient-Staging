public static class Runtime // TypeDefIndex: 4
{	// Methods

	// RVA: 0x1637B40 Offset: 0x1636140 VA: 0x181637B40
	private static void mono_runtime_install_handlers() { }

	// RVA: 0x1637B40 Offset: 0x1636140 VA: 0x181637B40
	public static void InstallSignalHandlers() { }

	// RVA: 0x1637B50 Offset: 0x1636150 VA: 0x181637B50
	private static void mono_runtime_cleanup_handlers() { }

	// RVA: 0x1637B50 Offset: 0x1636150 VA: 0x181637B50
	public static void RemoveSignalHandlers() { }

	// RVA: 0x1637B30 Offset: 0x1636130 VA: 0x181637B30
	public static string GetDisplayName() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private static string GetNativeStackTrace(Exception exception) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
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
	// RVA: 0x22E8CA0 Offset: 0x22E72A0 VA: 0x1822E8CA0
	public static bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8DC0 Offset: 0x22E73C0 VA: 0x1822E8DC0
	private static void set_Initialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8E20 Offset: 0x22E7420 VA: 0x1822E8E20
	private static void set_Integrity(IntegrityDescriptor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8D60 Offset: 0x22E7360 VA: 0x1822E8D60
	private static void set_HostValidation(HostValidationResult value) { }

	// RVA: 0x22E7910 Offset: 0x22E5F10 VA: 0x1822E7910
	public static void Initialize(EventHandler<StateChangedEventArgs> onStateChanged, EventHandler<LoadCompletedEventArgs> onCompleted, EventHandler<LoadProgressEventArgs> onProgress) { }

	// RVA: 0x22E7BA0 Offset: 0x22E61A0 VA: 0x1822E7BA0
	public static bool IsActive() { }

	// RVA: 0x22E88F0 Offset: 0x22E6EF0 VA: 0x1822E88F0
	public static void Release() { }

	// RVA: 0x22E8A60 Offset: 0x22E7060 VA: 0x1822E8A60
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E7850 Offset: 0x22E5E50 VA: 0x1822E7850
	public static void ConnectionReset() { }

	// RVA: 0x22E8610 Offset: 0x22E6C10 VA: 0x1822E8610
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E8790 Offset: 0x22E6D90 VA: 0x1822E8790
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E84A0 Offset: 0x22E6AA0 VA: 0x1822E84A0
	public static void PollStatus() { }

	// RVA: 0x22E8D00 Offset: 0x22E7300 VA: 0x1822E8D00
	public static INetProtect get_NetProtect() { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8380 Offset: 0x22E6980 VA: 0x1822E8380
	private static uint OnInternalProgress(uint Progress, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E8160 Offset: 0x22E6760 VA: 0x1822E8160
	private static void OnInternalEvent(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7EC0 Offset: 0x22E64C0 VA: 0x1822E7EC0
	private static uint OnIntegrityViolation(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22E7C50 Offset: 0x22E6250 VA: 0x1822E7C50
	private static bool OnHostValidation(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E8BC0 Offset: 0x22E71C0 VA: 0x1822E8BC0
	private static void .cctor() { }

}

private sealed class Runtime.<>c__DisplayClass19_0 // TypeDefIndex: 7163
{	// Fields
	public EventHandler<LoadCompletedEventArgs> onCompleted; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22E8F10 Offset: 0x22E7510 VA: 0x1822E8F10
	internal void <Initialize>b__0(object s, LoadCompletedEventArgs args) { }

}

