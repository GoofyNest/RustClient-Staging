internal class ISteamNetworkingSockets : SteamInterface // TypeDefIndex: 5123
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128CA30 Offset: 0x128B030 VA: 0x18128CA30
	internal static extern IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x128CA30 Offset: 0x128B030 VA: 0x18128CA30 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128C9C0 Offset: 0x128AFC0 VA: 0x18128C9C0
	internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x128C9C0 Offset: 0x128AFC0 VA: 0x18128C9C0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x128D0C0 Offset: 0x128B6C0 VA: 0x18128D0C0
	private static extern Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C190 Offset: 0x128A790 VA: 0x18128C190
	internal Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128D010 Offset: 0x128B610 VA: 0x18128D010
	private static extern Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C0E0 Offset: 0x128A6E0 VA: 0x18128C0E0
	internal Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128CD50 Offset: 0x128B350 VA: 0x18128CD50
	private static extern Result _AcceptConnection(IntPtr self, Connection hConn) { }

	// RVA: 0x128BE20 Offset: 0x128A420 VA: 0x18128BE20
	internal Result AcceptConnection(Connection hConn) { }

	// RVA: 0x128CDE0 Offset: 0x128B3E0 VA: 0x18128CDE0
	private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x128BEB0 Offset: 0x128A4B0 VA: 0x18128BEB0
	internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x128CEB0 Offset: 0x128B4B0 VA: 0x18128CEB0
	private static extern bool _CloseListenSocket(IntPtr self, Socket hSocket) { }

	// RVA: 0x128BF80 Offset: 0x128A580 VA: 0x18128BF80
	internal bool CloseListenSocket(Socket hSocket) { }

	// RVA: 0x128DAF0 Offset: 0x128C0F0 VA: 0x18128DAF0
	private static extern void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x128CC00 Offset: 0x128B200 VA: 0x18128CC00
	internal void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x128D9B0 Offset: 0x128BFB0 VA: 0x18128D9B0
	private static extern int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128CAA0 Offset: 0x128B0A0 VA: 0x18128CAA0
	internal int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128D330 Offset: 0x128B930 VA: 0x18128D330
	private static extern Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x128C400 Offset: 0x128AA00 VA: 0x18128C400
	internal Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x128D580 Offset: 0x128BB80 VA: 0x18128D580
	private static extern int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf) { }

	// RVA: 0x128C420 Offset: 0x128AA20 VA: 0x18128C420
	internal int GetDetailedConnectionStatus(Connection hConn, out string pszBuf) { }

	// RVA: 0x128CF40 Offset: 0x128B540 VA: 0x18128CF40
	private static extern Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x128C010 Offset: 0x128A610 VA: 0x18128C010
	internal Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x128D920 Offset: 0x128BF20 VA: 0x18128D920
	private static extern bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity) { }

	// RVA: 0x128C930 Offset: 0x128AF30 VA: 0x18128C930
	internal bool GetIdentity(ref NetIdentity pIdentity) { }

	// RVA: 0x128D220 Offset: 0x128B820 VA: 0x18128D220
	private static extern HSteamNetPollGroup _CreatePollGroup(IntPtr self) { }

	// RVA: 0x128C2F0 Offset: 0x128A8F0 VA: 0x18128C2F0
	internal HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0x128D2A0 Offset: 0x128B8A0 VA: 0x18128D2A0
	private static extern bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128C370 Offset: 0x128A970 VA: 0x18128C370
	internal bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128DB90 Offset: 0x128C190 VA: 0x18128DB90
	private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128CCB0 Offset: 0x128B2B0 VA: 0x18128CCB0
	internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128DA50 Offset: 0x128C050 VA: 0x18128DA50
	private static extern int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128CB50 Offset: 0x128B150 VA: 0x18128CB50
	internal int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128D620 Offset: 0x128BC20 VA: 0x18128D620
	private static extern void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x128C630 Offset: 0x128AC30 VA: 0x18128C630
	internal void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x128D170 Offset: 0x128B770 VA: 0x18128D170
	private static extern Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C240 Offset: 0x128A840 VA: 0x18128C240
	internal Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

}

