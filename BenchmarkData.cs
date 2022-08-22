public class BenchmarkData // TypeDefIndex: 6178
{	// Fields
	public static BenchmarkData Current; // 0x0
	public Dictionary<string, float> Results; // 0x10
	public string ComputerName; // 0x18
	public string BuildDate; // 0x20
	public string BranchName; // 0x28
	public string Changeset; // 0x30
	public string BuildId; // 0x38
	public bool Auto; // 0x40
	public int Version; // 0x44
	public AppInfo AppInfo; // 0x48
	public SystemInformation SystemInfo; // 0x50
	private int frames; // 0x54
	private int hitches; // 0x58
	private int freezes; // 0x5C
	private float lastTime; // 0x60
	private double frameTimes; // 0x68

	// Properties
	private float AvgMilliseconds { get; }
	private float avgFrameRate { get; }

	// Methods

	// RVA: 0x14A9230 Offset: 0x14A7830 VA: 0x1814A9230
	public static BenchmarkData New() { }

	// RVA: 0x14A9710 Offset: 0x14A7D10 VA: 0x1814A9710
	public void WriteTimersToResults() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F940 Offset: 0x9ED40 VA: 0x18009F940
	// RVA: 0x14A93E0 Offset: 0x14A79E0 VA: 0x1814A93E0
	public Task<string> Upload() { }

	// RVA: 0x14A94E0 Offset: 0x14A7AE0 VA: 0x1814A94E0
	public string WriteJSON() { }

	// RVA: 0x14A9940 Offset: 0x14A7F40 VA: 0x1814A9940
	private float get_AvgMilliseconds() { }

	// RVA: 0x14A9960 Offset: 0x14A7F60 VA: 0x1814A9960
	private float get_avgFrameRate() { }

	// RVA: 0x14A93D0 Offset: 0x14A79D0 VA: 0x1814A93D0
	public void ResetCounters() { }

	// RVA: 0x14A91D0 Offset: 0x14A77D0 VA: 0x1814A91D0
	public void Frame() { }

	// RVA: 0x14A8F40 Offset: 0x14A7540 VA: 0x1814A8F40
	public void CompleteDemoBenchmark(string benchmarkLabel = "") { }

	// RVA: 0x14A98D0 Offset: 0x14A7ED0 VA: 0x1814A98D0
	public void .ctor() { }

}

private struct BenchmarkData.<Upload>d__13 : IAsyncStateMachine // TypeDefIndex: 6179
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public BenchmarkData <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28

	// Methods

	// RVA: 0x1F1E00 Offset: 0x1F1200 VA: 0x1801F1E00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1E10 Offset: 0x1F1210 VA: 0x1801F1E10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

