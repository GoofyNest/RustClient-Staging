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

	[AsyncStateMachineAttribute] // RVA: 0xBA070 Offset: 0xB9470 VA: 0x1800BA070
	// RVA: 0x21C22E0 Offset: 0x21C08E0 VA: 0x1821C22E0 Slot: 13
	protected override ValueTask<bool> Initialize() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB4B0 Offset: 0xBA8B0 VA: 0x1800BB4B0
	// RVA: 0x21C2820 Offset: 0x21C0E20 VA: 0x1821C2820 Slot: 14
	protected override ValueTask Shutdown() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB710 Offset: 0xBAB10 VA: 0x1800BB710
	// RVA: 0x21C24F0 Offset: 0x21C0AF0 VA: 0x1821C24F0 Slot: 15
	protected override Task SendHeartbeat() { }

	[AsyncStateMachineAttribute] // RVA: 0xBB8B0 Offset: 0xBACB0 VA: 0x1800BB8B0
	// RVA: 0x21C2710 Offset: 0x21C0D10 VA: 0x1821C2710 Slot: 16
	protected override Task SendStaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xBB9D0 Offset: 0xBADD0 VA: 0x1800BB9D0
	// RVA: 0x21C25E0 Offset: 0x21C0BE0 VA: 0x1821C25E0 Slot: 17
	protected override Task SendPulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xBBAB0 Offset: 0xBAEB0 VA: 0x1800BBAB0
	// RVA: 0x21C23F0 Offset: 0x21C09F0 VA: 0x1821C23F0 Slot: 18
	protected override Task SendEvent(RgbEventType type) { }

	// RVA: 0x21C2920 Offset: 0x21C0F20 VA: 0x1821C2920
	private static string TryGetMomentsEvent(RgbEventType type) { }

	// RVA: 0x21C1E30 Offset: 0x21C0430 VA: 0x1821C1E30
	private ColorData GetColorData(Color color) { }

	// RVA: 0x21C2080 Offset: 0x21C0680 VA: 0x1821C2080
	private string GetEndpoint(string path) { }

	// RVA: 0x21C20E0 Offset: 0x21C06E0 VA: 0x1821C20E0
	private static string GetGameSenseAddress() { }

	// RVA: 0x21C1F40 Offset: 0x21C0540 VA: 0x1821C1F40
	private static string GetCorePropsPath() { }

	// RVA: 0x21C0D90 Offset: 0x21BF390 VA: 0x1821C0D90
	public void .ctor() { }

	// RVA: 0x21C2970 Offset: 0x21C0F70 VA: 0x1821C2970
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

	// RVA: 0x236EA0 Offset: 0x2362A0 VA: 0x180236EA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236EB0 Offset: 0x2362B0 VA: 0x180236EB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<Shutdown>d__11 : IAsyncStateMachine // TypeDefIndex: 7695
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30

	// Methods

	// RVA: 0x236F60 Offset: 0x236360 VA: 0x180236F60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendHeartbeat>d__12 : IAsyncStateMachine // TypeDefIndex: 7696
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteelSeriesGameSenseService <>4__this; // 0x20
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x28

	// Methods

	// RVA: 0x236F30 Offset: 0x236330 VA: 0x180236F30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
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

	// RVA: 0x236F50 Offset: 0x236350 VA: 0x180236F50 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
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

	// RVA: 0x236F40 Offset: 0x236340 VA: 0x180236F40 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
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

	// RVA: 0x236F10 Offset: 0x236310 VA: 0x180236F10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

