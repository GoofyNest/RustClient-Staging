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

	// RVA: 0x22E6360 Offset: 0x22E4960 VA: 0x1822E6360
	private static void .cctor() { }

	// RVA: 0x22E5D80 Offset: 0x22E4380 VA: 0x1822E5D80
	public static bool IsStartedWithEasyAntiCheat() { }

	// RVA: 0x22E5AD0 Offset: 0x22E40D0 VA: 0x1822E5AD0
	public static void Dispose() { }

	// RVA: 0x22E5BA0 Offset: 0x22E41A0 VA: 0x1822E5BA0
	public static void Initialize(NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation) { }

	// RVA: 0x22E5A50 Offset: 0x22E4050 VA: 0x1822E5A50
	public static void ConnectionReset() { }

	// RVA: 0x22E5FE0 Offset: 0x22E45E0 VA: 0x1822E5FE0
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E6240 Offset: 0x22E4840 VA: 0x1822E6240
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E6120 Offset: 0x22E4720 VA: 0x1822E6120
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E5EC0 Offset: 0x22E44C0 VA: 0x1822E5EC0
	public static void PollStatus() { }

	// RVA: 0x22E5DE0 Offset: 0x22E43E0 VA: 0x1822E5DE0
	public static IntPtr NetProtect() { }

}

public sealed class NativeClient.CallbackProgress : MulticastDelegate // TypeDefIndex: 7156
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E5010 Offset: 0x22E3610 VA: 0x1822E5010 Slot: 12
	public virtual uint Invoke(uint Progress, IntPtr CallbackParameter) { }

	// RVA: 0x22E4F80 Offset: 0x22E3580 VA: 0x1822E4F80 Slot: 13
	public virtual IAsyncResult BeginInvoke(uint Progress, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackFinished : MulticastDelegate // TypeDefIndex: 7157
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1310410 Offset: 0x130EA10 VA: 0x181310410 Slot: 12
	public virtual void Invoke(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E46B0 Offset: 0x22E2CB0 VA: 0x1822E46B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(LoadResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackIntegrity : MulticastDelegate // TypeDefIndex: 7158
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E4BF0 Offset: 0x22E31F0 VA: 0x1822E4BF0 Slot: 12
	public virtual uint Invoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	// RVA: 0x22E4B40 Offset: 0x22E3140 VA: 0x1822E4B40 Slot: 13
	public virtual IAsyncResult BeginInvoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackHostValidation : MulticastDelegate // TypeDefIndex: 7159
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E47D0 Offset: 0x22E2DD0 VA: 0x1822E47D0 Slot: 12
	public virtual bool Invoke(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22E4740 Offset: 0x22E2D40 VA: 0x1822E4740 Slot: 13
	public virtual IAsyncResult BeginInvoke(HostValidationResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xFF6510 Offset: 0xFF4B10 VA: 0x180FF6510 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class NativeClient.UnityModule : NativeClient.INativeModule // TypeDefIndex: 7161
{	// Methods

	// RVA: 0x22E8A50 Offset: 0x22E7050 VA: 0x1822E8A50
	private static extern IntPtr CreateGameClient(string InterfaceVersion) { }

	// RVA: 0x22E8D10 Offset: 0x22E7310 VA: 0x1822E8D10
	private static extern void GameClient_Destroy(IntPtr Instance) { }

	// RVA: 0x22E8D90 Offset: 0x22E7390 VA: 0x1822E8D90
	private static extern void GameClient_Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E8C90 Offset: 0x22E7290 VA: 0x1822E8C90
	private static extern void GameClient_ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E8F90 Offset: 0x22E7590 VA: 0x1822E8F90
	private static extern bool GameClient_PopNetworkMessage(IntPtr Instance, ref IntPtr MessageBuffer, out uint MessageLength) { }

	// RVA: 0x22E9030 Offset: 0x22E7630 VA: 0x1822E9030
	private static extern void GameClient_PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, uint MessageLength) { }

	// RVA: 0x22E90D0 Offset: 0x22E76D0 VA: 0x1822E90D0
	private static extern void GameClient_SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, uint AuthTicketLength) { }

	// RVA: 0x22E8ED0 Offset: 0x22E74D0 VA: 0x1822E8ED0
	private static extern void GameClient_PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E8E50 Offset: 0x22E7450 VA: 0x1822E8E50
	private static extern IntPtr GameClient_NetProtect(IntPtr Instance) { }

	// RVA: 0x22E8AF0 Offset: 0x22E70F0 VA: 0x1822E8AF0 Slot: 4
	public IntPtr Create() { }

	// RVA: 0x22E8BE0 Offset: 0x22E71E0 VA: 0x1822E8BE0 Slot: 5
	public void Destroy(IntPtr Instance) { }

	// RVA: 0x22E91A0 Offset: 0x22E77A0 VA: 0x1822E91A0 Slot: 6
	public void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E89A0 Offset: 0x22E6FA0 VA: 0x1822E89A0 Slot: 7
	public void ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E9430 Offset: 0x22E7A30 VA: 0x1822E9430 Slot: 8
	public bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E9660 Offset: 0x22E7C60 VA: 0x1822E9660 Slot: 9
	public void PushNetworkMessage(IntPtr Instance, byte[] Message, int MessageLength) { }

	// RVA: 0x22E9730 Offset: 0x22E7D30 VA: 0x1822E9730 Slot: 11
	public void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E9340 Offset: 0x22E7940 VA: 0x1822E9340 Slot: 10
	public void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E9290 Offset: 0x22E7890 VA: 0x1822E9290 Slot: 12
	public IntPtr NetProtect(IntPtr Instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

