internal static class SourceServerQuery // TypeDefIndex: 5258
{	// Fields
	private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE; // 0x0
	private static readonly Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries; // 0x8

	// Methods

	// RVA: 0xDE4AC0 Offset: 0xDE30C0 VA: 0x180DE4AC0
	internal static Task<Dictionary<string, string>> GetRules(ServerInfo server) { }

	[AsyncStateMachineAttribute] // RVA: 0x99800 Offset: 0x98C00 VA: 0x180099800
	// RVA: 0xDE49F0 Offset: 0xDE2FF0 VA: 0x180DE49F0
	private static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint) { }

	[AsyncStateMachineAttribute] // RVA: 0x99C70 Offset: 0x99070 VA: 0x180099C70
	// RVA: 0xDE4E40 Offset: 0xDE3440 VA: 0x180DE4E40
	private static Task<Dictionary<string, string>> GetRules(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99E60 Offset: 0x99260 VA: 0x180099E60
	// RVA: 0xDE4F10 Offset: 0xDE3510 VA: 0x180DE4F10
	private static Task<byte[]> Receive(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99F80 Offset: 0x99380 VA: 0x180099F80
	// RVA: 0xDE4920 Offset: 0xDE2F20 VA: 0x180DE4920
	private static Task<byte[]> GetChallengeData(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x9A250 Offset: 0x99650 VA: 0x18009A250
	// RVA: 0xDE4FE0 Offset: 0xDE35E0 VA: 0x180DE4FE0
	private static Task Send(UdpClient client, byte[] message) { }

	// RVA: 0xDE47A0 Offset: 0xDE2DA0 VA: 0x180DE47A0
	private static byte[] Combine(byte[][] arrays) { }

	// RVA: 0xDE50D0 Offset: 0xDE36D0 VA: 0x180DE50D0
	private static void .cctor() { }

}

private sealed class SourceServerQuery.<>c__DisplayClass3_0 // TypeDefIndex: 5259
{	// Fields
	public IPEndPoint endpoint; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0E80 Offset: 0xDEF480 VA: 0x180DF0E80
	internal Task<Dictionary<string, string>> <GetRules>b__0(Task<Dictionary<string, string>> t) { }

}

private struct SourceServerQuery.<GetRulesImpl>d__4 : IAsyncStateMachine // TypeDefIndex: 5260
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public IPEndPoint endpoint; // 0x20
	private UdpClient <client>5__2; // 0x28
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x30

	// Methods

	// RVA: 0x123360 Offset: 0x122760 VA: 0x180123360 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123370 Offset: 0x122770 VA: 0x180123370 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetRules>d__5 : IAsyncStateMachine // TypeDefIndex: 5261
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private TaskAwaiter<byte[]> <>u__1; // 0x28
	private TaskAwaiter <>u__2; // 0x30

	// Methods

	// RVA: 0x1233C0 Offset: 0x1227C0 VA: 0x1801233C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1233D0 Offset: 0x1227D0 VA: 0x1801233D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SourceServerQuery.<>c // TypeDefIndex: 5262
{	// Fields
	public static readonly SourceServerQuery.<>c <>9; // 0x0
	public static Func<byte[], bool> <>9__6_0; // 0x8
	public static Func<byte[], int> <>9__9_0; // 0x10

	// Methods

	// RVA: 0xDF10B0 Offset: 0xDEF6B0 VA: 0x180DF10B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0D80 Offset: 0xDEF380 VA: 0x180DF0D80
	internal bool <Receive>b__6_0(byte[] p) { }

	// RVA: 0xDEFFC0 Offset: 0xDEE5C0 VA: 0x180DEFFC0
	internal int <Combine>b__9_0(byte[] a) { }

}

private struct SourceServerQuery.<Receive>d__6 : IAsyncStateMachine // TypeDefIndex: 5263
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private byte[][] <packets>5__2; // 0x28
	private TaskAwaiter<UdpReceiveResult> <>u__1; // 0x30

	// Methods

	// RVA: 0x123480 Offset: 0x122880 VA: 0x180123480 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123490 Offset: 0x122890 VA: 0x180123490 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetChallengeData>d__7 : IAsyncStateMachine // TypeDefIndex: 5264
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private TaskAwaiter <>u__1; // 0x28
	private TaskAwaiter<byte[]> <>u__2; // 0x30

	// Methods

	// RVA: 0x123240 Offset: 0x122640 VA: 0x180123240 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123250 Offset: 0x122650 VA: 0x180123250 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<Send>d__8 : IAsyncStateMachine // TypeDefIndex: 5265
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public byte[] message; // 0x20
	public UdpClient client; // 0x28
	private TaskAwaiter<int> <>u__1; // 0x30

	// Methods

	// RVA: 0x1235A0 Offset: 0x1229A0 VA: 0x1801235A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

