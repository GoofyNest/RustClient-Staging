public static class EAC // TypeDefIndex: 9186
{	// Fields
	public static bool isLoading; // 0x0
	public static string lastError; // 0x8
	private static byte[] _lastTicket; // 0x10

	// Properties
	private static bool IsEacEnabled { get; }
	public static bool IsEncryptionSupported { get; }

	// Methods

	// RVA: 0xAB73C0 Offset: 0xAB59C0 VA: 0x180AB73C0
	private static bool get_IsEacEnabled() { }

	// RVA: 0xAB73E0 Offset: 0xAB59E0 VA: 0x180AB73E0
	public static bool get_IsEncryptionSupported() { }

	// RVA: 0xAB6820 Offset: 0xAB4E20 VA: 0x180AB6820
	public static void Encrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0xAB6430 Offset: 0xAB4A30 VA: 0x180AB6430
	public static void Decrypt(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0xAB6BC0 Offset: 0xAB51C0 VA: 0x180AB6BC0
	private static void OnLaunchProgress(object sender, LoadProgressEventArgs eventArgs) { }

	// RVA: 0xAB6A20 Offset: 0xAB5020 VA: 0x180AB6A20
	private static void OnLaunchCompleted(object sender, LoadCompletedEventArgs eventArgs) { }

	// RVA: 0xAB6DC0 Offset: 0xAB53C0 VA: 0x180AB6DC0
	private static void OnStateChanged(object sender, StateChangedEventArgs eventArgs) { }

	// RVA: 0xAB7130 Offset: 0xAB5730 VA: 0x180AB7130
	private static void SendToServer(byte[] message, int messageLength) { }

	[IteratorStateMachineAttribute] // RVA: 0xD72F0 Offset: 0xD66F0 VA: 0x1800D72F0
	// RVA: 0xAB6640 Offset: 0xAB4C40 VA: 0x180AB6640
	public static IEnumerator DoStartup() { }

	// RVA: 0xAB6580 Offset: 0xAB4B80 VA: 0x180AB6580
	public static void DoShutdown() { }

	// RVA: 0xAB6690 Offset: 0xAB4C90 VA: 0x180AB6690
	public static void DoUpdate() { }

	[AsyncStateMachineAttribute] // RVA: 0xD7410 Offset: 0xD6810 VA: 0x1800D7410
	// RVA: 0xAB6960 Offset: 0xAB4F60 VA: 0x180AB6960
	public static Task OnJoinServer() { }

	// RVA: 0xAB6C70 Offset: 0xAB5270 VA: 0x180AB6C70
	public static void OnLeaveServer() { }

	// RVA: 0xAB6CF0 Offset: 0xAB52F0 VA: 0x180AB6CF0
	public static void OnMessageReceived(Message message) { }

	// RVA: 0xAB7360 Offset: 0xAB5960 VA: 0x180AB7360
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xAC59E0 Offset: 0xAC3FE0 VA: 0x180AC59E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAC5D20 Offset: 0xAC4320 VA: 0x180AC5D20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct EAC.<OnJoinServer>d__16 : IAsyncStateMachine // TypeDefIndex: 9188
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<byte[]> <>u__1; // 0x20

	// Methods

	// RVA: 0xFC6E0 Offset: 0xFBAE0 VA: 0x1800FC6E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

