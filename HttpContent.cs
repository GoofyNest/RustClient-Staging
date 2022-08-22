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

	// RVA: 0x108C110 Offset: 0x108A710 VA: 0x18108C110
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x108C1E0 Offset: 0x108A7E0 VA: 0x18108C1E0
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x108B8C0 Offset: 0x1089EC0 VA: 0x18108B8C0
	internal void CopyTo(Stream stream) { }

	// RVA: 0x108B760 Offset: 0x1089D60 VA: 0x18108B760
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x108B800 Offset: 0x1089E00 VA: 0x18108B800
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1BA0 Offset: 0xD0FA0 VA: 0x1800D1BA0
	// RVA: 0x108B970 Offset: 0x1089F70 VA: 0x18108B970 Slot: 5
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x108BA70 Offset: 0x108A070 VA: 0x18108BA70
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970 Slot: 4
	public void Dispose() { }

	// RVA: 0x108BAD0 Offset: 0x108A0D0 VA: 0x18108BAD0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108BD70 Offset: 0x108A370 VA: 0x18108BD70
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1DC0 Offset: 0xD11C0 VA: 0x1800D1DC0
	// RVA: 0x108BD80 Offset: 0x108A380 VA: 0x18108BD80
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1F90 Offset: 0xD1390 VA: 0x1800D1F90
	// RVA: 0x108BE90 Offset: 0x108A490 VA: 0x18108BE90
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD2180 Offset: 0xD1580 VA: 0x1800D2180
	// RVA: 0x108BF90 Offset: 0x108A590 VA: 0x18108BF90
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x108BAF0 Offset: 0x108A0F0 VA: 0x18108BAF0
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x108C090 Offset: 0x108A690 VA: 0x18108C090
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

	// RVA: 0x10891F0 Offset: 0x10877F0 VA: 0x1810891F0
	public void .ctor(long maxSize) { }

	// RVA: 0x1089090 Offset: 0x1087690 VA: 0x181089090
	private void CheckOverflow(int count) { }

	// RVA: 0x1089150 Offset: 0x1087750 VA: 0x181089150 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1089190 Offset: 0x1087790 VA: 0x181089190 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 5746
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19DC60 Offset: 0x19D060 VA: 0x18019DC60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DC70 Offset: 0x19D070 VA: 0x18019DC70 Slot: 5
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

	// RVA: 0x19DD20 Offset: 0x19D120 VA: 0x18019DD20 Slot: 4
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

	// RVA: 0x19DD30 Offset: 0x19D130 VA: 0x18019DD30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DD40 Offset: 0x19D140 VA: 0x18019DD40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 5749
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19DD90 Offset: 0x19D190 VA: 0x18019DD90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DDA0 Offset: 0x19D1A0 VA: 0x18019DDA0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

