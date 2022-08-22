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

	// RVA: 0x16207B0 Offset: 0x161EDB0 VA: 0x1816207B0
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

	// RVA: 0x1621380 Offset: 0x161F980 VA: 0x181621380 Slot: 13
	public virtual int get_ReadTimeout() { }

	// RVA: 0x16213F0 Offset: 0x161F9F0 VA: 0x1816213F0 Slot: 14
	public virtual int get_WriteTimeout() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x161FF00 Offset: 0x161E500 VA: 0x18161FF00
	public Task CopyToAsync(Stream destination) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x161FE70 Offset: 0x161E470 VA: 0x18161FE70
	public Task CopyToAsync(Stream destination, int bufferSize) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x161FAF0 Offset: 0x161E0F0 VA: 0x18161FAF0 Slot: 15
	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3CA0 Offset: 0xA30A0 VA: 0x1800A3CA0
	// RVA: 0x161F9B0 Offset: 0x161DFB0 VA: 0x18161F9B0
	private Task CopyToAsyncInternal(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	// RVA: 0x161FF80 Offset: 0x161E580 VA: 0x18161FF80
	public void CopyTo(Stream destination) { }

	// RVA: 0x16208B0 Offset: 0x161EEB0 VA: 0x1816208B0
	private void InternalCopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x161F940 Offset: 0x161DF40 VA: 0x18161F940 Slot: 16
	public virtual void Close() { }

	// RVA: 0x15D2AC0 Offset: 0x15D10C0 VA: 0x1815D2AC0 Slot: 6
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Flush();

	// RVA: 0x161F3C0 Offset: 0x161D9C0 VA: 0x18161F3C0 Slot: 19
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x161F1A0 Offset: 0x161D7A0 VA: 0x18161F1A0
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x1620230 Offset: 0x161E830 VA: 0x181620230 Slot: 20
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1620970 Offset: 0x161EF70 VA: 0x181620970 Slot: 21
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x161EDC0 Offset: 0x161D3C0 VA: 0x18161EDC0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x161F610 Offset: 0x161DC10 VA: 0x18161F610 Slot: 22
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x161F3F0 Offset: 0x161D9F0 VA: 0x18161F3F0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x1620C80 Offset: 0x161F280 VA: 0x181620C80
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1620E70 Offset: 0x161F470 VA: 0x181620E70
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1620500 Offset: 0x161EB00 VA: 0x181620500 Slot: 23
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1620F50 Offset: 0x161F550 VA: 0x181620F50
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1620FF0 Offset: 0x161F5F0 VA: 0x181620FF0 Slot: 24
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x161EFB0 Offset: 0x161D5B0 VA: 0x18161EFB0
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count);

	// RVA: 0x1620BD0 Offset: 0x161F1D0 VA: 0x181620BD0 Slot: 28
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x1621240 Offset: 0x161F840 VA: 0x181621240 Slot: 30
	public virtual void WriteByte(byte value) { }

	// RVA: 0x161F640 Offset: 0x161DC40 VA: 0x18161F640
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x161F820 Offset: 0x161DE20 VA: 0x18161F820
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x161F730 Offset: 0x161DD30 VA: 0x18161F730
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x161F8B0 Offset: 0x161DEB0 VA: 0x18161F8B0
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x16212E0 Offset: 0x161F8E0 VA: 0x1816212E0
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

	// RVA: 0x161BB90 Offset: 0x161A190 VA: 0x18161BB90
	internal void ClearBeginState() { }

	// RVA: 0x161BDE0 Offset: 0x161A3E0 VA: 0x18161BDE0
	public void .ctor(bool isRead, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x161BBD0 Offset: 0x161A1D0 VA: 0x18161BBD0
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x161BC60 Offset: 0x161A260 VA: 0x18161BC60 Slot: 20
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

}

private sealed class Stream.NullStream : Stream // TypeDefIndex: 641
{	// Fields
	private static Task<int> s_nullReadTask; // 0x13BB3

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1616A80 Offset: 0x1615080 VA: 0x181616A80
	internal void .ctor() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x1616640 Offset: 0x1614C40 VA: 0x181616640 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1616720 Offset: 0x1614D20 VA: 0x181616720 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x16166B0 Offset: 0x1614CB0 VA: 0x1816166B0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1616820 Offset: 0x1614E20 VA: 0x181616820 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1616920 Offset: 0x1614F20 VA: 0x181616920 Slot: 21
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x16169F0 Offset: 0x1614FF0 VA: 0x1816169F0 Slot: 24
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 25
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

	// RVA: 0x16225F0 Offset: 0x1620BF0 VA: 0x1816225F0
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x1622630 Offset: 0x1620C30 VA: 0x181622630
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x1622580 Offset: 0x1620B80 VA: 0x181622580
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1622670 Offset: 0x1620C70 VA: 0x181622670 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1622560 Offset: 0x1620B60 VA: 0x181622560
	internal void ThrowIfError() { }

	// RVA: 0x161F820 Offset: 0x161DE20 VA: 0x18161F820
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x161F8B0 Offset: 0x161DEB0 VA: 0x18161F8B0
	internal static void EndWrite(IAsyncResult asyncResult) { }

}

private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 643
{	// Fields
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; // 0x0
	public static Func<ManualResetEvent> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x1624E40 Offset: 0x1623440 VA: 0x181624E40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1624CD0 Offset: 0x16232D0 VA: 0x181624CD0
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

	// RVA: 0x1624DE0 Offset: 0x16233E0 VA: 0x181624DE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x16245C0 Offset: 0x1622BC0 VA: 0x1816245C0
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x1624370 Offset: 0x1622970 VA: 0x181624370
	internal int <BeginReadInternal>b__39_0(object <p0>) { }

	// RVA: 0x1624220 Offset: 0x1622820 VA: 0x181624220
	internal IAsyncResult <BeginEndReadAsync>b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1624290 Offset: 0x1622890 VA: 0x181624290
	internal int <BeginEndReadAsync>b__43_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x16244A0 Offset: 0x1622AA0 VA: 0x1816244A0
	internal int <BeginWriteInternal>b__46_0(object <p0>) { }

	// RVA: 0x1624610 Offset: 0x1622C10 VA: 0x181624610
	internal void <RunReadWriteTaskWhenReady>b__47_0(Task t, object state) { }

	// RVA: 0x16242C0 Offset: 0x16228C0 VA: 0x1816242C0
	internal IAsyncResult <BeginEndWriteAsync>b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1624330 Offset: 0x1622930 VA: 0x181624330
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

	// RVA: 0x1F53F0 Offset: 0x1F47F0 VA: 0x1801F53F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

