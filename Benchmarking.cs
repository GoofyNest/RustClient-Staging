public static class Benchmarking // TypeDefIndex: 8261
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static bool <IsBenchmarking>k__BackingField; // 0x0
	public static string[] BenchmarkScenes; // 0x8

	// Properties
	public static bool IsBenchmarking { get; set; }
	public static bool IsAutoBenchmark { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x50FE00 Offset: 0x50E400 VA: 0x18050FE00
	public static bool get_IsBenchmarking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x50FE60 Offset: 0x50E460 VA: 0x18050FE60
	public static void set_IsBenchmarking(bool value) { }

	// RVA: 0x50FD30 Offset: 0x50E330 VA: 0x18050FD30
	public static bool get_IsAutoBenchmark() { }

	[AsyncStateMachineAttribute] // RVA: 0xA2F00 Offset: 0xA2300 VA: 0x1800A2F00
	// RVA: 0x50F6A0 Offset: 0x50DCA0 VA: 0x18050F6A0
	public static Task RunAsync(string demoName, bool runBenchmarkScenes = True) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2FC0 Offset: 0xA23C0 VA: 0x1800A2FC0
	// RVA: 0x50FA90 Offset: 0x50E090 VA: 0x18050FA90
	public static Task RunSingleSceneAsync(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3140 Offset: 0xA2540 VA: 0x1800A3140
	// RVA: 0x50F7B0 Offset: 0x50DDB0 VA: 0x18050F7B0
	private static Task RunBenchmarkScene(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3320 Offset: 0xA2720 VA: 0x1800A3320
	// RVA: 0x50F8A0 Offset: 0x50DEA0 VA: 0x18050F8A0
	public static Task RunBenchmarksInScene() { }

	[AsyncStateMachineAttribute] // RVA: 0xA33A0 Offset: 0xA27A0 VA: 0x1800A33A0
	// RVA: 0x50F5E0 Offset: 0x50DBE0 VA: 0x18050F5E0
	private static Task Report() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3420 Offset: 0xA2820 VA: 0x1800A3420
	// RVA: 0x50F980 Offset: 0x50DF80 VA: 0x18050F980
	private static Task RunDemoBasedBenchmark(string demoName, string benchmarkLabel = "") { }

	// RVA: 0x50F420 Offset: 0x50DA20 VA: 0x18050F420
	private static void RecordBundleSizes() { }

	// RVA: 0x50FB90 Offset: 0x50E190 VA: 0x18050FB90
	private static void .cctor() { }

}

private struct Benchmarking.<RunAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 8262
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string demoName; // 0x20
	public bool runBenchmarkScenes; // 0x28
	private object <>7__wrap1; // 0x30
	private int <>7__wrap2; // 0x38
	private TaskAwaiter <>u__1; // 0x40
	private string[] <>7__wrap3; // 0x48
	private int <>7__wrap4; // 0x50

	// Methods

	// RVA: 0xF28C0 Offset: 0xF1CC0 VA: 0x1800F28C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunSingleSceneAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 8263
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private object <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0xF2900 Offset: 0xF1D00 VA: 0x1800F2900 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarkScene>d__9 : IAsyncStateMachine // TypeDefIndex: 8264
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0xF28D0 Offset: 0xF1CD0 VA: 0x1800F28D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarksInScene>d__10 : IAsyncStateMachine // TypeDefIndex: 8265
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x20
	private BenchmarkScene[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private IEnumerator <coroutine>5__4; // 0x38

	// Methods

	// RVA: 0xF28E0 Offset: 0xF1CE0 VA: 0x1800F28E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<Report>d__11 : IAsyncStateMachine // TypeDefIndex: 8266
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<string> <>u__1; // 0x20

	// Methods

	// RVA: 0xF28B0 Offset: 0xF1CB0 VA: 0x1800F28B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunDemoBasedBenchmark>d__12 : IAsyncStateMachine // TypeDefIndex: 8267
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string demoName; // 0x20
	public string benchmarkLabel; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF28F0 Offset: 0xF1CF0 VA: 0x1800F28F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

