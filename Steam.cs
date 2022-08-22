internal static class SteamAPI // TypeDefIndex: 5111
{	// Methods

	// RVA: 0xDE3460 Offset: 0xDE1A60 VA: 0x180DE3460
	internal static bool Init() { }

	// RVA: 0xDE34D0 Offset: 0xDE1AD0 VA: 0x180DE34D0
	internal static void Shutdown() { }

	// RVA: 0xDE33F0 Offset: 0xDE19F0 VA: 0x180DE33F0
	internal static HSteamPipe GetHSteamPipe() { }

}

internal static class SteamAPI.Native // TypeDefIndex: 5112
{	// Methods

	// RVA: 0xDE3460 Offset: 0xDE1A60 VA: 0x180DE3460
	public static extern bool SteamAPI_Init() { }

	// RVA: 0xDE34D0 Offset: 0xDE1AD0 VA: 0x180DE34D0
	public static extern void SteamAPI_Shutdown() { }

	// RVA: 0xDE33F0 Offset: 0xDE19F0 VA: 0x180DE33F0
	public static extern HSteamPipe SteamAPI_GetHSteamPipe() { }

}

internal enum SteamItemFlags // TypeDefIndex: 5167
{	// Fields
	public int value__; // 0x0
	public const SteamItemFlags NoTrade = 1;
	public const SteamItemFlags Removed = 256;
	public const SteamItemFlags Consumed = 512;

}

public enum SteamNetworkingAvailability // TypeDefIndex: 5168
{	// Fields
	public int value__; // 0x0
	public const SteamNetworkingAvailability CannotTry = -102;
	public const SteamNetworkingAvailability Failed = -101;
	public const SteamNetworkingAvailability Previously = -100;
	public const SteamNetworkingAvailability Retrying = -10;
	public const SteamNetworkingAvailability NeverTried = 1;
	public const SteamNetworkingAvailability Waiting = 2;
	public const SteamNetworkingAvailability Attempting = 3;
	public const SteamNetworkingAvailability Current = 100;
	public const SteamNetworkingAvailability Unknown = 0;
	public const SteamNetworkingAvailability Force32bit = 2147483647;

}

public class SteamApps : SteamSharedClass<SteamApps> // TypeDefIndex: 5183
{	// Properties
	internal static ISteamApps Internal { get; }
	public static string GameLanguage { get; }
	public static string CurrentBetaName { get; }
	public static int BuildId { get; }

	// Methods

	// RVA: 0xDE5370 Offset: 0xDE3970 VA: 0x180DE5370
	internal static ISteamApps get_Internal() { }

	// RVA: 0xDE5170 Offset: 0xDE3770 VA: 0x180DE5170 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE5340 Offset: 0xDE3940 VA: 0x180DE5340
	public static string get_GameLanguage() { }

	// RVA: 0xDE5240 Offset: 0xDE3840 VA: 0x180DE5240
	public static bool IsSubscribedToApp(AppId appid) { }

	// RVA: 0xDE51F0 Offset: 0xDE37F0 VA: 0x180DE51F0
	public static bool IsDlcInstalled(AppId appid) { }

	// RVA: 0xDE5300 Offset: 0xDE3900 VA: 0x180DE5300
	public static string get_CurrentBetaName() { }

	// RVA: 0xDE52D0 Offset: 0xDE38D0 VA: 0x180DE52D0
	public static int get_BuildId() { }

	// RVA: 0xDE5290 Offset: 0xDE3890 VA: 0x180DE5290
	public void .ctor() { }

}

public static class SteamClient // TypeDefIndex: 5184
{	// Fields
	private static bool initialized; // 0x0
	private static readonly List<SteamClass> openInterfaces; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static AppId <AppId>k__BackingField; // 0x10

	// Properties
	public static bool IsValid { get; }
	public static bool IsLoggedOn { get; }
	public static SteamId SteamId { get; }
	public static string Name { get; }
	public static AppId AppId { get; set; }

	// Methods

	// RVA: 0xDE5480 Offset: 0xDE3A80 VA: 0x180DE5480
	public static void Init(uint appid, bool asyncCallbacks = True) { }

	// RVA: -1 Offset: -1
	internal static void AddInterface<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFD20 Offset: 0xCFE320 VA: 0x180CFFD20
	|-SteamClient.AddInterface<SteamApps>
	|-SteamClient.AddInterface<SteamFriends>
	|-SteamClient.AddInterface<SteamInput>
	|-SteamClient.AddInterface<SteamInventory>
	|-SteamClient.AddInterface<SteamMatchmaking>
	|-SteamClient.AddInterface<SteamMatchmakingServers>
	|-SteamClient.AddInterface<SteamMusic>
	|-SteamClient.AddInterface<SteamNetworking>
	|-SteamClient.AddInterface<SteamNetworkingSockets>
	|-SteamClient.AddInterface<SteamNetworkingUtils>
	|-SteamClient.AddInterface<SteamParental>
	|-SteamClient.AddInterface<SteamParties>
	|-SteamClient.AddInterface<SteamRemotePlay>
	|-SteamClient.AddInterface<SteamRemoteStorage>
	|-SteamClient.AddInterface<SteamScreenshots>
	|-SteamClient.AddInterface<SteamUGC>
	|-SteamClient.AddInterface<SteamUser>
	|-SteamClient.AddInterface<SteamUserStats>
	|-SteamClient.AddInterface<SteamUtils>
	|-SteamClient.AddInterface<SteamVideo>
	|-SteamClient.AddInterface<object>
	*/

	// RVA: 0xDE59C0 Offset: 0xDE3FC0 VA: 0x180DE59C0
	internal static void ShutdownInterfaces() { }

	// RVA: 0xDE5EF0 Offset: 0xDE44F0 VA: 0x180DE5EF0
	public static bool get_IsValid() { }

	// RVA: 0xDE5B50 Offset: 0xDE4150 VA: 0x180DE5B50
	public static void Shutdown() { }

	// RVA: 0xDE53F0 Offset: 0xDE39F0 VA: 0x180DE53F0
	internal static void Cleanup() { }

	// RVA: 0xDE5880 Offset: 0xDE3E80 VA: 0x180DE5880
	public static void RunCallbacks() { }

	// RVA: 0xDE5E10 Offset: 0xDE4410 VA: 0x180DE5E10
	public static bool get_IsLoggedOn() { }

	// RVA: 0xDE5F80 Offset: 0xDE4580 VA: 0x180DE5F80
	public static SteamId get_SteamId() { }

	// RVA: 0xDE5F50 Offset: 0xDE4550 VA: 0x180DE5F50
	public static string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE5D50 Offset: 0xDE4350 VA: 0x180DE5D50
	public static AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE6050 Offset: 0xDE4650 VA: 0x180DE6050
	internal static void set_AppId(AppId value) { }

	// RVA: 0xDE5CE0 Offset: 0xDE42E0 VA: 0x180DE5CE0
	private static void .cctor() { }

}

public class SteamFriends : SteamClientClass<SteamFriends> // TypeDefIndex: 5185
{	// Fields
	private static Dictionary<string, string> richPresence; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Friend, string, string> OnChatMessage; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Friend, string, string> OnClanChatMessage; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Friend> OnPersonaStateChange; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Friend, string> OnGameRichPresenceJoinRequested; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<bool> OnGameOverlayActivated; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string, string> OnGameServerChangeRequested; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, SteamId> OnGameLobbyJoinRequested; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Friend> OnFriendRichPresenceUpdate; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string> OnOverlayBrowserProtocol; // 0x48

	// Properties
	internal static ISteamFriends Internal { get; }

	// Methods

	// RVA: 0xDE72F0 Offset: 0xDE58F0 VA: 0x180DE72F0
	internal static ISteamFriends get_Internal() { }

	// RVA: 0xDE6400 Offset: 0xDE4A00 VA: 0x180DE6400 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE64C0 Offset: 0xDE4AC0 VA: 0x180DE64C0
	internal void InstallEvents() { }

	// RVA: 0xDE6B10 Offset: 0xDE5110 VA: 0x180DE6B10
	private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data) { }

	// RVA: 0xDE6DC0 Offset: 0xDE53C0 VA: 0x180DE6DC0
	private static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data) { }

	[IteratorStateMachineAttribute] // RVA: 0x8E180 Offset: 0x8D580 VA: 0x18008E180
	// RVA: 0xDE61F0 Offset: 0xDE47F0 VA: 0x180DE61F0
	private static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag) { }

	// RVA: 0xDE6260 Offset: 0xDE4860 VA: 0x180DE6260
	public static IEnumerable<Friend> GetFriends() { }

	// RVA: 0xDE7110 Offset: 0xDE5710 VA: 0x180DE7110
	public static void OpenUserOverlay(SteamId id, string type) { }

	// RVA: 0xDE70C0 Offset: 0xDE56C0 VA: 0x180DE70C0
	public static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = 0) { }

	// RVA: 0xDE7150 Offset: 0xDE5750 VA: 0x180DE7150
	public static void OpenWebOverlay(string url, bool modal = False) { }

	// RVA: 0xDE71D0 Offset: 0xDE57D0 VA: 0x180DE71D0
	public static void SetPlayedWith(SteamId steamid) { }

	// RVA: 0xDE7190 Offset: 0xDE5790 VA: 0x180DE7190
	public static bool RequestUserInformation(SteamId steamid, bool nameonly = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E200 Offset: 0x8D600 VA: 0x18008E200
	// RVA: 0xDE60B0 Offset: 0xDE46B0 VA: 0x180DE60B0
	internal static Task CacheUserInformationAsync(SteamId steamid, bool nameonly) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E4C0 Offset: 0x8D8C0 VA: 0x18008E4C0
	// RVA: 0xDE62C0 Offset: 0xDE48C0 VA: 0x180DE62C0
	public static Task<Nullable<Image>> GetMediumAvatarAsync(SteamId steamid) { }

	// RVA: 0xDE6380 Offset: 0xDE4980 VA: 0x180DE6380
	public static string GetRichPresence(string key) { }

	// RVA: 0xDE7200 Offset: 0xDE5800 VA: 0x180DE7200
	public static bool SetRichPresence(string key, string value) { }

	// RVA: 0xDE6180 Offset: 0xDE4780 VA: 0x180DE6180
	public static void ClearRichPresence() { }

	// RVA: 0xDE72B0 Offset: 0xDE58B0 VA: 0x180DE72B0
	public void .ctor() { }

}

private sealed class SteamFriends.<>c // TypeDefIndex: 5186
{	// Fields
	public static readonly SteamFriends.<>c <>9; // 0x0
	public static Action<PersonaStateChange_t> <>9__4_0; // 0x8
	public static Action<GameRichPresenceJoinRequested_t> <>9__4_1; // 0x10
	public static Action<GameOverlayActivated_t> <>9__4_2; // 0x18
	public static Action<GameServerChangeRequested_t> <>9__4_3; // 0x20
	public static Action<GameLobbyJoinRequested_t> <>9__4_4; // 0x28
	public static Action<FriendRichPresenceUpdate_t> <>9__4_5; // 0x30
	public static Action<OverlayBrowserProtocolNavigation_t> <>9__4_6; // 0x38

	// Methods

	// RVA: 0xDF1050 Offset: 0xDEF650 VA: 0x180DF1050
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF04E0 Offset: 0xDEEAE0 VA: 0x180DF04E0
	internal void <InstallEvents>b__4_0(PersonaStateChange_t x) { }

	// RVA: 0xDF0540 Offset: 0xDEEB40 VA: 0x180DF0540
	internal void <InstallEvents>b__4_1(GameRichPresenceJoinRequested_t x) { }

	// RVA: 0xDF05C0 Offset: 0xDEEBC0 VA: 0x180DF05C0
	internal void <InstallEvents>b__4_2(GameOverlayActivated_t x) { }

	// RVA: 0xDF0620 Offset: 0xDEEC20 VA: 0x180DF0620
	internal void <InstallEvents>b__4_3(GameServerChangeRequested_t x) { }

	// RVA: 0xDF06A0 Offset: 0xDEECA0 VA: 0x180DF06A0
	internal void <InstallEvents>b__4_4(GameLobbyJoinRequested_t x) { }

	// RVA: 0xDF0730 Offset: 0xDEED30 VA: 0x180DF0730
	internal void <InstallEvents>b__4_5(FriendRichPresenceUpdate_t x) { }

	// RVA: 0xDF0790 Offset: 0xDEED90 VA: 0x180DF0790
	internal void <InstallEvents>b__4_6(OverlayBrowserProtocolNavigation_t x) { }

}

private sealed class SteamFriends.<GetFriendsWithFlag>d__34 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IEnumerator, IDisposable // TypeDefIndex: 5187
{	// Fields
	private int <>1__state; // 0x10
	private Friend <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private FriendFlags flag; // 0x24
	public FriendFlags <>3__flag; // 0x28
	private int <i>5__2; // 0x2C

	// Properties
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDECFA0 Offset: 0xDEB5A0 VA: 0x180DECFA0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDED0E0 Offset: 0xDEB6E0 VA: 0x180DED0E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDED130 Offset: 0xDEB730 VA: 0x180DED130 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDED040 Offset: 0xDEB640 VA: 0x180DED040 Slot: 4
	private IEnumerator<Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDED040 Offset: 0xDEB640 VA: 0x180DED040 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private struct SteamFriends.<CacheUserInformationAsync>d__51 : IAsyncStateMachine // TypeDefIndex: 5188
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamId steamid; // 0x20
	public bool nameonly; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x123050 Offset: 0x122450 VA: 0x180123050 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamFriends.<GetMediumAvatarAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 5189
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Image>> <>t__builder; // 0x8
	public SteamId steamid; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x123300 Offset: 0x122700 VA: 0x180123300 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123310 Offset: 0x122710 VA: 0x180123310 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInput : SteamClientClass<SteamInput> // TypeDefIndex: 5190
{	// Fields
	private static readonly InputHandle_t[] queryArray; // 0x0
	internal static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles; // 0x8
	internal static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles; // 0x10
	internal static Dictionary<string, InputActionSetHandle_t> ActionSets; // 0x18

	// Methods

	// RVA: 0xDE73A0 Offset: 0xDE59A0 VA: 0x180DE73A0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE7530 Offset: 0xDE5B30 VA: 0x180DE7530
	public void .ctor() { }

	// RVA: 0xDE7420 Offset: 0xDE5A20 VA: 0x180DE7420
	private static void .cctor() { }

}

public class SteamInventory : SteamSharedClass<SteamInventory> // TypeDefIndex: 5191
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<InventoryResult> OnInventoryUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnDefinitionsUpdated; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static string <Currency>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static InventoryItem[] <Items>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static InventoryDef[] <Definitions>k__BackingField; // 0x20
	private static Dictionary<int, InventoryDef> _defMap; // 0x28

	// Properties
	internal static ISteamInventory Internal { get; }
	public static string Currency { get; set; }
	public static InventoryItem[] Items { get; set; }
	public static InventoryDef[] Definitions { get; set; }

	// Methods

	// RVA: 0xDE8800 Offset: 0xDE6E00 VA: 0x180DE8800
	internal static ISteamInventory get_Internal() { }

	// RVA: 0xDE7DB0 Offset: 0xDE63B0 VA: 0x180DE7DB0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE7E40 Offset: 0xDE6440 VA: 0x180DE7E40
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDE8030 Offset: 0xDE6630 VA: 0x180DE8030
	private static void InventoryUpdated(SteamInventoryFullUpdate_t x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE86D0 Offset: 0xDE6CD0 VA: 0x180DE86D0
	public static void add_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8970 Offset: 0xDE6F70 VA: 0x180DE8970
	public static void remove_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8620 Offset: 0xDE6C20 VA: 0x180DE8620
	public static void add_OnDefinitionsUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE88C0 Offset: 0xDE6EC0 VA: 0x180DE88C0
	public static void remove_OnDefinitionsUpdated(Action value) { }

	// RVA: 0xDE80F0 Offset: 0xDE66F0 VA: 0x180DE80F0
	private static void LoadDefinitions() { }

	// RVA: 0xDE83E0 Offset: 0xDE69E0 VA: 0x180DE83E0
	public static void LoadItemDefinitions() { }

	// RVA: 0xDE7900 Offset: 0xDE5F00 VA: 0x180DE7900
	public static InventoryDef FindDefinition(InventoryDefId defId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8780 Offset: 0xDE6D80 VA: 0x180DE8780
	public static string get_Currency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8A20 Offset: 0xDE7020 VA: 0x180DE8A20
	internal static void set_Currency(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0x8FA60 Offset: 0x8EE60 VA: 0x18008FA60
	// RVA: 0xDE7AB0 Offset: 0xDE60B0 VA: 0x180DE7AB0
	public static Task<InventoryDef[]> GetDefinitionsWithPricesAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8880 Offset: 0xDE6E80 VA: 0x180DE8880
	public static InventoryItem[] get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8AC0 Offset: 0xDE70C0 VA: 0x180DE8AC0
	internal static void set_Items(InventoryItem[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE87C0 Offset: 0xDE6DC0 VA: 0x180DE87C0
	public static InventoryDef[] get_Definitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8A70 Offset: 0xDE7070 VA: 0x180DE8A70
	internal static void set_Definitions(InventoryDef[] value) { }

	// RVA: 0xDE7B70 Offset: 0xDE6170 VA: 0x180DE7B70
	internal static InventoryDef[] GetDefinitions() { }

	// RVA: 0xDE7A30 Offset: 0xDE6030 VA: 0x180DE7A30
	public static bool GetAllItems() { }

	[AsyncStateMachineAttribute] // RVA: 0x900D0 Offset: 0x8F4D0 VA: 0x1800900D0
	// RVA: 0xDE7980 Offset: 0xDE5F80 VA: 0x180DE7980
	public static Task<Nullable<InventoryResult>> GetAllItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90150 Offset: 0x8F550 VA: 0x180090150
	// RVA: 0xDE7700 Offset: 0xDE5D00 VA: 0x180DE7700
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x90280 Offset: 0x8F680 VA: 0x180090280
	// RVA: 0xDE7800 Offset: 0xDE5E00 VA: 0x180DE7800
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem.Amount[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x903A0 Offset: 0x8F7A0 VA: 0x1800903A0
	// RVA: 0xDE7D00 Offset: 0xDE6300 VA: 0x180DE7D00
	public static Task<Nullable<InventoryResult>> GrantPromoItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0xDE8520 Offset: 0xDE6B20 VA: 0x180DE8520
	public static Task<Nullable<InventoryResult>> TriggerItemDropAsync(InventoryDefId id) { }

	[AsyncStateMachineAttribute] // RVA: 0x90770 Offset: 0x8FB70 VA: 0x180090770
	// RVA: 0xDE8440 Offset: 0xDE6A40 VA: 0x180DE8440
	public static Task<Nullable<InventoryPurchaseResult>> StartPurchaseAsync(InventoryDef[] items) { }

	// RVA: 0xDE85E0 Offset: 0xDE6BE0 VA: 0x180DE85E0
	public void .ctor() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5192
{	// Fields
	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Action<SteamInventoryFullUpdate_t> <>9__3_0; // 0x8
	public static Action<SteamInventoryDefinitionUpdate_t> <>9__3_1; // 0x10
	public static Func<InventoryDefId, InventoryDef> <>9__19_0; // 0x18
	public static Func<InventoryDefId, InventoryDef> <>9__29_0; // 0x20
	public static Func<InventoryItem, InventoryItemId> <>9__33_0; // 0x28
	public static Func<InventoryItem, uint> <>9__33_1; // 0x30
	public static Func<InventoryItem.Amount, InventoryItemId> <>9__34_0; // 0x38
	public static Func<InventoryItem.Amount, uint> <>9__34_1; // 0x40
	public static Func<InventoryDef, InventoryDefId> <>9__39_0; // 0x48
	public static Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId> <>9__39_1; // 0x50
	public static Func<IGrouping<InventoryDefId, InventoryDef>, uint> <>9__39_2; // 0x58

	// Methods

	// RVA: 0xDF11D0 Offset: 0xDEF7D0 VA: 0x180DF11D0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0290 Offset: 0xDEE890 VA: 0x180DF0290
	internal void <InstallEvents>b__3_0(SteamInventoryFullUpdate_t x) { }

	// RVA: 0xDF0400 Offset: 0xDEEA00 VA: 0x180DF0400
	internal void <InstallEvents>b__3_1(SteamInventoryDefinitionUpdate_t x) { }

	// RVA: 0xDF00B0 Offset: 0xDEE6B0 VA: 0x180DF00B0
	internal InventoryDef <GetDefinitionsWithPricesAsync>b__19_0(InventoryDefId x) { }

	// RVA: 0xDF0050 Offset: 0xDEE650 VA: 0x180DF0050
	internal InventoryDef <GetDefinitions>b__29_0(InventoryDefId x) { }

	// RVA: 0x820EF0 Offset: 0x81F4F0 VA: 0x180820EF0
	internal InventoryItemId <CraftItemAsync>b__33_0(InventoryItem x) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870
	internal uint <CraftItemAsync>b__33_1(InventoryItem x) { }

	// RVA: 0x820EF0 Offset: 0x81F4F0 VA: 0x180820EF0
	internal InventoryItemId <CraftItemAsync>b__34_0(InventoryItem.Amount x) { }

	// RVA: 0xDEFFE0 Offset: 0xDEE5E0 VA: 0x180DEFFE0
	internal uint <CraftItemAsync>b__34_1(InventoryItem.Amount x) { }

	// RVA: 0x7D3360 Offset: 0x7D1960 VA: 0x1807D3360
	internal InventoryDefId <StartPurchaseAsync>b__39_0(InventoryDef x) { }

	// RVA: 0xDF0D90 Offset: 0xDEF390 VA: 0x180DF0D90
	internal InventoryDefId <StartPurchaseAsync>b__39_1(IGrouping<InventoryDefId, InventoryDef> x) { }

	// RVA: 0xDF0E40 Offset: 0xDEF440 VA: 0x180DF0E40
	internal uint <StartPurchaseAsync>b__39_2(IGrouping<InventoryDefId, InventoryDef> x) { }

}

private struct SteamInventory.<GetDefinitionsWithPricesAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5193
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<InventoryDef[]> <>t__builder; // 0x8
	private CallResult<SteamInventoryRequestPricesResult_t> <>u__1; // 0x20

	// Methods

	// RVA: 0x1232A0 Offset: 0x1226A0 VA: 0x1801232A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1232B0 Offset: 0x1226B0 VA: 0x1801232B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GetAllItemsAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 5194
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x123180 Offset: 0x122580 VA: 0x180123180 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123190 Offset: 0x122590 VA: 0x180123190 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<CraftItemAsync>d__33 : IAsyncStateMachine // TypeDefIndex: 5195
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDef target; // 0x20
	public InventoryItem[] list; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0x1230C0 Offset: 0x1224C0 VA: 0x1801230C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1230D0 Offset: 0x1224D0 VA: 0x1801230D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<CraftItemAsync>d__34 : IAsyncStateMachine // TypeDefIndex: 5196
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDef target; // 0x20
	public InventoryItem.Amount[] list; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0x123120 Offset: 0x122520 VA: 0x180123120 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123130 Offset: 0x122530 VA: 0x180123130 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GrantPromoItemsAsync>d__36 : IAsyncStateMachine // TypeDefIndex: 5197
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x123420 Offset: 0x122820 VA: 0x180123420 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123430 Offset: 0x122830 VA: 0x180123430 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<TriggerItemDropAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 5198
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDefId id; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x28

	// Methods

	// RVA: 0x123670 Offset: 0x122A70 VA: 0x180123670 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123680 Offset: 0x122A80 VA: 0x180123680 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<StartPurchaseAsync>d__39 : IAsyncStateMachine // TypeDefIndex: 5199
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>> <>t__builder; // 0x8
	public InventoryDef[] items; // 0x20
	private CallResult<SteamInventoryStartPurchaseResult_t> <>u__1; // 0x28

	// Methods

	// RVA: 0x123610 Offset: 0x122A10 VA: 0x180123610 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123620 Offset: 0x122A20 VA: 0x180123620 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamMatchmaking : SteamClientClass<SteamMatchmaking> // TypeDefIndex: 5200
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Friend, Lobby> OnLobbyInvite; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby> OnLobbyEntered; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Result, Lobby> OnLobbyCreated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, uint, ushort, SteamId> OnLobbyGameCreated; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby> OnLobbyDataChanged; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend> OnLobbyMemberDataChanged; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend> OnLobbyMemberJoined; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend> OnLobbyMemberLeave; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend> OnLobbyMemberDisconnected; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend, Friend> OnLobbyMemberKicked; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend, Friend> OnLobbyMemberBanned; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Lobby, Friend, string> OnChatMessage; // 0x58

	// Properties
	internal static ISteamMatchmaking Internal { get; }

	// Methods

	// RVA: 0xDE9470 Offset: 0xDE7A70 VA: 0x180DE9470
	internal static ISteamMatchmaking get_Internal() { }

	// RVA: 0xDE8C30 Offset: 0xDE7230 VA: 0x180DE8C30 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE8CB0 Offset: 0xDE72B0 VA: 0x180DE8CB0
	internal static void InstallEvents() { }

	// RVA: 0xDE9200 Offset: 0xDE7800 VA: 0x180DE9200
	private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x931C0 Offset: 0x925C0 VA: 0x1800931C0
	// RVA: 0xDE8BD0 Offset: 0xDE71D0 VA: 0x180DE8BD0
	public static IEnumerable<ServerInfo> GetFavoriteServers() { }

	// RVA: 0xDE9430 Offset: 0xDE7A30 VA: 0x180DE9430
	public void .ctor() { }

}

private sealed class SteamMatchmaking.<>c // TypeDefIndex: 5201
{	// Fields
	public static readonly SteamMatchmaking.<>c <>9; // 0x0
	public static Action<LobbyInvite_t> <>9__5_0; // 0x8
	public static Action<LobbyEnter_t> <>9__5_1; // 0x10
	public static Action<LobbyCreated_t> <>9__5_2; // 0x18
	public static Action<LobbyGameCreated_t> <>9__5_3; // 0x20
	public static Action<LobbyDataUpdate_t> <>9__5_4; // 0x28
	public static Action<LobbyChatUpdate_t> <>9__5_5; // 0x30

	// Methods

	// RVA: 0xDF1230 Offset: 0xDEF830 VA: 0x180DF1230
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF07F0 Offset: 0xDEEDF0 VA: 0x180DF07F0
	internal void <InstallEvents>b__5_0(LobbyInvite_t x) { }

	// RVA: 0xDF0880 Offset: 0xDEEE80 VA: 0x180DF0880
	internal void <InstallEvents>b__5_1(LobbyEnter_t x) { }

	// RVA: 0xDF0900 Offset: 0xDEEF00 VA: 0x180DF0900
	internal void <InstallEvents>b__5_2(LobbyCreated_t x) { }

	// RVA: 0xDF0990 Offset: 0xDEEF90 VA: 0x180DF0990
	internal void <InstallEvents>b__5_3(LobbyGameCreated_t x) { }

	// RVA: 0xDF0A60 Offset: 0xDEF060 VA: 0x180DF0A60
	internal void <InstallEvents>b__5_4(LobbyDataUpdate_t x) { }

	// RVA: 0xDF0B50 Offset: 0xDEF150 VA: 0x180DF0B50
	internal void <InstallEvents>b__5_5(LobbyChatUpdate_t x) { }

}

private sealed class SteamMatchmaking.<GetFavoriteServers>d__47 : IEnumerable<ServerInfo>, IEnumerable, IEnumerator<ServerInfo>, IEnumerator, IDisposable // TypeDefIndex: 5202
{	// Fields
	private int <>1__state; // 0x10
	private ServerInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x90
	private int <count>5__2; // 0x94
	private int <i>5__3; // 0x98

	// Properties
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDECF60 Offset: 0xDEB560 VA: 0x180DECF60
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDECBE0 Offset: 0xDEB1E0 VA: 0x180DECBE0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDECE20 Offset: 0xDEB420 VA: 0x180DECE20 Slot: 6
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDECE70 Offset: 0xDEB470 VA: 0x180DECE70 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDECEC0 Offset: 0xDEB4C0 VA: 0x180DECEC0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDECD90 Offset: 0xDEB390 VA: 0x180DECD90 Slot: 4
	private IEnumerator<ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDECD90 Offset: 0xDEB390 VA: 0x180DECD90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers> // TypeDefIndex: 5203
{	// Properties
	internal static ISteamMatchmakingServers Internal { get; }

	// Methods

	// RVA: 0xDD8430 Offset: 0xDD6A30 VA: 0x180DD8430
	internal static ISteamMatchmakingServers get_Internal() { }

	// RVA: 0xDE8B10 Offset: 0xDE7110 VA: 0x180DE8B10 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE8B90 Offset: 0xDE7190 VA: 0x180DE8B90
	public void .ctor() { }

}

public class SteamMusic : SteamClientClass<SteamMusic> // TypeDefIndex: 5204
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnPlaybackChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<float> OnVolumeChanged; // 0x8

	// Methods

	// RVA: 0xDE9500 Offset: 0xDE7B00 VA: 0x180DE9500 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE9580 Offset: 0xDE7B80 VA: 0x180DE9580
	internal static void InstallEvents() { }

	// RVA: 0xDE9750 Offset: 0xDE7D50 VA: 0x180DE9750
	public void .ctor() { }

}

private sealed class SteamMusic.<>c // TypeDefIndex: 5205
{	// Fields
	public static readonly SteamMusic.<>c <>9; // 0x0
	public static Action<PlaybackStatusHasChanged_t> <>9__3_0; // 0x8
	public static Action<VolumeHasChanged_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDF0FF0 Offset: 0xDEF5F0 VA: 0x180DF0FF0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF0350 Offset: 0xDEE950 VA: 0x180DF0350
	internal void <InstallEvents>b__3_0(PlaybackStatusHasChanged_t x) { }

	// RVA: 0xDF0480 Offset: 0xDEEA80 VA: 0x180DF0480
	internal void <InstallEvents>b__3_1(VolumeHasChanged_t x) { }

}

public class SteamNetworking : SteamSharedClass<SteamNetworking> // TypeDefIndex: 5206
{	// Fields
	public static Action<SteamId> OnP2PSessionRequest; // 0x0
	public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed; // 0x8

	// Methods

	// RVA: 0xDEB030 Offset: 0xDE9630 VA: 0x180DEB030 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDEB0C0 Offset: 0xDE96C0 VA: 0x180DEB0C0
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDEB2A0 Offset: 0xDE98A0 VA: 0x180DEB2A0
	public void .ctor() { }

}

private sealed class SteamNetworking.<>c // TypeDefIndex: 5207
{	// Fields
	public static readonly SteamNetworking.<>c <>9; // 0x0
	public static Action<P2PSessionRequest_t> <>9__3_0; // 0x8
	public static Action<P2PSessionConnectFail_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDF1290 Offset: 0xDEF890 VA: 0x180DF1290
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDF03A0 Offset: 0xDEE9A0 VA: 0x180DF03A0
	internal void <InstallEvents>b__3_0(P2PSessionRequest_t x) { }

	// RVA: 0xDF0410 Offset: 0xDEEA10 VA: 0x180DF0410
	internal void <InstallEvents>b__3_1(P2PSessionConnectFail_t x) { }

}

public class SteamNetworkingSockets : SteamSharedClass<SteamNetworkingSockets> // TypeDefIndex: 5208
{	// Fields
	private static readonly Dictionary<uint, SocketManager> SocketInterfaces; // 0x0
	private static readonly Dictionary<uint, ConnectionManager> ConnectionInterfaces; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Connection, ConnectionInfo> OnConnectionStatusChanged; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<NetAddress> OnFakeIPResult; // 0x18

	// Properties
	internal static ISteamNetworkingSockets Internal { get; }
	public static NetIdentity Identity { get; }

	// Methods

	// RVA: 0xDEAEB0 Offset: 0xDE94B0 VA: 0x180DEAEB0
	internal static ISteamNetworkingSockets get_Internal() { }

	// RVA: 0xDEAE10 Offset: 0xDE9410 VA: 0x180DEAE10
	public static NetIdentity get_Identity() { }

	// RVA: 0xDEA8B0 Offset: 0xDE8EB0 VA: 0x180DEA8B0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDEA7B0 Offset: 0xDE8DB0 VA: 0x180DEA7B0
	internal static SocketManager GetSocketManager(uint id) { }

	// RVA: 0xDEAB70 Offset: 0xDE9170 VA: 0x180DEAB70
	internal static void SetSocketManager(uint id, SocketManager manager) { }

	// RVA: 0xDEA580 Offset: 0xDE8B80 VA: 0x180DEA580
	internal static ConnectionManager GetConnectionManager(uint id) { }

	// RVA: 0xDEAAB0 Offset: 0xDE90B0 VA: 0x180DEAAB0
	internal static void SetConnectionManager(uint id, ConnectionManager manager) { }

	// RVA: 0xDEA9E0 Offset: 0xDE8FE0 VA: 0x180DEA9E0
	internal void InstallEvents(bool server) { }

	// RVA: 0xDE9910 Offset: 0xDE7F10 VA: 0x180DE9910
	private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data) { }

	// RVA: 0xDEA400 Offset: 0xDE8A00 VA: 0x180DEA400
	private static void FakeIPResult(SteamNetworkingFakeIPResult_t data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEAD10 Offset: 0xDE9310 VA: 0x180DEAD10
	public static void add_OnFakeIPResult(Action<NetAddress> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEAF30 Offset: 0xDE9530 VA: 0x180DEAF30
	public static void remove_OnFakeIPResult(Action<NetAddress> value) { }

	// RVA: 0xDEA180 Offset: 0xDE8780 VA: 0x180DEA180
	public static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface) { }

	// RVA: 0xDE9790 Offset: 0xDE7D90 VA: 0x180DE9790
	public static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface) { }

	// RVA: 0xDEA650 Offset: 0xDE8C50 VA: 0x180DEA650
	public static Result GetFakeIP(int fakePortIndex, out NetAddress address) { }

	// RVA: 0xDEA2C0 Offset: 0xDE88C0 VA: 0x180DEA2C0
	public static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface) { }

	// RVA: 0xDEACD0 Offset: 0xDE92D0 VA: 0x180DEACD0
	public void .ctor() { }

	// RVA: 0xDEAC30 Offset: 0xDE9230 VA: 0x180DEAC30
	private static void .cctor() { }

}

public class SteamNetworkingUtils : SteamSharedClass<SteamNetworkingUtils> // TypeDefIndex: 5209
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<NetDebugOutput, string> OnDebugOutput; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static SteamNetworkingAvailability <Status>k__BackingField; // 0x8
	private static NetDebugOutput _debugLevel; // 0xC
	private static NetDebugFunc _debugFunc; // 0x10
	private static ConcurrentQueue<SteamNetworkingUtils.DebugMessage> debugMessages; // 0x18

	// Properties
	internal static ISteamNetworkingUtils Internal { get; }
	public static SteamNetworkingAvailability Status { get; set; }
	public static int ConnectionTimeout { get; set; }
	public static int SendBufferSize { set; }
	public static int AllowWithoutAuth { set; }
	public static int Unencrypted { set; }
	public static int DebugLevelAckRTT { get; set; }
	public static int DebugLevelPacketDecode { get; set; }
	public static int DebugLevelMessage { get; set; }
	public static int DebugLevelPacketGaps { get; set; }
	public static int DebugLevelP2PRendezvous { get; set; }
	public static int DebugLevelSDRRelayPings { get; set; }
	public static NetDebugOutput DebugLevel { get; set; }

	// Methods

	// RVA: 0x19C51A0 Offset: 0x19C37A0 VA: 0x1819C51A0
	internal static ISteamNetworkingUtils get_Internal() { }

	// RVA: 0x19C4750 Offset: 0x19C2D50 VA: 0x1819C4750 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C48E0 Offset: 0x19C2EE0 VA: 0x1819C48E0
	private static void InstallCallbacks(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C4E20 Offset: 0x19C3420 VA: 0x1819C4E20
	public static void add_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C5280 Offset: 0x19C3880 VA: 0x1819C5280
	public static void remove_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C5220 Offset: 0x19C3820 VA: 0x1819C5220
	public static SteamNetworkingAvailability get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C57B0 Offset: 0x19C3DB0 VA: 0x1819C57B0
	private static void set_Status(SteamNetworkingAvailability value) { }

	// RVA: 0x19C46F0 Offset: 0x19C2CF0 VA: 0x1819C46F0
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x19C4F10 Offset: 0x19C3510 VA: 0x1819C4F10
	public static int get_ConnectionTimeout() { }

	// RVA: 0x19C53D0 Offset: 0x19C39D0 VA: 0x1819C53D0
	public static void set_ConnectionTimeout(int value) { }

	// RVA: 0x19C5750 Offset: 0x19C3D50 VA: 0x1819C5750
	public static void set_SendBufferSize(int value) { }

	// RVA: 0x19C5370 Offset: 0x19C3970 VA: 0x1819C5370
	public static void set_AllowWithoutAuth(int value) { }

	// RVA: 0x19C5810 Offset: 0x19C3E10 VA: 0x1819C5810
	public static void set_Unencrypted(int value) { }

	// RVA: 0x19C4F60 Offset: 0x19C3560 VA: 0x1819C4F60
	public static int get_DebugLevelAckRTT() { }

	// RVA: 0x19C5430 Offset: 0x19C3A30 VA: 0x1819C5430
	public static void set_DebugLevelAckRTT(int value) { }

	// RVA: 0x19C5050 Offset: 0x19C3650 VA: 0x1819C5050
	public static int get_DebugLevelPacketDecode() { }

	// RVA: 0x19C5550 Offset: 0x19C3B50 VA: 0x1819C5550
	public static void set_DebugLevelPacketDecode(int value) { }

	// RVA: 0x19C4FB0 Offset: 0x19C35B0 VA: 0x1819C4FB0
	public static int get_DebugLevelMessage() { }

	// RVA: 0x19C5490 Offset: 0x19C3A90 VA: 0x1819C5490
	public static void set_DebugLevelMessage(int value) { }

	// RVA: 0x19C50A0 Offset: 0x19C36A0 VA: 0x1819C50A0
	public static int get_DebugLevelPacketGaps() { }

	// RVA: 0x19C55B0 Offset: 0x19C3BB0 VA: 0x1819C55B0
	public static void set_DebugLevelPacketGaps(int value) { }

	// RVA: 0x19C5000 Offset: 0x19C3600 VA: 0x1819C5000
	public static int get_DebugLevelP2PRendezvous() { }

	// RVA: 0x19C54F0 Offset: 0x19C3AF0 VA: 0x1819C54F0
	public static void set_DebugLevelP2PRendezvous(int value) { }

	// RVA: 0x19C50F0 Offset: 0x19C36F0 VA: 0x1819C50F0
	public static int get_DebugLevelSDRRelayPings() { }

	// RVA: 0x19C5610 Offset: 0x19C3C10 VA: 0x1819C5610
	public static void set_DebugLevelSDRRelayPings(int value) { }

	// RVA: 0x19C5140 Offset: 0x19C3740 VA: 0x1819C5140
	public static NetDebugOutput get_DebugLevel() { }

	// RVA: 0x19C5670 Offset: 0x19C3C70 VA: 0x1819C5670
	public static void set_DebugLevel(NetDebugOutput value) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C4AB0 Offset: 0x19C30B0 VA: 0x1819C4AB0
	private static void OnDebugMessage(NetDebugOutput nType, IntPtr str) { }

	// RVA: 0x19C49F0 Offset: 0x19C2FF0 VA: 0x1819C49F0
	internal static void LogDebugMessage(NetDebugOutput type, string message) { }

	// RVA: 0x19C4BA0 Offset: 0x19C31A0 VA: 0x1819C4BA0
	internal static void OutputDebugMessages() { }

	// RVA: 0x19C45C0 Offset: 0x19C2BC0 VA: 0x1819C45C0
	internal static NetMsg* AllocateMessage() { }

	// RVA: 0x19C4CD0 Offset: 0x19C32D0 VA: 0x1819C4CD0
	internal static bool SetConfigInt(NetConfig type, int value) { }

	// RVA: 0x19C4620 Offset: 0x19C2C20 VA: 0x1819C4620
	internal static int GetConfigInt(NetConfig type) { }

	// RVA: 0x19C4DE0 Offset: 0x19C33E0 VA: 0x1819C4DE0
	public void .ctor() { }

	// RVA: 0x19C4D70 Offset: 0x19C3370 VA: 0x1819C4D70
	private static void .cctor() { }

}

private struct SteamNetworkingUtils.DebugMessage // TypeDefIndex: 5210
{	// Fields
	public NetDebugOutput Type; // 0x0
	public string Msg; // 0x8

}

private sealed class SteamNetworkingUtils.<>c // TypeDefIndex: 5211
{	// Fields
	public static readonly SteamNetworkingUtils.<>c <>9; // 0x0
	public static Action<SteamRelayNetworkStatus_t> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x19CD680 Offset: 0x19CBC80 VA: 0x1819CD680
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC440 Offset: 0x19CAA40 VA: 0x1819CC440
	internal void <InstallCallbacks>b__3_0(SteamRelayNetworkStatus_t x) { }

}

public class SteamParental : SteamSharedClass<SteamParental> // TypeDefIndex: 5212
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSettingsChanged; // 0x13630

	// Methods

	// RVA: 0x19C5B90 Offset: 0x19C4190 VA: 0x1819C5B90 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C5D00 Offset: 0x19C4300 VA: 0x1819C5D00
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19C5E10 Offset: 0x19C4410 VA: 0x1819C5E10
	public void .ctor() { }

}

private sealed class SteamParental.<>c // TypeDefIndex: 5213
{	// Fields
	public static readonly SteamParental.<>c <>9; // 0x0
	public static Action<SteamParentalSettingsChanged_t> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x19CD6E0 Offset: 0x19CBCE0 VA: 0x1819CD6E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC4F0 Offset: 0x19CAAF0 VA: 0x1819CC4F0
	internal void <InstallEvents>b__3_0(SteamParentalSettingsChanged_t x) { }

}

public class SteamParties : SteamClientClass<SteamParties> // TypeDefIndex: 5214
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnBeaconLocationsUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnActiveBeaconsUpdated; // 0x8

	// Methods

	// RVA: 0x19C5E50 Offset: 0x19C4450 VA: 0x1819C5E50 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C5EE0 Offset: 0x19C44E0 VA: 0x1819C5EE0
	internal void InstallEvents(bool server) { }

	// RVA: 0x19C60C0 Offset: 0x19C46C0 VA: 0x1819C60C0
	public void .ctor() { }

}

private sealed class SteamParties.<>c // TypeDefIndex: 5215
{	// Fields
	public static readonly SteamParties.<>c <>9; // 0x0
	public static Action<AvailableBeaconLocationsUpdated_t> <>9__3_0; // 0x8
	public static Action<ActiveBeaconsUpdated_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19CD740 Offset: 0x19CBD40 VA: 0x1819CD740
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC5B0 Offset: 0x19CABB0 VA: 0x1819CC5B0
	internal void <InstallEvents>b__3_0(AvailableBeaconLocationsUpdated_t x) { }

	// RVA: 0x19CC8B0 Offset: 0x19CAEB0 VA: 0x1819CC8B0
	internal void <InstallEvents>b__3_1(ActiveBeaconsUpdated_t x) { }

}

public class SteamRemotePlay : SteamClientClass<SteamRemotePlay> // TypeDefIndex: 5216
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<RemotePlaySession> OnSessionConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<RemotePlaySession> OnSessionDisconnected; // 0x8

	// Methods

	// RVA: 0x19C6100 Offset: 0x19C4700 VA: 0x1819C6100 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C6190 Offset: 0x19C4790 VA: 0x1819C6190
	internal void InstallEvents(bool server) { }

	// RVA: 0x19C6370 Offset: 0x19C4970 VA: 0x1819C6370
	public void .ctor() { }

}

private sealed class SteamRemotePlay.<>c // TypeDefIndex: 5217
{	// Fields
	public static readonly SteamRemotePlay.<>c <>9; // 0x0
	public static Action<SteamRemotePlaySessionConnected_t> <>9__3_0; // 0x8
	public static Action<SteamRemotePlaySessionDisconnected_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19CD560 Offset: 0x19CBB60 VA: 0x1819CD560
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC540 Offset: 0x19CAB40 VA: 0x1819CC540
	internal void <InstallEvents>b__3_0(SteamRemotePlaySessionConnected_t x) { }

	// RVA: 0x19CC7C0 Offset: 0x19CADC0 VA: 0x1819CC7C0
	internal void <InstallEvents>b__3_1(SteamRemotePlaySessionDisconnected_t x) { }

}

public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage> // TypeDefIndex: 5218
{	// Methods

	// RVA: 0x19C63B0 Offset: 0x19C49B0 VA: 0x1819C63B0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C6430 Offset: 0x19C4A30 VA: 0x1819C6430
	public void .ctor() { }

}

public class SteamScreenshots : SteamClientClass<SteamScreenshots> // TypeDefIndex: 5219
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnScreenshotRequested; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Screenshot> OnScreenshotReady; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Result> OnScreenshotFailed; // 0x10

	// Properties
	internal static ISteamScreenshots Internal { get; }

	// Methods

	// RVA: 0x19C6790 Offset: 0x19C4D90 VA: 0x1819C6790
	internal static ISteamScreenshots get_Internal() { }

	// RVA: 0x19C6470 Offset: 0x19C4A70 VA: 0x1819C6470 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C64F0 Offset: 0x19C4AF0 VA: 0x1819C64F0
	internal static void InstallEvents() { }

	// RVA: 0x19C66C0 Offset: 0x19C4CC0 VA: 0x1819C66C0
	public static void TriggerScreenshot() { }

	// RVA: 0x19C6750 Offset: 0x19C4D50 VA: 0x1819C6750
	public void .ctor() { }

}

private sealed class SteamScreenshots.<>c // TypeDefIndex: 5220
{	// Fields
	public static readonly SteamScreenshots.<>c <>9; // 0x0
	public static Action<ScreenshotRequested_t> <>9__3_0; // 0x8
	public static Action<ScreenshotReady_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19CD620 Offset: 0x19CBC20 VA: 0x1819CD620
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC670 Offset: 0x19CAC70 VA: 0x1819CC670
	internal void <InstallEvents>b__3_0(ScreenshotRequested_t x) { }

	// RVA: 0x19CC720 Offset: 0x19CAD20 VA: 0x1819CC720
	internal void <InstallEvents>b__3_1(ScreenshotReady_t x) { }

}

public class SteamUGC : SteamSharedClass<SteamUGC> // TypeDefIndex: 5221
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Result> OnDownloadItemResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<AppId, PublishedFileId> OnItemSubscribed; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<AppId, PublishedFileId> OnItemUnsubscribed; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<AppId, PublishedFileId> OnItemInstalled; // 0x18

	// Properties
	internal static ISteamUGC Internal { get; }

	// Methods

	// RVA: 0x19C6D80 Offset: 0x19C5380 VA: 0x1819C6D80
	internal static ISteamUGC get_Internal() { }

	// RVA: 0x19C6860 Offset: 0x19C4E60 VA: 0x1819C6860 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C68F0 Offset: 0x19C4EF0 VA: 0x1819C68F0
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19C6820 Offset: 0x19C4E20 VA: 0x1819C6820
	public static bool Download(PublishedFileId fileId, bool highPriority = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x94C70 Offset: 0x94070 VA: 0x180094C70
	// RVA: 0x19C6C80 Offset: 0x19C5280 VA: 0x1819C6C80
	public static Task<Nullable<Item>> QueryFileAsync(PublishedFileId fileId) { }

	// RVA: 0x19C6D40 Offset: 0x19C5340 VA: 0x1819C6D40
	public void .ctor() { }

}

private sealed class SteamUGC.<>c // TypeDefIndex: 5222
{	// Fields
	public static readonly SteamUGC.<>c <>9; // 0x0
	public static Action<DownloadItemResult_t> <>9__3_0; // 0x8
	public static Action<RemoteStoragePublishedFileSubscribed_t> <>9__3_1; // 0x10
	public static Action<RemoteStoragePublishedFileUnsubscribed_t> <>9__3_2; // 0x18
	public static Action<ItemInstalled_t> <>9__3_3; // 0x20

	// Methods

	// RVA: 0x19CD440 Offset: 0x19CBA40 VA: 0x1819CD440
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC6C0 Offset: 0x19CACC0 VA: 0x1819CC6C0
	internal void <InstallEvents>b__3_0(DownloadItemResult_t x) { }

	// RVA: 0x19CC830 Offset: 0x19CAE30 VA: 0x1819CC830
	internal void <InstallEvents>b__3_1(RemoteStoragePublishedFileSubscribed_t x) { }

	// RVA: 0x19CCA50 Offset: 0x19CB050 VA: 0x1819CCA50
	internal void <InstallEvents>b__3_2(RemoteStoragePublishedFileUnsubscribed_t x) { }

	// RVA: 0x19CCAD0 Offset: 0x19CB0D0 VA: 0x1819CCAD0
	internal void <InstallEvents>b__3_3(ItemInstalled_t x) { }

}

private struct SteamUGC.<QueryFileAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5223
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Item>> <>t__builder; // 0x8
	public PublishedFileId fileId; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28

	// Methods

	// RVA: 0x2203F0 Offset: 0x21F7F0 VA: 0x1802203F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220400 Offset: 0x21F800 VA: 0x180220400 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamUser : SteamClientClass<SteamUser> // TypeDefIndex: 5224
{	// Fields
	private static Dictionary<string, string> richPresence; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSteamServersConnected; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSteamServerConnectFailure; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSteamServersDisconnected; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnClientGameServerDeny; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnLicensesUpdated; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<AppId, ulong, bool> OnMicroTxnAuthorizationResponse; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string> OnGameWebCallback; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<DurationControl> OnDurationControl; // 0x50
	private static bool _recordingVoice; // 0x58
	private static byte[] readBuffer; // 0x60
	private static uint sampleRate; // 0x68

	// Properties
	internal static ISteamUser Internal { get; }
	public static bool VoiceRecord { get; set; }
	public static bool HasVoiceData { get; }
	public static uint SampleRate { get; set; }
	public static uint OptimalSampleRate { get; }
	public static bool IsTwoFactorEnabled { get; }

	// Methods

	// RVA: 0x19C8CF0 Offset: 0x19C72F0 VA: 0x1819C8CF0
	internal static ISteamUser get_Internal() { }

	// RVA: 0x19C7B60 Offset: 0x19C6160 VA: 0x1819C7B60 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C7E20 Offset: 0x19C6420 VA: 0x1819C7E20
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C8A50 Offset: 0x19C7050 VA: 0x1819C8A50
	internal static void add_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C8F00 Offset: 0x19C7500 VA: 0x1819C8F00
	internal static void remove_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C8B50 Offset: 0x19C7150 VA: 0x1819C8B50
	public static void add_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C9000 Offset: 0x19C7600 VA: 0x1819C9000
	public static void remove_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	// RVA: 0x19C8EA0 Offset: 0x19C74A0 VA: 0x1819C8EA0
	public static bool get_VoiceRecord() { }

	// RVA: 0x19C92A0 Offset: 0x19C78A0 VA: 0x1819C92A0
	public static void set_VoiceRecord(bool value) { }

	// RVA: 0x19C8C50 Offset: 0x19C7250 VA: 0x1819C8C50
	public static bool get_HasVoiceData() { }

	// RVA: 0x19C8670 Offset: 0x19C6C70 VA: 0x1819C8670
	public static byte[] ReadVoiceDataBytes() { }

	// RVA: 0x19C8E40 Offset: 0x19C7440 VA: 0x1819C8E40
	public static uint get_SampleRate() { }

	// RVA: 0x19C9100 Offset: 0x19C7700 VA: 0x1819C9100
	public static void set_SampleRate(uint value) { }

	// RVA: 0x19C8DE0 Offset: 0x19C73E0 VA: 0x1819C8DE0
	public static uint get_OptimalSampleRate() { }

	// RVA: 0x19C7750 Offset: 0x19C5D50 VA: 0x1819C7750
	public static int DecompressVoice(byte[] from, Stream output) { }

	// RVA: 0x19C7A00 Offset: 0x19C6000 VA: 0x1819C7A00
	public static AuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0x958F0 Offset: 0x94CF0 VA: 0x1800958F0
	// RVA: 0x19C7920 Offset: 0x19C5F20 VA: 0x1819C7920
	public static Task<AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10) { }

	// RVA: 0x19C8D80 Offset: 0x19C7380 VA: 0x1819C8D80
	public static bool get_IsTwoFactorEnabled() { }

	[AsyncStateMachineAttribute] // RVA: 0x95A60 Offset: 0x94E60 VA: 0x180095A60
	// RVA: 0x19C88E0 Offset: 0x19C6EE0 VA: 0x1819C88E0
	public static Task<byte[]> RequestEncryptedAppTicketAsync() { }

	// RVA: 0x19C8A10 Offset: 0x19C7010 VA: 0x1819C8A10
	public void .ctor() { }

	// RVA: 0x19C89A0 Offset: 0x19C6FA0 VA: 0x1819C89A0
	private static void .cctor() { }

}

private sealed class SteamUser.<>c // TypeDefIndex: 5225
{	// Fields
	public static readonly SteamUser.<>c <>9; // 0x0
	public static Action<SteamServersConnected_t> <>9__4_0; // 0x8
	public static Action<SteamServerConnectFailure_t> <>9__4_1; // 0x10
	public static Action<SteamServersDisconnected_t> <>9__4_2; // 0x18
	public static Action<ClientGameServerDeny_t> <>9__4_3; // 0x20
	public static Action<LicensesUpdated_t> <>9__4_4; // 0x28
	public static Action<ValidateAuthTicketResponse_t> <>9__4_5; // 0x30
	public static Action<MicroTxnAuthorizationResponse_t> <>9__4_6; // 0x38
	public static Action<GameWebCallback_t> <>9__4_7; // 0x40
	public static Action<GetAuthSessionTicketResponse_t> <>9__4_8; // 0x48
	public static Action<DurationControl_t> <>9__4_9; // 0x50

	// Methods

	// RVA: 0x19CD500 Offset: 0x19CBB00 VA: 0x1819CD500
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CCBD0 Offset: 0x19CB1D0 VA: 0x1819CCBD0
	internal void <InstallEvents>b__4_0(SteamServersConnected_t x) { }

	// RVA: 0x19CCC40 Offset: 0x19CB240 VA: 0x1819CCC40
	internal void <InstallEvents>b__4_1(SteamServerConnectFailure_t x) { }

	// RVA: 0x19CCCB0 Offset: 0x19CB2B0 VA: 0x1819CCCB0
	internal void <InstallEvents>b__4_2(SteamServersDisconnected_t x) { }

	// RVA: 0x19CCD20 Offset: 0x19CB320 VA: 0x1819CCD20
	internal void <InstallEvents>b__4_3(ClientGameServerDeny_t x) { }

	// RVA: 0x19CCD90 Offset: 0x19CB390 VA: 0x1819CCD90
	internal void <InstallEvents>b__4_4(LicensesUpdated_t x) { }

	// RVA: 0x19CCE00 Offset: 0x19CB400 VA: 0x1819CCE00
	internal void <InstallEvents>b__4_5(ValidateAuthTicketResponse_t x) { }

	// RVA: 0x19CCED0 Offset: 0x19CB4D0 VA: 0x1819CCED0
	internal void <InstallEvents>b__4_6(MicroTxnAuthorizationResponse_t x) { }

	// RVA: 0x19CCF90 Offset: 0x19CB590 VA: 0x1819CCF90
	internal void <InstallEvents>b__4_7(GameWebCallback_t x) { }

	// RVA: 0x19CD020 Offset: 0x19CB620 VA: 0x1819CD020
	internal void <InstallEvents>b__4_8(GetAuthSessionTicketResponse_t x) { }

	// RVA: 0x19CD0A0 Offset: 0x19CB6A0 VA: 0x1819CD0A0
	internal void <InstallEvents>b__4_9(DurationControl_t x) { }

}

private sealed class SteamUser.<>c__DisplayClass54_0 // TypeDefIndex: 5226
{	// Fields
	public AuthTicket ticket; // 0x10
	public Result result; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CD410 Offset: 0x19CBA10 VA: 0x1819CD410
	internal void <GetAuthSessionTicketAsync>g__f|0(GetAuthSessionTicketResponse_t t) { }

}

private struct SteamUser.<GetAuthSessionTicketAsync>d__54 : IAsyncStateMachine // TypeDefIndex: 5227
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AuthTicket> <>t__builder; // 0x8
	public double timeoutSeconds; // 0x20
	private SteamUser.<>c__DisplayClass54_0 <>8__1; // 0x28
	private Stopwatch <stopwatch>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x220330 Offset: 0x21F730 VA: 0x180220330 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220340 Offset: 0x21F740 VA: 0x180220340 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamUser.<RequestEncryptedAppTicketAsync>d__71 : IAsyncStateMachine // TypeDefIndex: 5228
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	private CallResult<EncryptedAppTicketResponse_t> <>u__1; // 0x20

	// Methods

	// RVA: 0x220450 Offset: 0x21F850 VA: 0x180220450 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220460 Offset: 0x21F860 VA: 0x180220460 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamUserStats : SteamClientClass<SteamUserStats> // TypeDefIndex: 5229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static bool <StatsRecieved>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<string, int> OnAchievementIconFetched; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<SteamId, Result> OnUserStatsReceived; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Result> OnUserStatsStored; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<Achievement, int, int> OnAchievementProgress; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<SteamId> OnUserStatsUnloaded; // 0x28

	// Properties
	internal static ISteamUserStats Internal { get; }
	internal static bool StatsRecieved { set; }
	public static IEnumerable<Achievement> Achievements { get; }

	// Methods

	// RVA: 0x19C75D0 Offset: 0x19C5BD0 VA: 0x1819C75D0
	internal static ISteamUserStats get_Internal() { }

	// RVA: 0x19C6E90 Offset: 0x19C5490 VA: 0x1819C6E90 Slot: 4
	internal override void InitializeInterface(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C7710 Offset: 0x19C5D10 VA: 0x1819C7710
	internal static void set_StatsRecieved(bool value) { }

	// RVA: 0x19C6F30 Offset: 0x19C5530 VA: 0x1819C6F30
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C74C0 Offset: 0x19C5AC0 VA: 0x1819C74C0
	public static void add_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19C7660 Offset: 0x19C5C60 VA: 0x1819C7660
	public static void remove_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[IteratorStateMachineAttribute] // RVA: 0x96620 Offset: 0x95A20 VA: 0x180096620
	// RVA: 0x19C7570 Offset: 0x19C5B70 VA: 0x1819C7570
	public static IEnumerable<Achievement> get_Achievements() { }

	// RVA: 0x19C7450 Offset: 0x19C5A50 VA: 0x1819C7450
	public static bool StoreStats() { }

	// RVA: 0x19C7370 Offset: 0x19C5970 VA: 0x1819C7370
	public static bool RequestCurrentStats() { }

	// RVA: 0x19C73D0 Offset: 0x19C59D0 VA: 0x1819C73D0
	public static bool SetStat(string name, int value) { }

	// RVA: 0x19C7410 Offset: 0x19C5A10 VA: 0x1819C7410
	public static bool SetStat(string name, float value) { }

	// RVA: 0x19C6E50 Offset: 0x19C5450 VA: 0x1819C6E50
	public static int GetStatInt(string name) { }

	// RVA: 0x19C6E00 Offset: 0x19C5400 VA: 0x1819C6E00
	public static float GetStatFloat(string name) { }

	// RVA: 0x19C73A0 Offset: 0x19C59A0 VA: 0x1819C73A0
	public static bool ResetAll(bool includeAchievements) { }

	// RVA: 0x19C7480 Offset: 0x19C5A80 VA: 0x1819C7480
	public void .ctor() { }

}

private sealed class SteamUserStats.<>c // TypeDefIndex: 5230
{	// Fields
	public static readonly SteamUserStats.<>c <>9; // 0x0
	public static Action<UserStatsReceived_t> <>9__7_0; // 0x8
	public static Action<UserStatsStored_t> <>9__7_1; // 0x10
	public static Action<UserAchievementStored_t> <>9__7_2; // 0x18
	public static Action<UserStatsUnloaded_t> <>9__7_3; // 0x20
	public static Action<UserAchievementIconFetched_t> <>9__7_4; // 0x28

	// Methods

	// RVA: 0x19CD4A0 Offset: 0x19CBAA0 VA: 0x1819CD4A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CD130 Offset: 0x19CB730 VA: 0x1819CD130
	internal void <InstallEvents>b__7_0(UserStatsReceived_t x) { }

	// RVA: 0x19CD220 Offset: 0x19CB820 VA: 0x1819CD220
	internal void <InstallEvents>b__7_1(UserStatsStored_t x) { }

	// RVA: 0x19CD280 Offset: 0x19CB880 VA: 0x1819CD280
	internal void <InstallEvents>b__7_2(UserAchievementStored_t x) { }

	// RVA: 0x19CD320 Offset: 0x19CB920 VA: 0x1819CD320
	internal void <InstallEvents>b__7_3(UserStatsUnloaded_t x) { }

	// RVA: 0x19CD390 Offset: 0x19CB990 VA: 0x1819CD390
	internal void <InstallEvents>b__7_4(UserAchievementIconFetched_t x) { }

}

private sealed class SteamUserStats.<get_Achievements>d__24 : IEnumerable<Achievement>, IEnumerable, IEnumerator<Achievement>, IEnumerator, IDisposable // TypeDefIndex: 5231
{	// Fields
	private int <>1__state; // 0x10
	private Achievement <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private int <i>5__2; // 0x24

	// Properties
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xD88200 Offset: 0xD86800 VA: 0x180D88200
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19CD9A0 Offset: 0x19CBFA0 VA: 0x1819CD9A0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CDAF0 Offset: 0x19CC0F0 VA: 0x1819CDAF0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CDB40 Offset: 0x19CC140 VA: 0x1819CDB40 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CDA60 Offset: 0x19CC060 VA: 0x1819CDA60 Slot: 4
	private IEnumerator<Achievement> System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19CDA60 Offset: 0x19CC060 VA: 0x1819CDA60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class SteamUtils : SteamSharedClass<SteamUtils> // TypeDefIndex: 5232
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnIpCountryChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<int> OnLowBatteryPower; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSteamShutdown; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<bool> OnGamepadTextInputDismissed; // 0x18
	private static NotificationPosition overlayNotificationPosition; // 0x20

	// Properties
	internal static ISteamUtils Internal { get; }
	public static string IpCountry { get; }
	public static bool IsOverlayEnabled { get; }

	// Methods

	// RVA: 0x19C9D10 Offset: 0x19C8310 VA: 0x1819C9D10
	internal static ISteamUtils get_Internal() { }

	// RVA: 0x19C97C0 Offset: 0x19C7DC0 VA: 0x1819C97C0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19C9870 Offset: 0x19C7E70 VA: 0x1819C9870
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19C9C00 Offset: 0x19C8200 VA: 0x1819C9C00
	private static void SteamClosed() { }

	// RVA: 0x19C9D90 Offset: 0x19C8390 VA: 0x1819C9D90
	public static string get_IpCountry() { }

	// RVA: 0x19C9480 Offset: 0x19C7A80 VA: 0x1819C9480
	public static bool GetImageSize(int image, out uint width, out uint height) { }

	// RVA: 0x19C9520 Offset: 0x19C7B20 VA: 0x1819C9520
	public static Nullable<Image> GetImage(int image) { }

	// RVA: 0x19C9DF0 Offset: 0x19C83F0 VA: 0x1819C9DF0
	public static bool get_IsOverlayEnabled() { }

	// RVA: 0x19C9760 Offset: 0x19C7D60 VA: 0x1819C9760
	public static bool InitFilterText() { }

	// RVA: 0x19C93D0 Offset: 0x19C79D0 VA: 0x1819C93D0
	public static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage) { }

	// RVA: 0x19C9CD0 Offset: 0x19C82D0 VA: 0x1819C9CD0
	public void .ctor() { }

	// RVA: 0x19C9C90 Offset: 0x19C8290 VA: 0x1819C9C90
	private static void .cctor() { }

}

private sealed class SteamUtils.<>c // TypeDefIndex: 5233
{	// Fields
	public static readonly SteamUtils.<>c <>9; // 0x0
	public static Action<IPCountry_t> <>9__3_0; // 0x8
	public static Action<LowBatteryPower_t> <>9__3_1; // 0x10
	public static Action<SteamShutdown_t> <>9__3_2; // 0x18
	public static Action<GamepadTextInputDismissed_t> <>9__3_3; // 0x20

	// Methods

	// RVA: 0x19CD5C0 Offset: 0x19CBBC0 VA: 0x1819CD5C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19CC600 Offset: 0x19CAC00 VA: 0x1819CC600
	internal void <InstallEvents>b__3_0(IPCountry_t x) { }

	// RVA: 0x19CC900 Offset: 0x19CAF00 VA: 0x1819CC900
	internal void <InstallEvents>b__3_1(LowBatteryPower_t x) { }

	// RVA: 0x19CC980 Offset: 0x19CAF80 VA: 0x1819CC980
	internal void <InstallEvents>b__3_2(SteamShutdown_t x) { }

	// RVA: 0x19CCB50 Offset: 0x19CB150 VA: 0x1819CCB50
	internal void <InstallEvents>b__3_3(GamepadTextInputDismissed_t x) { }

}

public class SteamVideo : SteamClientClass<SteamVideo> // TypeDefIndex: 5234
{	// Methods

	// RVA: 0x19C9E50 Offset: 0x19C8450 VA: 0x1819C9E50 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InstallEvents() { }

	// RVA: 0x19C9ED0 Offset: 0x19C84D0 VA: 0x1819C9ED0
	public void .ctor() { }

}

public struct SteamId // TypeDefIndex: 5252
{	// Fields
	public ulong Value; // 0x0

	// Properties
	public uint AccountId { get; }

	// Methods

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static SteamId op_Implicit(ulong value) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static ulong op_Implicit(SteamId value) { }

	// RVA: 0x122FE0 Offset: 0x1223E0 VA: 0x180122FE0 Slot: 3
	public override string ToString() { }

	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public uint get_AccountId() { }

}

internal abstract class SteamInterface // TypeDefIndex: 5266
{	// Fields
	public IntPtr Self; // 0x10
	public IntPtr SelfGlobal; // 0x18
	public IntPtr SelfServer; // 0x20
	public IntPtr SelfClient; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsServer>k__BackingField; // 0x30

	// Properties
	public bool IsValid { get; }
	public bool IsServer { get; set; }

	// Methods

	// RVA: 0xDE75D0 Offset: 0xDE5BD0 VA: 0x180DE75D0 Slot: 4
	public virtual IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDE75A0 Offset: 0xDE5BA0 VA: 0x180DE75A0 Slot: 5
	public virtual IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDE7570 Offset: 0xDE5B70 VA: 0x180DE7570 Slot: 6
	public virtual IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDE76C0 Offset: 0xDE5CC0 VA: 0x180DE76C0
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C2F0 Offset: 0x82A8F0 VA: 0x18082C2F0
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82C320 Offset: 0x82A920 VA: 0x18082C320
	private void set_IsServer(bool value) { }

	// RVA: 0xDE7600 Offset: 0xDE5C00 VA: 0x180DE7600
	internal void SetupInterface(bool gameServer) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public abstract class SteamClass // TypeDefIndex: 5267
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void InitializeInterface(bool server);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void DestroyInterface(bool server);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

public class SteamSharedClass<T> : SteamClass // TypeDefIndex: 5268
{	// Fields
	internal static SteamInterface InterfaceClient; // 0x0
	internal static SteamInterface InterfaceServer; // 0x0

	// Properties
	internal static SteamInterface Interface { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal static SteamInterface get_Interface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA880 Offset: 0x1AA8E80 VA: 0x181AAA880
	|-SteamSharedClass<SteamApps>.get_Interface
	|-SteamSharedClass<SteamInventory>.get_Interface
	|-SteamSharedClass<SteamNetworkingSockets>.get_Interface
	|-SteamSharedClass<SteamNetworkingUtils>.get_Interface
	|-SteamSharedClass<SteamUGC>.get_Interface
	|-SteamSharedClass<SteamUtils>.get_Interface
	|-SteamSharedClass<object>.get_Interface
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void InitializeInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-SteamSharedClass<object>.InitializeInterface
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal virtual void SetInterface(bool server, SteamInterface iface) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA810 Offset: 0x1AA8E10 VA: 0x181AAA810
	|-SteamSharedClass<SteamApps>.SetInterface
	|-SteamSharedClass<SteamInventory>.SetInterface
	|-SteamSharedClass<SteamNetworking>.SetInterface
	|-SteamSharedClass<SteamNetworkingSockets>.SetInterface
	|-SteamSharedClass<SteamNetworkingUtils>.SetInterface
	|-SteamSharedClass<SteamParental>.SetInterface
	|-SteamSharedClass<SteamUGC>.SetInterface
	|-SteamSharedClass<SteamUtils>.SetInterface
	|-SteamSharedClass<object>.SetInterface
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override void DestroyInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA7A0 Offset: 0x1AA8DA0 VA: 0x181AAA7A0
	|-SteamSharedClass<SteamApps>.DestroyInterface
	|-SteamSharedClass<SteamInventory>.DestroyInterface
	|-SteamSharedClass<SteamNetworking>.DestroyInterface
	|-SteamSharedClass<SteamNetworkingSockets>.DestroyInterface
	|-SteamSharedClass<SteamNetworkingUtils>.DestroyInterface
	|-SteamSharedClass<SteamParental>.DestroyInterface
	|-SteamSharedClass<SteamUGC>.DestroyInterface
	|-SteamSharedClass<SteamUtils>.DestroyInterface
	|-SteamSharedClass<object>.DestroyInterface
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645400 Offset: 0x1643A00 VA: 0x181645400
	|-SteamSharedClass<SteamApps>..ctor
	|-SteamSharedClass<SteamInventory>..ctor
	|-SteamSharedClass<SteamNetworking>..ctor
	|-SteamSharedClass<SteamNetworkingSockets>..ctor
	|-SteamSharedClass<SteamNetworkingUtils>..ctor
	|-SteamSharedClass<SteamParental>..ctor
	|-SteamSharedClass<SteamUGC>..ctor
	|-SteamSharedClass<SteamUtils>..ctor
	|-SteamSharedClass<object>..ctor
	*/

}

public class SteamClientClass<T> : SteamClass // TypeDefIndex: 5269
{	// Fields
	internal static SteamInterface Interface; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal override void InitializeInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	|-SteamClientClass<object>.InitializeInterface
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal virtual void SetInterface(bool server, SteamInterface iface) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA700 Offset: 0x1AA8D00 VA: 0x181AAA700
	|-SteamClientClass<SteamFriends>.SetInterface
	|-SteamClientClass<SteamInput>.SetInterface
	|-SteamClientClass<SteamMatchmaking>.SetInterface
	|-SteamClientClass<SteamMatchmakingServers>.SetInterface
	|-SteamClientClass<SteamMusic>.SetInterface
	|-SteamClientClass<SteamParties>.SetInterface
	|-SteamClientClass<SteamRemotePlay>.SetInterface
	|-SteamClientClass<SteamRemoteStorage>.SetInterface
	|-SteamClientClass<SteamScreenshots>.SetInterface
	|-SteamClientClass<SteamUser>.SetInterface
	|-SteamClientClass<SteamUserStats>.SetInterface
	|-SteamClientClass<SteamVideo>.SetInterface
	|-SteamClientClass<object>.SetInterface
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override void DestroyInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AAA6C0 Offset: 0x1AA8CC0 VA: 0x181AAA6C0
	|-SteamClientClass<SteamFriends>.DestroyInterface
	|-SteamClientClass<SteamInput>.DestroyInterface
	|-SteamClientClass<SteamMatchmaking>.DestroyInterface
	|-SteamClientClass<SteamMatchmakingServers>.DestroyInterface
	|-SteamClientClass<SteamMusic>.DestroyInterface
	|-SteamClientClass<SteamParties>.DestroyInterface
	|-SteamClientClass<SteamRemotePlay>.DestroyInterface
	|-SteamClientClass<SteamRemoteStorage>.DestroyInterface
	|-SteamClientClass<SteamScreenshots>.DestroyInterface
	|-SteamClientClass<SteamUser>.DestroyInterface
	|-SteamClientClass<SteamUserStats>.DestroyInterface
	|-SteamClientClass<SteamVideo>.DestroyInterface
	|-SteamClientClass<object>.DestroyInterface
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1645400 Offset: 0x1643A00 VA: 0x181645400
	|-SteamClientClass<SteamFriends>..ctor
	|-SteamClientClass<SteamInput>..ctor
	|-SteamClientClass<SteamMatchmaking>..ctor
	|-SteamClientClass<SteamMatchmakingServers>..ctor
	|-SteamClientClass<SteamMusic>..ctor
	|-SteamClientClass<SteamParties>..ctor
	|-SteamClientClass<SteamRemotePlay>..ctor
	|-SteamClientClass<SteamRemoteStorage>..ctor
	|-SteamClientClass<SteamScreenshots>..ctor
	|-SteamClientClass<SteamUser>..ctor
	|-SteamClientClass<SteamUserStats>..ctor
	|-SteamClientClass<SteamVideo>..ctor
	|-SteamClientClass<object>..ctor
	*/

}

internal struct SteamParamStringArray : IDisposable // TypeDefIndex: 5273
{	// Fields
	public SteamParamStringArray_t Value; // 0x0
	private IntPtr[] NativeStrings; // 0x10
	private IntPtr NativeArray; // 0x18

	// Methods

	// RVA: 0x19C5950 Offset: 0x19C3F50 VA: 0x1819C5950
	public static SteamParamStringArray From(string[] array) { }

	// RVA: 0x220250 Offset: 0x21F650 VA: 0x180220250 Slot: 4
	public void Dispose() { }

}

internal struct SteamServersConnected_t : ICallbackData // TypeDefIndex: 5293
{	// Fields
	public static int _datasize; // 0x13690

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA6E0 Offset: 0x1D9AE0 VA: 0x1801DA6E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA6D0 Offset: 0x1D9AD0 VA: 0x1801DA6D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12913B0 Offset: 0x128F9B0 VA: 0x1812913B0
	private static void .cctor() { }

}

internal struct SteamServerConnectFailure_t : ICallbackData // TypeDefIndex: 5294
{	// Fields
	internal Result Result; // 0x0
	internal bool StillRetrying; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA670 Offset: 0x1D9A70 VA: 0x1801DA670 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA660 Offset: 0x1D9A60 VA: 0x1801DA660 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291300 Offset: 0x128F900 VA: 0x181291300
	private static void .cctor() { }

}

internal struct SteamServersDisconnected_t : ICallbackData // TypeDefIndex: 5295
{	// Fields
	internal Result Result; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA750 Offset: 0x1D9B50 VA: 0x1801DA750 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA740 Offset: 0x1D9B40 VA: 0x1801DA740 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291460 Offset: 0x128FA60 VA: 0x181291460
	private static void .cctor() { }

}

internal struct SteamAPICallCompleted_t : ICallbackData // TypeDefIndex: 5329
{	// Fields
	internal ulong AsyncCall; // 0x0
	internal int Callback; // 0x8
	internal uint ParamCount; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9130 Offset: 0x1D8530 VA: 0x1801D9130 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9120 Offset: 0x1D8520 VA: 0x1801D9120 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12904C0 Offset: 0x128EAC0 VA: 0x1812904C0
	private static void .cctor() { }

}

internal struct SteamShutdown_t : ICallbackData // TypeDefIndex: 5330
{	// Fields
	public static int _datasize; // 0x13799

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA7C0 Offset: 0x1D9BC0 VA: 0x1801DA7C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA7B0 Offset: 0x1D9BB0 VA: 0x1801DA7B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291510 Offset: 0x128FB10 VA: 0x181291510
	private static void .cctor() { }

}

internal struct SteamInputDeviceConnected_t : ICallbackData // TypeDefIndex: 5427
{	// Fields
	internal ulong ConnectedDeviceHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9390 Offset: 0x1D8790 VA: 0x1801D9390 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9380 Offset: 0x1D8780 VA: 0x1801D9380 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290740 Offset: 0x128ED40 VA: 0x181290740
	private static void .cctor() { }

}

internal struct SteamInputDeviceDisconnected_t : ICallbackData // TypeDefIndex: 5428
{	// Fields
	internal ulong DisconnectedDeviceHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9400 Offset: 0x1D8800 VA: 0x1801D9400 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D93F0 Offset: 0x1D87F0 VA: 0x1801D93F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12907E0 Offset: 0x128EDE0 VA: 0x1812907E0
	private static void .cctor() { }

}

internal struct SteamInputConfigurationLoaded_t : ICallbackData // TypeDefIndex: 5429
{	// Fields
	internal AppId AppID; // 0x0
	internal ulong DeviceHandle; // 0x4
	internal ulong MappingCreator; // 0xC
	internal uint MajorRevision; // 0x14
	internal uint MinorRevision; // 0x18
	internal bool UsesSteamInputAPI; // 0x1C
	internal bool UsesGamepadAPI; // 0x1D
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9320 Offset: 0x1D8720 VA: 0x1801D9320 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9310 Offset: 0x1D8710 VA: 0x1801D9310 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12906A0 Offset: 0x128ECA0 VA: 0x1812906A0
	private static void .cctor() { }

}

internal struct SteamUGCQueryCompleted_t : ICallbackData // TypeDefIndex: 5430
{	// Fields
	internal ulong Handle; // 0x0
	internal Result Result; // 0x8
	internal uint NumResultsReturned; // 0xC
	internal uint TotalMatchingResults; // 0x10
	internal bool CachedData; // 0x14
	internal byte[] NextCursor; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DB100 Offset: 0x1DA500 VA: 0x1801DB100 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB0F0 Offset: 0x1DA4F0 VA: 0x1801DB0F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291740 Offset: 0x128FD40 VA: 0x181291740
	private static void .cctor() { }

}

internal struct SteamUGCRequestUGCDetailsResult_t : ICallbackData // TypeDefIndex: 5431
{	// Fields
	internal SteamUGCDetails_t Details; // 0x0
	internal bool CachedData; // 0x88
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DB2E0 Offset: 0x1DA6E0 VA: 0x1801DB2E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB2D0 Offset: 0x1DA6D0 VA: 0x1801DB2D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12917F0 Offset: 0x128FDF0 VA: 0x1812917F0
	private static void .cctor() { }

}

internal struct SteamAppInstalled_t : ICallbackData // TypeDefIndex: 5449
{	// Fields
	internal AppId AppID; // 0x0
	internal int InstallFolderIndex; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9240 Offset: 0x1D8640 VA: 0x1801D9240 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9230 Offset: 0x1D8630 VA: 0x1801D9230 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290560 Offset: 0x128EB60 VA: 0x181290560
	private static void .cctor() { }

}

internal struct SteamAppUninstalled_t : ICallbackData // TypeDefIndex: 5450
{	// Fields
	internal AppId AppID; // 0x0
	internal int InstallFolderIndex; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D92B0 Offset: 0x1D86B0 VA: 0x1801D92B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D92A0 Offset: 0x1D86A0 VA: 0x1801D92A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290600 Offset: 0x128EC00 VA: 0x181290600
	private static void .cctor() { }

}

internal struct SteamInventoryResultReady_t : ICallbackData // TypeDefIndex: 5474
{	// Fields
	internal int Handle; // 0x0
	internal Result Result; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D97B0 Offset: 0x1D8BB0 VA: 0x1801D97B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D97A0 Offset: 0x1D8BA0 VA: 0x1801D97A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290BB0 Offset: 0x128F1B0 VA: 0x181290BB0
	private static void .cctor() { }

}

internal struct SteamInventoryFullUpdate_t : ICallbackData // TypeDefIndex: 5475
{	// Fields
	internal int Handle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9550 Offset: 0x1D8950 VA: 0x1801D9550 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9540 Offset: 0x1D8940 VA: 0x1801D9540 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12909D0 Offset: 0x128EFD0 VA: 0x1812909D0
	private static void .cctor() { }

}

internal struct SteamInventoryDefinitionUpdate_t : ICallbackData // TypeDefIndex: 5476
{	// Fields
	public static int _datasize; // 0x13930

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9470 Offset: 0x1D8870 VA: 0x1801D9470 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9460 Offset: 0x1D8860 VA: 0x1801D9460 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290880 Offset: 0x128EE80 VA: 0x181290880
	private static void .cctor() { }

}

internal struct SteamInventoryEligiblePromoItemDefIDs_t : ICallbackData // TypeDefIndex: 5477
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal int UmEligiblePromoItemDefs; // 0xC
	internal bool CachedData; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D94E0 Offset: 0x1D88E0 VA: 0x1801D94E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D94D0 Offset: 0x1D88D0 VA: 0x1801D94D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290930 Offset: 0x128EF30 VA: 0x181290930
	private static void .cctor() { }

}

internal struct SteamInventoryStartPurchaseResult_t : ICallbackData // TypeDefIndex: 5478
{	// Fields
	internal Result Result; // 0x0
	internal ulong OrderID; // 0x8
	internal ulong TransID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D98B0 Offset: 0x1D8CB0 VA: 0x1801D98B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D98A0 Offset: 0x1D8CA0 VA: 0x1801D98A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290C50 Offset: 0x128F250 VA: 0x181290C50
	private static void .cctor() { }

}

internal struct SteamInventoryRequestPricesResult_t : ICallbackData // TypeDefIndex: 5479
{	// Fields
	internal Result Result; // 0x0
	internal byte[] Currency; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D95B0 Offset: 0x1D89B0 VA: 0x1801D95B0
	internal string CurrencyUTF8() { }

	// RVA: 0x1D9640 Offset: 0x1D8A40 VA: 0x1801D9640 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9630 Offset: 0x1D8A30 VA: 0x1801D9630 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290B00 Offset: 0x128F100 VA: 0x181290B00
	private static void .cctor() { }

}

internal struct SteamParentalSettingsChanged_t : ICallbackData // TypeDefIndex: 5482
{	// Fields
	public static int _datasize; // 0x1397C

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA340 Offset: 0x1D9740 VA: 0x1801DA340 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA330 Offset: 0x1D9730 VA: 0x1801DA330 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291040 Offset: 0x128F640 VA: 0x181291040
	private static void .cctor() { }

}

internal struct SteamRemotePlaySessionConnected_t : ICallbackData // TypeDefIndex: 5483
{	// Fields
	internal uint SessionID; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA590 Offset: 0x1D9990 VA: 0x1801DA590 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA580 Offset: 0x1D9980 VA: 0x1801DA580 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12911A0 Offset: 0x128F7A0 VA: 0x1812911A0
	private static void .cctor() { }

}

internal struct SteamRemotePlaySessionDisconnected_t : ICallbackData // TypeDefIndex: 5484
{	// Fields
	internal uint SessionID; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA600 Offset: 0x1D9A00 VA: 0x1801DA600 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA5F0 Offset: 0x1D99F0 VA: 0x1801DA5F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1291250 Offset: 0x128F850 VA: 0x181291250
	private static void .cctor() { }

}

internal struct SteamNetworkingMessagesSessionRequest_t : ICallbackData // TypeDefIndex: 5485
{	// Fields
	internal NetIdentity DentityRemote; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA260 Offset: 0x1D9660 VA: 0x1801DA260 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA250 Offset: 0x1D9650 VA: 0x1801DA250 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290FA0 Offset: 0x128F5A0 VA: 0x181290FA0
	private static void .cctor() { }

}

internal struct SteamNetworkingMessagesSessionFailed_t : ICallbackData // TypeDefIndex: 5486
{	// Fields
	internal ConnectionInfo Nfo; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA060 Offset: 0x1D9460 VA: 0x1801DA060 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA050 Offset: 0x1D9450 VA: 0x1801DA050 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290F00 Offset: 0x128F500 VA: 0x181290F00
	private static void .cctor() { }

}

internal struct SteamNetConnectionStatusChangedCallback_t : ICallbackData // TypeDefIndex: 5487
{	// Fields
	internal Connection Conn; // 0x0
	internal ConnectionInfo Nfo; // 0x8
	internal ConnectionState OldState; // 0x2C0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9B40 Offset: 0x1D8F40 VA: 0x1801D9B40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9B30 Offset: 0x1D8F30 VA: 0x1801D9B30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290DA0 Offset: 0x128F3A0 VA: 0x181290DA0
	private static void .cctor() { }

}

internal struct SteamNetAuthenticationStatus_t : ICallbackData // TypeDefIndex: 5488
{	// Fields
	internal SteamNetworkingAvailability Avail; // 0x0
	internal byte[] DebugMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9990 Offset: 0x1D8D90 VA: 0x1801D9990 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9980 Offset: 0x1D8D80 VA: 0x1801D9980 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290D00 Offset: 0x128F300 VA: 0x181290D00
	private static void .cctor() { }

}

internal struct SteamRelayNetworkStatus_t : ICallbackData // TypeDefIndex: 5489
{	// Fields
	internal SteamNetworkingAvailability Avail; // 0x0
	internal int PingMeasurementInProgress; // 0x4
	internal SteamNetworkingAvailability AvailNetworkConfig; // 0x8
	internal SteamNetworkingAvailability AvailAnyRelay; // 0xC
	internal byte[] DebugMsg; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA3B0 Offset: 0x1D97B0 VA: 0x1801DA3B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA3A0 Offset: 0x1D97A0 VA: 0x1801DA3A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12910F0 Offset: 0x128F6F0 VA: 0x1812910F0
	private static void .cctor() { }

}

internal struct SteamNetworkingFakeIPResult_t : ICallbackData // TypeDefIndex: 5502
{	// Fields
	internal Result Result; // 0x0
	internal NetIdentity Dentity; // 0x4
	internal uint IP; // 0x8C
	internal ushort[] Ports; // 0x90
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9D90 Offset: 0x1D9190 VA: 0x1801D9D90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9D80 Offset: 0x1D9180 VA: 0x1801D9D80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290E50 Offset: 0x128F450 VA: 0x181290E50
	private static void .cctor() { }

}

internal struct SteamParamStringArray_t // TypeDefIndex: 5514
{	// Fields
	internal IntPtr Strings; // 0x0
	internal int NumStrings; // 0x8

}

internal struct SteamUGCDetails_t // TypeDefIndex: 5515
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal WorkshopFileType FileType; // 0xC
	internal AppId CreatorAppID; // 0x10
	internal AppId ConsumerAppID; // 0x14
	internal byte[] Title; // 0x18
	internal byte[] Description; // 0x20
	internal ulong SteamIDOwner; // 0x28
	internal uint TimeCreated; // 0x30
	internal uint TimeUpdated; // 0x34
	internal uint TimeAddedToUserList; // 0x38
	internal RemoteStoragePublishedFileVisibility Visibility; // 0x3C
	internal bool Banned; // 0x40
	internal bool AcceptedForUse; // 0x41
	internal bool TagsTruncated; // 0x42
	internal byte[] Tags; // 0x48
	internal ulong File; // 0x50
	internal ulong PreviewFile; // 0x58
	internal byte[] PchFileName; // 0x60
	internal int FileSize; // 0x68
	internal int PreviewFileSize; // 0x6C
	internal byte[] URL; // 0x70
	internal uint VotesUp; // 0x78
	internal uint VotesDown; // 0x7C
	internal float Score; // 0x80
	internal uint NumChildren; // 0x84

	// Methods

	// RVA: 0x1DA920 Offset: 0x1D9D20 VA: 0x1801DA920
	internal string TitleUTF8() { }

	// RVA: 0x1DA820 Offset: 0x1D9C20 VA: 0x1801DA820
	internal string DescriptionUTF8() { }

	// RVA: 0x1DA8A0 Offset: 0x1D9CA0 VA: 0x1801DA8A0
	internal string TagsUTF8() { }

}

internal struct SteamItemDetails_t // TypeDefIndex: 5516
{	// Fields
	internal InventoryItemId ItemId; // 0x0
	internal InventoryDefId Definition; // 0x8
	internal ushort Quantity; // 0xC
	internal ushort Flags; // 0xE

}

internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t> // TypeDefIndex: 5518
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static SteamAPICall_t op_Implicit(ulong value) { }

	// RVA: 0x122FE0 Offset: 0x1223E0 VA: 0x180122FE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D9220 Offset: 0x1D8620 VA: 0x1801D9220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D91B0 Offset: 0x1D85B0 VA: 0x1801D91B0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D91A0 Offset: 0x1D85A0 VA: 0x1801D91A0 Slot: 4
	public bool Equals(SteamAPICall_t p) { }

	// RVA: 0x1D9190 Offset: 0x1D8590 VA: 0x1801D9190 Slot: 5
	public int CompareTo(SteamAPICall_t other) { }

}

internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t> // TypeDefIndex: 5539
{	// Fields
	public int Value; // 0x0

	// Methods

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static SteamInventoryResult_t op_Implicit(int value) { }

	// RVA: 0x1D9890 Offset: 0x1D8C90 VA: 0x1801D9890 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9820 Offset: 0x1D8C20 VA: 0x1801D9820 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D8320 Offset: 0x1D7720 VA: 0x1801D8320 Slot: 4
	public bool Equals(SteamInventoryResult_t p) { }

	// RVA: 0x1D9810 Offset: 0x1D8C10 VA: 0x1801D9810 Slot: 5
	public int CompareTo(SteamInventoryResult_t other) { }

}

internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t> // TypeDefIndex: 5540
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80
	public static SteamInventoryUpdateHandle_t op_Implicit(ulong value) { }

	// RVA: 0x122FE0 Offset: 0x1223E0 VA: 0x180122FE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D9220 Offset: 0x1D8620 VA: 0x1801D9220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9910 Offset: 0x1D8D10 VA: 0x1801D9910 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D91A0 Offset: 0x1D85A0 VA: 0x1801D91A0 Slot: 4
	public bool Equals(SteamInventoryUpdateHandle_t p) { }

	// RVA: 0x1D9190 Offset: 0x1D8590 VA: 0x1801D9190 Slot: 5
	public int CompareTo(SteamInventoryUpdateHandle_t other) { }

}

internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID> // TypeDefIndex: 5542
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x68A650 Offset: 0x688C50 VA: 0x18068A650
	public static SteamNetworkingPOPID op_Implicit(uint value) { }

	// RVA: 0x1D8330 Offset: 0x1D7730 VA: 0x1801D8330 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DA2C0 Offset: 0x1D96C0 VA: 0x1801DA2C0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D8320 Offset: 0x1D7720 VA: 0x1801D8320 Slot: 4
	public bool Equals(SteamNetworkingPOPID p) { }

	// RVA: 0x1D82A0 Offset: 0x1D76A0 VA: 0x1801D82A0 Slot: 5
	public int CompareTo(SteamNetworkingPOPID other) { }

}

public class SteamAchievement : IAchievement // TypeDefIndex: 5710
{
// Namespace: Rust.Platform.Steam
public class SteamAchievement : IAchievement // TypeDefIndex: 5710
	// Fields
	private Achievement _achievement; // 0x10

	// Properties
	public string Key { get; }
	public bool IsUnlocked { get; }

	// Methods

	// RVA: 0x21EB150 Offset: 0x21E9750 VA: 0x1821EB150 Slot: 4
	public string get_Key() { }

	// RVA: 0x21EB140 Offset: 0x21E9740 VA: 0x1821EB140 Slot: 5
	public bool get_IsUnlocked() { }

	// RVA: 0x21EB110 Offset: 0x21E9710 VA: 0x1821EB110
	internal void .ctor(Achievement achievement) { }

	// RVA: 0x21EB100 Offset: 0x21E9700 VA: 0x1821EB100 Slot: 6
	public void Unlock() { }

}

public class SteamAuthTicket : IAuthTicket, IDisposable // TypeDefIndex: 5711
{	// Fields
	private readonly AuthTicket _ticket; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly string <Token>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly byte[] <Data>k__BackingField; // 0x20

	// Properties
	public string Token { get; }
	public byte[] Data { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	public string get_Token() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public byte[] get_Data() { }

	// RVA: 0x21EB180 Offset: 0x21E9780 VA: 0x1821EB180
	internal void .ctor(AuthTicket ticket) { }

	// RVA: 0x21EB160 Offset: 0x21E9760 VA: 0x1821EB160 Slot: 6
	public void Dispose() { }

}

public class SteamDownloadableContent : IDownloadableContent // TypeDefIndex: 5712
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <AppId>k__BackingField; // 0x10

	// Properties
	public int AppId { get; }
	public bool IsInstalled { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public int get_AppId() { }

	// RVA: 0x21EB290 Offset: 0x21E9890 VA: 0x1821EB290 Slot: 5
	public bool get_IsInstalled() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int appId) { }

}

public class SteamInventory : IPlayerInventory, IDisposable // TypeDefIndex: 5713
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly InventoryResult <Value>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IReadOnlyList<IPlayerItem> <Items>k__BackingField; // 0x18

	// Properties
	public InventoryResult Value { get; }
	public IReadOnlyList<IPlayerItem> Items { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public InventoryResult get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public IReadOnlyList<IPlayerItem> get_Items() { }

	// RVA: 0x21EB320 Offset: 0x21E9920 VA: 0x1821EB320
	internal void .ctor(InventoryResult inventory) { }

	// RVA: 0x21EB2E0 Offset: 0x21E98E0 VA: 0x1821EB2E0 Slot: 7
	public void Dispose() { }

	// RVA: 0x21EB2B0 Offset: 0x21E98B0 VA: 0x1821EB2B0 Slot: 4
	public bool BelongsTo(ulong userId) { }

	// RVA: 0x21EB300 Offset: 0x21E9900 VA: 0x1821EB300 Slot: 6
	public byte[] Serialize() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5714
{	// Fields
	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Func<InventoryItem, SteamItem> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x21F1540 Offset: 0x21EFB40 VA: 0x1821F1540
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F1130 Offset: 0x21EF730 VA: 0x1821F1130
	internal SteamItem <.ctor>b__6_0(InventoryItem i) { }

}

public class SteamItem : IPlayerItem // TypeDefIndex: 5715
{	// Fields
	public InventoryItem Value; // 0x10

	// Properties
	public int DefinitionId { get; }
	public int Quantity { get; }
	public DateTimeOffset Acquired { get; }
	public ulong WorkshopId { get; }
	public string ItemShortName { get; }

	// Methods

	// RVA: 0x21EBAC0 Offset: 0x21EA0C0 VA: 0x1821EBAC0
	public void .ctor(InventoryItem item) { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x1300D60 Offset: 0x12FF360 VA: 0x181300D60 Slot: 5
	public int get_Quantity() { }

	// RVA: 0x21EBB00 Offset: 0x21EA100 VA: 0x1821EBB00 Slot: 6
	public DateTimeOffset get_Acquired() { }

	// RVA: 0x21EBC00 Offset: 0x21EA200 VA: 0x1821EBC00 Slot: 7
	public ulong get_WorkshopId() { }

	// RVA: 0x21EBB90 Offset: 0x21EA190 VA: 0x1821EBB90 Slot: 8
	public string get_ItemShortName() { }

}

public class SteamItemDefinition : IPlayerItemDefinition, IEquatable<IPlayerItemDefinition> // TypeDefIndex: 5716
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly InventoryDef <Value>k__BackingField; // 0x10

	// Properties
	public InventoryDef Value { get; }
	public int DefinitionId { get; }
	public string Name { get; }
	public string Description { get; }
	public string Type { get; }
	public string IconUrl { get; }
	public int LocalPrice { get; }
	public string LocalPriceFormatted { get; }
	public string PriceCategory { get; }
	public bool IsGenerator { get; }
	public bool IsMarketable { get; }
	public string StoreTags { get; }
	public string ItemShortName { get; }
	public ulong WorkshopId { get; }
	public ulong WorkshopDownload { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public InventoryDef get_Value() { }

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(InventoryDef value) { }

	// RVA: 0x21EB840 Offset: 0x21E9E40 VA: 0x1821EB840 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x21EB970 Offset: 0x21E9F70 VA: 0x1821EB970 Slot: 5
	public string get_Name() { }

	// RVA: 0x21EB860 Offset: 0x21E9E60 VA: 0x1821EB860 Slot: 6
	public string get_Description() { }

	// RVA: 0x21EBA00 Offset: 0x21EA000 VA: 0x1821EBA00 Slot: 7
	public string get_Type() { }

	// RVA: 0x21EB880 Offset: 0x21E9E80 VA: 0x1821EB880 Slot: 8
	public string get_IconUrl() { }

	// RVA: 0x21EB950 Offset: 0x21E9F50 VA: 0x1821EB950 Slot: 9
	public int get_LocalPrice() { }

	// RVA: 0x21EB930 Offset: 0x21E9F30 VA: 0x1821EB930 Slot: 10
	public string get_LocalPriceFormatted() { }

	// RVA: 0x21EB990 Offset: 0x21E9F90 VA: 0x1821EB990 Slot: 11
	public string get_PriceCategory() { }

	// RVA: 0x21EB8A0 Offset: 0x21E9EA0 VA: 0x1821EB8A0 Slot: 12
	public bool get_IsGenerator() { }

	// RVA: 0x21EB8C0 Offset: 0x21E9EC0 VA: 0x1821EB8C0 Slot: 13
	public bool get_IsMarketable() { }

	// RVA: 0x21EB9B0 Offset: 0x21E9FB0 VA: 0x1821EB9B0 Slot: 14
	public string get_StoreTags() { }

	// RVA: 0x21EB8E0 Offset: 0x21E9EE0 VA: 0x1821EB8E0 Slot: 15
	public string get_ItemShortName() { }

	// RVA: 0x21EBA70 Offset: 0x21EA070 VA: 0x1821EBA70 Slot: 16
	public ulong get_WorkshopId() { }

	// RVA: 0x21EBA20 Offset: 0x21EA020 VA: 0x1821EBA20 Slot: 17
	public ulong get_WorkshopDownload() { }

	// RVA: 0x21EB650 Offset: 0x21E9C50 VA: 0x1821EB650 Slot: 18
	public IEnumerable<PlayerItemRecipe> GetRecipesContainingThis() { }

	// RVA: 0x21EB6E0 Offset: 0x21E9CE0 VA: 0x1821EB6E0
	private static PlayerItemRecipe SteamToPlatformRecipe(InventoryRecipe recipe) { }

	// RVA: 0x155D780 Offset: 0x155BD80 VA: 0x18155D780 Slot: 19
	public bool Equals(IPlayerItemDefinition other) { }

	// RVA: 0x21EB490 Offset: 0x21E9A90 VA: 0x1821EB490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21EB600 Offset: 0x21E9C00 VA: 0x1821EB600 Slot: 2
	public override int GetHashCode() { }

}

private sealed class SteamItemDefinition.<>c // TypeDefIndex: 5717
{	// Fields
	public static readonly SteamItemDefinition.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x21F1600 Offset: 0x21EFC00 VA: 0x1821F1600
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F10F0 Offset: 0x21EF6F0 VA: 0x1821F10F0
	internal PlayerItemRecipe.Ingredient <SteamToPlatformRecipe>b__33_0(InventoryRecipe.Ingredient i) { }

}

public class SteamPlatform : IPlatformService // TypeDefIndex: 5718
{	// Fields
	private readonly AvatarCache _avatars; // 0x10
	private readonly Dictionary<int, SteamDownloadableContent> _dlcCache; // 0x18
	private readonly Dictionary<ulong, SteamWorkshopContent> _workshopCache; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IReadOnlyList<IPlayerItemDefinition> <ItemDefinitions>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IReadOnlyList<IPlayerItem> <Items>k__BackingField; // 0x30
	private bool confiscatedLoop; // 0x38
	private readonly Dictionary<ulong, SteamPlayer> _playerCache; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <UserId>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <UserName>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Country>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Language>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Version>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Branch>k__BackingField; // 0x70
	private readonly Dictionary<string, SteamAchievement> _achievements; // 0x78
	private IPlatformHooks _hooks; // 0x80
	private bool _initialized; // 0x88

	// Properties
	public IReadOnlyList<IPlayerItemDefinition> ItemDefinitions { get; set; }
	public IReadOnlyList<IPlayerItem> Items { get; set; }
	public ulong UserId { get; set; }
	public string UserName { get; set; }
	public string Country { get; set; }
	public string Language { get; set; }
	public string Version { get; set; }
	public string Branch { get; set; }
	public IEnumerable<IPlayerInfo> Friends { get; }
	public IReadOnlyList<ServerInfo> FavoriteServers { get; }
	public uint OptimalSampleRate { get; }
	public bool VoiceRecord { get; set; }
	public bool HasVoiceData { get; }
	public bool IsValid { get; }

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xCB050 Offset: 0xCA450 VA: 0x1800CB050
	// RVA: 0x21ED9E0 Offset: 0x21EBFE0 VA: 0x1821ED9E0
	private static void LoadAvatarFromSteamAsync(ulong userId, Texture2D texture) { }

	// RVA: 0x21EC920 Offset: 0x21EAF20 VA: 0x1821EC920 Slot: 19
	public Texture2D GetAvatarTexture(ulong userId) { }

	// RVA: 0x21EC990 Offset: 0x21EAF90 VA: 0x1821EC990 Slot: 45
	public IDownloadableContent GetDownloadableContent(int appId) { }

	// RVA: 0x21ED060 Offset: 0x21EB660 VA: 0x1821ED060 Slot: 46
	public IWorkshopContent GetWorkshopContent(ulong workshopId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 36
	public IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	private void set_ItemDefinitions(IReadOnlyList<IPlayerItemDefinition> value) { }

	// RVA: 0x364A70 Offset: 0x363070 VA: 0x180364A70 Slot: 37
	public void RefreshItemDefinitions() { }

	// RVA: 0x21ECAD0 Offset: 0x21EB0D0 VA: 0x1821ECAD0 Slot: 38
	public IPlayerItemDefinition GetItemDefinition(int definitionId) { }

	// RVA: 0x21EDAC0 Offset: 0x21EC0C0 VA: 0x1821EDAC0
	private void OnDefinitionsUpdated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 39
	public IReadOnlyList<IPlayerItem> get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_Items(IReadOnlyList<IPlayerItem> value) { }

	// RVA: 0x21EDE10 Offset: 0x21EC410 VA: 0x1821EDE10 Slot: 40
	public void RefreshItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB410 Offset: 0xCA810 VA: 0x1800CB410
	// RVA: 0x21EDD40 Offset: 0x21EC340 VA: 0x1821EDD40 Slot: 41
	public Task<IPlayerInventory> RefreshAndGetItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB650 Offset: 0xCAA50 VA: 0x1800CB650
	// RVA: 0x21EC090 Offset: 0x21EA690 VA: 0x1821EC090 Slot: 42
	public Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output) { }

	[AsyncStateMachineAttribute] // RVA: 0xCB8F0 Offset: 0xCACF0 VA: 0x1800CB8F0
	// RVA: 0x21ECD00 Offset: 0x21EB300 VA: 0x1821ECD00 Slot: 43
	public Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices() { }

	// RVA: 0x21EC630 Offset: 0x21EAC30 VA: 0x1821EC630 Slot: 44
	public string FormatPrice(int price) { }

	// RVA: 0x21EDC30 Offset: 0x21EC230 VA: 0x1821EDC30
	private void OnInventoryUpdated(InventoryResult result) { }

	// RVA: 0x21EBE90 Offset: 0x21EA490 VA: 0x1821EBE90
	private void ConfiscatedItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCBBA0 Offset: 0xCAFA0 VA: 0x1800CBBA0
	// RVA: 0x21ED910 Offset: 0x21EBF10 VA: 0x1821ED910
	private Task InventoryDropAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0 Slot: 8
	public ulong get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE7190 Offset: 0xEE5790 VA: 0x180EE7190
	private void set_UserId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 9
	public string get_UserName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	private void set_UserName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 10
	public string get_Country() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	private void set_Country(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0 Slot: 11
	public string get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	private void set_Language(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0 Slot: 12
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	private void set_Version(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 13
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	private void set_Branch(string value) { }

	// RVA: 0x21EC890 Offset: 0x21EAE90 VA: 0x1821EC890 Slot: 14
	public IAuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0xCCAB0 Offset: 0xCBEB0 VA: 0x1800CCAB0
	// RVA: 0x21EC7C0 Offset: 0x21EADC0 VA: 0x1821EC7C0 Slot: 15
	public Task<IAuthTicket> GetAuthSessionTicketAsync() { }

	// RVA: 0x21EE620 Offset: 0x21ECC20 VA: 0x1821EE620 Slot: 16
	public IEnumerable<IPlayerInfo> get_Friends() { }

	// RVA: 0x21ECFD0 Offset: 0x21EB5D0 VA: 0x1821ECFD0 Slot: 17
	public IPlayerInfo GetPlayerInformation(ulong userId) { }

	[AsyncStateMachineAttribute] // RVA: 0xCCC40 Offset: 0xCC040 VA: 0x1800CCC40
	// RVA: 0x21ECEB0 Offset: 0x21EB4B0 VA: 0x1821ECEB0 Slot: 18
	public Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId) { }

	// RVA: 0x21ECDD0 Offset: 0x21EB3D0 VA: 0x1821ECDD0
	private SteamPlayer GetOrAddPlayer(ulong userId) { }

	// RVA: 0x21EC4C0 Offset: 0x21EAAC0 VA: 0x1821EC4C0 Slot: 27
	public string FilterChat(ulong userId, string message) { }

	// RVA: 0x21EC5B0 Offset: 0x21EABB0 VA: 0x1821EC5B0 Slot: 28
	public string FilterName(ulong userId, string message) { }

	// RVA: 0x21EC540 Offset: 0x21EAB40 VA: 0x1821EC540 Slot: 29
	public string FilterGeneric(string message) { }

	// RVA: 0x21EBE80 Offset: 0x21EA480 VA: 0x1821EBE80 Slot: 47
	public void ClearRichPresence() { }

	// RVA: 0x21ED050 Offset: 0x21EB650 VA: 0x1821ED050 Slot: 48
	public string GetRichPresence(string key) { }

	// RVA: 0x21EE0A0 Offset: 0x21EC6A0 VA: 0x1821EE0A0 Slot: 49
	public void SetRichPresence(string key, string value) { }

	// RVA: 0x21EC1B0 Offset: 0x21EA7B0 VA: 0x1821EC1B0 Slot: 20
	public IServerQuery CreateServerQuery(ServerQuerySet querySet) { }

	// RVA: 0x21EC310 Offset: 0x21EA910 VA: 0x1821EC310 Slot: 21
	public IServerQuery CreateServerQuery(IEnumerable<string> endpoints) { }

	// RVA: 0x21EBD80 Offset: 0x21EA380 VA: 0x1821EBD80 Slot: 22
	public void AddServerToHistory(ServerInfo server) { }

	// RVA: 0x21EDF60 Offset: 0x21EC560 VA: 0x1821EDF60 Slot: 23
	public void RemoveServerFromHistory(ServerInfo server) { }

	// RVA: 0x21EE590 Offset: 0x21ECB90 VA: 0x1821EE590 Slot: 24
	public IReadOnlyList<ServerInfo> get_FavoriteServers() { }

	// RVA: 0x21EBC80 Offset: 0x21EA280 VA: 0x1821EBC80 Slot: 25
	public void AddServerToFavorites(ServerInfo server) { }

	// RVA: 0x21EDE60 Offset: 0x21EC460 VA: 0x1821EDE60 Slot: 26
	public void RemoveServerFromFavorites(ServerInfo server) { }

	// RVA: 0x21EE260 Offset: 0x21EC860 VA: 0x1821EE260
	internal static ServerInfo ToPlatformServer(ServerInfo info) { }

	// RVA: 0x21EE310 Offset: 0x21EC910 VA: 0x1821EE310
	internal static ServerInfo ToSteamServer(ServerInfo server) { }

	// RVA: 0x21EC6D0 Offset: 0x21EACD0 VA: 0x1821EC6D0 Slot: 50
	public IAchievement GetAchievement(string key) { }

	// RVA: 0x21EE060 Offset: 0x21EC660 VA: 0x1821EE060 Slot: 51
	public void RequestCurrentStats() { }

	// RVA: 0x21ECA90 Offset: 0x21EB090 VA: 0x1821ECA90 Slot: 52
	public long GetGlobalStatInt(string key) { }

	// RVA: 0x21ED030 Offset: 0x21EB630 VA: 0x1821ED030 Slot: 53
	public long GetPlayerStatInt(string key) { }

	// RVA: 0x21EE090 Offset: 0x21EC690 VA: 0x1821EE090 Slot: 54
	public void SetPlayerStatInt(string key, long value) { }

	// RVA: 0x21ECA50 Offset: 0x21EB050 VA: 0x1821ECA50 Slot: 55
	public double GetGlobalStatFloat(string key) { }

	// RVA: 0x21ED010 Offset: 0x21EB610 VA: 0x1821ED010 Slot: 56
	public double GetPlayerStatFloat(string key) { }

	// RVA: 0x21EE070 Offset: 0x21EC670 VA: 0x1821EE070 Slot: 57
	public void SetPlayerStatFloat(string key, double value) { }

	// RVA: 0x21EE790 Offset: 0x21ECD90 VA: 0x1821EE790 Slot: 30
	public uint get_OptimalSampleRate() { }

	// RVA: 0x21EE7E0 Offset: 0x21ECDE0 VA: 0x1821EE7E0 Slot: 31
	public bool get_VoiceRecord() { }

	// RVA: 0x21EE880 Offset: 0x21ECE80 VA: 0x1821EE880 Slot: 32
	public void set_VoiceRecord(bool value) { }

	// RVA: 0x21EE6A0 Offset: 0x21ECCA0 VA: 0x1821EE6A0 Slot: 33
	public bool get_HasVoiceData() { }

	// RVA: 0x21EC940 Offset: 0x21EAF40 VA: 0x1821EC940 Slot: 34
	public byte[] GetCompressedVoiceData() { }

	// RVA: 0x21EC450 Offset: 0x21EAA50 VA: 0x1821EC450 Slot: 35
	public int DecompressVoiceData(byte[] data, MemoryStream outputStream) { }

	// RVA: 0x21EE6F0 Offset: 0x21ECCF0 VA: 0x1821EE6F0 Slot: 7
	public bool get_IsValid() { }

	// RVA: 0x21ED2A0 Offset: 0x21EB8A0 VA: 0x1821ED2A0 Slot: 4
	public bool Initialize(IPlatformHooks hooks) { }

	// RVA: 0x21EE0C0 Offset: 0x21EC6C0 VA: 0x1821EE0C0 Slot: 5
	public void Shutdown() { }

	// RVA: 0x21EE380 Offset: 0x21EC980 VA: 0x1821EE380 Slot: 6
	public void Update() { }

	// RVA: 0x21EDE20 Offset: 0x21EC420 VA: 0x1821EDE20
	private static AuthResponse RemapAuthResponse(AuthResponse response) { }

	// RVA: 0x21EC390 Offset: 0x21EA990 VA: 0x1821EC390
	private static void DebugPrintSteamCallback(CallbackType type, string content, bool isServer) { }

	// RVA: 0x21EE440 Offset: 0x21ECA40 VA: 0x1821EE440
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EE370 Offset: 0x21EC970 VA: 0x1821EE370
	private SteamPlayer <get_Friends>b__55_0(Friend f) { }

}

private struct SteamPlatform.<LoadAvatarFromSteamAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 5719
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ulong userId; // 0x28
	public Texture2D texture; // 0x30
	private TaskAwaiter<Nullable<Image>> <>u__1; // 0x38

	// Methods

	// RVA: 0x2371A0 Offset: 0x2365A0 VA: 0x1802371A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SteamPlatform.<>c // TypeDefIndex: 5720
{	// Fields
	public static readonly SteamPlatform.<>c <>9; // 0x0
	public static Func<InventoryDef, SteamItemDefinition> <>9__13_0; // 0x8
	public static Func<SteamItem, InventoryItem> <>9__20_0; // 0x10
	public static Func<InventoryDef, IPlayerItemDefinition> <>9__21_0; // 0x18
	public static Action<Exception> <>9__97_0; // 0x20

	// Methods

	// RVA: 0x21F15A0 Offset: 0x21EFBA0 VA: 0x1821F15A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F1090 Offset: 0x21EF690 VA: 0x1821F1090
	internal SteamItemDefinition <OnDefinitionsUpdated>b__13_0(InventoryDef d) { }

	// RVA: 0x21F0FA0 Offset: 0x21EF5A0 VA: 0x1821F0FA0
	internal InventoryItem <CraftItem>b__20_0(SteamItem i) { }

	// RVA: 0x21F0FD0 Offset: 0x21EF5D0 VA: 0x1821F0FD0
	internal IPlayerItemDefinition <GetItemDefinitionsWithPrices>b__21_0(InventoryDef d) { }

	// RVA: 0x21F1030 Offset: 0x21EF630 VA: 0x1821F1030
	internal void <Initialize>b__97_0(Exception e) { }

}

private struct SteamPlatform.<RefreshAndGetItems>d__19 : IAsyncStateMachine // TypeDefIndex: 5721
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInventory> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x2371B0 Offset: 0x2365B0 VA: 0x1802371B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2371C0 Offset: 0x2365C0 VA: 0x1802371C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<CraftItem>d__20 : IAsyncStateMachine // TypeDefIndex: 5722
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInventory> <>t__builder; // 0x8
	public IEnumerable<IPlayerItem> inputs; // 0x20
	public IPlayerItemDefinition output; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0x237010 Offset: 0x236410 VA: 0x180237010 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x237020 Offset: 0x236420 VA: 0x180237020 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetItemDefinitionsWithPrices>d__21 : IAsyncStateMachine // TypeDefIndex: 5723
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<IPlayerItemDefinition>> <>t__builder; // 0x8
	private TaskAwaiter<InventoryDef[]> <>u__1; // 0x20

	// Methods

	// RVA: 0x2370D0 Offset: 0x2364D0 VA: 0x1802370D0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2370E0 Offset: 0x2364E0 VA: 0x1802370E0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<InventoryDropAsync>d__26 : IAsyncStateMachine // TypeDefIndex: 5724
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__2; // 0x28

	// Methods

	// RVA: 0x237190 Offset: 0x236590 VA: 0x180237190 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetAuthSessionTicketAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 5725
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IAuthTicket> <>t__builder; // 0x8
	private TaskAwaiter<AuthTicket> <>u__1; // 0x20

	// Methods

	// RVA: 0x237070 Offset: 0x236470 VA: 0x180237070 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x237080 Offset: 0x236480 VA: 0x180237080 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetPlayerInformationAsync>d__57 : IAsyncStateMachine // TypeDefIndex: 5726
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInfo> <>t__builder; // 0x8
	public SteamPlatform <>4__this; // 0x20
	public ulong userId; // 0x28
	private SteamPlayer <player>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x237130 Offset: 0x236530 VA: 0x180237130 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x237140 Offset: 0x236540 VA: 0x180237140 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamPlayer : IPlayerInfo // TypeDefIndex: 5727
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly Friend <Value>k__BackingField; // 0x10

	// Properties
	public Friend Value { get; }
	public ulong UserId { get; }
	public string UserName { get; }
	public bool IsOnline { get; }
	public bool IsMe { get; }
	public bool IsFriend { get; }
	public bool IsPlayingThisGame { get; }
	public string ServerEndpoint { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public Friend get_Value() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	public ulong get_UserId() { }

	// RVA: 0x21EEAE0 Offset: 0x21ED0E0 VA: 0x1821EEAE0 Slot: 5
	public string get_UserName() { }

	// RVA: 0x21EE920 Offset: 0x21ECF20 VA: 0x1821EE920 Slot: 6
	public bool get_IsOnline() { }

	// RVA: 0x21EE900 Offset: 0x21ECF00 VA: 0x1821EE900 Slot: 7
	public bool get_IsMe() { }

	// RVA: 0x21EE8E0 Offset: 0x21ECEE0 VA: 0x1821EE8E0 Slot: 8
	public bool get_IsFriend() { }

	// RVA: 0x21EE940 Offset: 0x21ECF40 VA: 0x1821EE940 Slot: 9
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x21EE960 Offset: 0x21ECF60 VA: 0x1821EE960 Slot: 10
	public string get_ServerEndpoint() { }

	// RVA: 0x139EEF0 Offset: 0x139D4F0 VA: 0x18139EEF0
	public void .ctor(Friend value) { }

}

public class SteamServerQuery : IServerQuery, IDisposable // TypeDefIndex: 5728
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly ServerQuerySet <QuerySet>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Base <Query>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly IReadOnlyList<ServerInfo> <Servers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<ServerInfo> OnServerFound; // 0x28

	// Properties
	public ServerQuerySet QuerySet { get; }
	public Base Query { get; set; }
	public IReadOnlyList<ServerInfo> Servers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 4
	public ServerQuerySet get_QuerySet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Base get_Query() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Query(Base value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public IReadOnlyList<ServerInfo> get_Servers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EED80 Offset: 0x21ED380 VA: 0x1821EED80 Slot: 6
	public void add_OnServerFound(Action<ServerInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EEE20 Offset: 0x21ED420 VA: 0x1821EEE20 Slot: 7
	public void remove_OnServerFound(Action<ServerInfo> value) { }

	// RVA: 0x21EEC20 Offset: 0x21ED220 VA: 0x1821EEC20
	public void .ctor(ServerQuerySet set, Base query) { }

	// RVA: 0x21EEB20 Offset: 0x21ED120 VA: 0x1821EEB20 Slot: 10
	public void Dispose() { }

	// RVA: 0x21EEB00 Offset: 0x21ED100 VA: 0x1821EEB00 Slot: 8
	public void AddFilter(string key, string value) { }

	// RVA: 0x21EEBF0 Offset: 0x21ED1F0 VA: 0x1821EEBF0 Slot: 9
	public Task RunQueryAsync(double timeoutInSeconds) { }

}

private sealed class SteamServerQuery.<>c__DisplayClass13_0 // TypeDefIndex: 5729
{	// Fields
	public List<ServerInfo> serverList; // 0x10
	public SteamServerQuery <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F11A0 Offset: 0x21EF7A0 VA: 0x1821F11A0
	internal void <.ctor>b__0() { }

}

public static class SteamUtil // TypeDefIndex: 5730
{	// Fields
	private static string _betaNameFull; // 0x0
	private static string _betaNameType; // 0x8

	// Properties
	public static string betaName { get; }
	public static string betaBranch { get; }

	// Methods

	// RVA: 0x21EF350 Offset: 0x21ED950 VA: 0x1821EF350
	public static string get_betaName() { }

	// RVA: 0x21EF300 Offset: 0x21ED900 VA: 0x1821EF300
	public static string get_betaBranch() { }

	// RVA: 0x21EEEC0 Offset: 0x21ED4C0 VA: 0x1821EEEC0
	private static string GetBetaName(bool full) { }

	// RVA: 0x21EF290 Offset: 0x21ED890 VA: 0x1821EF290
	private static void .cctor() { }

}

public class SteamWorkshopContent : IWorkshopContent // TypeDefIndex: 5731
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly Item <Value>k__BackingField; // 0x10

	// Properties
	public Item Value { get; }
	public ulong WorkshopId { get; }
	public string Title { get; }
	public string Description { get; }
	public IEnumerable<string> Tags { get; }
	public string Url { get; }
	public string PreviewImageUrl { get; }
	public ulong OwnerId { get; }
	public IPlayerInfo Owner { get; }
	public bool IsInstalled { get; }
	public bool IsDownloadPending { get; }
	public bool IsDownloading { get; }
	public string Directory { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EFCD0 Offset: 0x21EE2D0 VA: 0x1821EFCD0
	public Item get_Value() { }

	// RVA: 0x21EFD60 Offset: 0x21EE360 VA: 0x1821EFD60 Slot: 4
	public ulong get_WorkshopId() { }

	// RVA: 0x21EFB70 Offset: 0x21EE170 VA: 0x1821EFB70 Slot: 5
	public string get_Title() { }

	// RVA: 0x21EF500 Offset: 0x21EDB00 VA: 0x1821EF500 Slot: 6
	public string get_Description() { }

	// RVA: 0x21EFAC0 Offset: 0x21EE0C0 VA: 0x1821EFAC0 Slot: 7
	public IEnumerable<string> get_Tags() { }

	// RVA: 0x21EFC20 Offset: 0x21EE220 VA: 0x1821EFC20 Slot: 8
	public string get_Url() { }

	// RVA: 0x21EFA10 Offset: 0x21EE010 VA: 0x1821EFA10 Slot: 9
	public string get_PreviewImageUrl() { }

	// RVA: 0x21EF870 Offset: 0x21EDE70 VA: 0x1821EF870 Slot: 10
	public ulong get_OwnerId() { }

	// RVA: 0x21EF920 Offset: 0x21EDF20 VA: 0x1821EF920 Slot: 11
	public IPlayerInfo get_Owner() { }

	// RVA: 0x21EF7C0 Offset: 0x21EDDC0 VA: 0x1821EF7C0 Slot: 12
	public bool get_IsInstalled() { }

	// RVA: 0x21EF660 Offset: 0x21EDC60 VA: 0x1821EF660 Slot: 13
	public bool get_IsDownloadPending() { }

	// RVA: 0x21EF710 Offset: 0x21EDD10 VA: 0x1821EF710 Slot: 14
	public bool get_IsDownloading() { }

	// RVA: 0x21EF5B0 Offset: 0x21EDBB0 VA: 0x1821EF5B0 Slot: 15
	public string get_Directory() { }

	// RVA: 0x21EF450 Offset: 0x21EDA50 VA: 0x1821EF450
	public void .ctor(Item item) { }

	// RVA: 0x21EF3A0 Offset: 0x21ED9A0 VA: 0x1821EF3A0 Slot: 16
	public bool Download() { }

}

public static class SteamNetworking // TypeDefIndex: 7362
{
// Namespace: Facepunch.Network
[ConsoleSystem.Factory] // RVA: 0x80DB0 Offset: 0x801B0 VA: 0x180080DB0
public static class SteamNetworking // TypeDefIndex: 7362
	// Properties
	[ClientVar] // RVA: 0x9B510 Offset: 0x9A910 VA: 0x18009B510
	[ServerVar] // RVA: 0x9B510 Offset: 0x9A910 VA: 0x18009B510
	public static int steamnetdebug { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamnetdebug_ackrtt { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamnetdebug_packetdecode { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamnetdebug_message { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamnetdebug_packetgaps { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamnetdebug_p2prendezvous { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamnetdebug_sdrrelaypings { get; set; }
	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	public static int steamconnectiontimeout { get; set; }

	// Methods

	// RVA: 0x22DAA20 Offset: 0x22D9020 VA: 0x1822DAA20
	public static SendType ToSteamSendType(SendMethod method, Priority priority) { }

	// RVA: 0x22DAA00 Offset: 0x22D9000 VA: 0x1822DAA00
	public static ushort ToSteamLaneIndexServer(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22DA9F0 Offset: 0x22D8FF0 VA: 0x1822DA9F0
	public static ushort ToSteamLaneIndexClient(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22DA890 Offset: 0x22D8E90 VA: 0x1822DA890
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x22DA8E0 Offset: 0x22D8EE0 VA: 0x1822DA8E0
	public static void SetDebugFunction() { }

	// RVA: 0x22DA960 Offset: 0x22D8F60 VA: 0x1822DA960
	private static void SteamNetworkingUtils_OnDebugOutput(NetDebugOutput type, string str) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x22DAFB0 Offset: 0x22D95B0 VA: 0x1822DAFB0
	public static string steamstatus() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x22DA890 Offset: 0x22D8E90 VA: 0x1822DA890
	public static void steamrelayinit() { }

	// RVA: 0x22DAB00 Offset: 0x22D9100 VA: 0x1822DAB00
	public static int get_steamnetdebug() { }

	// RVA: 0x22DADD0 Offset: 0x22D93D0 VA: 0x1822DADD0
	public static void set_steamnetdebug(int value) { }

	// RVA: 0x22DAAB0 Offset: 0x22D90B0 VA: 0x1822DAAB0
	public static int get_steamnetdebug_ackrtt() { }

	// RVA: 0x22DAD80 Offset: 0x22D9380 VA: 0x1822DAD80
	public static void set_steamnetdebug_ackrtt(int value) { }

	// RVA: 0x22DAC40 Offset: 0x22D9240 VA: 0x1822DAC40
	public static int get_steamnetdebug_packetdecode() { }

	// RVA: 0x22DAEC0 Offset: 0x22D94C0 VA: 0x1822DAEC0
	public static void set_steamnetdebug_packetdecode(int value) { }

	// RVA: 0x22DABA0 Offset: 0x22D91A0 VA: 0x1822DABA0
	public static int get_steamnetdebug_message() { }

	// RVA: 0x22DAE20 Offset: 0x22D9420 VA: 0x1822DAE20
	public static void set_steamnetdebug_message(int value) { }

	// RVA: 0x22DAC90 Offset: 0x22D9290 VA: 0x1822DAC90
	public static int get_steamnetdebug_packetgaps() { }

	// RVA: 0x22DAF10 Offset: 0x22D9510 VA: 0x1822DAF10
	public static void set_steamnetdebug_packetgaps(int value) { }

	// RVA: 0x22DABF0 Offset: 0x22D91F0 VA: 0x1822DABF0
	public static int get_steamnetdebug_p2prendezvous() { }

	// RVA: 0x22DAE70 Offset: 0x22D9470 VA: 0x1822DAE70
	public static void set_steamnetdebug_p2prendezvous(int value) { }

	// RVA: 0x22DACE0 Offset: 0x22D92E0 VA: 0x1822DACE0
	public static int get_steamnetdebug_sdrrelaypings() { }

	// RVA: 0x22DAF60 Offset: 0x22D9560 VA: 0x1822DAF60
	public static void set_steamnetdebug_sdrrelaypings(int value) { }

	// RVA: 0x22DAA60 Offset: 0x22D9060 VA: 0x1822DAA60
	public static int get_steamconnectiontimeout() { }

	// RVA: 0x22DAD30 Offset: 0x22D9330 VA: 0x1822DAD30
	public static void set_steamconnectiontimeout(int value) { }

}

public class SteamNetworking.Client : Client, IConnectionManager // TypeDefIndex: 7363
{	// Fields
	private ConnectionManager manager; // 0x70
	private const int bufferSize = 32;

	// Methods

	// RVA: 0x22CD0B0 Offset: 0x22CB6B0 VA: 0x1822CD0B0 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22D85F0 Offset: 0x22D6BF0 VA: 0x1822D85F0 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22D8750 Offset: 0x22D6D50 VA: 0x1822D8750 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22D88C0 Offset: 0x22D6EC0 VA: 0x1822D88C0 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22D8C80 Offset: 0x22D7280 VA: 0x1822D8C80 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	private void Steamworks.IConnectionManager.OnConnecting(ConnectionInfo info) { }

	// RVA: 0x22D8D90 Offset: 0x22D7390 VA: 0x1822D8D90 Slot: 14
	private void Steamworks.IConnectionManager.OnConnected(ConnectionInfo info) { }

	// RVA: 0x22D8DC0 Offset: 0x22D73C0 VA: 0x1822D8DC0 Slot: 15
	private void Steamworks.IConnectionManager.OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x22D8E40 Offset: 0x22D7440 VA: 0x1822D8E40 Slot: 16
	private void Steamworks.IConnectionManager.OnMessage(IntPtr data, int datasize, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D8A40 Offset: 0x22D7040 VA: 0x1822D8A40 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D8AC0 Offset: 0x22D70C0 VA: 0x1822D8AC0 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22D8B20 Offset: 0x22D7120 VA: 0x1822D8B20 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22D9440 Offset: 0x22D7A40 VA: 0x1822D9440
	public void .ctor() { }

}

public class SteamNetworking.Server : Server, ISocketManager // TypeDefIndex: 7364
{	// Fields
	private SocketManager manager; // 0x68
	private bool relay; // 0x70
	private const int bufferSize = 32;
	private int[] lanePriorities; // 0x78
	private ushort[] laneWeights; // 0x80

	// Properties
	public override string ProtocolId { get; }

	// Methods

	// RVA: 0x22DA860 Offset: 0x22D8E60 VA: 0x1822DA860 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x22DA740 Offset: 0x22D8D40 VA: 0x1822DA740
	public void .ctor(bool enableSteamDatagramRelay) { }

	// RVA: 0xEE7A80 Offset: 0xEE6080 VA: 0x180EE7A80 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22DA2A0 Offset: 0x22D88A0 VA: 0x1822DA2A0 Slot: 10
	public override bool Start() { }

	// RVA: 0x22DA670 Offset: 0x22D8C70 VA: 0x1822DA670 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22D9610 Offset: 0x22D7C10 VA: 0x1822D9610 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22D98F0 Offset: 0x22D7EF0 VA: 0x1822D98F0 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22D94A0 Offset: 0x22D7AA0 VA: 0x1822D94A0 Slot: 12
	public override void Cycle() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22D9F50 Offset: 0x22D8550 VA: 0x1822D9F50 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22DA130 Offset: 0x22D8730 VA: 0x1822DA130
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22D9C10 Offset: 0x22D8210 VA: 0x1822D9C10 Slot: 19
	public void OnConnecting(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9AE0 Offset: 0x22D80E0 VA: 0x1822D9AE0 Slot: 20
	public void OnConnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9C30 Offset: 0x22D8230 VA: 0x1822D9C30 Slot: 21
	public void OnDisconnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9CB0 Offset: 0x22D82B0 VA: 0x1822D9CB0 Slot: 22
	public void OnMessage(Connection cn, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D96F0 Offset: 0x22D7CF0 VA: 0x1822D96F0 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D96A0 Offset: 0x22D7CA0 VA: 0x1822D96A0 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22D9750 Offset: 0x22D7D50 VA: 0x1822D9750 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

private sealed class SteamNetworking.Server.<>c // TypeDefIndex: 7365
{	// Fields
	public static readonly SteamNetworking.Server.<>c <>9; // 0x0
	public static Action<NetAddress> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x22DB2A0 Offset: 0x22D98A0 VA: 0x1822DB2A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22DB210 Offset: 0x22D9810 VA: 0x1822DB210
	internal void <Start>b__9_0(NetAddress fakeAddressCallback) { }

}

public class SteamInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8653
{	// Fields
	private IPlayerItem[] Items; // 0x20

	// Methods

	// RVA: 0x7BA800 Offset: 0x7B8E00 VA: 0x1807BA800 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7BA6D0 Offset: 0x7B8CD0 VA: 0x1807BA6D0
	public bool HasItem(int itemid) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7BA420 Offset: 0x7B8A20 VA: 0x1807BA420
	private void ClientUpdateSteamInventory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7BA4C0 Offset: 0x7B8AC0 VA: 0x1807BA4C0
	public void ClientUpdate(IPlayerInventory result) { }

	// RVA: 0x7BACC0 Offset: 0x7B92C0 VA: 0x1807BACC0
	public void .ctor() { }

}

public class SteamInventoryGen : MonoBehaviour // TypeDefIndex: 9324
{	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class SteamDLCItem : ScriptableObject // TypeDefIndex: 10761
{	// Fields
	public int id; // 0x18
	public Translate.Phrase dlcName; // 0x20
	public int dlcAppID; // 0x28
	public bool bypassLicenseCheck; // 0x2C

	// Methods

	// RVA: 0xA8EC60 Offset: 0xA8D260 VA: 0x180A8EC60
	public bool IsInstalled() { }

	// RVA: 0xA8EAC0 Offset: 0xA8D0C0 VA: 0x180A8EAC0
	public bool CanUse(BasePlayer player) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public class SteamInventoryCategory : ScriptableObject // TypeDefIndex: 10762
{	// Fields
	[HeaderAttribute] // RVA: 0x7AE30 Offset: 0x7A230 VA: 0x18007AE30
	public bool canBeSoldToOtherUsers; // 0x18
	public bool canBeTradedWithOtherUsers; // 0x19
	public bool isCommodity; // 0x1A
	public SteamInventoryCategory.Price price; // 0x1C
	public SteamInventoryCategory.DropChance dropChance; // 0x20
	public bool CanBeInCrates; // 0x24

	// Methods

	// RVA: 0x7BA360 Offset: 0x7B8960 VA: 0x1807BA360
	public void .ctor() { }

}

public enum SteamInventoryCategory.Price // TypeDefIndex: 10763
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryCategory.Price CannotBuy = 0;
	public const SteamInventoryCategory.Price VLV25 = 1;
	public const SteamInventoryCategory.Price VLV50 = 2;
	public const SteamInventoryCategory.Price VLV75 = 3;
	public const SteamInventoryCategory.Price VLV100 = 4;
	public const SteamInventoryCategory.Price VLV150 = 5;
	public const SteamInventoryCategory.Price VLV200 = 6;
	public const SteamInventoryCategory.Price VLV250 = 7;
	public const SteamInventoryCategory.Price VLV300 = 8;
	public const SteamInventoryCategory.Price VLV350 = 9;
	public const SteamInventoryCategory.Price VLV400 = 10;
	public const SteamInventoryCategory.Price VLV450 = 11;
	public const SteamInventoryCategory.Price VLV500 = 12;
	public const SteamInventoryCategory.Price VLV550 = 13;
	public const SteamInventoryCategory.Price VLV600 = 14;
	public const SteamInventoryCategory.Price VLV650 = 15;
	public const SteamInventoryCategory.Price VLV700 = 16;
	public const SteamInventoryCategory.Price VLV750 = 17;
	public const SteamInventoryCategory.Price VLV800 = 18;
	public const SteamInventoryCategory.Price VLV850 = 19;
	public const SteamInventoryCategory.Price VLV900 = 20;
	public const SteamInventoryCategory.Price VLV950 = 21;
	public const SteamInventoryCategory.Price VLV1000 = 22;
	public const SteamInventoryCategory.Price VLV1100 = 23;
	public const SteamInventoryCategory.Price VLV1200 = 24;
	public const SteamInventoryCategory.Price VLV1300 = 25;
	public const SteamInventoryCategory.Price VLV1400 = 26;
	public const SteamInventoryCategory.Price VLV1500 = 27;
	public const SteamInventoryCategory.Price VLV1600 = 28;
	public const SteamInventoryCategory.Price VLV1700 = 29;
	public const SteamInventoryCategory.Price VLV1800 = 30;
	public const SteamInventoryCategory.Price VLV1900 = 31;
	public const SteamInventoryCategory.Price VLV2000 = 32;
	public const SteamInventoryCategory.Price VLV2500 = 33;
	public const SteamInventoryCategory.Price VLV3000 = 34;
	public const SteamInventoryCategory.Price VLV3500 = 35;
	public const SteamInventoryCategory.Price VLV4000 = 36;
	public const SteamInventoryCategory.Price VLV4500 = 37;
	public const SteamInventoryCategory.Price VLV5000 = 38;
	public const SteamInventoryCategory.Price VLV6000 = 39;
	public const SteamInventoryCategory.Price VLV7000 = 40;
	public const SteamInventoryCategory.Price VLV8000 = 41;
	public const SteamInventoryCategory.Price VLV9000 = 42;
	public const SteamInventoryCategory.Price VLV10000 = 43;

}

public enum SteamInventoryCategory.DropChance // TypeDefIndex: 10764
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryCategory.DropChance NeverDrop = 0;
	public const SteamInventoryCategory.DropChance VeryRare = 1;
	public const SteamInventoryCategory.DropChance Rare = 2;
	public const SteamInventoryCategory.DropChance Common = 3;
	public const SteamInventoryCategory.DropChance VeryCommon = 4;
	public const SteamInventoryCategory.DropChance ExtremelyRare = 5;

}

public class SteamInventoryItem : ScriptableObject // TypeDefIndex: 10765
{	// Fields
	public int id; // 0x18
	public Sprite icon; // 0x20
	public Translate.Phrase displayName; // 0x28
	public Translate.Phrase displayDescription; // 0x30
	[HeaderAttribute] // RVA: 0x7AE30 Offset: 0x7A230 VA: 0x18007AE30
	public SteamInventoryItem.Category category; // 0x38
	public SteamInventoryItem.SubCategory subcategory; // 0x3C
	public SteamInventoryCategory steamCategory; // 0x40
	public bool isLimitedTimeOffer; // 0x48
	[TooltipAttribute] // RVA: 0x7AFC0 Offset: 0x7A3C0 VA: 0x18007AFC0
	public bool PreventBreakingDown; // 0x49
	[HeaderAttribute] // RVA: 0x7B3E0 Offset: 0x7A7E0 VA: 0x18007B3E0
	public string itemname; // 0x50
	public ulong workshopID; // 0x58
	public SteamDLCItem DlcItem; // 0x60
	[TooltipAttribute] // RVA: 0x7B4E0 Offset: 0x7A8E0 VA: 0x18007B4E0
	public bool forceCraftableItemDesc; // 0x68

	// Properties
	public ItemDefinition itemDefinition { get; }

	// Methods

	// RVA: 0x7BA410 Offset: 0x7B8A10 VA: 0x1807BA410
	public ItemDefinition get_itemDefinition() { }

	// RVA: 0x7BA370 Offset: 0x7B8970 VA: 0x1807BA370 Slot: 4
	public virtual bool HasUnlocked(ulong playerId) { }

	// RVA: 0x7BA400 Offset: 0x7B8A00 VA: 0x1807BA400
	public void .ctor() { }

}

public enum SteamInventoryItem.Category // TypeDefIndex: 10766
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryItem.Category None = 0;
	public const SteamInventoryItem.Category Clothing = 1;
	public const SteamInventoryItem.Category Weapon = 2;
	public const SteamInventoryItem.Category Decoration = 3;
	public const SteamInventoryItem.Category Crate = 4;
	public const SteamInventoryItem.Category Resource = 5;

}

public enum SteamInventoryItem.SubCategory // TypeDefIndex: 10767
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryItem.SubCategory None = 0;
	public const SteamInventoryItem.SubCategory Shirt = 1;
	public const SteamInventoryItem.SubCategory Pants = 2;
	public const SteamInventoryItem.SubCategory Jacket = 3;
	public const SteamInventoryItem.SubCategory Hat = 4;
	public const SteamInventoryItem.SubCategory Mask = 5;
	public const SteamInventoryItem.SubCategory Footwear = 6;
	public const SteamInventoryItem.SubCategory Weapon = 7;
	public const SteamInventoryItem.SubCategory Misc = 8;
	public const SteamInventoryItem.SubCategory Crate = 9;
	public const SteamInventoryItem.SubCategory Resource = 10;
	public const SteamInventoryItem.SubCategory CrateUncraftable = 11;

}

public class SteamClientWrapper : SingletonComponent<SteamClientWrapper> // TypeDefIndex: 10777
{	// Methods

	// RVA: 0xA8E300 Offset: 0xA8C900 VA: 0x180A8E300
	public Texture GetAvatarTexture(ulong steamid) { }

	// RVA: 0xA8E510 Offset: 0xA8CB10 VA: 0x180A8E510
	public string GetUserName(ulong steamid) { }

	// RVA: 0xA8E780 Offset: 0xA8CD80 VA: 0x180A8E780
	public static void SetPlayerPresence(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA8E220 Offset: 0xA8C820 VA: 0x180A8E220
	public static void ClearPlayerPresence() { }

	// RVA: 0xA8E450 Offset: 0xA8CA50 VA: 0x180A8E450
	private static string GetLocalizationKey(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA8E600 Offset: 0xA8CC00 VA: 0x180A8E600
	public static void Init() { }

	// RVA: 0xA8E150 Offset: 0xA8C750 VA: 0x180A8E150 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA8E9F0 Offset: 0xA8CFF0 VA: 0x180A8E9F0
	public void Update() { }

	// RVA: 0xA8E710 Offset: 0xA8CD10 VA: 0x180A8E710
	public void OnDisable() { }

	// RVA: 0xA8EA60 Offset: 0xA8D060 VA: 0x180A8EA60
	public void .ctor() { }

}

public enum SteamClientWrapper.RichPresenceState // TypeDefIndex: 10778
{	// Fields
	public int value__; // 0x0
	public const SteamClientWrapper.RichPresenceState MainMenu = 0;
	public const SteamClientWrapper.RichPresenceState Wilderness = 1;
	public const SteamClientWrapper.RichPresenceState Monument = 2;

}

public static class SteamNewsSource // TypeDefIndex: 11132
{	// Fields
	public static SteamNewsSource.Story[] Stories; // 0x30A7

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x992C0 Offset: 0x986C0 VA: 0x1800992C0
	// RVA: 0x7BAD00 Offset: 0x7B9300 VA: 0x1807BAD00
	public static IEnumerator GetStories() { }

}

public struct SteamNewsSource.Story // TypeDefIndex: 11133
{	// Fields
	public string name; // 0x0
	public string url; // 0x8
	public int date; // 0x10
	public string text; // 0x18
	public string author; // 0x20

}

private sealed class SteamNewsSource.<GetStories>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11134
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private WWW <www>5__2; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7D2E00 Offset: 0x7D1400 VA: 0x1807D2E00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D32C0 Offset: 0x7D18C0 VA: 0x1807D32C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class SteamFriendsList : MonoBehaviour // TypeDefIndex: 11221
{	// Fields
	public RectTransform targetPanel; // 0x18
	public SteamUserButton userButton; // 0x20
	public bool IncludeFriendsList; // 0x28
	public bool IncludeRecentlySeen; // 0x29
	public bool IncludeLastAttacker; // 0x2A
	public bool IncludeRecentlyPlayedWith; // 0x2B
	public bool ShowTeamFirst; // 0x2C
	public bool HideSteamIdsInStreamerMode; // 0x2D
	public bool RefreshOnEnable; // 0x2E
	public SteamFriendsList.onFriendSelectedEvent onFriendSelected; // 0x30
	public Func<ulong, bool> shouldShowPlayer; // 0x38
	private List<IPlayerInfo> playerList; // 0x40
	internal static List<ulong> SeenList; // 0x0

	// Methods

	// RVA: 0xA8F8B0 Offset: 0xA8DEB0 VA: 0x180A8F8B0
	private void OnEnable() { }

	// RVA: 0xA8FC00 Offset: 0xA8E200 VA: 0x180A8FC00
	public void Refresh() { }

	// RVA: 0xA8EDD0 Offset: 0xA8D3D0 VA: 0x180A8EDD0
	public void AddPlayer(IPlayerInfo f) { }

	// RVA: 0xA8F8C0 Offset: 0xA8DEC0 VA: 0x180A8F8C0
	public int Priority(IPlayerInfo f) { }

	// RVA: 0xA8F420 Offset: 0xA8DA20 VA: 0x180A8F420
	public void FilterSearch(string name) { }

	// RVA: 0xA8EEE0 Offset: 0xA8D4E0 VA: 0x180A8EEE0
	public void AddToPanel(IEnumerable<IPlayerInfo> list, int count = -1) { }

	// RVA: 0xA8F500 Offset: 0xA8DB00 VA: 0x180A8F500
	private void FriendSelected(ulong steamid, string steamName) { }

	// RVA: 0xA8F570 Offset: 0xA8DB70 VA: 0x180A8F570
	public static void JustSeen(ulong steamid) { }

	// RVA: 0xA90670 Offset: 0xA8EC70 VA: 0x180A90670
	public void .ctor() { }

	// RVA: 0xA90610 Offset: 0xA8EC10 VA: 0x180A90610
	private static void .cctor() { }

}

public class SteamFriendsList.onFriendSelectedEvent : UnityEvent<ulong, string> // TypeDefIndex: 11222
{	// Methods

	// RVA: 0x7D3BB0 Offset: 0x7D21B0 VA: 0x1807D3BB0
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass15_0 // TypeDefIndex: 11223
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3390 Offset: 0x7D1990 VA: 0x1807D3390
	internal bool <AddPlayer>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass16_0 // TypeDefIndex: 11224
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3410 Offset: 0x7D1A10 VA: 0x1807D3410
	internal bool <Priority>b__0(PlayerTeam.TeamMember p) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass17_0 // TypeDefIndex: 11225
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3480 Offset: 0x7D1A80 VA: 0x1807D3480
	internal bool <FilterSearch>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass18_0 // TypeDefIndex: 11226
{	// Fields
	public IPlayerInfo player; // 0x10
	public SteamFriendsList <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass18_1 // TypeDefIndex: 11227
{	// Fields
	public ulong steamid; // 0x10
	public SteamFriendsList.<>c__DisplayClass18_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3580 Offset: 0x7D1B80 VA: 0x1807D3580
	internal void <AddToPanel>b__1() { }

}

private sealed class SteamFriendsList.<>c // TypeDefIndex: 11228
{	// Fields
	public static readonly SteamFriendsList.<>c <>9; // 0x0
	public static Func<IPlayerInfo, string> <>9__18_0; // 0x8

	// Methods

	// RVA: 0x7D3710 Offset: 0x7D1D10 VA: 0x1807D3710
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7D3310 Offset: 0x7D1910 VA: 0x1807D3310
	internal string <AddToPanel>b__18_0(IPlayerInfo x) { }

}

public class SteamUserButton : MonoBehaviour // TypeDefIndex: 11229
{	// Fields
	public RustText steamName; // 0x18
	public RustText steamInfo; // 0x20
	public RawImage avatar; // 0x28
	public Color textColorInGame; // 0x30
	public Color textColorOnline; // 0x40
	public Color textColorNormal; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <SteamId>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Username>k__BackingField; // 0x68

	// Properties
	public ulong SteamId { get; set; }
	public string Username { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6E6E10 Offset: 0x6E5410 VA: 0x1806E6E10
	private void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519DE0 Offset: 0x5183E0 VA: 0x180519DE0
	private void set_Username(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2590 Offset: 0xA1990 VA: 0x1800A2590
	// RVA: 0x7BAD50 Offset: 0x7B9350 VA: 0x1807BAD50
	public void UpdateFromUser(ulong steamid, bool isInThisGame, bool isOnline, bool hideSteamId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private struct SteamUserButton.<UpdateFromUser>d__14 : IAsyncStateMachine // TypeDefIndex: 11230
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SteamUserButton <>4__this; // 0x28
	public ulong steamid; // 0x30
	public bool hideSteamId; // 0x38
	public bool isInThisGame; // 0x39
	public bool isOnline; // 0x3A
	private TaskAwaiter<IPlayerInfo> <>u__1; // 0x40

	// Methods

	// RVA: 0xF69B0 Offset: 0xF5DB0 VA: 0x1800F69B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Steam // TypeDefIndex: 11964
{	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x36B8F0 Offset: 0x369EF0 VA: 0x18036B8F0
	public static object achievements() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x36B8B0 Offset: 0x369EB0 VA: 0x18036B8B0
	public static void ResetStats() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class Steam.<>c // TypeDefIndex: 11965
{	// Fields
	public static readonly Steam.<>c <>9; // 0x0
	public static Func<Achievement, <>f__AnonymousType0<string, string, bool>> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x36D560 Offset: 0x36BB60 VA: 0x18036D560
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x36D3C0 Offset: 0x36B9C0 VA: 0x18036D3C0
	internal <>f__AnonymousType0<string, string, bool> <achievements>b__0_0(Achievement x) { }

}

public class SteamInventoryCrafting : MonoBehaviour // TypeDefIndex: 12050
{	// Fields
	public GameObject Container; // 0x18
	public Button ConvertToItem; // 0x20
	public TextMeshProUGUI WoodAmount; // 0x28
	public TextMeshProUGUI ClothAmount; // 0x30
	public TextMeshProUGUI MetalAmount; // 0x38
	public int SelectedCount; // 0x40
	public TextMeshProUGUI InfoText; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IPlayerItemDefinition <ResultItem>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Coroutine <MarketCoroutine>k__BackingField; // 0x58
	public SteamInventoryCrateOpen CraftModal; // 0x60
	public GameObject CraftingContainer; // 0x68
	public GameObject CraftingButton; // 0x70
	public SteamInventoryNewItem NewItemModal; // 0x78
	private static readonly Regex priceRegex; // 0x0
	private readonly HttpClient httpClient; // 0x80
	private readonly Dictionary<int, Task<SteamInventoryCrafting.MarketPrice>> priceCache; // 0x88

	// Properties
	public IPlayerItemDefinition ResultItem { get; set; }
	public Coroutine MarketCoroutine { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public IPlayerItemDefinition get_ResultItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF820 Offset: 0x4CDE20 VA: 0x1804CF820
	private void set_ResultItem(IPlayerItemDefinition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public Coroutine get_MarketCoroutine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	private void set_MarketCoroutine(Coroutine value) { }

	// RVA: 0x4CED10 Offset: 0x4CD310 VA: 0x1804CED10
	public void OnEnable() { }

	// RVA: 0x4CDA80 Offset: 0x4CC080 VA: 0x1804CDA80
	private void FillCraftingContainer() { }

	// RVA: 0x4CF6E0 Offset: 0x4CDCE0 VA: 0x1804CF6E0
	public void Update() { }

	// RVA: 0x4CF2E0 Offset: 0x4CD8E0 VA: 0x1804CF2E0
	private void UpdateImpl(bool force) { }

	// RVA: 0x4CE210 Offset: 0x4CC810 VA: 0x1804CE210
	private void OnChanged(SteamInventoryItem[] items) { }

	// RVA: 0x4CF510 Offset: 0x4CDB10 VA: 0x1804CF510
	private void UpdateInfoText(int length, IPlayerItemDefinition definition, Nullable<double> totalValue) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1AF0 Offset: 0xD0EF0 VA: 0x1800D1AF0
	// RVA: 0x4CE060 Offset: 0x4CC660 VA: 0x1804CE060
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPrice(IPlayerItemDefinition definition) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1D70 Offset: 0xD1170 VA: 0x1800D1D70
	// RVA: 0x4CDF40 Offset: 0x4CC540 VA: 0x1804CDF40
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPriceImpl(IPlayerItemDefinition definition) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1E50 Offset: 0xD1250 VA: 0x1800D1E50
	// RVA: 0x4CE180 Offset: 0x4CC780 VA: 0x1804CE180
	private IEnumerator LoadMarketPrice(IPlayerItemDefinition definition) { }

	// RVA: 0x4CD640 Offset: 0x4CBC40 VA: 0x1804CD640
	public void DoExchange() { }

	[AsyncStateMachineAttribute] // RVA: 0xD20C0 Offset: 0xD14C0 VA: 0x1800D20C0
	// RVA: 0x4CD960 Offset: 0x4CBF60 VA: 0x1804CD960
	private Task ExchangeItems(SteamInventoryItem[] selected) { }

	// RVA: 0x4CEDA0 Offset: 0x4CD3A0 VA: 0x1804CEDA0
	public void OnRefreshed(IReadOnlyCollection<IPlayerItem> items) { }

	// RVA: 0x4CED20 Offset: 0x4CD320 VA: 0x1804CED20
	public void OnManualRefresh() { }

	// RVA: 0x4CF750 Offset: 0x4CDD50 VA: 0x1804CF750
	public void .ctor() { }

	// RVA: 0x4CF6F0 Offset: 0x4CDCF0 VA: 0x1804CF6F0
	private static void .cctor() { }

}

public class SteamInventoryCrafting.MarketPrice // TypeDefIndex: 12051
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <success>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <volume>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <lowest_price>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private double <lowest_price_value>k__BackingField; // 0x28

	// Properties
	public bool success { get; set; }
	public ulong volume { get; set; }
	public string lowest_price { get; set; }
	public double lowest_price_value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_success() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_success(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ulong get_volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFD0 Offset: 0x4995D0 VA: 0x18049AFD0
	public void set_volume(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_lowest_price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_lowest_price(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF80 Offset: 0x499580 VA: 0x18049AF80
	public double get_lowest_price_value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFB0 Offset: 0x4995B0 VA: 0x18049AFB0
	public void set_lowest_price_value(double value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass20_0 // TypeDefIndex: 12052
{	// Fields
	public IPlayerItemDefinition x; // 0x10
	public SteamInventoryCrafting <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3A40 Offset: 0x4B2040 VA: 0x1804B3A40
	internal void <FillCraftingContainer>b__1() { }

}

private sealed class SteamInventoryCrafting.<>c // TypeDefIndex: 12053
{	// Fields
	public static readonly SteamInventoryCrafting.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, bool> <>9__20_0; // 0x8
	public static Func<Toggle, bool> <>9__22_0; // 0x10
	public static Func<Toggle, SteamInventoryItem> <>9__22_1; // 0x18
	public static Func<SteamInventoryItem, bool> <>9__23_0; // 0x20
	public static Func<SteamInventoryItem, bool> <>9__23_1; // 0x28
	public static Func<SteamInventoryItem, bool> <>9__23_2; // 0x30
	public static Func<SteamInventoryItem, bool> <>9__23_3; // 0x38
	public static Func<SteamInventoryItem, bool> <>9__23_4; // 0x40
	public static Func<SteamInventoryItem, IEnumerable<PlayerItemRecipe>> <>9__23_5; // 0x48
	public static Func<PlayerItemRecipe, IPlayerItemDefinition> <>9__23_6; // 0x50
	public static Func<Toggle, bool> <>9__32_0; // 0x58
	public static Func<Toggle, SteamInventoryItem> <>9__32_1; // 0x60
	public static Func<IPlayerItem, bool> <>9__34_0; // 0x68
	public static Func<IPlayerItem, int> <>9__34_1; // 0x70
	public static Func<IPlayerItem, bool> <>9__34_2; // 0x78
	public static Func<IPlayerItem, int> <>9__34_3; // 0x80
	public static Func<IPlayerItem, bool> <>9__34_4; // 0x88
	public static Func<IPlayerItem, int> <>9__34_5; // 0x90

	// Methods

	// RVA: 0x4D2610 Offset: 0x4D0C10 VA: 0x1804D2610
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <FillCraftingContainer>b__20_0(IPlayerItemDefinition x) { }

	// RVA: 0x4D1980 Offset: 0x4CFF80 VA: 0x1804D1980
	internal bool <UpdateImpl>b__22_0(Toggle x) { }

	// RVA: 0x4D2060 Offset: 0x4D0660 VA: 0x1804D2060
	internal SteamInventoryItem <UpdateImpl>b__22_1(Toggle x) { }

	// RVA: 0x4D1A50 Offset: 0x4D0050 VA: 0x1804D1A50
	internal bool <OnChanged>b__23_0(SteamInventoryItem x) { }

	// RVA: 0x4D1A80 Offset: 0x4D0080 VA: 0x1804D1A80
	internal bool <OnChanged>b__23_1(SteamInventoryItem x) { }

	// RVA: 0x4D1A50 Offset: 0x4D0050 VA: 0x1804D1A50
	internal bool <OnChanged>b__23_2(SteamInventoryItem x) { }

	// RVA: 0x4D1AF0 Offset: 0x4D00F0 VA: 0x1804D1AF0
	internal bool <OnChanged>b__23_3(SteamInventoryItem x) { }

	// RVA: 0x4D1A50 Offset: 0x4D0050 VA: 0x1804D1A50
	internal bool <OnChanged>b__23_4(SteamInventoryItem x) { }

	// RVA: 0x4D1B60 Offset: 0x4D0160 VA: 0x1804D1B60
	internal IEnumerable<PlayerItemRecipe> <OnChanged>b__23_5(SteamInventoryItem x) { }

	// RVA: 0x4D1BC0 Offset: 0x4D01C0 VA: 0x1804D1BC0
	internal IPlayerItemDefinition <OnChanged>b__23_6(PlayerItemRecipe x) { }

	// RVA: 0x4D1980 Offset: 0x4CFF80 VA: 0x1804D1980
	internal bool <DoExchange>b__32_0(Toggle x) { }

	// RVA: 0x4D19A0 Offset: 0x4CFFA0 VA: 0x1804D19A0
	internal SteamInventoryItem <DoExchange>b__32_1(Toggle x) { }

	// RVA: 0x4D1C30 Offset: 0x4D0230 VA: 0x1804D1C30
	internal bool <OnRefreshed>b__34_0(IPlayerItem x) { }

	// RVA: 0x4D1C80 Offset: 0x4D0280 VA: 0x1804D1C80
	internal int <OnRefreshed>b__34_1(IPlayerItem x) { }

	// RVA: 0x4D1CD0 Offset: 0x4D02D0 VA: 0x1804D1CD0
	internal bool <OnRefreshed>b__34_2(IPlayerItem x) { }

	// RVA: 0x4D1D20 Offset: 0x4D0320 VA: 0x1804D1D20
	internal int <OnRefreshed>b__34_3(IPlayerItem x) { }

	// RVA: 0x4D1D70 Offset: 0x4D0370 VA: 0x1804D1D70
	internal bool <OnRefreshed>b__34_4(IPlayerItem x) { }

	// RVA: 0x4D1DC0 Offset: 0x4D03C0 VA: 0x1804D1DC0
	internal int <OnRefreshed>b__34_5(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass23_0 // TypeDefIndex: 12054
{	// Fields
	public IPlayerItemDefinition itemType; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3AB0 Offset: 0x4B20B0 VA: 0x1804B3AB0
	internal bool <OnChanged>b__7(SteamInventoryItem x) { }

}

private struct SteamInventoryCrafting.<GetMarketPrice>d__29 : IAsyncStateMachine // TypeDefIndex: 12055
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice> <>t__builder; // 0x8
	public SteamInventoryCrafting <>4__this; // 0x20
	public IPlayerItemDefinition definition; // 0x28
	private TaskAwaiter<SteamInventoryCrafting.MarketPrice> <>u__1; // 0x30

	// Methods

	// RVA: 0xF2200 Offset: 0xF1600 VA: 0x1800F2200 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2210 Offset: 0xF1610 VA: 0x1800F2210 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventoryCrafting.<GetMarketPriceImpl>d__30 : IAsyncStateMachine // TypeDefIndex: 12056
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice> <>t__builder; // 0x8
	public IPlayerItemDefinition definition; // 0x20
	public SteamInventoryCrafting <>4__this; // 0x28
	private TaskAwaiter<string> <>u__1; // 0x30

	// Methods

	// RVA: 0xF21A0 Offset: 0xF15A0 VA: 0x1800F21A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF21B0 Offset: 0xF15B0 VA: 0x1800F21B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass31_0 // TypeDefIndex: 12057
{	// Fields
	public Task<SteamInventoryCrafting.MarketPrice> task; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3BA0 Offset: 0x4B21A0 VA: 0x1804B3BA0
	internal bool <LoadMarketPrice>b__0() { }

}

private sealed class SteamInventoryCrafting.<LoadMarketPrice>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12058
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SteamInventoryCrafting <>4__this; // 0x20
	public IPlayerItemDefinition definition; // 0x28
	private SteamInventoryCrafting.<>c__DisplayClass31_0 <>8__1; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4B1D10 Offset: 0x4B0310 VA: 0x1804B1D10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4B1EF0 Offset: 0x4B04F0 VA: 0x1804B1EF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_0 // TypeDefIndex: 12059
{	// Fields
	public SteamInventoryItem[] selected; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3BC0 Offset: 0x4B21C0 VA: 0x1804B3BC0
	internal bool <ExchangeItems>b__0(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_1 // TypeDefIndex: 12060
{	// Fields
	public IPlayerItemDefinition targetItem; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3C90 Offset: 0x4B2290 VA: 0x1804B3C90
	internal Task<IPlayerInventory> <ExchangeItems>b__1(SteamInventoryItem x) { }

}

private struct SteamInventoryCrafting.<ExchangeItems>d__33 : IAsyncStateMachine // TypeDefIndex: 12061
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryItem[] selected; // 0x20
	public SteamInventoryCrafting <>4__this; // 0x28
	private SteamInventoryCrafting.<>c__DisplayClass33_0 <>8__1; // 0x30
	private SteamInventoryCrafting.<>c__DisplayClass33_1 <>8__2; // 0x38
	private IPlayerInventory <result>5__2; // 0x40
	private TaskAwaiter<IPlayerInventory> <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50
	private TaskAwaiter<IPlayerInventory[]> <>u__3; // 0x58

	// Methods

	// RVA: 0xF2180 Offset: 0xF1580 VA: 0x1800F2180 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryCrateOpen : MonoBehaviour // TypeDefIndex: 12062
{	// Fields
	public TextMeshProUGUI Name; // 0x18
	public TextMeshProUGUI Requirements; // 0x20
	public TextMeshProUGUI Label; // 0x28
	public HttpImage IconImage; // 0x30
	public GameObject ErrorPanel; // 0x38
	public TextMeshProUGUI ErrorText; // 0x40
	public GameObject CraftButton; // 0x48
	public GameObject ProgressPanel; // 0x50
	public SteamInventoryNewItem NewItemModal; // 0x58
	private InventoryRecipe Recipe; // 0x60

	// Methods

	// RVA: 0x4AD600 Offset: 0x4ABC00 VA: 0x1804AD600
	public void Open(int ItemDefinition) { }

	// RVA: 0x4AD500 Offset: 0x4ABB00 VA: 0x1804AD500
	public void DoCraft() { }

	[AsyncStateMachineAttribute] // RVA: 0xD5F60 Offset: 0xD5360 VA: 0x1800D5F60
	// RVA: 0x4AD500 Offset: 0x4ABB00 VA: 0x1804AD500
	private Task DoCraftAsync() { }

	// RVA: 0x4AD4B0 Offset: 0x4ABAB0 VA: 0x1804AD4B0
	public void Close() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass10_0 // TypeDefIndex: 12063
{	// Fields
	public InventoryRecipe.Ingredient i; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3920 Offset: 0x4B1F20 VA: 0x1804B3920
	internal bool <Open>b__1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c // TypeDefIndex: 12064
{	// Fields
	public static readonly SteamInventoryCrateOpen.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, string> <>9__10_0; // 0x8
	public static Func<InventoryItem, int> <>9__10_2; // 0x10
	public static Func<InventoryItem, int> <>9__12_1; // 0x18

	// Methods

	// RVA: 0x4B3DB0 Offset: 0x4B23B0 VA: 0x1804B3DB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B37C0 Offset: 0x4B1DC0 VA: 0x1804B37C0
	internal string <Open>b__10_0(InventoryRecipe.Ingredient x) { }

	// RVA: 0x4B36F0 Offset: 0x4B1CF0 VA: 0x1804B36F0
	internal int <Open>b__10_2(InventoryItem x) { }

	// RVA: 0x4B36F0 Offset: 0x4B1CF0 VA: 0x1804B36F0
	internal int <DoCraftAsync>b__12_1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_0 // TypeDefIndex: 12065
{	// Fields
	public List<InventoryItem.Amount> items; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3950 Offset: 0x4B1F50 VA: 0x1804B3950
	internal bool <DoCraftAsync>b__2(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_1 // TypeDefIndex: 12066
{	// Fields
	public InventoryRecipe.Ingredient i; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3920 Offset: 0x4B1F20 VA: 0x1804B3920
	internal bool <DoCraftAsync>b__0(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_2 // TypeDefIndex: 12067
{	// Fields
	public InventoryItem x; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3A20 Offset: 0x4B2020 VA: 0x1804B3A20
	internal bool <DoCraftAsync>b__3(InventoryItem.Amount y) { }

}

private struct SteamInventoryCrateOpen.<DoCraftAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 12068
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryCrateOpen <>4__this; // 0x20
	private SteamInventoryCrateOpen.<>c__DisplayClass12_0 <>8__1; // 0x28
	private Nullable<InventoryResult> <result>5__2; // 0x30
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0xF2160 Offset: 0xF1560 VA: 0x1800F2160 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryIcon : MonoBehaviour // TypeDefIndex: 12069
{	// Methods

	// RVA: 0x4ADC80 Offset: 0x4AC280 VA: 0x1804ADC80
	public void Setup(IPlayerItem item, ItemSkinDirectory.Skin skin) { }

	// RVA: 0x4ADD90 Offset: 0x4AC390 VA: 0x1804ADD90
	internal void Setup(IPlayerItem item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class SteamInventoryItem : MonoBehaviour // TypeDefIndex: 12070
{	// Fields
	public IPlayerItem Item; // 0x18
	public HttpImage Image; // 0x20

	// Methods

	// RVA: 0x4ADF40 Offset: 0x4AC540 VA: 0x1804ADF40
	public bool Setup(IPlayerItem item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class SteamInventoryManager : SingletonComponent<SteamInventoryManager> // TypeDefIndex: 12071
{	// Fields
	public GameObject inventoryItemPrefab; // 0x18
	public GameObject inventoryCanvas; // 0x20
	public GameObject missingItems; // 0x28
	public SteamInventoryCrafting CraftControl; // 0x30
	public List<GameObject> items; // 0x38
	public GameObject LoadingOverlay; // 0x40

	// Methods

	// RVA: 0x4AE060 Offset: 0x4AC660 VA: 0x1804AE060 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4AE200 Offset: 0x4AC800 VA: 0x1804AE200
	public void ManualRefresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD64C0 Offset: 0xD58C0 VA: 0x1800D64C0
	// RVA: 0x4AE380 Offset: 0x4AC980 VA: 0x1804AE380
	public Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6620 Offset: 0xD5A20 VA: 0x1800D6620
	// RVA: 0x4AE0D0 Offset: 0x4AC6D0 VA: 0x1804AE0D0
	private Task FixStacks(IReadOnlyCollection<IPlayerItem> steamitems) { }

	// RVA: 0x4AE480 Offset: 0x4ACA80 VA: 0x1804AE480
	public void .ctor() { }

}

private sealed class SteamInventoryManager.<>c // TypeDefIndex: 12072
{	// Fields
	public static readonly SteamInventoryManager.<>c <>9; // 0x0
	public static Func<IPlayerItem, DateTimeOffset> <>9__8_0; // 0x8
	public static Func<InventoryItem, bool> <>9__9_0; // 0x10
	public static Func<InventoryItem, bool> <>9__9_1; // 0x18
	public static Func<InventoryItem, bool> <>9__9_2; // 0x20
	public static Func<InventoryItem, InventoryDefId> <>9__9_3; // 0x28

	// Methods

	// RVA: 0x4B3E10 Offset: 0x4B2410 VA: 0x1804B3E10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3850 Offset: 0x4B1E50 VA: 0x1804B3850
	internal DateTimeOffset <Refresh>b__8_0(IPlayerItem x) { }

	// RVA: 0x4B3700 Offset: 0x4B1D00 VA: 0x1804B3700
	internal bool <FixStacks>b__9_0(InventoryItem x) { }

	// RVA: 0x4B3720 Offset: 0x4B1D20 VA: 0x1804B3720
	internal bool <FixStacks>b__9_1(InventoryItem x) { }

	// RVA: 0x4B3750 Offset: 0x4B1D50 VA: 0x1804B3750
	internal bool <FixStacks>b__9_2(InventoryItem x) { }

	// RVA: 0x4B37B0 Offset: 0x4B1DB0 VA: 0x1804B37B0
	internal InventoryDefId <FixStacks>b__9_3(InventoryItem x) { }

}

private struct SteamInventoryManager.<Refresh>d__8 : IAsyncStateMachine // TypeDefIndex: 12073
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryManager <>4__this; // 0x20
	private IReadOnlyList<IPlayerItem> <steamitems>5__2; // 0x28
	private int <itemIndex>5__3; // 0x30
	private TaskAwaiter<IPlayerInventory> <>u__1; // 0x38
	private IEnumerator<IPlayerItem> <>7__wrap3; // 0x40
	private IPlayerItem <item>5__5; // 0x48
	private TaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventoryManager.<FixStacks>d__9 : IAsyncStateMachine // TypeDefIndex: 12074
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public IReadOnlyCollection<IPlayerItem> steamitems; // 0x20
	public SteamInventoryManager <>4__this; // 0x28
	private bool <actionTaken>5__2; // 0x30
	private InventoryItem[] <>7__wrap2; // 0x38
	private int <>7__wrap3; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50
	private IEnumerator<IGrouping<InventoryDefId, InventoryItem>> <>7__wrap4; // 0x58
	private IGrouping<InventoryDefId, InventoryItem> <group>5__6; // 0x60
	private IEnumerator<InventoryItem> <>7__wrap6; // 0x68

	// Methods

	// RVA: 0xF2190 Offset: 0xF1590 VA: 0x1800F2190 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryNewItem : MonoBehaviour // TypeDefIndex: 12075
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xD69E0 Offset: 0xD5DE0 VA: 0x1800D69E0
	// RVA: 0x4AE4E0 Offset: 0x4ACAE0 VA: 0x1804AE4E0
	public Task Open(IPlayerItem item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private struct SteamInventoryNewItem.<Open>d__0 : IAsyncStateMachine // TypeDefIndex: 12076
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryNewItem <>4__this; // 0x20
	public IPlayerItem item; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2260 Offset: 0xF1660 VA: 0x1800F2260 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF2170 Offset: 0xF1570 VA: 0x1800F2170 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

