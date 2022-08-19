public class IpList : Internet // TypeDefIndex: 5289
{	// Fields
	public List<string> Ips; // 0x58
	private bool wantsCancel; // 0x60

	// Methods

	// RVA: 0xDE2570 Offset: 0xDE0B70 VA: 0x180DE2570
	public void .ctor(IEnumerable<string> list) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2740 Offset: 0xA1B40 VA: 0x1800A2740
	// RVA: 0xDE2460 Offset: 0xDE0A60 VA: 0x180DE2460 Slot: 5
	public override Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	// RVA: 0xDE2450 Offset: 0xDE0A50 VA: 0x180DE2450 Slot: 6
	public override void Cancel() { }

}

private struct IpList.<RunQueryAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 5290
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public IpList <>4__this; // 0x20
	public float timeoutSeconds; // 0x28
	private int <blockSize>5__2; // 0x2C
	private int <pointer>5__3; // 0x30
	private string[] <ips>5__4; // 0x38
	private IEnumerable<string> <sublist>5__5; // 0x40
	private Internet <list>5__6; // 0x48
	private TaskAwaiter<bool> <>u__1; // 0x50

	// Methods

	// RVA: 0x1237A0 Offset: 0x122BA0 VA: 0x1801237A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1237B0 Offset: 0x122BB0 VA: 0x1801237B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

