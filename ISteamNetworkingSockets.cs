internal class ISteamNetworkingSockets : SteamInterface // TypeDefIndex: 5123
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128C390 Offset: 0x128A990 VA: 0x18128C390
	internal static extern IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x128C390 Offset: 0x128A990 VA: 0x18128C390 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128C320 Offset: 0x128A920 VA: 0x18128C320
	internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x128C320 Offset: 0x128A920 VA: 0x18128C320 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x128CA20 Offset: 0x128B020 VA: 0x18128CA20
	private static extern Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128BAF0 Offset: 0x128A0F0 VA: 0x18128BAF0
	internal Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C970 Offset: 0x128AF70 VA: 0x18128C970
	private static extern Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128BA40 Offset: 0x128A040 VA: 0x18128BA40
	internal Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128C6B0 Offset: 0x128ACB0 VA: 0x18128C6B0
	private static extern Result _AcceptConnection(IntPtr self, Connection hConn) { }

	// RVA: 0x128B780 Offset: 0x1289D80 VA: 0x18128B780
	internal Result AcceptConnection(Connection hConn) { }

	// RVA: 0x128C740 Offset: 0x128AD40 VA: 0x18128C740
	private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x128B810 Offset: 0x1289E10 VA: 0x18128B810
	internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x128C810 Offset: 0x128AE10 VA: 0x18128C810
	private static extern bool _CloseListenSocket(IntPtr self, Socket hSocket) { }

	// RVA: 0x128B8E0 Offset: 0x1289EE0 VA: 0x18128B8E0
	internal bool CloseListenSocket(Socket hSocket) { }

	// RVA: 0x128D450 Offset: 0x128BA50 VA: 0x18128D450
	private static extern void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x128C560 Offset: 0x128AB60 VA: 0x18128C560
	internal void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x128D310 Offset: 0x128B910 VA: 0x18128D310
	private static extern int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128C400 Offset: 0x128AA00 VA: 0x18128C400
	internal int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128CC90 Offset: 0x128B290 VA: 0x18128CC90
	private static extern Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x128BD60 Offset: 0x128A360 VA: 0x18128BD60
	internal Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x128CEE0 Offset: 0x128B4E0 VA: 0x18128CEE0
	private static extern int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf) { }

	// RVA: 0x128BD80 Offset: 0x128A380 VA: 0x18128BD80
	internal int GetDetailedConnectionStatus(Connection hConn, out string pszBuf) { }

	// RVA: 0x128C8A0 Offset: 0x128AEA0 VA: 0x18128C8A0
	private static extern Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x128B970 Offset: 0x1289F70 VA: 0x18128B970
	internal Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x128D280 Offset: 0x128B880 VA: 0x18128D280
	private static extern bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity) { }

	// RVA: 0x128C290 Offset: 0x128A890 VA: 0x18128C290
	internal bool GetIdentity(ref NetIdentity pIdentity) { }

	// RVA: 0x128CB80 Offset: 0x128B180 VA: 0x18128CB80
	private static extern HSteamNetPollGroup _CreatePollGroup(IntPtr self) { }

	// RVA: 0x128BC50 Offset: 0x128A250 VA: 0x18128BC50
	internal HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0x128CC00 Offset: 0x128B200 VA: 0x18128CC00
	private static extern bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128BCD0 Offset: 0x128A2D0 VA: 0x18128BCD0
	internal bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128D4F0 Offset: 0x128BAF0 VA: 0x18128D4F0
	private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128C610 Offset: 0x128AC10 VA: 0x18128C610
	internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x128D3B0 Offset: 0x128B9B0 VA: 0x18128D3B0
	private static extern int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128C4B0 Offset: 0x128AAB0 VA: 0x18128C4B0
	internal int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x128CF80 Offset: 0x128B580 VA: 0x18128CF80
	private static extern void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x128BF90 Offset: 0x128A590 VA: 0x18128BF90
	internal void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x128CAD0 Offset: 0x128B0D0 VA: 0x18128CAD0
	private static extern Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x128BBA0 Offset: 0x128A1A0 VA: 0x18128BBA0
	internal Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

}

