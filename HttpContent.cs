public abstract class HttpContent : IDisposable // TypeDefIndex: 5744
{	private HttpContent.FixedMemoryStream buffer; // 0x10
	private Stream stream; // 0x18
	private bool disposed; // 0x20
	private HttpContentHeaders headers; // 0x28

	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }


	public HttpContentHeaders get_Headers() { }

	internal Nullable<long> get_LoadedBufferLength() { }

	internal void CopyTo(Stream stream) { }

	public Task CopyToAsync(Stream stream) { }

	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1C90 Offset: 0xD1090 VA: 0x1800D1C90
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1E60 Offset: 0xD1260 VA: 0x1800D1E60
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1FE0 Offset: 0xD13E0 VA: 0x1800D1FE0
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD2180 Offset: 0xD1580 VA: 0x1800D2180
	public Task<string> ReadAsStringAsync() { }

	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	private static int StartsWith(byte[] array, int length, byte[] value) { }

	protected internal abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	protected internal abstract bool TryComputeLength(out long length);

	protected void .ctor() { }

}

private sealed class HttpContent.FixedMemoryStream : MemoryStream // TypeDefIndex: 5745
{	private readonly long maxSize; // 0x50


	public void .ctor(long maxSize) { }

	private void CheckOverflow(int count) { }

	public override void WriteByte(byte value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

}

private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 5746
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<LoadIntoBufferAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 5747
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	public long maxBufferSize; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 5748
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 5749
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

