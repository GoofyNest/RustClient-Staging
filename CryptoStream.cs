public class CryptoStream : Stream, IDisposable // TypeDefIndex: 949
{	// Fields
	private Stream _stream; // 0x28
	private ICryptoTransform _Transform; // 0x30
	private byte[] _InputBuffer; // 0x38
	private int _InputBufferIndex; // 0x40
	private int _InputBlockSize; // 0x44
	private byte[] _OutputBuffer; // 0x48
	private int _OutputBufferIndex; // 0x50
	private int _OutputBlockSize; // 0x54
	private CryptoStreamMode _transformMode; // 0x58
	private bool _canRead; // 0x5C
	private bool _canWrite; // 0x5D
	private bool _finalBlockTransformed; // 0x5E

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }

	// Methods

	// RVA: 0x16FC350 Offset: 0x16FA950 VA: 0x1816FC350
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x15F1E80 Offset: 0x15F0480 VA: 0x1815F1E80 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x15F1E70 Offset: 0x15F0470 VA: 0x1815F1E70 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16FC600 Offset: 0x16FAC00 VA: 0x1816FC600 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16FC670 Offset: 0x16FAC70 VA: 0x1816FC670 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16FC6E0 Offset: 0x16FACE0 VA: 0x1816FC6E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x15F1E60 Offset: 0x15F0460 VA: 0x1815F1E60
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x16FACD0 Offset: 0x16F92D0 VA: 0x1816FACD0
	public void FlushFinalBlock() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x16FB9D0 Offset: 0x16F9FD0 VA: 0x1816FB9D0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16FBA40 Offset: 0x16FA040 VA: 0x1816FBA40 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16FB440 Offset: 0x16F9A40 VA: 0x1816FB440 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x16FB0B0 Offset: 0x16F96B0 VA: 0x1816FB0B0 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8E30 Offset: 0xC8230 VA: 0x1800C8E30
	// RVA: 0x16FAF60 Offset: 0x16F9560 VA: 0x1816FAF60
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16FBF60 Offset: 0x16FA560 VA: 0x1816FBF60 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16FBBF0 Offset: 0x16FA1F0 VA: 0x1816FBBF0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8FC0 Offset: 0xC83C0 VA: 0x1800C8FC0
	// RVA: 0x16FBAB0 Offset: 0x16FA0B0 VA: 0x1816FBAB0
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15D3730 Offset: 0x15D1D30 VA: 0x1815D3730
	public void Clear() { }

	// RVA: 0x16FAB50 Offset: 0x16F9150 VA: 0x1816FAB50 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FAEB0 Offset: 0x16F94B0 VA: 0x1816FAEB0
	private void InitializeBuffer() { }

}

private struct CryptoStream.HopToThreadPoolAwaitable : INotifyCompletion // TypeDefIndex: 950
{	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x14CC10 Offset: 0x14C010 VA: 0x18014CC10
	public CryptoStream.HopToThreadPoolAwaitable GetAwaiter() { }

	// RVA: 0x207500 Offset: 0x206900 VA: 0x180207500
	public bool get_IsCompleted() { }

	// RVA: 0x2074A0 Offset: 0x2068A0 VA: 0x1802074A0 Slot: 4
	public void OnCompleted(Action continuation) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void GetResult() { }

}

private struct CryptoStream.<ReadAsyncInternal>d__34 : IAsyncStateMachine // TypeDefIndex: 951
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private byte[] <tempInputBuffer>5__1; // 0x40
	private int <currentOutputIndex>5__2; // 0x48
	private int <bytesToDeliver>5__3; // 0x4C
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60
	private int <>7__wrap1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__3; // 0x78

	// Methods

	// RVA: 0x207510 Offset: 0x206910 VA: 0x180207510 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x207520 Offset: 0x206920 VA: 0x180207520 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CryptoStream.<WriteAsyncInternal>d__37 : IAsyncStateMachine // TypeDefIndex: 952
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public int count; // 0x28
	public int offset; // 0x2C
	public byte[] buffer; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private int <bytesToWrite>5__1; // 0x40
	private int <currentInputIndex>5__2; // 0x44
	private int <numWholeBlocksInBytes>5__3; // 0x48
	private SemaphoreSlim <sem>5__4; // 0x50
	private CryptoStream.HopToThreadPoolAwaitable <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x60

	// Methods

	// RVA: 0x207570 Offset: 0x206970 VA: 0x180207570 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

