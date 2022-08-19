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

	// RVA: 0x108B3E0 Offset: 0x10899E0 VA: 0x18108B3E0
	public HttpContentHeaders get_Headers() { }

	// RVA: 0x108B4B0 Offset: 0x1089AB0 VA: 0x18108B4B0
	internal Nullable<long> get_LoadedBufferLength() { }

	// RVA: 0x108AB90 Offset: 0x1089190 VA: 0x18108AB90
	internal void CopyTo(Stream stream) { }

	// RVA: 0x108AA30 Offset: 0x1089030 VA: 0x18108AA30
	public Task CopyToAsync(Stream stream) { }

	// RVA: 0x108AAD0 Offset: 0x10890D0 VA: 0x18108AAD0
	public Task CopyToAsync(Stream stream, TransportContext context) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1B10 Offset: 0xD0F10 VA: 0x1800D1B10
	// RVA: 0x108AC40 Offset: 0x1089240 VA: 0x18108AC40 Slot: 5
	protected virtual Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x108AD40 Offset: 0x1089340 VA: 0x18108AD40
	private static HttpContent.FixedMemoryStream CreateFixedMemoryStream(long maxBufferSize) { }

	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10 Slot: 4
	public void Dispose() { }

	// RVA: 0x108ADA0 Offset: 0x10893A0 VA: 0x18108ADA0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108B040 Offset: 0x1089640 VA: 0x18108B040
	public Task LoadIntoBufferAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1D30 Offset: 0xD1130 VA: 0x1800D1D30
	// RVA: 0x108B050 Offset: 0x1089650 VA: 0x18108B050
	public Task LoadIntoBufferAsync(long maxBufferSize) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1F00 Offset: 0xD1300 VA: 0x1800D1F00
	// RVA: 0x108B160 Offset: 0x1089760 VA: 0x18108B160
	public Task<Stream> ReadAsStreamAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0xD20F0 Offset: 0xD14F0 VA: 0x1800D20F0
	// RVA: 0x108B260 Offset: 0x1089860 VA: 0x18108B260
	public Task<string> ReadAsStringAsync() { }

	// RVA: 0x108ADC0 Offset: 0x10893C0 VA: 0x18108ADC0
	private static Encoding GetEncodingFromBuffer(byte[] buffer, int length, ref int preambleLength) { }

	// RVA: 0x108B360 Offset: 0x1089960 VA: 0x18108B360
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

	// RVA: 0x10884C0 Offset: 0x1086AC0 VA: 0x1810884C0
	public void .ctor(long maxSize) { }

	// RVA: 0x1088360 Offset: 0x1086960 VA: 0x181088360
	private void CheckOverflow(int count) { }

	// RVA: 0x1088420 Offset: 0x1086A20 VA: 0x181088420 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x1088460 Offset: 0x1086A60 VA: 0x181088460 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

}

private struct HttpContent.<CreateContentReadStreamAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 5746
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19DFF0 Offset: 0x19D3F0 VA: 0x18019DFF0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E000 Offset: 0x19D400 VA: 0x18019E000 Slot: 5
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

	// RVA: 0x19E0B0 Offset: 0x19D4B0 VA: 0x18019E0B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStreamAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 5748
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x28

	// Methods

	// RVA: 0x19E0C0 Offset: 0x19D4C0 VA: 0x18019E0C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E0D0 Offset: 0x19D4D0 VA: 0x18019E0D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct HttpContent.<ReadAsStringAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 5749
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public HttpContent <>4__this; // 0x20
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x19E120 Offset: 0x19D520 VA: 0x18019E120 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19E130 Offset: 0x19D530 VA: 0x18019E130 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

