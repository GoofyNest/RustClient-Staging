public class ShoutcastStream : IDisposable // TypeDefIndex: 11982
{	// Fields
	private static HttpClient client; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <SocketConnected>k__BackingField; // 0x10
	private MP3Stream MP3Stream; // 0x18
	private CancellationTokenSource cancelSource; // 0x20
	private CancellationToken cancelToken; // 0x28
	private bool disconnected; // 0x30
	private bool connecting; // 0x31
	private static TimeSince lastStreamInit; // 0x8
	private static int sessionCount; // 0xC
	private int sessionId; // 0x34
	private bool reading; // 0x38
	private string url; // 0x40
	private static List<float[]> pooledBuffers; // 0x10
	public const uint MaxSampleBuffer = 163840;
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <currentWriteIndex>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float[] <floatSamples>k__BackingField; // 0x50
	private byte[] buffer; // 0x58
	public float[] floatBuffer; // 0x60
	public const uint bufferSize = 32768;
	private const float const_1_div_32768_ = 3,051758E-05;
	private List<ShoutcastStreamer> connectedStreamers; // 0x68
	private static List<ShoutcastStream> connections; // 0x18
	private static List<ShoutcastStream> active; // 0x20
	private static int lastFrameUpdate; // 0x28
	private float[] intToFloatBuffer; // 0x70
	private short[] zeroResult; // 0x78
	private short[] byteResult; // 0x80

	// Properties
	public bool SocketConnected { get; set; }
	public int Frequency { get; }
	public uint currentWriteIndex { get; set; }
	public float[] floatSamples { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_SocketConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	private void set_SocketConnected(bool value) { }

	// RVA: 0x5983A0 Offset: 0x5969A0 VA: 0x1805983A0
	public int get_Frequency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	public uint get_currentWriteIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	private void set_currentWriteIndex(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public float[] get_floatSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	private void set_floatSamples(float[] value) { }

	// RVA: 0x597EA0 Offset: 0x5964A0 VA: 0x180597EA0
	public static void RunConnections() { }

	// RVA: 0x5974A0 Offset: 0x595AA0 VA: 0x1805974A0
	public static ShoutcastStream GetExistingStream(string host) { }

	// RVA: 0x597630 Offset: 0x595C30 VA: 0x180597630
	public uint GetLeadStreamerReadIndex() { }

	// RVA: 0x597A00 Offset: 0x596000 VA: 0x180597A00
	public bool IsLeadStream(ShoutcastStreamer stream) { }

	// RVA: 0x597D40 Offset: 0x596340 VA: 0x180597D40
	public void ResetSamples(uint read) { }

	// RVA: 0x5976F0 Offset: 0x595CF0 VA: 0x1805976F0
	public void InitialiseConnection(string host, ShoutcastStreamer forStreamer) { }

	// RVA: 0x597CD0 Offset: 0x5962D0 VA: 0x180597CD0
	public void RegisterNewStreamer(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC9C30 Offset: 0xC9030 VA: 0x1800C9C30
	// RVA: 0x597060 Offset: 0x595660 VA: 0x180597060
	private Task ConnectAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xC9DC0 Offset: 0xC91C0 VA: 0x1800C9DC0
	// RVA: 0x597A90 Offset: 0x596090 VA: 0x180597A90
	public Task<bool> ReadDataAsync(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC9F70 Offset: 0xC9370 VA: 0x1800C9F70
	// RVA: 0x597BB0 Offset: 0x5961B0 VA: 0x180597BB0
	private Task<bool> ReadDataAsync(byte[] byteBuffer) { }

	// RVA: 0x597920 Offset: 0x595F20 VA: 0x180597920
	private float[] IntToFloat(short[] from) { }

	// RVA: 0x596EC0 Offset: 0x5954C0 VA: 0x180596EC0
	private short[] ByteToInt16(byte[] buffer) { }

	// RVA: 0x596C90 Offset: 0x595290 VA: 0x180596C90
	private float[] ByteToFloat(byte[] bArray) { }

	// RVA: 0x597160 Offset: 0x595760 VA: 0x180597160
	private void Disconnect() { }

	// RVA: 0x597010 Offset: 0x595610 VA: 0x180597010
	private void ClearFloatSamples() { }

	// RVA: 0x5973B0 Offset: 0x5959B0 VA: 0x1805973B0 Slot: 4
	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0xCA030 Offset: 0xC9430 VA: 0x1800CA030
	// RVA: 0x5973B0 Offset: 0x5959B0 VA: 0x1805973B0
	private Task ShutdownSafely() { }

	// RVA: 0x596B20 Offset: 0x595120 VA: 0x180596B20
	public void AttemptDisconnect(ShoutcastStreamer streamer) { }

	// RVA: 0x598270 Offset: 0x596870 VA: 0x180598270
	public void .ctor() { }

	// RVA: 0x598150 Offset: 0x596750 VA: 0x180598150
	private static void .cctor() { }

}

private sealed class ShoutcastStream.<>c__DisplayClass42_0 // TypeDefIndex: 11983
{	// Fields
	public Stream stream; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4A50 Offset: 0x5A3050 VA: 0x1805A4A50
	internal MP3Stream <ConnectAsync>b__0() { }

}

private struct ShoutcastStream.<ConnectAsync>d__42 : IAsyncStateMachine // TypeDefIndex: 11984
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	private ShoutcastStream.<>c__DisplayClass42_0 <>8__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30
	private TaskAwaiter<Stream> <>u__2; // 0x38
	private TaskAwaiter<MP3Stream> <>u__3; // 0x40

	// Methods

	// RVA: 0xF3260 Offset: 0xF2660 VA: 0x1800F3260 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__43 : IAsyncStateMachine // TypeDefIndex: 11985
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ShoutcastStreamer forStreamer; // 0x20
	public ShoutcastStream <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3340 Offset: 0xF2740 VA: 0x1800F3340 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3350 Offset: 0xF2750 VA: 0x1800F3350 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__44 : IAsyncStateMachine // TypeDefIndex: 11986
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	public byte[] byteBuffer; // 0x28
	private TaskAwaiter<int> <>u__1; // 0x30

	// Methods

	// RVA: 0xF33A0 Offset: 0xF27A0 VA: 0x1800F33A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF33B0 Offset: 0xF27B0 VA: 0x1800F33B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ShutdownSafely>d__54 : IAsyncStateMachine // TypeDefIndex: 11987
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	private Stopwatch <stopwatch>5__2; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF3420 Offset: 0xF2820 VA: 0x1800F3420 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

