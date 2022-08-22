internal class ISteamMatchmaking : SteamInterface // TypeDefIndex: 5119
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128B8A0 Offset: 0x1289EA0 VA: 0x18128B8A0
	internal static extern IntPtr SteamAPI_SteamMatchmaking_v009() { }

	// RVA: 0x128B8A0 Offset: 0x1289EA0 VA: 0x18128B8A0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128BAB0 Offset: 0x128A0B0 VA: 0x18128BAB0
	private static extern int _GetFavoriteGameCount(IntPtr self) { }

	// RVA: 0x128B670 Offset: 0x1289C70 VA: 0x18128B670
	internal int GetFavoriteGameCount() { }

	// RVA: 0x128BB30 Offset: 0x128A130 VA: 0x18128BB30
	private static extern bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x128B6F0 Offset: 0x1289CF0 VA: 0x18128B6F0
	internal bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x128B9E0 Offset: 0x1289FE0 VA: 0x18128B9E0
	private static extern int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x128B5A0 Offset: 0x1289BA0 VA: 0x18128B5A0
	internal int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x128BCE0 Offset: 0x128A2E0 VA: 0x18128BCE0
	private static extern bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x128B910 Offset: 0x1289F10 VA: 0x18128B910
	internal bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x128BC10 Offset: 0x128A210 VA: 0x18128BC10
	private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x128B7D0 Offset: 0x1289DD0 VA: 0x18128B7D0
	internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

