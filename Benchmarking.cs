public static class Benchmarking // TypeDefIndex: 8261
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <IsBenchmarking>k__BackingField; // 0x0
	public static string[] BenchmarkScenes; // 0x8

	// Properties
	public static bool IsBenchmarking { get; set; }
	public static bool IsAutoBenchmark { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x50FD90 Offset: 0x50E390 VA: 0x18050FD90
	public static bool get_IsBenchmarking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x50FDF0 Offset: 0x50E3F0 VA: 0x18050FDF0
	public static void set_IsBenchmarking(bool value) { }

	// RVA: 0x50FCC0 Offset: 0x50E2C0 VA: 0x18050FCC0
	public static bool get_IsAutoBenchmark() { }

	[AsyncStateMachineAttribute] // RVA: 0xA2F90 Offset: 0xA2390 VA: 0x1800A2F90
	// RVA: 0x50F630 Offset: 0x50DC30 VA: 0x18050F630
	public static Task RunAsync(string demoName, bool runBenchmarkScenes = True) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3050 Offset: 0xA2450 VA: 0x1800A3050
	// RVA: 0x50FA20 Offset: 0x50E020 VA: 0x18050FA20
	public static Task RunSingleSceneAsync(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3180 Offset: 0xA2580 VA: 0x1800A3180
	// RVA: 0x50F740 Offset: 0x50DD40 VA: 0x18050F740
	private static Task RunBenchmarkScene(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3320 Offset: 0xA2720 VA: 0x1800A3320
	// RVA: 0x50F830 Offset: 0x50DE30 VA: 0x18050F830
	public static Task RunBenchmarksInScene() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3430 Offset: 0xA2830 VA: 0x1800A3430
	// RVA: 0x50F570 Offset: 0x50DB70 VA: 0x18050F570
	private static Task Report() { }

	[AsyncStateMachineAttribute] // RVA: 0xA34B0 Offset: 0xA28B0 VA: 0x1800A34B0
	// RVA: 0x50F910 Offset: 0x50DF10 VA: 0x18050F910
	private static Task RunDemoBasedBenchmark(string demoName, string benchmarkLabel = "") { }

	// RVA: 0x50F3B0 Offset: 0x50D9B0 VA: 0x18050F3B0
	private static void RecordBundleSizes() { }

	// RVA: 0x50FB20 Offset: 0x50E120 VA: 0x18050FB20
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

	// RVA: 0xF2840 Offset: 0xF1C40 VA: 0x1800F2840 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
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

	// RVA: 0xF2880 Offset: 0xF1C80 VA: 0x1800F2880 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarkScene>d__9 : IAsyncStateMachine // TypeDefIndex: 8264
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0xF2850 Offset: 0xF1C50 VA: 0x1800F2850 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
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

	// RVA: 0xF2860 Offset: 0xF1C60 VA: 0x1800F2860 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<Report>d__11 : IAsyncStateMachine // TypeDefIndex: 8266
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<string> <>u__1; // 0x20

	// Methods

	// RVA: 0xF2830 Offset: 0xF1C30 VA: 0x1800F2830 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
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

	// RVA: 0xF2870 Offset: 0xF1C70 VA: 0x1800F2870 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

