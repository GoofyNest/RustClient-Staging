public class IpList : Internet // TypeDefIndex: 5289
{	// Fields
	public List<string> Ips; // 0x58
	private bool wantsCancel; // 0x60

	// Methods

	// RVA: 0xDE32E0 Offset: 0xDE18E0 VA: 0x180DE32E0
	public void .ctor(IEnumerable<string> list) { }

	[AsyncStateMachineAttribute] // RVA: 0xA27D0 Offset: 0xA1BD0 VA: 0x1800A27D0
	// RVA: 0xDE31D0 Offset: 0xDE17D0 VA: 0x180DE31D0 Slot: 5
	public override Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	// RVA: 0xDE31C0 Offset: 0xDE17C0 VA: 0x180DE31C0 Slot: 6
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

	// RVA: 0x123540 Offset: 0x122940 VA: 0x180123540 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123550 Offset: 0x122950 VA: 0x180123550 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

