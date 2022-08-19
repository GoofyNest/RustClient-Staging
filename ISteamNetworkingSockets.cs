internal class ISteamNetworkingSockets : SteamInterface // TypeDefIndex: 5123
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128C0D0 Offset: 0x128A6D0 VA: 0x18128C0D0
	internal static extern IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x128C0D0 Offset: 0x128A6D0 VA: 0x18128C0D0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128C060 Offset: 0x128A660 VA: 0x18128C060
	internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x128C060 Offset: 0x128A660 VA: 0x18128C060 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x128C760 Offset: 0x128AD60 VA: 0x18128C760
	private static extern Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128B830 Offset: 0x1289E30 VA: 0x18128B830
	internal Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C6B0 Offset: 0x128ACB0 VA: 0x18128C6B0
	private static extern Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128B780 Offset: 0x1289D80 VA: 0x18128B780
	internal Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C3F0 Offset: 0x128A9F0 VA: 0x18128C3F0
	private static extern Result _AcceptConnection(IntPtr self, Connection hConn) { }

	// RVA: 0x128B4C0 Offset: 0x1289AC0 VA: 0x18128B4C0
	internal Result AcceptConnection(Connection hConn) { }

	// RVA: 0x128C480 Offset: 0x128AA80 VA: 0x18128C480
	private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x128B550 Offset: 0x1289B50 VA: 0x18128B550
	internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x128C550 Offset: 0x128AB50 VA: 0x18128C550
	private static extern bool _CloseListenSocket(IntPtr self, Socket hSocket) { }

	// RVA: 0x128B620 Offset: 0x1289C20 VA: 0x18128B620
	internal bool CloseListenSocket(Socket hSocket) { }

	// RVA: 0x128D190 Offset: 0x128B790 VA: 0x18128D190
	private static extern void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x128C2A0 Offset: 0x128A8A0 VA: 0x18128C2A0
	internal void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x128D050 Offset: 0x128B650 VA: 0x18128D050
	private static extern int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128C140 Offset: 0x128A740 VA: 0x18128C140
	internal int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128C9D0 Offset: 0x128AFD0 VA: 0x18128C9D0
	private static extern Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x128BAA0 Offset: 0x128A0A0 VA: 0x18128BAA0
	internal Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x128CC20 Offset: 0x128B220 VA: 0x18128CC20
	private static extern int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf) { }

	// RVA: 0x128BAC0 Offset: 0x128A0C0 VA: 0x18128BAC0
	internal int GetDetailedConnectionStatus(Connection hConn, out string pszBuf) { }

	// RVA: 0x128C5E0 Offset: 0x128ABE0 VA: 0x18128C5E0
	private static extern Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x128B6B0 Offset: 0x1289CB0 VA: 0x18128B6B0
	internal Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x128CFC0 Offset: 0x128B5C0 VA: 0x18128CFC0
	private static extern bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity) { }

	// RVA: 0x128BFD0 Offset: 0x128A5D0 VA: 0x18128BFD0
	internal bool GetIdentity(ref NetIdentity pIdentity) { }

	// RVA: 0x128C8C0 Offset: 0x128AEC0 VA: 0x18128C8C0
	private static extern HSteamNetPollGroup _CreatePollGroup(IntPtr self) { }

	// RVA: 0x128B990 Offset: 0x1289F90 VA: 0x18128B990
	internal HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0x128C940 Offset: 0x128AF40 VA: 0x18128C940
	private static extern bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128BA10 Offset: 0x128A010 VA: 0x18128BA10
	internal bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128D230 Offset: 0x128B830 VA: 0x18128D230
	private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128C350 Offset: 0x128A950 VA: 0x18128C350
	internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128D0F0 Offset: 0x128B6F0 VA: 0x18128D0F0
	private static extern int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128C1F0 Offset: 0x128A7F0 VA: 0x18128C1F0
	internal int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128CCC0 Offset: 0x128B2C0 VA: 0x18128CCC0
	private static extern void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x128BCD0 Offset: 0x128A2D0 VA: 0x18128BCD0
	internal void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x128C810 Offset: 0x128AE10 VA: 0x18128C810
	private static extern Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128B8E0 Offset: 0x1289EE0 VA: 0x18128B8E0
	internal Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

}

