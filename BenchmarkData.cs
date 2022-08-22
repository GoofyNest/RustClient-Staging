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

	// RVA: 0x14AA160 Offset: 0x14A8760 VA: 0x1814AA160
	public static BenchmarkData New() { }

	// RVA: 0x14AA640 Offset: 0x14A8C40 VA: 0x1814AA640
	public void WriteTimersToResults() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F940 Offset: 0x9ED40 VA: 0x18009F940
	// RVA: 0x14AA310 Offset: 0x14A8910 VA: 0x1814AA310
	public Task<string> Upload() { }

	// RVA: 0x14AA410 Offset: 0x14A8A10 VA: 0x1814AA410
	public string WriteJSON() { }

	// RVA: 0x14AA870 Offset: 0x14A8E70 VA: 0x1814AA870
	private float get_AvgMilliseconds() { }

	// RVA: 0x14AA890 Offset: 0x14A8E90 VA: 0x1814AA890
	private float get_avgFrameRate() { }

	// RVA: 0x14AA300 Offset: 0x14A8900 VA: 0x1814AA300
	public void ResetCounters() { }

	// RVA: 0x14AA100 Offset: 0x14A8700 VA: 0x1814AA100
	public void Frame() { }

	// RVA: 0x14A9E70 Offset: 0x14A8470 VA: 0x1814A9E70
	public void CompleteDemoBenchmark(string benchmarkLabel = "") { }

	// RVA: 0x14AA800 Offset: 0x14A8E00 VA: 0x1814AA800
	public void .ctor() { }

}

private struct BenchmarkData.<Upload>d__13 : IAsyncStateMachine // TypeDefIndex: 6179
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public BenchmarkData <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28

	// Methods

	// RVA: 0x1F19E0 Offset: 0x1F0DE0 VA: 0x1801F19E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F19F0 Offset: 0x1F0DF0 VA: 0x1801F19F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

