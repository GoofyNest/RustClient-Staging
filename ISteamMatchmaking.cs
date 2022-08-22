internal class ISteamMatchmaking : SteamInterface // TypeDefIndex: 5119
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128B200 Offset: 0x1289800 VA: 0x18128B200
	internal static extern IntPtr SteamAPI_SteamMatchmaking_v009() { }

	// RVA: 0x128B200 Offset: 0x1289800 VA: 0x18128B200 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128B410 Offset: 0x1289A10 VA: 0x18128B410
	private static extern int _GetFavoriteGameCount(IntPtr self) { }

	// RVA: 0x128AFD0 Offset: 0x12895D0 VA: 0x18128AFD0
	internal int GetFavoriteGameCount() { }

	// RVA: 0x128B490 Offset: 0x1289A90 VA: 0x18128B490
	private static extern bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x128B050 Offset: 0x1289650 VA: 0x18128B050
	internal bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x128B340 Offset: 0x1289940 VA: 0x18128B340
	private static extern int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x128AF00 Offset: 0x1289500 VA: 0x18128AF00
	internal int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x128B640 Offset: 0x1289C40 VA: 0x18128B640
	private static extern bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x128B270 Offset: 0x1289870 VA: 0x18128B270
	internal bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x128B570 Offset: 0x1289B70 VA: 0x18128B570
	private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x128B130 Offset: 0x1289730 VA: 0x18128B130
	internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

