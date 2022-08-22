internal class ISteamMatchmakingServers : SteamInterface // TypeDefIndex: 5120
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x12899D0 Offset: 0x1287FD0 VA: 0x1812899D0
	internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002() { }

	// RVA: 0x12899D0 Offset: 0x1287FD0 VA: 0x1812899D0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128AC70 Offset: 0x1289270 VA: 0x18128AC70
	private static extern HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A130 Offset: 0x1288730 VA: 0x18128A130
	internal HServerListRequest RequestInternetServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128AE60 Offset: 0x1289460 VA: 0x18128AE60
	private static extern HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A320 Offset: 0x1288920 VA: 0x18128A320
	internal HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A890 Offset: 0x1288E90 VA: 0x18128A890
	private static extern HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1289D50 Offset: 0x1288350 VA: 0x181289D50
	internal HServerListRequest RequestFriendsServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A6A0 Offset: 0x1288CA0 VA: 0x18128A6A0
	private static extern HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1289B60 Offset: 0x1288160 VA: 0x181289B60
	internal HServerListRequest RequestFavoritesServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128AA80 Offset: 0x1289080 VA: 0x18128AA80
	private static extern HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1289F40 Offset: 0x1288540 VA: 0x181289F40
	internal HServerListRequest RequestHistoryServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A610 Offset: 0x1288C10 VA: 0x18128A610
	private static extern void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest) { }

	// RVA: 0x1289AD0 Offset: 0x12880D0 VA: 0x181289AD0
	internal void ReleaseRequest(HServerListRequest hServerListRequest) { }

	// RVA: 0x128A4E0 Offset: 0x1288AE0 VA: 0x18128A4E0
	private static extern IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x1289890 Offset: 0x1287E90 VA: 0x181289890
	internal gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	// RVA: 0x128A3C0 Offset: 0x12889C0 VA: 0x18128A3C0
	private static extern void _CancelQuery(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289770 Offset: 0x1287D70 VA: 0x181289770
	internal void CancelQuery(HServerListRequest hRequest) { }

	// RVA: 0x128A580 Offset: 0x1288B80 VA: 0x18128A580
	private static extern bool _IsRefreshing(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289A40 Offset: 0x1288040 VA: 0x181289A40
	internal bool IsRefreshing(HServerListRequest hRequest) { }

	// RVA: 0x128A450 Offset: 0x1288A50 VA: 0x18128A450
	private static extern int _GetServerCount(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289800 Offset: 0x1287E00 VA: 0x181289800
	internal int GetServerCount(HServerListRequest hRequest) { }

}

