internal class ISteamMatchmaking : SteamInterface // TypeDefIndex: 5119
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x128AF40 Offset: 0x1289540 VA: 0x18128AF40
	internal static extern IntPtr SteamAPI_SteamMatchmaking_v009() { }

	// RVA: 0x128AF40 Offset: 0x1289540 VA: 0x18128AF40 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x128B150 Offset: 0x1289750 VA: 0x18128B150
	private static extern int _GetFavoriteGameCount(IntPtr self) { }

	// RVA: 0x128AD10 Offset: 0x1289310 VA: 0x18128AD10
	internal int GetFavoriteGameCount() { }

	// RVA: 0x128B1D0 Offset: 0x12897D0 VA: 0x18128B1D0
	private static extern bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x128AD90 Offset: 0x1289390 VA: 0x18128AD90
	internal bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x128B080 Offset: 0x1289680 VA: 0x18128B080
	private static extern int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x128AC40 Offset: 0x1289240 VA: 0x18128AC40
	internal int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x128B380 Offset: 0x1289980 VA: 0x18128B380
	private static extern bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x128AFB0 Offset: 0x12895B0 VA: 0x18128AFB0
	internal bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x128B2B0 Offset: 0x12898B0 VA: 0x18128B2B0
	private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x128AE70 Offset: 0x1289470 VA: 0x18128AE70
	internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

