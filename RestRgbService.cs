public abstract class RestRgbService : IRgbService // TypeDefIndex: 7678
{	// Fields
	private readonly SemaphoreSlim _sema; // 0x10
	private readonly Stopwatch _heartbeatTimer; // 0x18
	private readonly Stopwatch _timeSinceFailure; // 0x20
	private bool _failed; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsConnected>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <ColorCorrection>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private HttpClient <Client>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeSpan <HeartbeatInterval>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TimeSpan <ReinitializeDelay>k__BackingField; // 0x48

	// Properties
	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }
	protected HttpClient Client { get; set; }
	protected TimeSpan HeartbeatInterval { get; set; }
	protected TimeSpan ReinitializeDelay { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x73ABF0 Offset: 0x7391F0 VA: 0x18073ABF0 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11244C0 Offset: 0x1122AC0 VA: 0x1811244C0
	protected void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12CCDB0 Offset: 0x12CB3B0 VA: 0x1812CCDB0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C0C70 Offset: 0x21BF270 VA: 0x1821C0C70 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	protected HttpClient get_Client() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	protected void set_Client(HttpClient value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	protected TimeSpan get_HeartbeatInterval() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C0C80 Offset: 0x21BF280 VA: 0x1821C0C80
	protected void set_HeartbeatInterval(TimeSpan value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	protected TimeSpan get_ReinitializeDelay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE6420 Offset: 0xEE4A20 VA: 0x180EE6420
	protected void set_ReinitializeDelay(TimeSpan value) { }

	// RVA: 0x21C0AD0 Offset: 0x21BF0D0 VA: 0x1821C0AD0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract ValueTask<bool> Initialize();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract ValueTask Shutdown();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract Task SendHeartbeat();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract Task SendStaticColor(Color color);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract Task SendPulseColor(Color color, float duration);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract Task SendEvent(RgbEventType type);

	[AsyncStateMachineAttribute] // RVA: 0xB6BE0 Offset: 0xB5FE0 VA: 0x1800B6BE0
	// RVA: 0x21C05F0 Offset: 0x21BEBF0 VA: 0x1821C05F0 Slot: 7
	public ValueTask Start() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6E30 Offset: 0xB6230 VA: 0x1800B6E30
	// RVA: 0x21C08D0 Offset: 0x21BEED0 VA: 0x1821C08D0 Slot: 8
	public ValueTask Stop() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6FE0 Offset: 0xB63E0 VA: 0x1800B6FE0
	// RVA: 0x21C09D0 Offset: 0x21BEFD0 VA: 0x1821C09D0 Slot: 9
	public ValueTask Update() { }

	[AsyncStateMachineAttribute] // RVA: 0xB7060 Offset: 0xB6460 VA: 0x1800B7060
	// RVA: 0x21C04F0 Offset: 0x21BEAF0 VA: 0x1821C04F0
	private void SendHeartbeatAndWait() { }

	// RVA: 0x21C07E0 Offset: 0x21BEDE0 VA: 0x1821C07E0 Slot: 10
	public void StaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7150 Offset: 0xB6550 VA: 0x1800B7150
	// RVA: 0x21C06F0 Offset: 0x21BECF0 VA: 0x1821C06F0
	private void StaticColorImpl(Color color) { }

	// RVA: 0x21C03E0 Offset: 0x21BE9E0 VA: 0x1821C03E0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xB72B0 Offset: 0xB66B0 VA: 0x1800B72B0
	// RVA: 0x21C02E0 Offset: 0x21BE8E0 VA: 0x1821C02E0
	private void PulseColorImpl(Color color, float duration) { }

	// RVA: 0x21C01F0 Offset: 0x21BE7F0 VA: 0x1821C01F0 Slot: 12
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7440 Offset: 0xB6840 VA: 0x1800B7440
	// RVA: 0x21C0100 Offset: 0x21BE700 VA: 0x1821C0100
	private void EventImpl(RgbEventType type) { }

	// RVA: 0x21C05C0 Offset: 0x21BEBC0 VA: 0x1821C05C0
	private void ShutdownFromFailure() { }

	[AsyncStateMachineAttribute] // RVA: 0xB8880 Offset: 0xB7C80 VA: 0x1800B8880
	// RVA: -1 Offset: -1
	protected Task<HttpResponseMessage> SendPost<T>(string endpoint, T payload) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED7A10 Offset: 0xED6010 VA: 0x180ED7A10
	|-RestRgbService.SendPost<GameEvent<ColorEventData>>
	|
	|-RVA: 0xED78C0 Offset: 0xED5EC0 VA: 0x180ED78C0
	|-RestRgbService.SendPost<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xED7B60 Offset: 0xED6160 VA: 0x180ED7B60
	|-RestRgbService.SendPost<GameMetadata>
	|
	|-RVA: 0xED7CB0 Offset: 0xED62B0 VA: 0x180ED7CB0
	|-RestRgbService.SendPost<LoadGoLispHandlers>
	|
	|-RVA: 0xED7E00 Offset: 0xED6400 VA: 0x180ED7E00
	|-RestRgbService.SendPost<RegisterGameEvent>
	|
	|-RVA: 0xED7F50 Offset: 0xED6550 VA: 0x180ED7F50
	|-RestRgbService.SendPost<RegisterTimelineEvents>
	|
	|-RVA: 0xED80A0 Offset: 0xED66A0 VA: 0x180ED80A0
	|-RestRgbService.SendPost<RemoveGame>
	*/

	// RVA: -1 Offset: -1
	protected static HttpContent BuildContent<T>(T parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED72A0 Offset: 0xED58A0 VA: 0x180ED72A0
	|-RestRgbService.BuildContent<GameEvent<ColorEventData>>
	|
	|-RVA: 0xED71C0 Offset: 0xED57C0 VA: 0x180ED71C0
	|-RestRgbService.BuildContent<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xED7380 Offset: 0xED5980 VA: 0x180ED7380
	|-RestRgbService.BuildContent<GameMetadata>
	|
	|-RVA: 0xED7460 Offset: 0xED5A60 VA: 0x180ED7460
	|-RestRgbService.BuildContent<Heartbeat>
	|
	|-RVA: 0xED7540 Offset: 0xED5B40 VA: 0x180ED7540
	|-RestRgbService.BuildContent<LoadGoLispHandlers>
	|
	|-RVA: 0xED7620 Offset: 0xED5C20 VA: 0x180ED7620
	|-RestRgbService.BuildContent<RegisterGameEvent>
	|
	|-RVA: 0xED7700 Offset: 0xED5D00 VA: 0x180ED7700
	|-RestRgbService.BuildContent<RegisterTimelineEvents>
	|
	|-RVA: 0xED77E0 Offset: 0xED5DE0 VA: 0x180ED77E0
	|-RestRgbService.BuildContent<RemoveGame>
	*/

}

private struct RestRgbService.<Start>d__31 : IAsyncStateMachine // TypeDefIndex: 7679
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30
	private ValueTaskAwaiter<bool> <>u__2; // 0x38

	// Methods

	// RVA: 0x236F90 Offset: 0x236390 VA: 0x180236F90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Stop>d__32 : IAsyncStateMachine // TypeDefIndex: 7680
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30
	private ValueTaskAwaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x236FC0 Offset: 0x2363C0 VA: 0x180236FC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Update>d__33 : IAsyncStateMachine // TypeDefIndex: 7681
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private ValueTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x236FE0 Offset: 0x2363E0 VA: 0x180236FE0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendHeartbeatAndWait>d__34 : IAsyncStateMachine // TypeDefIndex: 7682
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x38

	// Methods

	// RVA: 0x236F20 Offset: 0x236320 VA: 0x180236F20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<StaticColorImpl>d__36 : IAsyncStateMachine // TypeDefIndex: 7683
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public Color color; // 0x30
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x236FA0 Offset: 0x2363A0 VA: 0x180236FA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<PulseColorImpl>d__38 : IAsyncStateMachine // TypeDefIndex: 7684
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public Color color; // 0x30
	public float duration; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x236F00 Offset: 0x236300 VA: 0x180236F00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<EventImpl>d__40 : IAsyncStateMachine // TypeDefIndex: 7685
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public RgbEventType type; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x236E90 Offset: 0x236290 VA: 0x180236E90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendPost>d__42<T> : IAsyncStateMachine // TypeDefIndex: 7686
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x0
	public T payload; // 0x0
	public RestRgbService <>4__this; // 0x0
	public string endpoint; // 0x0
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1206A0 Offset: 0x11FAA0 VA: 0x1801206A0
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.MoveNext
	|
	|-RVA: 0x1206B0 Offset: 0x11FAB0 VA: 0x1801206B0
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.MoveNext
	|
	|-RVA: 0x120690 Offset: 0x11FA90 VA: 0x180120690
	|-RestRgbService.<SendPost>d__42<GameMetadata>.MoveNext
	|
	|-RVA: 0x120670 Offset: 0x11FA70 VA: 0x180120670
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.MoveNext
	|
	|-RVA: 0x120680 Offset: 0x11FA80 VA: 0x180120680
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.MoveNext
	|
	|-RVA: 0x120660 Offset: 0x11FA60 VA: 0x180120660
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.MoveNext
	|
	|-RVA: 0x1206C0 Offset: 0x11FAC0 VA: 0x1801206C0
	|-RestRgbService.<SendPost>d__42<RemoveGame>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1208B0 Offset: 0x11FCB0 VA: 0x1801208B0
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.SetStateMachine
	|
	|-RVA: 0x1207C0 Offset: 0x11FBC0 VA: 0x1801207C0
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.SetStateMachine
	|
	|-RVA: 0x120720 Offset: 0x11FB20 VA: 0x180120720
	|-RestRgbService.<SendPost>d__42<GameMetadata>.SetStateMachine
	|
	|-RVA: 0x120770 Offset: 0x11FB70 VA: 0x180120770
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.SetStateMachine
	|
	|-RVA: 0x1206D0 Offset: 0x11FAD0 VA: 0x1801206D0
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.SetStateMachine
	|
	|-RVA: 0x120810 Offset: 0x11FC10 VA: 0x180120810
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.SetStateMachine
	|
	|-RVA: 0x120860 Offset: 0x11FC60 VA: 0x180120860
	|-RestRgbService.<SendPost>d__42<RemoveGame>.SetStateMachine
	*/

}

