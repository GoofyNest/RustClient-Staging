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

	// RVA: 0x22E6260 Offset: 0x22E4860 VA: 0x1822E6260
	private static void .cctor() { }

	// RVA: 0x22E5C80 Offset: 0x22E4280 VA: 0x1822E5C80
	public static bool IsStartedWithEasyAntiCheat() { }

	// RVA: 0x22E59D0 Offset: 0x22E3FD0 VA: 0x1822E59D0
	public static void Dispose() { }

	// RVA: 0x22E5AA0 Offset: 0x22E40A0 VA: 0x1822E5AA0
	public static void Initialize(NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation) { }

	// RVA: 0x22E5950 Offset: 0x22E3F50 VA: 0x1822E5950
	public static void ConnectionReset() { }

	// RVA: 0x22E5EE0 Offset: 0x22E44E0 VA: 0x1822E5EE0
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E6140 Offset: 0x22E4740 VA: 0x1822E6140
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E6020 Offset: 0x22E4620 VA: 0x1822E6020
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E5DC0 Offset: 0x22E43C0 VA: 0x1822E5DC0
	public static void PollStatus() { }

	// RVA: 0x22E5CE0 Offset: 0x22E42E0 VA: 0x1822E5CE0
	public static IntPtr NetProtect() { }

}

public sealed class NativeClient.CallbackProgress : MulticastDelegate // TypeDefIndex: 7156
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4F10 Offset: 0x22E3510 VA: 0x1822E4F10 Slot: 12
	public virtual uint Invoke(uint Progress, IntPtr CallbackParameter) { }

	// RVA: 0x22E4E80 Offset: 0x22E3480 VA: 0x1822E4E80 Slot: 13
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

	// RVA: 0x22E45B0 Offset: 0x22E2BB0 VA: 0x1822E45B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(LoadResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackIntegrity : MulticastDelegate // TypeDefIndex: 7158
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4AF0 Offset: 0x22E30F0 VA: 0x1822E4AF0 Slot: 12
	public virtual uint Invoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	// RVA: 0x22E4A40 Offset: 0x22E3040 VA: 0x1822E4A40 Slot: 13
	public virtual IAsyncResult BeginInvoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackHostValidation : MulticastDelegate // TypeDefIndex: 7159
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E46D0 Offset: 0x22E2CD0 VA: 0x1822E46D0 Slot: 12
	public virtual bool Invoke(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E4640 Offset: 0x22E2C40 VA: 0x1822E4640 Slot: 13
	public virtual IAsyncResult BeginInvoke(HostValidationResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xFF6250 Offset: 0xFF4850 VA: 0x180FF6250 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class NativeClient.UnityModule : NativeClient.INativeModule // TypeDefIndex: 7161
{	// Methods

	// RVA: 0x22E8950 Offset: 0x22E6F50 VA: 0x1822E8950
	private static extern IntPtr CreateGameClient(string InterfaceVersion) { }

	// RVA: 0x22E8C10 Offset: 0x22E7210 VA: 0x1822E8C10
	private static extern void GameClient_Destroy(IntPtr Instance) { }

	// RVA: 0x22E8C90 Offset: 0x22E7290 VA: 0x1822E8C90
	private static extern void GameClient_Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E8B90 Offset: 0x22E7190 VA: 0x1822E8B90
	private static extern void GameClient_ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E8E90 Offset: 0x22E7490 VA: 0x1822E8E90
	private static extern bool GameClient_PopNetworkMessage(IntPtr Instance, ref IntPtr MessageBuffer, out uint MessageLength) { }

	// RVA: 0x22E8F30 Offset: 0x22E7530 VA: 0x1822E8F30
	private static extern void GameClient_PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, uint MessageLength) { }

	// RVA: 0x22E8FD0 Offset: 0x22E75D0 VA: 0x1822E8FD0
	private static extern void GameClient_SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, uint AuthTicketLength) { }

	// RVA: 0x22E8DD0 Offset: 0x22E73D0 VA: 0x1822E8DD0
	private static extern void GameClient_PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E8D50 Offset: 0x22E7350 VA: 0x1822E8D50
	private static extern IntPtr GameClient_NetProtect(IntPtr Instance) { }

	// RVA: 0x22E89F0 Offset: 0x22E6FF0 VA: 0x1822E89F0 Slot: 4
	public IntPtr Create() { }

	// RVA: 0x22E8AE0 Offset: 0x22E70E0 VA: 0x1822E8AE0 Slot: 5
	public void Destroy(IntPtr Instance) { }

	// RVA: 0x22E90A0 Offset: 0x22E76A0 VA: 0x1822E90A0 Slot: 6
	public void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E88A0 Offset: 0x22E6EA0 VA: 0x1822E88A0 Slot: 7
	public void ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E9330 Offset: 0x22E7930 VA: 0x1822E9330 Slot: 8
	public bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E9560 Offset: 0x22E7B60 VA: 0x1822E9560 Slot: 9
	public void PushNetworkMessage(IntPtr Instance, byte[] Message, int MessageLength) { }

	// RVA: 0x22E9630 Offset: 0x22E7C30 VA: 0x1822E9630 Slot: 11
	public void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E9240 Offset: 0x22E7840 VA: 0x1822E9240 Slot: 10
	public void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E9190 Offset: 0x22E7790 VA: 0x1822E9190 Slot: 12
	public IntPtr NetProtect(IntPtr Instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

