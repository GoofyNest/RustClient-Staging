internal class Utility // TypeDefIndex: 4719
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action EngineUpdate; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEBF7A0 Offset: 0xEBDDA0 VA: 0x180EBF7A0
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEBF690 Offset: 0xEBDC90 VA: 0x180EBF690
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEBF730 Offset: 0xEBDD30 VA: 0x180EBF730
	internal static void RaiseFlushPendingResources() { }

	// RVA: 0xEBF820 Offset: 0xEBDE20 VA: 0x180EBF820
	private static void .cctor() { }

}

public class Utility.GPUBuffer<T> // TypeDefIndex: 4720
{	// Fields
	private IntPtr buffer; // 0x0

}

public static class Utility // TypeDefIndex: 5272
{	// Fields
	private static readonly byte[] readBuffer; // 0x2B1047C

	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	internal static T ToType<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D47D0 Offset: 0x5D2DD0 VA: 0x1805D47D0
	|-Utility.ToType<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0x5D48E0 Offset: 0x5D2EE0 VA: 0x1805D48E0
	|-Utility.ToType<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0x5D49F0 Offset: 0x5D2FF0 VA: 0x1805D49F0
	|-Utility.ToType<ClientGameServerDeny_t>
	|
	|-RVA: 0x5D4B20 Offset: 0x5D3120 VA: 0x1805D4B20
	|-Utility.ToType<DownloadItemResult_t>
	|
	|-RVA: 0x5D4C70 Offset: 0x5D3270 VA: 0x1805D4C70
	|-Utility.ToType<DurationControl_t>
	|
	|-RVA: 0x5D4DB0 Offset: 0x5D33B0 VA: 0x1805D4DB0
	|-Utility.ToType<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0x5D4EE0 Offset: 0x5D34E0 VA: 0x1805D4EE0
	|-Utility.ToType<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0x5D5020 Offset: 0x5D3620 VA: 0x1805D5020
	|-Utility.ToType<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0x5D5150 Offset: 0x5D3750 VA: 0x1805D5150
	|-Utility.ToType<GameLobbyJoinRequested_t>
	|
	|-RVA: 0x5D5280 Offset: 0x5D3880 VA: 0x1805D5280
	|-Utility.ToType<GameOverlayActivated_t>
	|
	|-RVA: 0x5D5390 Offset: 0x5D3990 VA: 0x1805D5390
	|-Utility.ToType<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0x5D54C0 Offset: 0x5D3AC0 VA: 0x1805D54C0
	|-Utility.ToType<GameServerChangeRequested_t>
	|
	|-RVA: 0x5D55F0 Offset: 0x5D3BF0 VA: 0x1805D55F0
	|-Utility.ToType<GameWebCallback_t>
	|
	|-RVA: 0x5D5700 Offset: 0x5D3D00 VA: 0x1805D5700
	|-Utility.ToType<GamepadTextInputDismissed_t>
	|
	|-RVA: 0x5D5810 Offset: 0x5D3E10 VA: 0x1805D5810
	|-Utility.ToType<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0x5D5920 Offset: 0x5D3F20 VA: 0x1805D5920
	|-Utility.ToType<IPCountry_t>
	|
	|-RVA: 0x5D5A30 Offset: 0x5D4030 VA: 0x1805D5A30
	|-Utility.ToType<ItemInstalled_t>
	|
	|-RVA: 0x5D5B60 Offset: 0x5D4160 VA: 0x1805D5B60
	|-Utility.ToType<LicensesUpdated_t>
	|
	|-RVA: 0x5D5C70 Offset: 0x5D4270 VA: 0x1805D5C70
	|-Utility.ToType<LobbyChatMsg_t>
	|
	|-RVA: 0x5D5DC0 Offset: 0x5D43C0 VA: 0x1805D5DC0
	|-Utility.ToType<LobbyChatUpdate_t>
	|
	|-RVA: 0x5D5F00 Offset: 0x5D4500 VA: 0x1805D5F00
	|-Utility.ToType<LobbyCreated_t>
	|
	|-RVA: 0x5D6030 Offset: 0x5D4630 VA: 0x1805D6030
	|-Utility.ToType<LobbyDataUpdate_t>
	|
	|-RVA: 0x5D6180 Offset: 0x5D4780 VA: 0x1805D6180
	|-Utility.ToType<LobbyEnter_t>
	|
	|-RVA: 0x5D62D0 Offset: 0x5D48D0 VA: 0x1805D62D0
	|-Utility.ToType<LobbyGameCreated_t>
	|
	|-RVA: 0x5D6420 Offset: 0x5D4A20 VA: 0x1805D6420
	|-Utility.ToType<LobbyInvite_t>
	|
	|-RVA: 0x5D6570 Offset: 0x5D4B70 VA: 0x1805D6570
	|-Utility.ToType<LowBatteryPower_t>
	|
	|-RVA: 0x5D6680 Offset: 0x5D4C80 VA: 0x1805D6680
	|-Utility.ToType<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0x5D67D0 Offset: 0x5D4DD0 VA: 0x1805D67D0
	|-Utility.ToType<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0x5D68E0 Offset: 0x5D4EE0 VA: 0x1805D68E0
	|-Utility.ToType<P2PSessionConnectFail_t>
	|
	|-RVA: 0x5D6A10 Offset: 0x5D5010 VA: 0x1805D6A10
	|-Utility.ToType<P2PSessionRequest_t>
	|
	|-RVA: 0x5D6B20 Offset: 0x5D5120 VA: 0x1805D6B20
	|-Utility.ToType<PersonaStateChange_t>
	|
	|-RVA: 0x5D6C50 Offset: 0x5D5250 VA: 0x1805D6C50
	|-Utility.ToType<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0x5D6D60 Offset: 0x5D5360 VA: 0x1805D6D60
	|-Utility.ToType<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0x5D6E90 Offset: 0x5D5490 VA: 0x1805D6E90
	|-Utility.ToType<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0x5D70D0 Offset: 0x5D56D0 VA: 0x1805D70D0
	|-Utility.ToType<ScreenshotReady_t>
	|
	|-RVA: 0x5D71E0 Offset: 0x5D57E0 VA: 0x1805D71E0
	|-Utility.ToType<ScreenshotRequested_t>
	|
	|-RVA: 0x5D72F0 Offset: 0x5D58F0 VA: 0x1805D72F0
	|-Utility.ToType<SteamAPICallCompleted_t>
	|
	|-RVA: 0x5D7420 Offset: 0x5D5A20 VA: 0x1805D7420
	|-Utility.ToType<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0x5D7530 Offset: 0x5D5B30 VA: 0x1805D7530
	|-Utility.ToType<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0x5D7640 Offset: 0x5D5C40 VA: 0x1805D7640
	|-Utility.ToType<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0x5D7890 Offset: 0x5D5E90 VA: 0x1805D7890
	|-Utility.ToType<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0x5D7A60 Offset: 0x5D6060 VA: 0x1805D7A60
	|-Utility.ToType<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0x5D7B70 Offset: 0x5D6170 VA: 0x1805D7B70
	|-Utility.ToType<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0x5D7CC0 Offset: 0x5D62C0 VA: 0x1805D7CC0
	|-Utility.ToType<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0x5D7DD0 Offset: 0x5D63D0 VA: 0x1805D7DD0
	|-Utility.ToType<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0x5D7EE0 Offset: 0x5D64E0 VA: 0x1805D7EE0
	|-Utility.ToType<SteamServerConnectFailure_t>
	|
	|-RVA: 0x5D7FF0 Offset: 0x5D65F0 VA: 0x1805D7FF0
	|-Utility.ToType<SteamServersConnected_t>
	|
	|-RVA: 0x5D8100 Offset: 0x5D6700 VA: 0x1805D8100
	|-Utility.ToType<SteamServersDisconnected_t>
	|
	|-RVA: 0x5D8210 Offset: 0x5D6810 VA: 0x1805D8210
	|-Utility.ToType<SteamShutdown_t>
	|
	|-RVA: 0x5D8320 Offset: 0x5D6920 VA: 0x1805D8320
	|-Utility.ToType<UserAchievementIconFetched_t>
	|
	|-RVA: 0x5D8470 Offset: 0x5D6A70 VA: 0x1805D8470
	|-Utility.ToType<UserAchievementStored_t>
	|
	|-RVA: 0x5D85B0 Offset: 0x5D6BB0 VA: 0x1805D85B0
	|-Utility.ToType<UserStatsReceived_t>
	|
	|-RVA: 0x5D86F0 Offset: 0x5D6CF0 VA: 0x1805D86F0
	|-Utility.ToType<UserStatsStored_t>
	|
	|-RVA: 0x5D8820 Offset: 0x5D6E20 VA: 0x1805D8820
	|-Utility.ToType<UserStatsUnloaded_t>
	|
	|-RVA: 0x5D8930 Offset: 0x5D6F30 VA: 0x1805D8930
	|-Utility.ToType<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0x5D8A70 Offset: 0x5D7070 VA: 0x1805D8A70
	|-Utility.ToType<VolumeHasChanged_t>
	|
	|-RVA: 0x5D8B90 Offset: 0x5D7190 VA: 0x1805D8B90
	|-Utility.ToType<gameserveritem_t>
	|
	|-RVA: 0x5D6FC0 Offset: 0x5D55C0 VA: 0x1805D6FC0
	|-Utility.ToType<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CF7A0 Offset: 0x19CDDA0 VA: 0x1819CF7A0
	internal static object ToType(IntPtr ptr, Type t) { }

	// RVA: 0x19CF770 Offset: 0x19CDD70 VA: 0x1819CF770
	internal static uint Swap(uint x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CF490 Offset: 0x19CDA90 VA: 0x1819CF490
	public static uint IpToInt32(IPAddress ipAddress) { }

	// RVA: 0x19CF3F0 Offset: 0x19CD9F0 VA: 0x1819CF3F0
	public static IPAddress Int32ToIp(uint ipAddress) { }

	// RVA: 0x19CE8E0 Offset: 0x19CCEE0 VA: 0x1819CE8E0
	public static string FormatPrice(string currency, double price) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CF520 Offset: 0x19CDB20 VA: 0x1819CF520
	public static string ReadNullTerminatedUTF8String(BinaryReader br) { }

	// RVA: 0x19CF820 Offset: 0x19CDE20 VA: 0x1819CF820
	private static void .cctor() { }

}

