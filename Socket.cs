public class SocketAddress // TypeDefIndex: 2895
{	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x1001190 Offset: 0xFFF790 VA: 0x181001190
	public AddressFamily get_Family() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x10011F0 Offset: 0xFFF7F0 VA: 0x1810011F0
	public byte get_Item(int offset) { }

	// RVA: 0x1000C30 Offset: 0xFFF230 VA: 0x181000C30
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x1000D50 Offset: 0xFFF350 VA: 0x181000D50
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x1000BB0 Offset: 0xFFF1B0 VA: 0x181000BB0
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x1000450 Offset: 0xFFEA50 VA: 0x181000450
	internal IPAddress GetIPAddress() { }

	// RVA: 0x10006E0 Offset: 0xFFECE0 VA: 0x1810006E0
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x10001B0 Offset: 0xFFE7B0 VA: 0x1810001B0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x10002E0 Offset: 0xFFE8E0 VA: 0x1810002E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10007A0 Offset: 0xFFEDA0 VA: 0x1810007A0 Slot: 3
	public override string ToString() { }

}

public class SocketException : Win32Exception // TypeDefIndex: 3038
{	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x1001800 Offset: 0xFFFE00 VA: 0x181001800
	private static int WSAGetLastError_internal() { }

	// RVA: 0x10019C0 Offset: 0xFFFFC0 VA: 0x1810019C0
	public void .ctor() { }

	// RVA: 0x1001950 Offset: 0xFFFF50 VA: 0x181001950
	internal void .ctor(int error, string message) { }

	// RVA: 0x1001810 Offset: 0xFFFE10 VA: 0x181001810
	public void .ctor(int errorCode) { }

	// RVA: 0x1001870 Offset: 0xFFFE70 VA: 0x181001870
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x10018D0 Offset: 0xFFFED0 VA: 0x1810018D0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1001A30 Offset: 0x1000030 VA: 0x181001A30 Slot: 5
	public override string get_Message() { }

	// RVA: 0x58AC70 Offset: 0x589270 VA: 0x18058AC70
	public SocketError get_SocketErrorCode() { }

}

public class Socket : IDisposable // TypeDefIndex: 3047
{	// Fields
	private static object s_InternalSyncObject; // 0x0
	internal static bool s_SupportsIPv4; // 0x8
	internal static bool s_SupportsIPv6; // 0x9
	internal static bool s_OSSupportsIPv6; // 0xA
	internal static bool s_Initialized; // 0xB
	private static bool s_LoggingEnabled; // 0xC
	private bool is_closed; // 0x10
	private bool is_listening; // 0x11
	private bool useOverlappedIO; // 0x12
	private int linger_timeout; // 0x14
	private AddressFamily addressFamily; // 0x18
	private SocketType socketType; // 0x1C
	private ProtocolType protocolType; // 0x20
	internal SafeSocketHandle m_Handle; // 0x28
	internal EndPoint seed_endpoint; // 0x30
	internal SemaphoreSlim ReadSem; // 0x38
	internal SemaphoreSlim WriteSem; // 0x40
	internal bool is_blocking; // 0x48
	internal bool is_bound; // 0x49
	internal bool is_connected; // 0x4A
	private int m_IntCleanedUp; // 0x4C
	internal bool connect_in_progress; // 0x50
	private static AsyncCallback AcceptAsyncCallback; // 0x10
	private static IOAsyncCallback BeginAcceptCallback; // 0x18
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x20
	private static AsyncCallback ConnectAsyncCallback; // 0x28
	private static IOAsyncCallback BeginConnectCallback; // 0x30
	private static AsyncCallback DisconnectAsyncCallback; // 0x38
	private static IOAsyncCallback BeginDisconnectCallback; // 0x40
	private static AsyncCallback ReceiveAsyncCallback; // 0x48
	private static IOAsyncCallback BeginReceiveCallback; // 0x50
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x58
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x60
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x68
	private static AsyncCallback SendAsyncCallback; // 0x70
	private static IOAsyncCallback BeginSendGenericCallback; // 0x78
	private static AsyncCallback SendToAsyncCallback; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0xB9C50 Offset: 0xB9050 VA: 0x1800B9C50
	public static bool SupportsIPv4 { get; }
	public static bool OSSupportsIPv4 { get; }
	[ObsoleteAttribute] // RVA: 0xB9D20 Offset: 0xB9120 VA: 0x1800B9D20
	public static bool SupportsIPv6 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool ExclusiveAddressUse { set; }
	public int ReceiveTimeout { set; }
	public int SendTimeout { set; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public int Available { get; }
	public bool IsBound { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x1009480 Offset: 0x1007A80 VA: 0x181009480
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x1009F20 Offset: 0x1008520 VA: 0x181009F20
	public static bool get_SupportsIPv4() { }

	// RVA: 0x1009D40 Offset: 0x1008340 VA: 0x181009D40
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x1009F90 Offset: 0x1008590 VA: 0x181009F90
	public static bool get_SupportsIPv6() { }

	// RVA: 0x1009DB0 Offset: 0x10083B0 VA: 0x181009DB0
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x962AB0 Offset: 0x9610B0 VA: 0x180962AB0
	public IntPtr get_Handle() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public SocketType get_SocketType() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x100A200 Offset: 0x1008800 VA: 0x18100A200
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x100A330 Offset: 0x1008930 VA: 0x18100A330
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x100A3D0 Offset: 0x10089D0 VA: 0x18100A3D0
	public void set_SendTimeout(int value) { }

	// RVA: 0x100A0C0 Offset: 0x10086C0 VA: 0x18100A0C0
	public void set_DontFragment(bool value) { }

	// RVA: 0x1009860 Offset: 0x1007E60 VA: 0x181009860
	public bool get_DualMode() { }

	// RVA: 0x100A160 Offset: 0x1008760 VA: 0x18100A160
	public void set_DualMode(bool value) { }

	// RVA: 0x1009B80 Offset: 0x1008180 VA: 0x181009B80
	private bool get_IsDualMode() { }

	// RVA: 0x1007B00 Offset: 0x1006100 VA: 0x181007B00
	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	// RVA: 0x1007A60 Offset: 0x1006060 VA: 0x181007A60
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1007CE0 Offset: 0x10062E0 VA: 0x181007CE0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x10070A0 Offset: 0x10056A0 VA: 0x1810070A0
	public int Receive(byte[] buffer) { }

	// RVA: 0x10070E0 Offset: 0x10056E0 VA: 0x1810070E0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x10069D0 Offset: 0x1004FD0 VA: 0x1810069D0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x10053A0 Offset: 0x10039A0 VA: 0x1810053A0
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x10083C0 Offset: 0x10069C0 VA: 0x1810083C0
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x10034B0 Offset: 0x1001AB0 VA: 0x1810034B0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1004DE0 Offset: 0x10033E0 VA: 0x181004DE0
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x10026F0 Offset: 0x1000CF0 VA: 0x1810026F0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1004B30 Offset: 0x1003130 VA: 0x181004B30
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x1009A80 Offset: 0x1008080 VA: 0x181009A80
	private static object get_InternalSyncObject() { }

	// RVA: 0x1009850 Offset: 0x1007E50 VA: 0x181009850
	internal bool get_CleanedUp() { }

	// RVA: 0x1005680 Offset: 0x1003C80 VA: 0x181005680
	internal static void InitializeSockets() { }

	// RVA: 0x10045D0 Offset: 0x1002BD0 VA: 0x1810045D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1005A90 Offset: 0x1004090 VA: 0x181005A90
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1009370 Offset: 0x1007970 VA: 0x181009370
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1008890 Offset: 0x1006E90 VA: 0x181008890
	private void SocketDefaults() { }

	// RVA: 0x1008A60 Offset: 0x1007060 VA: 0x181008A60
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x10097A0 Offset: 0x1007DA0 VA: 0x1810097A0
	public int get_Available() { }

	// RVA: 0x1001EA0 Offset: 0x10004A0 VA: 0x181001EA0
	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	// RVA: 0x1001FC0 Offset: 0x10005C0 VA: 0x181001FC0
	private static int Available_internal(IntPtr socket, out int error) { }

	// RVA: 0xBA1AA0 Offset: 0xBA00A0 VA: 0x180BA1AA0
	public bool get_IsBound() { }

	// RVA: 0x1009C50 Offset: 0x1008250 VA: 0x181009C50
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x1005F00 Offset: 0x1004500 VA: 0x181005F00
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1006030 Offset: 0x1004630 VA: 0x181006030
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_Blocking() { }

	// RVA: 0x100A000 Offset: 0x1008600 VA: 0x18100A000
	public void set_Blocking(bool value) { }

	// RVA: 0x1003AD0 Offset: 0x10020D0 VA: 0x181003AD0
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x1003BF0 Offset: 0x10021F0 VA: 0x181003BF0
	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	// RVA: 0xBA1A90 Offset: 0xBA0090 VA: 0x180BA1A90
	public bool get_Connected() { }

	// RVA: 0x100A2A0 Offset: 0x10088A0 VA: 0x18100A2A0
	public void set_NoDelay(bool value) { }

	// RVA: 0x1009E20 Offset: 0x1008420 VA: 0x181009E20
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x1007320 Offset: 0x1005920 VA: 0x181007320
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1007310 Offset: 0x1005910 VA: 0x181007310
	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x1006190 Offset: 0x1004790 VA: 0x181006190
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x1006050 Offset: 0x1004650 VA: 0x181006050
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1006040 Offset: 0x1004640 VA: 0x181006040
	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1001D50 Offset: 0x1000350 VA: 0x181001D50
	public Socket Accept() { }

	// RVA: 0x1001C10 Offset: 0x1000210 VA: 0x181001C10
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x1001FD0 Offset: 0x10005D0 VA: 0x181001FD0
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x1004720 Offset: 0x1002D20 VA: 0x181004720
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x1004640 Offset: 0x1002C40 VA: 0x181004640
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1001AD0 Offset: 0x10000D0 VA: 0x181001AD0
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x1001AC0 Offset: 0x10000C0 VA: 0x181001AC0
	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x1003950 Offset: 0x1001F50 VA: 0x181003950
	public void Bind(EndPoint localEP) { }

	// RVA: 0x1003820 Offset: 0x1001E20 VA: 0x181003820
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x1003940 Offset: 0x1001F40 VA: 0x181003940
	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x1005E00 Offset: 0x1004400 VA: 0x181005E00
	public void Listen(int backlog) { }

	// RVA: 0x1005CE0 Offset: 0x10042E0 VA: 0x181005CE0
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1005CD0 Offset: 0x10042D0 VA: 0x181005CD0
	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x1003E20 Offset: 0x1002420 VA: 0x181003E20
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1002160 Offset: 0x1000760 VA: 0x181002160
	private static void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1002900 Offset: 0x1000F00 VA: 0x181002900
	private static void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x10047E0 Offset: 0x1002DE0 VA: 0x1810047E0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1003D00 Offset: 0x1002300 VA: 0x181003D00
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1003CF0 Offset: 0x10022F0 VA: 0x181003CF0
	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1004320 Offset: 0x1002920 VA: 0x181004320
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x1004890 Offset: 0x1002E90 VA: 0x181004890
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x10041F0 Offset: 0x10027F0 VA: 0x1810041F0
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x1004310 Offset: 0x1002910 VA: 0x181004310
	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x1006F30 Offset: 0x1005530 VA: 0x181006F30
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1006A70 Offset: 0x1005070 VA: 0x181006A70
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x10024F0 Offset: 0x1000AF0 VA: 0x1810024F0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1004A50 Offset: 0x1003050 VA: 0x181004A50
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1006870 Offset: 0x1004E70 VA: 0x181006870
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10069B0 Offset: 0x1004FB0 VA: 0x1810069B0
	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1006730 Offset: 0x1004D30 VA: 0x181006730
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10069C0 Offset: 0x1004FC0 VA: 0x1810069C0
	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1006590 Offset: 0x1004B90 VA: 0x181006590
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x10022A0 Offset: 0x10008A0 VA: 0x1810022A0
	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1004940 Offset: 0x1002F40 VA: 0x181004940
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x1006440 Offset: 0x1004A40 VA: 0x181006440
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1006430 Offset: 0x1004A30 VA: 0x181006430
	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1007B30 Offset: 0x1006130 VA: 0x181007B30
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1007ED0 Offset: 0x10064D0 VA: 0x181007ED0
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1003590 Offset: 0x1001B90 VA: 0x181003590
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1002E30 Offset: 0x1001430 VA: 0x181002E30
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1004D00 Offset: 0x1003300 VA: 0x181004D00
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1007900 Offset: 0x1005F00 VA: 0x181007900
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007A50 Offset: 0x1006050 VA: 0x181007A50
	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10077C0 Offset: 0x1005DC0 VA: 0x1810077C0
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007A40 Offset: 0x1006040 VA: 0x181007A40
	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10075B0 Offset: 0x1005BB0 VA: 0x1810075B0
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1003240 Offset: 0x1001840 VA: 0x181003240
	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1003080 Offset: 0x1001680 VA: 0x181003080
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1004C50 Offset: 0x1003250 VA: 0x181004C50
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1007450 Offset: 0x1005A50 VA: 0x181007450
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x10075A0 Offset: 0x1005BA0 VA: 0x1810075A0
	private static int SendTo_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1004F00 Offset: 0x1003500 VA: 0x181004F00
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x1005100 Offset: 0x1003700 VA: 0x181005100
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x10050F0 Offset: 0x10036F0 VA: 0x1810050F0
	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1008620 Offset: 0x1006C20 VA: 0x181008620
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x1008640 Offset: 0x1006C40 VA: 0x181008640
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x10084C0 Offset: 0x1006AC0 VA: 0x1810084C0
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1008610 Offset: 0x1006C10 VA: 0x181008610
	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1005510 Offset: 0x1003B10 VA: 0x181005510
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1005240 Offset: 0x1003840 VA: 0x181005240
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1005390 Offset: 0x1003990 VA: 0x181005390
	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1003C80 Offset: 0x1002280 VA: 0x181003C80
	public void Close() { }

	// RVA: 0x1003C10 Offset: 0x1002210 VA: 0x181003C10
	public void Close(int timeout) { }

	// RVA: 0x1003C00 Offset: 0x1002200 VA: 0x181003C00
	internal static void Close_internal(IntPtr socket, out int error) { }

	// RVA: 0x1008760 Offset: 0x1006D60 VA: 0x181008760
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x1008880 Offset: 0x1006E80 VA: 0x181008880
	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x1004410 Offset: 0x1002A10 VA: 0x181004410 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1005B60 Offset: 0x1004160 VA: 0x181005B60
	private void Linger(IntPtr handle) { }

	// RVA: 0x1008C20 Offset: 0x1007220 VA: 0x181008C20
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1008A70 Offset: 0x1007070 VA: 0x181008A70
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x1008AD0 Offset: 0x10070D0 VA: 0x181008AD0
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x1008CC0 Offset: 0x10072C0 VA: 0x181008CC0
	private void ThrowIfUdp() { }

	// RVA: 0x1008D20 Offset: 0x1007320 VA: 0x181008D20
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x1006300 Offset: 0x1004900 VA: 0x181006300
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x10071A0 Offset: 0x10057A0 VA: 0x1810071A0
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1009790 Offset: 0x1007D90 VA: 0x181009790
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x1009920 Offset: 0x1007F20 VA: 0x181009920
	internal static int get_FamilyHint() { }

	// RVA: 0xFE76A0 Offset: 0xFE5CA0 VA: 0x180FE76A0
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1005B10 Offset: 0x1004110 VA: 0x181005B10
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1008E50 Offset: 0x1007450 VA: 0x181008E50
	private static void .cctor() { }

}

private struct Socket.WSABUF // TypeDefIndex: 3048
{	// Fields
	public int len; // 0x0
	public IntPtr buf; // 0x8

}

private sealed class Socket.<>c // TypeDefIndex: 3049
{	// Fields
	public static readonly Socket.<>c <>9; // 0x0
	public static IOAsyncCallback <>9__241_0; // 0x8
	public static IOAsyncCallback <>9__253_0; // 0x10

	// Methods

	// RVA: 0x100EA00 Offset: 0x100D000 VA: 0x18100EA00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100C750 Offset: 0x100AD50 VA: 0x18100C750
	internal void <BeginSend>b__241_0(IOAsyncResult s) { }

	// RVA: 0x100C6D0 Offset: 0x100ACD0 VA: 0x18100C6D0
	internal void <BeginSendTo>b__253_0(IOAsyncResult s) { }

	// RVA: 0x100C840 Offset: 0x100AE40 VA: 0x18100C840
	internal void <.cctor>b__309_0(IAsyncResult ares) { }

	// RVA: 0x100D5A0 Offset: 0x100BBA0 VA: 0x18100D5A0
	internal void <.cctor>b__309_1(IOAsyncResult ares) { }

	// RVA: 0x100D690 Offset: 0x100BC90 VA: 0x18100D690
	internal void <.cctor>b__309_2(IOAsyncResult ares) { }

	// RVA: 0x100D830 Offset: 0x100BE30 VA: 0x18100D830
	internal void <.cctor>b__309_3(IAsyncResult ares) { }

	// RVA: 0x100DAC0 Offset: 0x100C0C0 VA: 0x18100DAC0
	internal void <.cctor>b__309_4(IOAsyncResult ares) { }

	// RVA: 0x100DD90 Offset: 0x100C390 VA: 0x18100DD90
	internal void <.cctor>b__309_5(IAsyncResult ares) { }

	// RVA: 0x100E020 Offset: 0x100C620 VA: 0x18100E020
	internal void <.cctor>b__309_6(IOAsyncResult ares) { }

	// RVA: 0x100E1C0 Offset: 0x100C7C0 VA: 0x18100E1C0
	internal void <.cctor>b__309_7(IAsyncResult ares) { }

	// RVA: 0x100E3D0 Offset: 0x100C9D0 VA: 0x18100E3D0
	internal void <.cctor>b__309_8(IOAsyncResult ares) { }

	// RVA: 0x100E550 Offset: 0x100CB50 VA: 0x18100E550
	internal void <.cctor>b__309_9(IOAsyncResult ares) { }

	// RVA: 0x100CB80 Offset: 0x100B180 VA: 0x18100CB80
	internal void <.cctor>b__309_10(IAsyncResult ares) { }

	// RVA: 0x100CD90 Offset: 0x100B390 VA: 0x18100CD90
	internal void <.cctor>b__309_11(IOAsyncResult ares) { }

	// RVA: 0x100D030 Offset: 0x100B630 VA: 0x18100D030
	internal void <.cctor>b__309_12(IAsyncResult ares) { }

	// RVA: 0x100D240 Offset: 0x100B840 VA: 0x18100D240
	internal void <.cctor>b__309_13(IOAsyncResult ares) { }

	// RVA: 0x100D390 Offset: 0x100B990 VA: 0x18100D390
	internal void <.cctor>b__309_14(IAsyncResult ares) { }

}

private sealed class Socket.<>c__DisplayClass242_0 // TypeDefIndex: 3050
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100E810 Offset: 0x100CE10 VA: 0x18100E810
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

private sealed class Socket.<>c__DisplayClass254_0 // TypeDefIndex: 3051
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100E8A0 Offset: 0x100CEA0 VA: 0x18100E8A0
	internal void <BeginSendToCallback>b__0(IOAsyncResult s) { }

}

private sealed class Socket.<>c__DisplayClass298_0 // TypeDefIndex: 3052
{	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100E930 Offset: 0x100CF30 VA: 0x18100E930
	internal void <QueueIOSelectorJob>b__0(Task t) { }

}

public enum SocketError // TypeDefIndex: 3053
{	// Fields
	public int value__; // 0x0
	public const SocketError Success = 0;
	public const SocketError SocketError = -1;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;

}

public enum SocketFlags // TypeDefIndex: 3054
{	// Fields
	public int value__; // 0x0
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;

}

public enum SocketOptionLevel // TypeDefIndex: 3055
{	// Fields
	public int value__; // 0x0
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;

}

public enum SocketOptionName // TypeDefIndex: 3056
{	// Fields
	public int value__; // 0x0
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = -129;
	public const SocketOptionName ExclusiveAddressUse = -5;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;

}

public enum SocketShutdown // TypeDefIndex: 3057
{	// Fields
	public int value__; // 0x0
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;

}

public enum SocketType // TypeDefIndex: 3058
{	// Fields
	public int value__; // 0x0
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = -1;

}

public class SocketAsyncEventArgs : EventArgs // TypeDefIndex: 3063
{	// Fields
	internal int in_progress; // 0x10
	internal EndPoint remote_ep; // 0x18
	internal Socket current_socket; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Socket <AcceptSocket>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <BytesTransferred>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SocketError <SocketError>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x38

	// Properties
	public Socket AcceptSocket { get; set; }
	internal int BytesTransferred { set; }
	public SocketError SocketError { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_SocketError(SocketError value) { }

	// RVA: 0x1001290 Offset: 0xFFF890 VA: 0x181001290
	internal void Complete() { }

	// RVA: 0x10012B0 Offset: 0xFFF8B0 VA: 0x1810012B0 Slot: 4
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

}

internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 3064
{	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public byte[] Buffer; // 0x50
	public int Offset; // 0x58
	public int Size; // 0x5C
	public SocketFlags SockFlags; // 0x60
	public Socket AcceptSocket; // 0x68
	public IPAddress[] Addresses; // 0x70
	public int Port; // 0x78
	public IList<ArraySegment<byte>> Buffers; // 0x80
	public bool ReuseSocket; // 0x88
	public int CurrentAddress; // 0x8C
	public Socket AcceptedSocket; // 0x90
	public int Total; // 0x98
	internal int error; // 0x9C
	public int EndCalled; // 0xA0

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x10017B0 Offset: 0xFFFDB0 VA: 0x1810017B0
	public IntPtr get_Handle() { }

	// RVA: 0x10016E0 Offset: 0xFFFCE0 VA: 0x1810016E0
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1001730 Offset: 0xFFFD30 VA: 0x181001730
	public SocketError get_ErrorCode() { }

	// RVA: 0x1001300 Offset: 0xFFF900 VA: 0x181001300
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x10013D0 Offset: 0xFFF9D0 VA: 0x1810013D0 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x1001490 Offset: 0xFFFA90 VA: 0x181001490
	public void Complete() { }

	// RVA: 0x1001480 Offset: 0xFFFA80 VA: 0x181001480
	public void Complete(bool synch) { }

	// RVA: 0x10016D0 Offset: 0xFFFCD0 VA: 0x1810016D0
	public void Complete(int total) { }

	// RVA: 0x10013E0 Offset: 0xFFF9E0 VA: 0x1810013E0
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x1001420 Offset: 0xFFFA20 VA: 0x181001420
	public void Complete(Exception e) { }

	// RVA: 0x1001450 Offset: 0xFFFA50 VA: 0x181001450
	public void Complete(Socket s) { }

	// RVA: 0x1001690 Offset: 0xFFFC90 VA: 0x181001690
	public void Complete(Socket s, int total) { }

}

private sealed class SocketAsyncResult.<>c // TypeDefIndex: 3065
{	// Fields
	public static readonly SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x100E9A0 Offset: 0x100CFA0 VA: 0x18100E9A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100C7D0 Offset: 0x100ADD0 VA: 0x18100C7D0
	internal void <Complete>b__27_0(object state) { }

}

internal enum SocketOperation // TypeDefIndex: 3066
{	// Fields
	public int value__; // 0x0
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;

}

public sealed class SocketElement : ConfigurationElement // TypeDefIndex: 3180
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x15374B0 Offset: 0x1535AB0 VA: 0x1815374B0
	public void .ctor() { }

	// RVA: 0x15374E0 Offset: 0x1535AE0 VA: 0x1815374E0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public class SocketManager // TypeDefIndex: 5182
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ISocketManager <Interface>k__BackingField; // 0x10
	public HashSet<Connection> Connecting; // 0x18
	public HashSet<Connection> Connected; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Socket <Socket>k__BackingField; // 0x28
	internal HSteamNetPollGroup pollGroup; // 0x2C

	// Properties
	public ISocketManager Interface { get; set; }
	public Socket Socket { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public ISocketManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Interface(ISocketManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public Socket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	internal void set_Socket(Socket value) { }

	// RVA: 0xDE3970 Offset: 0xDE1F70 VA: 0x180DE3970 Slot: 3
	public override string ToString() { }

	// RVA: 0xDE2C90 Offset: 0xDE1290 VA: 0x180DE2C90
	internal void Initialize() { }

	// RVA: 0xDE2B80 Offset: 0xDE1180 VA: 0x180DE2B80
	public bool Close() { }

	// RVA: 0xDE2F50 Offset: 0xDE1550 VA: 0x180DE2F50 Slot: 4
	public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE2E40 Offset: 0xDE1440 VA: 0x180DE2E40 Slot: 5
	public virtual void OnConnecting(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE2D00 Offset: 0xDE1300 VA: 0x180DE2D00 Slot: 6
	public virtual void OnConnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE3300 Offset: 0xDE1900 VA: 0x180DE3300 Slot: 7
	public virtual void OnDisconnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE3770 Offset: 0xDE1D70 VA: 0x180DE3770
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0xDE35B0 Offset: 0xDE1BB0 VA: 0x180DE35B0
	internal void ReceiveMessage(IntPtr msgPtr) { }

	// RVA: 0xDE3420 Offset: 0xDE1A20 VA: 0x180DE3420 Slot: 8
	public virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0xDE3990 Offset: 0xDE1F90 VA: 0x180DE3990
	public void .ctor() { }

}

public struct Socket // TypeDefIndex: 5547
{	// Fields
	internal uint Id; // 0x0

	// Methods

	// RVA: 0x1D7CC0 Offset: 0x1D70C0 VA: 0x1801D7CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static Socket op_Implicit(uint value) { }

	// RVA: 0x1D8800 Offset: 0x1D7C00 VA: 0x1801D8800
	public bool Close() { }

}

public class SocketWrapper : ISocket // TypeDefIndex: 6921
{	// Fields
	private static readonly byte[] keepAliveValues; // 0x0
	private readonly Socket _socket; // 0x10
	private CancellationTokenSource _tokenSource; // 0x18
	private TaskFactory _taskFactory; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Stream <Stream>k__BackingField; // 0x28

	// Properties
	public IPAddress RemoteIpAddress { get; }
	public int RemotePort { get; }
	public bool Connected { get; }
	public Stream Stream { get; set; }
	public bool NoDelay { set; }
	public EndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0x2208A60 Offset: 0x2207060 VA: 0x182208A60 Slot: 5
	public IPAddress get_RemoteIpAddress() { }

	// RVA: 0x2208AF0 Offset: 0x22070F0 VA: 0x182208AF0 Slot: 6
	public int get_RemotePort() { }

	// RVA: 0x22087A0 Offset: 0x2206DA0 VA: 0x1822087A0
	private static void .cctor() { }

	// RVA: 0x22088A0 Offset: 0x2206EA0 VA: 0x1822088A0
	public void .ctor(Socket socket) { }

	// RVA: 0x2208360 Offset: 0x2206960 VA: 0x182208360 Slot: 11
	public Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error) { }

	// RVA: 0x2208780 Offset: 0x2206D80 VA: 0x182208780 Slot: 15
	public void Listen(int backlog) { }

	// RVA: 0x22086B0 Offset: 0x2206CB0 VA: 0x1822086B0 Slot: 14
	public void Bind(EndPoint endPoint) { }

	// RVA: 0x2208A20 Offset: 0x2207020 VA: 0x182208A20 Slot: 4
	public bool get_Connected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 7
	public Stream get_Stream() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_Stream(Stream value) { }

	// RVA: 0x2208B80 Offset: 0x2207180 VA: 0x182208B80 Slot: 8
	public void set_NoDelay(bool value) { }

	// RVA: 0x2208A40 Offset: 0x2207040 VA: 0x182208A40 Slot: 9
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x2208160 Offset: 0x2206760 VA: 0x182208160 Slot: 10
	public Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error) { }

	// RVA: 0x2208730 Offset: 0x2206D30 VA: 0x182208730 Slot: 12
	public void Dispose() { }

	// RVA: 0x22086D0 Offset: 0x2206CD0 VA: 0x1822086D0 Slot: 13
	public void Close() { }

}

private sealed class SocketWrapper.<>c__DisplayClass12_0 // TypeDefIndex: 6922
{	// Fields
	public SslStream ssl; // 0x10
	public X509Certificate2 certificate; // 0x18
	public SslProtocols enabledSslProtocols; // 0x20
	public Action callback; // 0x28
	public Action<Exception> error; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2208F00 Offset: 0x2207500 VA: 0x182208F00
	internal IAsyncResult <Authenticate>b__0(AsyncCallback cb, object s) { }

	// RVA: 0x2208F50 Offset: 0x2207550 VA: 0x182208F50
	internal void <Authenticate>b__1(Task t) { }

	// RVA: 0x2208F70 Offset: 0x2207570 VA: 0x182208F70
	internal void <Authenticate>b__2(Task t) { }

	// RVA: 0x2208FE0 Offset: 0x22075E0 VA: 0x182208FE0
	internal void <Authenticate>b__3(Task t) { }

}

private sealed class SocketWrapper.<>c__DisplayClass26_0 // TypeDefIndex: 6923
{	// Fields
	public SocketWrapper <>4__this; // 0x10
	public Action<ISocket> callback; // 0x18
	public Action<Exception> error; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x2209050 Offset: 0x2207650 VA: 0x182209050
	internal ISocket <Accept>b__0(IAsyncResult r) { }

	// RVA: 0x2209110 Offset: 0x2207710 VA: 0x182209110
	internal void <Accept>b__1(Task<ISocket> t) { }

	// RVA: 0x2209180 Offset: 0x2207780 VA: 0x182209180
	internal void <Accept>b__2(Task t) { }

	// RVA: 0x22091F0 Offset: 0x22077F0 VA: 0x1822091F0
	internal void <Accept>b__3(Task<ISocket> t) { }

}

public class SocketHandle : PrefabAttribute // TypeDefIndex: 9088
{	// Methods

	// RVA: 0x5B74E0 Offset: 0x5B5AE0 VA: 0x1805B74E0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5B7300 Offset: 0x5B5900 VA: 0x1805B7300
	internal void AdjustTarget(ref Construction.Target target, float maxplaceDistance) { }

	// RVA: 0x5B7540 Offset: 0x5B5B40 VA: 0x1805B7540
	public void .ctor() { }

}

public class SocketMod : PrefabAttribute // TypeDefIndex: 9089
{	// Fields
	public Socket_Base baseSocket; // 0x98
	public Translate.Phrase FailedPhrase; // 0xA0

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 8
	public virtual bool DoCheck(Construction.Placement place) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5BA7C0 Offset: 0x5B8DC0 VA: 0x1805BA7C0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5BB3D0 Offset: 0x5B99D0 VA: 0x1805BB3D0
	public void .ctor() { }

}

public class SocketMod_AngleCheck : SocketMod // TypeDefIndex: 9090
{	// Fields
	public bool wantsAngle; // 0xA8
	public Vector3 worldNormal; // 0xAC
	public float withinDegrees; // 0xB8
	public static Translate.Phrase ErrorPhrase; // 0x0

	// Methods

	// RVA: 0x5B78D0 Offset: 0x5B5ED0 VA: 0x1805B78D0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B75A0 Offset: 0x5B5BA0 VA: 0x1805B75A0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B7A70 Offset: 0x5B6070 VA: 0x1805B7A70
	public void .ctor() { }

	// RVA: 0x5B7A00 Offset: 0x5B6000 VA: 0x1805B7A00
	private static void .cctor() { }

}

public class SocketMod_AreaCheck : SocketMod // TypeDefIndex: 9091
{	// Fields
	public Bounds bounds; // 0xA8
	public LayerMask layerMask; // 0xC0
	public bool wantsInside; // 0xC4

	// Methods

	// RVA: 0x5B8320 Offset: 0x5B6920 VA: 0x1805B8320
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B81F0 Offset: 0x5B67F0 VA: 0x1805B81F0
	public static bool IsInArea(Vector3 position, Quaternion rotation, Bounds bounds, LayerMask layerMask, BaseEntity entity) { }

	// RVA: 0x5B7F90 Offset: 0x5B6590 VA: 0x1805B7F90
	public bool DoCheck(Vector3 position, Quaternion rotation, BaseEntity entity) { }

	// RVA: 0x5B7B30 Offset: 0x5B6130 VA: 0x1805B7B30 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B8440 Offset: 0x5B6A40 VA: 0x1805B8440
	public void .ctor() { }

}

public class SocketMod_Attraction : SocketMod // TypeDefIndex: 9092
{	// Fields
	public float outerRadius; // 0xA8
	public float innerRadius; // 0xAC
	public string groupName; // 0xB0
	public bool lockRotation; // 0xB8
	public bool ignoreRotationForRadiusCheck; // 0xB9
	public static TimeSince LastSnap; // 0x0

	// Methods

	// RVA: 0x5B9600 Offset: 0x5B7C00 VA: 0x1805B9600
	private void OnDrawGizmosSelected() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B8590 Offset: 0x5B6B90 VA: 0x1805B8590 Slot: 9
	public override void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5B97C0 Offset: 0x5B7DC0 VA: 0x1805B97C0
	public void .ctor() { }

}

public class SocketMod_BuildingBlock : SocketMod // TypeDefIndex: 9093
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public bool wantsCollide; // 0xB4

	// Methods

	// RVA: 0x5B9B20 Offset: 0x5B8120 VA: 0x1805B9B20
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B9860 Offset: 0x5B7E60 VA: 0x1805B9860 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C80 Offset: 0x5B8280 VA: 0x1805B9C80
	public void .ctor() { }

}

public class SocketMod_EntityCheck : SocketMod // TypeDefIndex: 9094
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public BaseEntity[] entityTypes; // 0xB8
	public bool wantsCollide; // 0xC0

	// Methods

	// RVA: 0x5BA100 Offset: 0x5B8700 VA: 0x1805BA100
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B9CE0 Offset: 0x5B82E0 VA: 0x1805B9CE0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C80 Offset: 0x5B8280 VA: 0x1805B9C80
	public void .ctor() { }

}

private sealed class SocketMod_EntityCheck.<>c__DisplayClass6_0 // TypeDefIndex: 9095
{	// Fields
	public BaseEntity ent; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C4760 Offset: 0x5C2D60 VA: 0x1805C4760
	internal bool <DoCheck>b__0(BaseEntity x) { }

}

public class SocketMod_EntityType : SocketMod // TypeDefIndex: 9096
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public BaseEntity searchType; // 0xB8
	public bool wantsCollide; // 0xC0

	// Methods

	// RVA: 0x5BA660 Offset: 0x5B8C60 VA: 0x1805BA660
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BA260 Offset: 0x5B8860 VA: 0x1805BA260 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C80 Offset: 0x5B8280 VA: 0x1805B9C80
	public void .ctor() { }

}

public class SocketMod_HotSpot : SocketMod // TypeDefIndex: 9097
{	// Fields
	public float spotSize; // 0xA8

	// Methods

	// RVA: 0x5BA960 Offset: 0x5B8F60 VA: 0x1805BA960
	private void OnDrawGizmos() { }

	// RVA: 0x5BA820 Offset: 0x5B8E20 VA: 0x1805BA820 Slot: 9
	public override void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5BAAB0 Offset: 0x5B90B0 VA: 0x1805BAAB0
	public void .ctor() { }

}

public class SocketMod_InWater : SocketMod // TypeDefIndex: 9098
{	// Fields
	public bool wantsInWater; // 0xA8
	public static Translate.Phrase WantsWaterPhrase; // 0x0
	public static Translate.Phrase NoWaterPhrase; // 0x8

	// Methods

	// RVA: 0x5BAF00 Offset: 0x5B9500 VA: 0x1805BAF00
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BAB10 Offset: 0x5B9110 VA: 0x1805BAB10 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BB0B0 Offset: 0x5B96B0 VA: 0x1805BB0B0
	public void .ctor() { }

	// RVA: 0x5BB000 Offset: 0x5B9600 VA: 0x1805BB000
	private static void .cctor() { }

}

public class SocketMod_PhysicMaterial : SocketMod // TypeDefIndex: 9099
{	// Fields
	public PhysicMaterial[] ValidMaterials; // 0xA8
	private PhysicMaterial foundMaterial; // 0xB0

	// Methods

	// RVA: 0x5BB110 Offset: 0x5B9710 VA: 0x1805BB110 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BB3D0 Offset: 0x5B99D0 VA: 0x1805BB3D0
	public void .ctor() { }

}

public class SocketMod_PlantCheck : SocketMod // TypeDefIndex: 9100
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public bool wantsCollide; // 0xB4

	// Methods

	// RVA: 0x5BB860 Offset: 0x5B9E60 VA: 0x1805BB860
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BB430 Offset: 0x5B9A30 VA: 0x1805BB430 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C80 Offset: 0x5B8280 VA: 0x1805B9C80
	public void .ctor() { }

}

public class SocketMod_SphereCheck : SocketMod // TypeDefIndex: 9101
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public bool wantsCollide; // 0xB0
	public static Translate.Phrase Error_WantsCollideConstruction; // 0x0
	public static Translate.Phrase Error_DoesNotWantCollideConstruction; // 0x8

	// Methods

	// RVA: 0x5BC210 Offset: 0x5BA810 VA: 0x1805BC210
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BB9C0 Offset: 0x5B9FC0 VA: 0x1805BB9C0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C80 Offset: 0x5B8280 VA: 0x1805B9C80
	public void .ctor() { }

	// RVA: 0x5BC370 Offset: 0x5BA970 VA: 0x1805BC370
	private static void .cctor() { }

}

public class SocketMod_TerrainCheck : SocketMod // TypeDefIndex: 9102
{	// Fields
	public bool wantsInTerrain; // 0xA8

	// Methods

	// RVA: 0x5BC9B0 Offset: 0x5BAFB0 VA: 0x1805BC9B0
	private void OnDrawGizmos() { }

	// RVA: 0x5BC660 Offset: 0x5BAC60 VA: 0x1805BC660
	public static bool IsInTerrain(Vector3 vPoint) { }

	// RVA: 0x5BC420 Offset: 0x5BAA20 VA: 0x1805BC420 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BB0B0 Offset: 0x5B96B0 VA: 0x1805BB0B0
	public void .ctor() { }

}

public class SocketMod_WaterDepth : SocketMod // TypeDefIndex: 9103
{	// Fields
	public float MinimumWaterDepth; // 0xA8
	public float MaximumWaterDepth; // 0xAC
	public bool AllowWaterVolumes; // 0xB0
	public static Translate.Phrase TooDeepPhrase; // 0x0
	public static Translate.Phrase TooShallowPhrase; // 0x8

	// Methods

	// RVA: 0x5BCB10 Offset: 0x5BB110 VA: 0x1805BCB10 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BD080 Offset: 0x5BB680 VA: 0x1805BD080
	public void .ctor() { }

	// RVA: 0x5BCFD0 Offset: 0x5BB5D0 VA: 0x1805BCFD0
	private static void .cctor() { }

}

public class Socket_Base : PrefabAttribute // TypeDefIndex: 9104
{	// Fields
	public bool male; // 0x98
	public bool maleDummy; // 0x99
	public bool female; // 0x9A
	public bool femaleDummy; // 0x9B
	public bool monogamous; // 0x9C
	public Vector3 position; // 0xA0
	public Quaternion rotation; // 0xAC
	public Vector3 selectSize; // 0xBC
	public Vector3 selectCenter; // 0xC8
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public string socketName; // 0xD8
	public SocketMod[] socketMods; // 0xE0

	// Methods

	// RVA: 0x5BD8B0 Offset: 0x5BBEB0 VA: 0x1805BD8B0
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5BD690 Offset: 0x5BBC90 VA: 0x1805BD690
	public OBB GetSelectBounds(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5BD630 Offset: 0x5BBC30 VA: 0x1805BD630 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5BD0F0 Offset: 0x5BB6F0 VA: 0x1805BD0F0 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5BDAC0 Offset: 0x5BC0C0 VA: 0x1805BDAC0 Slot: 8
	public virtual bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BD9D0 Offset: 0x5BBFD0 VA: 0x1805BD9D0 Slot: 9
	public virtual bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x5BD270 Offset: 0x5BB870 VA: 0x1805BD270 Slot: 10
	public virtual bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x5BD420 Offset: 0x5BBA20 VA: 0x1805BD420 Slot: 11
	public virtual Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BD290 Offset: 0x5BB890 VA: 0x1805BD290 Slot: 12
	public virtual bool CheckSocketMods(Construction.Placement placement) { }

	// RVA: 0x5BDB30 Offset: 0x5BC130 VA: 0x1805BDB30
	public void .ctor() { }

}

public class Socket_Free : Socket_Base // TypeDefIndex: 9105
{	// Fields
	public Vector3 idealPlacementNormal; // 0xE8
	public bool useTargetNormal; // 0xF4
	public bool blendAimAngle; // 0xF5

	// Methods

	// RVA: 0x5BE1A0 Offset: 0x5BC7A0 VA: 0x1805BE1A0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BE390 Offset: 0x5BC990 VA: 0x1805BE390 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BDC10 Offset: 0x5BC210 VA: 0x1805BDC10 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BE3A0 Offset: 0x5BC9A0 VA: 0x1805BE3A0
	public void .ctor() { }

}

public class Socket_Specific : Socket_Base // TypeDefIndex: 9106
{	// Fields
	public bool useFemaleRotation; // 0xE8
	public string targetSocketName; // 0xF0

	// Methods

	// RVA: 0x5BEE90 Offset: 0x5BD490 VA: 0x1805BEE90
	private void OnDrawGizmos() { }

	// RVA: 0x5BF140 Offset: 0x5BD740 VA: 0x1805BF140 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BE420 Offset: 0x5BCA20 VA: 0x1805BE420 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BF2D0 Offset: 0x5BD8D0 VA: 0x1805BF2D0
	public void .ctor() { }

}

public class Socket_Specific_Female : Socket_Base // TypeDefIndex: 9107
{	// Fields
	public int rotationDegrees; // 0xE8
	public int rotationOffset; // 0xEC
	public string[] allowedMaleSockets; // 0xF0

	// Methods

	// RVA: 0x5BEBD0 Offset: 0x5BD1D0 VA: 0x1805BEBD0
	private void OnDrawGizmos() { }

	// RVA: 0x5BEB20 Offset: 0x5BD120 VA: 0x1805BEB20
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BEA90 Offset: 0x5BD090 VA: 0x1805BEA90
	public bool CanAccept(Socket_Specific socket) { }

	// RVA: 0x5BEE80 Offset: 0x5BD480 VA: 0x1805BEE80
	public void .ctor() { }

}

public class Socket_Terrain : Socket_Base // TypeDefIndex: 9108
{	// Fields
	public float placementHeight; // 0xE8
	public bool alignToNormal; // 0xEC

	// Methods

	// RVA: 0x5BF5E0 Offset: 0x5BDBE0 VA: 0x1805BF5E0
	private void OnDrawGizmos() { }

	// RVA: 0x5BE390 Offset: 0x5BC990 VA: 0x1805BE390 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BF2E0 Offset: 0x5BD8E0 VA: 0x1805BF2E0 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BEE80 Offset: 0x5BD480 VA: 0x1805BEE80
	public void .ctor() { }

}

