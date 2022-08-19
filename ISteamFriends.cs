internal class ISteamFriends : SteamInterface // TypeDefIndex: 5116
{	// Methods

	// RVA: 0x1285ED0 Offset: 0x12844D0 VA: 0x181285ED0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x12867C0 Offset: 0x1284DC0 VA: 0x1812867C0
	internal static extern IntPtr SteamAPI_SteamFriends_v017() { }

	// RVA: 0x12867C0 Offset: 0x1284DC0 VA: 0x1812867C0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1287250 Offset: 0x1285850 VA: 0x181287250
	private static extern Utf8StringPointer _GetPersonaName(IntPtr self) { }

	// RVA: 0x1286730 Offset: 0x1284D30 VA: 0x181286730
	internal string GetPersonaName() { }

	// RVA: 0x1286E20 Offset: 0x1285420 VA: 0x181286E20
	private static extern int _GetFriendCount(IntPtr self, int iFriendFlags) { }

	// RVA: 0x12862F0 Offset: 0x12848F0 VA: 0x1812862F0
	internal int GetFriendCount(int iFriendFlags) { }

	// RVA: 0x1286D80 Offset: 0x1285380 VA: 0x181286D80
	private static extern SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags) { }

	// RVA: 0x1286250 Offset: 0x1284850 VA: 0x181286250
	internal SteamId GetFriendByIndex(int iFriend, int iFriendFlags) { }

	// RVA: 0x1287130 Offset: 0x1285730 VA: 0x181287130
	private static extern Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286610 Offset: 0x1284C10 VA: 0x181286610
	internal Relationship GetFriendRelationship(SteamId steamIDFriend) { }

	// RVA: 0x12870A0 Offset: 0x12856A0 VA: 0x1812870A0
	private static extern FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286580 Offset: 0x1284B80 VA: 0x181286580
	internal FriendState GetFriendPersonaState(SteamId steamIDFriend) { }

	// RVA: 0x1287010 Offset: 0x1285610 VA: 0x181287010
	private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x12864E0 Offset: 0x1284AE0 VA: 0x1812864E0
	internal string GetFriendPersonaName(SteamId steamIDFriend) { }

	// RVA: 0x1286EB0 Offset: 0x12854B0 VA: 0x181286EB0
	private static extern bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1286380 Offset: 0x1284980 VA: 0x181286380
	internal bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1286AD0 Offset: 0x12850D0 VA: 0x181286AD0
	private static extern void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID) { }

	// RVA: 0x1285FA0 Offset: 0x12845A0 VA: 0x181285FA0
	internal void ActivateGameOverlayToUser(string pchDialog, SteamId steamID) { }

	// RVA: 0x1286B80 Offset: 0x1285180 VA: 0x181286B80
	private static extern void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1286050 Offset: 0x1284650 VA: 0x181286050
	internal void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1286A30 Offset: 0x1285030 VA: 0x181286A30
	private static extern void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1285F00 Offset: 0x1284500 VA: 0x181285F00
	internal void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1287370 Offset: 0x1285970 VA: 0x181287370
	private static extern void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith) { }

	// RVA: 0x12868D0 Offset: 0x1284ED0 VA: 0x1812868D0
	internal void SetPlayedWith(SteamId steamIDUserPlayedWith) { }

	// RVA: 0x12871C0 Offset: 0x12857C0 VA: 0x1812871C0
	private static extern int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x12866A0 Offset: 0x1284CA0 VA: 0x1812866A0
	internal int GetMediumFriendAvatar(SteamId steamIDFriend) { }

	// RVA: 0x12872D0 Offset: 0x12858D0 VA: 0x1812872D0
	private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1287400 Offset: 0x1285A00 VA: 0x181287400
	private static extern bool _SetRichPresence(IntPtr self, string pchKey, string pchValue) { }

	// RVA: 0x1286960 Offset: 0x1284F60 VA: 0x181286960
	internal bool SetRichPresence(string pchKey, string pchValue) { }

	// RVA: 0x1286C30 Offset: 0x1285230 VA: 0x181286C30
	private static extern void _ClearRichPresence(IntPtr self) { }

	// RVA: 0x1286100 Offset: 0x1284700 VA: 0x181286100
	internal void ClearRichPresence() { }

	// RVA: 0x1286CB0 Offset: 0x12852B0 VA: 0x181286CB0
	private static extern int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1286180 Offset: 0x1284780 VA: 0x181286180
	internal int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1286F50 Offset: 0x1285550 VA: 0x181286F50
	private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x1286420 Offset: 0x1284A20 VA: 0x181286420
	internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

