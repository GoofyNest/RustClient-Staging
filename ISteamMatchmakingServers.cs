internal class ISteamMatchmakingServers : SteamInterface // TypeDefIndex: 5120
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128A070 Offset: 0x1288670 VA: 0x18128A070
	internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002() { }

	// RVA: 0x128A070 Offset: 0x1288670 VA: 0x18128A070 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128B310 Offset: 0x1289910 VA: 0x18128B310
	private static extern HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A7D0 Offset: 0x1288DD0 VA: 0x18128A7D0
	internal HServerListRequest RequestInternetServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128B500 Offset: 0x1289B00 VA: 0x18128B500
	private static extern HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A9C0 Offset: 0x1288FC0 VA: 0x18128A9C0
	internal HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x128AF30 Offset: 0x1289530 VA: 0x18128AF30
	private static extern HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A3F0 Offset: 0x12889F0 VA: 0x18128A3F0
	internal HServerListRequest RequestFriendsServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128AD40 Offset: 0x1289340 VA: 0x18128AD40
	private static extern HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A200 Offset: 0x1288800 VA: 0x18128A200
	internal HServerListRequest RequestFavoritesServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128B120 Offset: 0x1289720 VA: 0x18128B120
	private static extern HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A5E0 Offset: 0x1288BE0 VA: 0x18128A5E0
	internal HServerListRequest RequestHistoryServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128ACB0 Offset: 0x12892B0 VA: 0x18128ACB0
	private static extern void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest) { }

	// RVA: 0x128A170 Offset: 0x1288770 VA: 0x18128A170
	internal void ReleaseRequest(HServerListRequest hServerListRequest) { }

	// RVA: 0x128AB80 Offset: 0x1289180 VA: 0x18128AB80
	private static extern IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x1289F30 Offset: 0x1288530 VA: 0x181289F30
	internal gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	// RVA: 0x128AA60 Offset: 0x1289060 VA: 0x18128AA60
	private static extern void _CancelQuery(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289E10 Offset: 0x1288410 VA: 0x181289E10
	internal void CancelQuery(HServerListRequest hRequest) { }

	// RVA: 0x128AC20 Offset: 0x1289220 VA: 0x18128AC20
	private static extern bool _IsRefreshing(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x128A0E0 Offset: 0x12886E0 VA: 0x18128A0E0
	internal bool IsRefreshing(HServerListRequest hRequest) { }

	// RVA: 0x128AAF0 Offset: 0x12890F0 VA: 0x18128AAF0
	private static extern int _GetServerCount(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289EA0 Offset: 0x12884A0 VA: 0x181289EA0
	internal int GetServerCount(HServerListRequest hRequest) { }

}

