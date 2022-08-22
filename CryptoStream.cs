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

	// RVA: 0x16FC610 Offset: 0x16FAC10 VA: 0x1816FC610
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x15F2140 Offset: 0x15F0740 VA: 0x1815F2140 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x15F2130 Offset: 0x15F0730 VA: 0x1815F2130 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x16FC8C0 Offset: 0x16FAEC0 VA: 0x1816FC8C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x16FC930 Offset: 0x16FAF30 VA: 0x1816FC930 Slot: 11
	public override long get_Position() { }

	// RVA: 0x16FC9A0 Offset: 0x16FAFA0 VA: 0x1816FC9A0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x15F2120 Offset: 0x15F0720 VA: 0x1815F2120
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x16FAF90 Offset: 0x16F9590 VA: 0x1816FAF90
	public void FlushFinalBlock() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x16FBC90 Offset: 0x16FA290 VA: 0x1816FBC90 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x16FBD00 Offset: 0x16FA300 VA: 0x1816FBD00 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x16FB700 Offset: 0x16F9D00 VA: 0x1816FB700 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x16FB370 Offset: 0x16F9970 VA: 0x1816FB370 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8E30 Offset: 0xC8230 VA: 0x1800C8E30
	// RVA: 0x16FB220 Offset: 0x16F9820 VA: 0x1816FB220
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16FC220 Offset: 0x16FA820 VA: 0x1816FC220 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x16FBEB0 Offset: 0x16FA4B0 VA: 0x1816FBEB0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xC8FC0 Offset: 0xC83C0 VA: 0x1800C8FC0
	// RVA: 0x16FBD70 Offset: 0x16FA370 VA: 0x1816FBD70
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x15D39F0 Offset: 0x15D1FF0 VA: 0x1815D39F0
	public void Clear() { }

	// RVA: 0x16FAE10 Offset: 0x16F9410 VA: 0x1816FAE10 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FB170 Offset: 0x16F9770 VA: 0x1816FB170
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

