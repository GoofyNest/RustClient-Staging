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

	// RVA: 0x1001EF0 Offset: 0x10004F0 VA: 0x181001EF0
	public AddressFamily get_Family() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x1001F50 Offset: 0x1000550 VA: 0x181001F50
	public byte get_Item(int offset) { }

	// RVA: 0x1001990 Offset: 0xFFFF90 VA: 0x181001990
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x1001AB0 Offset: 0x10000B0 VA: 0x181001AB0
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x1001910 Offset: 0xFFFF10 VA: 0x181001910
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x10011B0 Offset: 0xFFF7B0 VA: 0x1810011B0
	internal IPAddress GetIPAddress() { }

	// RVA: 0x1001440 Offset: 0xFFFA40 VA: 0x181001440
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x1000F10 Offset: 0xFFF510 VA: 0x181000F10 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1001040 Offset: 0xFFF640 VA: 0x181001040 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1001500 Offset: 0xFFFB00 VA: 0x181001500 Slot: 3
	public override string ToString() { }

}

public class SocketException : Win32Exception // TypeDefIndex: 3038
{	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x1002560 Offset: 0x1000B60 VA: 0x181002560
	private static int WSAGetLastError_internal() { }

	// RVA: 0x1002720 Offset: 0x1000D20 VA: 0x181002720
	public void .ctor() { }

	// RVA: 0x10026B0 Offset: 0x1000CB0 VA: 0x1810026B0
	internal void .ctor(int error, string message) { }

	// RVA: 0x1002570 Offset: 0x1000B70 VA: 0x181002570
	public void .ctor(int errorCode) { }

	// RVA: 0x10025D0 Offset: 0x1000BD0 VA: 0x1810025D0
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1002630 Offset: 0x1000C30 VA: 0x181002630
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1002790 Offset: 0x1000D90 VA: 0x181002790 Slot: 5
	public override string get_Message() { }

	// RVA: 0x58AC00 Offset: 0x589200 VA: 0x18058AC00
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

	// RVA: 0x100A1E0 Offset: 0x10087E0 VA: 0x18100A1E0
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x100AC80 Offset: 0x1009280 VA: 0x18100AC80
	public static bool get_SupportsIPv4() { }

	// RVA: 0x100AAA0 Offset: 0x10090A0 VA: 0x18100AAA0
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x100ACF0 Offset: 0x10092F0 VA: 0x18100ACF0
	public static bool get_SupportsIPv6() { }

	// RVA: 0x100AB10 Offset: 0x1009110 VA: 0x18100AB10
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x9630C0 Offset: 0x9616C0 VA: 0x1809630C0
	public IntPtr get_Handle() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
	public SocketType get_SocketType() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x100AF60 Offset: 0x1009560 VA: 0x18100AF60
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x100B090 Offset: 0x1009690 VA: 0x18100B090
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x100B130 Offset: 0x1009730 VA: 0x18100B130
	public void set_SendTimeout(int value) { }

	// RVA: 0x100AE20 Offset: 0x1009420 VA: 0x18100AE20
	public void set_DontFragment(bool value) { }

	// RVA: 0x100A5C0 Offset: 0x1008BC0 VA: 0x18100A5C0
	public bool get_DualMode() { }

	// RVA: 0x100AEC0 Offset: 0x10094C0 VA: 0x18100AEC0
	public void set_DualMode(bool value) { }

	// RVA: 0x100A8E0 Offset: 0x1008EE0 VA: 0x18100A8E0
	private bool get_IsDualMode() { }

	// RVA: 0x1008860 Offset: 0x1006E60 VA: 0x181008860
	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	// RVA: 0x10087C0 Offset: 0x1006DC0 VA: 0x1810087C0
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1008A40 Offset: 0x1007040 VA: 0x181008A40
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1007E00 Offset: 0x1006400 VA: 0x181007E00
	public int Receive(byte[] buffer) { }

	// RVA: 0x1007E40 Offset: 0x1006440 VA: 0x181007E40
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1007730 Offset: 0x1005D30 VA: 0x181007730
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1006100 Offset: 0x1004700 VA: 0x181006100
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1009120 Offset: 0x1007720 VA: 0x181009120
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x1004210 Offset: 0x1002810 VA: 0x181004210
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1005B40 Offset: 0x1004140 VA: 0x181005B40
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1003450 Offset: 0x1001A50 VA: 0x181003450
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1005890 Offset: 0x1003E90 VA: 0x181005890
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x100A7E0 Offset: 0x1008DE0 VA: 0x18100A7E0
	private static object get_InternalSyncObject() { }

	// RVA: 0x100A5B0 Offset: 0x1008BB0 VA: 0x18100A5B0
	internal bool get_CleanedUp() { }

	// RVA: 0x10063E0 Offset: 0x10049E0 VA: 0x1810063E0
	internal static void InitializeSockets() { }

	// RVA: 0x1005330 Offset: 0x1003930 VA: 0x181005330 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x10067F0 Offset: 0x1004DF0 VA: 0x1810067F0
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x100A0D0 Offset: 0x10086D0 VA: 0x18100A0D0
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x10095F0 Offset: 0x1007BF0 VA: 0x1810095F0
	private void SocketDefaults() { }

	// RVA: 0x10097C0 Offset: 0x1007DC0 VA: 0x1810097C0
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x100A500 Offset: 0x1008B00 VA: 0x18100A500
	public int get_Available() { }

	// RVA: 0x1002C00 Offset: 0x1001200 VA: 0x181002C00
	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	// RVA: 0x1002D20 Offset: 0x1001320 VA: 0x181002D20
	private static int Available_internal(IntPtr socket, out int error) { }

	// RVA: 0xBA2230 Offset: 0xBA0830 VA: 0x180BA2230
	public bool get_IsBound() { }

	// RVA: 0x100A9B0 Offset: 0x1008FB0 VA: 0x18100A9B0
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x1006C60 Offset: 0x1005260 VA: 0x181006C60
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1006D90 Offset: 0x1005390 VA: 0x181006D90
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x4BC370 Offset: 0x4BA970 VA: 0x1804BC370
	public bool get_Blocking() { }

	// RVA: 0x100AD60 Offset: 0x1009360 VA: 0x18100AD60
	public void set_Blocking(bool value) { }

	// RVA: 0x1004830 Offset: 0x1002E30 VA: 0x181004830
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x1004950 Offset: 0x1002F50 VA: 0x181004950
	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	// RVA: 0xBA2220 Offset: 0xBA0820 VA: 0x180BA2220
	public bool get_Connected() { }

	// RVA: 0x100B000 Offset: 0x1009600 VA: 0x18100B000
	public void set_NoDelay(bool value) { }

	// RVA: 0x100AB80 Offset: 0x1009180 VA: 0x18100AB80
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x1008080 Offset: 0x1006680 VA: 0x181008080
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1008070 Offset: 0x1006670 VA: 0x181008070
	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x1006EF0 Offset: 0x10054F0 VA: 0x181006EF0
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x1006DB0 Offset: 0x10053B0 VA: 0x181006DB0
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1006DA0 Offset: 0x10053A0 VA: 0x181006DA0
	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1002AB0 Offset: 0x10010B0 VA: 0x181002AB0
	public Socket Accept() { }

	// RVA: 0x1002970 Offset: 0x1000F70 VA: 0x181002970
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x1002D30 Offset: 0x1001330 VA: 0x181002D30
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x1005480 Offset: 0x1003A80 VA: 0x181005480
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x10053A0 Offset: 0x10039A0 VA: 0x1810053A0
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1002830 Offset: 0x1000E30 VA: 0x181002830
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x1002820 Offset: 0x1000E20 VA: 0x181002820
	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x10046B0 Offset: 0x1002CB0 VA: 0x1810046B0
	public void Bind(EndPoint localEP) { }

	// RVA: 0x1004580 Offset: 0x1002B80 VA: 0x181004580
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x10046A0 Offset: 0x1002CA0 VA: 0x1810046A0
	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x1006B60 Offset: 0x1005160 VA: 0x181006B60
	public void Listen(int backlog) { }

	// RVA: 0x1006A40 Offset: 0x1005040 VA: 0x181006A40
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1006A30 Offset: 0x1005030 VA: 0x181006A30
	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x1004B80 Offset: 0x1003180 VA: 0x181004B80
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1002EC0 Offset: 0x10014C0 VA: 0x181002EC0
	private static void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1003660 Offset: 0x1001C60 VA: 0x181003660
	private static void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1005540 Offset: 0x1003B40 VA: 0x181005540
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1004A60 Offset: 0x1003060 VA: 0x181004A60
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1004A50 Offset: 0x1003050 VA: 0x181004A50
	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1005080 Offset: 0x1003680 VA: 0x181005080
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x10055F0 Offset: 0x1003BF0 VA: 0x1810055F0
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1004F50 Offset: 0x1003550 VA: 0x181004F50
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x1005070 Offset: 0x1003670 VA: 0x181005070
	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x1007C90 Offset: 0x1006290 VA: 0x181007C90
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x10077D0 Offset: 0x1005DD0 VA: 0x1810077D0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1003250 Offset: 0x1001850 VA: 0x181003250
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x10057B0 Offset: 0x1003DB0 VA: 0x1810057B0
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x10075D0 Offset: 0x1005BD0 VA: 0x1810075D0
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007710 Offset: 0x1005D10 VA: 0x181007710
	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007490 Offset: 0x1005A90 VA: 0x181007490
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007720 Offset: 0x1005D20 VA: 0x181007720
	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10072F0 Offset: 0x10058F0 VA: 0x1810072F0
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x1003000 Offset: 0x1001600 VA: 0x181003000
	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x10056A0 Offset: 0x1003CA0 VA: 0x1810056A0
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x10071A0 Offset: 0x10057A0 VA: 0x1810071A0
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1007190 Offset: 0x1005790 VA: 0x181007190
	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1008890 Offset: 0x1006E90 VA: 0x181008890
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1008C30 Offset: 0x1007230 VA: 0x181008C30
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x10042F0 Offset: 0x10028F0 VA: 0x1810042F0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1003B90 Offset: 0x1002190 VA: 0x181003B90
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1005A60 Offset: 0x1004060 VA: 0x181005A60
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1008660 Offset: 0x1006C60 VA: 0x181008660
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10087B0 Offset: 0x1006DB0 VA: 0x1810087B0
	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1008520 Offset: 0x1006B20 VA: 0x181008520
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10087A0 Offset: 0x1006DA0 VA: 0x1810087A0
	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1008310 Offset: 0x1006910 VA: 0x181008310
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1003FA0 Offset: 0x10025A0 VA: 0x181003FA0
	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1003DE0 Offset: 0x10023E0 VA: 0x181003DE0
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x10059B0 Offset: 0x1003FB0 VA: 0x1810059B0
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x10081B0 Offset: 0x10067B0 VA: 0x1810081B0
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1008300 Offset: 0x1006900 VA: 0x181008300
	private static int SendTo_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1005C60 Offset: 0x1004260 VA: 0x181005C60
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x1005E60 Offset: 0x1004460 VA: 0x181005E60
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1005E50 Offset: 0x1004450 VA: 0x181005E50
	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1009380 Offset: 0x1007980 VA: 0x181009380
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x10093A0 Offset: 0x10079A0 VA: 0x1810093A0
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1009220 Offset: 0x1007820 VA: 0x181009220
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1009370 Offset: 0x1007970 VA: 0x181009370
	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1006270 Offset: 0x1004870 VA: 0x181006270
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1005FA0 Offset: 0x10045A0 VA: 0x181005FA0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x10060F0 Offset: 0x10046F0 VA: 0x1810060F0
	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x10049E0 Offset: 0x1002FE0 VA: 0x1810049E0
	public void Close() { }

	// RVA: 0x1004970 Offset: 0x1002F70 VA: 0x181004970
	public void Close(int timeout) { }

	// RVA: 0x1004960 Offset: 0x1002F60 VA: 0x181004960
	internal static void Close_internal(IntPtr socket, out int error) { }

	// RVA: 0x10094C0 Offset: 0x1007AC0 VA: 0x1810094C0
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x10095E0 Offset: 0x1007BE0 VA: 0x1810095E0
	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x1005170 Offset: 0x1003770 VA: 0x181005170 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x10068C0 Offset: 0x1004EC0 VA: 0x1810068C0
	private void Linger(IntPtr handle) { }

	// RVA: 0x1009980 Offset: 0x1007F80 VA: 0x181009980
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x10097D0 Offset: 0x1007DD0 VA: 0x1810097D0
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x1009830 Offset: 0x1007E30 VA: 0x181009830
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x1009A20 Offset: 0x1008020 VA: 0x181009A20
	private void ThrowIfUdp() { }

	// RVA: 0x1009A80 Offset: 0x1008080 VA: 0x181009A80
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x1007060 Offset: 0x1005660 VA: 0x181007060
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1007F00 Offset: 0x1006500 VA: 0x181007F00
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x100A4F0 Offset: 0x1008AF0 VA: 0x18100A4F0
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x100A680 Offset: 0x1008C80 VA: 0x18100A680
	internal static int get_FamilyHint() { }

	// RVA: 0xFE8400 Offset: 0xFE6A00 VA: 0x180FE8400
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1006870 Offset: 0x1004E70 VA: 0x181006870
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1009BB0 Offset: 0x10081B0 VA: 0x181009BB0
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

	// RVA: 0x100F760 Offset: 0x100DD60 VA: 0x18100F760
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100D4B0 Offset: 0x100BAB0 VA: 0x18100D4B0
	internal void <BeginSend>b__241_0(IOAsyncResult s) { }

	// RVA: 0x100D430 Offset: 0x100BA30 VA: 0x18100D430
	internal void <BeginSendTo>b__253_0(IOAsyncResult s) { }

	// RVA: 0x100D5A0 Offset: 0x100BBA0 VA: 0x18100D5A0
	internal void <.cctor>b__309_0(IAsyncResult ares) { }

	// RVA: 0x100E300 Offset: 0x100C900 VA: 0x18100E300
	internal void <.cctor>b__309_1(IOAsyncResult ares) { }

	// RVA: 0x100E3F0 Offset: 0x100C9F0 VA: 0x18100E3F0
	internal void <.cctor>b__309_2(IOAsyncResult ares) { }

	// RVA: 0x100E590 Offset: 0x100CB90 VA: 0x18100E590
	internal void <.cctor>b__309_3(IAsyncResult ares) { }

	// RVA: 0x100E820 Offset: 0x100CE20 VA: 0x18100E820
	internal void <.cctor>b__309_4(IOAsyncResult ares) { }

	// RVA: 0x100EAF0 Offset: 0x100D0F0 VA: 0x18100EAF0
	internal void <.cctor>b__309_5(IAsyncResult ares) { }

	// RVA: 0x100ED80 Offset: 0x100D380 VA: 0x18100ED80
	internal void <.cctor>b__309_6(IOAsyncResult ares) { }

	// RVA: 0x100EF20 Offset: 0x100D520 VA: 0x18100EF20
	internal void <.cctor>b__309_7(IAsyncResult ares) { }

	// RVA: 0x100F130 Offset: 0x100D730 VA: 0x18100F130
	internal void <.cctor>b__309_8(IOAsyncResult ares) { }

	// RVA: 0x100F2B0 Offset: 0x100D8B0 VA: 0x18100F2B0
	internal void <.cctor>b__309_9(IOAsyncResult ares) { }

	// RVA: 0x100D8E0 Offset: 0x100BEE0 VA: 0x18100D8E0
	internal void <.cctor>b__309_10(IAsyncResult ares) { }

	// RVA: 0x100DAF0 Offset: 0x100C0F0 VA: 0x18100DAF0
	internal void <.cctor>b__309_11(IOAsyncResult ares) { }

	// RVA: 0x100DD90 Offset: 0x100C390 VA: 0x18100DD90
	internal void <.cctor>b__309_12(IAsyncResult ares) { }

	// RVA: 0x100DFA0 Offset: 0x100C5A0 VA: 0x18100DFA0
	internal void <.cctor>b__309_13(IOAsyncResult ares) { }

	// RVA: 0x100E0F0 Offset: 0x100C6F0 VA: 0x18100E0F0
	internal void <.cctor>b__309_14(IAsyncResult ares) { }

}

private sealed class Socket.<>c__DisplayClass242_0 // TypeDefIndex: 3050
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100F570 Offset: 0x100DB70 VA: 0x18100F570
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

private sealed class Socket.<>c__DisplayClass254_0 // TypeDefIndex: 3051
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100F600 Offset: 0x100DC00 VA: 0x18100F600
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

	// RVA: 0x100F690 Offset: 0x100DC90 VA: 0x18100F690
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
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_SocketError(SocketError value) { }

	// RVA: 0x1001FF0 Offset: 0x10005F0 VA: 0x181001FF0
	internal void Complete() { }

	// RVA: 0x1002010 Offset: 0x1000610 VA: 0x181002010 Slot: 4
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

	// RVA: 0x1002510 Offset: 0x1000B10 VA: 0x181002510
	public IntPtr get_Handle() { }

	// RVA: 0x1002440 Offset: 0x1000A40 VA: 0x181002440
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1002490 Offset: 0x1000A90 VA: 0x181002490
	public SocketError get_ErrorCode() { }

	// RVA: 0x1002060 Offset: 0x1000660 VA: 0x181002060
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x1002130 Offset: 0x1000730 VA: 0x181002130 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x10021F0 Offset: 0x10007F0 VA: 0x1810021F0
	public void Complete() { }

	// RVA: 0x10021E0 Offset: 0x10007E0 VA: 0x1810021E0
	public void Complete(bool synch) { }

	// RVA: 0x1002430 Offset: 0x1000A30 VA: 0x181002430
	public void Complete(int total) { }

	// RVA: 0x1002140 Offset: 0x1000740 VA: 0x181002140
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x1002180 Offset: 0x1000780 VA: 0x181002180
	public void Complete(Exception e) { }

	// RVA: 0x10021B0 Offset: 0x10007B0 VA: 0x1810021B0
	public void Complete(Socket s) { }

	// RVA: 0x10023F0 Offset: 0x10009F0 VA: 0x1810023F0
	public void Complete(Socket s, int total) { }

}

private sealed class SocketAsyncResult.<>c // TypeDefIndex: 3065
{	// Fields
	public static readonly SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x100F700 Offset: 0x100DD00 VA: 0x18100F700
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100D530 Offset: 0x100BB30 VA: 0x18100D530
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

	// RVA: 0x1536840 Offset: 0x1534E40 VA: 0x181536840
	public void .ctor() { }

	// RVA: 0x1536870 Offset: 0x1534E70 VA: 0x181536870 Slot: 4
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public ISocketManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Interface(ISocketManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	public Socket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	internal void set_Socket(Socket value) { }

	// RVA: 0xDE46E0 Offset: 0xDE2CE0 VA: 0x180DE46E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xDE3A00 Offset: 0xDE2000 VA: 0x180DE3A00
	internal void Initialize() { }

	// RVA: 0xDE38F0 Offset: 0xDE1EF0 VA: 0x180DE38F0
	public bool Close() { }

	// RVA: 0xDE3CC0 Offset: 0xDE22C0 VA: 0x180DE3CC0 Slot: 4
	public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE3BB0 Offset: 0xDE21B0 VA: 0x180DE3BB0 Slot: 5
	public virtual void OnConnecting(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE3A70 Offset: 0xDE2070 VA: 0x180DE3A70 Slot: 6
	public virtual void OnConnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE4070 Offset: 0xDE2670 VA: 0x180DE4070 Slot: 7
	public virtual void OnDisconnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE44E0 Offset: 0xDE2AE0 VA: 0x180DE44E0
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0xDE4320 Offset: 0xDE2920 VA: 0x180DE4320
	internal void ReceiveMessage(IntPtr msgPtr) { }

	// RVA: 0xDE4190 Offset: 0xDE2790 VA: 0x180DE4190 Slot: 8
	public virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0xDE4700 Offset: 0xDE2D00 VA: 0x180DE4700
	public void .ctor() { }

}

public struct Socket // TypeDefIndex: 5547
{	// Fields
	internal uint Id; // 0x0

	// Methods

	// RVA: 0x1D8330 Offset: 0x1D7730 VA: 0x1801D8330 Slot: 3
	public override string ToString() { }

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static Socket op_Implicit(uint value) { }

	// RVA: 0x1D8E70 Offset: 0x1D8270 VA: 0x1801D8E70
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

	// RVA: 0x2209540 Offset: 0x2207B40 VA: 0x182209540 Slot: 5
	public IPAddress get_RemoteIpAddress() { }

	// RVA: 0x22095D0 Offset: 0x2207BD0 VA: 0x1822095D0 Slot: 6
	public int get_RemotePort() { }

	// RVA: 0x2209280 Offset: 0x2207880 VA: 0x182209280
	private static void .cctor() { }

	// RVA: 0x2209380 Offset: 0x2207980 VA: 0x182209380
	public void .ctor(Socket socket) { }

	// RVA: 0x2208E40 Offset: 0x2207440 VA: 0x182208E40 Slot: 11
	public Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error) { }

	// RVA: 0x2209260 Offset: 0x2207860 VA: 0x182209260 Slot: 15
	public void Listen(int backlog) { }

	// RVA: 0x2209190 Offset: 0x2207790 VA: 0x182209190 Slot: 14
	public void Bind(EndPoint endPoint) { }

	// RVA: 0x2209500 Offset: 0x2207B00 VA: 0x182209500 Slot: 4
	public bool get_Connected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 7
	public Stream get_Stream() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_Stream(Stream value) { }

	// RVA: 0x2209660 Offset: 0x2207C60 VA: 0x182209660 Slot: 8
	public void set_NoDelay(bool value) { }

	// RVA: 0x2209520 Offset: 0x2207B20 VA: 0x182209520 Slot: 9
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x2208C40 Offset: 0x2207240 VA: 0x182208C40 Slot: 10
	public Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error) { }

	// RVA: 0x2209210 Offset: 0x2207810 VA: 0x182209210 Slot: 12
	public void Dispose() { }

	// RVA: 0x22091B0 Offset: 0x22077B0 VA: 0x1822091B0 Slot: 13
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

	// RVA: 0x22099E0 Offset: 0x2207FE0 VA: 0x1822099E0
	internal IAsyncResult <Authenticate>b__0(AsyncCallback cb, object s) { }

	// RVA: 0x2209A30 Offset: 0x2208030 VA: 0x182209A30
	internal void <Authenticate>b__1(Task t) { }

	// RVA: 0x2209A50 Offset: 0x2208050 VA: 0x182209A50
	internal void <Authenticate>b__2(Task t) { }

	// RVA: 0x2209AC0 Offset: 0x22080C0 VA: 0x182209AC0
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

	// RVA: 0x2209B30 Offset: 0x2208130 VA: 0x182209B30
	internal ISocket <Accept>b__0(IAsyncResult r) { }

	// RVA: 0x2209BF0 Offset: 0x22081F0 VA: 0x182209BF0
	internal void <Accept>b__1(Task<ISocket> t) { }

	// RVA: 0x2209C60 Offset: 0x2208260 VA: 0x182209C60
	internal void <Accept>b__2(Task t) { }

	// RVA: 0x2209CD0 Offset: 0x22082D0 VA: 0x182209CD0
	internal void <Accept>b__3(Task<ISocket> t) { }

}

public class SocketHandle : PrefabAttribute // TypeDefIndex: 9088
{	// Methods

	// RVA: 0x5B7470 Offset: 0x5B5A70 VA: 0x1805B7470 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5B7290 Offset: 0x5B5890 VA: 0x1805B7290
	internal void AdjustTarget(ref Construction.Target target, float maxplaceDistance) { }

	// RVA: 0x5B74D0 Offset: 0x5B5AD0 VA: 0x1805B74D0
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

	// RVA: 0x5BA750 Offset: 0x5B8D50 VA: 0x1805BA750 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5BB360 Offset: 0x5B9960 VA: 0x1805BB360
	public void .ctor() { }

}

public class SocketMod_AngleCheck : SocketMod // TypeDefIndex: 9090
{	// Fields
	public bool wantsAngle; // 0xA8
	public Vector3 worldNormal; // 0xAC
	public float withinDegrees; // 0xB8
	public static Translate.Phrase ErrorPhrase; // 0x0

	// Methods

	// RVA: 0x5B7860 Offset: 0x5B5E60 VA: 0x1805B7860
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B7530 Offset: 0x5B5B30 VA: 0x1805B7530 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B7A00 Offset: 0x5B6000 VA: 0x1805B7A00
	public void .ctor() { }

	// RVA: 0x5B7990 Offset: 0x5B5F90 VA: 0x1805B7990
	private static void .cctor() { }

}

public class SocketMod_AreaCheck : SocketMod // TypeDefIndex: 9091
{	// Fields
	public Bounds bounds; // 0xA8
	public LayerMask layerMask; // 0xC0
	public bool wantsInside; // 0xC4

	// Methods

	// RVA: 0x5B82B0 Offset: 0x5B68B0 VA: 0x1805B82B0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B8180 Offset: 0x5B6780 VA: 0x1805B8180
	public static bool IsInArea(Vector3 position, Quaternion rotation, Bounds bounds, LayerMask layerMask, BaseEntity entity) { }

	// RVA: 0x5B7F20 Offset: 0x5B6520 VA: 0x1805B7F20
	public bool DoCheck(Vector3 position, Quaternion rotation, BaseEntity entity) { }

	// RVA: 0x5B7AC0 Offset: 0x5B60C0 VA: 0x1805B7AC0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B83D0 Offset: 0x5B69D0 VA: 0x1805B83D0
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

	// RVA: 0x5B9590 Offset: 0x5B7B90 VA: 0x1805B9590
	private void OnDrawGizmosSelected() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B8520 Offset: 0x5B6B20 VA: 0x1805B8520 Slot: 9
	public override void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5B9750 Offset: 0x5B7D50 VA: 0x1805B9750
	public void .ctor() { }

}

public class SocketMod_BuildingBlock : SocketMod // TypeDefIndex: 9093
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public bool wantsCollide; // 0xB4

	// Methods

	// RVA: 0x5B9AB0 Offset: 0x5B80B0 VA: 0x1805B9AB0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B97F0 Offset: 0x5B7DF0 VA: 0x1805B97F0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C10 Offset: 0x5B8210 VA: 0x1805B9C10
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

	// RVA: 0x5BA090 Offset: 0x5B8690 VA: 0x1805BA090
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5B9C70 Offset: 0x5B8270 VA: 0x1805B9C70 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C10 Offset: 0x5B8210 VA: 0x1805B9C10
	public void .ctor() { }

}

private sealed class SocketMod_EntityCheck.<>c__DisplayClass6_0 // TypeDefIndex: 9095
{	// Fields
	public BaseEntity ent; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x5C46F0 Offset: 0x5C2CF0 VA: 0x1805C46F0
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

	// RVA: 0x5BA5F0 Offset: 0x5B8BF0 VA: 0x1805BA5F0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BA1F0 Offset: 0x5B87F0 VA: 0x1805BA1F0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C10 Offset: 0x5B8210 VA: 0x1805B9C10
	public void .ctor() { }

}

public class SocketMod_HotSpot : SocketMod // TypeDefIndex: 9097
{	// Fields
	public float spotSize; // 0xA8

	// Methods

	// RVA: 0x5BA8F0 Offset: 0x5B8EF0 VA: 0x1805BA8F0
	private void OnDrawGizmos() { }

	// RVA: 0x5BA7B0 Offset: 0x5B8DB0 VA: 0x1805BA7B0 Slot: 9
	public override void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5BAA40 Offset: 0x5B9040 VA: 0x1805BAA40
	public void .ctor() { }

}

public class SocketMod_InWater : SocketMod // TypeDefIndex: 9098
{	// Fields
	public bool wantsInWater; // 0xA8
	public static Translate.Phrase WantsWaterPhrase; // 0x0
	public static Translate.Phrase NoWaterPhrase; // 0x8

	// Methods

	// RVA: 0x5BAE90 Offset: 0x5B9490 VA: 0x1805BAE90
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BAAA0 Offset: 0x5B90A0 VA: 0x1805BAAA0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BB040 Offset: 0x5B9640 VA: 0x1805BB040
	public void .ctor() { }

	// RVA: 0x5BAF90 Offset: 0x5B9590 VA: 0x1805BAF90
	private static void .cctor() { }

}

public class SocketMod_PhysicMaterial : SocketMod // TypeDefIndex: 9099
{	// Fields
	public PhysicMaterial[] ValidMaterials; // 0xA8
	private PhysicMaterial foundMaterial; // 0xB0

	// Methods

	// RVA: 0x5BB0A0 Offset: 0x5B96A0 VA: 0x1805BB0A0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BB360 Offset: 0x5B9960 VA: 0x1805BB360
	public void .ctor() { }

}

public class SocketMod_PlantCheck : SocketMod // TypeDefIndex: 9100
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public bool wantsCollide; // 0xB4

	// Methods

	// RVA: 0x5BB7F0 Offset: 0x5B9DF0 VA: 0x1805BB7F0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BB3C0 Offset: 0x5B99C0 VA: 0x1805BB3C0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C10 Offset: 0x5B8210 VA: 0x1805B9C10
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

	// RVA: 0x5BC1A0 Offset: 0x5BA7A0 VA: 0x1805BC1A0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BB950 Offset: 0x5B9F50 VA: 0x1805BB950 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5B9C10 Offset: 0x5B8210 VA: 0x1805B9C10
	public void .ctor() { }

	// RVA: 0x5BC300 Offset: 0x5BA900 VA: 0x1805BC300
	private static void .cctor() { }

}

public class SocketMod_TerrainCheck : SocketMod // TypeDefIndex: 9102
{	// Fields
	public bool wantsInTerrain; // 0xA8

	// Methods

	// RVA: 0x5BC940 Offset: 0x5BAF40 VA: 0x1805BC940
	private void OnDrawGizmos() { }

	// RVA: 0x5BC5F0 Offset: 0x5BABF0 VA: 0x1805BC5F0
	public static bool IsInTerrain(Vector3 vPoint) { }

	// RVA: 0x5BC3B0 Offset: 0x5BA9B0 VA: 0x1805BC3B0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BB040 Offset: 0x5B9640 VA: 0x1805BB040
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

	// RVA: 0x5BCAA0 Offset: 0x5BB0A0 VA: 0x1805BCAA0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5BD010 Offset: 0x5BB610 VA: 0x1805BD010
	public void .ctor() { }

	// RVA: 0x5BCF60 Offset: 0x5BB560 VA: 0x1805BCF60
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

	// RVA: 0x5BD840 Offset: 0x5BBE40 VA: 0x1805BD840
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5BD620 Offset: 0x5BBC20 VA: 0x1805BD620
	public OBB GetSelectBounds(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5BD5C0 Offset: 0x5BBBC0 VA: 0x1805BD5C0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5BD080 Offset: 0x5BB680 VA: 0x1805BD080 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5BDA50 Offset: 0x5BC050 VA: 0x1805BDA50 Slot: 8
	public virtual bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BD960 Offset: 0x5BBF60 VA: 0x1805BD960 Slot: 9
	public virtual bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x5BD200 Offset: 0x5BB800 VA: 0x1805BD200 Slot: 10
	public virtual bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x5BD3B0 Offset: 0x5BB9B0 VA: 0x1805BD3B0 Slot: 11
	public virtual Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BD220 Offset: 0x5BB820 VA: 0x1805BD220 Slot: 12
	public virtual bool CheckSocketMods(Construction.Placement placement) { }

	// RVA: 0x5BDAC0 Offset: 0x5BC0C0 VA: 0x1805BDAC0
	public void .ctor() { }

}

public class Socket_Free : Socket_Base // TypeDefIndex: 9105
{	// Fields
	public Vector3 idealPlacementNormal; // 0xE8
	public bool useTargetNormal; // 0xF4
	public bool blendAimAngle; // 0xF5

	// Methods

	// RVA: 0x5BE130 Offset: 0x5BC730 VA: 0x1805BE130
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BE320 Offset: 0x5BC920 VA: 0x1805BE320 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BDBA0 Offset: 0x5BC1A0 VA: 0x1805BDBA0 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BE330 Offset: 0x5BC930 VA: 0x1805BE330
	public void .ctor() { }

}

public class Socket_Specific : Socket_Base // TypeDefIndex: 9106
{	// Fields
	public bool useFemaleRotation; // 0xE8
	public string targetSocketName; // 0xF0

	// Methods

	// RVA: 0x5BEE20 Offset: 0x5BD420 VA: 0x1805BEE20
	private void OnDrawGizmos() { }

	// RVA: 0x5BF0D0 Offset: 0x5BD6D0 VA: 0x1805BF0D0 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BE3B0 Offset: 0x5BC9B0 VA: 0x1805BE3B0 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BF260 Offset: 0x5BD860 VA: 0x1805BF260
	public void .ctor() { }

}

public class Socket_Specific_Female : Socket_Base // TypeDefIndex: 9107
{	// Fields
	public int rotationDegrees; // 0xE8
	public int rotationOffset; // 0xEC
	public string[] allowedMaleSockets; // 0xF0

	// Methods

	// RVA: 0x5BEB60 Offset: 0x5BD160 VA: 0x1805BEB60
	private void OnDrawGizmos() { }

	// RVA: 0x5BEAB0 Offset: 0x5BD0B0 VA: 0x1805BEAB0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5BEA20 Offset: 0x5BD020 VA: 0x1805BEA20
	public bool CanAccept(Socket_Specific socket) { }

	// RVA: 0x5BEE10 Offset: 0x5BD410 VA: 0x1805BEE10
	public void .ctor() { }

}

public class Socket_Terrain : Socket_Base // TypeDefIndex: 9108
{	// Fields
	public float placementHeight; // 0xE8
	public bool alignToNormal; // 0xEC

	// Methods

	// RVA: 0x5BF570 Offset: 0x5BDB70 VA: 0x1805BF570
	private void OnDrawGizmos() { }

	// RVA: 0x5BE320 Offset: 0x5BC920 VA: 0x1805BE320 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5BF270 Offset: 0x5BD870 VA: 0x1805BF270 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5BEE10 Offset: 0x5BD410 VA: 0x1805BEE10
	public void .ctor() { }

}

