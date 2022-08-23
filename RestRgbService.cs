public abstract class RestRgbService : IRgbService // TypeDefIndex: 7678
{	private readonly SemaphoreSlim _sema; // 0x10
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

	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }
	protected HttpClient Client { get; set; }
	protected TimeSpan HeartbeatInterval { get; set; }
	protected TimeSpan ReinitializeDelay { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_ColorCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected HttpClient get_Client() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_Client(HttpClient value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TimeSpan get_HeartbeatInterval() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_HeartbeatInterval(TimeSpan value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected TimeSpan get_ReinitializeDelay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_ReinitializeDelay(TimeSpan value) { }

	protected void .ctor() { }

	protected abstract ValueTask<bool> Initialize();

	protected abstract ValueTask Shutdown();

	protected abstract Task SendHeartbeat();

	protected abstract Task SendStaticColor(Color color);

	protected abstract Task SendPulseColor(Color color, float duration);

	protected abstract Task SendEvent(RgbEventType type);

	[AsyncStateMachineAttribute] // RVA: 0xB6BE0 Offset: 0xB5FE0 VA: 0x1800B6BE0
	public ValueTask Start() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6E30 Offset: 0xB6230 VA: 0x1800B6E30
	public ValueTask Stop() { }

	[AsyncStateMachineAttribute] // RVA: 0xB6FE0 Offset: 0xB63E0 VA: 0x1800B6FE0
	public ValueTask Update() { }

	[AsyncStateMachineAttribute] // RVA: 0xB7060 Offset: 0xB6460 VA: 0x1800B7060
	private void SendHeartbeatAndWait() { }

	public void StaticColor(Color color) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7150 Offset: 0xB6550 VA: 0x1800B7150
	private void StaticColorImpl(Color color) { }

	public void PulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] // RVA: 0xB72B0 Offset: 0xB66B0 VA: 0x1800B72B0
	private void PulseColorImpl(Color color, float duration) { }

	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] // RVA: 0xB7440 Offset: 0xB6840 VA: 0x1800B7440
	private void EventImpl(RgbEventType type) { }

	private void ShutdownFromFailure() { }

	[AsyncStateMachineAttribute] // RVA: 0xB8880 Offset: 0xB7C80 VA: 0x1800B8880
	protected Task<HttpResponseMessage> SendPost<T>(string endpoint, T payload) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED87C0 Offset: 0xED6DC0 VA: 0x180ED87C0
	|-RestRgbService.SendPost<GameEvent<ColorEventData>>
	|
	|-RVA: 0xED8670 Offset: 0xED6C70 VA: 0x180ED8670
	|-RestRgbService.SendPost<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xED8910 Offset: 0xED6F10 VA: 0x180ED8910
	|-RestRgbService.SendPost<GameMetadata>
	|
	|-RVA: 0xED8A60 Offset: 0xED7060 VA: 0x180ED8A60
	|-RestRgbService.SendPost<LoadGoLispHandlers>
	|
	|-RVA: 0xED8BB0 Offset: 0xED71B0 VA: 0x180ED8BB0
	|-RestRgbService.SendPost<RegisterGameEvent>
	|
	|-RVA: 0xED8D00 Offset: 0xED7300 VA: 0x180ED8D00
	|-RestRgbService.SendPost<RegisterTimelineEvents>
	|
	|-RVA: 0xED8E50 Offset: 0xED7450 VA: 0x180ED8E50
	|-RestRgbService.SendPost<RemoveGame>
	*/

	protected static HttpContent BuildContent<T>(T parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8050 Offset: 0xED6650 VA: 0x180ED8050
	|-RestRgbService.BuildContent<GameEvent<ColorEventData>>
	|
	|-RVA: 0xED7F70 Offset: 0xED6570 VA: 0x180ED7F70
	|-RestRgbService.BuildContent<GameEvent<EmptyEventData>>
	|
	|-RVA: 0xED8130 Offset: 0xED6730 VA: 0x180ED8130
	|-RestRgbService.BuildContent<GameMetadata>
	|
	|-RVA: 0xED8210 Offset: 0xED6810 VA: 0x180ED8210
	|-RestRgbService.BuildContent<Heartbeat>
	|
	|-RVA: 0xED82F0 Offset: 0xED68F0 VA: 0x180ED82F0
	|-RestRgbService.BuildContent<LoadGoLispHandlers>
	|
	|-RVA: 0xED83D0 Offset: 0xED69D0 VA: 0x180ED83D0
	|-RestRgbService.BuildContent<RegisterGameEvent>
	|
	|-RVA: 0xED84B0 Offset: 0xED6AB0 VA: 0x180ED84B0
	|-RestRgbService.BuildContent<RegisterTimelineEvents>
	|
	|-RVA: 0xED8590 Offset: 0xED6B90 VA: 0x180ED8590
	|-RestRgbService.BuildContent<RemoveGame>
	*/

}

private struct RestRgbService.<Start>d__31 : IAsyncStateMachine // TypeDefIndex: 7679
{	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30
	private ValueTaskAwaiter<bool> <>u__2; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Stop>d__32 : IAsyncStateMachine // TypeDefIndex: 7680
{	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter <>u__1; // 0x30
	private ValueTaskAwaiter <>u__2; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Update>d__33 : IAsyncStateMachine // TypeDefIndex: 7681
{	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private ValueTaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendHeartbeatAndWait>d__34 : IAsyncStateMachine // TypeDefIndex: 7682
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<StaticColorImpl>d__36 : IAsyncStateMachine // TypeDefIndex: 7683
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public Color color; // 0x30
	private TaskAwaiter <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<PulseColorImpl>d__38 : IAsyncStateMachine // TypeDefIndex: 7684
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public Color color; // 0x30
	public float duration; // 0x40
	private TaskAwaiter <>u__1; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<EventImpl>d__40 : IAsyncStateMachine // TypeDefIndex: 7685
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public RestRgbService <>4__this; // 0x28
	public RgbEventType type; // 0x30
	private TaskAwaiter <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendPost>d__42<T> : IAsyncStateMachine // TypeDefIndex: 7686
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; // 0x0
	public T payload; // 0x0
	public RestRgbService <>4__this; // 0x0
	public string endpoint; // 0x0
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x0


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

