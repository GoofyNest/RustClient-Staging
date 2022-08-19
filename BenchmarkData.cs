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

	// RVA: 0x14A9EA0 Offset: 0x14A84A0 VA: 0x1814A9EA0
	public static BenchmarkData New() { }

	// RVA: 0x14AA380 Offset: 0x14A8980 VA: 0x1814AA380
	public void WriteTimersToResults() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F8B0 Offset: 0x9ECB0 VA: 0x18009F8B0
	// RVA: 0x14AA050 Offset: 0x14A8650 VA: 0x1814AA050
	public Task<string> Upload() { }

	// RVA: 0x14AA150 Offset: 0x14A8750 VA: 0x1814AA150
	public string WriteJSON() { }

	// RVA: 0x14AA5B0 Offset: 0x14A8BB0 VA: 0x1814AA5B0
	private float get_AvgMilliseconds() { }

	// RVA: 0x14AA5D0 Offset: 0x14A8BD0 VA: 0x1814AA5D0
	private float get_avgFrameRate() { }

	// RVA: 0x14AA040 Offset: 0x14A8640 VA: 0x1814AA040
	public void ResetCounters() { }

	// RVA: 0x14A9E40 Offset: 0x14A8440 VA: 0x1814A9E40
	public void Frame() { }

	// RVA: 0x14A9BB0 Offset: 0x14A81B0 VA: 0x1814A9BB0
	public void CompleteDemoBenchmark(string benchmarkLabel = "") { }

	// RVA: 0x14AA540 Offset: 0x14A8B40 VA: 0x1814AA540
	public void .ctor() { }

}

private struct BenchmarkData.<Upload>d__13 : IAsyncStateMachine // TypeDefIndex: 6179
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public BenchmarkData <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28

	// Methods

	// RVA: 0x1F1A60 Offset: 0x1F0E60 VA: 0x1801F1A60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1F1A70 Offset: 0x1F0E70 VA: 0x1801F1A70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

