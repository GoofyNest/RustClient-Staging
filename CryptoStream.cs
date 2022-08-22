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

	// RVA: 0x16FA200 Offset: 0x16F8800 VA: 0x1816FA200
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x15DF460 Offset: 0x15DDA60 VA: 0x1815DF460 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x15DF450 Offset: 0x15DDA50 VA: 0x1815DF450 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16FA4B0 Offset: 0x16F8AB0 VA: 0x1816FA4B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16FA520 Offset: 0x16F8B20 VA: 0x1816FA520 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16FA590 Offset: 0x16F8B90 VA: 0x1816FA590 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x15DF440 Offset: 0x15DDA40 VA: 0x1815DF440
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x16F8B80 Offset: 0x16F7180 VA: 0x1816F8B80
	public void FlushFinalBlock() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x16F9880 Offset: 0x16F7E80 VA: 0x1816F9880 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16F98F0 Offset: 0x16F7EF0 VA: 0x1816F98F0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16F92F0 Offset: 0x16F78F0 VA: 0x1816F92F0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x16F8F60 Offset: 0x16F7560 VA: 0x1816F8F60 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8E30 Offset: 0xC8230 VA: 0x1800C8E30
	// RVA: 0x16F8E10 Offset: 0x16F7410 VA: 0x1816F8E10
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16F9E10 Offset: 0x16F8410 VA: 0x1816F9E10 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16F9AA0 Offset: 0x16F80A0 VA: 0x1816F9AA0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8FC0 Offset: 0xC83C0 VA: 0x1800C8FC0
	// RVA: 0x16F9960 Offset: 0x16F7F60 VA: 0x1816F9960
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15D2AC0 Offset: 0x15D10C0 VA: 0x1815D2AC0
	public void Clear() { }

	// RVA: 0x16F8A00 Offset: 0x16F7000 VA: 0x1816F8A00 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16F8D60 Offset: 0x16F7360 VA: 0x1816F8D60
	private void InitializeBuffer() { }

}

private struct CryptoStream.HopToThreadPoolAwaitable : INotifyCompletion // TypeDefIndex: 950
{	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x14CA30 Offset: 0x14BE30 VA: 0x18014CA30
	public CryptoStream.HopToThreadPoolAwaitable GetAwaiter() { }

	// RVA: 0x207130 Offset: 0x206530 VA: 0x180207130
	public bool get_IsCompleted() { }

	// RVA: 0x2070D0 Offset: 0x2064D0 VA: 0x1802070D0 Slot: 4
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

	// RVA: 0x207140 Offset: 0x206540 VA: 0x180207140 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x207150 Offset: 0x206550 VA: 0x180207150 Slot: 5
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

	// RVA: 0x2071A0 Offset: 0x2065A0 VA: 0x1802071A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

