internal static class SourceServerQuery // TypeDefIndex: 5258
{	// Fields
	private static readonly byte[] A2S_SERVERQUERY_GETCHALLENGE; // 0x0
	private static readonly Dictionary<IPEndPoint, Task<Dictionary<string, string>>> PendingQueries; // 0x8

	// Methods

	// RVA: 0xDE3D50 Offset: 0xDE2350 VA: 0x180DE3D50
	internal static Task<Dictionary<string, string>> GetRules(ServerInfo server) { }

	[AsyncStateMachineAttribute] // RVA: 0x997B0 Offset: 0x98BB0 VA: 0x1800997B0
	// RVA: 0xDE3C80 Offset: 0xDE2280 VA: 0x180DE3C80
	private static Task<Dictionary<string, string>> GetRulesImpl(IPEndPoint endpoint) { }

	[AsyncStateMachineAttribute] // RVA: 0x99BA0 Offset: 0x98FA0 VA: 0x180099BA0
	// RVA: 0xDE40D0 Offset: 0xDE26D0 VA: 0x180DE40D0
	private static Task<Dictionary<string, string>> GetRules(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99DD0 Offset: 0x991D0 VA: 0x180099DD0
	// RVA: 0xDE41A0 Offset: 0xDE27A0 VA: 0x180DE41A0
	private static Task<byte[]> Receive(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x99EF0 Offset: 0x992F0 VA: 0x180099EF0
	// RVA: 0xDE3BB0 Offset: 0xDE21B0 VA: 0x180DE3BB0
	private static Task<byte[]> GetChallengeData(UdpClient client) { }

	[AsyncStateMachineAttribute] // RVA: 0x9A1C0 Offset: 0x995C0 VA: 0x18009A1C0
	// RVA: 0xDE4270 Offset: 0xDE2870 VA: 0x180DE4270
	private static Task Send(UdpClient client, byte[] message) { }

	// RVA: 0xDE3A30 Offset: 0xDE2030 VA: 0x180DE3A30
	private static byte[] Combine(byte[][] arrays) { }

	// RVA: 0xDE4360 Offset: 0xDE2960 VA: 0x180DE4360
	private static void .cctor() { }

}

private sealed class SourceServerQuery.<>c__DisplayClass3_0 // TypeDefIndex: 5259
{	// Fields
	public IPEndPoint endpoint; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0110 Offset: 0xDEE710 VA: 0x180DF0110
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

	// RVA: 0x1235C0 Offset: 0x1229C0 VA: 0x1801235C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1235D0 Offset: 0x1229D0 VA: 0x1801235D0 Slot: 5
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

	// RVA: 0x123620 Offset: 0x122A20 VA: 0x180123620 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x123630 Offset: 0x122A30 VA: 0x180123630 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SourceServerQuery.<>c // TypeDefIndex: 5262
{	// Fields
	public static readonly SourceServerQuery.<>c <>9; // 0x0
	public static Func<byte[], bool> <>9__6_0; // 0x8
	public static Func<byte[], int> <>9__9_0; // 0x10

	// Methods

	// RVA: 0xDF0340 Offset: 0xDEE940 VA: 0x180DF0340
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0010 Offset: 0xDEE610 VA: 0x180DF0010
	internal bool <Receive>b__6_0(byte[] p) { }

	// RVA: 0xDEF250 Offset: 0xDED850 VA: 0x180DEF250
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

	// RVA: 0x1236E0 Offset: 0x122AE0 VA: 0x1801236E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1236F0 Offset: 0x122AF0 VA: 0x1801236F0 Slot: 5
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

	// RVA: 0x1234A0 Offset: 0x1228A0 VA: 0x1801234A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1234B0 Offset: 0x1228B0 VA: 0x1801234B0 Slot: 5
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

	// RVA: 0x123800 Offset: 0x122C00 VA: 0x180123800 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

