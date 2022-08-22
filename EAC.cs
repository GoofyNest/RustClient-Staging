public static class EAC // TypeDefIndex: 9186
{	// Fields
	public static bool isLoading; // 0x0
	public static string lastError; // 0x8
	private static byte[] _lastTicket; // 0x10

	// Properties
	private static bool IsEacEnabled { get; }
	public static bool IsEncryptionSupported { get; }

	// Methods

	// RVA: 0xAB7680 Offset: 0xAB5C80 VA: 0x180AB7680
	private static bool get_IsEacEnabled() { }

	// RVA: 0xAB76A0 Offset: 0xAB5CA0 VA: 0x180AB76A0
	public static bool get_IsEncryptionSupported() { }

	// RVA: 0xAB6AE0 Offset: 0xAB50E0 VA: 0x180AB6AE0
	public static void Encrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0xAB66F0 Offset: 0xAB4CF0 VA: 0x180AB66F0
	public static void Decrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0xAB6E80 Offset: 0xAB5480 VA: 0x180AB6E80
	private static void OnLaunchProgress(object sender, LoadProgressEventArgs eventArgs) { }

	// RVA: 0xAB6CE0 Offset: 0xAB52E0 VA: 0x180AB6CE0
	private static void OnLaunchCompleted(object sender, LoadCompletedEventArgs eventArgs) { }

	// RVA: 0xAB7080 Offset: 0xAB5680 VA: 0x180AB7080
	private static void OnStateChanged(object sender, StateChangedEventArgs eventArgs) { }

	// RVA: 0xAB73F0 Offset: 0xAB59F0 VA: 0x180AB73F0
	private static void SendToServer(byte[] message, int messageLength) { }

	[IteratorStateMachineAttribute] // RVA: 0xD7360 Offset: 0xD6760 VA: 0x1800D7360
	// RVA: 0xAB6900 Offset: 0xAB4F00 VA: 0x180AB6900
	public static IEnumerator DoStartup() { }

	// RVA: 0xAB6840 Offset: 0xAB4E40 VA: 0x180AB6840
	public static void DoShutdown() { }

	// RVA: 0xAB6950 Offset: 0xAB4F50 VA: 0x180AB6950
	public static void DoUpdate() { }

	[AsyncStateMachineAttribute] // RVA: 0xD7480 Offset: 0xD6880 VA: 0x1800D7480
	// RVA: 0xAB6C20 Offset: 0xAB5220 VA: 0x180AB6C20
	public static Task OnJoinServer() { }

	// RVA: 0xAB6F30 Offset: 0xAB5530 VA: 0x180AB6F30
	public static void OnLeaveServer() { }

	// RVA: 0xAB6FB0 Offset: 0xAB55B0 VA: 0x180AB6FB0
	public static void OnMessageReceived(Message message) { }

	// RVA: 0xAB7620 Offset: 0xAB5C20 VA: 0x180AB7620
	private static void .cctor() { }

}

private sealed class EAC.<DoStartup>d__12 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9187
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xAC5CA0 Offset: 0xAC42A0 VA: 0x180AC5CA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAC5FE0 Offset: 0xAC45E0 VA: 0x180AC5FE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct EAC.<OnJoinServer>d__16 : IAsyncStateMachine // TypeDefIndex: 9188
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<byte[]> <>u__1; // 0x20

	// Methods

	// RVA: 0xFC660 Offset: 0xFBA60 VA: 0x1800FC660 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

