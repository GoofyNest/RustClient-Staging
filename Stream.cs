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
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual int ReadTimeout { get; }
	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	public virtual int WriteTimeout { get; }

	// Methods

	// RVA: 0x1633490 Offset: 0x1631A90 VA: 0x181633490
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

	// RVA: 0x1634060 Offset: 0x1632660 VA: 0x181634060 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x16340D0 Offset: 0x16326D0 VA: 0x1816340D0 Slot: 14
	public virtual int get_WriteTimeout() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1632BE0 Offset: 0x16311E0 VA: 0x181632BE0
	public Task CopyToAsync(Stream destination) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1632B50 Offset: 0x1631150 VA: 0x181632B50
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16327D0 Offset: 0x1630DD0 VA: 0x1816327D0 Slot: 15
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3CA0 Offset: 0xA30A0 VA: 0x1800A3CA0
	// RVA: 0x1632690 Offset: 0x1630C90 VA: 0x181632690
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x1632C60 Offset: 0x1631260 VA: 0x181632C60
	public void CopyTo(Stream destination) { }

	// RVA: 0x1633590 Offset: 0x1631B90 VA: 0x181633590
	private void InternalCopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1632620 Offset: 0x1630C20 VA: 0x181632620 Slot: 16
	public virtual void Close() { }

	// RVA: 0x15D39F0 Offset: 0x15D1FF0 VA: 0x1815D39F0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Flush();

	// RVA: 0x16320A0 Offset: 0x16306A0 VA: 0x1816320A0 Slot: 19
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1631E80 Offset: 0x1630480 VA: 0x181631E80
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x1632F10 Offset: 0x1631510 VA: 0x181632F10 Slot: 20
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1633650 Offset: 0x1631C50 VA: 0x181633650 Slot: 21
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1631AA0 Offset: 0x16300A0 VA: 0x181631AA0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x16322F0 Offset: 0x16308F0 VA: 0x1816322F0 Slot: 22
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x16320D0 Offset: 0x16306D0 VA: 0x1816320D0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x1633960 Offset: 0x1631F60 VA: 0x181633960
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1633B50 Offset: 0x1632150 VA: 0x181633B50
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x16331E0 Offset: 0x16317E0 VA: 0x1816331E0 Slot: 23
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1633C30 Offset: 0x1632230 VA: 0x181633C30
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1633CD0 Offset: 0x16322D0 VA: 0x181633CD0 Slot: 24
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1631C90 Offset: 0x1630290 VA: 0x181631C90
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count);

	// RVA: 0x16338B0 Offset: 0x1631EB0 VA: 0x1816338B0 Slot: 28
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x1633F20 Offset: 0x1632520 VA: 0x181633F20 Slot: 30
	public virtual void WriteByte(byte value) { }

	// RVA: 0x1632320 Offset: 0x1630920 VA: 0x181632320
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1632500 Offset: 0x1630B00 VA: 0x181632500
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1632410 Offset: 0x1630A10 VA: 0x181632410
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1632590 Offset: 0x1630B90 VA: 0x181632590
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x1633FC0 Offset: 0x16325C0 VA: 0x181633FC0
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

	// RVA: 0x162E870 Offset: 0x162CE70 VA: 0x18162E870
	internal void ClearBeginState() { }

	// RVA: 0x162EAC0 Offset: 0x162D0C0 VA: 0x18162EAC0
	public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x162E8B0 Offset: 0x162CEB0 VA: 0x18162E8B0
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x162E940 Offset: 0x162CF40 VA: 0x18162E940 Slot: 20
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

}

private sealed class Stream.NullStream : Stream // TypeDefIndex: 641
{	// Fields
	private static Task<int> s_nullReadTask; // 0x2B112A0

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1629760 Offset: 0x1627D60 VA: 0x181629760
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

	// RVA: 0x1629320 Offset: 0x1627920 VA: 0x181629320 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1629400 Offset: 0x1627A00 VA: 0x181629400 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1629390 Offset: 0x1627990 VA: 0x181629390 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1629500 Offset: 0x1627B00 VA: 0x181629500 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1629600 Offset: 0x1627C00 VA: 0x181629600 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16296D0 Offset: 0x1627CD0 VA: 0x1816296D0 Slot: 24
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

	// RVA: 0x16352D0 Offset: 0x16338D0 VA: 0x1816352D0
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x1635310 Offset: 0x1633910 VA: 0x181635310
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x1635260 Offset: 0x1633860 VA: 0x181635260
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1635350 Offset: 0x1633950 VA: 0x181635350 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1635240 Offset: 0x1633840 VA: 0x181635240
	internal void ThrowIfError() { }

	// RVA: 0x1632500 Offset: 0x1630B00 VA: 0x181632500
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1632590 Offset: 0x1630B90 VA: 0x181632590
	internal static void EndWrite(IAsyncResult asyncResult) { }

}

private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 643
{	// Fields
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; // 0x0
	public static Func<ManualResetEvent> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x1637B20 Offset: 0x1636120 VA: 0x181637B20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x16379B0 Offset: 0x1635FB0 VA: 0x1816379B0
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

	// RVA: 0x1637AC0 Offset: 0x16360C0 VA: 0x181637AC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x16372A0 Offset: 0x16358A0 VA: 0x1816372A0
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x1637050 Offset: 0x1635650 VA: 0x181637050
	internal int <BeginReadInternal>b__39_0(object <p0>) { }

	// RVA: 0x1636F00 Offset: 0x1635500 VA: 0x181636F00
	internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1636F70 Offset: 0x1635570 VA: 0x181636F70
	internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x1637180 Offset: 0x1635780 VA: 0x181637180
	internal int <BeginWriteInternal>b__46_0(object <p0>) { }

	// RVA: 0x16372F0 Offset: 0x16358F0 VA: 0x1816372F0
	internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	// RVA: 0x1636FA0 Offset: 0x16355A0 VA: 0x181636FA0
	internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1637010 Offset: 0x1635610 VA: 0x181637010
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

	// RVA: 0x1F65A0 Offset: 0x1F59A0 VA: 0x1801F65A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

