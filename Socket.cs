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

	// RVA: 0x1001450 Offset: 0xFFFA50 VA: 0x181001450
	public AddressFamily get_Family() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Size() { }

	// RVA: 0x10014B0 Offset: 0xFFFAB0 VA: 0x1810014B0
	public byte get_Item(int offset) { }

	// RVA: 0x1000EF0 Offset: 0xFFF4F0 VA: 0x181000EF0
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x1001010 Offset: 0xFFF610 VA: 0x181001010
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x1000E70 Offset: 0xFFF470 VA: 0x181000E70
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x1000710 Offset: 0xFFED10 VA: 0x181000710
	internal IPAddress GetIPAddress() { }

	// RVA: 0x10009A0 Offset: 0xFFEFA0 VA: 0x1810009A0
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x1000470 Offset: 0xFFEA70 VA: 0x181000470 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x10005A0 Offset: 0xFFEBA0 VA: 0x1810005A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1000A60 Offset: 0xFFF060 VA: 0x181000A60 Slot: 3
	public override string ToString() { }

}

public class SocketException : Win32Exception // TypeDefIndex: 3038
{	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x1001AC0 Offset: 0x10000C0 VA: 0x181001AC0
	private static int WSAGetLastError_internal() { }

	// RVA: 0x1001C80 Offset: 0x1000280 VA: 0x181001C80
	public void .ctor() { }

	// RVA: 0x1001C10 Offset: 0x1000210 VA: 0x181001C10
	internal void .ctor(int error, string message) { }

	// RVA: 0x1001AD0 Offset: 0x10000D0 VA: 0x181001AD0
	public void .ctor(int errorCode) { }

	// RVA: 0x1001B30 Offset: 0x1000130 VA: 0x181001B30
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1001B90 Offset: 0x1000190 VA: 0x181001B90
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1001CF0 Offset: 0x10002F0 VA: 0x181001CF0 Slot: 5
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

	// RVA: 0x1009740 Offset: 0x1007D40 VA: 0x181009740
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x100A1E0 Offset: 0x10087E0 VA: 0x18100A1E0
	public static bool get_SupportsIPv4() { }

	// RVA: 0x100A000 Offset: 0x1008600 VA: 0x18100A000
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x100A250 Offset: 0x1008850 VA: 0x18100A250
	public static bool get_SupportsIPv6() { }

	// RVA: 0x100A070 Offset: 0x1008670 VA: 0x18100A070
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x962BC0 Offset: 0x9611C0 VA: 0x180962BC0
	public IntPtr get_Handle() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public SocketType get_SocketType() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x100A4C0 Offset: 0x1008AC0 VA: 0x18100A4C0
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x100A5F0 Offset: 0x1008BF0 VA: 0x18100A5F0
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x100A690 Offset: 0x1008C90 VA: 0x18100A690
	public void set_SendTimeout(int value) { }

	// RVA: 0x100A380 Offset: 0x1008980 VA: 0x18100A380
	public void set_DontFragment(bool value) { }

	// RVA: 0x1009B20 Offset: 0x1008120 VA: 0x181009B20
	public bool get_DualMode() { }

	// RVA: 0x100A420 Offset: 0x1008A20 VA: 0x18100A420
	public void set_DualMode(bool value) { }

	// RVA: 0x1009E40 Offset: 0x1008440 VA: 0x181009E40
	private bool get_IsDualMode() { }

	// RVA: 0x1007DC0 Offset: 0x10063C0 VA: 0x181007DC0
	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	// RVA: 0x1007D20 Offset: 0x1006320 VA: 0x181007D20
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1007FA0 Offset: 0x10065A0 VA: 0x181007FA0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1007360 Offset: 0x1005960 VA: 0x181007360
	public int Receive(byte[] buffer) { }

	// RVA: 0x10073A0 Offset: 0x10059A0 VA: 0x1810073A0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1006C90 Offset: 0x1005290 VA: 0x181006C90
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1005660 Offset: 0x1003C60 VA: 0x181005660
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1008680 Offset: 0x1006C80 VA: 0x181008680
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x1003770 Offset: 0x1001D70 VA: 0x181003770
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x10050A0 Offset: 0x10036A0 VA: 0x1810050A0
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x10029B0 Offset: 0x1000FB0 VA: 0x1810029B0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1004DF0 Offset: 0x10033F0 VA: 0x181004DF0
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x1009D40 Offset: 0x1008340 VA: 0x181009D40
	private static object get_InternalSyncObject() { }

	// RVA: 0x1009B10 Offset: 0x1008110 VA: 0x181009B10
	internal bool get_CleanedUp() { }

	// RVA: 0x1005940 Offset: 0x1003F40 VA: 0x181005940
	internal static void InitializeSockets() { }

	// RVA: 0x1004890 Offset: 0x1002E90 VA: 0x181004890 Slot: 4
	public void Dispose() { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1005D50 Offset: 0x1004350 VA: 0x181005D50
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1009630 Offset: 0x1007C30 VA: 0x181009630
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1008B50 Offset: 0x1007150 VA: 0x181008B50
	private void SocketDefaults() { }

	// RVA: 0x1008D20 Offset: 0x1007320 VA: 0x181008D20
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x1009A60 Offset: 0x1008060 VA: 0x181009A60
	public int get_Available() { }

	// RVA: 0x1002160 Offset: 0x1000760 VA: 0x181002160
	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	// RVA: 0x1002280 Offset: 0x1000880 VA: 0x181002280
	private static int Available_internal(IntPtr socket, out int error) { }

	// RVA: 0xBA1D60 Offset: 0xBA0360 VA: 0x180BA1D60
	public bool get_IsBound() { }

	// RVA: 0x1009F10 Offset: 0x1008510 VA: 0x181009F10
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x10061C0 Offset: 0x10047C0 VA: 0x1810061C0
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x10062F0 Offset: 0x10048F0 VA: 0x1810062F0
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x4BC3E0 Offset: 0x4BA9E0 VA: 0x1804BC3E0
	public bool get_Blocking() { }

	// RVA: 0x100A2C0 Offset: 0x10088C0 VA: 0x18100A2C0
	public void set_Blocking(bool value) { }

	// RVA: 0x1003D90 Offset: 0x1002390 VA: 0x181003D90
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x1003EB0 Offset: 0x10024B0 VA: 0x181003EB0
	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	// RVA: 0xBA1D50 Offset: 0xBA0350 VA: 0x180BA1D50
	public bool get_Connected() { }

	// RVA: 0x100A560 Offset: 0x1008B60 VA: 0x18100A560
	public void set_NoDelay(bool value) { }

	// RVA: 0x100A0E0 Offset: 0x10086E0 VA: 0x18100A0E0
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x10075E0 Offset: 0x1005BE0 VA: 0x1810075E0
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x10075D0 Offset: 0x1005BD0 VA: 0x1810075D0
	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x1006450 Offset: 0x1004A50 VA: 0x181006450
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x1006310 Offset: 0x1004910 VA: 0x181006310
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1006300 Offset: 0x1004900 VA: 0x181006300
	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1002010 Offset: 0x1000610 VA: 0x181002010
	public Socket Accept() { }

	// RVA: 0x1001ED0 Offset: 0x10004D0 VA: 0x181001ED0
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x1002290 Offset: 0x1000890 VA: 0x181002290
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x10049E0 Offset: 0x1002FE0 VA: 0x1810049E0
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x1004900 Offset: 0x1002F00 VA: 0x181004900
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1001D90 Offset: 0x1000390 VA: 0x181001D90
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x1001D80 Offset: 0x1000380 VA: 0x181001D80
	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x1003C10 Offset: 0x1002210 VA: 0x181003C10
	public void Bind(EndPoint localEP) { }

	// RVA: 0x1003AE0 Offset: 0x10020E0 VA: 0x181003AE0
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x1003C00 Offset: 0x1002200 VA: 0x181003C00
	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x10060C0 Offset: 0x10046C0 VA: 0x1810060C0
	public void Listen(int backlog) { }

	// RVA: 0x1005FA0 Offset: 0x10045A0 VA: 0x181005FA0
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1005F90 Offset: 0x1004590 VA: 0x181005F90
	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x10040E0 Offset: 0x10026E0 VA: 0x1810040E0
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1002420 Offset: 0x1000A20 VA: 0x181002420
	private static void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1002BC0 Offset: 0x10011C0 VA: 0x181002BC0
	private static void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1004AA0 Offset: 0x10030A0 VA: 0x181004AA0
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1003FC0 Offset: 0x10025C0 VA: 0x181003FC0
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1003FB0 Offset: 0x10025B0 VA: 0x181003FB0
	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x10045E0 Offset: 0x1002BE0 VA: 0x1810045E0
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x1004B50 Offset: 0x1003150 VA: 0x181004B50
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x10044B0 Offset: 0x1002AB0 VA: 0x1810044B0
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x10045D0 Offset: 0x1002BD0 VA: 0x1810045D0
	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x10071F0 Offset: 0x10057F0 VA: 0x1810071F0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1006D30 Offset: 0x1005330 VA: 0x181006D30
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x10027B0 Offset: 0x1000DB0 VA: 0x1810027B0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1004D10 Offset: 0x1003310 VA: 0x181004D10
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1006B30 Offset: 0x1005130 VA: 0x181006B30
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1006C70 Offset: 0x1005270 VA: 0x181006C70
	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10069F0 Offset: 0x1004FF0 VA: 0x1810069F0
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1006C80 Offset: 0x1005280 VA: 0x181006C80
	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1006850 Offset: 0x1004E50 VA: 0x181006850
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x1002560 Offset: 0x1000B60 VA: 0x181002560
	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1004C00 Offset: 0x1003200 VA: 0x181004C00
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x1006700 Offset: 0x1004D00 VA: 0x181006700
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x10066F0 Offset: 0x1004CF0 VA: 0x1810066F0
	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1007DF0 Offset: 0x10063F0 VA: 0x181007DF0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1008190 Offset: 0x1006790 VA: 0x181008190
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1003850 Offset: 0x1001E50 VA: 0x181003850
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x10030F0 Offset: 0x10016F0 VA: 0x1810030F0
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1004FC0 Offset: 0x10035C0 VA: 0x181004FC0
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1007BC0 Offset: 0x10061C0 VA: 0x181007BC0
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007D10 Offset: 0x1006310 VA: 0x181007D10
	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007A80 Offset: 0x1006080 VA: 0x181007A80
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007D00 Offset: 0x1006300 VA: 0x181007D00
	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1007870 Offset: 0x1005E70 VA: 0x181007870
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1003500 Offset: 0x1001B00 VA: 0x181003500
	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1003340 Offset: 0x1001940 VA: 0x181003340
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1004F10 Offset: 0x1003510 VA: 0x181004F10
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1007710 Offset: 0x1005D10 VA: 0x181007710
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1007860 Offset: 0x1005E60 VA: 0x181007860
	private static int SendTo_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x10051C0 Offset: 0x10037C0 VA: 0x1810051C0
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x10053C0 Offset: 0x10039C0 VA: 0x1810053C0
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x10053B0 Offset: 0x10039B0 VA: 0x1810053B0
	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x10088E0 Offset: 0x1006EE0 VA: 0x1810088E0
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x1008900 Offset: 0x1006F00 VA: 0x181008900
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1008780 Offset: 0x1006D80 VA: 0x181008780
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x10088D0 Offset: 0x1006ED0 VA: 0x1810088D0
	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x10057D0 Offset: 0x1003DD0 VA: 0x1810057D0
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1005500 Offset: 0x1003B00 VA: 0x181005500
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1005650 Offset: 0x1003C50 VA: 0x181005650
	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1003F40 Offset: 0x1002540 VA: 0x181003F40
	public void Close() { }

	// RVA: 0x1003ED0 Offset: 0x10024D0 VA: 0x181003ED0
	public void Close(int timeout) { }

	// RVA: 0x1003EC0 Offset: 0x10024C0 VA: 0x181003EC0
	internal static void Close_internal(IntPtr socket, out int error) { }

	// RVA: 0x1008A20 Offset: 0x1007020 VA: 0x181008A20
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x1008B40 Offset: 0x1007140 VA: 0x181008B40
	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x10046D0 Offset: 0x1002CD0 VA: 0x1810046D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1005E20 Offset: 0x1004420 VA: 0x181005E20
	private void Linger(IntPtr handle) { }

	// RVA: 0x1008EE0 Offset: 0x10074E0 VA: 0x181008EE0
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1008D30 Offset: 0x1007330 VA: 0x181008D30
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x1008D90 Offset: 0x1007390 VA: 0x181008D90
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x1008F80 Offset: 0x1007580 VA: 0x181008F80
	private void ThrowIfUdp() { }

	// RVA: 0x1008FE0 Offset: 0x10075E0 VA: 0x181008FE0
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x10065C0 Offset: 0x1004BC0 VA: 0x1810065C0
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1007460 Offset: 0x1005A60 VA: 0x181007460
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1009A50 Offset: 0x1008050 VA: 0x181009A50
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x1009BE0 Offset: 0x10081E0 VA: 0x181009BE0
	internal static int get_FamilyHint() { }

	// RVA: 0xFE7960 Offset: 0xFE5F60 VA: 0x180FE7960
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1005DD0 Offset: 0x10043D0 VA: 0x181005DD0
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1009110 Offset: 0x1007710 VA: 0x181009110
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

	// RVA: 0x100ECC0 Offset: 0x100D2C0 VA: 0x18100ECC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100CA10 Offset: 0x100B010 VA: 0x18100CA10
	internal void <BeginSend>b__241_0(IOAsyncResult s) { }

	// RVA: 0x100C990 Offset: 0x100AF90 VA: 0x18100C990
	internal void <BeginSendTo>b__253_0(IOAsyncResult s) { }

	// RVA: 0x100CB00 Offset: 0x100B100 VA: 0x18100CB00
	internal void <.cctor>b__309_0(IAsyncResult ares) { }

	// RVA: 0x100D860 Offset: 0x100BE60 VA: 0x18100D860
	internal void <.cctor>b__309_1(IOAsyncResult ares) { }

	// RVA: 0x100D950 Offset: 0x100BF50 VA: 0x18100D950
	internal void <.cctor>b__309_2(IOAsyncResult ares) { }

	// RVA: 0x100DAF0 Offset: 0x100C0F0 VA: 0x18100DAF0
	internal void <.cctor>b__309_3(IAsyncResult ares) { }

	// RVA: 0x100DD80 Offset: 0x100C380 VA: 0x18100DD80
	internal void <.cctor>b__309_4(IOAsyncResult ares) { }

	// RVA: 0x100E050 Offset: 0x100C650 VA: 0x18100E050
	internal void <.cctor>b__309_5(IAsyncResult ares) { }

	// RVA: 0x100E2E0 Offset: 0x100C8E0 VA: 0x18100E2E0
	internal void <.cctor>b__309_6(IOAsyncResult ares) { }

	// RVA: 0x100E480 Offset: 0x100CA80 VA: 0x18100E480
	internal void <.cctor>b__309_7(IAsyncResult ares) { }

	// RVA: 0x100E690 Offset: 0x100CC90 VA: 0x18100E690
	internal void <.cctor>b__309_8(IOAsyncResult ares) { }

	// RVA: 0x100E810 Offset: 0x100CE10 VA: 0x18100E810
	internal void <.cctor>b__309_9(IOAsyncResult ares) { }

	// RVA: 0x100CE40 Offset: 0x100B440 VA: 0x18100CE40
	internal void <.cctor>b__309_10(IAsyncResult ares) { }

	// RVA: 0x100D050 Offset: 0x100B650 VA: 0x18100D050
	internal void <.cctor>b__309_11(IOAsyncResult ares) { }

	// RVA: 0x100D2F0 Offset: 0x100B8F0 VA: 0x18100D2F0
	internal void <.cctor>b__309_12(IAsyncResult ares) { }

	// RVA: 0x100D500 Offset: 0x100BB00 VA: 0x18100D500
	internal void <.cctor>b__309_13(IOAsyncResult ares) { }

	// RVA: 0x100D650 Offset: 0x100BC50 VA: 0x18100D650
	internal void <.cctor>b__309_14(IAsyncResult ares) { }

}

private sealed class Socket.<>c__DisplayClass242_0 // TypeDefIndex: 3050
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100EAD0 Offset: 0x100D0D0 VA: 0x18100EAD0
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

private sealed class Socket.<>c__DisplayClass254_0 // TypeDefIndex: 3051
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100EB60 Offset: 0x100D160 VA: 0x18100EB60
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

	// RVA: 0x100EBF0 Offset: 0x100D1F0 VA: 0x18100EBF0
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
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_SocketError(SocketError value) { }

	// RVA: 0x1001550 Offset: 0xFFFB50 VA: 0x181001550
	internal void Complete() { }

	// RVA: 0x1001570 Offset: 0xFFFB70 VA: 0x181001570 Slot: 4
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

	// RVA: 0x1001A70 Offset: 0x1000070 VA: 0x181001A70
	public IntPtr get_Handle() { }

	// RVA: 0x10019A0 Offset: 0xFFFFA0 VA: 0x1810019A0
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x10019F0 Offset: 0xFFFFF0 VA: 0x1810019F0
	public SocketError get_ErrorCode() { }

	// RVA: 0x10015C0 Offset: 0xFFFBC0 VA: 0x1810015C0
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x1001690 Offset: 0xFFFC90 VA: 0x181001690 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x1001750 Offset: 0xFFFD50 VA: 0x181001750
	public void Complete() { }

	// RVA: 0x1001740 Offset: 0xFFFD40 VA: 0x181001740
	public void Complete(bool synch) { }

	// RVA: 0x1001990 Offset: 0xFFFF90 VA: 0x181001990
	public void Complete(int total) { }

	// RVA: 0x10016A0 Offset: 0xFFFCA0 VA: 0x1810016A0
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x10016E0 Offset: 0xFFFCE0 VA: 0x1810016E0
	public void Complete(Exception e) { }

	// RVA: 0x1001710 Offset: 0xFFFD10 VA: 0x181001710
	public void Complete(Socket s) { }

	// RVA: 0x1001950 Offset: 0xFFFF50 VA: 0x181001950
	public void Complete(Socket s, int total) { }

}

private sealed class SocketAsyncResult.<>c // TypeDefIndex: 3065
{	// Fields
	public static readonly SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x100EC60 Offset: 0x100D260 VA: 0x18100EC60
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x100CA90 Offset: 0x100B090 VA: 0x18100CA90
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

	// RVA: 0x1537770 Offset: 0x1535D70 VA: 0x181537770
	public void .ctor() { }

	// RVA: 0x15377A0 Offset: 0x1535DA0 VA: 0x1815377A0 Slot: 4
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
	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	internal void set_Socket(Socket value) { }

	// RVA: 0xDE3C30 Offset: 0xDE2230 VA: 0x180DE3C30 Slot: 3
	public override string ToString() { }

	// RVA: 0xDE2F50 Offset: 0xDE1550 VA: 0x180DE2F50
	internal void Initialize() { }

	// RVA: 0xDE2E40 Offset: 0xDE1440 VA: 0x180DE2E40
	public bool Close() { }

	// RVA: 0xDE3210 Offset: 0xDE1810 VA: 0x180DE3210 Slot: 4
	public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE3100 Offset: 0xDE1700 VA: 0x180DE3100 Slot: 5
	public virtual void OnConnecting(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE2FC0 Offset: 0xDE15C0 VA: 0x180DE2FC0 Slot: 6
	public virtual void OnConnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE35C0 Offset: 0xDE1BC0 VA: 0x180DE35C0 Slot: 7
	public virtual void OnDisconnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDE3A30 Offset: 0xDE2030 VA: 0x180DE3A30
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0xDE3870 Offset: 0xDE1E70 VA: 0x180DE3870
	internal void ReceiveMessage(IntPtr msgPtr) { }

	// RVA: 0xDE36E0 Offset: 0xDE1CE0 VA: 0x180DE36E0 Slot: 8
	public virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0xDE3C50 Offset: 0xDE2250 VA: 0x180DE3C50
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

	// RVA: 0x2208D20 Offset: 0x2207320 VA: 0x182208D20 Slot: 5
	public IPAddress get_RemoteIpAddress() { }

	// RVA: 0x2208DB0 Offset: 0x22073B0 VA: 0x182208DB0 Slot: 6
	public int get_RemotePort() { }

	// RVA: 0x2208A60 Offset: 0x2207060 VA: 0x182208A60
	private static void .cctor() { }

	// RVA: 0x2208B60 Offset: 0x2207160 VA: 0x182208B60
	public void .ctor(Socket socket) { }

	// RVA: 0x2208620 Offset: 0x2206C20 VA: 0x182208620 Slot: 11
	public Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error) { }

	// RVA: 0x2208A40 Offset: 0x2207040 VA: 0x182208A40 Slot: 15
	public void Listen(int backlog) { }

	// RVA: 0x2208970 Offset: 0x2206F70 VA: 0x182208970 Slot: 14
	public void Bind(EndPoint endPoint) { }

	// RVA: 0x2208CE0 Offset: 0x22072E0 VA: 0x182208CE0 Slot: 4
	public bool get_Connected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 7
	public Stream get_Stream() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_Stream(Stream value) { }

	// RVA: 0x2208E40 Offset: 0x2207440 VA: 0x182208E40 Slot: 8
	public void set_NoDelay(bool value) { }

	// RVA: 0x2208D00 Offset: 0x2207300 VA: 0x182208D00 Slot: 9
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x2208420 Offset: 0x2206A20 VA: 0x182208420 Slot: 10
	public Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error) { }

	// RVA: 0x22089F0 Offset: 0x2206FF0 VA: 0x1822089F0 Slot: 12
	public void Dispose() { }

	// RVA: 0x2208990 Offset: 0x2206F90 VA: 0x182208990 Slot: 13
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

	// RVA: 0x22091C0 Offset: 0x22077C0 VA: 0x1822091C0
	internal IAsyncResult <Authenticate>b__0(AsyncCallback cb, object s) { }

	// RVA: 0x2209210 Offset: 0x2207810 VA: 0x182209210
	internal void <Authenticate>b__1(Task t) { }

	// RVA: 0x2209230 Offset: 0x2207830 VA: 0x182209230
	internal void <Authenticate>b__2(Task t) { }

	// RVA: 0x22092A0 Offset: 0x22078A0 VA: 0x1822092A0
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

	// RVA: 0x2209310 Offset: 0x2207910 VA: 0x182209310
	internal ISocket <Accept>b__0(IAsyncResult r) { }

	// RVA: 0x22093D0 Offset: 0x22079D0 VA: 0x1822093D0
	internal void <Accept>b__1(Task<ISocket> t) { }

	// RVA: 0x2209440 Offset: 0x2207A40 VA: 0x182209440
	internal void <Accept>b__2(Task t) { }

	// RVA: 0x22094B0 Offset: 0x2207AB0 VA: 0x1822094B0
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

