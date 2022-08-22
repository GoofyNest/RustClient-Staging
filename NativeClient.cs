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

	// RVA: 0x22E6B80 Offset: 0x22E5180 VA: 0x1822E6B80
	private static void .cctor() { }

	// RVA: 0x22E65A0 Offset: 0x22E4BA0 VA: 0x1822E65A0
	public static bool IsStartedWithEasyAntiCheat() { }

	// RVA: 0x22E62F0 Offset: 0x22E48F0 VA: 0x1822E62F0
	public static void Dispose() { }

	// RVA: 0x22E63C0 Offset: 0x22E49C0 VA: 0x1822E63C0
	public static void Initialize(NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation) { }

	// RVA: 0x22E6270 Offset: 0x22E4870 VA: 0x1822E6270
	public static void ConnectionReset() { }

	// RVA: 0x22E6800 Offset: 0x22E4E00 VA: 0x1822E6800
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E6A60 Offset: 0x22E5060 VA: 0x1822E6A60
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E6940 Offset: 0x22E4F40 VA: 0x1822E6940
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E66E0 Offset: 0x22E4CE0 VA: 0x1822E66E0
	public static void PollStatus() { }

	// RVA: 0x22E6600 Offset: 0x22E4C00 VA: 0x1822E6600
	public static IntPtr NetProtect() { }

}

public sealed class NativeClient.CallbackProgress : MulticastDelegate // TypeDefIndex: 7156
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E5830 Offset: 0x22E3E30 VA: 0x1822E5830 Slot: 12
	public virtual uint Invoke(uint Progress, IntPtr CallbackParameter) { }

	// RVA: 0x22E57A0 Offset: 0x22E3DA0 VA: 0x1822E57A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(uint Progress, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackFinished : MulticastDelegate // TypeDefIndex: 7157
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AA6350 Offset: 0x1AA4950 VA: 0x181AA6350 Slot: 12
	public virtual void Invoke(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E4ED0 Offset: 0x22E34D0 VA: 0x1822E4ED0 Slot: 13
	public virtual IAsyncResult BeginInvoke(LoadResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackIntegrity : MulticastDelegate // TypeDefIndex: 7158
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E5410 Offset: 0x22E3A10 VA: 0x1822E5410 Slot: 12
	public virtual uint Invoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	// RVA: 0x22E5360 Offset: 0x22E3960 VA: 0x1822E5360 Slot: 13
	public virtual IAsyncResult BeginInvoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackHostValidation : MulticastDelegate // TypeDefIndex: 7159
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4FF0 Offset: 0x22E35F0 VA: 0x1822E4FF0 Slot: 12
	public virtual bool Invoke(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E4F60 Offset: 0x22E3560 VA: 0x1822E4F60 Slot: 13
	public virtual IAsyncResult BeginInvoke(HostValidationResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xFF6FB0 Offset: 0xFF55B0 VA: 0x180FF6FB0 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class NativeClient.UnityModule : NativeClient.INativeModule // TypeDefIndex: 7161
{	// Methods

	// RVA: 0x22E9270 Offset: 0x22E7870 VA: 0x1822E9270
	private static extern IntPtr CreateGameClient(string InterfaceVersion) { }

	// RVA: 0x22E9530 Offset: 0x22E7B30 VA: 0x1822E9530
	private static extern void GameClient_Destroy(IntPtr Instance) { }

	// RVA: 0x22E95B0 Offset: 0x22E7BB0 VA: 0x1822E95B0
	private static extern void GameClient_Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E94B0 Offset: 0x22E7AB0 VA: 0x1822E94B0
	private static extern void GameClient_ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E97B0 Offset: 0x22E7DB0 VA: 0x1822E97B0
	private static extern bool GameClient_PopNetworkMessage(IntPtr Instance, ref IntPtr MessageBuffer, out uint MessageLength) { }

	// RVA: 0x22E9850 Offset: 0x22E7E50 VA: 0x1822E9850
	private static extern void GameClient_PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, uint MessageLength) { }

	// RVA: 0x22E98F0 Offset: 0x22E7EF0 VA: 0x1822E98F0
	private static extern void GameClient_SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, uint AuthTicketLength) { }

	// RVA: 0x22E96F0 Offset: 0x22E7CF0 VA: 0x1822E96F0
	private static extern void GameClient_PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E9670 Offset: 0x22E7C70 VA: 0x1822E9670
	private static extern IntPtr GameClient_NetProtect(IntPtr Instance) { }

	// RVA: 0x22E9310 Offset: 0x22E7910 VA: 0x1822E9310 Slot: 4
	public IntPtr Create() { }

	// RVA: 0x22E9400 Offset: 0x22E7A00 VA: 0x1822E9400 Slot: 5
	public void Destroy(IntPtr Instance) { }

	// RVA: 0x22E99C0 Offset: 0x22E7FC0 VA: 0x1822E99C0 Slot: 6
	public void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E91C0 Offset: 0x22E77C0 VA: 0x1822E91C0 Slot: 7
	public void ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E9C50 Offset: 0x22E8250 VA: 0x1822E9C50 Slot: 8
	public bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E9E80 Offset: 0x22E8480 VA: 0x1822E9E80 Slot: 9
	public void PushNetworkMessage(IntPtr Instance, byte[] Message, int MessageLength) { }

	// RVA: 0x22E9F50 Offset: 0x22E8550 VA: 0x1822E9F50 Slot: 11
	public void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E9B60 Offset: 0x22E8160 VA: 0x1822E9B60 Slot: 10
	public void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E9AB0 Offset: 0x22E80B0 VA: 0x1822E9AB0 Slot: 12
	public IntPtr NetProtect(IntPtr Instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

