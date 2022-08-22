internal class ISteamFriends : SteamInterface // TypeDefIndex: 5116
{	// Methods

	// RVA: 0x1286830 Offset: 0x1284E30 VA: 0x181286830
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1287120 Offset: 0x1285720 VA: 0x181287120
	internal static extern IntPtr SteamAPI_SteamFriends_v017() { }

	// RVA: 0x1287120 Offset: 0x1285720 VA: 0x181287120 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1287BB0 Offset: 0x12861B0 VA: 0x181287BB0
	private static extern Utf8StringPointer _GetPersonaName(IntPtr self) { }

	// RVA: 0x1287090 Offset: 0x1285690 VA: 0x181287090
	internal string GetPersonaName() { }

	// RVA: 0x1287780 Offset: 0x1285D80 VA: 0x181287780
	private static extern int _GetFriendCount(IntPtr self, int iFriendFlags) { }

	// RVA: 0x1286C50 Offset: 0x1285250 VA: 0x181286C50
	internal int GetFriendCount(int iFriendFlags) { }

	// RVA: 0x12876E0 Offset: 0x1285CE0 VA: 0x1812876E0
	private static extern SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags) { }

	// RVA: 0x1286BB0 Offset: 0x12851B0 VA: 0x181286BB0
	internal SteamId GetFriendByIndex(int iFriend, int iFriendFlags) { }

	// RVA: 0x1287A90 Offset: 0x1286090 VA: 0x181287A90
	private static extern Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286F70 Offset: 0x1285570 VA: 0x181286F70
	internal Relationship GetFriendRelationship(SteamId steamIDFriend) { }

	// RVA: 0x1287A00 Offset: 0x1286000 VA: 0x181287A00
	private static extern FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286EE0 Offset: 0x12854E0 VA: 0x181286EE0
	internal FriendState GetFriendPersonaState(SteamId steamIDFriend) { }

	// RVA: 0x1287970 Offset: 0x1285F70 VA: 0x181287970
	private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1286E40 Offset: 0x1285440 VA: 0x181286E40
	internal string GetFriendPersonaName(SteamId steamIDFriend) { }

	// RVA: 0x1287810 Offset: 0x1285E10 VA: 0x181287810
	private static extern bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1286CE0 Offset: 0x12852E0 VA: 0x181286CE0
	internal bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1287430 Offset: 0x1285A30 VA: 0x181287430
	private static extern void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID) { }

	// RVA: 0x1286900 Offset: 0x1284F00 VA: 0x181286900
	internal void ActivateGameOverlayToUser(string pchDialog, SteamId steamID) { }

	// RVA: 0x12874E0 Offset: 0x1285AE0 VA: 0x1812874E0
	private static extern void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x12869B0 Offset: 0x1284FB0 VA: 0x1812869B0
	internal void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1287390 Offset: 0x1285990 VA: 0x181287390
	private static extern void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1286860 Offset: 0x1284E60 VA: 0x181286860
	internal void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1287CD0 Offset: 0x12862D0 VA: 0x181287CD0
	private static extern void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith) { }

	// RVA: 0x1287230 Offset: 0x1285830 VA: 0x181287230
	internal void SetPlayedWith(SteamId steamIDUserPlayedWith) { }

	// RVA: 0x1287B20 Offset: 0x1286120 VA: 0x181287B20
	private static extern int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1287000 Offset: 0x1285600 VA: 0x181287000
	internal int GetMediumFriendAvatar(SteamId steamIDFriend) { }

	// RVA: 0x1287C30 Offset: 0x1286230 VA: 0x181287C30
	private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1287190 Offset: 0x1285790 VA: 0x181287190
	internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1287D60 Offset: 0x1286360 VA: 0x181287D60
	private static extern bool _SetRichPresence(IntPtr self, string pchKey, string pchValue) { }

	// RVA: 0x12872C0 Offset: 0x12858C0 VA: 0x1812872C0
	internal bool SetRichPresence(string pchKey, string pchValue) { }

	// RVA: 0x1287590 Offset: 0x1285B90 VA: 0x181287590
	private static extern void _ClearRichPresence(IntPtr self) { }

	// RVA: 0x1286A60 Offset: 0x1285060 VA: 0x181286A60
	internal void ClearRichPresence() { }

	// RVA: 0x1287610 Offset: 0x1285C10 VA: 0x181287610
	private static extern int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1286AE0 Offset: 0x12850E0 VA: 0x181286AE0
	internal int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x12878B0 Offset: 0x1285EB0 VA: 0x1812878B0
	private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x1286D80 Offset: 0x1285380 VA: 0x181286D80
	internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

