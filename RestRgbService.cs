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
	// RVA: 0x73AC50 Offset: 0x739250 VA: 0x18073AC50 Slot: 4
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11251F0 Offset: 0x11237F0 VA: 0x1811251F0
	protected void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x12D3520 Offset: 0x12D1B20 VA: 0x1812D3520 Slot: 5
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C1750 Offset: 0x21BFD50 VA: 0x1821C1750 Slot: 6
	public void set_ColorCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	protected HttpClient get_Client() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	protected void set_Client(HttpClient value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	protected TimeSpan get_HeartbeatInterval() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21C1760 Offset: 0x21BFD60 VA: 0x1821C1760
	protected void set_HeartbeatInterval(TimeSpan value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	protected TimeSpan get_ReinitializeDelay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE7190 Offset: 0xEE5790 VA: 0x180EE7190
	protected void set_ReinitializeDelay(TimeSpan value) { }

	// RVA: 0x21C15B0 Offset: 0x21BFBB0 VA: 0x1821C15B0
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
	// RVA: 0x21C10D0 Offset: 0x21BF6D0 VA: 0x1821C10D0 Slot: 7
	public ValueTask Start() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6E30 Offset: 0xB6230 VA: 0x1800B6E30
	// RVA: 0x21C13B0 Offset: 0x21BF9B0 VA: 0x1821C13B0 Slot: 8
	public ValueTask Stop() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6FE0 Offset: 0xB63E0 VA: 0x1800B6FE0
	// RVA: 0x21C14B0 Offset: 0x21BFAB0 VA: 0x1821C14B0 Slot: 9
	public ValueTask Update() { }

	[AsyncStateMachineAttribute] // RVA: 0xB7060 Offset: 0xB6460 VA: 0x1800B7060
	// RVA: 0x21C0FD0 Offset: 0x21BF5D0 VA: 0x1821C0FD0
	private void SendHeartbeatAndWait() { }

	// RVA: 0x21C12C0 Offset: 0x21BF8C0 VA: 0x1821C12C0 Slot: 10
	public void StaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7150 Offset: 0xB6550 VA: 0x1800B7150
	// RVA: 0x21C11D0 Offset: 0x21BF7D0 VA: 0x1821C11D0
	private void StaticColorImpl(Color color) { }

	// RVA: 0x21C0EC0 Offset: 0x21BF4C0 VA: 0x1821C0EC0 Slot: 11
	public void PulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xB72B0 Offset: 0xB66B0 VA: 0x1800B72B0
	// RVA: 0x21C0DC0 Offset: 0x21BF3C0 VA: 0x1821C0DC0
	private void PulseColorImpl(Color color, float duration) { }

	// RVA: 0x21C0CD0 Offset: 0x21BF2D0 VA: 0x1821C0CD0 Slot: 12
	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7440 Offset: 0xB6840 VA: 0x1800B7440
	// RVA: 0x21C0BE0 Offset: 0x21BF1E0 VA: 0x1821C0BE0
	private void EventImpl(RgbEventType type) { }

	// RVA: 0x21C10A0 Offset: 0x21BF6A0 VA: 0x1821C10A0
	private void ShutdownFromFailure() { }

	[AsyncStateMachineAttribute] // RVA: 0xB8880 Offset: 0xB7C80 VA: 0x1800B8880
	// RVA: -1 Offset: -1
	protected Task<HttpResponseMessage> SendPost<T>(string endpoint, T payload) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8780 Offset: 0xED6D80 VA: 0x180ED8780
	|-RestRgbService.SendPost<GameEvent<ColorEventData>>
	|
	|-RVA: 0xED8630 Offset: 0xED6C30 VA: 0x180ED8630
	|-RestRgbService.SendPost<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xED88D0 Offset: 0xED6ED0 VA: 0x180ED88D0
	|-RestRgbService.SendPost<GameMetadata>
	|
	|-RVA: 0xED8A20 Offset: 0xED7020 VA: 0x180ED8A20
	|-RestRgbService.SendPost<LoadGoLispHandlers>
	|
	|-RVA: 0xED8B70 Offset: 0xED7170 VA: 0x180ED8B70
	|-RestRgbService.SendPost<RegisterGameEvent>
	|
	|-RVA: 0xED8CC0 Offset: 0xED72C0 VA: 0x180ED8CC0
	|-RestRgbService.SendPost<RegisterTimelineEvents>
	|
	|-RVA: 0xED8E10 Offset: 0xED7410 VA: 0x180ED8E10
	|-RestRgbService.SendPost<RemoveGame>
	*/

	// RVA: -1 Offset: -1
	protected static HttpContent BuildContent<T>(T parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8010 Offset: 0xED6610 VA: 0x180ED8010
	|-RestRgbService.BuildContent<GameEvent<ColorEventData>>
	|
	|-RVA: 0xED7F30 Offset: 0xED6530 VA: 0x180ED7F30
	|-RestRgbService.BuildContent<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xED80F0 Offset: 0xED66F0 VA: 0x180ED80F0
	|-RestRgbService.BuildContent<GameMetadata>
	|
	|-RVA: 0xED81D0 Offset: 0xED67D0 VA: 0x180ED81D0
	|-RestRgbService.BuildContent<Heartbeat>
	|
	|-RVA: 0xED82B0 Offset: 0xED68B0 VA: 0x180ED82B0
	|-RestRgbService.BuildContent<LoadGoLispHandlers>
	|
	|-RVA: 0xED8390 Offset: 0xED6990 VA: 0x180ED8390
	|-RestRgbService.BuildContent<RegisterGameEvent>
	|
	|-RVA: 0xED8470 Offset: 0xED6A70 VA: 0x180ED8470
	|-RestRgbService.BuildContent<RegisterTimelineEvents>
	|
	|-RVA: 0xED8550 Offset: 0xED6B50 VA: 0x180ED8550
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
	|-RVA: 0x1204C0 Offset: 0x11F8C0 VA: 0x1801204C0
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.MoveNext
	|
	|-RVA: 0x1204D0 Offset: 0x11F8D0 VA: 0x1801204D0
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.MoveNext
	|
	|-RVA: 0x1204B0 Offset: 0x11F8B0 VA: 0x1801204B0
	|-RestRgbService.<SendPost>d__42<GameMetadata>.MoveNext
	|
	|-RVA: 0x120490 Offset: 0x11F890 VA: 0x180120490
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.MoveNext
	|
	|-RVA: 0x1204A0 Offset: 0x11F8A0 VA: 0x1801204A0
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.MoveNext
	|
	|-RVA: 0x120480 Offset: 0x11F880 VA: 0x180120480
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.MoveNext
	|
	|-RVA: 0x1204E0 Offset: 0x11F8E0 VA: 0x1801204E0
	|-RestRgbService.<SendPost>d__42<RemoveGame>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1206D0 Offset: 0x11FAD0 VA: 0x1801206D0
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.SetStateMachine
	|
	|-RVA: 0x1205E0 Offset: 0x11F9E0 VA: 0x1801205E0
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.SetStateMachine
	|
	|-RVA: 0x120540 Offset: 0x11F940 VA: 0x180120540
	|-RestRgbService.<SendPost>d__42<GameMetadata>.SetStateMachine
	|
	|-RVA: 0x120590 Offset: 0x11F990 VA: 0x180120590
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.SetStateMachine
	|
	|-RVA: 0x1204F0 Offset: 0x11F8F0 VA: 0x1801204F0
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.SetStateMachine
	|
	|-RVA: 0x120630 Offset: 0x11FA30 VA: 0x180120630
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.SetStateMachine
	|
	|-RVA: 0x120680 Offset: 0x11FA80 VA: 0x180120680
	|-RestRgbService.<SendPost>d__42<RemoveGame>.SetStateMachine
	*/

}

