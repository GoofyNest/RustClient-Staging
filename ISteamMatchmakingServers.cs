internal class ISteamMatchmakingServers : SteamInterface // TypeDefIndex: 5120
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1289710 Offset: 0x1287D10 VA: 0x181289710
	internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002() { }

	// RVA: 0x1289710 Offset: 0x1287D10 VA: 0x181289710 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128A9B0 Offset: 0x1288FB0 VA: 0x18128A9B0
	private static extern HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1289E70 Offset: 0x1288470 VA: 0x181289E70
	internal HServerListRequest RequestInternetServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128ABA0 Offset: 0x12891A0 VA: 0x18128ABA0
	private static extern HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A060 Offset: 0x1288660 VA: 0x18128A060
	internal HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A5D0 Offset: 0x1288BD0 VA: 0x18128A5D0
	private static extern HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1289A90 Offset: 0x1288090 VA: 0x181289A90
	internal HServerListRequest RequestFriendsServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A3E0 Offset: 0x12889E0 VA: 0x18128A3E0
	private static extern HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x12898A0 Offset: 0x1287EA0 VA: 0x1812898A0
	internal HServerListRequest RequestFavoritesServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A7C0 Offset: 0x1288DC0 VA: 0x18128A7C0
	private static extern HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1289C80 Offset: 0x1288280 VA: 0x181289C80
	internal HServerListRequest RequestHistoryServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x128A350 Offset: 0x1288950 VA: 0x18128A350
	private static extern void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest) { }

	// RVA: 0x1289810 Offset: 0x1287E10 VA: 0x181289810
	internal void ReleaseRequest(HServerListRequest hServerListRequest) { }

	// RVA: 0x128A220 Offset: 0x1288820 VA: 0x18128A220
	private static extern IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x12895D0 Offset: 0x1287BD0 VA: 0x1812895D0
	internal gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	// RVA: 0x128A100 Offset: 0x1288700 VA: 0x18128A100
	private static extern void _CancelQuery(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x12894B0 Offset: 0x1287AB0 VA: 0x1812894B0
	internal void CancelQuery(HServerListRequest hRequest) { }

	// RVA: 0x128A2C0 Offset: 0x12888C0 VA: 0x18128A2C0
	private static extern bool _IsRefreshing(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289780 Offset: 0x1287D80 VA: 0x181289780
	internal bool IsRefreshing(HServerListRequest hRequest) { }

	// RVA: 0x128A190 Offset: 0x1288790 VA: 0x18128A190
	private static extern int _GetServerCount(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1289540 Offset: 0x1287B40 VA: 0x181289540
	internal int GetServerCount(HServerListRequest hRequest) { }

}

