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
	|-RVA: 0x1958970 Offset: 0x1956F70 VA: 0x181958970
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
	|-RVA: 0x1958AB0 Offset: 0x19570B0 VA: 0x181958AB0
	|-Queue<RCon.Command>..ctor
	|
	|-RVA: 0x1958BA0 Offset: 0x19571A0 VA: 0x181958BA0
	|-Queue<int>..ctor
	|
	|-RVA: 0x1958E70 Offset: 0x1957470 VA: 0x181958E70
	|-Queue<IntPtr>..ctor
	|
	|-RVA: 0x1958F60 Offset: 0x1957560 VA: 0x181958F60
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<Renderer>..ctor
	|
	|-RVA: 0x1958D80 Offset: 0x1957380 VA: 0x181958D80
	|-Queue<ulong>..ctor
	|
	|-RVA: 0x19589C0 Offset: 0x1956FC0 VA: 0x1819589C0
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|
	|-RVA: 0x1958C90 Offset: 0x1957290 VA: 0x181958C90
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
	|-RVA: 0x1958580 Offset: 0x1956B80 VA: 0x181958580
	|-Queue<RCon.Command>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19584A0 Offset: 0x1956AA0 VA: 0x1819584A0
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958510 Offset: 0x1956B10 VA: 0x181958510
	|-Queue<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958660 Offset: 0x1956C60 VA: 0x181958660
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19585F0 Offset: 0x1956BF0 VA: 0x1819585F0
	|-Queue<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19583C0 Offset: 0x19569C0 VA: 0x1819583C0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958430 Offset: 0x1956A30 VA: 0x181958430
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956110 Offset: 0x1954710 VA: 0x181956110
	|-Queue<BaseEntity>.Clear
	|-Queue<RCon.Command>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|
	|-RVA: 0x19560F0 Offset: 0x19546F0 VA: 0x1819560F0
	|-Queue<int>.Clear
	|-Queue<IntPtr>.Clear
	|-Queue<ulong>.Clear
	|-Queue<AsyncGPUReadbackRequest>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957EA0 Offset: 0x19564A0 VA: 0x181957EA0
	|-Queue<RCon.Command>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957C10 Offset: 0x1956210 VA: 0x181957C10
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957460 Offset: 0x1955A60 VA: 0x181957460
	|-Queue<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19571D0 Offset: 0x19557D0 VA: 0x1819571D0
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957980 Offset: 0x1955F80 VA: 0x181957980
	|-Queue<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1958130 Offset: 0x1956730 VA: 0x181958130
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19576F0 Offset: 0x1955CF0 VA: 0x1819576F0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19566E0 Offset: 0x1954CE0 VA: 0x1819566E0
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
	|-RVA: 0x1956930 Offset: 0x1954F30 VA: 0x181956930
	|-Queue<RCon.Command>.Enqueue
	|
	|-RVA: 0x1956A20 Offset: 0x1955020 VA: 0x181956A20
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x19567B0 Offset: 0x1954DB0 VA: 0x1819567B0
	|-Queue<IntPtr>.Enqueue
	|-Queue<ulong>.Enqueue
	|
	|-RVA: 0x1956620 Offset: 0x1954C20 VA: 0x181956620
	|-Queue<AsyncGPUReadbackRequest>.Enqueue
	|
	|-RVA: 0x1956860 Offset: 0x1954E60 VA: 0x181956860
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956AD0 Offset: 0x19550D0 VA: 0x181956AD0
	|-Queue<string>.GetEnumerator
	|-Queue<IntPtr>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|-Queue<ulong>.GetEnumerator
	|
	|-RVA: 0x1956B80 Offset: 0x1955180 VA: 0x181956B80
	|-Queue<RCon.Command>.GetEnumerator
	|
	|-RVA: 0x1956BF0 Offset: 0x19551F0 VA: 0x181956BF0
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x1956B20 Offset: 0x1955120 VA: 0x181956B20
	|-Queue<AsyncGPUReadbackRequest>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957100 Offset: 0x1955700 VA: 0x181957100
	|-Queue<RCon.Command>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1957060 Offset: 0x1955660 VA: 0x181957060
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1956FC0 Offset: 0x19555C0 VA: 0x181956FC0
	|-Queue<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1956F20 Offset: 0x1955520 VA: 0x181956F20
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957100 Offset: 0x1955700 VA: 0x181957100
	|-Queue<RCon.Command>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1957060 Offset: 0x1955660 VA: 0x181957060
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1956FC0 Offset: 0x19555C0 VA: 0x181956FC0
	|-Queue<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1956F20 Offset: 0x1955520 VA: 0x181956F20
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956250 Offset: 0x1954850 VA: 0x181956250
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
	|-RVA: 0x19563B0 Offset: 0x19549B0 VA: 0x1819563B0
	|-Queue<RCon.Command>.Dequeue
	|
	|-RVA: 0x19564E0 Offset: 0x1954AE0 VA: 0x1819564E0
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x1956310 Offset: 0x1954910 VA: 0x181956310
	|-Queue<IntPtr>.Dequeue
	|-Queue<ulong>.Dequeue
	|
	|-RVA: 0x1956570 Offset: 0x1954B70 VA: 0x181956570
	|-Queue<AsyncGPUReadbackRequest>.Dequeue
	|
	|-RVA: 0x1956180 Offset: 0x1954780 VA: 0x181956180
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956D50 Offset: 0x1955350 VA: 0x181956D50
	|-Queue<ulong>.Peek
	|-Queue<IntPtr>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x1956CD0 Offset: 0x19552D0 VA: 0x181956CD0
	|-Queue<AsyncGPUReadbackRequest>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|
	|-RVA: 0x1956DB0 Offset: 0x19553B0 VA: 0x181956DB0
	|-Queue<RCon.Command>.Peek
	|
	|-RVA: 0x1956C70 Offset: 0x1955270 VA: 0x181956C70
	|-Queue<int>.Peek
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956E40 Offset: 0x1955440 VA: 0x181956E40
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
	|-RVA: 0x1956C40 Offset: 0x1955240 VA: 0x181956C40
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
	|-RVA: 0x1958730 Offset: 0x1956D30 VA: 0x181958730
	|-Queue<RCon.Command>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958790 Offset: 0x1956D90 VA: 0x181958790
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x19586D0 Offset: 0x1956CD0 VA: 0x1819586D0
	|-Queue<IntPtr>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958850 Offset: 0x1956E50 VA: 0x181958850
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x19588B0 Offset: 0x1956EB0 VA: 0x1819588B0
	|-Queue<ulong>.ThrowForEmptyQueue
	|
	|-RVA: 0x19587F0 Offset: 0x1956DF0 VA: 0x1819587F0
	|-Queue<AsyncGPUReadbackRequest>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958910 Offset: 0x1956F10 VA: 0x181958910
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
	|-RVA: 0x220600 Offset: 0x21FA00 VA: 0x180220600
	|-Queue.Enumerator<RCon.Command>..ctor
	|
	|-RVA: 0x220760 Offset: 0x21FB60 VA: 0x180220760
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x220710 Offset: 0x21FB10 VA: 0x180220710
	|-Queue.Enumerator<IntPtr>..ctor
	|-Queue.Enumerator<object>..ctor
	|-Queue.Enumerator<ulong>..ctor
	|
	|-RVA: 0x2205B0 Offset: 0x21F9B0 VA: 0x1802205B0
	|-Queue.Enumerator<AsyncGPUReadbackRequest>..ctor
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21EB80 Offset: 0x21DF80 VA: 0x18021EB80
	|-Queue.Enumerator<RCon.Command>.Dispose
	|
	|-RVA: 0x21EB70 Offset: 0x21DF70 VA: 0x18021EB70
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x21EB00 Offset: 0x21DF00 VA: 0x18021EB00
	|-Queue.Enumerator<IntPtr>.Dispose
	|-Queue.Enumerator<object>.Dispose
	|-Queue.Enumerator<string>.Dispose
	|-Queue.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x21EAB0 Offset: 0x21DEB0 VA: 0x18021EAB0
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.Dispose
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21EEA0 Offset: 0x21E2A0 VA: 0x18021EEA0
	|-Queue.Enumerator<RCon.Command>.MoveNext
	|
	|-RVA: 0x21EDC0 Offset: 0x21E1C0 VA: 0x18021EDC0
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21F060 Offset: 0x21E460 VA: 0x18021F060
	|-Queue.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x21EBA0 Offset: 0x21DFA0 VA: 0x18021EBA0
	|-Queue.Enumerator<object>.MoveNext
	|-Queue.Enumerator<string>.MoveNext
	|
	|-RVA: 0x21F1A0 Offset: 0x21E5A0 VA: 0x18021F1A0
	|-Queue.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21ECD0 Offset: 0x21E0D0 VA: 0x18021ECD0
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.MoveNext
	|
	|-RVA: 0x21F280 Offset: 0x21E680 VA: 0x18021F280
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2207C0 Offset: 0x21FBC0 VA: 0x1802207C0
	|-Queue.Enumerator<string>.get_Current
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x2209B0 Offset: 0x21FDB0 VA: 0x1802209B0
	|-Queue.Enumerator<RCon.Command>.get_Current
	|
	|-RVA: 0x220910 Offset: 0x21FD10 VA: 0x180220910
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x220850 Offset: 0x21FC50 VA: 0x180220850
	|-Queue.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x220800 Offset: 0x21FC00 VA: 0x180220800
	|-Queue.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x220890 Offset: 0x21FC90 VA: 0x180220890
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.get_Current
	|
	|-RVA: 0x2208D0 Offset: 0x21FCD0 VA: 0x1802208D0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2204A0 Offset: 0x21F8A0 VA: 0x1802204A0
	|-Queue.Enumerator<RCon.Command>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220470 Offset: 0x21F870 VA: 0x180220470
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2204D0 Offset: 0x21F8D0 VA: 0x1802204D0
	|-Queue.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220490 Offset: 0x21F890 VA: 0x180220490
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2204C0 Offset: 0x21F8C0 VA: 0x1802204C0
	|-Queue.Enumerator<ulong>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x2204B0 Offset: 0x21F8B0 VA: 0x1802204B0
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220480 Offset: 0x21F880 VA: 0x180220480
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2203A0 Offset: 0x21F7A0 VA: 0x1802203A0
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220060 Offset: 0x21F460 VA: 0x180220060
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220230 Offset: 0x21F630 VA: 0x180220230
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2201C0 Offset: 0x21F5C0 VA: 0x1802201C0
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220110 Offset: 0x21F510 VA: 0x180220110
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21FFB0 Offset: 0x21F3B0 VA: 0x18021FFB0
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2202F0 Offset: 0x21F6F0 VA: 0x1802202F0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21F940 Offset: 0x21ED40 VA: 0x18021F940
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FA50 Offset: 0x21EE50 VA: 0x18021FA50
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21F9D0 Offset: 0x21EDD0 VA: 0x18021F9D0
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FB50 Offset: 0x21EF50 VA: 0x18021FB50
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FD10 Offset: 0x21F110 VA: 0x18021FD10
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FAD0 Offset: 0x21EED0 VA: 0x18021FAD0
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FC30 Offset: 0x21F030 VA: 0x18021FC30
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IConnectionManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Interface(IConnectionManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x1EBFC0 Offset: 0x1EB3C0 VA: 0x1801EBFC0 Slot: 3
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

	// RVA: 0x1EBFB0 Offset: 0x1EB3B0 VA: 0x1801EBFB0 Slot: 3
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

	// RVA: 0x1E5060 Offset: 0x1E4460 VA: 0x1801E5060 Slot: 4
	public bool Equals(Connection other) { }

	// RVA: 0x1E5070 Offset: 0x1E4470 VA: 0x1801E5070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E50F0 Offset: 0x1E44F0 VA: 0x1801E50F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D3140 Offset: 0x1D2540 VA: 0x1801D3140 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static Connection op_Implicit(uint value) { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static uint op_Implicit(Connection value) { }

	// RVA: 0x1E4EB0 Offset: 0x1E42B0 VA: 0x1801E4EB0
	public Result Accept() { }

	// RVA: 0x1E4F20 Offset: 0x1E4320 VA: 0x1801E4F20
	public bool Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x1E51B0 Offset: 0x1E45B0 VA: 0x1801E51B0
	public Result SendMessage(IntPtr ptr, int size, SendType sendType = 8, ushort laneIndex = 0) { }

	// RVA: 0x1E4FD0 Offset: 0x1E43D0 VA: 0x1801E4FD0
	public string DetailedStatus() { }

	// RVA: 0x1E5110 Offset: 0x1E4510 VA: 0x1801E5110
	public ConnectionStatus QuickStatus() { }

	// RVA: 0x1E4F30 Offset: 0x1E4330 VA: 0x1801E4F30
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

	// RVA: 0x1E47D0 Offset: 0x1E3BD0 VA: 0x1801E47D0
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

	// RVA: 0x14B7E0 Offset: 0x14ABE0 VA: 0x18014B7E0
	public int get_Ping() { }

	// RVA: 0x1E4C10 Offset: 0x1E4010 VA: 0x1801E4C10
	public float get_OutBytesPerSec() { }

	// RVA: 0x1E4C00 Offset: 0x1E4000 VA: 0x1801E4C00
	public float get_InBytesPerSec() { }

	// RVA: 0x117100 Offset: 0x116500 VA: 0x180117100
	public float get_ConnectionQualityLocal() { }

	// RVA: 0x1E4C20 Offset: 0x1E4020 VA: 0x1801E4C20
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

	// RVA: 0x220E450 Offset: 0x220CA50 VA: 0x18220E450
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public string get_RecordFilename() { }

	// RVA: 0xBC8BC0 Offset: 0xBC71C0 VA: 0x180BC8BC0
	public int get_RecordFilesize() { }

	// RVA: 0x220DD40 Offset: 0x220C340 VA: 0x18220DD40
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x220DE50 Offset: 0x220C450 VA: 0x18220DE50
	public void StopRecording() { }

	// RVA: 0x795BE0 Offset: 0x7941E0 VA: 0x180795BE0
	public bool get_IsRecording() { }

	// RVA: 0x220D840 Offset: 0x220BE40 VA: 0x18220D840
	public void RecordPacket(byte packetId, IProto proto) { }

	// RVA: 0x220DAC0 Offset: 0x220C0C0 VA: 0x18220DAC0
	public void RecordPacket(Stream stream) { }

	// RVA: 0x220D7A0 Offset: 0x220BDA0 VA: 0x18220D7A0 Slot: 4
	public virtual void OnDisconnected() { }

	// RVA: 0x220E4D0 Offset: 0x220CAD0 VA: 0x18220E4D0
	public bool get_isAuthenticated() { }

	// RVA: 0x220DCC0 Offset: 0x220C2C0 VA: 0x18220DCC0
	public void ResetPacketsPerSecond() { }

	// RVA: 0x220D630 Offset: 0x220BC30 VA: 0x18220D630
	public void AddPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220D5E0 Offset: 0x220BBE0 VA: 0x18220D5E0
	public void AddPacketsPerSecond(int index = 0) { }

	// RVA: 0x220D6E0 Offset: 0x220BCE0 VA: 0x18220D6E0
	public ulong GetPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220D680 Offset: 0x220BC80 VA: 0x18220D680
	public ulong GetPacketsPerSecond(int index = 0) { }

	// RVA: 0x220D740 Offset: 0x220BD40 VA: 0x18220D740
	public float GetSecondsConnected() { }

	// RVA: 0x220E210 Offset: 0x220C810 VA: 0x18220E210 Slot: 3
	public override string ToString() { }

	// RVA: 0x220E2F0 Offset: 0x220C8F0 VA: 0x18220E2F0
	public void .ctor() { }

	// RVA: 0x220E290 Offset: 0x220C890 VA: 0x18220E290
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

	// RVA: 0x220CE40 Offset: 0x220B440 VA: 0x18220CE40
	public void Set(string k, string v) { }

	// RVA: 0x220CDC0 Offset: 0x220B3C0 VA: 0x18220CDC0
	public string GetString(string k, string def = "") { }

	// RVA: 0x220CC60 Offset: 0x220B260 VA: 0x18220CC60
	public float GetFloat(string k, float def = 0) { }

	// RVA: 0x220CD10 Offset: 0x220B310 VA: 0x18220CD10
	public int GetInt(string k, int def = 0) { }

	// RVA: 0x220CB60 Offset: 0x220B160 VA: 0x18220CB60
	public bool GetBool(string k, bool def = False) { }

	// RVA: 0x220CEB0 Offset: 0x220B4B0 VA: 0x18220CEB0
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

	// RVA: 0x220FDE0 Offset: 0x220E3E0 VA: 0x18220FDE0
	public MemoryStream GetStreamForDecryption() { }

	// RVA: 0x2210270 Offset: 0x220E870 VA: 0x182210270
	public bool Start(IntPtr data, int length) { }

	// RVA: 0x2210B80 Offset: 0x220F180 VA: 0x182210B80
	public int get_Unread() { }

	// RVA: 0x2210780 Offset: 0x220ED80 VA: 0x182210780
	public string String(int maxLength = 256) { }

	// RVA: 0x2210670 Offset: 0x220EC70 VA: 0x182210670
	public string StringMultiLine(int maxLength = 2048) { }

	// RVA: 0x22103E0 Offset: 0x220E9E0 VA: 0x1822103E0
	private string StringInternal(int maxLength, bool allowNewLine) { }

	// RVA: 0x2210680 Offset: 0x220EC80 VA: 0x182210680
	public string StringRaw(uint maxLength = 1048576) { }

	// RVA: 0x2210790 Offset: 0x220ED90 VA: 0x182210790
	public bool TemporaryBytesWithSize(out byte[] buffer, out int size) { }

	// RVA: 0x220FD10 Offset: 0x220E310 VA: 0x18220FD10
	public uint EntityID() { }

	// RVA: 0x220FD10 Offset: 0x220E310 VA: 0x18220FD10
	public uint GroupID() { }

	// RVA: 0x220FBB0 Offset: 0x220E1B0 VA: 0x18220FBB0
	public int BytesWithSize(byte[] buffer, uint maxLength = 4294967295) { }

	// RVA: 0x220FAE0 Offset: 0x220E0E0 VA: 0x18220FAE0
	public byte[] BytesWithSize(uint maxSize = 10485760) { }

	// RVA: 0x22100C0 Offset: 0x220E6C0 VA: 0x1822100C0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xC15040 Offset: 0xC13640 VA: 0x180C15040 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x220FFC0 Offset: 0x220E5C0 VA: 0x18220FFC0
	public byte PacketID() { }

	// RVA: 0x220FAA0 Offset: 0x220E0A0 VA: 0x18220FAA0
	public bool Bit() { }

	// RVA: 0x220FFC0 Offset: 0x220E5C0 VA: 0x18220FFC0
	public byte UInt8() { }

	// RVA: 0x2210900 Offset: 0x220EF00 VA: 0x182210900
	public ushort UInt16() { }

	// RVA: 0x220FD10 Offset: 0x220E310 VA: 0x18220FD10
	public uint UInt32() { }

	// RVA: 0x2210940 Offset: 0x220EF40 VA: 0x182210940
	public ulong UInt64() { }

	// RVA: 0x220FF80 Offset: 0x220E580 VA: 0x18220FF80
	public sbyte Int8() { }

	// RVA: 0x220FEC0 Offset: 0x220E4C0 VA: 0x18220FEC0
	public short Int16() { }

	// RVA: 0x220FF00 Offset: 0x220E500 VA: 0x18220FF00
	public int Int32() { }

	// RVA: 0x220FF40 Offset: 0x220E540 VA: 0x18220FF40
	public long Int64() { }

	// RVA: 0x220FD50 Offset: 0x220E350 VA: 0x18220FD50
	public float Float() { }

	// RVA: 0x220FCD0 Offset: 0x220E2D0 VA: 0x18220FCD0
	public double Double() { }

	// RVA: 0x2210980 Offset: 0x220EF80 VA: 0x182210980
	public Vector3 Vector3() { }

	// RVA: 0x2210000 Offset: 0x220E600 VA: 0x182210000
	public Quaternion Quaternion() { }

	// RVA: 0x2210060 Offset: 0x220E660 VA: 0x182210060
	public Ray Ray() { }

	// RVA: 0x220FC70 Offset: 0x220E270 VA: 0x18220FC70
	public Color Color() { }

	// RVA: 0x2210160 Offset: 0x220E760 VA: 0x182210160 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21C0C80 Offset: 0x21BF280 VA: 0x1821C0C80 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x22101F0 Offset: 0x220E7F0 VA: 0x1822101F0 Slot: 25
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

	// RVA: 0x220FD90 Offset: 0x220E390 VA: 0x18220FD90 Slot: 18
	public override void Flush() { }

	// RVA: 0x2210A30 Offset: 0x220F030 VA: 0x182210A30 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x22109E0 Offset: 0x220EFE0 VA: 0x1822109E0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2210B00 Offset: 0x220F100 VA: 0x182210B00
	public void .ctor() { }

	// RVA: 0x2210A80 Offset: 0x220F080 VA: 0x182210A80
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

	// RVA: 0x2211E10 Offset: 0x2210410 VA: 0x182211E10
	public void .ctor(BaseNetwork netwrite) { }

	// RVA: 0x22117B0 Offset: 0x220FDB0 VA: 0x1822117B0
	public void Shutdown() { }

	// RVA: 0x2211830 Offset: 0x220FE30 VA: 0x182211830
	public bool Start() { }

	// RVA: 0x2211710 Offset: 0x220FD10 VA: 0x182211710
	public void Send(SendInfo info) { }

	// RVA: 0x2211460 Offset: 0x220FA60 VA: 0x182211460
	public void PacketID(Message.Type val) { }

	// RVA: 0x2211BD0 Offset: 0x22101D0 VA: 0x182211BD0
	public void UInt8(byte val) { }

	// RVA: 0x2211AE0 Offset: 0x22100E0 VA: 0x182211AE0
	public void UInt16(ushort val) { }

	// RVA: 0x2211B30 Offset: 0x2210130 VA: 0x182211B30
	public void UInt32(uint val) { }

	// RVA: 0x2211B80 Offset: 0x2210180 VA: 0x182211B80
	public void UInt64(ulong val) { }

	// RVA: 0x2211410 Offset: 0x220FA10 VA: 0x182211410
	public void Int8(sbyte val) { }

	// RVA: 0x2211320 Offset: 0x220F920 VA: 0x182211320
	public void Int16(short val) { }

	// RVA: 0x2211370 Offset: 0x220F970 VA: 0x182211370
	public void Int32(int val) { }

	// RVA: 0x22113C0 Offset: 0x220F9C0 VA: 0x1822113C0
	public void Int64(long val) { }

	// RVA: 0x2210BD0 Offset: 0x220F1D0 VA: 0x182210BD0
	public void Bool(bool val) { }

	// RVA: 0x22112D0 Offset: 0x220F8D0 VA: 0x1822112D0
	public void Float(float val) { }

	// RVA: 0x2210FB0 Offset: 0x220F5B0 VA: 0x182210FB0
	public void Double(double val) { }

	// RVA: 0x2210E60 Offset: 0x220F460 VA: 0x182210E60
	public void Bytes(byte[] val) { }

	// RVA: 0x2211840 Offset: 0x220FE40 VA: 0x182211840
	public void String(string val) { }

	// RVA: 0x2211C20 Offset: 0x2210220 VA: 0x182211C20
	public void Vector3(in Vector3 obj) { }

	// RVA: 0x2210EA0 Offset: 0x220F4A0 VA: 0x182210EA0
	public void Quaternion(in Quaternion obj) { }

	// RVA: 0x22114B0 Offset: 0x220FAB0 VA: 0x1822114B0
	public void Ray(in Ray obj) { }

	// RVA: 0x2210EA0 Offset: 0x220F4A0 VA: 0x182210EA0
	public void Color(in Color obj) { }

	// RVA: 0x2211280 Offset: 0x220F880 VA: 0x182211280
	public void EntityID(uint id) { }

	// RVA: 0x2211280 Offset: 0x220F880 VA: 0x182211280
	public void GroupID(uint id) { }

	// RVA: 0x2210C30 Offset: 0x220F230 VA: 0x182210C30
	public void BytesWithSize(MemoryStream val) { }

	// RVA: 0x2210CF0 Offset: 0x220F2F0 VA: 0x182210CF0
	public void BytesWithSize(byte[] b) { }

	// RVA: 0x2210D10 Offset: 0x220F310 VA: 0x182210D10
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

	// RVA: 0x2211000 Offset: 0x220F600 VA: 0x182211000
	private void EnsureCapacity(int spaceRequired) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 31
	public override byte[] GetBuffer() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x2211F00 Offset: 0x2210500 VA: 0x182211F00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x2211F10 Offset: 0x2210510 VA: 0x182211F10 Slot: 11
	public override long get_Position() { }

	// RVA: 0x2211F20 Offset: 0x2210520 VA: 0x182211F20 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x22115B0 Offset: 0x220FBB0 VA: 0x1822115B0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2211560 Offset: 0x220FB60 VA: 0x182211560 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2211D40 Offset: 0x2210340 VA: 0x182211D40 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2211CF0 Offset: 0x22102F0 VA: 0x182211CF0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2211670 Offset: 0x220FC70 VA: 0x182211670 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2211760 Offset: 0x220FD60 VA: 0x182211760 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2211DB0 Offset: 0x22103B0 VA: 0x182211DB0
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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_connection(Connection value) { }

	// RVA: 0x2212170 Offset: 0x2210770 VA: 0x182212170
	public void Destroy() { }

	// RVA: 0x22121A0 Offset: 0x22107A0 VA: 0x1822121A0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x22124C0 Offset: 0x2210AC0 VA: 0x1822124C0
	public void StartSubscriber() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void OnConnected(Connection c) { }

	// RVA: 0x2212220 Offset: 0x2210820 VA: 0x182212220
	public void OnDisconnected() { }

	// RVA: 0x22120E0 Offset: 0x22106E0 VA: 0x1822120E0
	public void CloseSubscriber() { }

	// RVA: 0x2212E80 Offset: 0x2211480 VA: 0x182212E80
	public bool UpdateGroups(Vector3 position) { }

	// RVA: 0x2212600 Offset: 0x2210C00 VA: 0x182212600
	public bool SwitchGroup(Group newGroup) { }

	// RVA: 0x2212250 Offset: 0x2210850 VA: 0x182212250
	internal void OnGroupTransition(Group oldGroup) { }

	// RVA: 0x22123E0 Offset: 0x22109E0 VA: 0x1822123E0
	internal void OnSubscriptionChange() { }

	// RVA: 0x2212D10 Offset: 0x2211310 VA: 0x182212D10
	public bool SwitchSecondaryGroup(Group newGroup) { }

	// RVA: 0x2211F40 Offset: 0x2210540 VA: 0x182211F40
	private void AddVisibleFromNear(Group additionalGroup, List<Group> groupsVisible) { }

	// RVA: 0x22132C0 Offset: 0x22118C0 VA: 0x1822132C0
	public bool UpdateSubscriptions(int removeLimit, int addLimit) { }

	// RVA: 0x2213020 Offset: 0x2211620 VA: 0x182213020
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

	// RVA: 0x2207B50 Offset: 0x2206150 VA: 0x182207B50
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

	// RVA: 0x2207AF0 Offset: 0x22060F0 VA: 0x182207AF0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4430 Offset: 0xBA2A30 VA: 0x180BA4430 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x2207730 Offset: 0x2205D30 VA: 0x182207730 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA45D0 Offset: 0xBA2BD0 VA: 0x180BA45D0 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x22079B0 Offset: 0x2205FB0 VA: 0x1822079B0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA46E0 Offset: 0xBA2CE0 VA: 0x180BA46E0 Slot: 18
	public override void Flush() { }

	// RVA: 0x1634E30 Offset: 0x1633430 VA: 0x181634E30 Slot: 16
	public override void Close() { }

	// RVA: 0x2207960 Offset: 0x2205F60 VA: 0x182207960 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x22075D0 Offset: 0x2205BD0 VA: 0x1822075D0
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

	// RVA: 0x220C4A0 Offset: 0x220AAA0 VA: 0x18220C4A0
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

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Exception get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Exception(Exception value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IAsyncResult get_ActualResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_ActualResult(IAsyncResult value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x2207C00 Offset: 0x2206200 VA: 0x182207C00 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2207C60 Offset: 0x2206260 VA: 0x182207C60 Slot: 4
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

	// RVA: 0x2209260 Offset: 0x2207860 VA: 0x182209260
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

	// RVA: 0x22E6CB0 Offset: 0x22E52B0 VA: 0x1822E6CB0
	public void .ctor(IntPtr Instance) { }

	// RVA: 0x22E6BB0 Offset: 0x22E51B0 VA: 0x1822E6BB0 Slot: 4
	public bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6C30 Offset: 0x22E5230 VA: 0x1822E6C30 Slot: 5
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
	// RVA: 0x1071260 Offset: 0x106F860 VA: 0x181071260
	public static Client get_cl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[FormerlySerializedAsAttribute] // RVA: 0xBF320 Offset: 0xBE720 VA: 0x1800BF320
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
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public static class NetworkPacketEx // TypeDefIndex: 11703
	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9FD8F0 Offset: 0x9FBEF0 VA: 0x1809FD8F0
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

