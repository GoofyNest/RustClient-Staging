public class SteelSeriesGameSenseService : RestRgbService // TypeDefIndex: 7693
{	// Fields
	private const string GameId = "RUST";
	private const string StaticColorEvent = "STATIC_COLOR";
	private const string PulseColorEvent = "PULSE_COLOR";
	private const string AllyDeathEvent = "ALLY_DIED";
	private const string EnemyDeathEvent = "ENEMY_DIED";
	private static readonly string PulseHandlerCode; // 0x0
	private string _address; // 0x50
	private string _heartbeatEndpoint; // 0x58
	private HttpContent _heartbeatContent; // 0x60
	private string _gameEventEndpoint; // 0x68

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xB9FD0 Offset: 0xB93D0 VA: 0x1800B9FD0
	// RVA: 0x21C21E0 Offset: 0x21C07E0 VA: 0x1821C21E0 Slot: 13
	protected override ValueTask<bool> Initialize() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB450 Offset: 0xBA850 VA: 0x1800BB450
	// RVA: 0x21C2720 Offset: 0x21C0D20 VA: 0x1821C2720 Slot: 14
	protected override ValueTask Shutdown() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB670 Offset: 0xBAA70 VA: 0x1800BB670
	// RVA: 0x21C23F0 Offset: 0x21C09F0 VA: 0x1821C23F0 Slot: 15
	protected override Task SendHeartbeat() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB810 Offset: 0xBAC10 VA: 0x1800BB810
	// RVA: 0x21C2610 Offset: 0x21C0C10 VA: 0x1821C2610 Slot: 16
	protected override Task SendStaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xBB930 Offset: 0xBAD30 VA: 0x1800BB930
	// RVA: 0x21C24E0 Offset: 0x21C0AE0 VA: 0x1821C24E0 Slot: 17
	protected override Task SendPulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xBBA20 Offset: 0xBAE20 VA: 0x1800BBA20
	// RVA: 0x21C22F0 Offset: 0x21C08F0 VA: 0x1821C22F0 Slot: 18
	protected override Task SendEvent(RgbEventType type) { }

	// RVA: 0x21C2820 Offset: 0x21C0E20 VA: 0x1821C2820
	private static string TryGetMomentsEvent(RgbEventType type) { }

	// RVA: 0x21C1D30 Offset: 0x21C0330 VA: 0x1821C1D30
	private ColorData GetColorData(Color color) { }

	// RVA: 0x21C1F80 Offset: 0x21C0580 VA: 0x1821C1F80
	private string GetEndpoint(string path) { }

	// RVA: 0x21C1FE0 Offset: 0x21C05E0 VA: 0x1821C1FE0
	private static string GetGameSenseAddress() { }

	// RVA: 0x21C1E40 Offset: 0x21C0440 VA: 0x1821C1E40
	private static string GetCorePropsPath() { }

	// RVA: 0x21C0C90 Offset: 0x21BF290 VA: 0x1821C0C90
	public void .ctor() { }

	// RVA: 0x21C2870 Offset: 0x21C0E70 VA: 0x1821C2870
	private static void .cctor() { }

}

private struct SteelSeriesGameSenseService.<Initialize>d__10 : IAsyncStateMachine // TypeDefIndex: 7694
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder<bool> <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private string <registerGameEventEndpoint>5__2; // 0x30
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x38

	// Methods

	// RVA: 0x236F20 Offset: 0x236320 VA: 0x180236F20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236F30 Offset: 0x236330 VA: 0x180236F30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<Shutdown>d__11 : IAsyncStateMachine // TypeDefIndex: 7695
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30

	// Methods

	// RVA: 0x236FE0 Offset: 0x2363E0 VA: 0x180236FE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendHeartbeat>d__12 : IAsyncStateMachine // TypeDefIndex: 7696
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x28

	// Methods

	// RVA: 0x236FB0 Offset: 0x2363B0 VA: 0x180236FB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendStaticColor>d__13 : IAsyncStateMachine // TypeDefIndex: 7697
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	public Color color; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x38

	// Methods

	// RVA: 0x236FD0 Offset: 0x2363D0 VA: 0x180236FD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendPulseColor>d__14 : IAsyncStateMachine // TypeDefIndex: 7698
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	public float duration; // 0x28
	public Color color; // 0x2C
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x40

	// Methods

	// RVA: 0x236FC0 Offset: 0x2363C0 VA: 0x180236FC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendEvent>d__15 : IAsyncStateMachine // TypeDefIndex: 7699
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public RgbEventType type; // 0x20
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30

	// Methods

	// RVA: 0x236F90 Offset: 0x236390 VA: 0x180236F90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

