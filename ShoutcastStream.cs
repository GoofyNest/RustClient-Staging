public class ShoutcastStream : IDisposable // TypeDefIndex: 11986
{	private static HttpClient client; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private uint <currentWriteIndex>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

	public bool SocketConnected { get; set; }
	public int Frequency { get; }
	public uint currentWriteIndex { get; set; }
	public float[] floatSamples { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_SocketConnected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_SocketConnected(bool value) { }

	public int get_Frequency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public uint get_currentWriteIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_currentWriteIndex(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float[] get_floatSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_floatSamples(float[] value) { }

	public static void RunConnections() { }

	public static ShoutcastStream GetExistingStream(string host) { }

	public uint GetLeadStreamerReadIndex() { }

	public bool IsLeadStream(ShoutcastStreamer stream) { }

	public void ResetSamples(uint read) { }

	public void InitialiseConnection(string host, ShoutcastStreamer forStreamer) { }

	public void RegisterNewStreamer(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xC9ED0 Offset: 0xC92D0 VA: 0x1800C9ED0
	private Task ConnectAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xCA050 Offset: 0xC9450 VA: 0x1800CA050
	public Task<bool> ReadDataAsync(ShoutcastStreamer forStreamer) { }

	[AsyncStateMachineAttribute] // RVA: 0xCA1C0 Offset: 0xC95C0 VA: 0x1800CA1C0
	private Task<bool> ReadDataAsync(byte[] byteBuffer) { }

	private float[] IntToFloat(short[] from) { }

	private short[] ByteToInt16(byte[] buffer) { }

	private float[] ByteToFloat(byte[] bArray) { }

	private void Disconnect() { }

	private void ClearFloatSamples() { }

	public void Dispose() { }

	[AsyncStateMachineAttribute] // RVA: 0xCA2C0 Offset: 0xC96C0 VA: 0x1800CA2C0
	private Task ShutdownSafely() { }

	public void AttemptDisconnect(ShoutcastStreamer streamer) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class ShoutcastStream.<>c__DisplayClass42_0 // TypeDefIndex: 11987
{	public Stream stream; // 0x10


	public void .ctor() { }

	internal MP3Stream <ConnectAsync>b__0() { }

}

private struct ShoutcastStream.<ConnectAsync>d__42 : IAsyncStateMachine // TypeDefIndex: 11988
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	private ShoutcastStream.<>c__DisplayClass42_0 <>8__1; // 0x28
	private TaskAwaiter<HttpResponseMessage> <>u__1; // 0x30
	private TaskAwaiter<Stream> <>u__2; // 0x38
	private TaskAwaiter<MP3Stream> <>u__3; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__43 : IAsyncStateMachine // TypeDefIndex: 11989
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ShoutcastStreamer forStreamer; // 0x20
	public ShoutcastStream <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ReadDataAsync>d__44 : IAsyncStateMachine // TypeDefIndex: 11990
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	public byte[] byteBuffer; // 0x28
	private TaskAwaiter<int> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ShoutcastStream.<ShutdownSafely>d__54 : IAsyncStateMachine // TypeDefIndex: 11991
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ShoutcastStream <>4__this; // 0x20
	private Stopwatch <stopwatch>5__2; // 0x28
	private TaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

