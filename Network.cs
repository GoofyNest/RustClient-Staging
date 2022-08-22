internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 815
{	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x14982D0 Offset: 0x14968D0 VA: 0x1814982D0
	private static void .cctor() { }

	// RVA: 0x1498350 Offset: 0x1496950 VA: 0x181498350
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x1498170 Offset: 0x1496770 VA: 0x181498170 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1498260 Offset: 0x1496860 VA: 0x181498260
	private static void WaitCallback_Context(object state) { }

}

public class ProxyAttribute : Attribute // TypeDefIndex: 1159
{	// Methods

	// RVA: 0x1482C80 Offset: 0x1481280 VA: 0x181482C80 Slot: 7
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x1482D90 Offset: 0x1481390 VA: 0x181482D90 Slot: 8
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

	// RVA: 0x1468060 Offset: 0x1466660 VA: 0x181468060
	public void .ctor() { }

	// RVA: 0x1467CA0 Offset: 0x14662A0 VA: 0x181467CA0
	public void .ctor(int capacity) { }

	// RVA: 0x1467EA0 Offset: 0x14664A0 VA: 0x181467EA0
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x1467CB0 Offset: 0x14662B0 VA: 0x181467CB0
	public void .ctor(ICollection col) { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x14673A0 Offset: 0x14659A0 VA: 0x1814673A0 Slot: 10
	public virtual object Clone() { }

	// RVA: 0x1468080 Offset: 0x1466680 VA: 0x181468080 Slot: 11
	public virtual object get_SyncRoot() { }

	// RVA: 0x1467340 Offset: 0x1465940 VA: 0x181467340 Slot: 12
	public virtual void Clear() { }

	// RVA: 0x1467490 Offset: 0x1465A90 VA: 0x181467490 Slot: 13
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1467790 Offset: 0x1465D90 VA: 0x181467790 Slot: 14
	public virtual void Enqueue(object obj) { }

	// RVA: 0x1467990 Offset: 0x1465F90 VA: 0x181467990 Slot: 15
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1467690 Offset: 0x1465C90 VA: 0x181467690 Slot: 16
	public virtual object Dequeue() { }

	// RVA: 0x1467A40 Offset: 0x1466040 VA: 0x181467A40 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x1467950 Offset: 0x1465F50 VA: 0x181467950
	internal object GetElement(int i) { }

	// RVA: 0x1467BE0 Offset: 0x14661E0 VA: 0x181467BE0 Slot: 18
	public virtual object[] ToArray() { }

	// RVA: 0x1467B00 Offset: 0x1466100 VA: 0x181467B00
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

	// RVA: 0x14671F0 Offset: 0x14657F0 VA: 0x1814671F0
	internal void .ctor(Queue q) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 7
	public object Clone() { }

	// RVA: 0x1467030 Offset: 0x1465630 VA: 0x181467030 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1467270 Offset: 0x1465870 VA: 0x181467270 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1467140 Offset: 0x1465740 VA: 0x181467140 Slot: 10
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

	// RVA: 0x1348480 Offset: 0x1346A80 VA: 0x181348480
	public void .ctor(string userName, string password) { }

	// RVA: 0x1348580 Offset: 0x1346B80 VA: 0x181348580
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_UserName() { }

	// RVA: 0x13486F0 Offset: 0x1346CF0 VA: 0x1813486F0
	public void set_UserName(string value) { }

	// RVA: 0x1348470 Offset: 0x1346A70 VA: 0x181348470
	public string get_Password() { }

	// RVA: 0x13486C0 Offset: 0x1346CC0 VA: 0x1813486C0
	public void set_Password(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Domain() { }

	// RVA: 0x1348660 Offset: 0x1346C60 VA: 0x181348660
	public void set_Domain(string value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal string InternalGetUserName() { }

	// RVA: 0x1348470 Offset: 0x1346A70 VA: 0x181348470
	internal string InternalGetPassword() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal string InternalGetDomain() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

internal class NetRes // TypeDefIndex: 2921
{	// Methods

	// RVA: 0x13483C0 Offset: 0x13469C0 VA: 0x1813483C0
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1348360 Offset: 0x1346960 VA: 0x181348360
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

	// RVA: 0xFFB4B0 Offset: 0xFF9AB0 VA: 0x180FFB4B0
	public void .ctor(Socket socket) { }

	// RVA: 0xFFB3E0 Offset: 0xFF99E0 VA: 0x180FFB3E0
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xFFB570 Offset: 0xFF9B70 VA: 0x180FFB570 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xFFB660 Offset: 0xFF9C60 VA: 0x180FFB660 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0xFFB6F0 Offset: 0xFF9CF0 VA: 0x180FFB6F0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0xFFB580 Offset: 0xFF9B80 VA: 0x180FFB580 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFFB5F0 Offset: 0xFF9BF0 VA: 0x180FFB5F0 Slot: 11
	public override long get_Position() { }

	// RVA: 0xFFB780 Offset: 0xFF9D80 VA: 0x180FFB780 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xFFAF50 Offset: 0xFF9550 VA: 0x180FFAF50 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xFFAA30 Offset: 0xFF9030 VA: 0x180FFAA30
	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0xFFABA0 Offset: 0xFF91A0 VA: 0x180FFABA0 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	// RVA: 0xFFB030 Offset: 0xFF9630 VA: 0x180FFB030 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFFA350 Offset: 0xFF8950 VA: 0x180FFA350 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFFA990 Offset: 0xFF8F90 VA: 0x180FFA990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xFF9BD0 Offset: 0xFF81D0 VA: 0x180FF9BD0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFFA430 Offset: 0xFF8A30 VA: 0x180FFA430 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFF9F90 Offset: 0xFF8590 VA: 0x180FF9F90 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFFA6E0 Offset: 0xFF8CE0 VA: 0x180FFA6E0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0xFFAFC0 Offset: 0xFF95C0 VA: 0x180FFAFC0 Slot: 26
	public override void SetLength(long value) { }

}

public class NetworkInformationException : Win32Exception // TypeDefIndex: 3074
{	// Methods

	// RVA: 0x1348750 Offset: 0x1346D50 VA: 0x181348750
	public void .ctor() { }

	// RVA: 0x13487E0 Offset: 0x1346DE0 VA: 0x1813487E0
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
	|-RVA: 0x1958C30 Offset: 0x1957230 VA: 0x181958C30
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
	|-RVA: 0x1958D70 Offset: 0x1957370 VA: 0x181958D70
	|-Queue<RCon.Command>..ctor
	|
	|-RVA: 0x1958E60 Offset: 0x1957460 VA: 0x181958E60
	|-Queue<int>..ctor
	|
	|-RVA: 0x1959130 Offset: 0x1957730 VA: 0x181959130
	|-Queue<IntPtr>..ctor
	|
	|-RVA: 0x1959220 Offset: 0x1957820 VA: 0x181959220
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<Renderer>..ctor
	|
	|-RVA: 0x1959040 Offset: 0x1957640 VA: 0x181959040
	|-Queue<ulong>..ctor
	|
	|-RVA: 0x1958C80 Offset: 0x1957280 VA: 0x181958C80
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|
	|-RVA: 0x1958F50 Offset: 0x1957550 VA: 0x181958F50
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
	|-RVA: 0x1958840 Offset: 0x1956E40 VA: 0x181958840
	|-Queue<RCon.Command>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958760 Offset: 0x1956D60 VA: 0x181958760
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19587D0 Offset: 0x1956DD0 VA: 0x1819587D0
	|-Queue<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958920 Offset: 0x1956F20 VA: 0x181958920
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19588B0 Offset: 0x1956EB0 VA: 0x1819588B0
	|-Queue<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1958680 Offset: 0x1956C80 VA: 0x181958680
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19586F0 Offset: 0x1956CF0 VA: 0x1819586F0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19563D0 Offset: 0x19549D0 VA: 0x1819563D0
	|-Queue<BaseEntity>.Clear
	|-Queue<RCon.Command>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|
	|-RVA: 0x19563B0 Offset: 0x19549B0 VA: 0x1819563B0
	|-Queue<int>.Clear
	|-Queue<IntPtr>.Clear
	|-Queue<ulong>.Clear
	|-Queue<AsyncGPUReadbackRequest>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1958160 Offset: 0x1956760 VA: 0x181958160
	|-Queue<RCon.Command>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957ED0 Offset: 0x19564D0 VA: 0x181957ED0
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957720 Offset: 0x1955D20 VA: 0x181957720
	|-Queue<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957490 Offset: 0x1955A90 VA: 0x181957490
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1957C40 Offset: 0x1956240 VA: 0x181957C40
	|-Queue<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19583F0 Offset: 0x19569F0 VA: 0x1819583F0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19579B0 Offset: 0x1955FB0 VA: 0x1819579B0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19569A0 Offset: 0x1954FA0 VA: 0x1819569A0
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
	|-RVA: 0x1956BF0 Offset: 0x19551F0 VA: 0x181956BF0
	|-Queue<RCon.Command>.Enqueue
	|
	|-RVA: 0x1956CE0 Offset: 0x19552E0 VA: 0x181956CE0
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x1956A70 Offset: 0x1955070 VA: 0x181956A70
	|-Queue<IntPtr>.Enqueue
	|-Queue<ulong>.Enqueue
	|
	|-RVA: 0x19568E0 Offset: 0x1954EE0 VA: 0x1819568E0
	|-Queue<AsyncGPUReadbackRequest>.Enqueue
	|
	|-RVA: 0x1956B20 Offset: 0x1955120 VA: 0x181956B20
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956D90 Offset: 0x1955390 VA: 0x181956D90
	|-Queue<string>.GetEnumerator
	|-Queue<IntPtr>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|-Queue<ulong>.GetEnumerator
	|
	|-RVA: 0x1956E40 Offset: 0x1955440 VA: 0x181956E40
	|-Queue<RCon.Command>.GetEnumerator
	|
	|-RVA: 0x1956EB0 Offset: 0x19554B0 VA: 0x181956EB0
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x1956DE0 Offset: 0x19553E0 VA: 0x181956DE0
	|-Queue<AsyncGPUReadbackRequest>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19573C0 Offset: 0x19559C0 VA: 0x1819573C0
	|-Queue<RCon.Command>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1957320 Offset: 0x1955920 VA: 0x181957320
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1957280 Offset: 0x1955880 VA: 0x181957280
	|-Queue<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x19571E0 Offset: 0x19557E0 VA: 0x1819571E0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19573C0 Offset: 0x19559C0 VA: 0x1819573C0
	|-Queue<RCon.Command>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1957320 Offset: 0x1955920 VA: 0x181957320
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1957280 Offset: 0x1955880 VA: 0x181957280
	|-Queue<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x19571E0 Offset: 0x19557E0 VA: 0x1819571E0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1956510 Offset: 0x1954B10 VA: 0x181956510
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
	|-RVA: 0x1956670 Offset: 0x1954C70 VA: 0x181956670
	|-Queue<RCon.Command>.Dequeue
	|
	|-RVA: 0x19567A0 Offset: 0x1954DA0 VA: 0x1819567A0
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x19565D0 Offset: 0x1954BD0 VA: 0x1819565D0
	|-Queue<IntPtr>.Dequeue
	|-Queue<ulong>.Dequeue
	|
	|-RVA: 0x1956830 Offset: 0x1954E30 VA: 0x181956830
	|-Queue<AsyncGPUReadbackRequest>.Dequeue
	|
	|-RVA: 0x1956440 Offset: 0x1954A40 VA: 0x181956440
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957010 Offset: 0x1955610 VA: 0x181957010
	|-Queue<ulong>.Peek
	|-Queue<IntPtr>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x1956F90 Offset: 0x1955590 VA: 0x181956F90
	|-Queue<AsyncGPUReadbackRequest>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|
	|-RVA: 0x1957070 Offset: 0x1955670 VA: 0x181957070
	|-Queue<RCon.Command>.Peek
	|
	|-RVA: 0x1956F30 Offset: 0x1955530 VA: 0x181956F30
	|-Queue<int>.Peek
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1957100 Offset: 0x1955700 VA: 0x181957100
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
	|-RVA: 0x1956F00 Offset: 0x1955500 VA: 0x181956F00
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
	|-RVA: 0x19589F0 Offset: 0x1956FF0 VA: 0x1819589F0
	|-Queue<RCon.Command>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958A50 Offset: 0x1957050 VA: 0x181958A50
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958990 Offset: 0x1956F90 VA: 0x181958990
	|-Queue<IntPtr>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958B10 Offset: 0x1957110 VA: 0x181958B10
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958B70 Offset: 0x1957170 VA: 0x181958B70
	|-Queue<ulong>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958AB0 Offset: 0x19570B0 VA: 0x181958AB0
	|-Queue<AsyncGPUReadbackRequest>.ThrowForEmptyQueue
	|
	|-RVA: 0x1958BD0 Offset: 0x19571D0 VA: 0x181958BD0
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

	// RVA: 0x1520B10 Offset: 0x151F110 VA: 0x181520B10
	public void .ctor() { }

}

public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 3171
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1520B40 Offset: 0x151F140 VA: 0x181520B40
	public void .ctor() { }

	// RVA: 0x1520B70 Offset: 0x151F170 VA: 0x181520B70 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 3173
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1536D00 Offset: 0x1535300 VA: 0x181536D00
	public void .ctor() { }

	// RVA: 0x1536D30 Offset: 0x1535330 VA: 0x181536D30 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 3176
{	// Methods

	// RVA: 0x1536B80 Offset: 0x1535180 VA: 0x181536B80
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
	// RVA: 0x136F0A0 Offset: 0x136D6A0 VA: 0x18136F0A0
	internal void set_ConnectionInfo(ConnectionInfo value) { }

	// RVA: 0x136E700 Offset: 0x136CD00 VA: 0x18136E700
	public void Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x136F070 Offset: 0x136D670 VA: 0x18136F070 Slot: 3
	public override string ToString() { }

	// RVA: 0x136E900 Offset: 0x136CF00 VA: 0x18136E900 Slot: 4
	public virtual void OnConnectionChanged(ConnectionInfo info) { }

	// RVA: 0x136E810 Offset: 0x136CE10 VA: 0x18136E810 Slot: 5
	public virtual void OnConnecting(ConnectionInfo info) { }

	// RVA: 0x136E720 Offset: 0x136CD20 VA: 0x18136E720 Slot: 6
	public virtual void OnConnected(ConnectionInfo info) { }

	// RVA: 0x136EBF0 Offset: 0x136D1F0 VA: 0x18136EBF0 Slot: 7
	public virtual void OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x136EEA0 Offset: 0x136D4A0 VA: 0x18136EEA0
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0x136EDD0 Offset: 0x136D3D0 VA: 0x18136EDD0
	internal void ReceiveMessage(ref NetMsg* msg) { }

	// RVA: 0x136ECE0 Offset: 0x136D2E0 VA: 0x18136ECE0 Slot: 8
	public virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x136F090 Offset: 0x136D690 VA: 0x18136F090
	public void .ctor() { }

}

internal sealed class NetDebugFunc : MulticastDelegate // TypeDefIndex: 5179
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDE2B20 Offset: 0xDE1120 VA: 0x180DE2B20 Slot: 12
	public virtual void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg) { }

	// RVA: 0xDE2A90 Offset: 0xDE1090 VA: 0x180DE2A90 Slot: 13
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

	// RVA: 0x1374FB0 Offset: 0x13735B0 VA: 0x181374FB0
	internal static extern void InternalClear(ref NetAddress self) { }

	// RVA: 0x1375030 Offset: 0x1373630 VA: 0x181375030
	internal static extern void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort) { }

	// RVA: 0x13750D0 Offset: 0x13736D0 VA: 0x1813750D0
	internal static extern void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x1374B00 Offset: 0x1373100 VA: 0x181374B00
	public static NetAddress AnyIp(ushort port) { }

	// RVA: 0x1374BB0 Offset: 0x13731B0 VA: 0x181374BB0
	public static NetAddress From(string addrStr, ushort port) { }

	// RVA: 0x1374DD0 Offset: 0x13733D0 VA: 0x181374DD0
	public static NetAddress From(IPAddress address, ushort port) { }

	// RVA: 0x1375360 Offset: 0x1373960 VA: 0x181375360
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

	// RVA: 0x13753F0 Offset: 0x13739F0 VA: 0x1813753F0
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

	// RVA: 0x220E710 Offset: 0x220CD10 VA: 0x18220E710
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public string get_RecordFilename() { }

	// RVA: 0xBC8E80 Offset: 0xBC7480 VA: 0x180BC8E80
	public int get_RecordFilesize() { }

	// RVA: 0x220E000 Offset: 0x220C600 VA: 0x18220E000
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x220E110 Offset: 0x220C710 VA: 0x18220E110
	public void StopRecording() { }

	// RVA: 0x795CF0 Offset: 0x7942F0 VA: 0x180795CF0
	public bool get_IsRecording() { }

	// RVA: 0x220DB00 Offset: 0x220C100 VA: 0x18220DB00
	public void RecordPacket(byte packetId, IProto proto) { }

	// RVA: 0x220DD80 Offset: 0x220C380 VA: 0x18220DD80
	public void RecordPacket(Stream stream) { }

	// RVA: 0x220DA60 Offset: 0x220C060 VA: 0x18220DA60 Slot: 4
	public virtual void OnDisconnected() { }

	// RVA: 0x220E790 Offset: 0x220CD90 VA: 0x18220E790
	public bool get_isAuthenticated() { }

	// RVA: 0x220DF80 Offset: 0x220C580 VA: 0x18220DF80
	public void ResetPacketsPerSecond() { }

	// RVA: 0x220D8F0 Offset: 0x220BEF0 VA: 0x18220D8F0
	public void AddPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220D8A0 Offset: 0x220BEA0 VA: 0x18220D8A0
	public void AddPacketsPerSecond(int index = 0) { }

	// RVA: 0x220D9A0 Offset: 0x220BFA0 VA: 0x18220D9A0
	public ulong GetPacketsPerSecond(Message.Type message) { }

	// RVA: 0x220D940 Offset: 0x220BF40 VA: 0x18220D940
	public ulong GetPacketsPerSecond(int index = 0) { }

	// RVA: 0x220DA00 Offset: 0x220C000 VA: 0x18220DA00
	public float GetSecondsConnected() { }

	// RVA: 0x220E4D0 Offset: 0x220CAD0 VA: 0x18220E4D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x220E5B0 Offset: 0x220CBB0 VA: 0x18220E5B0
	public void .ctor() { }

	// RVA: 0x220E550 Offset: 0x220CB50 VA: 0x18220E550
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

	// RVA: 0x220D100 Offset: 0x220B700 VA: 0x18220D100
	public void Set(string k, string v) { }

	// RVA: 0x220D080 Offset: 0x220B680 VA: 0x18220D080
	public string GetString(string k, string def = "") { }

	// RVA: 0x220CF20 Offset: 0x220B520 VA: 0x18220CF20
	public float GetFloat(string k, float def = 0) { }

	// RVA: 0x220CFD0 Offset: 0x220B5D0 VA: 0x18220CFD0
	public int GetInt(string k, int def = 0) { }

	// RVA: 0x220CE20 Offset: 0x220B420 VA: 0x18220CE20
	public bool GetBool(string k, bool def = False) { }

	// RVA: 0x220D170 Offset: 0x220B770 VA: 0x18220D170
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

	// RVA: 0x22100A0 Offset: 0x220E6A0 VA: 0x1822100A0
	public MemoryStream GetStreamForDecryption() { }

	// RVA: 0x2210530 Offset: 0x220EB30 VA: 0x182210530
	public bool Start(IntPtr data, int length) { }

	// RVA: 0x2210E40 Offset: 0x220F440 VA: 0x182210E40
	public int get_Unread() { }

	// RVA: 0x2210A40 Offset: 0x220F040 VA: 0x182210A40
	public string String(int maxLength = 256) { }

	// RVA: 0x2210930 Offset: 0x220EF30 VA: 0x182210930
	public string StringMultiLine(int maxLength = 2048) { }

	// RVA: 0x22106A0 Offset: 0x220ECA0 VA: 0x1822106A0
	private string StringInternal(int maxLength, bool allowNewLine) { }

	// RVA: 0x2210940 Offset: 0x220EF40 VA: 0x182210940
	public string StringRaw(uint maxLength = 1048576) { }

	// RVA: 0x2210A50 Offset: 0x220F050 VA: 0x182210A50
	public bool TemporaryBytesWithSize(out byte[] buffer, out int size) { }

	// RVA: 0x220FFD0 Offset: 0x220E5D0 VA: 0x18220FFD0
	public uint EntityID() { }

	// RVA: 0x220FFD0 Offset: 0x220E5D0 VA: 0x18220FFD0
	public uint GroupID() { }

	// RVA: 0x220FE70 Offset: 0x220E470 VA: 0x18220FE70
	public int BytesWithSize(byte[] buffer, uint maxLength = 4294967295) { }

	// RVA: 0x220FDA0 Offset: 0x220E3A0 VA: 0x18220FDA0
	public byte[] BytesWithSize(uint maxSize = 10485760) { }

	// RVA: 0x2210380 Offset: 0x220E980 VA: 0x182210380 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xC15300 Offset: 0xC13900 VA: 0x180C15300 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2210280 Offset: 0x220E880 VA: 0x182210280
	public byte PacketID() { }

	// RVA: 0x220FD60 Offset: 0x220E360 VA: 0x18220FD60
	public bool Bit() { }

	// RVA: 0x2210280 Offset: 0x220E880 VA: 0x182210280
	public byte UInt8() { }

	// RVA: 0x2210BC0 Offset: 0x220F1C0 VA: 0x182210BC0
	public ushort UInt16() { }

	// RVA: 0x220FFD0 Offset: 0x220E5D0 VA: 0x18220FFD0
	public uint UInt32() { }

	// RVA: 0x2210C00 Offset: 0x220F200 VA: 0x182210C00
	public ulong UInt64() { }

	// RVA: 0x2210240 Offset: 0x220E840 VA: 0x182210240
	public sbyte Int8() { }

	// RVA: 0x2210180 Offset: 0x220E780 VA: 0x182210180
	public short Int16() { }

	// RVA: 0x22101C0 Offset: 0x220E7C0 VA: 0x1822101C0
	public int Int32() { }

	// RVA: 0x2210200 Offset: 0x220E800 VA: 0x182210200
	public long Int64() { }

	// RVA: 0x2210010 Offset: 0x220E610 VA: 0x182210010
	public float Float() { }

	// RVA: 0x220FF90 Offset: 0x220E590 VA: 0x18220FF90
	public double Double() { }

	// RVA: 0x2210C40 Offset: 0x220F240 VA: 0x182210C40
	public Vector3 Vector3() { }

	// RVA: 0x22102C0 Offset: 0x220E8C0 VA: 0x1822102C0
	public Quaternion Quaternion() { }

	// RVA: 0x2210320 Offset: 0x220E920 VA: 0x182210320
	public Ray Ray() { }

	// RVA: 0x220FF30 Offset: 0x220E530 VA: 0x18220FF30
	public Color Color() { }

	// RVA: 0x2210420 Offset: 0x220EA20 VA: 0x182210420 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21C0F40 Offset: 0x21BF540 VA: 0x1821C0F40 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x22104B0 Offset: 0x220EAB0 VA: 0x1822104B0 Slot: 25
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

	// RVA: 0x2210050 Offset: 0x220E650 VA: 0x182210050 Slot: 18
	public override void Flush() { }

	// RVA: 0x2210CF0 Offset: 0x220F2F0 VA: 0x182210CF0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2210CA0 Offset: 0x220F2A0 VA: 0x182210CA0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2210DC0 Offset: 0x220F3C0 VA: 0x182210DC0
	public void .ctor() { }

	// RVA: 0x2210D40 Offset: 0x220F340 VA: 0x182210D40
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

	// RVA: 0x22120D0 Offset: 0x22106D0 VA: 0x1822120D0
	public void .ctor(BaseNetwork netwrite) { }

	// RVA: 0x2211A70 Offset: 0x2210070 VA: 0x182211A70
	public void Shutdown() { }

	// RVA: 0x2211AF0 Offset: 0x22100F0 VA: 0x182211AF0
	public bool Start() { }

	// RVA: 0x22119D0 Offset: 0x220FFD0 VA: 0x1822119D0
	public void Send(SendInfo info) { }

	// RVA: 0x2211720 Offset: 0x220FD20 VA: 0x182211720
	public void PacketID(Message.Type val) { }

	// RVA: 0x2211E90 Offset: 0x2210490 VA: 0x182211E90
	public void UInt8(byte val) { }

	// RVA: 0x2211DA0 Offset: 0x22103A0 VA: 0x182211DA0
	public void UInt16(ushort val) { }

	// RVA: 0x2211DF0 Offset: 0x22103F0 VA: 0x182211DF0
	public void UInt32(uint val) { }

	// RVA: 0x2211E40 Offset: 0x2210440 VA: 0x182211E40
	public void UInt64(ulong val) { }

	// RVA: 0x22116D0 Offset: 0x220FCD0 VA: 0x1822116D0
	public void Int8(sbyte val) { }

	// RVA: 0x22115E0 Offset: 0x220FBE0 VA: 0x1822115E0
	public void Int16(short val) { }

	// RVA: 0x2211630 Offset: 0x220FC30 VA: 0x182211630
	public void Int32(int val) { }

	// RVA: 0x2211680 Offset: 0x220FC80 VA: 0x182211680
	public void Int64(long val) { }

	// RVA: 0x2210E90 Offset: 0x220F490 VA: 0x182210E90
	public void Bool(bool val) { }

	// RVA: 0x2211590 Offset: 0x220FB90 VA: 0x182211590
	public void Float(float val) { }

	// RVA: 0x2211270 Offset: 0x220F870 VA: 0x182211270
	public void Double(double val) { }

	// RVA: 0x2211120 Offset: 0x220F720 VA: 0x182211120
	public void Bytes(byte[] val) { }

	// RVA: 0x2211B00 Offset: 0x2210100 VA: 0x182211B00
	public void String(string val) { }

	// RVA: 0x2211EE0 Offset: 0x22104E0 VA: 0x182211EE0
	public void Vector3(in Vector3 obj) { }

	// RVA: 0x2211160 Offset: 0x220F760 VA: 0x182211160
	public void Quaternion(in Quaternion obj) { }

	// RVA: 0x2211770 Offset: 0x220FD70 VA: 0x182211770
	public void Ray(in Ray obj) { }

	// RVA: 0x2211160 Offset: 0x220F760 VA: 0x182211160
	public void Color(in Color obj) { }

	// RVA: 0x2211540 Offset: 0x220FB40 VA: 0x182211540
	public void EntityID(uint id) { }

	// RVA: 0x2211540 Offset: 0x220FB40 VA: 0x182211540
	public void GroupID(uint id) { }

	// RVA: 0x2210EF0 Offset: 0x220F4F0 VA: 0x182210EF0
	public void BytesWithSize(MemoryStream val) { }

	// RVA: 0x2210FB0 Offset: 0x220F5B0 VA: 0x182210FB0
	public void BytesWithSize(byte[] b) { }

	// RVA: 0x2210FD0 Offset: 0x220F5D0 VA: 0x182210FD0
	public void BytesWithSize(byte[] b, int length) { }

	// RVA: -1 Offset: -1
	private void Write<T>(in T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15751E0 Offset: 0x15737E0 VA: 0x1815751E0
	|-NetWrite.Write<byte>
	|-NetWrite.Write<sbyte>
	|
	|-RVA: 0x1575250 Offset: 0x1573850 VA: 0x181575250
	|-NetWrite.Write<double>
	|-NetWrite.Write<long>
	|-NetWrite.Write<ulong>
	|
	|-RVA: 0x15752C0 Offset: 0x15738C0 VA: 0x1815752C0
	|-NetWrite.Write<short>
	|-NetWrite.Write<ushort>
	|
	|-RVA: 0x1575330 Offset: 0x1573930 VA: 0x181575330
	|-NetWrite.Write<int>
	|-NetWrite.Write<float>
	|-NetWrite.Write<uint>
	*/

	// RVA: 0x22112C0 Offset: 0x220F8C0 VA: 0x1822112C0
	private void EnsureCapacity(int spaceRequired) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 31
	public override byte[] GetBuffer() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x22121C0 Offset: 0x22107C0 VA: 0x1822121C0 Slot: 10
	public override long get_Length() { }

	// RVA: 0x22121D0 Offset: 0x22107D0 VA: 0x1822121D0 Slot: 11
	public override long get_Position() { }

	// RVA: 0x22121E0 Offset: 0x22107E0 VA: 0x1822121E0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void Flush() { }

	// RVA: 0x2211870 Offset: 0x220FE70 VA: 0x182211870 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2211820 Offset: 0x220FE20 VA: 0x182211820 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x2212000 Offset: 0x2210600 VA: 0x182212000 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2211FB0 Offset: 0x22105B0 VA: 0x182211FB0 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x2211930 Offset: 0x220FF30 VA: 0x182211930 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2211A20 Offset: 0x2210020 VA: 0x182211A20 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2212070 Offset: 0x2210670 VA: 0x182212070
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

	// RVA: 0x2212430 Offset: 0x2210A30 VA: 0x182212430
	public void Destroy() { }

	// RVA: 0x2212460 Offset: 0x2210A60 VA: 0x182212460 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2212780 Offset: 0x2210D80 VA: 0x182212780
	public void StartSubscriber() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void OnConnected(Connection c) { }

	// RVA: 0x22124E0 Offset: 0x2210AE0 VA: 0x1822124E0
	public void OnDisconnected() { }

	// RVA: 0x22123A0 Offset: 0x22109A0 VA: 0x1822123A0
	public void CloseSubscriber() { }

	// RVA: 0x2213140 Offset: 0x2211740 VA: 0x182213140
	public bool UpdateGroups(Vector3 position) { }

	// RVA: 0x22128C0 Offset: 0x2210EC0 VA: 0x1822128C0
	public bool SwitchGroup(Group newGroup) { }

	// RVA: 0x2212510 Offset: 0x2210B10 VA: 0x182212510
	internal void OnGroupTransition(Group oldGroup) { }

	// RVA: 0x22126A0 Offset: 0x2210CA0 VA: 0x1822126A0
	internal void OnSubscriptionChange() { }

	// RVA: 0x2212FD0 Offset: 0x22115D0 VA: 0x182212FD0
	public bool SwitchSecondaryGroup(Group newGroup) { }

	// RVA: 0x2212200 Offset: 0x2210800 VA: 0x182212200
	private void AddVisibleFromNear(Group additionalGroup, List<Group> groupsVisible) { }

	// RVA: 0x2213580 Offset: 0x2211B80 VA: 0x182213580
	public bool UpdateSubscriptions(int removeLimit, int addLimit) { }

	// RVA: 0x22132E0 Offset: 0x22118E0 VA: 0x1822132E0
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

	// RVA: 0x2207E10 Offset: 0x2206410 VA: 0x182207E10
	public void .ctor(Stream stream) { }

	// RVA: 0xBA4BA0 Offset: 0xBA31A0 VA: 0x180BA4BA0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA4BD0 Offset: 0xBA31D0 VA: 0x180BA4BD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA4C00 Offset: 0xBA3200 VA: 0x180BA4C00 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA4C30 Offset: 0xBA3230 VA: 0x180BA4C30 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA4C60 Offset: 0xBA3260 VA: 0x180BA4C60 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA4C90 Offset: 0xBA3290 VA: 0x180BA4C90 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xBA4A00 Offset: 0xBA3000 VA: 0x180BA4A00 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA4A30 Offset: 0xBA3030 VA: 0x180BA4A30 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xBA4A60 Offset: 0xBA3060 VA: 0x180BA4A60 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2207DB0 Offset: 0x22063B0 VA: 0x182207DB0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xBA46F0 Offset: 0xBA2CF0 VA: 0x180BA46F0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22079F0 Offset: 0x2205FF0 VA: 0x1822079F0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xBA4890 Offset: 0xBA2E90 VA: 0x180BA4890 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2207C70 Offset: 0x2206270 VA: 0x182207C70 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xBA49A0 Offset: 0xBA2FA0 VA: 0x180BA49A0 Slot: 18
	public override void Flush() { }

	// RVA: 0x16350F0 Offset: 0x16336F0 VA: 0x1816350F0 Slot: 16
	public override void Close() { }

	// RVA: 0x2207C20 Offset: 0x2206220 VA: 0x182207C20 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2207890 Offset: 0x2205E90 VA: 0x182207890
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

	// RVA: 0x220C760 Offset: 0x220AD60 VA: 0x18220C760
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

	// RVA: 0x2207EC0 Offset: 0x22064C0 VA: 0x182207EC0 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x2207F20 Offset: 0x2206520 VA: 0x182207F20 Slot: 4
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

	// RVA: 0x2209520 Offset: 0x2207B20 VA: 0x182209520
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

	// RVA: 0xFC6630 Offset: 0xFC4C30 VA: 0x180FC6630
	public void Start() { }

	// RVA: 0xFC6A90 Offset: 0xFC5090 VA: 0x180FC6A90
	public void set_Enabled(bool value) { }

	// RVA: 0xFC6680 Offset: 0xFC4C80 VA: 0x180FC6680
	public void UpdateFrom(Stats incomingStats) { }

	// RVA: 0xFC6A30 Offset: 0xFC5030 VA: 0x180FC6A30
	public void .ctor() { }

}

private sealed class NetGraph.<>c // TypeDefIndex: 7076
{	// Fields
	public static readonly NetGraph.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xFD92D0 Offset: 0xFD78D0 VA: 0x180FD92D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8770 Offset: 0xFD6D70 VA: 0x180FD8770
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

	// RVA: 0xFC5F70 Offset: 0xFC4570 VA: 0x180FC5F70
	internal void Hide() { }

	// RVA: 0xFC5FC0 Offset: 0xFC45C0 VA: 0x180FC5FC0
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

	// RVA: 0xFC6110 Offset: 0xFC4710 VA: 0x180FC6110
	private void Awake() { }

	// RVA: 0x4DC140 Offset: 0x4DA740 VA: 0x1804DC140
	internal void Hide() { }

	// RVA: 0xFC6160 Offset: 0xFC4760 VA: 0x180FC6160
	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class NetGraphRow.<>c // TypeDefIndex: 7079
{	// Fields
	public static readonly NetGraphRow.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__10_0; // 0x8

	// Methods

	// RVA: 0xFD9270 Offset: 0xFD7870 VA: 0x180FD9270
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xFD8730 Offset: 0xFD6D30 VA: 0x180FD8730
	internal long <UpdateFrom>b__10_0(KeyValuePair<string, Stats.Node> y) { }

}

internal sealed class NetProtect : INetProtect // TypeDefIndex: 7165
{	// Methods

	// RVA: 0x22E6F70 Offset: 0x22E5570 VA: 0x1822E6F70
	public void .ctor(IntPtr Instance) { }

	// RVA: 0x22E6E70 Offset: 0x22E5470 VA: 0x1822E6E70 Slot: 4
	public bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E6EF0 Offset: 0x22E54F0 VA: 0x1822E6EF0 Slot: 5
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
	// RVA: 0x1071520 Offset: 0x106FB20 VA: 0x181071520
	public static Client get_cl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1071560 Offset: 0x106FB60 VA: 0x181071560
	private static void set_cl(Client value) { }

	// RVA: 0x1071310 Offset: 0x106F910 VA: 0x181071310
	public static void ClientInit(Client newclient) { }

	// RVA: 0x10713A0 Offset: 0x106F9A0 VA: 0x1810713A0
	public static void StartDemoPlayback(Reader demo) { }

	// RVA: 0x1071460 Offset: 0x106FA60 VA: 0x181071460
	public static void StopDemoPlayback() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class NetworkInfoGeneralText : MonoBehaviour // TypeDefIndex: 9286
{	// Fields
	public TextMeshProUGUI text; // 0x18

	// Methods

	// RVA: 0x9D0A80 Offset: 0x9CF080 VA: 0x1809D0A80
	private void Update() { }

	// RVA: 0x9D0A80 Offset: 0x9CF080 VA: 0x1809D0A80
	private void UpdateText() { }

	// RVA: 0x9D0A00 Offset: 0x9CF000 VA: 0x1809D0A00
	private static string ChannelStat(int window, int left) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public abstract class NetworkCryptography : INetworkCryptocraphy // TypeDefIndex: 10237
{	// Fields
	private MemoryStream buffer; // 0x10

	// Methods

	// RVA: 0x7CEA80 Offset: 0x7CD080 VA: 0x1807CEA80 Slot: 6
	public MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CE950 Offset: 0x7CCF50 VA: 0x1807CE950 Slot: 7
	public MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CEB80 Offset: 0x7CD180 VA: 0x1807CEB80 Slot: 8
	public void Encrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CEA50 Offset: 0x7CD050 VA: 0x1807CEA50 Slot: 9
	public void Decrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CEBB0 Offset: 0x7CD1B0 VA: 0x1807CEBB0 Slot: 4
	public bool IsEnabledIncoming(Connection connection) { }

	// RVA: 0x7CEBD0 Offset: 0x7CD1D0 VA: 0x1807CEBD0 Slot: 5
	public bool IsEnabledOutgoing(Connection connection) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: 0x7CE8E0 Offset: 0x7CCEE0 VA: 0x1807CE8E0
	protected void .ctor() { }

}

public class NetworkCryptographyClient : NetworkCryptography // TypeDefIndex: 10238
{	// Methods

	// RVA: 0x7CE7F0 Offset: 0x7CCDF0 VA: 0x1807CE7F0 Slot: 10
	protected override void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7CE700 Offset: 0x7CCD00 VA: 0x1807CE700 Slot: 11
	protected override void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7CE8E0 Offset: 0x7CCEE0 VA: 0x1807CE8E0
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

	// RVA: 0x9D0B80 Offset: 0x9CF180 VA: 0x1809D0B80
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
	|-RVA: 0x15753A0 Offset: 0x15739A0 VA: 0x1815753A0
	|-NetworkWriteEx.WriteObject<bool>
	|
	|-RVA: 0x1575EB0 Offset: 0x15744B0 VA: 0x181575EB0
	|-NetworkWriteEx.WriteObject<byte>
	|
	|-RVA: 0x15769C0 Offset: 0x1574FC0 VA: 0x1815769C0
	|-NetworkWriteEx.WriteObject<int>
	|
	|-RVA: 0x15774C0 Offset: 0x1575AC0 VA: 0x1815774C0
	|-NetworkWriteEx.WriteObject<object>
	|
	|-RVA: 0x1577EC0 Offset: 0x15764C0 VA: 0x181577EC0
	|-NetworkWriteEx.WriteObject<sbyte>
	|
	|-RVA: 0xCFBAE0 Offset: 0xCFA0E0 VA: 0x180CFBAE0
	|-NetworkWriteEx.WriteObject<float>
	|
	|-RVA: 0xCFC610 Offset: 0xCFAC10 VA: 0x180CFC610
	|-NetworkWriteEx.WriteObject<uint>
	|
	|-RVA: 0xCFD110 Offset: 0xCFB710 VA: 0x180CFD110
	|-NetworkWriteEx.WriteObject<ulong>
	|
	|-RVA: 0xCFA460 Offset: 0xCF8A60 VA: 0x180CFA460
	|-NetworkWriteEx.WriteObject<Color>
	|
	|-RVA: 0xCFAF40 Offset: 0xCF9540 VA: 0x180CFAF40
	|-NetworkWriteEx.WriteObject<Ray>
	|
	|-RVA: 0xCFDC20 Offset: 0xCFC220 VA: 0x180CFDC20
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
	|-RVA: 0xD59990 Offset: 0xD57F90 VA: 0x180D59990
	|-NetworkedProperty<int>.set_Value
	|
	|-RVA: 0xD59910 Offset: 0xD57F10 VA: 0x180D59910
	|-NetworkedProperty<object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseEntity entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD59840 Offset: 0xD57E40 VA: 0x180D59840
	|-NetworkedProperty<int>..ctor
	|-NetworkedProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(NetworkedProperty<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD59880 Offset: 0xD57E80 VA: 0x180D59880
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

	// RVA: 0x87B1D0 Offset: 0x8797D0 VA: 0x18087B1D0
	public void .ctor() { }

	// RVA: 0x87B0D0 Offset: 0x8796D0 VA: 0x18087B0D0 Slot: 42
	private IEnumerator<Variant> System.Collections.Generic.IEnumerable<TinyJSON.Variant>.GetEnumerator() { }

	// RVA: 0x87B150 Offset: 0x879750 VA: 0x18087B150 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x87AE70 Offset: 0x879470 VA: 0x18087AE70
	public void Add(Variant item) { }

	// RVA: 0x87B2A0 Offset: 0x8798A0 VA: 0x18087B2A0 Slot: 40
	public override Variant get_Item(int index) { }

	// RVA: 0x87B300 Offset: 0x879900 VA: 0x18087B300 Slot: 41
	public override void set_Item(int index, Variant value) { }

	// RVA: 0x87B260 Offset: 0x879860 VA: 0x18087B260
	public int get_Count() { }

	// RVA: 0x87AED0 Offset: 0x8794D0 VA: 0x18087AED0
	internal bool CanBeMultiRankArray(int[] rankLengths) { }

	// RVA: 0x87AEE0 Offset: 0x8794E0 VA: 0x18087AEE0
	private bool CanBeMultiRankArray(int rank, int[] rankLengths) { }

}

public sealed class ProxyBoolean : Variant // TypeDefIndex: 11584
{	// Fields
	private readonly bool value; // 0x10

	// Methods

	// RVA: 0x87B3B0 Offset: 0x8799B0 VA: 0x18087B3B0
	public void .ctor(bool value) { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x87B370 Offset: 0x879970 VA: 0x18087B370 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public sealed class ProxyNumber : Variant // TypeDefIndex: 11585
{	// Fields
	private static readonly char[] floatingPointCharacters; // 0x0
	private readonly IConvertible value; // 0x10

	// Methods

	// RVA: 0x87C290 Offset: 0x87A890 VA: 0x18087C290
	public void .ctor(IConvertible value) { }

	// RVA: 0x87B420 Offset: 0x879A20 VA: 0x18087B420
	private static IConvertible Parse(string value) { }

	// RVA: 0x87B750 Offset: 0x879D50 VA: 0x18087B750 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x87B810 Offset: 0x879E10 VA: 0x18087B810 Slot: 25
	public override byte ToByte(IFormatProvider provider) { }

	// RVA: 0x87B8D0 Offset: 0x879ED0 VA: 0x18087B8D0 Slot: 26
	public override char ToChar(IFormatProvider provider) { }

	// RVA: 0x87B990 Offset: 0x879F90 VA: 0x18087B990 Slot: 27
	public override Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x87BA70 Offset: 0x87A070 VA: 0x18087BA70 Slot: 28
	public override double ToDouble(IFormatProvider provider) { }

	// RVA: 0x87BB30 Offset: 0x87A130 VA: 0x18087BB30 Slot: 29
	public override short ToInt16(IFormatProvider provider) { }

	// RVA: 0x87BBF0 Offset: 0x87A1F0 VA: 0x18087BBF0 Slot: 30
	public override int ToInt32(IFormatProvider provider) { }

	// RVA: 0x87BCB0 Offset: 0x87A2B0 VA: 0x18087BCB0 Slot: 31
	public override long ToInt64(IFormatProvider provider) { }

	// RVA: 0x87BD70 Offset: 0x87A370 VA: 0x18087BD70 Slot: 32
	public override sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x87BE30 Offset: 0x87A430 VA: 0x18087BE30 Slot: 33
	public override float ToSingle(IFormatProvider provider) { }

	// RVA: 0x87BEF0 Offset: 0x87A4F0 VA: 0x18087BEF0 Slot: 34
	public override string ToString(IFormatProvider provider) { }

	// RVA: 0x87BFB0 Offset: 0x87A5B0 VA: 0x18087BFB0 Slot: 35
	public override ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x87C070 Offset: 0x87A670 VA: 0x18087C070 Slot: 36
	public override uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x87C130 Offset: 0x87A730 VA: 0x18087C130 Slot: 37
	public override ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x87C1F0 Offset: 0x87A7F0 VA: 0x18087C1F0
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

	// RVA: 0x87C850 Offset: 0x87AE50 VA: 0x18087C850
	public void .ctor() { }

	// RVA: 0x87C6E0 Offset: 0x87ACE0 VA: 0x18087C6E0 Slot: 42
	private IEnumerator<KeyValuePair<string, Variant>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TinyJSON.Variant>>.GetEnumerator() { }

	// RVA: 0x87C760 Offset: 0x87AD60 VA: 0x18087C760 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x87C670 Offset: 0x87AC70 VA: 0x18087C670
	public void Add(string key, Variant item) { }

	// RVA: 0x87C7E0 Offset: 0x87ADE0 VA: 0x18087C7E0
	public bool TryGetValue(string key, out Variant item) { }

	// RVA: 0x87C9E0 Offset: 0x87AFE0 VA: 0x18087C9E0
	public string get_TypeHint() { }

	// RVA: 0x87C930 Offset: 0x87AF30 VA: 0x18087C930 Slot: 38
	public override Variant get_Item(string key) { }

	// RVA: 0x87CB10 Offset: 0x87B110 VA: 0x18087CB10 Slot: 39
	public override void set_Item(string key, Variant value) { }

	// RVA: 0x87C8E0 Offset: 0x87AEE0 VA: 0x18087C8E0
	public int get_Count() { }

	// RVA: 0x87C990 Offset: 0x87AF90 VA: 0x18087C990
	public Dictionary.KeyCollection<string, Variant> get_Keys() { }

	// RVA: 0x87CAC0 Offset: 0x87B0C0 VA: 0x18087CAC0
	public Dictionary.ValueCollection<string, Variant> get_Values() { }

}

public sealed class ProxyString : Variant // TypeDefIndex: 11587
{	// Fields
	private readonly string value; // 0x10

	// Methods

	// RVA: 0x87CB80 Offset: 0x87B180 VA: 0x18087CB80
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
	// RVA: 0x9FDBB0 Offset: 0x9FC1B0 VA: 0x1809FDBB0
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

