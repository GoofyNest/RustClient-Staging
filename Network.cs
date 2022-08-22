internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 815
{	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x14973A0 Offset: 0x14959A0 VA: 0x1814973A0
	private static void .cctor() { }

	// RVA: 0x1497420 Offset: 0x1495A20 VA: 0x181497420
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x1497240 Offset: 0x1495840 VA: 0x181497240 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1497330 Offset: 0x1495930 VA: 0x181497330
	private static void WaitCallback_Context(object state) { }

}

public class ProxyAttribute : Attribute // TypeDefIndex: 1159
{	// Methods

	// RVA: 0x1481D50 Offset: 0x1480350 VA: 0x181481D50 Slot: 7
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x1481E60 Offset: 0x1480460 VA: 0x181481E60 Slot: 8
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

}

public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1413
{	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x1467130 Offset: 0x1465730 VA: 0x181467130
	public void .ctor() { }

	// RVA: 0x1466D70 Offset: 0x1465370 VA: 0x181466D70
	public void .ctor(int capacity) { }

	// RVA: 0x1466F70 Offset: 0x1465570 VA: 0x181466F70
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x1466D80 Offset: 0x1465380 VA: 0x181466D80
	public void .ctor(ICollection col) { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1466470 Offset: 0x1464A70 VA: 0x181466470 Slot: 10
	public virtual object Clone() { }

	// RVA: 0x1467150 Offset: 0x1465750 VA: 0x181467150 Slot: 11
	public virtual object get_SyncRoot() { }

	// RVA: 0x1466410 Offset: 0x1464A10 VA: 0x181466410 Slot: 12
	public virtual void Clear() { }

	// RVA: 0x1466560 Offset: 0x1464B60 VA: 0x181466560 Slot: 13
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1466860 Offset: 0x1464E60 VA: 0x181466860 Slot: 14
	public virtual void Enqueue(object obj) { }

	// RVA: 0x1466A60 Offset: 0x1465060 VA: 0x181466A60 Slot: 15
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1466760 Offset: 0x1464D60 VA: 0x181466760 Slot: 16
	public virtual object Dequeue() { }

	// RVA: 0x1466B10 Offset: 0x1465110 VA: 0x181466B10 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x1466A20 Offset: 0x1465020 VA: 0x181466A20
	internal object GetElement(int i) { }

	// RVA: 0x1466CB0 Offset: 0x14652B0 VA: 0x181466CB0 Slot: 18
	public virtual object[] ToArray() { }

	// RVA: 0x1466BD0 Offset: 0x14651D0 VA: 0x181466BD0
	private void SetCapacity(int capacity) { }

}

private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1414
{	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x14662C0 Offset: 0x14648C0 VA: 0x1814662C0
	internal void .ctor(Queue q) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 7
	public object Clone() { }

	// RVA: 0x1466100 Offset: 0x1464700 VA: 0x181466100 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1466340 Offset: 0x1464940 VA: 0x181466340 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1466210 Offset: 0x1464810 VA: 0x181466210 Slot: 10
	public virtual void Reset() { }

}

public class NetworkCredential : ICredentials // TypeDefIndex: 2893
{	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x1347580 Offset: 0x1345B80 VA: 0x181347580
	public void .ctor(string userName, string password) { }

	// RVA: 0x1347680 Offset: 0x1345C80 VA: 0x181347680
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_UserName() { }

	// RVA: 0x13477F0 Offset: 0x1345DF0 VA: 0x1813477F0
	public void set_UserName(string value) { }

	// RVA: 0x1347570 Offset: 0x1345B70 VA: 0x181347570
	public string get_Password() { }

	// RVA: 0x13477C0 Offset: 0x1345DC0 VA: 0x1813477C0
	public void set_Password(string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Domain() { }

	// RVA: 0x1347760 Offset: 0x1345D60 VA: 0x181347760
	public void set_Domain(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string InternalGetUserName() { }

	// RVA: 0x1347570 Offset: 0x1345B70 VA: 0x181347570
	internal string InternalGetPassword() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal string InternalGetDomain() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

internal class NetRes // TypeDefIndex: 2921
{	// Methods

	// RVA: 0x13474C0 Offset: 0x1345AC0 VA: 0x1813474C0
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1347460 Offset: 0x1345A60 VA: 0x181347460
	public static string GetWebStatusString(WebExceptionStatus Status) { }

}

public class NetworkStream : Stream // TypeDefIndex: 3044
{
// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 3044
	// Fields
	private Socket m_StreamSocket; // 0x28
	private bool m_Readable; // 0x30
	private bool m_Writeable; // 0x31
	private bool m_OwnsSocket; // 0x32
	private int m_CloseTimeout; // 0x34
	private bool m_CleanedUp; // 0x38
	private int m_CurrentReadTimeout; // 0x3C
	private int m_CurrentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xFFBF50 Offset: 0xFFA550 VA: 0x180FFBF50
	public void .ctor(Socket socket) { }

	// RVA: 0xFFBE80 Offset: 0xFFA480 VA: 0x180FFBE80
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xFFC010 Offset: 0xFFA610 VA: 0x180FFC010 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xFFC100 Offset: 0xFFA700 VA: 0x180FFC100 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0xFFC190 Offset: 0xFFA790 VA: 0x180FFC190 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0xFFC020 Offset: 0xFFA620 VA: 0x180FFC020 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFFC090 Offset: 0xFFA690 VA: 0x180FFC090 Slot: 11
	public override long get_Position() { }

	// RVA: 0xFFC220 Offset: 0xFFA820 VA: 0x180FFC220 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xFFB9F0 Offset: 0xFF9FF0 VA: 0x180FFB9F0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xFFB4D0 Offset: 0xFF9AD0 VA: 0x180FFB4D0
	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0xFFB640 Offset: 0xFF9C40 VA: 0x180FFB640 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	// RVA: 0xFFBAD0 Offset: 0xFFA0D0 VA: 0x180FFBAD0 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFFADF0 Offset: 0xFF93F0 VA: 0x180FFADF0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFFB430 Offset: 0xFF9A30 VA: 0x180FFB430 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xFFA670 Offset: 0xFF8C70 VA: 0x180FFA670 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFFAED0 Offset: 0xFF94D0 VA: 0x180FFAED0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFFAA30 Offset: 0xFF9030 VA: 0x180FFAA30 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFFB180 Offset: 0xFF9780 VA: 0x180FFB180 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0xFFBA60 Offset: 0xFFA060 VA: 0x180FFBA60 Slot: 26
	public override void SetLength(long value) { }

}

public class NetworkInformationException : Win32Exception // TypeDefIndex: 3074
{	// Methods

	// RVA: 0x1347850 Offset: 0x1345E50 VA: 0x181347850
	public void .ctor() { }

	// RVA: 0x13478E0 Offset: 0x1345EE0 VA: 0x1813478E0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

public enum NetworkInterfaceComponent // TypeDefIndex: 3075
{	// Fields
	public int value__; // 0x0
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;

}

public enum NetBiosNodeType // TypeDefIndex: 3076
{	// Fields
	public int value__; // 0x0
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;

}

public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 3118
{	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	// Properties
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1946030 Offset: 0x1944630 VA: 0x181946030
	|-Queue<BaseEntity>..ctor
	|-Queue<DeferredAction>..ctor
	|-Queue<RCon.Command>..ctor
	|-Queue<QueuedStream.WriteData>..ctor
	|-Queue<CFNetwork.GetProxyData>..ctor
	|-Queue<OccludeeState>..ctor
	|-Queue<OcclusionCulling.Cell>..ctor
	|-Queue<int>..ctor
	|-Queue<IntPtr>..ctor
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<ulong>..ctor
	|-Queue<WeakReference>..ctor
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|-Queue<Transform>..ctor
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1946170 Offset: 0x1944770 VA: 0x181946170
	|-Queue<RCon.Command>..ctor
	|
	|-RVA: 0x1946260 Offset: 0x1944860 VA: 0x181946260
	|-Queue<int>..ctor
	|
	|-RVA: 0x1946530 Offset: 0x1944B30 VA: 0x181946530
	|-Queue<IntPtr>..ctor
	|
	|-RVA: 0x1946620 Offset: 0x1944C20 VA: 0x181946620
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<Renderer>..ctor
	|
	|-RVA: 0x1946440 Offset: 0x1944A40 VA: 0x181946440
	|-Queue<ulong>..ctor
	|
	|-RVA: 0x1946080 Offset: 0x1944680 VA: 0x181946080
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|
	|-RVA: 0x1946350 Offset: 0x1944950 VA: 0x181946350
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	|-Queue<BaseEntity>.get_Count
	|-Queue<DeferredAction>.get_Count
	|-Queue<RCon.Command>.get_Count
	|-Queue<QueuedStream.WriteData>.get_Count
	|-Queue<CFNetwork.GetProxyData>.get_Count
	|-Queue<OccludeeState>.get_Count
	|-Queue<OcclusionCulling.Cell>.get_Count
	|-Queue<int>.get_Count
	|-Queue<IntPtr>.get_Count
	|-Queue<object>.get_Count
	|-Queue<string>.get_Count
	|-Queue<ulong>.get_Count
	|-Queue<WeakReference>.get_Count
	|-Queue<Renderer>.get_Count
	|-Queue<AsyncGPUReadbackRequest>.get_Count
	|-Queue<Transform>.get_Count
	|-Queue<EventDispatcher.EventRecord>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1945C40 Offset: 0x1944240 VA: 0x181945C40
	|-Queue<RCon.Command>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1945B60 Offset: 0x1944160 VA: 0x181945B60
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1945BD0 Offset: 0x19441D0 VA: 0x181945BD0
	|-Queue<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1945D20 Offset: 0x1944320 VA: 0x181945D20
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1945CB0 Offset: 0x19442B0 VA: 0x181945CB0
	|-Queue<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1945A80 Offset: 0x1944080 VA: 0x181945A80
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1945AF0 Offset: 0x19440F0 VA: 0x181945AF0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19437D0 Offset: 0x1941DD0 VA: 0x1819437D0
	|-Queue<BaseEntity>.Clear
	|-Queue<RCon.Command>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|
	|-RVA: 0x19437B0 Offset: 0x1941DB0 VA: 0x1819437B0
	|-Queue<int>.Clear
	|-Queue<IntPtr>.Clear
	|-Queue<ulong>.Clear
	|-Queue<AsyncGPUReadbackRequest>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1945560 Offset: 0x1943B60 VA: 0x181945560
	|-Queue<RCon.Command>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19452D0 Offset: 0x19438D0 VA: 0x1819452D0
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1944B20 Offset: 0x1943120 VA: 0x181944B20
	|-Queue<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1944890 Offset: 0x1942E90 VA: 0x181944890
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1945040 Offset: 0x1943640 VA: 0x181945040
	|-Queue<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19457F0 Offset: 0x1943DF0 VA: 0x1819457F0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1944DB0 Offset: 0x19433B0 VA: 0x181944DB0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1943DA0 Offset: 0x19423A0 VA: 0x181943DA0
	|-Queue<BaseEntity>.Enqueue
	|-Queue<DeferredAction>.Enqueue
	|-Queue<QueuedStream.WriteData>.Enqueue
	|-Queue<CFNetwork.GetProxyData>.Enqueue
	|-Queue<OccludeeState>.Enqueue
	|-Queue<OcclusionCulling.Cell>.Enqueue
	|-Queue<object>.Enqueue
	|-Queue<string>.Enqueue
	|-Queue<WeakReference>.Enqueue
	|-Queue<Renderer>.Enqueue
	|-Queue<Transform>.Enqueue
	|
	|-RVA: 0x1943FF0 Offset: 0x19425F0 VA: 0x181943FF0
	|-Queue<RCon.Command>.Enqueue
	|
	|-RVA: 0x19440E0 Offset: 0x19426E0 VA: 0x1819440E0
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x1943E70 Offset: 0x1942470 VA: 0x181943E70
	|-Queue<IntPtr>.Enqueue
	|-Queue<ulong>.Enqueue
	|
	|-RVA: 0x1943CE0 Offset: 0x19422E0 VA: 0x181943CE0
	|-Queue<AsyncGPUReadbackRequest>.Enqueue
	|
	|-RVA: 0x1943F20 Offset: 0x1942520 VA: 0x181943F20
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1944190 Offset: 0x1942790 VA: 0x181944190
	|-Queue<string>.GetEnumerator
	|-Queue<IntPtr>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|-Queue<ulong>.GetEnumerator
	|
	|-RVA: 0x1944240 Offset: 0x1942840 VA: 0x181944240
	|-Queue<RCon.Command>.GetEnumerator
	|
	|-RVA: 0x19442B0 Offset: 0x19428B0 VA: 0x1819442B0
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x19441E0 Offset: 0x19427E0 VA: 0x1819441E0
	|-Queue<AsyncGPUReadbackRequest>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19447C0 Offset: 0x1942DC0 VA: 0x1819447C0
	|-Queue<RCon.Command>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1944720 Offset: 0x1942D20 VA: 0x181944720
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1944680 Offset: 0x1942C80 VA: 0x181944680
	|-Queue<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x19445E0 Offset: 0x1942BE0 VA: 0x1819445E0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19447C0 Offset: 0x1942DC0 VA: 0x1819447C0
	|-Queue<RCon.Command>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1944720 Offset: 0x1942D20 VA: 0x181944720
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1944680 Offset: 0x1942C80 VA: 0x181944680
	|-Queue<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x19445E0 Offset: 0x1942BE0 VA: 0x1819445E0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1943910 Offset: 0x1941F10 VA: 0x181943910
	|-Queue<BaseEntity>.Dequeue
	|-Queue<DeferredAction>.Dequeue
	|-Queue<QueuedStream.WriteData>.Dequeue
	|-Queue<OccludeeState>.Dequeue
	|-Queue<OcclusionCulling.Cell>.Dequeue
	|-Queue<string>.Dequeue
	|-Queue<WeakReference>.Dequeue
	|-Queue<Renderer>.Dequeue
	|-Queue<Transform>.Dequeue
	|-Queue<CFNetwork.GetProxyData>.Dequeue
	|-Queue<object>.Dequeue
	|
	|-RVA: 0x1943A70 Offset: 0x1942070 VA: 0x181943A70
	|-Queue<RCon.Command>.Dequeue
	|
	|-RVA: 0x1943BA0 Offset: 0x19421A0 VA: 0x181943BA0
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x19439D0 Offset: 0x1941FD0 VA: 0x1819439D0
	|-Queue<IntPtr>.Dequeue
	|-Queue<ulong>.Dequeue
	|
	|-RVA: 0x1943C30 Offset: 0x1942230 VA: 0x181943C30
	|-Queue<AsyncGPUReadbackRequest>.Dequeue
	|
	|-RVA: 0x1943840 Offset: 0x1941E40 VA: 0x181943840
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1944410 Offset: 0x1942A10 VA: 0x181944410
	|-Queue<ulong>.Peek
	|-Queue<IntPtr>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x1944390 Offset: 0x1942990 VA: 0x181944390
	|-Queue<AsyncGPUReadbackRequest>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|
	|-RVA: 0x1944470 Offset: 0x1942A70 VA: 0x181944470
	|-Queue<RCon.Command>.Peek
	|
	|-RVA: 0x1944330 Offset: 0x1942930 VA: 0x181944330
	|-Queue<int>.Peek
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1944500 Offset: 0x1942B00 VA: 0x181944500
	|-Queue<RCon.Command>.SetCapacity
	|-Queue<int>.SetCapacity
	|-Queue<IntPtr>.SetCapacity
	|-Queue<object>.SetCapacity
	|-Queue<ulong>.SetCapacity
	|-Queue<AsyncGPUReadbackRequest>.SetCapacity
	|-Queue<EventDispatcher.EventRecord>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1944300 Offset: 0x1942900 VA: 0x181944300
	|-Queue<RCon.Command>.MoveNext
	|-Queue<int>.MoveNext
	|-Queue<IntPtr>.MoveNext
	|-Queue<object>.MoveNext
	|-Queue<ulong>.MoveNext
	|-Queue<AsyncGPUReadbackRequest>.MoveNext
	|-Queue<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1945DF0 Offset: 0x19443F0 VA: 0x181945DF0
	|-Queue<RCon.Command>.ThrowForEmptyQueue
	|
	|-RVA: 0x1945E50 Offset: 0x1944450 VA: 0x181945E50
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x1945D90 Offset: 0x1944390 VA: 0x181945D90
	|-Queue<IntPtr>.ThrowForEmptyQueue
	|
	|-RVA: 0x1945F10 Offset: 0x1944510 VA: 0x181945F10
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x1945F70 Offset: 0x1944570 VA: 0x181945F70
	|-Queue<ulong>.ThrowForEmptyQueue
	|
	|-RVA: 0x1945EB0 Offset: 0x19444B0 VA: 0x181945EB0
	|-Queue<AsyncGPUReadbackRequest>.ThrowForEmptyQueue
	|
	|-RVA: 0x1945FD0 Offset: 0x19445D0 VA: 0x181945FD0
	|-Queue<EventDispatcher.EventRecord>.ThrowForEmptyQueue
	*/

}

public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3119
{	// Fields
	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21BB80 Offset: 0x21AF80 VA: 0x18021BB80
	|-Queue.Enumerator<RCon.Command>..ctor
	|
	|-RVA: 0x21BCE0 Offset: 0x21B0E0 VA: 0x18021BCE0
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x21BC90 Offset: 0x21B090 VA: 0x18021BC90
	|-Queue.Enumerator<IntPtr>..ctor
	|-Queue.Enumerator<object>..ctor
	|-Queue.Enumerator<ulong>..ctor
	|
	|-RVA: 0x21BB30 Offset: 0x21AF30 VA: 0x18021BB30
	|-Queue.Enumerator<AsyncGPUReadbackRequest>..ctor
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A100 Offset: 0x219500 VA: 0x18021A100
	|-Queue.Enumerator<RCon.Command>.Dispose
	|
	|-RVA: 0x21A0F0 Offset: 0x2194F0 VA: 0x18021A0F0
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x21A080 Offset: 0x219480 VA: 0x18021A080
	|-Queue.Enumerator<IntPtr>.Dispose
	|-Queue.Enumerator<object>.Dispose
	|-Queue.Enumerator<string>.Dispose
	|-Queue.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x21A030 Offset: 0x219430 VA: 0x18021A030
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.Dispose
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21A420 Offset: 0x219820 VA: 0x18021A420
	|-Queue.Enumerator<RCon.Command>.MoveNext
	|
	|-RVA: 0x21A340 Offset: 0x219740 VA: 0x18021A340
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21A5E0 Offset: 0x2199E0 VA: 0x18021A5E0
	|-Queue.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x21A120 Offset: 0x219520 VA: 0x18021A120
	|-Queue.Enumerator<object>.MoveNext
	|-Queue.Enumerator<string>.MoveNext
	|
	|-RVA: 0x21A720 Offset: 0x219B20 VA: 0x18021A720
	|-Queue.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21A250 Offset: 0x219650 VA: 0x18021A250
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.MoveNext
	|
	|-RVA: 0x21A800 Offset: 0x219C00 VA: 0x18021A800
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21BD40 Offset: 0x21B140 VA: 0x18021BD40
	|-Queue.Enumerator<string>.get_Current
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x21BF30 Offset: 0x21B330 VA: 0x18021BF30
	|-Queue.Enumerator<RCon.Command>.get_Current
	|
	|-RVA: 0x21BE90 Offset: 0x21B290 VA: 0x18021BE90
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x21BDD0 Offset: 0x21B1D0 VA: 0x18021BDD0
	|-Queue.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x21BD80 Offset: 0x21B180 VA: 0x18021BD80
	|-Queue.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x21BE10 Offset: 0x21B210 VA: 0x18021BE10
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.get_Current
	|
	|-RVA: 0x21BE50 Offset: 0x21B250 VA: 0x18021BE50
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21BA20 Offset: 0x21AE20 VA: 0x18021BA20
	|-Queue.Enumerator<RCon.Command>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x21B9F0 Offset: 0x21ADF0 VA: 0x18021B9F0
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x21BA50 Offset: 0x21AE50 VA: 0x18021BA50
	|-Queue.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x21BA10 Offset: 0x21AE10 VA: 0x18021BA10
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x21BA40 Offset: 0x21AE40 VA: 0x18021BA40
	|-Queue.Enumerator<ulong>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x21BA30 Offset: 0x21AE30 VA: 0x18021BA30
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x21BA00 Offset: 0x21AE00 VA: 0x18021BA00
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21B920 Offset: 0x21AD20 VA: 0x18021B920
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21B5E0 Offset: 0x21A9E0 VA: 0x18021B5E0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21B7B0 Offset: 0x21ABB0 VA: 0x18021B7B0
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21B740 Offset: 0x21AB40 VA: 0x18021B740
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21B690 Offset: 0x21AA90 VA: 0x18021B690
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21B530 Offset: 0x21A930 VA: 0x18021B530
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21B870 Offset: 0x21AC70 VA: 0x18021B870
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AEC0 Offset: 0x21A2C0 VA: 0x18021AEC0
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21AFD0 Offset: 0x21A3D0 VA: 0x18021AFD0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21AF50 Offset: 0x21A350 VA: 0x18021AF50
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21B0D0 Offset: 0x21A4D0 VA: 0x18021B0D0
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21B290 Offset: 0x21A690 VA: 0x18021B290
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21B050 Offset: 0x21A450 VA: 0x18021B050
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21B1B0 Offset: 0x21A5B0 VA: 0x18021B1B0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	*/

}

public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
{
// Namespace: System.Net.Configuration
[ConfigurationCollectionAttribute] // RVA: 0xC10D0 Offset: 0xC04D0 VA: 0x1800C10D0
[DefaultMemberAttribute] // RVA: 0xC10D0 Offset: 0xC04D0 VA: 0x1800C10D0
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
	// Methods

	// RVA: 0x151FBE0 Offset: 0x151E1E0 VA: 0x18151FBE0
	public void .ctor() { }

}

public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 3171
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x151FC10 Offset: 0x151E210 VA: 0x18151FC10
	public void .ctor() { }

	// RVA: 0x151FC40 Offset: 0x151E240 VA: 0x18151FC40 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 3173
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1535DD0 Offset: 0x15343D0 VA: 0x181535DD0
	public void .ctor() { }

	// RVA: 0x1535E00 Offset: 0x1534400 VA: 0x181535E00 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 3176
{	// Methods

	// RVA: 0x1535C50 Offset: 0x1534250 VA: 0x181535C50
	public void .ctor() { }

}

public enum NetworkReachability // TypeDefIndex: 3358
{	// Fields
	public int value__; // 0x0
	public const NetworkReachability NotReachable = 0;
	public const NetworkReachability ReachableViaCarrierDataNetwork = 1;
	public const NetworkReachability ReachableViaLocalAreaNetwork = 2;

}

internal enum ConnectionChangeType // TypeDefIndex: 4143
{	// Fields
	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;

}

public enum ConnectionState // TypeDefIndex: 4173
{	// Fields
	public int value__; // 0x0
	public const ConnectionState Closed = 0;
	public const ConnectionState Open = 1;
	public const ConnectionState Connecting = 2;
	public const ConnectionState Executing = 4;
	public const ConnectionState Fetching = 8;
	public const ConnectionState Broken = 16;

}

public enum ConnectionState // TypeDefIndex: 5169
{	// Fields
	public int value__; // 0x0
	public const ConnectionState None = 0;
	public const ConnectionState Connecting = 1;
	public const ConnectionState FindingRoute = 2;
	public const ConnectionState Connected = 3;
	public const ConnectionState ClosedByPeer = 4;
	public const ConnectionState ProblemDetectedLocally = 5;
	public const ConnectionState FinWait = -1;
	public const ConnectionState Linger = -2;
	public const ConnectionState Dead = -3;

}

internal enum NetConfigScope // TypeDefIndex: 5170
{	// Fields
	public int value__; // 0x0
	public const NetConfigScope Global = 1;
	public const NetConfigScope SocketsInterface = 2;
	public const NetConfigScope ListenSocket = 3;
	public const NetConfigScope Connection = 4;

}

internal enum NetConfigType // TypeDefIndex: 5171
{	// Fields
	public int value__; // 0x0
	public const NetConfigType Int32 = 1;
	public const NetConfigType Int64 = 2;
	public const NetConfigType Float = 3;
	public const NetConfigType String = 4;
	public const NetConfigType Ptr = 5;

}

internal enum NetConfig // TypeDefIndex: 5172
{	// Fields
	public int value__; // 0x0
	public const NetConfig Invalid = 0;
	public const NetConfig TimeoutInitial = 24;
	public const NetConfig TimeoutConnected = 25;
	public const NetConfig SendBufferSize = 9;
	public const NetConfig ConnectionUserData = 40;
	public const NetConfig SendRateMin = 10;
	public const NetConfig SendRateMax = 11;
	public const NetConfig NagleTime = 12;
	public const NetConfig IP_AllowWithoutAuth = 23;
	public const NetConfig MTU_PacketSize = 32;
	public const NetConfig MTU_DataSize = 33;
	public const NetConfig Unencrypted = 34;
	public const NetConfig SymmetricConnect = 37;
	public const NetConfig LocalVirtualPort = 38;
	public const NetConfig DualWifi_Enable = 39;
	public const NetConfig EnableDiagnosticsUI = 46;
	public const NetConfig FakePacketLoss_Send = 2;
	public const NetConfig FakePacketLoss_Recv = 3;
	public const NetConfig FakePacketLag_Send = 4;
	public const NetConfig FakePacketLag_Recv = 5;
	public const NetConfig FakePacketReorder_Send = 6;
	public const NetConfig FakePacketReorder_Recv = 7;
	public const NetConfig FakePacketReorder_Time = 8;
	public const NetConfig FakePacketDup_Send = 26;
	public const NetConfig FakePacketDup_Recv = 27;
	public const NetConfig FakePacketDup_TimeMax = 28;
	public const NetConfig PacketTraceMaxBytes = 41;
	public const NetConfig FakeRateLimit_Send_Rate = 42;
	public const NetConfig FakeRateLimit_Send_Burst = 43;
	public const NetConfig FakeRateLimit_Recv_Rate = 44;
	public const NetConfig FakeRateLimit_Recv_Burst = 45;
	public const NetConfig Callback_ConnectionStatusChanged = 201;
	public const NetConfig Callback_AuthStatusChanged = 202;
	public const NetConfig Callback_RelayNetworkStatusChanged = 203;
	public const NetConfig Callback_MessagesSessionRequest = 204;
	public const NetConfig Callback_MessagesSessionFailed = 205;
	public const NetConfig Callback_CreateConnectionSignaling = 206;
	public const NetConfig Callback_FakeIPResult = 207;
	public const NetConfig P2P_STUN_ServerList = 103;
	public const NetConfig P2P_Transport_ICE_Enable = 104;
	public const NetConfig P2P_Transport_ICE_Penalty = 105;
	public const NetConfig P2P_Transport_SDR_Penalty = 106;
	public const NetConfig SDRClient_ConsecutitivePingTimeoutsFailInitial = 19;
	public const NetConfig SDRClient_ConsecutitivePingTimeoutsFail = 20;
	public const NetConfig SDRClient_MinPingsBeforePingAccurate = 21;
	public const NetConfig SDRClient_SingleSocket = 22;
	public const NetConfig SDRClient_ForceRelayCluster = 29;
	public const NetConfig SDRClient_DebugTicketAddress = 30;
	public const NetConfig SDRClient_ForceProxyAddr = 31;
	public const NetConfig SDRClient_FakeClusterPing = 36;
	public const NetConfig LogLevel_AckRTT = 13;
	public const NetConfig LogLevel_PacketDecode = 14;
	public const NetConfig LogLevel_Message = 15;
	public const NetConfig LogLevel_PacketGaps = 16;
	public const NetConfig LogLevel_P2PRendezvous = 17;
	public const NetConfig LogLevel_SDRRelayPings = 18;
	public const NetConfig DELETED_EnumerateDevVars = 35;

}

internal enum NetConfigResult // TypeDefIndex: 5173
{	// Fields
	public int value__; // 0x0
	public const NetConfigResult BadValue = -1;
	public const NetConfigResult BadScopeObj = -2;
	public const NetConfigResult BufferTooSmall = -3;
	public const NetConfigResult OK = 1;
	public const NetConfigResult OKInherited = 2;

}

public enum NetDebugOutput // TypeDefIndex: 5174
{	// Fields
	public int value__; // 0x0
	public const NetDebugOutput None = 0;
	public const NetDebugOutput Bug = 1;
	public const NetDebugOutput Error = 2;
	public const NetDebugOutput Important = 3;
	public const NetDebugOutput Warning = 4;
	public const NetDebugOutput Msg = 5;
	public const NetDebugOutput Verbose = 6;
	public const NetDebugOutput Debug = 7;
	public const NetDebugOutput Everything = 8;

}

public class ConnectionManager // TypeDefIndex: 5178
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IConnectionManager <Interface>k__BackingField; // 0x10
	public Connection Connection; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ConnectionInfo <ConnectionInfo>k__BackingField; // 0x20
	public bool Connected; // 0x2D8
	public bool Connecting; // 0x2D9

	// Properties
	public IConnectionManager Interface { get; set; }
	internal ConnectionInfo ConnectionInfo { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public IConnectionManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Interface(IConnectionManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x136E1A0 Offset: 0x136C7A0 VA: 0x18136E1A0
	internal void set_ConnectionInfo(ConnectionInfo value) { }

	// RVA: 0x136D800 Offset: 0x136BE00 VA: 0x18136D800
	public void Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x136E170 Offset: 0x136C770 VA: 0x18136E170 Slot: 3
	public override string ToString() { }

	// RVA: 0x136DA00 Offset: 0x136C000 VA: 0x18136DA00 Slot: 4
	public virtual void OnConnectionChanged(ConnectionInfo info) { }

	// RVA: 0x136D910 Offset: 0x136BF10 VA: 0x18136D910 Slot: 5
	public virtual void OnConnecting(ConnectionInfo info) { }

	// RVA: 0x136D820 Offset: 0x136BE20 VA: 0x18136D820 Slot: 6
	public virtual void OnConnected(ConnectionInfo info) { }

	// RVA: 0x136DCF0 Offset: 0x136C2F0 VA: 0x18136DCF0 Slot: 7
	public virtual void OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x136DFA0 Offset: 0x136C5A0 VA: 0x18136DFA0
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0x136DED0 Offset: 0x136C4D0 VA: 0x18136DED0
	internal void ReceiveMessage(ref NetMsg* msg) { }

	// RVA: 0x136DDE0 Offset: 0x136C3E0 VA: 0x18136DDE0 Slot: 8
	public virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x136E190 Offset: 0x136C790 VA: 0x18136E190
	public void .ctor() { }

}

internal sealed class NetDebugFunc : MulticastDelegate // TypeDefIndex: 5179
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE35D0 Offset: 0xDE1BD0 VA: 0x180DE35D0 Slot: 12
	public virtual void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg) { }

	// RVA: 0xDE3540 Offset: 0xDE1B40 VA: 0x180DE3540 Slot: 13
	public virtual IAsyncResult BeginInvoke([In] NetDebugOutput nType, [In] IntPtr pszMsg, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal struct NetKeyValue // TypeDefIndex: 5507
{	// Fields
	internal NetConfig Value; // 0x0
	internal NetConfigType DataType; // 0x4
	internal long Int64Value; // 0x8
	internal int Int32Value; // 0x8
	internal float FloatValue; // 0x8
	internal IntPtr PointerValue; // 0x8

}

public struct NetIdentity // TypeDefIndex: 5508
{	// Fields
	internal NetIdentity.IdentityType type; // 0x0
	internal int size; // 0x4
	internal ulong steamid; // 0x8
	internal NetAddress netaddress; // 0x8

	// Methods

	// RVA: 0x1EC3E0 Offset: 0x1EB7E0 VA: 0x1801EC3E0 Slot: 3
	public override string ToString() { }

}

internal enum NetIdentity.IdentityType // TypeDefIndex: 5509
{	// Fields
	public int value__; // 0x0
	public const NetIdentity.IdentityType Invalid = 0;
	public const NetIdentity.IdentityType IPAddress = 1;
	public const NetIdentity.IdentityType GenericString = 2;
	public const NetIdentity.IdentityType GenericBytes = 3;
	public const NetIdentity.IdentityType SteamID = 16;

}

public struct NetAddress // TypeDefIndex: 5510
{	// Fields
	internal NetAddress.IPV4 ip; // 0x0
	internal ushort port; // 0x10

	// Properties
	public static NetAddress Cleared { get; }

	// Methods

	// RVA: 0x13740B0 Offset: 0x13726B0 VA: 0x1813740B0
	internal static extern void InternalClear(ref NetAddress self) { }

	// RVA: 0x1374130 Offset: 0x1372730 VA: 0x181374130
	internal static extern void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort) { }

	// RVA: 0x13741D0 Offset: 0x13727D0 VA: 0x1813741D0
	internal static extern void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x1373C00 Offset: 0x1372200 VA: 0x181373C00
	public static NetAddress AnyIp(ushort port) { }

	// RVA: 0x1373CB0 Offset: 0x13722B0 VA: 0x181373CB0
	public static NetAddress From(string addrStr, ushort port) { }

	// RVA: 0x1373ED0 Offset: 0x13724D0 VA: 0x181373ED0
	public static NetAddress From(IPAddress address, ushort port) { }

	// RVA: 0x1374460 Offset: 0x1372A60 VA: 0x181374460
	public static NetAddress get_Cleared() { }

	// RVA: 0x1EC3D0 Offset: 0x1EB7D0 VA: 0x1801EC3D0 Slot: 3
	public override string ToString() { }

}

internal struct NetAddress.IPV4 // TypeDefIndex: 5511
{	// Fields
	internal ulong m_8zeros; // 0x0
	internal ushort m_0000; // 0x8
	internal ushort m_ffff; // 0xA
	internal byte ip0; // 0xC
	internal byte ip1; // 0xD
	internal byte ip2; // 0xE
	internal byte ip3; // 0xF

}

internal struct NetMsg // TypeDefIndex: 5512
{	// Fields
	internal IntPtr DataPtr; // 0x0
	internal int DataSize; // 0x8
	internal Connection Connection; // 0xC
	internal NetIdentity Identity; // 0x10
	internal long ConnectionUserData; // 0x98
	internal long RecvTime; // 0xA0
	internal long MessageNumber; // 0xA8
	internal IntPtr FreeDataPtr; // 0xB0
	internal IntPtr ReleasePtr; // 0xB8
	internal int Channel; // 0xC0
	internal SendType Flags; // 0xC4
	internal long UserData; // 0xC8
	internal ushort IdxLane; // 0xD0
	internal ushort _pad1__; // 0xD2

	// Methods

	// RVA: 0x13744F0 Offset: 0x1372AF0 VA: 0x1813744F0
	internal static extern void InternalRelease(NetMsg* self) { }

}

public struct Connection : IEquatable<Connection> // TypeDefIndex: 5543
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <Id>k__BackingField; // 0x0

	// Properties
	public uint Id { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public uint get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_Id(uint value) { }

	// RVA: 0x1E5480 Offset: 0x1E4880 VA: 0x1801E5480 Slot: 4
	public bool Equals(Connection other) { }

	// RVA: 0x1E5490 Offset: 0x1E4890 VA: 0x1801E5490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E5510 Offset: 0x1E4910 VA: 0x1801E5510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D37B0 Offset: 0x1D2BB0 VA: 0x1801D37B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static Connection op_Implicit(uint value) { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static uint op_Implicit(Connection value) { }

	// RVA: 0x1E52D0 Offset: 0x1E46D0 VA: 0x1801E52D0
	public Result Accept() { }

	// RVA: 0x1E5340 Offset: 0x1E4740 VA: 0x1801E5340
	public bool Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x1E55D0 Offset: 0x1E49D0 VA: 0x1801E55D0
	public Result SendMessage(IntPtr ptr, int size, SendType sendType = 8, ushort laneIndex = 0) { }

	// RVA: 0x1E53F0 Offset: 0x1E47F0 VA: 0x1801E53F0
	public string DetailedStatus() { }

	// RVA: 0x1E5530 Offset: 0x1E4930 VA: 0x1801E5530
	public ConnectionStatus QuickStatus() { }

	// RVA: 0x1E5350 Offset: 0x1E4750 VA: 0x1801E5350
	public Result ConfigureConnectionLanes(int[] lanePriorities, ushort[] laneWeights) { }

}

public struct ConnectionInfo // TypeDefIndex: 5544
{	// Fields
	internal NetIdentity identity; // 0x0
	internal long userData; // 0x88
	internal Socket listenSocket; // 0x90
	internal NetAddress address; // 0x94
	internal ushort pad; // 0xA6
	internal SteamNetworkingPOPID popRemote; // 0xA8
	internal SteamNetworkingPOPID popRelay; // 0xAC
	internal ConnectionState state; // 0xB0
	internal int endReason; // 0xB4
	internal string endDebug; // 0xB8
	internal string connectionDescription; // 0xC0

	// Properties
	public ConnectionState State { get; }
	public NetAddress Address { get; }

	// Methods

	// RVA: 0xFD3D0 Offset: 0xFC7D0 VA: 0x1800FD3D0
	public ConnectionState get_State() { }

	// RVA: 0x1E4BF0 Offset: 0x1E3FF0 VA: 0x1801E4BF0
	public NetAddress get_Address() { }

}

public struct ConnectionLaneStatus // TypeDefIndex: 5545
{	// Fields
	internal int cbPendingUnreliable; // 0x0
	internal int cbPendingReliable; // 0x4
	internal int cbSentUnackedReliable; // 0x8
	internal int _reservePad1; // 0xC
	internal long ecQueueTime; // 0x10
	internal uint[] reserved; // 0x18

}

public struct ConnectionStatus // TypeDefIndex: 5546
{	// Fields
	internal ConnectionState state; // 0x0
	internal int ping; // 0x4
	internal float connectionQualityLocal; // 0x8
	internal float connectionQualityRemote; // 0xC
	internal float outPacketsPerSec; // 0x10
	internal float outBytesPerSec; // 0x14
	internal float inPacketsPerSec; // 0x18
	internal float inBytesPerSec; // 0x1C
	internal int sendRateBytesPerSecond; // 0x20
	internal int cbPendingUnreliable; // 0x24
	internal int cbPendingReliable; // 0x28
	internal int cbSentUnackedReliable; // 0x2C
	internal long ecQueueTime; // 0x30
	internal uint[] reserved; // 0x38

	// Properties
	public int Ping { get; }
	public float OutBytesPerSec { get; }
	public float InBytesPerSec { get; }
	public float ConnectionQualityLocal { get; }
	public int PendingUnreliable { get; }
	public int PendingReliable { get; }

	// Methods

	// RVA: 0x14B600 Offset: 0x14AA00 VA: 0x18014B600
	public int get_Ping() { }

	// RVA: 0x1E5030 Offset: 0x1E4430 VA: 0x1801E5030
	public float get_OutBytesPerSec() { }

	// RVA: 0x1E5020 Offset: 0x1E4420 VA: 0x1801E5020
	public float get_InBytesPerSec() { }

	// RVA: 0x117100 Offset: 0x116500 VA: 0x180117100
	public float get_ConnectionQualityLocal() { }

	// RVA: 0x1E5040 Offset: 0x1E4440 VA: 0x1801E5040
	public int get_PendingUnreliable() { }

	// RVA: 0xF3ED0 Offset: 0xF32D0 VA: 0x1800F3ED0
	public int get_PendingReliable() { }

}

public class Connection // TypeDefIndex: 6682
{	// Fields
	private static MemoryStream reusableStream; // 0x0
	protected MemoryStream recordStream; // 0x10
	protected BinaryWriter recordWriter; // 0x18
	protected Stopwatch recordTime; // 0x20
	protected string recordFilename; // 0x28
	protected IDemoHeader recordHeader; // 0x30
	public Connection.State state; // 0x38
	public bool active; // 0x3C
	public bool connected; // 0x3D
	public uint authLevel; // 0x40
	public uint encryptionLevel; // 0x44
	public bool decryptIncoming; // 0x48
	public bool encryptOutgoing; // 0x49
	public bool trusted; // 0x4A
	public bool rejected; // 0x4B
	public string authStatus; // 0x50
	public byte[] token; // 0x58
	public bool hasRequestedWorld; // 0x60
	public ulong guid; // 0x68
	public ulong userid; // 0x70
	public ulong ownerid; // 0x78
	public string username; // 0x80
	public string os; // 0x88
	public uint protocol; // 0x90
	private TimeAverageValueData[] packetsPerSecond; // 0x98
	public double connectionTime; // 0xA0
	public string ipaddress; // 0xA8
	public MonoBehaviour player; // 0xB0
	public Connection.Validation validate; // 0xB8
	public Connection.ClientInfo info; // 0xC0

	// Properties
	public TimeSpan RecordTimeElapsed { get; }
	public string RecordFilename { get; }
	public int RecordFilesize { get; }
	public bool IsRecording { get; }
	public bool isAuthenticated { get; }

	// Methods

	// RVA: 0x220EF30 Offset: 0x220D530 VA: 0x18220EF30
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public string get_RecordFilename() { }

	// RVA: 0xBC9350 Offset: 0xBC7950 VA: 0x180BC9350
	public int get_RecordFilesize() { }

	// RVA: 0x220E820 Offset: 0x220CE20 VA: 0x18220E820
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x220E930 Offset: 0x220CF30 VA: 0x18220E930
	public void StopRecording() { }

	// RVA: 0x795C00 Offset: 0x794200 VA: 0x180795C00
	public bool get_IsRecording() { }

	// RVA: 0x220E320 Offset: 0x220C920 VA: 0x18220E320
	public void RecordPacket(byte packetId, IProto proto) { }

	// RVA: 0x220E5A0 Offset: 0x220CBA0 VA: 0x18220E5A0
	public void RecordPacket(Stream stream) { }

	// RVA: 0x220E280 Offset: 0x220C880 VA: 0x18220E280 Slot: 4
	public virtual void OnDisconnected() { }

	// RVA: 0x220EFB0 Offset: 0x220D5B0 VA: 0x18220EFB0
	public bool get_isAuthenticated() { }

	// RVA: 0x220E7A0 Offset: 0x220CDA0 VA: 0x18220E7A0
	public void ResetPacketsPerSecond() { }

	// RVA: 0x220E110 Offset: 0x220C710 VA: 0x18220E110
	public void AddPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220E0C0 Offset: 0x220C6C0 VA: 0x18220E0C0
	public void AddPacketsPerSecond(int index = 0) { }

	// RVA: 0x220E1C0 Offset: 0x220C7C0 VA: 0x18220E1C0
	public ulong GetPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220E160 Offset: 0x220C760 VA: 0x18220E160
	public ulong GetPacketsPerSecond(int index = 0) { }

	// RVA: 0x220E220 Offset: 0x220C820 VA: 0x18220E220
	public float GetSecondsConnected() { }

	// RVA: 0x220ECF0 Offset: 0x220D2F0 VA: 0x18220ECF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x220EDD0 Offset: 0x220D3D0 VA: 0x18220EDD0
	public void .ctor() { }

	// RVA: 0x220ED70 Offset: 0x220D370 VA: 0x18220ED70
	private static void .cctor() { }

}

public enum Connection.State // TypeDefIndex: 6683
{	// Fields
	public int value__; // 0x0
	public const Connection.State Unconnected = 0;
	public const Connection.State Connecting = 1;
	public const Connection.State InQueue = 2;
	public const Connection.State Welcoming = 3;
	public const Connection.State Connected = 4;
	public const Connection.State Disconnected = 5;

}

public struct Connection.Validation // TypeDefIndex: 6684
{	// Fields
	public uint entityUpdates; // 0x0

}

public class Connection.ClientInfo // TypeDefIndex: 6685
{	// Fields
	public Dictionary<string, string> info; // 0x10

	// Methods

	// RVA: 0x220D920 Offset: 0x220BF20 VA: 0x18220D920
	public void Set(string k, string v) { }

	// RVA: 0x220D8A0 Offset: 0x220BEA0 VA: 0x18220D8A0
	public string GetString(string k, string def = "") { }

	// RVA: 0x220D740 Offset: 0x220BD40 VA: 0x18220D740
	public float GetFloat(string k, float def = 0) { }

	// RVA: 0x220D7F0 Offset: 0x220BDF0 VA: 0x18220D7F0
	public int GetInt(string k, int def = 0) { }

	// RVA: 0x220D640 Offset: 0x220BC40 VA: 0x18220D640
	public bool GetBool(string k, bool def = False) { }

	// RVA: 0x220D990 Offset: 0x220BF90 VA: 0x18220D990
	public void .ctor() { }

}

public class NetRead : Stream // TypeDefIndex: 6695
{	// Fields
	private MemoryStream _stream; // 0x28
	public byte[] Data; // 0x30
	public long _length; // 0x38
	public long _position; // 0x40
	private const int bufferSize = 1048576;
	private static byte[] byteBuffer; // 0x0
	private static char[] charBuffer; // 0x8

	// Properties
	public int Unread { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }

	// Methods

	// RVA: 0x22108C0 Offset: 0x220EEC0 VA: 0x1822108C0
	public MemoryStream GetStreamForDecryption() { }

	// RVA: 0x2210D50 Offset: 0x220F350 VA: 0x182210D50
	public bool Start(IntPtr data, int length) { }

	// RVA: 0x2211660 Offset: 0x220FC60 VA: 0x182211660
	public int get_Unread() { }

	// RVA: 0x2211260 Offset: 0x220F860 VA: 0x182211260
	public string String(int maxLength = 256) { }

	// RVA: 0x2211150 Offset: 0x220F750 VA: 0x182211150
	public string StringMultiLine(int maxLength = 2048) { }

	// RVA: 0x2210EC0 Offset: 0x220F4C0 VA: 0x182210EC0
	private string StringInternal(int maxLength, bool allowNewLine) { }

	// RVA: 0x2211160 Offset: 0x220F760 VA: 0x182211160
	public string StringRaw(uint maxLength = 1048576) { }

	// RVA: 0x2211270 Offset: 0x220F870 VA: 0x182211270
	public bool TemporaryBytesWithSize(out byte[] buffer, out int size) { }

	// RVA: 0x22107F0 Offset: 0x220EDF0 VA: 0x1822107F0
	public uint EntityID() { }

	// RVA: 0x22107F0 Offset: 0x220EDF0 VA: 0x1822107F0
	public uint GroupID() { }

	// RVA: 0x2210690 Offset: 0x220EC90 VA: 0x182210690
	public int BytesWithSize(byte[] buffer, uint maxLength = 4294967295) { }

	// RVA: 0x22105C0 Offset: 0x220EBC0 VA: 0x1822105C0
	public byte[] BytesWithSize(uint maxSize = 10485760) { }

	// RVA: 0x2210BA0 Offset: 0x220F1A0 VA: 0x182210BA0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xC157D0 Offset: 0xC13DD0 VA: 0x180C157D0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2210AA0 Offset: 0x220F0A0 VA: 0x182210AA0
	public byte PacketID() { }

	// RVA: 0x2210580 Offset: 0x220EB80 VA: 0x182210580
	public bool Bit() { }

	// RVA: 0x2210AA0 Offset: 0x220F0A0 VA: 0x182210AA0
	public byte UInt8() { }

	// RVA: 0x22113E0 Offset: 0x220F9E0 VA: 0x1822113E0
	public ushort UInt16() { }

	// RVA: 0x22107F0 Offset: 0x220EDF0 VA: 0x1822107F0
	public uint UInt32() { }

	// RVA: 0x2211420 Offset: 0x220FA20 VA: 0x182211420
	public ulong UInt64() { }

	// RVA: 0x2210A60 Offset: 0x220F060 VA: 0x182210A60
	public sbyte Int8() { }

	// RVA: 0x22109A0 Offset: 0x220EFA0 VA: 0x1822109A0
	public short Int16() { }

	// RVA: 0x22109E0 Offset: 0x220EFE0 VA: 0x1822109E0
	public int Int32() { }

	// RVA: 0x2210A20 Offset: 0x220F020 VA: 0x182210A20
	public long Int64() { }

	// RVA: 0x2210830 Offset: 0x220EE30 VA: 0x182210830
	public float Float() { }

	// RVA: 0x22107B0 Offset: 0x220EDB0 VA: 0x1822107B0
	public double Double() { }

	// RVA: 0x2211460 Offset: 0x220FA60 VA: 0x182211460
	public Vector3 Vector3() { }

	// RVA: 0x2210AE0 Offset: 0x220F0E0 VA: 0x182210AE0
	public Quaternion Quaternion() { }

	// RVA: 0x2210B40 Offset: 0x220F140 VA: 0x182210B40
	public Ray Ray() { }

	// RVA: 0x2210750 Offset: 0x220ED50 VA: 0x182210750
	public Color Color() { }

	// RVA: 0x2210C40 Offset: 0x220F240 VA: 0x182210C40 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340 Slot: 10
	public override long get_Length() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21C1760 Offset: 0x21BFD60 VA: 0x1821C1760 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2210CD0 Offset: 0x220F2D0 VA: 0x182210CD0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1
	public T Read<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2890 Offset: 0x5D0E90 VA: 0x1805D2890
	|-NetRead.Read<byte>
	|-NetRead.Read<sbyte>
	|
	|-RVA: 0x5D2960 Offset: 0x5D0F60 VA: 0x1805D2960
	|-NetRead.Read<double>
	|
	|-RVA: 0x5D29C0 Offset: 0x5D0FC0 VA: 0x1805D29C0
	|-NetRead.Read<short>
	|-NetRead.Read<ushort>
	|
	|-RVA: 0x5D2A20 Offset: 0x5D1020 VA: 0x1805D2A20
	|-NetRead.Read<int>
	|-NetRead.Read<uint>
	|
	|-RVA: 0x5D2A80 Offset: 0x5D1080 VA: 0x1805D2A80
	|-NetRead.Read<long>
	|-NetRead.Read<ulong>
	|
	|-RVA: 0x5D2B70 Offset: 0x5D1170 VA: 0x1805D2B70
	|-NetRead.Read<float>
	|
	|-RVA: 0x5D28F0 Offset: 0x5D0EF0 VA: 0x1805D28F0
	|-NetRead.Read<Color>
	|-NetRead.Read<Quaternion>
	|
	|-RVA: 0x5D2AE0 Offset: 0x5D10E0 VA: 0x1805D2AE0
	|-NetRead.Read<Ray>
	|
	|-RVA: 0x5D2BD0 Offset: 0x5D11D0 VA: 0x1805D2BD0
	|-NetRead.Read<Vector3>
	*/

	// RVA: 0x2210870 Offset: 0x220EE70 VA: 0x182210870 Slot: 18
	public override void Flush() { }

	// RVA: 0x2211510 Offset: 0x220FB10 VA: 0x182211510 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x22114C0 Offset: 0x220FAC0 VA: 0x1822114C0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x22115E0 Offset: 0x220FBE0 VA: 0x1822115E0
	public void .ctor() { }

	// RVA: 0x2211560 Offset: 0x220FB60 VA: 0x182211560
	private static void .cctor() { }

}

public class NetWrite : MemoryStream // TypeDefIndex: 6696
{	// Fields
	private static MemoryStream buffer; // 0x0
	private BaseNetwork netwrite; // 0x50
	private byte[] data; // 0x58
	private int position; // 0x60
	private int length; // 0x64

	// Properties
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x22128F0 Offset: 0x2210EF0 VA: 0x1822128F0
	public void .ctor(BaseNetwork netwrite) { }

	// RVA: 0x2212290 Offset: 0x2210890 VA: 0x182212290
	public void Shutdown() { }

	// RVA: 0x2212310 Offset: 0x2210910 VA: 0x182212310
	public bool Start() { }

	// RVA: 0x22121F0 Offset: 0x22107F0 VA: 0x1822121F0
	public void Send(SendInfo info) { }

	// RVA: 0x2211F40 Offset: 0x2210540 VA: 0x182211F40
	public void PacketID(Message.Type val) { }

	// RVA: 0x22126B0 Offset: 0x2210CB0 VA: 0x1822126B0
	public void UInt8(byte val) { }

	// RVA: 0x22125C0 Offset: 0x2210BC0 VA: 0x1822125C0
	public void UInt16(ushort val) { }

	// RVA: 0x2212610 Offset: 0x2210C10 VA: 0x182212610
	public void UInt32(uint val) { }

	// RVA: 0x2212660 Offset: 0x2210C60 VA: 0x182212660
	public void UInt64(ulong val) { }

	// RVA: 0x2211EF0 Offset: 0x22104F0 VA: 0x182211EF0
	public void Int8(sbyte val) { }

	// RVA: 0x2211E00 Offset: 0x2210400 VA: 0x182211E00
	public void Int16(short val) { }

	// RVA: 0x2211E50 Offset: 0x2210450 VA: 0x182211E50
	public void Int32(int val) { }

	// RVA: 0x2211EA0 Offset: 0x22104A0 VA: 0x182211EA0
	public void Int64(long val) { }

	// RVA: 0x22116B0 Offset: 0x220FCB0 VA: 0x1822116B0
	public void Bool(bool val) { }

	// RVA: 0x2211DB0 Offset: 0x22103B0 VA: 0x182211DB0
	public void Float(float val) { }

	// RVA: 0x2211A90 Offset: 0x2210090 VA: 0x182211A90
	public void Double(double val) { }

	// RVA: 0x2211940 Offset: 0x220FF40 VA: 0x182211940
	public void Bytes(byte[] val) { }

	// RVA: 0x2212320 Offset: 0x2210920 VA: 0x182212320
	public void String(string val) { }

	// RVA: 0x2212700 Offset: 0x2210D00 VA: 0x182212700
	public void Vector3(in Vector3 obj) { }

	// RVA: 0x2211980 Offset: 0x220FF80 VA: 0x182211980
	public void Quaternion(in Quaternion obj) { }

	// RVA: 0x2211F90 Offset: 0x2210590 VA: 0x182211F90
	public void Ray(in Ray obj) { }

	// RVA: 0x2211980 Offset: 0x220FF80 VA: 0x182211980
	public void Color(in Color obj) { }

	// RVA: 0x2211D60 Offset: 0x2210360 VA: 0x182211D60
	public void EntityID(uint id) { }

	// RVA: 0x2211D60 Offset: 0x2210360 VA: 0x182211D60
	public void GroupID(uint id) { }

	// RVA: 0x2211710 Offset: 0x220FD10 VA: 0x182211710
	public void BytesWithSize(MemoryStream val) { }

	// RVA: 0x22117D0 Offset: 0x220FDD0 VA: 0x1822117D0
	public void BytesWithSize(byte[] b) { }

	// RVA: 0x22117F0 Offset: 0x220FDF0 VA: 0x1822117F0
	public void BytesWithSize(byte[] b, int length) { }

	// RVA: -1 Offset: -1
	private void Write<T>(in T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15742B0 Offset: 0x15728B0 VA: 0x1815742B0
	|-NetWrite.Write<byte>
	|-NetWrite.Write<sbyte>
	|
	|-RVA: 0x1574320 Offset: 0x1572920 VA: 0x181574320
	|-NetWrite.Write<double>
	|-NetWrite.Write<long>
	|-NetWrite.Write<ulong>
	|
	|-RVA: 0x1574390 Offset: 0x1572990 VA: 0x181574390
	|-NetWrite.Write<short>
	|-NetWrite.Write<ushort>
	|
	|-RVA: 0x1574400 Offset: 0x1572A00 VA: 0x181574400
	|-NetWrite.Write<int>
	|-NetWrite.Write<float>
	|-NetWrite.Write<uint>
	*/

	// RVA: 0x2211AE0 Offset: 0x22100E0 VA: 0x182211AE0
	private void EnsureCapacity(int spaceRequired) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 31
	public override byte[] GetBuffer() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x22129E0 Offset: 0x2210FE0 VA: 0x1822129E0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x22129F0 Offset: 0x2210FF0 VA: 0x1822129F0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2212A00 Offset: 0x2211000 VA: 0x182212A00 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x2212090 Offset: 0x2210690 VA: 0x182212090 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2212040 Offset: 0x2210640 VA: 0x182212040 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2212820 Offset: 0x2210E20 VA: 0x182212820 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x22127D0 Offset: 0x2210DD0 VA: 0x1822127D0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2212150 Offset: 0x2210750 VA: 0x182212150 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2212240 Offset: 0x2210840 VA: 0x182212240 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2212890 Offset: 0x2210E90 VA: 0x182212890
	private static void .cctor() { }

}

public class Networkable : Pool.IPooled // TypeDefIndex: 6700
{	// Fields
	public uint ID; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Connection <connection>k__BackingField; // 0x18
	public Group group; // 0x20
	public Group secondaryGroup; // 0x28
	public Subscriber subscriber; // 0x30
	public NetworkHandler handler; // 0x38
	private bool updateSubscriptions; // 0x40
	internal Server sv; // 0x48
	internal Client cl; // 0x50

	// Properties
	public Connection connection { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Connection get_connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_connection(Connection value) { }

	// RVA: 0x2212C50 Offset: 0x2211250 VA: 0x182212C50
	public void Destroy() { }

	// RVA: 0x2212C80 Offset: 0x2211280 VA: 0x182212C80 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2212FA0 Offset: 0x22115A0 VA: 0x182212FA0
	public void StartSubscriber() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void OnConnected(Connection c) { }

	// RVA: 0x2212D00 Offset: 0x2211300 VA: 0x182212D00
	public void OnDisconnected() { }

	// RVA: 0x2212BC0 Offset: 0x22111C0 VA: 0x182212BC0
	public void CloseSubscriber() { }

	// RVA: 0x2213960 Offset: 0x2211F60 VA: 0x182213960
	public bool UpdateGroups(Vector3 position) { }

	// RVA: 0x22130E0 Offset: 0x22116E0 VA: 0x1822130E0
	public bool SwitchGroup(Group newGroup) { }

	// RVA: 0x2212D30 Offset: 0x2211330 VA: 0x182212D30
	internal void OnGroupTransition(Group oldGroup) { }

	// RVA: 0x2212EC0 Offset: 0x22114C0 VA: 0x182212EC0
	internal void OnSubscriptionChange() { }

	// RVA: 0x22137F0 Offset: 0x2211DF0 VA: 0x1822137F0
	public bool SwitchSecondaryGroup(Group newGroup) { }

	// RVA: 0x2212A20 Offset: 0x2211020 VA: 0x182212A20
	private void AddVisibleFromNear(Group additionalGroup, List<Group> groupsVisible) { }

	// RVA: 0x2213DA0 Offset: 0x22123A0 VA: 0x182213DA0
	public bool UpdateSubscriptions(int removeLimit, int addLimit) { }

	// RVA: 0x2213B00 Offset: 0x2212100 VA: 0x182213B00
	public bool UpdateHighPrioritySubscriptions() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class QueuedStream : Stream // TypeDefIndex: 6916
{	// Fields
	private readonly Stream _stream; // 0x28
	private readonly Queue<QueuedStream.WriteData> _queue; // 0x30
	private int _pendingWrite; // 0x38
	private bool _disposed; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2208630 Offset: 0x2206C30 VA: 0x182208630
	public void .ctor(Stream stream) { }

	// RVA: 0xBA5070 Offset: 0xBA3670 VA: 0x180BA5070 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA50A0 Offset: 0xBA36A0 VA: 0x180BA50A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA50D0 Offset: 0xBA36D0 VA: 0x180BA50D0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA5100 Offset: 0xBA3700 VA: 0x180BA5100 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA5130 Offset: 0xBA3730 VA: 0x180BA5130 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA5160 Offset: 0xBA3760 VA: 0x180BA5160 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xBA4ED0 Offset: 0xBA34D0 VA: 0x180BA4ED0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4F00 Offset: 0xBA3500 VA: 0x180BA4F00 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4F30 Offset: 0xBA3530 VA: 0x180BA4F30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x22085D0 Offset: 0x2206BD0 VA: 0x1822085D0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4BC0 Offset: 0xBA31C0 VA: 0x180BA4BC0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2208210 Offset: 0x2206810 VA: 0x182208210 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4D60 Offset: 0xBA3360 VA: 0x180BA4D60 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2208490 Offset: 0x2206A90 VA: 0x182208490 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA4E70 Offset: 0xBA3470 VA: 0x180BA4E70 Slot: 18
	public override void Flush() { }

	// RVA: 0x1622410 Offset: 0x1620A10 VA: 0x181622410 Slot: 16
	public override void Close() { }

	// RVA: 0x2208440 Offset: 0x2206A40 VA: 0x182208440 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x22080B0 Offset: 0x22066B0 VA: 0x1822080B0
	private IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, QueuedStream.WriteData queued) { }

}

private class QueuedStream.WriteData // TypeDefIndex: 6917
{	// Fields
	public readonly byte[] Buffer; // 0x10
	public readonly int Offset; // 0x18
	public readonly int Count; // 0x1C
	public readonly AsyncCallback Callback; // 0x20
	public readonly object State; // 0x28
	public readonly QueuedStream.QueuedWriteResult AsyncResult; // 0x30

	// Methods

	// RVA: 0x220CF80 Offset: 0x220B580 VA: 0x18220CF80
	public void .ctor(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

}

private class QueuedStream.QueuedWriteResult : IAsyncResult // TypeDefIndex: 6918
{	// Fields
	private readonly object _state; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Exception <Exception>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IAsyncResult <ActualResult>k__BackingField; // 0x20

	// Properties
	public Exception Exception { get; set; }
	public IAsyncResult ActualResult { get; set; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Exception get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Exception(Exception value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IAsyncResult get_ActualResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_ActualResult(IAsyncResult value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x22086E0 Offset: 0x2206CE0 VA: 0x1822086E0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2208740 Offset: 0x2206D40 VA: 0x182208740 Slot: 4
	public bool get_IsCompleted() { }

}

private sealed class QueuedStream.<>c__DisplayClass27_0 // TypeDefIndex: 6919
{	// Fields
	public QueuedStream.WriteData queued; // 0x10
	public QueuedStream <>4__this; // 0x18
	public AsyncCallback callback; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209D40 Offset: 0x2208340 VA: 0x182209D40
	internal void <BeginWriteInternal>b__0(IAsyncResult ar) { }

}

public class NetGraph : SingletonComponent<NetGraph> // TypeDefIndex: 7075
{	// Fields
	public CanvasGroup group; // 0x18
	public GameObject rootPanel; // 0x20
	private NetGraphRow[] rows; // 0x28

	// Properties
	public bool Enabled { set; }

	// Methods

	// RVA: 0xFC70D0 Offset: 0xFC56D0 VA: 0x180FC70D0
	public void Start() { }

	// RVA: 0xFC7530 Offset: 0xFC5B30 VA: 0x180FC7530
	public void set_Enabled(bool value) { }

	// RVA: 0xFC7120 Offset: 0xFC5720 VA: 0x180FC7120
	public void UpdateFrom(Stats incomingStats) { }

	// RVA: 0xFC74D0 Offset: 0xFC5AD0 VA: 0x180FC74D0
	public void .ctor() { }

}

private sealed class NetGraph.<>c // TypeDefIndex: 7076
{	// Fields
	public static readonly NetGraph.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xFD9D70 Offset: 0xFD8370 VA: 0x180FD9D70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD9210 Offset: 0xFD7810 VA: 0x180FD9210
	internal long <UpdateFrom>b__6_0(KeyValuePair<string, Stats.Node> y) { }

}

public class NetGraphItem : MonoBehaviour // TypeDefIndex: 7077
{	// Fields
	public CanvasGroup group; // 0x18
	public LayoutElement element; // 0x20
	public Text countTotal; // 0x28
	public Text label; // 0x30
	public Text bytes; // 0x38

	// Methods

	// RVA: 0xFC6A10 Offset: 0xFC5010 VA: 0x180FC6A10
	internal void Hide() { }

	// RVA: 0xFC6A60 Offset: 0xFC5060 VA: 0x180FC6A60
	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class NetGraphRow : MonoBehaviour // TypeDefIndex: 7078
{	// Fields
	public CanvasGroup group; // 0x18
	public Text countTotal; // 0x20
	public Text countUnique; // 0x28
	public Text label; // 0x30
	public Text bytes; // 0x38
	public GameObject RowContainer; // 0x40
	public NetGraphItem[] Items; // 0x48
	public GameObject RowSpacer; // 0x50

	// Methods

	// RVA: 0xFC6BB0 Offset: 0xFC51B0 VA: 0x180FC6BB0
	private void Awake() { }

	// RVA: 0x4DC0D0 Offset: 0x4DA6D0 VA: 0x1804DC0D0
	internal void Hide() { }

	// RVA: 0xFC6C00 Offset: 0xFC5200 VA: 0x180FC6C00
	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class NetGraphRow.<>c // TypeDefIndex: 7079
{	// Fields
	public static readonly NetGraphRow.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__10_0; // 0x8

	// Methods

	// RVA: 0xFD9D10 Offset: 0xFD8310 VA: 0x180FD9D10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD91D0 Offset: 0xFD77D0 VA: 0x180FD91D0
	internal long <UpdateFrom>b__10_0(KeyValuePair<string, Stats.Node> y) { }

}

internal sealed class NetProtect : INetProtect // TypeDefIndex: 7165
{	// Methods

	// RVA: 0x22E7790 Offset: 0x22E5D90 VA: 0x1822E7790
	public void .ctor(IntPtr Instance) { }

	// RVA: 0x22E7690 Offset: 0x22E5C90 VA: 0x1822E7690 Slot: 4
	public bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E7710 Offset: 0x22E5D10 VA: 0x1822E7710 Slot: 5
	public bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

}

public class Net // TypeDefIndex: 8228
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Client <cl>k__BackingField; // 0x0
	public static Client ClientNetwork; // 0x8
	public static DemoClient DemoClientNetwork; // 0x10

	// Properties
	public static Client cl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1071F90 Offset: 0x1070590 VA: 0x181071F90
	public static Client get_cl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1071FD0 Offset: 0x10705D0 VA: 0x181071FD0
	private static void set_cl(Client value) { }

	// RVA: 0x1071D80 Offset: 0x1070380 VA: 0x181071D80
	public static void ClientInit(Client newclient) { }

	// RVA: 0x1071E10 Offset: 0x1070410 VA: 0x181071E10
	public static void StartDemoPlayback(Reader demo) { }

	// RVA: 0x1071ED0 Offset: 0x10704D0 VA: 0x181071ED0
	public static void StopDemoPlayback() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class NetworkInfoGeneralText : MonoBehaviour // TypeDefIndex: 9286
{	// Fields
	public TextMeshProUGUI text; // 0x18

	// Methods

	// RVA: 0x9D0F70 Offset: 0x9CF570 VA: 0x1809D0F70
	private void Update() { }

	// RVA: 0x9D0F70 Offset: 0x9CF570 VA: 0x1809D0F70
	private void UpdateText() { }

	// RVA: 0x9D0EF0 Offset: 0x9CF4F0 VA: 0x1809D0EF0
	private static string ChannelStat(int window, int left) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class NetworkCryptography : INetworkCryptocraphy // TypeDefIndex: 10237
{	// Fields
	private MemoryStream buffer; // 0x10

	// Methods

	// RVA: 0x7ECE70 Offset: 0x7EB470 VA: 0x1807ECE70 Slot: 6
	public MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7ECD40 Offset: 0x7EB340 VA: 0x1807ECD40 Slot: 7
	public MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7ECF70 Offset: 0x7EB570 VA: 0x1807ECF70 Slot: 8
	public void Encrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7ECE40 Offset: 0x7EB440 VA: 0x1807ECE40 Slot: 9
	public void Decrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7ECFA0 Offset: 0x7EB5A0 VA: 0x1807ECFA0 Slot: 4
	public bool IsEnabledIncoming(Connection connection) { }

	// RVA: 0x7ECFC0 Offset: 0x7EB5C0 VA: 0x1807ECFC0 Slot: 5
	public bool IsEnabledOutgoing(Connection connection) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: 0x7ECCD0 Offset: 0x7EB2D0 VA: 0x1807ECCD0
	protected void .ctor() { }

}

public class NetworkCryptographyClient : NetworkCryptography // TypeDefIndex: 10238
{	// Methods

	// RVA: 0x7ECBE0 Offset: 0x7EB1E0 VA: 0x1807ECBE0 Slot: 10
	protected override void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7ECAF0 Offset: 0x7EB0F0 VA: 0x1807ECAF0 Slot: 11
	protected override void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7ECCD0 Offset: 0x7EB2D0 VA: 0x1807ECCD0
	public void .ctor() { }

}

public class NetworkVisibilityGrid : MonoBehaviour // TypeDefIndex: 10239
{	// Fields
	public int startID; // 0x18
	public int gridSize; // 0x1C
	public int cellCount; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xBF320 Offset: 0xBE720 VA: 0x1800BF320
	public int visibilityRadiusFar; // 0x24
	public int visibilityRadiusNear; // 0x28
	public float switchTolerance; // 0x2C

	// Methods

	// RVA: 0x9D1070 Offset: 0x9CF670 VA: 0x1809D1070
	public void .ctor() { }

}

public class ConnectionAuth : MonoBehaviour // TypeDefIndex: 10709
{	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ConnectionQueue // TypeDefIndex: 10710
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ConnectionScreen : SingletonComponent<ConnectionScreen> // TypeDefIndex: 11096
{	// Fields
	public Text statusText; // 0x18
	public GameObject disconnectButton; // 0x20
	public GameObject retryButton; // 0x28
	public ServerBrowserInfo browserInfo; // 0x30
	internal Nullable<ServerInfo> currentServer; // 0x38
	internal Dictionary<string, string> currentServerRules; // 0xB8

	// Methods

	// RVA: 0x2FCC70 Offset: 0x2FB270 VA: 0x1802FCC70
	public static void Show() { }

	// RVA: 0x2FCDB0 Offset: 0x2FB3B0 VA: 0x1802FCDB0
	public static void UpdateServer(ServerInfo server) { }

	// RVA: 0x2FC520 Offset: 0x2FAB20 VA: 0x1802FC520
	public static void FailedWith(string str) { }

	// RVA: 0x2FC3A0 Offset: 0x2FA9A0 VA: 0x1802FC3A0
	public static void FailedWithException(Exception e) { }

	// RVA: 0x2FCB80 Offset: 0x2FB180 VA: 0x1802FCB80
	public static void SetStatus(string status) { }

	// RVA: 0x2FC0F0 Offset: 0x2FA6F0 VA: 0x1802FC0F0
	public static void DisconnectReason(string str) { }

	// RVA: 0x2FCA10 Offset: 0x2FB010 VA: 0x1802FCA10
	public void RetryConnection() { }

	[AsyncStateMachineAttribute] // RVA: 0x960C0 Offset: 0x954C0 VA: 0x1800960C0
	// RVA: 0x2FC680 Offset: 0x2FAC80 VA: 0x1802FC680
	public static void LoadServerInfo(string address, int port, bool addToHistory = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x96220 Offset: 0x95620 VA: 0x180096220
	// RVA: 0x2FC780 Offset: 0x2FAD80 VA: 0x1802FC780
	private static void LoadServerRules() { }

	// RVA: 0x2FC820 Offset: 0x2FAE20 VA: 0x1802FC820
	private static void OnServerInfoChanged() { }

	// RVA: 0x2FD0F0 Offset: 0x2FB6F0 VA: 0x1802FD0F0
	public void .ctor() { }

}

private struct ConnectionScreen.<LoadServerInfo>d__13 : IAsyncStateMachine // TypeDefIndex: 11097
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string address; // 0x28
	public int port; // 0x30
	public bool addToHistory; // 0x34
	private TaskAwaiter<Nullable<ServerInfo>> <>u__1; // 0x38

	// Methods

	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ConnectionScreen.<LoadServerRules>d__14 : IAsyncStateMachine // TypeDefIndex: 11098
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x28

	// Methods

	// RVA: 0xF1540 Offset: 0xF0940 VA: 0x1800F1540 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class NetworkSleep : MonoBehaviour // TypeDefIndex: 11322
{	// Fields
	public static int totalBehavioursDisabled; // 0x0
	public static int totalCollidersDisabled; // 0x4
	public Behaviour[] behaviours; // 0x18
	public Collider[] colliders; // 0x20
	internal int BehavioursDisabled; // 0x28
	internal int CollidersDisabled; // 0x2C

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public static class NetworkWriteEx // TypeDefIndex: 11348
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static void WriteObject<T>(NetWrite write, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574470 Offset: 0x1572A70 VA: 0x181574470
	|-NetworkWriteEx.WriteObject<bool>
	|
	|-RVA: 0x1574F80 Offset: 0x1573580 VA: 0x181574F80
	|-NetworkWriteEx.WriteObject<byte>
	|
	|-RVA: 0x1575A90 Offset: 0x1574090 VA: 0x181575A90
	|-NetworkWriteEx.WriteObject<int>
	|
	|-RVA: 0x1576590 Offset: 0x1574B90 VA: 0x181576590
	|-NetworkWriteEx.WriteObject<object>
	|
	|-RVA: 0x1576F90 Offset: 0x1575590 VA: 0x181576F90
	|-NetworkWriteEx.WriteObject<sbyte>
	|
	|-RVA: 0xCFBF80 Offset: 0xCFA580 VA: 0x180CFBF80
	|-NetworkWriteEx.WriteObject<float>
	|
	|-RVA: 0xCFCAB0 Offset: 0xCFB0B0 VA: 0x180CFCAB0
	|-NetworkWriteEx.WriteObject<uint>
	|
	|-RVA: 0xCFD5B0 Offset: 0xCFBBB0 VA: 0x180CFD5B0
	|-NetworkWriteEx.WriteObject<ulong>
	|
	|-RVA: 0xCFA900 Offset: 0xCF8F00 VA: 0x180CFA900
	|-NetworkWriteEx.WriteObject<Color>
	|
	|-RVA: 0xCFB3E0 Offset: 0xCF99E0 VA: 0x180CFB3E0
	|-NetworkWriteEx.WriteObject<Ray>
	|
	|-RVA: 0xCFE0C0 Offset: 0xCFC6C0 VA: 0x180CFE0C0
	|-NetworkWriteEx.WriteObject<Vector3>
	*/

}

public class NetworkedProperty<T> // TypeDefIndex: 11430
{	// Fields
	private T val; // 0x0
	private BaseEntity entity; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	|-NetworkedProperty<int>.get_Value
	|
	|-RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	|-NetworkedProperty<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E4F0 Offset: 0x164CAF0 VA: 0x18164E4F0
	|-NetworkedProperty<int>.set_Value
	|
	|-RVA: 0x164E400 Offset: 0x164CA00 VA: 0x18164E400
	|-NetworkedProperty<object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseEntity entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E330 Offset: 0x164C930 VA: 0x18164E330
	|-NetworkedProperty<int>..ctor
	|-NetworkedProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(NetworkedProperty<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x164E370 Offset: 0x164C970 VA: 0x18164E370
	|-NetworkedProperty<int>.op_Implicit
	|-NetworkedProperty<object>.op_Implicit
	*/

}

public sealed class ProxyArray : Variant, IEnumerable<Variant>, IEnumerable // TypeDefIndex: 11583
{	// Fields
	private readonly List<Variant> list; // 0x10

	// Properties
	public override Variant Item { get; set; }
	public int Count { get; }

	// Methods

	// RVA: 0x85E510 Offset: 0x85CB10 VA: 0x18085E510
	public void .ctor() { }

	// RVA: 0x85E410 Offset: 0x85CA10 VA: 0x18085E410 Slot: 42
	private IEnumerator<Variant> System.Collections.Generic.IEnumerable<TinyJSON.Variant>.GetEnumerator() { }

	// RVA: 0x85E490 Offset: 0x85CA90 VA: 0x18085E490 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x85E1B0 Offset: 0x85C7B0 VA: 0x18085E1B0
	public void Add(Variant item) { }

	// RVA: 0x85E5E0 Offset: 0x85CBE0 VA: 0x18085E5E0 Slot: 40
	public override Variant get_Item(int index) { }

	// RVA: 0x85E640 Offset: 0x85CC40 VA: 0x18085E640 Slot: 41
	public override void set_Item(int index, Variant value) { }

	// RVA: 0x85E5A0 Offset: 0x85CBA0 VA: 0x18085E5A0
	public int get_Count() { }

	// RVA: 0x85E210 Offset: 0x85C810 VA: 0x18085E210
	internal bool CanBeMultiRankArray(int[] rankLengths) { }

	// RVA: 0x85E220 Offset: 0x85C820 VA: 0x18085E220
	private bool CanBeMultiRankArray(int rank, int[] rankLengths) { }

}

public sealed class ProxyBoolean : Variant // TypeDefIndex: 11584
{	// Fields
	private readonly bool value; // 0x10

	// Methods

	// RVA: 0x85E6F0 Offset: 0x85CCF0 VA: 0x18085E6F0
	public void .ctor(bool value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x85E6B0 Offset: 0x85CCB0 VA: 0x18085E6B0 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public sealed class ProxyNumber : Variant // TypeDefIndex: 11585
{	// Fields
	private static readonly char[] floatingPointCharacters; // 0x0
	private readonly IConvertible value; // 0x10

	// Methods

	// RVA: 0x85F5D0 Offset: 0x85DBD0 VA: 0x18085F5D0
	public void .ctor(IConvertible value) { }

	// RVA: 0x85E760 Offset: 0x85CD60 VA: 0x18085E760
	private static IConvertible Parse(string value) { }

	// RVA: 0x85EA90 Offset: 0x85D090 VA: 0x18085EA90 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x85EB50 Offset: 0x85D150 VA: 0x18085EB50 Slot: 25
	public override byte ToByte(IFormatProvider provider) { }

	// RVA: 0x85EC10 Offset: 0x85D210 VA: 0x18085EC10 Slot: 26
	public override char ToChar(IFormatProvider provider) { }

	// RVA: 0x85ECD0 Offset: 0x85D2D0 VA: 0x18085ECD0 Slot: 27
	public override Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x85EDB0 Offset: 0x85D3B0 VA: 0x18085EDB0 Slot: 28
	public override double ToDouble(IFormatProvider provider) { }

	// RVA: 0x85EE70 Offset: 0x85D470 VA: 0x18085EE70 Slot: 29
	public override short ToInt16(IFormatProvider provider) { }

	// RVA: 0x85EF30 Offset: 0x85D530 VA: 0x18085EF30 Slot: 30
	public override int ToInt32(IFormatProvider provider) { }

	// RVA: 0x85EFF0 Offset: 0x85D5F0 VA: 0x18085EFF0 Slot: 31
	public override long ToInt64(IFormatProvider provider) { }

	// RVA: 0x85F0B0 Offset: 0x85D6B0 VA: 0x18085F0B0 Slot: 32
	public override sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x85F170 Offset: 0x85D770 VA: 0x18085F170 Slot: 33
	public override float ToSingle(IFormatProvider provider) { }

	// RVA: 0x85F230 Offset: 0x85D830 VA: 0x18085F230 Slot: 34
	public override string ToString(IFormatProvider provider) { }

	// RVA: 0x85F2F0 Offset: 0x85D8F0 VA: 0x18085F2F0 Slot: 35
	public override ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x85F3B0 Offset: 0x85D9B0 VA: 0x18085F3B0 Slot: 36
	public override uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x85F470 Offset: 0x85DA70 VA: 0x18085F470 Slot: 37
	public override ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x85F530 Offset: 0x85DB30 VA: 0x18085F530
	private static void .cctor() { }

}

public sealed class ProxyObject : Variant, IEnumerable<KeyValuePair<string, Variant>>, IEnumerable // TypeDefIndex: 11586
{	// Fields
	public const string TypeHintKey = "@type";
	private readonly Dictionary<string, Variant> dict; // 0x10

	// Properties
	public string TypeHint { get; }
	public override Variant Item { get; set; }
	public int Count { get; }
	public Dictionary.KeyCollection<string, Variant> Keys { get; }
	public Dictionary.ValueCollection<string, Variant> Values { get; }

	// Methods

	// RVA: 0x85FB90 Offset: 0x85E190 VA: 0x18085FB90
	public void .ctor() { }

	// RVA: 0x85FA20 Offset: 0x85E020 VA: 0x18085FA20 Slot: 42
	private IEnumerator<KeyValuePair<string, Variant>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TinyJSON.Variant>>.GetEnumerator() { }

	// RVA: 0x85FAA0 Offset: 0x85E0A0 VA: 0x18085FAA0 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x85F9B0 Offset: 0x85DFB0 VA: 0x18085F9B0
	public void Add(string key, Variant item) { }

	// RVA: 0x85FB20 Offset: 0x85E120 VA: 0x18085FB20
	public bool TryGetValue(string key, out Variant item) { }

	// RVA: 0x85FD20 Offset: 0x85E320 VA: 0x18085FD20
	public string get_TypeHint() { }

	// RVA: 0x85FC70 Offset: 0x85E270 VA: 0x18085FC70 Slot: 38
	public override Variant get_Item(string key) { }

	// RVA: 0x85FE50 Offset: 0x85E450 VA: 0x18085FE50 Slot: 39
	public override void set_Item(string key, Variant value) { }

	// RVA: 0x85FC20 Offset: 0x85E220 VA: 0x18085FC20
	public int get_Count() { }

	// RVA: 0x85FCD0 Offset: 0x85E2D0 VA: 0x18085FCD0
	public Dictionary.KeyCollection<string, Variant> get_Keys() { }

	// RVA: 0x85FE00 Offset: 0x85E400 VA: 0x18085FE00
	public Dictionary.ValueCollection<string, Variant> get_Values() { }

}

public sealed class ProxyString : Variant // TypeDefIndex: 11587
{	// Fields
	private readonly string value; // 0x10

	// Methods

	// RVA: 0x85FEC0 Offset: 0x85E4C0 VA: 0x18085FEC0
	public void .ctor(string value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public class ConnectionLimiter // TypeDefIndex: 11645
{	// Fields
	private readonly object _sync; // 0x10
	private readonly Dictionary<IPAddress, int> _addressCounts; // 0x18
	private int _overallCount; // 0x20

	// Methods

	// RVA: 0x5837B0 Offset: 0x581DB0 VA: 0x1805837B0
	public void .ctor() { }

	// RVA: 0x583590 Offset: 0x581B90 VA: 0x180583590
	public bool TryAdd(IPAddress address) { }

	// RVA: 0x582EA0 Offset: 0x5814A0 VA: 0x180582EA0
	public void Remove(IPAddress address) { }

	// RVA: 0x582DC0 Offset: 0x5813C0 VA: 0x180582DC0
	public void Clear() { }

	// RVA: 0x583000 Offset: 0x581600 VA: 0x180583000 Slot: 3
	public override string ToString() { }

}

private sealed class ConnectionLimiter.<>c // TypeDefIndex: 11646
{	// Fields
	public static readonly ConnectionLimiter.<>c <>9; // 0x0
	public static Func<KeyValuePair<IPAddress, int>, int> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x589D70 Offset: 0x588370 VA: 0x180589D70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589AC0 Offset: 0x5880C0 VA: 0x180589AC0
	internal int <ToString>b__7_0(KeyValuePair<IPAddress, int> t) { }

}

public static class NetworkPacketEx // TypeDefIndex: 11703
{
// Namespace: UnityEngine
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public static class NetworkPacketEx // TypeDefIndex: 11703
	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FE0A0 Offset: 0x9FC6A0 VA: 0x1809FE0A0
	public static BasePlayer Player(Message v) { }

}

public class Net : ConsoleSystem // TypeDefIndex: 11947
{	// Fields
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static bool visdebug; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debug; // 0x1
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int visibilityRadiusFarOverride; // 0x4
	[ServerVar] // RVA: 0x81B10 Offset: 0x80F10 VA: 0x180081B10
	public static int visibilityRadiusNearOverride; // 0x8

	// Methods

	// RVA: 0x366E90 Offset: 0x365490 VA: 0x180366E90
	public void .ctor() { }

	// RVA: 0x366E10 Offset: 0x365410 VA: 0x180366E10
	private static void .cctor() { }

}

public class Netgraph : ConsoleSystem // TypeDefIndex: 11948
{	// Fields
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool enabled; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static float updatespeed; // 0x4
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static string typefilter; // 0x8
	[ClientVar] // RVA: 0x89230 Offset: 0x88630 VA: 0x180089230
	public static string entityfilter; // 0x10

	// Methods

	// RVA: 0x366FD0 Offset: 0x3655D0 VA: 0x180366FD0
	public void .ctor() { }

	// RVA: 0x366F30 Offset: 0x365530 VA: 0x180366F30
	private static void .cctor() { }

}

