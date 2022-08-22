public static class Benchmarking // TypeDefIndex: 8261
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <IsBenchmarking>k__BackingField; // 0x0
	public static string[] BenchmarkScenes; // 0x8

	public static bool IsBenchmarking { get; set; }
	public static bool IsAutoBenchmark { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static bool get_IsBenchmarking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void set_IsBenchmarking(bool value) { }

	public static bool get_IsAutoBenchmark() { }

	[AsyncStateMachineAttribute] // RVA: 0xA2F90 Offset: 0xA2390 VA: 0x1800A2F90
	public static Task RunAsync(string demoName, bool runBenchmarkScenes = True) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3050 Offset: 0xA2450 VA: 0x1800A3050
	public static Task RunSingleSceneAsync(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3180 Offset: 0xA2580 VA: 0x1800A3180
	private static Task RunBenchmarkScene(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3320 Offset: 0xA2720 VA: 0x1800A3320
	public static Task RunBenchmarksInScene() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3430 Offset: 0xA2830 VA: 0x1800A3430
	private static Task Report() { }

	[AsyncStateMachineAttribute] // RVA: 0xA34B0 Offset: 0xA28B0 VA: 0x1800A34B0
	private static Task RunDemoBasedBenchmark(string demoName, string benchmarkLabel = "") { }

	private static void RecordBundleSizes() { }

	private static void .cctor() { }

}

private struct Benchmarking.<RunAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 8262
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string demoName; // 0x20
	public bool runBenchmarkScenes; // 0x28
	private object <>7__wrap1; // 0x30
	private int <>7__wrap2; // 0x38
	private TaskAwaiter <>u__1; // 0x40
	private string[] <>7__wrap3; // 0x48
	private int <>7__wrap4; // 0x50


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunSingleSceneAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 8263
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private object <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private TaskAwaiter <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarkScene>d__9 : IAsyncStateMachine // TypeDefIndex: 8264
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarksInScene>d__10 : IAsyncStateMachine // TypeDefIndex: 8265
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x20
	private BenchmarkScene[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private IEnumerator <coroutine>5__4; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<Report>d__11 : IAsyncStateMachine // TypeDefIndex: 8266
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<string> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunDemoBasedBenchmark>d__12 : IAsyncStateMachine // TypeDefIndex: 8267
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string demoName; // 0x20
	public string benchmarkLabel; // 0x28
	private TaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

