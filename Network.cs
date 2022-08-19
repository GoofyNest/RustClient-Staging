internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 815
{	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x1498010 Offset: 0x1496610 VA: 0x181498010
	private static void .cctor() { }

	// RVA: 0x1498090 Offset: 0x1496690 VA: 0x181498090
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x1497EB0 Offset: 0x14964B0 VA: 0x181497EB0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1497FA0 Offset: 0x14965A0 VA: 0x181497FA0
	private static void WaitCallback_Context(object state) { }

}

public class ProxyAttribute : Attribute // TypeDefIndex: 1159
{	// Methods

	// RVA: 0x14829C0 Offset: 0x1480FC0 VA: 0x1814829C0 Slot: 7
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x1482AD0 Offset: 0x14810D0 VA: 0x181482AD0 Slot: 8
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

	// RVA: 0x1467DA0 Offset: 0x14663A0 VA: 0x181467DA0
	public void .ctor() { }

	// RVA: 0x14679E0 Offset: 0x1465FE0 VA: 0x1814679E0
	public void .ctor(int capacity) { }

	// RVA: 0x1467BE0 Offset: 0x14661E0 VA: 0x181467BE0
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x14679F0 Offset: 0x1465FF0 VA: 0x1814679F0
	public void .ctor(ICollection col) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x14670E0 Offset: 0x14656E0 VA: 0x1814670E0 Slot: 10
	public virtual object Clone() { }

	// RVA: 0x1467DC0 Offset: 0x14663C0 VA: 0x181467DC0 Slot: 11
	public virtual object get_SyncRoot() { }

	// RVA: 0x1467080 Offset: 0x1465680 VA: 0x181467080 Slot: 12
	public virtual void Clear() { }

	// RVA: 0x14671D0 Offset: 0x14657D0 VA: 0x1814671D0 Slot: 13
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x14674D0 Offset: 0x1465AD0 VA: 0x1814674D0 Slot: 14
	public virtual void Enqueue(object obj) { }

	// RVA: 0x14676D0 Offset: 0x1465CD0 VA: 0x1814676D0 Slot: 15
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x14673D0 Offset: 0x14659D0 VA: 0x1814673D0 Slot: 16
	public virtual object Dequeue() { }

	// RVA: 0x1467780 Offset: 0x1465D80 VA: 0x181467780 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x1467690 Offset: 0x1465C90 VA: 0x181467690
	internal object GetElement(int i) { }

	// RVA: 0x1467920 Offset: 0x1465F20 VA: 0x181467920 Slot: 18
	public virtual object[] ToArray() { }

	// RVA: 0x1467840 Offset: 0x1465E40 VA: 0x181467840
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

	// RVA: 0x1466F30 Offset: 0x1465530 VA: 0x181466F30
	internal void .ctor(Queue q) { }

	// RVA: 0xD71020 Offset: 0xD6F620 VA: 0x180D71020 Slot: 7
	public object Clone() { }

	// RVA: 0x1466D70 Offset: 0x1465370 VA: 0x181466D70 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1466FB0 Offset: 0x14655B0 VA: 0x181466FB0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1466E80 Offset: 0x1465480 VA: 0x181466E80 Slot: 10
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

	// RVA: 0x13481C0 Offset: 0x13467C0 VA: 0x1813481C0
	public void .ctor(string userName, string password) { }

	// RVA: 0x13482C0 Offset: 0x13468C0 VA: 0x1813482C0
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_UserName() { }

	// RVA: 0x1348430 Offset: 0x1346A30 VA: 0x181348430
	public void set_UserName(string value) { }

	// RVA: 0x13481B0 Offset: 0x13467B0 VA: 0x1813481B0
	public string get_Password() { }

	// RVA: 0x1348400 Offset: 0x1346A00 VA: 0x181348400
	public void set_Password(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Domain() { }

	// RVA: 0x13483A0 Offset: 0x13469A0 VA: 0x1813483A0
	public void set_Domain(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string InternalGetUserName() { }

	// RVA: 0x13481B0 Offset: 0x13467B0 VA: 0x1813481B0
	internal string InternalGetPassword() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string InternalGetDomain() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

internal class NetRes // TypeDefIndex: 2921
{	// Methods

	// RVA: 0x1348100 Offset: 0x1346700 VA: 0x181348100
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x13480A0 Offset: 0x13466A0 VA: 0x1813480A0
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

	// RVA: 0xFFB1F0 Offset: 0xFF97F0 VA: 0x180FFB1F0
	public void .ctor(Socket socket) { }

	// RVA: 0xFFB120 Offset: 0xFF9720 VA: 0x180FFB120
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xFFB2B0 Offset: 0xFF98B0 VA: 0x180FFB2B0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xFFB3A0 Offset: 0xFF99A0 VA: 0x180FFB3A0 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0xFFB430 Offset: 0xFF9A30 VA: 0x180FFB430 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0xFFB2C0 Offset: 0xFF98C0 VA: 0x180FFB2C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFFB330 Offset: 0xFF9930 VA: 0x180FFB330 Slot: 11
	public override long get_Position() { }

	// RVA: 0xFFB4C0 Offset: 0xFF9AC0 VA: 0x180FFB4C0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xFFAC90 Offset: 0xFF9290 VA: 0x180FFAC90 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xFFA770 Offset: 0xFF8D70 VA: 0x180FFA770
	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0xFFA8E0 Offset: 0xFF8EE0 VA: 0x180FFA8E0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	// RVA: 0xFFAD70 Offset: 0xFF9370 VA: 0x180FFAD70 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFFA090 Offset: 0xFF8690 VA: 0x180FFA090 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFFA6D0 Offset: 0xFF8CD0 VA: 0x180FFA6D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xFF9910 Offset: 0xFF7F10 VA: 0x180FF9910 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFFA170 Offset: 0xFF8770 VA: 0x180FFA170 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFF9CD0 Offset: 0xFF82D0 VA: 0x180FF9CD0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFFA420 Offset: 0xFF8A20 VA: 0x180FFA420 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0xFFAD00 Offset: 0xFF9300 VA: 0x180FFAD00 Slot: 26
	public override void SetLength(long value) { }

}

public class NetworkInformationException : Win32Exception // TypeDefIndex: 3074
{	// Methods

	// RVA: 0x1348490 Offset: 0x1346A90 VA: 0x181348490
	public void .ctor() { }

	// RVA: 0x1348520 Offset: 0x1346B20 VA: 0x181348520
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
	|-RVA: 0x19589B0 Offset: 0x1956FB0 VA: 0x1819589B0
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
	|-RVA: 0x1958AF0 Offset: 0x19570F0 VA: 0x181958AF0
	|-Queue<RCon.Command>..ctor
	|
	|-RVA: 0x1958BE0 Offset: 0x19571E0 VA: 0x181958BE0
	|-Queue<int>..ctor
	|
	|-RVA: 0x1958EB0 Offset: 0x19574B0 VA: 0x181958EB0
	|-Queue<IntPtr>..ctor
	|
	|-RVA: 0x1958FA0 Offset: 0x19575A0 VA: 0x181958FA0
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<Renderer>..ctor
	|
	|-RVA: 0x1958DC0 Offset: 0x19573C0 VA: 0x181958DC0
	|-Queue<ulong>..ctor
	|
	|-RVA: 0x1958A00 Offset: 0x1957000 VA: 0x181958A00
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|
	|-RVA: 0x1958CD0 Offset: 0x19572D0 VA: 0x181958CD0
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
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
	|-RVA: 0x19585C0 Offset: 0x1956BC0 VA: 0x1819585C0
	|-Queue<RCon.Command>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19584E0 Offset: 0x1956AE0 VA: 0x1819584E0
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958550 Offset: 0x1956B50 VA: 0x181958550
	|-Queue<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19586A0 Offset: 0x1956CA0 VA: 0x1819586A0
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958630 Offset: 0x1956C30 VA: 0x181958630
	|-Queue<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958400 Offset: 0x1956A00 VA: 0x181958400
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958470 Offset: 0x1956A70 VA: 0x181958470
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956150 Offset: 0x1954750 VA: 0x181956150
	|-Queue<BaseEntity>.Clear
	|-Queue<RCon.Command>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|
	|-RVA: 0x1956130 Offset: 0x1954730 VA: 0x181956130
	|-Queue<int>.Clear
	|-Queue<IntPtr>.Clear
	|-Queue<ulong>.Clear
	|-Queue<AsyncGPUReadbackRequest>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957EE0 Offset: 0x19564E0 VA: 0x181957EE0
	|-Queue<RCon.Command>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957C50 Offset: 0x1956250 VA: 0x181957C50
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19574A0 Offset: 0x1955AA0 VA: 0x1819574A0
	|-Queue<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957210 Offset: 0x1955810 VA: 0x181957210
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19579C0 Offset: 0x1955FC0 VA: 0x1819579C0
	|-Queue<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1958170 Offset: 0x1956770 VA: 0x181958170
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957730 Offset: 0x1955D30 VA: 0x181957730
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956720 Offset: 0x1954D20 VA: 0x181956720
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
	|-RVA: 0x1956970 Offset: 0x1954F70 VA: 0x181956970
	|-Queue<RCon.Command>.Enqueue
	|
	|-RVA: 0x1956A60 Offset: 0x1955060 VA: 0x181956A60
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x19567F0 Offset: 0x1954DF0 VA: 0x1819567F0
	|-Queue<IntPtr>.Enqueue
	|-Queue<ulong>.Enqueue
	|
	|-RVA: 0x1956660 Offset: 0x1954C60 VA: 0x181956660
	|-Queue<AsyncGPUReadbackRequest>.Enqueue
	|
	|-RVA: 0x19568A0 Offset: 0x1954EA0 VA: 0x1819568A0
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956B10 Offset: 0x1955110 VA: 0x181956B10
	|-Queue<string>.GetEnumerator
	|-Queue<IntPtr>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|-Queue<ulong>.GetEnumerator
	|
	|-RVA: 0x1956BC0 Offset: 0x19551C0 VA: 0x181956BC0
	|-Queue<RCon.Command>.GetEnumerator
	|
	|-RVA: 0x1956C30 Offset: 0x1955230 VA: 0x181956C30
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x1956B60 Offset: 0x1955160 VA: 0x181956B60
	|-Queue<AsyncGPUReadbackRequest>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957140 Offset: 0x1955740 VA: 0x181957140
	|-Queue<RCon.Command>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x19570A0 Offset: 0x19556A0 VA: 0x1819570A0
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1957000 Offset: 0x1955600 VA: 0x181957000
	|-Queue<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1956F60 Offset: 0x1955560 VA: 0x181956F60
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957140 Offset: 0x1955740 VA: 0x181957140
	|-Queue<RCon.Command>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x19570A0 Offset: 0x19556A0 VA: 0x1819570A0
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1957000 Offset: 0x1955600 VA: 0x181957000
	|-Queue<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1956F60 Offset: 0x1955560 VA: 0x181956F60
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956290 Offset: 0x1954890 VA: 0x181956290
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
	|-RVA: 0x19563F0 Offset: 0x19549F0 VA: 0x1819563F0
	|-Queue<RCon.Command>.Dequeue
	|
	|-RVA: 0x1956520 Offset: 0x1954B20 VA: 0x181956520
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x1956350 Offset: 0x1954950 VA: 0x181956350
	|-Queue<IntPtr>.Dequeue
	|-Queue<ulong>.Dequeue
	|
	|-RVA: 0x19565B0 Offset: 0x1954BB0 VA: 0x1819565B0
	|-Queue<AsyncGPUReadbackRequest>.Dequeue
	|
	|-RVA: 0x19561C0 Offset: 0x19547C0 VA: 0x1819561C0
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956D90 Offset: 0x1955390 VA: 0x181956D90
	|-Queue<ulong>.Peek
	|-Queue<IntPtr>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x1956D10 Offset: 0x1955310 VA: 0x181956D10
	|-Queue<AsyncGPUReadbackRequest>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|
	|-RVA: 0x1956DF0 Offset: 0x19553F0 VA: 0x181956DF0
	|-Queue<RCon.Command>.Peek
	|
	|-RVA: 0x1956CB0 Offset: 0x19552B0 VA: 0x181956CB0
	|-Queue<int>.Peek
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956E80 Offset: 0x1955480 VA: 0x181956E80
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
	|-RVA: 0x1956C80 Offset: 0x1955280 VA: 0x181956C80
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
	|-RVA: 0x1958770 Offset: 0x1956D70 VA: 0x181958770
	|-Queue<RCon.Command>.ThrowForEmptyQueue
	|
	|-RVA: 0x19587D0 Offset: 0x1956DD0 VA: 0x1819587D0
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958710 Offset: 0x1956D10 VA: 0x181958710
	|-Queue<IntPtr>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958890 Offset: 0x1956E90 VA: 0x181958890
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x19588F0 Offset: 0x1956EF0 VA: 0x1819588F0
	|-Queue<ulong>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958830 Offset: 0x1956E30 VA: 0x181958830
	|-Queue<AsyncGPUReadbackRequest>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958950 Offset: 0x1956F50 VA: 0x181958950
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
	|-RVA: 0x220680 Offset: 0x21FA80 VA: 0x180220680
	|-Queue.Enumerator<RCon.Command>..ctor
	|
	|-RVA: 0x2207E0 Offset: 0x21FBE0 VA: 0x1802207E0
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x220790 Offset: 0x21FB90 VA: 0x180220790
	|-Queue.Enumerator<IntPtr>..ctor
	|-Queue.Enumerator<object>..ctor
	|-Queue.Enumerator<ulong>..ctor
	|
	|-RVA: 0x220630 Offset: 0x21FA30 VA: 0x180220630
	|-Queue.Enumerator<AsyncGPUReadbackRequest>..ctor
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21EC00 Offset: 0x21E000 VA: 0x18021EC00
	|-Queue.Enumerator<RCon.Command>.Dispose
	|
	|-RVA: 0x21EBF0 Offset: 0x21DFF0 VA: 0x18021EBF0
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x21EB80 Offset: 0x21DF80 VA: 0x18021EB80
	|-Queue.Enumerator<IntPtr>.Dispose
	|-Queue.Enumerator<object>.Dispose
	|-Queue.Enumerator<string>.Dispose
	|-Queue.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x21EB30 Offset: 0x21DF30 VA: 0x18021EB30
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.Dispose
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21EF20 Offset: 0x21E320 VA: 0x18021EF20
	|-Queue.Enumerator<RCon.Command>.MoveNext
	|
	|-RVA: 0x21EE40 Offset: 0x21E240 VA: 0x18021EE40
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21F0E0 Offset: 0x21E4E0 VA: 0x18021F0E0
	|-Queue.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x21EC20 Offset: 0x21E020 VA: 0x18021EC20
	|-Queue.Enumerator<object>.MoveNext
	|-Queue.Enumerator<string>.MoveNext
	|
	|-RVA: 0x21F220 Offset: 0x21E620 VA: 0x18021F220
	|-Queue.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21ED50 Offset: 0x21E150 VA: 0x18021ED50
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.MoveNext
	|
	|-RVA: 0x21F300 Offset: 0x21E700 VA: 0x18021F300
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220840 Offset: 0x21FC40 VA: 0x180220840
	|-Queue.Enumerator<string>.get_Current
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x220A30 Offset: 0x21FE30 VA: 0x180220A30
	|-Queue.Enumerator<RCon.Command>.get_Current
	|
	|-RVA: 0x220990 Offset: 0x21FD90 VA: 0x180220990
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x2208D0 Offset: 0x21FCD0 VA: 0x1802208D0
	|-Queue.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x220880 Offset: 0x21FC80 VA: 0x180220880
	|-Queue.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x220910 Offset: 0x21FD10 VA: 0x180220910
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.get_Current
	|
	|-RVA: 0x220950 Offset: 0x21FD50 VA: 0x180220950
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220520 Offset: 0x21F920 VA: 0x180220520
	|-Queue.Enumerator<RCon.Command>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2204F0 Offset: 0x21F8F0 VA: 0x1802204F0
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220550 Offset: 0x21F950 VA: 0x180220550
	|-Queue.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220510 Offset: 0x21F910 VA: 0x180220510
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220540 Offset: 0x21F940 VA: 0x180220540
	|-Queue.Enumerator<ulong>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220530 Offset: 0x21F930 VA: 0x180220530
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220500 Offset: 0x21F900 VA: 0x180220500
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220420 Offset: 0x21F820 VA: 0x180220420
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2200E0 Offset: 0x21F4E0 VA: 0x1802200E0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2202B0 Offset: 0x21F6B0 VA: 0x1802202B0
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220240 Offset: 0x21F640 VA: 0x180220240
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220190 Offset: 0x21F590 VA: 0x180220190
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220030 Offset: 0x21F430 VA: 0x180220030
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220370 Offset: 0x21F770 VA: 0x180220370
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21F9C0 Offset: 0x21EDC0 VA: 0x18021F9C0
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FAD0 Offset: 0x21EED0 VA: 0x18021FAD0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FA50 Offset: 0x21EE50 VA: 0x18021FA50
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FBD0 Offset: 0x21EFD0 VA: 0x18021FBD0
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FD90 Offset: 0x21F190 VA: 0x18021FD90
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FB50 Offset: 0x21EF50 VA: 0x18021FB50
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FCB0 Offset: 0x21F0B0 VA: 0x18021FCB0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	*/

}

public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
{
// Namespace: System.Net.Configuration
[ConfigurationCollectionAttribute] // RVA: 0xC1090 Offset: 0xC0490 VA: 0x1800C1090
[DefaultMemberAttribute] // RVA: 0xC1090 Offset: 0xC0490 VA: 0x1800C1090
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
	// Methods

	// RVA: 0x1520850 Offset: 0x151EE50 VA: 0x181520850
	public void .ctor() { }

}

public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 3171
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1520880 Offset: 0x151EE80 VA: 0x181520880
	public void .ctor() { }

	// RVA: 0x15208B0 Offset: 0x151EEB0 VA: 0x1815208B0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 3173
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1536A40 Offset: 0x1535040 VA: 0x181536A40
	public void .ctor() { }

	// RVA: 0x1536A70 Offset: 0x1535070 VA: 0x181536A70 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 3176
{	// Methods

	// RVA: 0x15368C0 Offset: 0x1534EC0 VA: 0x1815368C0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private IConnectionManager <Interface>k__BackingField; // 0x10
	public Connection Connection; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ConnectionInfo <ConnectionInfo>k__BackingField; // 0x20
	public bool Connected; // 0x2D8
	public bool Connecting; // 0x2D9

	// Properties
	public IConnectionManager Interface { get; set; }
	internal ConnectionInfo ConnectionInfo { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IConnectionManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Interface(IConnectionManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x136EDE0 Offset: 0x136D3E0 VA: 0x18136EDE0
	internal void set_ConnectionInfo(ConnectionInfo value) { }

	// RVA: 0x136E440 Offset: 0x136CA40 VA: 0x18136E440
	public void Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x136EDB0 Offset: 0x136D3B0 VA: 0x18136EDB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x136E640 Offset: 0x136CC40 VA: 0x18136E640 Slot: 4
	public virtual void OnConnectionChanged(ConnectionInfo info) { }

	// RVA: 0x136E550 Offset: 0x136CB50 VA: 0x18136E550 Slot: 5
	public virtual void OnConnecting(ConnectionInfo info) { }

	// RVA: 0x136E460 Offset: 0x136CA60 VA: 0x18136E460 Slot: 6
	public virtual void OnConnected(ConnectionInfo info) { }

	// RVA: 0x136E930 Offset: 0x136CF30 VA: 0x18136E930 Slot: 7
	public virtual void OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x136EBE0 Offset: 0x136D1E0 VA: 0x18136EBE0
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0x136EB10 Offset: 0x136D110 VA: 0x18136EB10
	internal void ReceiveMessage(ref NetMsg* msg) { }

	// RVA: 0x136EA20 Offset: 0x136D020 VA: 0x18136EA20 Slot: 8
	public virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x136EDD0 Offset: 0x136D3D0 VA: 0x18136EDD0
	public void .ctor() { }

}

internal sealed class NetDebugFunc : MulticastDelegate // TypeDefIndex: 5179
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE2860 Offset: 0xDE0E60 VA: 0x180DE2860 Slot: 12
	public virtual void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg) { }

	// RVA: 0xDE27D0 Offset: 0xDE0DD0 VA: 0x180DE27D0 Slot: 13
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

	// RVA: 0x1EC040 Offset: 0x1EB440 VA: 0x1801EC040 Slot: 3
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

	// RVA: 0x1374CF0 Offset: 0x13732F0 VA: 0x181374CF0
	internal static extern void InternalClear(ref NetAddress self) { }

	// RVA: 0x1374D70 Offset: 0x1373370 VA: 0x181374D70
	internal static extern void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort) { }

	// RVA: 0x1374E10 Offset: 0x1373410 VA: 0x181374E10
	internal static extern void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x1374840 Offset: 0x1372E40 VA: 0x181374840
	public static NetAddress AnyIp(ushort port) { }

	// RVA: 0x13748F0 Offset: 0x1372EF0 VA: 0x1813748F0
	public static NetAddress From(string addrStr, ushort port) { }

	// RVA: 0x1374B10 Offset: 0x1373110 VA: 0x181374B10
	public static NetAddress From(IPAddress address, ushort port) { }

	// RVA: 0x13750A0 Offset: 0x13736A0 VA: 0x1813750A0
	public static NetAddress get_Cleared() { }

	// RVA: 0x1EC030 Offset: 0x1EB430 VA: 0x1801EC030 Slot: 3
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

	// RVA: 0x1375130 Offset: 0x1373730 VA: 0x181375130
	internal static extern void InternalRelease(NetMsg* self) { }

}

public struct Connection : IEquatable<Connection> // TypeDefIndex: 5543
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private uint <Id>k__BackingField; // 0x0

	// Properties
	public uint Id { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public uint get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_Id(uint value) { }

	// RVA: 0x1E50E0 Offset: 0x1E44E0 VA: 0x1801E50E0 Slot: 4
	public bool Equals(Connection other) { }

	// RVA: 0x1E50F0 Offset: 0x1E44F0 VA: 0x1801E50F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E5170 Offset: 0x1E4570 VA: 0x1801E5170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D31C0 Offset: 0x1D25C0 VA: 0x1801D31C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static Connection op_Implicit(uint value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Implicit(Connection value) { }

	// RVA: 0x1E4F30 Offset: 0x1E4330 VA: 0x1801E4F30
	public Result Accept() { }

	// RVA: 0x1E4FA0 Offset: 0x1E43A0 VA: 0x1801E4FA0
	public bool Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x1E5230 Offset: 0x1E4630 VA: 0x1801E5230
	public Result SendMessage(IntPtr ptr, int size, SendType sendType = 8, ushort laneIndex = 0) { }

	// RVA: 0x1E5050 Offset: 0x1E4450 VA: 0x1801E5050
	public string DetailedStatus() { }

	// RVA: 0x1E5190 Offset: 0x1E4590 VA: 0x1801E5190
	public ConnectionStatus QuickStatus() { }

	// RVA: 0x1E4FB0 Offset: 0x1E43B0 VA: 0x1801E4FB0
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

	// RVA: 0xFD450 Offset: 0xFC850 VA: 0x1800FD450
	public ConnectionState get_State() { }

	// RVA: 0x1E4850 Offset: 0x1E3C50 VA: 0x1801E4850
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

	// RVA: 0x14B860 Offset: 0x14AC60 VA: 0x18014B860
	public int get_Ping() { }

	// RVA: 0x1E4C90 Offset: 0x1E4090 VA: 0x1801E4C90
	public float get_OutBytesPerSec() { }

	// RVA: 0x1E4C80 Offset: 0x1E4080 VA: 0x1801E4C80
	public float get_InBytesPerSec() { }

	// RVA: 0x117180 Offset: 0x116580 VA: 0x180117180
	public float get_ConnectionQualityLocal() { }

	// RVA: 0x1E4CA0 Offset: 0x1E40A0 VA: 0x1801E4CA0
	public int get_PendingUnreliable() { }

	// RVA: 0xF3F50 Offset: 0xF3350 VA: 0x1800F3F50
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

	// RVA: 0x220E610 Offset: 0x220CC10 VA: 0x18220E610
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_RecordFilename() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0
	public int get_RecordFilesize() { }

	// RVA: 0x220DF00 Offset: 0x220C500 VA: 0x18220DF00
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x220E010 Offset: 0x220C610 VA: 0x18220E010
	public void StopRecording() { }

	// RVA: 0x795BE0 Offset: 0x7941E0 VA: 0x180795BE0
	public bool get_IsRecording() { }

	// RVA: 0x220DA00 Offset: 0x220C000 VA: 0x18220DA00
	public void RecordPacket(byte packetId, IProto proto) { }

	// RVA: 0x220DC80 Offset: 0x220C280 VA: 0x18220DC80
	public void RecordPacket(Stream stream) { }

	// RVA: 0x220D960 Offset: 0x220BF60 VA: 0x18220D960 Slot: 4
	public virtual void OnDisconnected() { }

	// RVA: 0x220E690 Offset: 0x220CC90 VA: 0x18220E690
	public bool get_isAuthenticated() { }

	// RVA: 0x220DE80 Offset: 0x220C480 VA: 0x18220DE80
	public void ResetPacketsPerSecond() { }

	// RVA: 0x220D7F0 Offset: 0x220BDF0 VA: 0x18220D7F0
	public void AddPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220D7A0 Offset: 0x220BDA0 VA: 0x18220D7A0
	public void AddPacketsPerSecond(int index = 0) { }

	// RVA: 0x220D8A0 Offset: 0x220BEA0 VA: 0x18220D8A0
	public ulong GetPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220D840 Offset: 0x220BE40 VA: 0x18220D840
	public ulong GetPacketsPerSecond(int index = 0) { }

	// RVA: 0x220D900 Offset: 0x220BF00 VA: 0x18220D900
	public float GetSecondsConnected() { }

	// RVA: 0x220E3D0 Offset: 0x220C9D0 VA: 0x18220E3D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x220E4B0 Offset: 0x220CAB0 VA: 0x18220E4B0
	public void .ctor() { }

	// RVA: 0x220E450 Offset: 0x220CA50 VA: 0x18220E450
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

	// RVA: 0x220D000 Offset: 0x220B600 VA: 0x18220D000
	public void Set(string k, string v) { }

	// RVA: 0x220CF80 Offset: 0x220B580 VA: 0x18220CF80
	public string GetString(string k, string def = "") { }

	// RVA: 0x220CE20 Offset: 0x220B420 VA: 0x18220CE20
	public float GetFloat(string k, float def = 0) { }

	// RVA: 0x220CED0 Offset: 0x220B4D0 VA: 0x18220CED0
	public int GetInt(string k, int def = 0) { }

	// RVA: 0x220CD20 Offset: 0x220B320 VA: 0x18220CD20
	public bool GetBool(string k, bool def = False) { }

	// RVA: 0x220D070 Offset: 0x220B670 VA: 0x18220D070
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

	// RVA: 0x220FFA0 Offset: 0x220E5A0 VA: 0x18220FFA0
	public MemoryStream GetStreamForDecryption() { }

	// RVA: 0x2210430 Offset: 0x220EA30 VA: 0x182210430
	public bool Start(IntPtr data, int length) { }

	// RVA: 0x2210D40 Offset: 0x220F340 VA: 0x182210D40
	public int get_Unread() { }

	// RVA: 0x2210940 Offset: 0x220EF40 VA: 0x182210940
	public string String(int maxLength = 256) { }

	// RVA: 0x2210830 Offset: 0x220EE30 VA: 0x182210830
	public string StringMultiLine(int maxLength = 2048) { }

	// RVA: 0x22105A0 Offset: 0x220EBA0 VA: 0x1822105A0
	private string StringInternal(int maxLength, bool allowNewLine) { }

	// RVA: 0x2210840 Offset: 0x220EE40 VA: 0x182210840
	public string StringRaw(uint maxLength = 1048576) { }

	// RVA: 0x2210950 Offset: 0x220EF50 VA: 0x182210950
	public bool TemporaryBytesWithSize(out byte[] buffer, out int size) { }

	// RVA: 0x220FED0 Offset: 0x220E4D0 VA: 0x18220FED0
	public uint EntityID() { }

	// RVA: 0x220FED0 Offset: 0x220E4D0 VA: 0x18220FED0
	public uint GroupID() { }

	// RVA: 0x220FD70 Offset: 0x220E370 VA: 0x18220FD70
	public int BytesWithSize(byte[] buffer, uint maxLength = 4294967295) { }

	// RVA: 0x220FCA0 Offset: 0x220E2A0 VA: 0x18220FCA0
	public byte[] BytesWithSize(uint maxSize = 10485760) { }

	// RVA: 0x2210280 Offset: 0x220E880 VA: 0x182210280 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xC15040 Offset: 0xC13640 VA: 0x180C15040 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2210180 Offset: 0x220E780 VA: 0x182210180
	public byte PacketID() { }

	// RVA: 0x220FC60 Offset: 0x220E260 VA: 0x18220FC60
	public bool Bit() { }

	// RVA: 0x2210180 Offset: 0x220E780 VA: 0x182210180
	public byte UInt8() { }

	// RVA: 0x2210AC0 Offset: 0x220F0C0 VA: 0x182210AC0
	public ushort UInt16() { }

	// RVA: 0x220FED0 Offset: 0x220E4D0 VA: 0x18220FED0
	public uint UInt32() { }

	// RVA: 0x2210B00 Offset: 0x220F100 VA: 0x182210B00
	public ulong UInt64() { }

	// RVA: 0x2210140 Offset: 0x220E740 VA: 0x182210140
	public sbyte Int8() { }

	// RVA: 0x2210080 Offset: 0x220E680 VA: 0x182210080
	public short Int16() { }

	// RVA: 0x22100C0 Offset: 0x220E6C0 VA: 0x1822100C0
	public int Int32() { }

	// RVA: 0x2210100 Offset: 0x220E700 VA: 0x182210100
	public long Int64() { }

	// RVA: 0x220FF10 Offset: 0x220E510 VA: 0x18220FF10
	public float Float() { }

	// RVA: 0x220FE90 Offset: 0x220E490 VA: 0x18220FE90
	public double Double() { }

	// RVA: 0x2210B40 Offset: 0x220F140 VA: 0x182210B40
	public Vector3 Vector3() { }

	// RVA: 0x22101C0 Offset: 0x220E7C0 VA: 0x1822101C0
	public Quaternion Quaternion() { }

	// RVA: 0x2210220 Offset: 0x220E820 VA: 0x182210220
	public Ray Ray() { }

	// RVA: 0x220FE30 Offset: 0x220E430 VA: 0x18220FE30
	public Color Color() { }

	// RVA: 0x2210320 Offset: 0x220E920 VA: 0x182210320 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21C0E40 Offset: 0x21BF440 VA: 0x1821C0E40 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x22103B0 Offset: 0x220E9B0 VA: 0x1822103B0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1
	public T Read<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D2900 Offset: 0x5D0F00 VA: 0x1805D2900
	|-NetRead.Read<byte>
	|-NetRead.Read<sbyte>
	|
	|-RVA: 0x5D29D0 Offset: 0x5D0FD0 VA: 0x1805D29D0
	|-NetRead.Read<double>
	|
	|-RVA: 0x5D2A30 Offset: 0x5D1030 VA: 0x1805D2A30
	|-NetRead.Read<short>
	|-NetRead.Read<ushort>
	|
	|-RVA: 0x5D2A90 Offset: 0x5D1090 VA: 0x1805D2A90
	|-NetRead.Read<int>
	|-NetRead.Read<uint>
	|
	|-RVA: 0x5D2AF0 Offset: 0x5D10F0 VA: 0x1805D2AF0
	|-NetRead.Read<long>
	|-NetRead.Read<ulong>
	|
	|-RVA: 0x5D2BE0 Offset: 0x5D11E0 VA: 0x1805D2BE0
	|-NetRead.Read<float>
	|
	|-RVA: 0x5D2960 Offset: 0x5D0F60 VA: 0x1805D2960
	|-NetRead.Read<Color>
	|-NetRead.Read<Quaternion>
	|
	|-RVA: 0x5D2B50 Offset: 0x5D1150 VA: 0x1805D2B50
	|-NetRead.Read<Ray>
	|
	|-RVA: 0x5D2C40 Offset: 0x5D1240 VA: 0x1805D2C40
	|-NetRead.Read<Vector3>
	*/

	// RVA: 0x220FF50 Offset: 0x220E550 VA: 0x18220FF50 Slot: 18
	public override void Flush() { }

	// RVA: 0x2210BF0 Offset: 0x220F1F0 VA: 0x182210BF0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2210BA0 Offset: 0x220F1A0 VA: 0x182210BA0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2210CC0 Offset: 0x220F2C0 VA: 0x182210CC0
	public void .ctor() { }

	// RVA: 0x2210C40 Offset: 0x220F240 VA: 0x182210C40
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

	// RVA: 0x2211FD0 Offset: 0x22105D0 VA: 0x182211FD0
	public void .ctor(BaseNetwork netwrite) { }

	// RVA: 0x2211970 Offset: 0x220FF70 VA: 0x182211970
	public void Shutdown() { }

	// RVA: 0x22119F0 Offset: 0x220FFF0 VA: 0x1822119F0
	public bool Start() { }

	// RVA: 0x22118D0 Offset: 0x220FED0 VA: 0x1822118D0
	public void Send(SendInfo info) { }

	// RVA: 0x2211620 Offset: 0x220FC20 VA: 0x182211620
	public void PacketID(Message.Type val) { }

	// RVA: 0x2211D90 Offset: 0x2210390 VA: 0x182211D90
	public void UInt8(byte val) { }

	// RVA: 0x2211CA0 Offset: 0x22102A0 VA: 0x182211CA0
	public void UInt16(ushort val) { }

	// RVA: 0x2211CF0 Offset: 0x22102F0 VA: 0x182211CF0
	public void UInt32(uint val) { }

	// RVA: 0x2211D40 Offset: 0x2210340 VA: 0x182211D40
	public void UInt64(ulong val) { }

	// RVA: 0x22115D0 Offset: 0x220FBD0 VA: 0x1822115D0
	public void Int8(sbyte val) { }

	// RVA: 0x22114E0 Offset: 0x220FAE0 VA: 0x1822114E0
	public void Int16(short val) { }

	// RVA: 0x2211530 Offset: 0x220FB30 VA: 0x182211530
	public void Int32(int val) { }

	// RVA: 0x2211580 Offset: 0x220FB80 VA: 0x182211580
	public void Int64(long val) { }

	// RVA: 0x2210D90 Offset: 0x220F390 VA: 0x182210D90
	public void Bool(bool val) { }

	// RVA: 0x2211490 Offset: 0x220FA90 VA: 0x182211490
	public void Float(float val) { }

	// RVA: 0x2211170 Offset: 0x220F770 VA: 0x182211170
	public void Double(double val) { }

	// RVA: 0x2211020 Offset: 0x220F620 VA: 0x182211020
	public void Bytes(byte[] val) { }

	// RVA: 0x2211A00 Offset: 0x2210000 VA: 0x182211A00
	public void String(string val) { }

	// RVA: 0x2211DE0 Offset: 0x22103E0 VA: 0x182211DE0
	public void Vector3(in Vector3 obj) { }

	// RVA: 0x2211060 Offset: 0x220F660 VA: 0x182211060
	public void Quaternion(in Quaternion obj) { }

	// RVA: 0x2211670 Offset: 0x220FC70 VA: 0x182211670
	public void Ray(in Ray obj) { }

	// RVA: 0x2211060 Offset: 0x220F660 VA: 0x182211060
	public void Color(in Color obj) { }

	// RVA: 0x2211440 Offset: 0x220FA40 VA: 0x182211440
	public void EntityID(uint id) { }

	// RVA: 0x2211440 Offset: 0x220FA40 VA: 0x182211440
	public void GroupID(uint id) { }

	// RVA: 0x2210DF0 Offset: 0x220F3F0 VA: 0x182210DF0
	public void BytesWithSize(MemoryStream val) { }

	// RVA: 0x2210EB0 Offset: 0x220F4B0 VA: 0x182210EB0
	public void BytesWithSize(byte[] b) { }

	// RVA: 0x2210ED0 Offset: 0x220F4D0 VA: 0x182210ED0
	public void BytesWithSize(byte[] b, int length) { }

	// RVA: -1 Offset: -1
	private void Write<T>(in T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574F20 Offset: 0x1573520 VA: 0x181574F20
	|-NetWrite.Write<byte>
	|-NetWrite.Write<sbyte>
	|
	|-RVA: 0x1574F90 Offset: 0x1573590 VA: 0x181574F90
	|-NetWrite.Write<double>
	|-NetWrite.Write<long>
	|-NetWrite.Write<ulong>
	|
	|-RVA: 0x1575000 Offset: 0x1573600 VA: 0x181575000
	|-NetWrite.Write<short>
	|-NetWrite.Write<ushort>
	|
	|-RVA: 0x1575070 Offset: 0x1573670 VA: 0x181575070
	|-NetWrite.Write<int>
	|-NetWrite.Write<float>
	|-NetWrite.Write<uint>
	*/

	// RVA: 0x22111C0 Offset: 0x220F7C0 VA: 0x1822111C0
	private void EnsureCapacity(int spaceRequired) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 31
	public override byte[] GetBuffer() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x22120C0 Offset: 0x22106C0 VA: 0x1822120C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x22120D0 Offset: 0x22106D0 VA: 0x1822120D0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22120E0 Offset: 0x22106E0 VA: 0x1822120E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x2211770 Offset: 0x220FD70 VA: 0x182211770 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2211720 Offset: 0x220FD20 VA: 0x182211720 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2211F00 Offset: 0x2210500 VA: 0x182211F00 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2211EB0 Offset: 0x22104B0 VA: 0x182211EB0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2211830 Offset: 0x220FE30 VA: 0x182211830 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2211920 Offset: 0x220FF20 VA: 0x182211920 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2211F70 Offset: 0x2210570 VA: 0x182211F70
	private static void .cctor() { }

}

public class Networkable : Pool.IPooled // TypeDefIndex: 6700
{	// Fields
	public uint ID; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Connection get_connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_connection(Connection value) { }

	// RVA: 0x2212330 Offset: 0x2210930 VA: 0x182212330
	public void Destroy() { }

	// RVA: 0x2212360 Offset: 0x2210960 VA: 0x182212360 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2212680 Offset: 0x2210C80 VA: 0x182212680
	public void StartSubscriber() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void OnConnected(Connection c) { }

	// RVA: 0x22123E0 Offset: 0x22109E0 VA: 0x1822123E0
	public void OnDisconnected() { }

	// RVA: 0x22122A0 Offset: 0x22108A0 VA: 0x1822122A0
	public void CloseSubscriber() { }

	// RVA: 0x2213040 Offset: 0x2211640 VA: 0x182213040
	public bool UpdateGroups(Vector3 position) { }

	// RVA: 0x22127C0 Offset: 0x2210DC0 VA: 0x1822127C0
	public bool SwitchGroup(Group newGroup) { }

	// RVA: 0x2212410 Offset: 0x2210A10 VA: 0x182212410
	internal void OnGroupTransition(Group oldGroup) { }

	// RVA: 0x22125A0 Offset: 0x2210BA0 VA: 0x1822125A0
	internal void OnSubscriptionChange() { }

	// RVA: 0x2212ED0 Offset: 0x22114D0 VA: 0x182212ED0
	public bool SwitchSecondaryGroup(Group newGroup) { }

	// RVA: 0x2212100 Offset: 0x2210700 VA: 0x182212100
	private void AddVisibleFromNear(Group additionalGroup, List<Group> groupsVisible) { }

	// RVA: 0x2213480 Offset: 0x2211A80 VA: 0x182213480
	public bool UpdateSubscriptions(int removeLimit, int addLimit) { }

	// RVA: 0x22131E0 Offset: 0x22117E0 VA: 0x1822131E0
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

	// RVA: 0x2207D10 Offset: 0x2206310 VA: 0x182207D10
	public void .ctor(Stream stream) { }

	// RVA: 0xBA48E0 Offset: 0xBA2EE0 VA: 0x180BA48E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA4910 Offset: 0xBA2F10 VA: 0x180BA4910 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA4940 Offset: 0xBA2F40 VA: 0x180BA4940 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA4970 Offset: 0xBA2F70 VA: 0x180BA4970 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA49D0 Offset: 0xBA2FD0 VA: 0x180BA49D0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xBA4740 Offset: 0xBA2D40 VA: 0x180BA4740 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4770 Offset: 0xBA2D70 VA: 0x180BA4770 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA47A0 Offset: 0xBA2DA0 VA: 0x180BA47A0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2207CB0 Offset: 0x22062B0 VA: 0x182207CB0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4430 Offset: 0xBA2A30 VA: 0x180BA4430 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22078F0 Offset: 0x2205EF0 VA: 0x1822078F0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA45D0 Offset: 0xBA2BD0 VA: 0x180BA45D0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2207B70 Offset: 0x2206170 VA: 0x182207B70 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA46E0 Offset: 0xBA2CE0 VA: 0x180BA46E0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1634E30 Offset: 0x1633430 VA: 0x181634E30 Slot: 16
	public override void Close() { }

	// RVA: 0x2207B20 Offset: 0x2206120 VA: 0x182207B20 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2207790 Offset: 0x2205D90 VA: 0x182207790
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

	// RVA: 0x220C660 Offset: 0x220AC60 VA: 0x18220C660
	public void .ctor(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

}

private class QueuedStream.QueuedWriteResult : IAsyncResult // TypeDefIndex: 6918
{	// Fields
	private readonly object _state; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Exception <Exception>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private IAsyncResult <ActualResult>k__BackingField; // 0x20

	// Properties
	public Exception Exception { get; set; }
	public IAsyncResult ActualResult { get; set; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Exception get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Exception(Exception value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IAsyncResult get_ActualResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_ActualResult(IAsyncResult value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x2207DC0 Offset: 0x22063C0 VA: 0x182207DC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2207E20 Offset: 0x2206420 VA: 0x182207E20 Slot: 4
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

	// RVA: 0x2209420 Offset: 0x2207A20 VA: 0x182209420
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

	// RVA: 0xFC6370 Offset: 0xFC4970 VA: 0x180FC6370
	public void Start() { }

	// RVA: 0xFC67D0 Offset: 0xFC4DD0 VA: 0x180FC67D0
	public void set_Enabled(bool value) { }

	// RVA: 0xFC63C0 Offset: 0xFC49C0 VA: 0x180FC63C0
	public void UpdateFrom(Stats incomingStats) { }

	// RVA: 0xFC6770 Offset: 0xFC4D70 VA: 0x180FC6770
	public void .ctor() { }

}

private sealed class NetGraph.<>c // TypeDefIndex: 7076
{	// Fields
	public static readonly NetGraph.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xFD9010 Offset: 0xFD7610 VA: 0x180FD9010
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD84B0 Offset: 0xFD6AB0 VA: 0x180FD84B0
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

	// RVA: 0xFC5CB0 Offset: 0xFC42B0 VA: 0x180FC5CB0
	internal void Hide() { }

	// RVA: 0xFC5D00 Offset: 0xFC4300 VA: 0x180FC5D00
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

	// RVA: 0xFC5E50 Offset: 0xFC4450 VA: 0x180FC5E50
	private void Awake() { }

	// RVA: 0x4DC140 Offset: 0x4DA740 VA: 0x1804DC140
	internal void Hide() { }

	// RVA: 0xFC5EA0 Offset: 0xFC44A0 VA: 0x180FC5EA0
	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class NetGraphRow.<>c // TypeDefIndex: 7079
{	// Fields
	public static readonly NetGraphRow.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__10_0; // 0x8

	// Methods

	// RVA: 0xFD8FB0 Offset: 0xFD75B0 VA: 0x180FD8FB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8470 Offset: 0xFD6A70 VA: 0x180FD8470
	internal long <UpdateFrom>b__10_0(KeyValuePair<string, Stats.Node> y) { }

}

internal sealed class NetProtect : INetProtect // TypeDefIndex: 7165
{	// Methods

	// RVA: 0x22E6E70 Offset: 0x22E5470 VA: 0x1822E6E70
	public void .ctor(IntPtr Instance) { }

	// RVA: 0x22E6D70 Offset: 0x22E5370 VA: 0x1822E6D70 Slot: 4
	public bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6DF0 Offset: 0x22E53F0 VA: 0x1822E6DF0 Slot: 5
	public bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

}

public class Net // TypeDefIndex: 8228
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Client <cl>k__BackingField; // 0x0
	public static Client ClientNetwork; // 0x8
	public static DemoClient DemoClientNetwork; // 0x10

	// Properties
	public static Client cl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1071260 Offset: 0x106F860 VA: 0x181071260
	public static Client get_cl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x10712A0 Offset: 0x106F8A0 VA: 0x1810712A0
	private static void set_cl(Client value) { }

	// RVA: 0x1071050 Offset: 0x106F650 VA: 0x181071050
	public static void ClientInit(Client newclient) { }

	// RVA: 0x10710E0 Offset: 0x106F6E0 VA: 0x1810710E0
	public static void StartDemoPlayback(Reader demo) { }

	// RVA: 0x10711A0 Offset: 0x106F7A0 VA: 0x1810711A0
	public static void StopDemoPlayback() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class NetworkInfoGeneralText : MonoBehaviour // TypeDefIndex: 9286
{	// Fields
	public TextMeshProUGUI text; // 0x18

	// Methods

	// RVA: 0x9D07C0 Offset: 0x9CEDC0 VA: 0x1809D07C0
	private void Update() { }

	// RVA: 0x9D07C0 Offset: 0x9CEDC0 VA: 0x1809D07C0
	private void UpdateText() { }

	// RVA: 0x9D0740 Offset: 0x9CED40 VA: 0x1809D0740
	private static string ChannelStat(int window, int left) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class NetworkCryptography : INetworkCryptocraphy // TypeDefIndex: 10237
{	// Fields
	private MemoryStream buffer; // 0x10

	// Methods

	// RVA: 0x7CE970 Offset: 0x7CCF70 VA: 0x1807CE970 Slot: 6
	public MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CE840 Offset: 0x7CCE40 VA: 0x1807CE840 Slot: 7
	public MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CEA70 Offset: 0x7CD070 VA: 0x1807CEA70 Slot: 8
	public void Encrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CE940 Offset: 0x7CCF40 VA: 0x1807CE940 Slot: 9
	public void Decrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CEAA0 Offset: 0x7CD0A0 VA: 0x1807CEAA0 Slot: 4
	public bool IsEnabledIncoming(Connection connection) { }

	// RVA: 0x7CEAC0 Offset: 0x7CD0C0 VA: 0x1807CEAC0 Slot: 5
	public bool IsEnabledOutgoing(Connection connection) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: 0x7CE7D0 Offset: 0x7CCDD0 VA: 0x1807CE7D0
	protected void .ctor() { }

}

public class NetworkCryptographyClient : NetworkCryptography // TypeDefIndex: 10238
{	// Methods

	// RVA: 0x7CE6E0 Offset: 0x7CCCE0 VA: 0x1807CE6E0 Slot: 10
	protected override void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7CE5F0 Offset: 0x7CCBF0 VA: 0x1807CE5F0 Slot: 11
	protected override void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7CE7D0 Offset: 0x7CCDD0 VA: 0x1807CE7D0
	public void .ctor() { }

}

public class NetworkVisibilityGrid : MonoBehaviour // TypeDefIndex: 10239
{	// Fields
	public int startID; // 0x18
	public int gridSize; // 0x1C
	public int cellCount; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xBF280 Offset: 0xBE680 VA: 0x1800BF280
	public int visibilityRadiusFar; // 0x24
	public int visibilityRadiusNear; // 0x28
	public float switchTolerance; // 0x2C

	// Methods

	// RVA: 0x9D08C0 Offset: 0x9CEEC0 VA: 0x1809D08C0
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

	[AsyncStateMachineAttribute] // RVA: 0x96010 Offset: 0x95410 VA: 0x180096010
	// RVA: 0x2FC680 Offset: 0x2FAC80 VA: 0x1802FC680
	public static void LoadServerInfo(string address, int port, bool addToHistory = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x96150 Offset: 0x95550 VA: 0x180096150
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

	// RVA: 0xF15A0 Offset: 0xF09A0 VA: 0x1800F15A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ConnectionScreen.<LoadServerRules>d__14 : IAsyncStateMachine // TypeDefIndex: 11098
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x28

	// Methods

	// RVA: 0xF15C0 Offset: 0xF09C0 VA: 0x1800F15C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static void WriteObject<T>(NetWrite write, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15750E0 Offset: 0x15736E0 VA: 0x1815750E0
	|-NetworkWriteEx.WriteObject<bool>
	|
	|-RVA: 0x1575BF0 Offset: 0x15741F0 VA: 0x181575BF0
	|-NetworkWriteEx.WriteObject<byte>
	|
	|-RVA: 0x1576700 Offset: 0x1574D00 VA: 0x181576700
	|-NetworkWriteEx.WriteObject<int>
	|
	|-RVA: 0x1577200 Offset: 0x1575800 VA: 0x181577200
	|-NetworkWriteEx.WriteObject<object>
	|
	|-RVA: 0x1577C00 Offset: 0x1576200 VA: 0x181577C00
	|-NetworkWriteEx.WriteObject<sbyte>
	|
	|-RVA: 0xCFB820 Offset: 0xCF9E20 VA: 0x180CFB820
	|-NetworkWriteEx.WriteObject<float>
	|
	|-RVA: 0xCFC350 Offset: 0xCFA950 VA: 0x180CFC350
	|-NetworkWriteEx.WriteObject<uint>
	|
	|-RVA: 0xCFCE50 Offset: 0xCFB450 VA: 0x180CFCE50
	|-NetworkWriteEx.WriteObject<ulong>
	|
	|-RVA: 0xCFA1A0 Offset: 0xCF87A0 VA: 0x180CFA1A0
	|-NetworkWriteEx.WriteObject<Color>
	|
	|-RVA: 0xCFAC80 Offset: 0xCF9280 VA: 0x180CFAC80
	|-NetworkWriteEx.WriteObject<Ray>
	|
	|-RVA: 0xCFD960 Offset: 0xCFBF60 VA: 0x180CFD960
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
	|-RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	|-NetworkedProperty<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD596D0 Offset: 0xD57CD0 VA: 0x180D596D0
	|-NetworkedProperty<int>.set_Value
	|
	|-RVA: 0xD59650 Offset: 0xD57C50 VA: 0x180D59650
	|-NetworkedProperty<object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseEntity entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD59580 Offset: 0xD57B80 VA: 0x180D59580
	|-NetworkedProperty<int>..ctor
	|-NetworkedProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(NetworkedProperty<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD595C0 Offset: 0xD57BC0 VA: 0x180D595C0
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

	// RVA: 0x87B0C0 Offset: 0x8796C0 VA: 0x18087B0C0
	public void .ctor() { }

	// RVA: 0x87AFC0 Offset: 0x8795C0 VA: 0x18087AFC0 Slot: 42
	private IEnumerator<Variant> System.Collections.Generic.IEnumerable<TinyJSON.Variant>.GetEnumerator() { }

	// RVA: 0x87B040 Offset: 0x879640 VA: 0x18087B040 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x87AD60 Offset: 0x879360 VA: 0x18087AD60
	public void Add(Variant item) { }

	// RVA: 0x87B190 Offset: 0x879790 VA: 0x18087B190 Slot: 40
	public override Variant get_Item(int index) { }

	// RVA: 0x87B1F0 Offset: 0x8797F0 VA: 0x18087B1F0 Slot: 41
	public override void set_Item(int index, Variant value) { }

	// RVA: 0x87B150 Offset: 0x879750 VA: 0x18087B150
	public int get_Count() { }

	// RVA: 0x87ADC0 Offset: 0x8793C0 VA: 0x18087ADC0
	internal bool CanBeMultiRankArray(int[] rankLengths) { }

	// RVA: 0x87ADD0 Offset: 0x8793D0 VA: 0x18087ADD0
	private bool CanBeMultiRankArray(int rank, int[] rankLengths) { }

}

public sealed class ProxyBoolean : Variant // TypeDefIndex: 11584
{	// Fields
	private readonly bool value; // 0x10

	// Methods

	// RVA: 0x87B2A0 Offset: 0x8798A0 VA: 0x18087B2A0
	public void .ctor(bool value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x87B260 Offset: 0x879860 VA: 0x18087B260 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public sealed class ProxyNumber : Variant // TypeDefIndex: 11585
{	// Fields
	private static readonly char[] floatingPointCharacters; // 0x0
	private readonly IConvertible value; // 0x10

	// Methods

	// RVA: 0x87C180 Offset: 0x87A780 VA: 0x18087C180
	public void .ctor(IConvertible value) { }

	// RVA: 0x87B310 Offset: 0x879910 VA: 0x18087B310
	private static IConvertible Parse(string value) { }

	// RVA: 0x87B640 Offset: 0x879C40 VA: 0x18087B640 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x87B700 Offset: 0x879D00 VA: 0x18087B700 Slot: 25
	public override byte ToByte(IFormatProvider provider) { }

	// RVA: 0x87B7C0 Offset: 0x879DC0 VA: 0x18087B7C0 Slot: 26
	public override char ToChar(IFormatProvider provider) { }

	// RVA: 0x87B880 Offset: 0x879E80 VA: 0x18087B880 Slot: 27
	public override Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x87B960 Offset: 0x879F60 VA: 0x18087B960 Slot: 28
	public override double ToDouble(IFormatProvider provider) { }

	// RVA: 0x87BA20 Offset: 0x87A020 VA: 0x18087BA20 Slot: 29
	public override short ToInt16(IFormatProvider provider) { }

	// RVA: 0x87BAE0 Offset: 0x87A0E0 VA: 0x18087BAE0 Slot: 30
	public override int ToInt32(IFormatProvider provider) { }

	// RVA: 0x87BBA0 Offset: 0x87A1A0 VA: 0x18087BBA0 Slot: 31
	public override long ToInt64(IFormatProvider provider) { }

	// RVA: 0x87BC60 Offset: 0x87A260 VA: 0x18087BC60 Slot: 32
	public override sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x87BD20 Offset: 0x87A320 VA: 0x18087BD20 Slot: 33
	public override float ToSingle(IFormatProvider provider) { }

	// RVA: 0x87BDE0 Offset: 0x87A3E0 VA: 0x18087BDE0 Slot: 34
	public override string ToString(IFormatProvider provider) { }

	// RVA: 0x87BEA0 Offset: 0x87A4A0 VA: 0x18087BEA0 Slot: 35
	public override ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x87BF60 Offset: 0x87A560 VA: 0x18087BF60 Slot: 36
	public override uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x87C020 Offset: 0x87A620 VA: 0x18087C020 Slot: 37
	public override ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x87C0E0 Offset: 0x87A6E0 VA: 0x18087C0E0
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

	// RVA: 0x87C740 Offset: 0x87AD40 VA: 0x18087C740
	public void .ctor() { }

	// RVA: 0x87C5D0 Offset: 0x87ABD0 VA: 0x18087C5D0 Slot: 42
	private IEnumerator<KeyValuePair<string, Variant>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TinyJSON.Variant>>.GetEnumerator() { }

	// RVA: 0x87C650 Offset: 0x87AC50 VA: 0x18087C650 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x87C560 Offset: 0x87AB60 VA: 0x18087C560
	public void Add(string key, Variant item) { }

	// RVA: 0x87C6D0 Offset: 0x87ACD0 VA: 0x18087C6D0
	public bool TryGetValue(string key, out Variant item) { }

	// RVA: 0x87C8D0 Offset: 0x87AED0 VA: 0x18087C8D0
	public string get_TypeHint() { }

	// RVA: 0x87C820 Offset: 0x87AE20 VA: 0x18087C820 Slot: 38
	public override Variant get_Item(string key) { }

	// RVA: 0x87CA00 Offset: 0x87B000 VA: 0x18087CA00 Slot: 39
	public override void set_Item(string key, Variant value) { }

	// RVA: 0x87C7D0 Offset: 0x87ADD0 VA: 0x18087C7D0
	public int get_Count() { }

	// RVA: 0x87C880 Offset: 0x87AE80 VA: 0x18087C880
	public Dictionary.KeyCollection<string, Variant> get_Keys() { }

	// RVA: 0x87C9B0 Offset: 0x87AFB0 VA: 0x18087C9B0
	public Dictionary.ValueCollection<string, Variant> get_Values() { }

}

public sealed class ProxyString : Variant // TypeDefIndex: 11587
{	// Fields
	private readonly string value; // 0x10

	// Methods

	// RVA: 0x87CA70 Offset: 0x87B070 VA: 0x18087CA70
	public void .ctor(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public class ConnectionLimiter // TypeDefIndex: 11645
{	// Fields
	private readonly object _sync; // 0x10
	private readonly Dictionary<IPAddress, int> _addressCounts; // 0x18
	private int _overallCount; // 0x20

	// Methods

	// RVA: 0x583820 Offset: 0x581E20 VA: 0x180583820
	public void .ctor() { }

	// RVA: 0x583600 Offset: 0x581C00 VA: 0x180583600
	public bool TryAdd(IPAddress address) { }

	// RVA: 0x582F10 Offset: 0x581510 VA: 0x180582F10
	public void Remove(IPAddress address) { }

	// RVA: 0x582E30 Offset: 0x581430 VA: 0x180582E30
	public void Clear() { }

	// RVA: 0x583070 Offset: 0x581670 VA: 0x180583070 Slot: 3
	public override string ToString() { }

}

private sealed class ConnectionLimiter.<>c // TypeDefIndex: 11646
{	// Fields
	public static readonly ConnectionLimiter.<>c <>9; // 0x0
	public static Func<KeyValuePair<IPAddress, int>, int> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x589DE0 Offset: 0x5883E0 VA: 0x180589DE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x589B30 Offset: 0x588130 VA: 0x180589B30
	internal int <ToString>b__7_0(KeyValuePair<IPAddress, int> t) { }

}

public static class NetworkPacketEx // TypeDefIndex: 11703
{
// Namespace: UnityEngine
[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
public static class NetworkPacketEx // TypeDefIndex: 11703
	// Methods

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x9FD8F0 Offset: 0x9FBEF0 VA: 0x1809FD8F0
	public static BasePlayer Player(Message v) { }

}

public class Net : ConsoleSystem // TypeDefIndex: 11947
{	// Fields
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static bool visdebug; // 0x0
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool debug; // 0x1
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int visibilityRadiusFarOverride; // 0x4
	[ServerVar] // RVA: 0x81A60 Offset: 0x80E60 VA: 0x180081A60
	public static int visibilityRadiusNearOverride; // 0x8

	// Methods

	// RVA: 0x366E90 Offset: 0x365490 VA: 0x180366E90
	public void .ctor() { }

	// RVA: 0x366E10 Offset: 0x365410 VA: 0x180366E10
	private static void .cctor() { }

}

public class Netgraph : ConsoleSystem // TypeDefIndex: 11948
{	// Fields
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static bool enabled; // 0x0
	[ClientVar] // RVA: 0x81290 Offset: 0x80690 VA: 0x180081290
	public static float updatespeed; // 0x4
	[ClientVar] // RVA: 0x891C0 Offset: 0x885C0 VA: 0x1800891C0
	public static string typefilter; // 0x8
	[ClientVar] // RVA: 0x891C0 Offset: 0x885C0 VA: 0x1800891C0
	public static string entityfilter; // 0x10

	// Methods

	// RVA: 0x366FD0 Offset: 0x3655D0 VA: 0x180366FD0
	public void .ctor() { }

	// RVA: 0x366F30 Offset: 0x365530 VA: 0x180366F30
	private static void .cctor() { }

}

