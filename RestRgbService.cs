public abstract class RestRgbService : IRgbService // TypeDefIndex: 7678
{	// Fields
	private readonly SemaphoreSlim _sema; // 0x10
	private readonly Stopwatch _heartbeatTimer; // 0x18
	private readonly Stopwatch _timeSinceFailure; // 0x20
	private bool _failed; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsConnected>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <ColorCorrection>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private HttpClient <Client>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TimeSpan <HeartbeatInterval>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TimeSpan <ReinitializeDelay>k__BackingField; // 0x48

	// Properties
	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }
	protected HttpClient Client { get; set; }
	protected TimeSpan HeartbeatInterval { get; set; }
	protected TimeSpan ReinitializeDelay { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x73ABF0 Offset: 0x7391F0 VA: 0x18073ABF0 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x11244C0 Offset: 0x1122AC0 VA: 0x1811244C0
	protected void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x12CCDB0 Offset: 0x12CB3B0 VA: 0x1812CCDB0 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21C0E30 Offset: 0x21BF430 VA: 0x1821C0E30 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	protected HttpClient get_Client() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	protected void set_Client(HttpClient value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	protected TimeSpan get_HeartbeatInterval() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21C0E40 Offset: 0x21BF440 VA: 0x1821C0E40
	protected void set_HeartbeatInterval(TimeSpan value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	protected TimeSpan get_ReinitializeDelay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEE6420 Offset: 0xEE4A20 VA: 0x180EE6420
	protected void set_ReinitializeDelay(TimeSpan value) { }

	// RVA: 0x21C0C90 Offset: 0x21BF290 VA: 0x1821C0C90
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

	[AsyncStateMachineAttribute] // RVA: 0xB6B70 Offset: 0xB5F70 VA: 0x1800B6B70
	// RVA: 0x21C07B0 Offset: 0x21BEDB0 VA: 0x1821C07B0 Slot: 7
	public ValueTask Start() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6D10 Offset: 0xB6110 VA: 0x1800B6D10
	// RVA: 0x21C0A90 Offset: 0x21BF090 VA: 0x1821C0A90 Slot: 8
	public ValueTask Stop() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6F10 Offset: 0xB6310 VA: 0x1800B6F10
	// RVA: 0x21C0B90 Offset: 0x21BF190 VA: 0x1821C0B90 Slot: 9
	public ValueTask Update() { }

	[AsyncStateMachineAttribute] // RVA: 0xB7000 Offset: 0xB6400 VA: 0x1800B7000
	// RVA: 0x21C06B0 Offset: 0x21BECB0 VA: 0x1821C06B0
	private void SendHeartbeatAndWait() { }

	// RVA: 0x21C09A0 Offset: 0x21BEFA0 VA: 0x1821C09A0 Slot: 10
	public void StaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xB70F0 Offset: 0xB64F0 VA: 0x1800B70F0
	// RVA: 0x21C08B0 Offset: 0x21BEEB0 VA: 0x1821C08B0
	private void StaticColorImpl(Color color) { }

	// RVA: 0x21C05A0 Offset: 0x21BEBA0 VA: 0x1821C05A0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7250 Offset: 0xB6650 VA: 0x1800B7250
	// RVA: 0x21C04A0 Offset: 0x21BEAA0 VA: 0x1821C04A0
	private void PulseColorImpl(Color color, float duration) { }

	// RVA: 0x21C03B0 Offset: 0x21BE9B0 VA: 0x1821C03B0 Slot: 12
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB73A0 Offset: 0xB67A0 VA: 0x1800B73A0
	// RVA: 0x21C02C0 Offset: 0x21BE8C0 VA: 0x1821C02C0
	private void EventImpl(RgbEventType type) { }

	// RVA: 0x21C0780 Offset: 0x21BED80 VA: 0x1821C0780
	private void ShutdownFromFailure() { }

	[AsyncStateMachineAttribute] // RVA: 0xB8790 Offset: 0xB7B90 VA: 0x1800B8790
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

	// RVA: 0x237010 Offset: 0x236410 VA: 0x180237010 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
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

	// RVA: 0x237040 Offset: 0x236440 VA: 0x180237040 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Update>d__33 : IAsyncStateMachine // TypeDefIndex: 7681
{	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private ValueTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x237060 Offset: 0x236460 VA: 0x180237060 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x236FF0 Offset: 0x2363F0 VA: 0x180236FF0 Slot: 5
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

	// RVA: 0x236FA0 Offset: 0x2363A0 VA: 0x180236FA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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

	// RVA: 0x237020 Offset: 0x236420 VA: 0x180237020 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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

	// RVA: 0x236F80 Offset: 0x236380 VA: 0x180236F80 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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

	// RVA: 0x236F10 Offset: 0x236310 VA: 0x180236F10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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
	|-RVA: 0x120720 Offset: 0x11FB20 VA: 0x180120720
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.MoveNext
	|
	|-RVA: 0x120730 Offset: 0x11FB30 VA: 0x180120730
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.MoveNext
	|
	|-RVA: 0x120710 Offset: 0x11FB10 VA: 0x180120710
	|-RestRgbService.<SendPost>d__42<GameMetadata>.MoveNext
	|
	|-RVA: 0x1206F0 Offset: 0x11FAF0 VA: 0x1801206F0
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.MoveNext
	|
	|-RVA: 0x120700 Offset: 0x11FB00 VA: 0x180120700
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.MoveNext
	|
	|-RVA: 0x1206E0 Offset: 0x11FAE0 VA: 0x1801206E0
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.MoveNext
	|
	|-RVA: 0x120740 Offset: 0x11FB40 VA: 0x180120740
	|-RestRgbService.<SendPost>d__42<RemoveGame>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x120930 Offset: 0x11FD30 VA: 0x180120930
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.SetStateMachine
	|
	|-RVA: 0x120840 Offset: 0x11FC40 VA: 0x180120840
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.SetStateMachine
	|
	|-RVA: 0x1207A0 Offset: 0x11FBA0 VA: 0x1801207A0
	|-RestRgbService.<SendPost>d__42<GameMetadata>.SetStateMachine
	|
	|-RVA: 0x1207F0 Offset: 0x11FBF0 VA: 0x1801207F0
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.SetStateMachine
	|
	|-RVA: 0x120750 Offset: 0x11FB50 VA: 0x180120750
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.SetStateMachine
	|
	|-RVA: 0x120890 Offset: 0x11FC90 VA: 0x180120890
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.SetStateMachine
	|
	|-RVA: 0x1208E0 Offset: 0x11FCE0 VA: 0x1801208E0
	|-RestRgbService.<SendPost>d__42<RemoveGame>.SetStateMachine
	*/

}

