internal static class SourceServerQuery // TypeDefIndex: 5258
{	private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE; // 0x0
	private static readonly Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries; // 0x8


	internal static Task<Dictionary<string, string>> GetRules(ServerInfo server) { }

	[AsyncStateMachineAttribute] // RVA: 0x99800 Offset: 0x98C00 VA: 0x180099800
	private static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint) { }

	[AsyncStateMachineAttribute] // RVA: 0x99C70 Offset: 0x99070 VA: 0x180099C70
	private static Task<Dictionary<string, string>> GetRules(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99E60 Offset: 0x99260 VA: 0x180099E60
	private static Task<byte[]> Receive(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99F80 Offset: 0x99380 VA: 0x180099F80
	private static Task<byte[]> GetChallengeData(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x9A250 Offset: 0x99650 VA: 0x18009A250
	private static Task Send(UdpClient client, byte[] message) { }

	private static byte[] Combine(byte[][] arrays) { }

	private static void .cctor() { }

}

private sealed class SourceServerQuery.<>c__DisplayClass3_0 // TypeDefIndex: 5259
{	public IPEndPoint endpoint; // 0x10


	public void .ctor() { }

	internal Task<Dictionary<string, string>> <GetRules>b__0(Task<Dictionary<string, string>> t) { }

}

private struct SourceServerQuery.<GetRulesImpl>d__4 : IAsyncStateMachine // TypeDefIndex: 5260
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public IPEndPoint endpoint; // 0x20
	private UdpClient <client>5__2; // 0x28
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetRules>d__5 : IAsyncStateMachine // TypeDefIndex: 5261
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private TaskAwaiter<byte[]> <>u__1; // 0x28
	private TaskAwaiter <>u__2; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SourceServerQuery.<>c // TypeDefIndex: 5262
{	public static readonly SourceServerQuery.<>c <>9; // 0x0
	public static Func<byte[], bool> <>9__6_0; // 0x8
	public static Func<byte[], int> <>9__9_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Receive>b__6_0(byte[] p) { }

	internal int <Combine>b__9_0(byte[] a) { }

}

private struct SourceServerQuery.<Receive>d__6 : IAsyncStateMachine // TypeDefIndex: 5263
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private byte[][] <packets>5__2; // 0x28
	private TaskAwaiter<UdpReceiveResult> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<GetChallengeData>d__7 : IAsyncStateMachine // TypeDefIndex: 5264
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public UdpClient client; // 0x20
	private TaskAwaiter <>u__1; // 0x28
	private TaskAwaiter<byte[]> <>u__2; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SourceServerQuery.<Send>d__8 : IAsyncStateMachine // TypeDefIndex: 5265
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public byte[] message; // 0x20
	public UdpClient client; // 0x28
	private TaskAwaiter<int> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

