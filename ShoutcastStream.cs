public class ShoutcastStream : IDisposable // TypeDefIndex: 11982
{	// Fields
	private static HttpClient client; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint <currentWriteIndex>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_SocketConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	private void set_SocketConnected(bool value) { }

	// RVA: 0x598410 Offset: 0x596A10 VA: 0x180598410
	public int get_Frequency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	public uint get_currentWriteIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	private void set_currentWriteIndex(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public float[] get_floatSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	private void set_floatSamples(float[] value) { }

	// RVA: 0x597F10 Offset: 0x596510 VA: 0x180597F10
	public static void RunConnections() { }

	// RVA: 0x597510 Offset: 0x595B10 VA: 0x180597510
	public static ShoutcastStream GetExistingStream(string host) { }

	// RVA: 0x5976A0 Offset: 0x595CA0 VA: 0x1805976A0
	public uint GetLeadStreamerReadIndex() { }

	// RVA: 0x597A70 Offset: 0x596070 VA: 0x180597A70
	public bool IsLeadStream(ShoutcastStreamer stream) { }

	// RVA: 0x597DB0 Offset: 0x5963B0 VA: 0x180597DB0
	public void ResetSamples(uint read) { }

	// RVA: 0x597760 Offset: 0x595D60 VA: 0x180597760
	public void InitialiseConnection(string host, ShoutcastStreamer forStreamer) { }

	// RVA: 0x597D40 Offset: 0x596340 VA: 0x180597D40
	public void RegisterNewStreamer(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC9AD0 Offset: 0xC8ED0 VA: 0x1800C9AD0
	// RVA: 0x5970D0 Offset: 0x5956D0 VA: 0x1805970D0
	private Task ConnectAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xC9CA0 Offset: 0xC90A0 VA: 0x1800C9CA0
	// RVA: 0x597B00 Offset: 0x596100 VA: 0x180597B00
	public Task<bool> ReadDataAsync(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC9EA0 Offset: 0xC92A0 VA: 0x1800C9EA0
	// RVA: 0x597C20 Offset: 0x596220 VA: 0x180597C20
	private Task<bool> ReadDataAsync(byte[] byteBuffer) { }

	// RVA: 0x597990 Offset: 0x595F90 VA: 0x180597990
	private float[] IntToFloat(short[] from) { }

	// RVA: 0x596F30 Offset: 0x595530 VA: 0x180596F30
	private short[] ByteToInt16(byte[] buffer) { }

	// RVA: 0x596D00 Offset: 0x595300 VA: 0x180596D00
	private float[] ByteToFloat(byte[] bArray) { }

	// RVA: 0x5971D0 Offset: 0x5957D0 VA: 0x1805971D0
	private void Disconnect() { }

	// RVA: 0x597080 Offset: 0x595680 VA: 0x180597080
	private void ClearFloatSamples() { }

	// RVA: 0x597420 Offset: 0x595A20 VA: 0x180597420 Slot: 4
	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0xC9FA0 Offset: 0xC93A0 VA: 0x1800C9FA0
	// RVA: 0x597420 Offset: 0x595A20 VA: 0x180597420
	private Task ShutdownSafely() { }

	// RVA: 0x596B90 Offset: 0x595190 VA: 0x180596B90
	public void AttemptDisconnect(ShoutcastStreamer streamer) { }

	// RVA: 0x5982E0 Offset: 0x5968E0 VA: 0x1805982E0
	public void .ctor() { }

	// RVA: 0x5981C0 Offset: 0x5967C0 VA: 0x1805981C0
	private static void .cctor() { }

}

private sealed class ShoutcastStream.<>c__DisplayClass42_0 // TypeDefIndex: 11983
{	// Fields
	public Stream stream; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5A4AC0 Offset: 0x5A30C0 VA: 0x1805A4AC0
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

	// RVA: 0xF32E0 Offset: 0xF26E0 VA: 0x1800F32E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
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

	// RVA: 0xF33C0 Offset: 0xF27C0 VA: 0x1800F33C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF33D0 Offset: 0xF27D0 VA: 0x1800F33D0 Slot: 5
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

	// RVA: 0xF3420 Offset: 0xF2820 VA: 0x1800F3420 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF3430 Offset: 0xF2830 VA: 0x1800F3430 Slot: 5
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

	// RVA: 0xF34A0 Offset: 0xF28A0 VA: 0x1800F34A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

