public static class Feedback // TypeDefIndex: 6194
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xA49D0 Offset: 0xA3DD0 VA: 0x1800A49D0
	// RVA: 0x14B35A0 Offset: 0x14B1BA0 VA: 0x1814B35A0
	public static Task<string> Report(Feedback feedback) { }

}

private struct Feedback.<Report>d__0 : IAsyncStateMachine // TypeDefIndex: 6195
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public Feedback feedback; // 0x20
	private IAuthTicket <ticket>5__2; // 0x60
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x68
	private TaskAwaiter<string> <>u__2; // 0x70

	// Methods

	// RVA: 0x1F1DA0 Offset: 0x1F11A0 VA: 0x1801F1DA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1F1DB0 Offset: 0x1F11B0 VA: 0x1801F1DB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public struct Feedback // TypeDefIndex: 6242
{	// Fields
	public string Subject; // 0x0
	public string Message; // 0x8
	public ReportType Type; // 0x10
	public string TargetReportType; // 0x18
	public string TargetId; // 0x20
	public string TargetName; // 0x28
	public string TargetEntity; // 0x30
	public AppInfo AppInfo; // 0x38

}

