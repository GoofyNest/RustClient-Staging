internal static class NativeClient // TypeDefIndex: 7155
{	// Fields
	private static readonly string InterfaceVersion; // 0x0
	private static readonly NativeClient.INativeModule Module; // 0x8
	private static IntPtr Instance; // 0x10
	private static byte[] StaticMsgBuf; // 0x18
	private static NativeClient.CallbackProgress nogcOnProgress; // 0x20
	private static NativeClient.CallbackFinished nogcOnFinished; // 0x28
	private static NativeClient.CallbackIntegrity nogcOnIntegrityViolation; // 0x30
	private static NativeClient.CallbackHostValidation nogcOnHostValidation; // 0x38

	// Methods

	// RVA: 0x22E60A0 Offset: 0x22E46A0 VA: 0x1822E60A0
	private static void .cctor() { }

	// RVA: 0x22E5AC0 Offset: 0x22E40C0 VA: 0x1822E5AC0
	public static bool IsStartedWithEasyAntiCheat() { }

	// RVA: 0x22E5810 Offset: 0x22E3E10 VA: 0x1822E5810
	public static void Dispose() { }

	// RVA: 0x22E58E0 Offset: 0x22E3EE0 VA: 0x1822E58E0
	public static void Initialize(NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation) { }

	// RVA: 0x22E5790 Offset: 0x22E3D90 VA: 0x1822E5790
	public static void ConnectionReset() { }

	// RVA: 0x22E5D20 Offset: 0x22E4320 VA: 0x1822E5D20
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E5F80 Offset: 0x22E4580 VA: 0x1822E5F80
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E5E60 Offset: 0x22E4460 VA: 0x1822E5E60
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E5C00 Offset: 0x22E4200 VA: 0x1822E5C00
	public static void PollStatus() { }

	// RVA: 0x22E5B20 Offset: 0x22E4120 VA: 0x1822E5B20
	public static IntPtr NetProtect() { }

}

public sealed class NativeClient.CallbackProgress : MulticastDelegate // TypeDefIndex: 7156
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4D50 Offset: 0x22E3350 VA: 0x1822E4D50 Slot: 12
	public virtual uint Invoke(uint Progress, IntPtr CallbackParameter) { }

	// RVA: 0x22E4CC0 Offset: 0x22E32C0 VA: 0x1822E4CC0 Slot: 13
	public virtual IAsyncResult BeginInvoke(uint Progress, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackFinished : MulticastDelegate // TypeDefIndex: 7157
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1310150 Offset: 0x130E750 VA: 0x181310150 Slot: 12
	public virtual void Invoke(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E43F0 Offset: 0x22E29F0 VA: 0x1822E43F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(LoadResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackIntegrity : MulticastDelegate // TypeDefIndex: 7158
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4930 Offset: 0x22E2F30 VA: 0x1822E4930 Slot: 12
	public virtual uint Invoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	// RVA: 0x22E4880 Offset: 0x22E2E80 VA: 0x1822E4880 Slot: 13
	public virtual IAsyncResult BeginInvoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackHostValidation : MulticastDelegate // TypeDefIndex: 7159
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4510 Offset: 0x22E2B10 VA: 0x1822E4510 Slot: 12
	public virtual bool Invoke(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E4480 Offset: 0x22E2A80 VA: 0x1822E4480 Slot: 13
	public virtual IAsyncResult BeginInvoke(HostValidationResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class NativeClient.UnityModule : NativeClient.INativeModule // TypeDefIndex: 7161
{	// Methods

	// RVA: 0x22E8790 Offset: 0x22E6D90 VA: 0x1822E8790
	private static extern IntPtr CreateGameClient(string InterfaceVersion) { }

	// RVA: 0x22E8A50 Offset: 0x22E7050 VA: 0x1822E8A50
	private static extern void GameClient_Destroy(IntPtr Instance) { }

	// RVA: 0x22E8AD0 Offset: 0x22E70D0 VA: 0x1822E8AD0
	private static extern void GameClient_Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E89D0 Offset: 0x22E6FD0 VA: 0x1822E89D0
	private static extern void GameClient_ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E8CD0 Offset: 0x22E72D0 VA: 0x1822E8CD0
	private static extern bool GameClient_PopNetworkMessage(IntPtr Instance, ref IntPtr MessageBuffer, out uint MessageLength) { }

	// RVA: 0x22E8D70 Offset: 0x22E7370 VA: 0x1822E8D70
	private static extern void GameClient_PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, uint MessageLength) { }

	// RVA: 0x22E8E10 Offset: 0x22E7410 VA: 0x1822E8E10
	private static extern void GameClient_SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, uint AuthTicketLength) { }

	// RVA: 0x22E8C10 Offset: 0x22E7210 VA: 0x1822E8C10
	private static extern void GameClient_PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E8B90 Offset: 0x22E7190 VA: 0x1822E8B90
	private static extern IntPtr GameClient_NetProtect(IntPtr Instance) { }

	// RVA: 0x22E8830 Offset: 0x22E6E30 VA: 0x1822E8830 Slot: 4
	public IntPtr Create() { }

	// RVA: 0x22E8920 Offset: 0x22E6F20 VA: 0x1822E8920 Slot: 5
	public void Destroy(IntPtr Instance) { }

	// RVA: 0x22E8EE0 Offset: 0x22E74E0 VA: 0x1822E8EE0 Slot: 6
	public void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E86E0 Offset: 0x22E6CE0 VA: 0x1822E86E0 Slot: 7
	public void ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E9170 Offset: 0x22E7770 VA: 0x1822E9170 Slot: 8
	public bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E93A0 Offset: 0x22E79A0 VA: 0x1822E93A0 Slot: 9
	public void PushNetworkMessage(IntPtr Instance, byte[] Message, int MessageLength) { }

	// RVA: 0x22E9470 Offset: 0x22E7A70 VA: 0x1822E9470 Slot: 11
	public void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E9080 Offset: 0x22E7680 VA: 0x1822E9080 Slot: 10
	public void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E8FD0 Offset: 0x22E75D0 VA: 0x1822E8FD0 Slot: 12
	public IntPtr NetProtect(IntPtr Instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

