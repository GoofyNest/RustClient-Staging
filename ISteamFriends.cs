internal class ISteamFriends : SteamInterface // TypeDefIndex: 5116
{	// Methods

	// RVA: 0x1286190 Offset: 0x1284790 VA: 0x181286190
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1286A80 Offset: 0x1285080 VA: 0x181286A80
	internal static extern IntPtr SteamAPI_SteamFriends_v017() { }

	// RVA: 0x1286A80 Offset: 0x1285080 VA: 0x181286A80 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1287510 Offset: 0x1285B10 VA: 0x181287510
	private static extern Utf8StringPointer _GetPersonaName(IntPtr self) { }

	// RVA: 0x12869F0 Offset: 0x1284FF0 VA: 0x1812869F0
	internal string GetPersonaName() { }

	// RVA: 0x12870E0 Offset: 0x12856E0 VA: 0x1812870E0
	private static extern int _GetFriendCount(IntPtr self, int iFriendFlags) { }

	// RVA: 0x12865B0 Offset: 0x1284BB0 VA: 0x1812865B0
	internal int GetFriendCount(int iFriendFlags) { }

	// RVA: 0x1287040 Offset: 0x1285640 VA: 0x181287040
	private static extern SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags) { }

	// RVA: 0x1286510 Offset: 0x1284B10 VA: 0x181286510
	internal SteamId GetFriendByIndex(int iFriend, int iFriendFlags) { }

	// RVA: 0x12873F0 Offset: 0x12859F0 VA: 0x1812873F0
	private static extern Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x12868D0 Offset: 0x1284ED0 VA: 0x1812868D0
	internal Relationship GetFriendRelationship(SteamId steamIDFriend) { }

	// RVA: 0x1287360 Offset: 0x1285960 VA: 0x181287360
	private static extern FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286840 Offset: 0x1284E40 VA: 0x181286840
	internal FriendState GetFriendPersonaState(SteamId steamIDFriend) { }

	// RVA: 0x12872D0 Offset: 0x12858D0 VA: 0x1812872D0
	private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x12867A0 Offset: 0x1284DA0 VA: 0x1812867A0
	internal string GetFriendPersonaName(SteamId steamIDFriend) { }

	// RVA: 0x1287170 Offset: 0x1285770 VA: 0x181287170
	private static extern bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1286640 Offset: 0x1284C40 VA: 0x181286640
	internal bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1286D90 Offset: 0x1285390 VA: 0x181286D90
	private static extern void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID) { }

	// RVA: 0x1286260 Offset: 0x1284860 VA: 0x181286260
	internal void ActivateGameOverlayToUser(string pchDialog, SteamId steamID) { }

	// RVA: 0x1286E40 Offset: 0x1285440 VA: 0x181286E40
	private static extern void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1286310 Offset: 0x1284910 VA: 0x181286310
	internal void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1286CF0 Offset: 0x12852F0 VA: 0x181286CF0
	private static extern void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x12861C0 Offset: 0x12847C0 VA: 0x1812861C0
	internal void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1287630 Offset: 0x1285C30 VA: 0x181287630
	private static extern void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith) { }

	// RVA: 0x1286B90 Offset: 0x1285190 VA: 0x181286B90
	internal void SetPlayedWith(SteamId steamIDUserPlayedWith) { }

	// RVA: 0x1287480 Offset: 0x1285A80 VA: 0x181287480
	private static extern int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286960 Offset: 0x1284F60 VA: 0x181286960
	internal int GetMediumFriendAvatar(SteamId steamIDFriend) { }

	// RVA: 0x1287590 Offset: 0x1285B90 VA: 0x181287590
	private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1286AF0 Offset: 0x12850F0 VA: 0x181286AF0
	internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x12876C0 Offset: 0x1285CC0 VA: 0x1812876C0
	private static extern bool _SetRichPresence(IntPtr self, string pchKey, string pchValue) { }

	// RVA: 0x1286C20 Offset: 0x1285220 VA: 0x181286C20
	internal bool SetRichPresence(string pchKey, string pchValue) { }

	// RVA: 0x1286EF0 Offset: 0x12854F0 VA: 0x181286EF0
	private static extern void _ClearRichPresence(IntPtr self) { }

	// RVA: 0x12863C0 Offset: 0x12849C0 VA: 0x1812863C0
	internal void ClearRichPresence() { }

	// RVA: 0x1286F70 Offset: 0x1285570 VA: 0x181286F70
	private static extern int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1286440 Offset: 0x1284A40 VA: 0x181286440
	internal int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1287210 Offset: 0x1285810 VA: 0x181287210
	private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x12866E0 Offset: 0x1284CE0 VA: 0x1812866E0
	internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

