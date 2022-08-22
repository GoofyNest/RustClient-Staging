public abstract class HttpContent : IDisposable // TypeDefIndex: 5744
{	// Fields
	private HttpContent.FixedMemoryStream buffer; // 0x10
	private Stream stream; // 0x18
	private bool disposed; // 0x20
	private HttpContentHeaders headers; // 0x28

	// Properties
	public HttpContentHeaders Headers { get; }
	internal Nullable<long> LoadedBufferLength { get; }

	// Methods

	// RVA: 0x108B6A0 Offset: 0x1089CA0 VA: 0x18108B6A0
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x108B770 Offset: 0x1089D70 VA: 0x18108B770
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x108AE50 Offset: 0x1089450 VA: 0x18108AE50
	internal void CopyTo(Stream stream) { }

	// RVA: 0x108ACF0 Offset: 0x10892F0 VA: 0x18108ACF0
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x108AD90 Offset: 0x1089390 VA: 0x18108AD90
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1BA0 Offset: 0xD0FA0 VA: 0x1800D1BA0
	// RVA: 0x108AF00 Offset: 0x1089500 VA: 0x18108AF00 Slot: 5
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x108B000 Offset: 0x1089600 VA: 0x18108B000
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0xFE4ED0 Offset: 0xFE34D0 VA: 0x180FE4ED0 Slot: 4
	public void Dispose() { }

	// RVA: 0x108B060 Offset: 0x1089660 VA: 0x18108B060 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108B300 Offset: 0x1089900 VA: 0x18108B300
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1DC0 Offset: 0xD11C0 VA: 0x1800D1DC0
	// RVA: 0x108B310 Offset: 0x1089910 VA: 0x18108B310
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1F90 Offset: 0xD1390 VA: 0x1800D1F90
	// RVA: 0x108B420 Offset: 0x1089A20 VA: 0x18108B420
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD2180 Offset: 0xD1580 VA: 0x1800D2180
	// RVA: 0x108B520 Offset: 0x1089B20 VA: 0x18108B520
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x108B080 Offset: 0x1089680 VA: 0x18108B080
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x108B620 Offset: 0x1089C20 VA: 0x18108B620
	private static int StartsWith(byte[] array, int length, byte[] value) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected internal abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

	// RVA: -1 Offset: -1 Slot: 8
	protected internal abstract bool TryComputeLength(out long length);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

private sealed class HttpContent.FixedMemoryStream : MemoryStream // TypeDefIndex: 5745
{	// Fields
	private readonly long maxSize; // 0x50

	// Methods

	// RVA: 0x1088780 Offset: 0x1086D80 VA: 0x181088780
	public void .ctor(long maxSize) { }

	// RVA: 0x1088620 Offset: 0x1086C20 VA: 0x181088620
	private void CheckOverflow(int count) { }

	// RVA: 0x10886E0 Offset: 0x1086CE0 VA: 0x1810886E0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1088720 Offset: 0x1086D20 VA: 0x181088720 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 5746
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19DF70 Offset: 0x19D370 VA: 0x18019DF70 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DF80 Offset: 0x19D380 VA: 0x18019DF80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<LoadIntoBufferAsync>d__17 : IAsyncStateMachine // TypeDefIndex: 5747
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	public long maxBufferSize; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x19E030 Offset: 0x19D430 VA: 0x18019E030 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 5748
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x28

	// Methods

	// RVA: 0x19E040 Offset: 0x19D440 VA: 0x18019E040 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E050 Offset: 0x19D450 VA: 0x18019E050 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 5749
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19E0A0 Offset: 0x19D4A0 VA: 0x18019E0A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0B0 Offset: 0x19D4B0 VA: 0x18019E0B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

