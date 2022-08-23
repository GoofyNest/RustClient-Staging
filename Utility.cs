internal class Utility // TypeDefIndex: 4719
{	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action EngineUpdate; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static void RaiseFlushPendingResources() { }

	private static void .cctor() { }

}

public class Utility.GPUBuffer<T> // TypeDefIndex: 4720
{	private IntPtr buffer; // 0x0

}

public static class Utility // TypeDefIndex: 5272
{	private static readonly byte[] readBuffer; // 0x2B1047C


	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static T ToType<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D48A0 Offset: 0x5D2EA0 VA: 0x1805D48A0
	|-Utility.ToType<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0x5D49B0 Offset: 0x5D2FB0 VA: 0x1805D49B0
	|-Utility.ToType<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0x5D4AC0 Offset: 0x5D30C0 VA: 0x1805D4AC0
	|-Utility.ToType<ClientGameServerDeny_t>
	|
	|-RVA: 0x5D4BF0 Offset: 0x5D31F0 VA: 0x1805D4BF0
	|-Utility.ToType<DownloadItemResult_t>
	|
	|-RVA: 0x5D4D40 Offset: 0x5D3340 VA: 0x1805D4D40
	|-Utility.ToType<DurationControl_t>
	|
	|-RVA: 0x5D4E80 Offset: 0x5D3480 VA: 0x1805D4E80
	|-Utility.ToType<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0x5D4FB0 Offset: 0x5D35B0 VA: 0x1805D4FB0
	|-Utility.ToType<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0x5D50F0 Offset: 0x5D36F0 VA: 0x1805D50F0
	|-Utility.ToType<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0x5D5220 Offset: 0x5D3820 VA: 0x1805D5220
	|-Utility.ToType<GameLobbyJoinRequested_t>
	|
	|-RVA: 0x5D5350 Offset: 0x5D3950 VA: 0x1805D5350
	|-Utility.ToType<GameOverlayActivated_t>
	|
	|-RVA: 0x5D5460 Offset: 0x5D3A60 VA: 0x1805D5460
	|-Utility.ToType<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0x5D5590 Offset: 0x5D3B90 VA: 0x1805D5590
	|-Utility.ToType<GameServerChangeRequested_t>
	|
	|-RVA: 0x5D56C0 Offset: 0x5D3CC0 VA: 0x1805D56C0
	|-Utility.ToType<GameWebCallback_t>
	|
	|-RVA: 0x5D57D0 Offset: 0x5D3DD0 VA: 0x1805D57D0
	|-Utility.ToType<GamepadTextInputDismissed_t>
	|
	|-RVA: 0x5D58E0 Offset: 0x5D3EE0 VA: 0x1805D58E0
	|-Utility.ToType<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0x5D59F0 Offset: 0x5D3FF0 VA: 0x1805D59F0
	|-Utility.ToType<IPCountry_t>
	|
	|-RVA: 0x5D5B00 Offset: 0x5D4100 VA: 0x1805D5B00
	|-Utility.ToType<ItemInstalled_t>
	|
	|-RVA: 0x5D5C30 Offset: 0x5D4230 VA: 0x1805D5C30
	|-Utility.ToType<LicensesUpdated_t>
	|
	|-RVA: 0x5D5D40 Offset: 0x5D4340 VA: 0x1805D5D40
	|-Utility.ToType<LobbyChatMsg_t>
	|
	|-RVA: 0x5D5E90 Offset: 0x5D4490 VA: 0x1805D5E90
	|-Utility.ToType<LobbyChatUpdate_t>
	|
	|-RVA: 0x5D5FD0 Offset: 0x5D45D0 VA: 0x1805D5FD0
	|-Utility.ToType<LobbyCreated_t>
	|
	|-RVA: 0x5D6100 Offset: 0x5D4700 VA: 0x1805D6100
	|-Utility.ToType<LobbyDataUpdate_t>
	|
	|-RVA: 0x5D6250 Offset: 0x5D4850 VA: 0x1805D6250
	|-Utility.ToType<LobbyEnter_t>
	|
	|-RVA: 0x5D63A0 Offset: 0x5D49A0 VA: 0x1805D63A0
	|-Utility.ToType<LobbyGameCreated_t>
	|
	|-RVA: 0x5D64F0 Offset: 0x5D4AF0 VA: 0x1805D64F0
	|-Utility.ToType<LobbyInvite_t>
	|
	|-RVA: 0x5D6640 Offset: 0x5D4C40 VA: 0x1805D6640
	|-Utility.ToType<LowBatteryPower_t>
	|
	|-RVA: 0x5D6750 Offset: 0x5D4D50 VA: 0x1805D6750
	|-Utility.ToType<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0x5D68A0 Offset: 0x5D4EA0 VA: 0x1805D68A0
	|-Utility.ToType<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0x5D69B0 Offset: 0x5D4FB0 VA: 0x1805D69B0
	|-Utility.ToType<P2PSessionConnectFail_t>
	|
	|-RVA: 0x5D6AE0 Offset: 0x5D50E0 VA: 0x1805D6AE0
	|-Utility.ToType<P2PSessionRequest_t>
	|
	|-RVA: 0x5D6BF0 Offset: 0x5D51F0 VA: 0x1805D6BF0
	|-Utility.ToType<PersonaStateChange_t>
	|
	|-RVA: 0x5D6D20 Offset: 0x5D5320 VA: 0x1805D6D20
	|-Utility.ToType<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0x5D6E30 Offset: 0x5D5430 VA: 0x1805D6E30
	|-Utility.ToType<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0x5D6F60 Offset: 0x5D5560 VA: 0x1805D6F60
	|-Utility.ToType<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0x5D71A0 Offset: 0x5D57A0 VA: 0x1805D71A0
	|-Utility.ToType<ScreenshotReady_t>
	|
	|-RVA: 0x5D72B0 Offset: 0x5D58B0 VA: 0x1805D72B0
	|-Utility.ToType<ScreenshotRequested_t>
	|
	|-RVA: 0x5D73C0 Offset: 0x5D59C0 VA: 0x1805D73C0
	|-Utility.ToType<SteamAPICallCompleted_t>
	|
	|-RVA: 0x5D74F0 Offset: 0x5D5AF0 VA: 0x1805D74F0
	|-Utility.ToType<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0x5D7600 Offset: 0x5D5C00 VA: 0x1805D7600
	|-Utility.ToType<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0x5D7710 Offset: 0x5D5D10 VA: 0x1805D7710
	|-Utility.ToType<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0x5D7960 Offset: 0x5D5F60 VA: 0x1805D7960
	|-Utility.ToType<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0x5D7B30 Offset: 0x5D6130 VA: 0x1805D7B30
	|-Utility.ToType<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0x5D7C40 Offset: 0x5D6240 VA: 0x1805D7C40
	|-Utility.ToType<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0x5D7D90 Offset: 0x5D6390 VA: 0x1805D7D90
	|-Utility.ToType<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0x5D7EA0 Offset: 0x5D64A0 VA: 0x1805D7EA0
	|-Utility.ToType<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0x5D7FB0 Offset: 0x5D65B0 VA: 0x1805D7FB0
	|-Utility.ToType<SteamServerConnectFailure_t>
	|
	|-RVA: 0x5D80C0 Offset: 0x5D66C0 VA: 0x1805D80C0
	|-Utility.ToType<SteamServersConnected_t>
	|
	|-RVA: 0x5D81D0 Offset: 0x5D67D0 VA: 0x1805D81D0
	|-Utility.ToType<SteamServersDisconnected_t>
	|
	|-RVA: 0x5D82E0 Offset: 0x5D68E0 VA: 0x1805D82E0
	|-Utility.ToType<SteamShutdown_t>
	|
	|-RVA: 0x5D83F0 Offset: 0x5D69F0 VA: 0x1805D83F0
	|-Utility.ToType<UserAchievementIconFetched_t>
	|
	|-RVA: 0x5D8540 Offset: 0x5D6B40 VA: 0x1805D8540
	|-Utility.ToType<UserAchievementStored_t>
	|
	|-RVA: 0x5D8680 Offset: 0x5D6C80 VA: 0x1805D8680
	|-Utility.ToType<UserStatsReceived_t>
	|
	|-RVA: 0x5D87C0 Offset: 0x5D6DC0 VA: 0x1805D87C0
	|-Utility.ToType<UserStatsStored_t>
	|
	|-RVA: 0x5D88F0 Offset: 0x5D6EF0 VA: 0x1805D88F0
	|-Utility.ToType<UserStatsUnloaded_t>
	|
	|-RVA: 0x5D8A00 Offset: 0x5D7000 VA: 0x1805D8A00
	|-Utility.ToType<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0x5D8B40 Offset: 0x5D7140 VA: 0x1805D8B40
	|-Utility.ToType<VolumeHasChanged_t>
	|
	|-RVA: 0x5D8C60 Offset: 0x5D7260 VA: 0x1805D8C60
	|-Utility.ToType<gameserveritem_t>
	|
	|-RVA: 0x5D7090 Offset: 0x5D5690 VA: 0x1805D7090
	|-Utility.ToType<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal static object ToType(IntPtr ptr, Type t) { }

	internal static uint Swap(uint x) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static uint IpToInt32(IPAddress ipAddress) { }

	public static IPAddress Int32ToIp(uint ipAddress) { }

	public static string FormatPrice(string currency, double price) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static string ReadNullTerminatedUTF8String(BinaryReader br) { }

	private static void .cctor() { }

}

