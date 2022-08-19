public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 638
{	// Fields
	public static readonly Stream Null; // 0x0
	private const int _DefaultCopyBufferSize = 81920;
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x16331D0 Offset: 0x16317D0 VA: 0x1816331D0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void set_Position(long value);

	// RVA: 0x1633DA0 Offset: 0x16323A0 VA: 0x181633DA0 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x1633E10 Offset: 0x1632410 VA: 0x181633E10 Slot: 14
	public virtual int get_WriteTimeout() { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1632920 Offset: 0x1630F20 VA: 0x181632920
	public Task CopyToAsync(Stream destination) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1632890 Offset: 0x1630E90 VA: 0x181632890
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1632510 Offset: 0x1630B10 VA: 0x181632510 Slot: 15
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3D20 Offset: 0xA3120 VA: 0x1800A3D20
	// RVA: 0x16323D0 Offset: 0x16309D0 VA: 0x1816323D0
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x16329A0 Offset: 0x1630FA0 VA: 0x1816329A0
	public void CopyTo(Stream destination) { }

	// RVA: 0x16332D0 Offset: 0x16318D0 VA: 0x1816332D0
	private void InternalCopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1632360 Offset: 0x1630960 VA: 0x181632360 Slot: 16
	public virtual void Close() { }

	// RVA: 0x15D3730 Offset: 0x15D1D30 VA: 0x1815D3730 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Flush();

	// RVA: 0x1631DE0 Offset: 0x16303E0 VA: 0x181631DE0 Slot: 19
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1631BC0 Offset: 0x16301C0 VA: 0x181631BC0
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x1632C50 Offset: 0x1631250 VA: 0x181632C50 Slot: 20
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1633390 Offset: 0x1631990 VA: 0x181633390 Slot: 21
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16317E0 Offset: 0x162FDE0 VA: 0x1816317E0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1632030 Offset: 0x1630630 VA: 0x181632030 Slot: 22
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1631E10 Offset: 0x1630410 VA: 0x181631E10
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x16336A0 Offset: 0x1631CA0 VA: 0x1816336A0
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1633890 Offset: 0x1631E90 VA: 0x181633890
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1632F20 Offset: 0x1631520 VA: 0x181632F20 Slot: 23
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1633970 Offset: 0x1631F70 VA: 0x181633970
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1633A10 Offset: 0x1632010 VA: 0x181633A10 Slot: 24
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x16319D0 Offset: 0x162FFD0 VA: 0x1816319D0
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count);

	// RVA: 0x16335F0 Offset: 0x1631BF0 VA: 0x1816335F0 Slot: 28
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x1633C60 Offset: 0x1632260 VA: 0x181633C60 Slot: 30
	public virtual void WriteByte(byte value) { }

	// RVA: 0x1632060 Offset: 0x1630660 VA: 0x181632060
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1632240 Offset: 0x1630840 VA: 0x181632240
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1632150 Offset: 0x1630750 VA: 0x181632150
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x16322D0 Offset: 0x16308D0 VA: 0x1816322D0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1633D00 Offset: 0x1632300 VA: 0x181633D00
	private static void .cctor() { }

}

private struct Stream.ReadWriteParameters // TypeDefIndex: 639
{	// Fields
	internal byte[] Buffer; // 0x0
	internal int Offset; // 0x8
	internal int Count; // 0xC

}

private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 640
{	// Fields
	internal readonly bool _isRead; // 0x58
	internal Stream _stream; // 0x60
	internal byte[] _buffer; // 0x68
	internal int _offset; // 0x70
	internal int _count; // 0x74
	private AsyncCallback _callback; // 0x78
	private ExecutionContext _context; // 0x80
	private static ContextCallback s_invokeAsyncCallback; // 0x0

	// Methods

	// RVA: 0x162E5B0 Offset: 0x162CBB0 VA: 0x18162E5B0
	internal void ClearBeginState() { }

	// RVA: 0x162E800 Offset: 0x162CE00 VA: 0x18162E800
	public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x162E5F0 Offset: 0x162CBF0 VA: 0x18162E5F0
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x162E680 Offset: 0x162CC80 VA: 0x18162E680 Slot: 20
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

}

private sealed class Stream.NullStream : Stream // TypeDefIndex: 641
{	// Fields
	private static Task<int> s_nullReadTask; // 0x2B11240

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x16294A0 Offset: 0x1627AA0 VA: 0x1816294A0
	internal void .ctor() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public override long get_Length() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	public override long get_Position() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1629060 Offset: 0x1627660 VA: 0x181629060 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1629140 Offset: 0x1627740 VA: 0x181629140 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16290D0 Offset: 0x16276D0 VA: 0x1816290D0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1629240 Offset: 0x1627840 VA: 0x181629240 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1629340 Offset: 0x1627940 VA: 0x181629340 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x1629410 Offset: 0x1627A10 VA: 0x181629410 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 26
	public override void SetLength(long length) { }

}

internal sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 642
{	// Fields
	private readonly object _stateObject; // 0x10
	private readonly bool _isWrite; // 0x18
	private ManualResetEvent _waitHandle; // 0x20
	private ExceptionDispatchInfo _exceptionInfo; // 0x28
	private bool _endXxxCalled; // 0x30
	private int _bytesRead; // 0x34

	// Properties
	public bool IsCompleted { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }

	// Methods

	// RVA: 0x1635010 Offset: 0x1633610 VA: 0x181635010
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x1635050 Offset: 0x1633650 VA: 0x181635050
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x1634FA0 Offset: 0x16335A0 VA: 0x181634FA0
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1635090 Offset: 0x1633690 VA: 0x181635090 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1634F80 Offset: 0x1633580 VA: 0x181634F80
	internal void ThrowIfError() { }

	// RVA: 0x1632240 Offset: 0x1630840 VA: 0x181632240
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16322D0 Offset: 0x16308D0 VA: 0x1816322D0
	internal static void EndWrite(IAsyncResult asyncResult) { }

}

private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 643
{	// Fields
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; // 0x0
	public static Func<ManualResetEvent> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x1637860 Offset: 0x1635E60 VA: 0x181637860
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x16376F0 Offset: 0x1635CF0 VA: 0x1816376F0
	internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }

}

private sealed class Stream.<>c // TypeDefIndex: 644
{	// Fields
	public static readonly Stream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__4_0; // 0x8
	public static Func<object, int> <>9__39_0; // 0x10
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__43_0; // 0x18
	public static Func<Stream, IAsyncResult, int> <>9__43_1; // 0x20
	public static Func<object, int> <>9__46_0; // 0x28
	public static Action<Task, object> <>9__47_0; // 0x30
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__53_0; // 0x38
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__53_1; // 0x40

	// Methods

	// RVA: 0x1637800 Offset: 0x1635E00 VA: 0x181637800
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1636FE0 Offset: 0x16355E0 VA: 0x181636FE0
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x1636D90 Offset: 0x1635390 VA: 0x181636D90
	internal int <BeginReadInternal>b__39_0(object <p0>) { }

	// RVA: 0x1636C40 Offset: 0x1635240 VA: 0x181636C40
	internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1636CB0 Offset: 0x16352B0 VA: 0x181636CB0
	internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x1636EC0 Offset: 0x16354C0 VA: 0x181636EC0
	internal int <BeginWriteInternal>b__46_0(object <p0>) { }

	// RVA: 0x1637030 Offset: 0x1635630 VA: 0x181637030
	internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	// RVA: 0x1636CE0 Offset: 0x16352E0 VA: 0x181636CE0
	internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1636D50 Offset: 0x1635350 VA: 0x181636D50
	internal VoidTaskResult <BeginEndWriteAsync>b__53_1(Stream stream, IAsyncResult asyncResult) { }

}

private struct Stream.<CopyToAsyncInternal>d__27 : IAsyncStateMachine // TypeDefIndex: 645
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int bufferSize; // 0x20
	public Stream destination; // 0x28
	private byte[] <buffer>5__1; // 0x30
	private int <bytesRead>5__2; // 0x38
	public CancellationToken cancellationToken; // 0x40
	public Stream <>4__this; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x60

	// Methods

	// RVA: 0x1F6620 Offset: 0x1F5A20 VA: 0x1801F6620 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF21F0 Offset: 0xF15F0 VA: 0x1800F21F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

