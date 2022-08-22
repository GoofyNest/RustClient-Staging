internal static class SteamAPI // TypeDefIndex: 5111
{	// Methods

	// RVA: 0xDE26F0 Offset: 0xDE0CF0 VA: 0x180DE26F0
	internal static bool Init() { }

	// RVA: 0xDE2760 Offset: 0xDE0D60 VA: 0x180DE2760
	internal static void Shutdown() { }

	// RVA: 0xDE2680 Offset: 0xDE0C80 VA: 0x180DE2680
	internal static HSteamPipe GetHSteamPipe() { }

}

internal static class SteamAPI.Native // TypeDefIndex: 5112
{	// Methods

	// RVA: 0xDE26F0 Offset: 0xDE0CF0 VA: 0x180DE26F0
	public static extern bool SteamAPI_Init() { }

	// RVA: 0xDE2760 Offset: 0xDE0D60 VA: 0x180DE2760
	public static extern void SteamAPI_Shutdown() { }

	// RVA: 0xDE2680 Offset: 0xDE0C80 VA: 0x180DE2680
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

	// RVA: 0xDE4600 Offset: 0xDE2C00 VA: 0x180DE4600
	internal static ISteamApps get_Internal() { }

	// RVA: 0xDE4400 Offset: 0xDE2A00 VA: 0x180DE4400 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE45D0 Offset: 0xDE2BD0 VA: 0x180DE45D0
	public static string get_GameLanguage() { }

	// RVA: 0xDE44D0 Offset: 0xDE2AD0 VA: 0x180DE44D0
	public static bool IsSubscribedToApp(AppId appid) { }

	// RVA: 0xDE4480 Offset: 0xDE2A80 VA: 0x180DE4480
	public static bool IsDlcInstalled(AppId appid) { }

	// RVA: 0xDE4590 Offset: 0xDE2B90 VA: 0x180DE4590
	public static string get_CurrentBetaName() { }

	// RVA: 0xDE4560 Offset: 0xDE2B60 VA: 0x180DE4560
	public static int get_BuildId() { }

	// RVA: 0xDE4520 Offset: 0xDE2B20 VA: 0x180DE4520
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

	// RVA: 0xDE4710 Offset: 0xDE2D10 VA: 0x180DE4710
	public static void Init(uint appid, bool asyncCallbacks = True) { }

	// RVA: -1 Offset: -1
	internal static void AddInterface<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF5C0 Offset: 0xCFDBC0 VA: 0x180CFF5C0
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

	// RVA: 0xDE4C50 Offset: 0xDE3250 VA: 0x180DE4C50
	internal static void ShutdownInterfaces() { }

	// RVA: 0xDE5180 Offset: 0xDE3780 VA: 0x180DE5180
	public static bool get_IsValid() { }

	// RVA: 0xDE4DE0 Offset: 0xDE33E0 VA: 0x180DE4DE0
	public static void Shutdown() { }

	// RVA: 0xDE4680 Offset: 0xDE2C80 VA: 0x180DE4680
	internal static void Cleanup() { }

	// RVA: 0xDE4B10 Offset: 0xDE3110 VA: 0x180DE4B10
	public static void RunCallbacks() { }

	// RVA: 0xDE50A0 Offset: 0xDE36A0 VA: 0x180DE50A0
	public static bool get_IsLoggedOn() { }

	// RVA: 0xDE5210 Offset: 0xDE3810 VA: 0x180DE5210
	public static SteamId get_SteamId() { }

	// RVA: 0xDE51E0 Offset: 0xDE37E0 VA: 0x180DE51E0
	public static string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE4FE0 Offset: 0xDE35E0 VA: 0x180DE4FE0
	public static AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE52E0 Offset: 0xDE38E0 VA: 0x180DE52E0
	internal static void set_AppId(AppId value) { }

	// RVA: 0xDE4F70 Offset: 0xDE3570 VA: 0x180DE4F70
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

	// RVA: 0xDE6580 Offset: 0xDE4B80 VA: 0x180DE6580
	internal static ISteamFriends get_Internal() { }

	// RVA: 0xDE5690 Offset: 0xDE3C90 VA: 0x180DE5690 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE5750 Offset: 0xDE3D50 VA: 0x180DE5750
	internal void InstallEvents() { }

	// RVA: 0xDE5DA0 Offset: 0xDE43A0 VA: 0x180DE5DA0
	private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data) { }

	// RVA: 0xDE6050 Offset: 0xDE4650 VA: 0x180DE6050
	private static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data) { }

	[IteratorStateMachineAttribute] // RVA: 0x8E180 Offset: 0x8D580 VA: 0x18008E180
	// RVA: 0xDE5480 Offset: 0xDE3A80 VA: 0x180DE5480
	private static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag) { }

	// RVA: 0xDE54F0 Offset: 0xDE3AF0 VA: 0x180DE54F0
	public static IEnumerable<Friend> GetFriends() { }

	// RVA: 0xDE63A0 Offset: 0xDE49A0 VA: 0x180DE63A0
	public static void OpenUserOverlay(SteamId id, string type) { }

	// RVA: 0xDE6350 Offset: 0xDE4950 VA: 0x180DE6350
	public static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = 0) { }

	// RVA: 0xDE63E0 Offset: 0xDE49E0 VA: 0x180DE63E0
	public static void OpenWebOverlay(string url, bool modal = False) { }

	// RVA: 0xDE6460 Offset: 0xDE4A60 VA: 0x180DE6460
	public static void SetPlayedWith(SteamId steamid) { }

	// RVA: 0xDE6420 Offset: 0xDE4A20 VA: 0x180DE6420
	public static bool RequestUserInformation(SteamId steamid, bool nameonly = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E200 Offset: 0x8D600 VA: 0x18008E200
	// RVA: 0xDE5340 Offset: 0xDE3940 VA: 0x180DE5340
	internal static Task CacheUserInformationAsync(SteamId steamid, bool nameonly) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E4C0 Offset: 0x8D8C0 VA: 0x18008E4C0
	// RVA: 0xDE5550 Offset: 0xDE3B50 VA: 0x180DE5550
	public static Task<Nullable<Image>> GetMediumAvatarAsync(SteamId steamid) { }

	// RVA: 0xDE5610 Offset: 0xDE3C10 VA: 0x180DE5610
	public static string GetRichPresence(string key) { }

	// RVA: 0xDE6490 Offset: 0xDE4A90 VA: 0x180DE6490
	public static bool SetRichPresence(string key, string value) { }

	// RVA: 0xDE5410 Offset: 0xDE3A10 VA: 0x180DE5410
	public static void ClearRichPresence() { }

	// RVA: 0xDE6540 Offset: 0xDE4B40 VA: 0x180DE6540
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

	// RVA: 0xDF02E0 Offset: 0xDEE8E0 VA: 0x180DF02E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF770 Offset: 0xDEDD70 VA: 0x180DEF770
	internal void <InstallEvents>b__4_0(PersonaStateChange_t x) { }

	// RVA: 0xDEF7D0 Offset: 0xDEDDD0 VA: 0x180DEF7D0
	internal void <InstallEvents>b__4_1(GameRichPresenceJoinRequested_t x) { }

	// RVA: 0xDEF850 Offset: 0xDEDE50 VA: 0x180DEF850
	internal void <InstallEvents>b__4_2(GameOverlayActivated_t x) { }

	// RVA: 0xDEF8B0 Offset: 0xDEDEB0 VA: 0x180DEF8B0
	internal void <InstallEvents>b__4_3(GameServerChangeRequested_t x) { }

	// RVA: 0xDEF930 Offset: 0xDEDF30 VA: 0x180DEF930
	internal void <InstallEvents>b__4_4(GameLobbyJoinRequested_t x) { }

	// RVA: 0xDEF9C0 Offset: 0xDEDFC0 VA: 0x180DEF9C0
	internal void <InstallEvents>b__4_5(FriendRichPresenceUpdate_t x) { }

	// RVA: 0xDEFA20 Offset: 0xDEE020 VA: 0x180DEFA20
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDEC230 Offset: 0xDEA830 VA: 0x180DEC230 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC370 Offset: 0xDEA970 VA: 0x180DEC370 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC3C0 Offset: 0xDEA9C0 VA: 0x180DEC3C0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC2D0 Offset: 0xDEA8D0 VA: 0x180DEC2D0 Slot: 4
	private IEnumerator<Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC2D0 Offset: 0xDEA8D0 VA: 0x180DEC2D0 Slot: 5
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

	// RVA: 0x123230 Offset: 0x122630 VA: 0x180123230 Slot: 4
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

	// RVA: 0x1234E0 Offset: 0x1228E0 VA: 0x1801234E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1234F0 Offset: 0x1228F0 VA: 0x1801234F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInput : SteamClientClass<SteamInput> // TypeDefIndex: 5190
{	// Fields
	private static readonly InputHandle_t[] queryArray; // 0x0
	internal static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles; // 0x8
	internal static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles; // 0x10
	internal static Dictionary<string, InputActionSetHandle_t> ActionSets; // 0x18

	// Methods

	// RVA: 0xDE6630 Offset: 0xDE4C30 VA: 0x180DE6630 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE67C0 Offset: 0xDE4DC0 VA: 0x180DE67C0
	public void .ctor() { }

	// RVA: 0xDE66B0 Offset: 0xDE4CB0 VA: 0x180DE66B0
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

	// RVA: 0xDE7A90 Offset: 0xDE6090 VA: 0x180DE7A90
	internal static ISteamInventory get_Internal() { }

	// RVA: 0xDE7040 Offset: 0xDE5640 VA: 0x180DE7040 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE70D0 Offset: 0xDE56D0 VA: 0x180DE70D0
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDE72C0 Offset: 0xDE58C0 VA: 0x180DE72C0
	private static void InventoryUpdated(SteamInventoryFullUpdate_t x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7960 Offset: 0xDE5F60 VA: 0x180DE7960
	public static void add_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7C00 Offset: 0xDE6200 VA: 0x180DE7C00
	public static void remove_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE78B0 Offset: 0xDE5EB0 VA: 0x180DE78B0
	public static void add_OnDefinitionsUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7B50 Offset: 0xDE6150 VA: 0x180DE7B50
	public static void remove_OnDefinitionsUpdated(Action value) { }

	// RVA: 0xDE7380 Offset: 0xDE5980 VA: 0x180DE7380
	private static void LoadDefinitions() { }

	// RVA: 0xDE7670 Offset: 0xDE5C70 VA: 0x180DE7670
	public static void LoadItemDefinitions() { }

	// RVA: 0xDE6B90 Offset: 0xDE5190 VA: 0x180DE6B90
	public static InventoryDef FindDefinition(InventoryDefId defId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7A10 Offset: 0xDE6010 VA: 0x180DE7A10
	public static string get_Currency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7CB0 Offset: 0xDE62B0 VA: 0x180DE7CB0
	internal static void set_Currency(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0x8FA60 Offset: 0x8EE60 VA: 0x18008FA60
	// RVA: 0xDE6D40 Offset: 0xDE5340 VA: 0x180DE6D40
	public static Task<InventoryDef[]> GetDefinitionsWithPricesAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7B10 Offset: 0xDE6110 VA: 0x180DE7B10
	public static InventoryItem[] get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7D50 Offset: 0xDE6350 VA: 0x180DE7D50
	internal static void set_Items(InventoryItem[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7A50 Offset: 0xDE6050 VA: 0x180DE7A50
	public static InventoryDef[] get_Definitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7D00 Offset: 0xDE6300 VA: 0x180DE7D00
	internal static void set_Definitions(InventoryDef[] value) { }

	// RVA: 0xDE6E00 Offset: 0xDE5400 VA: 0x180DE6E00
	internal static InventoryDef[] GetDefinitions() { }

	// RVA: 0xDE6CC0 Offset: 0xDE52C0 VA: 0x180DE6CC0
	public static bool GetAllItems() { }

	[AsyncStateMachineAttribute] // RVA: 0x900D0 Offset: 0x8F4D0 VA: 0x1800900D0
	// RVA: 0xDE6C10 Offset: 0xDE5210 VA: 0x180DE6C10
	public static Task<Nullable<InventoryResult>> GetAllItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90150 Offset: 0x8F550 VA: 0x180090150
	// RVA: 0xDE6990 Offset: 0xDE4F90 VA: 0x180DE6990
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x90280 Offset: 0x8F680 VA: 0x180090280
	// RVA: 0xDE6A90 Offset: 0xDE5090 VA: 0x180DE6A90
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem.Amount[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x903A0 Offset: 0x8F7A0 VA: 0x1800903A0
	// RVA: 0xDE6F90 Offset: 0xDE5590 VA: 0x180DE6F90
	public static Task<Nullable<InventoryResult>> GrantPromoItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0xDE77B0 Offset: 0xDE5DB0 VA: 0x180DE77B0
	public static Task<Nullable<InventoryResult>> TriggerItemDropAsync(InventoryDefId id) { }

	[AsyncStateMachineAttribute] // RVA: 0x90770 Offset: 0x8FB70 VA: 0x180090770
	// RVA: 0xDE76D0 Offset: 0xDE5CD0 VA: 0x180DE76D0
	public static Task<Nullable<InventoryPurchaseResult>> StartPurchaseAsync(InventoryDef[] items) { }

	// RVA: 0xDE7870 Offset: 0xDE5E70 VA: 0x180DE7870
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

	// RVA: 0xDF0460 Offset: 0xDEEA60 VA: 0x180DF0460
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF520 Offset: 0xDEDB20 VA: 0x180DEF520
	internal void <InstallEvents>b__3_0(SteamInventoryFullUpdate_t x) { }

	// RVA: 0xDEF690 Offset: 0xDEDC90 VA: 0x180DEF690
	internal void <InstallEvents>b__3_1(SteamInventoryDefinitionUpdate_t x) { }

	// RVA: 0xDEF340 Offset: 0xDED940 VA: 0x180DEF340
	internal InventoryDef <GetDefinitionsWithPricesAsync>b__19_0(InventoryDefId x) { }

	// RVA: 0xDEF2E0 Offset: 0xDED8E0 VA: 0x180DEF2E0
	internal InventoryDef <GetDefinitions>b__29_0(InventoryDefId x) { }

	// RVA: 0x820850 Offset: 0x81EE50 VA: 0x180820850
	internal InventoryItemId <CraftItemAsync>b__33_0(InventoryItem x) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	internal uint <CraftItemAsync>b__33_1(InventoryItem x) { }

	// RVA: 0x820850 Offset: 0x81EE50 VA: 0x180820850
	internal InventoryItemId <CraftItemAsync>b__34_0(InventoryItem.Amount x) { }

	// RVA: 0xDEF270 Offset: 0xDED870 VA: 0x180DEF270
	internal uint <CraftItemAsync>b__34_1(InventoryItem.Amount x) { }

	// RVA: 0x7B4E60 Offset: 0x7B3460 VA: 0x1807B4E60
	internal InventoryDefId <StartPurchaseAsync>b__39_0(InventoryDef x) { }

	// RVA: 0xDF0020 Offset: 0xDEE620 VA: 0x180DF0020
	internal InventoryDefId <StartPurchaseAsync>b__39_1(IGrouping<InventoryDefId, InventoryDef> x) { }

	// RVA: 0xDF00D0 Offset: 0xDEE6D0 VA: 0x180DF00D0
	internal uint <StartPurchaseAsync>b__39_2(IGrouping<InventoryDefId, InventoryDef> x) { }

}

private struct SteamInventory.<GetDefinitionsWithPricesAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5193
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<InventoryDef[]> <>t__builder; // 0x8
	private CallResult<SteamInventoryRequestPricesResult_t> <>u__1; // 0x20

	// Methods

	// RVA: 0x123480 Offset: 0x122880 VA: 0x180123480 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123490 Offset: 0x122890 VA: 0x180123490 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GetAllItemsAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 5194
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x123360 Offset: 0x122760 VA: 0x180123360 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123370 Offset: 0x122770 VA: 0x180123370 Slot: 5
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

	// RVA: 0x1232A0 Offset: 0x1226A0 VA: 0x1801232A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1232B0 Offset: 0x1226B0 VA: 0x1801232B0 Slot: 5
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

	// RVA: 0x123300 Offset: 0x122700 VA: 0x180123300 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123310 Offset: 0x122710 VA: 0x180123310 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GrantPromoItemsAsync>d__36 : IAsyncStateMachine // TypeDefIndex: 5197
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x123600 Offset: 0x122A00 VA: 0x180123600 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123610 Offset: 0x122A10 VA: 0x180123610 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<TriggerItemDropAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 5198
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDefId id; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x28

	// Methods

	// RVA: 0x123850 Offset: 0x122C50 VA: 0x180123850 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123860 Offset: 0x122C60 VA: 0x180123860 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<StartPurchaseAsync>d__39 : IAsyncStateMachine // TypeDefIndex: 5199
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>> <>t__builder; // 0x8
	public InventoryDef[] items; // 0x20
	private CallResult<SteamInventoryStartPurchaseResult_t> <>u__1; // 0x28

	// Methods

	// RVA: 0x1237F0 Offset: 0x122BF0 VA: 0x1801237F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x123800 Offset: 0x122C00 VA: 0x180123800 Slot: 5
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

	// RVA: 0xDE8700 Offset: 0xDE6D00 VA: 0x180DE8700
	internal static ISteamMatchmaking get_Internal() { }

	// RVA: 0xDE7EC0 Offset: 0xDE64C0 VA: 0x180DE7EC0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE7F40 Offset: 0xDE6540 VA: 0x180DE7F40
	internal static void InstallEvents() { }

	// RVA: 0xDE8490 Offset: 0xDE6A90 VA: 0x180DE8490
	private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x931C0 Offset: 0x925C0 VA: 0x1800931C0
	// RVA: 0xDE7E60 Offset: 0xDE6460 VA: 0x180DE7E60
	public static IEnumerable<ServerInfo> GetFavoriteServers() { }

	// RVA: 0xDE86C0 Offset: 0xDE6CC0 VA: 0x180DE86C0
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

	// RVA: 0xDF04C0 Offset: 0xDEEAC0 VA: 0x180DF04C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEFA80 Offset: 0xDEE080 VA: 0x180DEFA80
	internal void <InstallEvents>b__5_0(LobbyInvite_t x) { }

	// RVA: 0xDEFB10 Offset: 0xDEE110 VA: 0x180DEFB10
	internal void <InstallEvents>b__5_1(LobbyEnter_t x) { }

	// RVA: 0xDEFB90 Offset: 0xDEE190 VA: 0x180DEFB90
	internal void <InstallEvents>b__5_2(LobbyCreated_t x) { }

	// RVA: 0xDEFC20 Offset: 0xDEE220 VA: 0x180DEFC20
	internal void <InstallEvents>b__5_3(LobbyGameCreated_t x) { }

	// RVA: 0xDEFCF0 Offset: 0xDEE2F0 VA: 0x180DEFCF0
	internal void <InstallEvents>b__5_4(LobbyDataUpdate_t x) { }

	// RVA: 0xDEFDE0 Offset: 0xDEE3E0 VA: 0x180DEFDE0
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
	// RVA: 0xDEC1F0 Offset: 0xDEA7F0 VA: 0x180DEC1F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDEBE70 Offset: 0xDEA470 VA: 0x180DEBE70 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC0B0 Offset: 0xDEA6B0 VA: 0x180DEC0B0 Slot: 6
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC100 Offset: 0xDEA700 VA: 0x180DEC100 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC150 Offset: 0xDEA750 VA: 0x180DEC150 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC020 Offset: 0xDEA620 VA: 0x180DEC020 Slot: 4
	private IEnumerator<ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC020 Offset: 0xDEA620 VA: 0x180DEC020 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers> // TypeDefIndex: 5203
{	// Properties
	internal static ISteamMatchmakingServers Internal { get; }

	// Methods

	// RVA: 0xDD76C0 Offset: 0xDD5CC0 VA: 0x180DD76C0
	internal static ISteamMatchmakingServers get_Internal() { }

	// RVA: 0xDE7DA0 Offset: 0xDE63A0 VA: 0x180DE7DA0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE7E20 Offset: 0xDE6420 VA: 0x180DE7E20
	public void .ctor() { }

}

public class SteamMusic : SteamClientClass<SteamMusic> // TypeDefIndex: 5204
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnPlaybackChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<float> OnVolumeChanged; // 0x8

	// Methods

	// RVA: 0xDE8790 Offset: 0xDE6D90 VA: 0x180DE8790 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE8810 Offset: 0xDE6E10 VA: 0x180DE8810
	internal static void InstallEvents() { }

	// RVA: 0xDE89E0 Offset: 0xDE6FE0 VA: 0x180DE89E0
	public void .ctor() { }

}

private sealed class SteamMusic.<>c // TypeDefIndex: 5205
{	// Fields
	public static readonly SteamMusic.<>c <>9; // 0x0
	public static Action<PlaybackStatusHasChanged_t> <>9__3_0; // 0x8
	public static Action<VolumeHasChanged_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDF0280 Offset: 0xDEE880 VA: 0x180DF0280
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF5E0 Offset: 0xDEDBE0 VA: 0x180DEF5E0
	internal void <InstallEvents>b__3_0(PlaybackStatusHasChanged_t x) { }

	// RVA: 0xDEF710 Offset: 0xDEDD10 VA: 0x180DEF710
	internal void <InstallEvents>b__3_1(VolumeHasChanged_t x) { }

}

public class SteamNetworking : SteamSharedClass<SteamNetworking> // TypeDefIndex: 5206
{	// Fields
	public static Action<SteamId> OnP2PSessionRequest; // 0x0
	public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed; // 0x8

	// Methods

	// RVA: 0xDEA2C0 Offset: 0xDE88C0 VA: 0x180DEA2C0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDEA350 Offset: 0xDE8950 VA: 0x180DEA350
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDEA530 Offset: 0xDE8B30 VA: 0x180DEA530
	public void .ctor() { }

}

private sealed class SteamNetworking.<>c // TypeDefIndex: 5207
{	// Fields
	public static readonly SteamNetworking.<>c <>9; // 0x0
	public static Action<P2PSessionRequest_t> <>9__3_0; // 0x8
	public static Action<P2PSessionConnectFail_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDF0520 Offset: 0xDEEB20 VA: 0x180DF0520
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF630 Offset: 0xDEDC30 VA: 0x180DEF630
	internal void <InstallEvents>b__3_0(P2PSessionRequest_t x) { }

	// RVA: 0xDEF6A0 Offset: 0xDEDCA0 VA: 0x180DEF6A0
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

	// RVA: 0xDEA140 Offset: 0xDE8740 VA: 0x180DEA140
	internal static ISteamNetworkingSockets get_Internal() { }

	// RVA: 0xDEA0A0 Offset: 0xDE86A0 VA: 0x180DEA0A0
	public static NetIdentity get_Identity() { }

	// RVA: 0xDE9B40 Offset: 0xDE8140 VA: 0x180DE9B40 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE9A40 Offset: 0xDE8040 VA: 0x180DE9A40
	internal static SocketManager GetSocketManager(uint id) { }

	// RVA: 0xDE9E00 Offset: 0xDE8400 VA: 0x180DE9E00
	internal static void SetSocketManager(uint id, SocketManager manager) { }

	// RVA: 0xDE9810 Offset: 0xDE7E10 VA: 0x180DE9810
	internal static ConnectionManager GetConnectionManager(uint id) { }

	// RVA: 0xDE9D40 Offset: 0xDE8340 VA: 0x180DE9D40
	internal static void SetConnectionManager(uint id, ConnectionManager manager) { }

	// RVA: 0xDE9C70 Offset: 0xDE8270 VA: 0x180DE9C70
	internal void InstallEvents(bool server) { }

	// RVA: 0xDE8BA0 Offset: 0xDE71A0 VA: 0x180DE8BA0
	private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data) { }

	// RVA: 0xDE9690 Offset: 0xDE7C90 VA: 0x180DE9690
	private static void FakeIPResult(SteamNetworkingFakeIPResult_t data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE9FA0 Offset: 0xDE85A0 VA: 0x180DE9FA0
	public static void add_OnFakeIPResult(Action<NetAddress> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEA1C0 Offset: 0xDE87C0 VA: 0x180DEA1C0
	public static void remove_OnFakeIPResult(Action<NetAddress> value) { }

	// RVA: 0xDE9410 Offset: 0xDE7A10 VA: 0x180DE9410
	public static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface) { }

	// RVA: 0xDE8A20 Offset: 0xDE7020 VA: 0x180DE8A20
	public static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface) { }

	// RVA: 0xDE98E0 Offset: 0xDE7EE0 VA: 0x180DE98E0
	public static Result GetFakeIP(int fakePortIndex, out NetAddress address) { }

	// RVA: 0xDE9550 Offset: 0xDE7B50 VA: 0x180DE9550
	public static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface) { }

	// RVA: 0xDE9F60 Offset: 0xDE8560 VA: 0x180DE9F60
	public void .ctor() { }

	// RVA: 0xDE9EC0 Offset: 0xDE84C0 VA: 0x180DE9EC0
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

	// RVA: 0x19D7AE0 Offset: 0x19D60E0 VA: 0x1819D7AE0
	internal static ISteamNetworkingUtils get_Internal() { }

	// RVA: 0x19D7090 Offset: 0x19D5690 VA: 0x1819D7090 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D7220 Offset: 0x19D5820 VA: 0x1819D7220
	private static void InstallCallbacks(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D7760 Offset: 0x19D5D60 VA: 0x1819D7760
	public static void add_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D7BC0 Offset: 0x19D61C0 VA: 0x1819D7BC0
	public static void remove_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D7B60 Offset: 0x19D6160 VA: 0x1819D7B60
	public static SteamNetworkingAvailability get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D80F0 Offset: 0x19D66F0 VA: 0x1819D80F0
	private static void set_Status(SteamNetworkingAvailability value) { }

	// RVA: 0x19D7030 Offset: 0x19D5630 VA: 0x1819D7030
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x19D7850 Offset: 0x19D5E50 VA: 0x1819D7850
	public static int get_ConnectionTimeout() { }

	// RVA: 0x19D7D10 Offset: 0x19D6310 VA: 0x1819D7D10
	public static void set_ConnectionTimeout(int value) { }

	// RVA: 0x19D8090 Offset: 0x19D6690 VA: 0x1819D8090
	public static void set_SendBufferSize(int value) { }

	// RVA: 0x19D7CB0 Offset: 0x19D62B0 VA: 0x1819D7CB0
	public static void set_AllowWithoutAuth(int value) { }

	// RVA: 0x19D8150 Offset: 0x19D6750 VA: 0x1819D8150
	public static void set_Unencrypted(int value) { }

	// RVA: 0x19D78A0 Offset: 0x19D5EA0 VA: 0x1819D78A0
	public static int get_DebugLevelAckRTT() { }

	// RVA: 0x19D7D70 Offset: 0x19D6370 VA: 0x1819D7D70
	public static void set_DebugLevelAckRTT(int value) { }

	// RVA: 0x19D7990 Offset: 0x19D5F90 VA: 0x1819D7990
	public static int get_DebugLevelPacketDecode() { }

	// RVA: 0x19D7E90 Offset: 0x19D6490 VA: 0x1819D7E90
	public static void set_DebugLevelPacketDecode(int value) { }

	// RVA: 0x19D78F0 Offset: 0x19D5EF0 VA: 0x1819D78F0
	public static int get_DebugLevelMessage() { }

	// RVA: 0x19D7DD0 Offset: 0x19D63D0 VA: 0x1819D7DD0
	public static void set_DebugLevelMessage(int value) { }

	// RVA: 0x19D79E0 Offset: 0x19D5FE0 VA: 0x1819D79E0
	public static int get_DebugLevelPacketGaps() { }

	// RVA: 0x19D7EF0 Offset: 0x19D64F0 VA: 0x1819D7EF0
	public static void set_DebugLevelPacketGaps(int value) { }

	// RVA: 0x19D7940 Offset: 0x19D5F40 VA: 0x1819D7940
	public static int get_DebugLevelP2PRendezvous() { }

	// RVA: 0x19D7E30 Offset: 0x19D6430 VA: 0x1819D7E30
	public static void set_DebugLevelP2PRendezvous(int value) { }

	// RVA: 0x19D7A30 Offset: 0x19D6030 VA: 0x1819D7A30
	public static int get_DebugLevelSDRRelayPings() { }

	// RVA: 0x19D7F50 Offset: 0x19D6550 VA: 0x1819D7F50
	public static void set_DebugLevelSDRRelayPings(int value) { }

	// RVA: 0x19D7A80 Offset: 0x19D6080 VA: 0x1819D7A80
	public static NetDebugOutput get_DebugLevel() { }

	// RVA: 0x19D7FB0 Offset: 0x19D65B0 VA: 0x1819D7FB0
	public static void set_DebugLevel(NetDebugOutput value) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D73F0 Offset: 0x19D59F0 VA: 0x1819D73F0
	private static void OnDebugMessage(NetDebugOutput nType, IntPtr str) { }

	// RVA: 0x19D7330 Offset: 0x19D5930 VA: 0x1819D7330
	internal static void LogDebugMessage(NetDebugOutput type, string message) { }

	// RVA: 0x19D74E0 Offset: 0x19D5AE0 VA: 0x1819D74E0
	internal static void OutputDebugMessages() { }

	// RVA: 0x19D6F00 Offset: 0x19D5500 VA: 0x1819D6F00
	internal static NetMsg* AllocateMessage() { }

	// RVA: 0x19D7610 Offset: 0x19D5C10 VA: 0x1819D7610
	internal static bool SetConfigInt(NetConfig type, int value) { }

	// RVA: 0x19D6F60 Offset: 0x19D5560 VA: 0x1819D6F60
	internal static int GetConfigInt(NetConfig type) { }

	// RVA: 0x19D7720 Offset: 0x19D5D20 VA: 0x1819D7720
	public void .ctor() { }

	// RVA: 0x19D76B0 Offset: 0x19D5CB0 VA: 0x1819D76B0
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

	// RVA: 0x19DFFC0 Offset: 0x19DE5C0 VA: 0x1819DFFC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DED80 Offset: 0x19DD380 VA: 0x1819DED80
	internal void <InstallCallbacks>b__3_0(SteamRelayNetworkStatus_t x) { }

}

public class SteamParental : SteamSharedClass<SteamParental> // TypeDefIndex: 5212
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSettingsChanged; // 0x13848

	// Methods

	// RVA: 0x19D84D0 Offset: 0x19D6AD0 VA: 0x1819D84D0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8640 Offset: 0x19D6C40 VA: 0x1819D8640
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D8750 Offset: 0x19D6D50 VA: 0x1819D8750
	public void .ctor() { }

}

private sealed class SteamParental.<>c // TypeDefIndex: 5213
{	// Fields
	public static readonly SteamParental.<>c <>9; // 0x0
	public static Action<SteamParentalSettingsChanged_t> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x19E0020 Offset: 0x19DE620 VA: 0x1819E0020
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DEE30 Offset: 0x19DD430 VA: 0x1819DEE30
	internal void <InstallEvents>b__3_0(SteamParentalSettingsChanged_t x) { }

}

public class SteamParties : SteamClientClass<SteamParties> // TypeDefIndex: 5214
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnBeaconLocationsUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnActiveBeaconsUpdated; // 0x8

	// Methods

	// RVA: 0x19D8790 Offset: 0x19D6D90 VA: 0x1819D8790 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8820 Offset: 0x19D6E20 VA: 0x1819D8820
	internal void InstallEvents(bool server) { }

	// RVA: 0x19D8A00 Offset: 0x19D7000 VA: 0x1819D8A00
	public void .ctor() { }

}

private sealed class SteamParties.<>c // TypeDefIndex: 5215
{	// Fields
	public static readonly SteamParties.<>c <>9; // 0x0
	public static Action<AvailableBeaconLocationsUpdated_t> <>9__3_0; // 0x8
	public static Action<ActiveBeaconsUpdated_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19E0080 Offset: 0x19DE680 VA: 0x1819E0080
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DEEF0 Offset: 0x19DD4F0 VA: 0x1819DEEF0
	internal void <InstallEvents>b__3_0(AvailableBeaconLocationsUpdated_t x) { }

	// RVA: 0x19DF1F0 Offset: 0x19DD7F0 VA: 0x1819DF1F0
	internal void <InstallEvents>b__3_1(ActiveBeaconsUpdated_t x) { }

}

public class SteamRemotePlay : SteamClientClass<SteamRemotePlay> // TypeDefIndex: 5216
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<RemotePlaySession> OnSessionConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<RemotePlaySession> OnSessionDisconnected; // 0x8

	// Methods

	// RVA: 0x19D8A40 Offset: 0x19D7040 VA: 0x1819D8A40 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8AD0 Offset: 0x19D70D0 VA: 0x1819D8AD0
	internal void InstallEvents(bool server) { }

	// RVA: 0x19D8CB0 Offset: 0x19D72B0 VA: 0x1819D8CB0
	public void .ctor() { }

}

private sealed class SteamRemotePlay.<>c // TypeDefIndex: 5217
{	// Fields
	public static readonly SteamRemotePlay.<>c <>9; // 0x0
	public static Action<SteamRemotePlaySessionConnected_t> <>9__3_0; // 0x8
	public static Action<SteamRemotePlaySessionDisconnected_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19DFEA0 Offset: 0x19DE4A0 VA: 0x1819DFEA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DEE80 Offset: 0x19DD480 VA: 0x1819DEE80
	internal void <InstallEvents>b__3_0(SteamRemotePlaySessionConnected_t x) { }

	// RVA: 0x19DF100 Offset: 0x19DD700 VA: 0x1819DF100
	internal void <InstallEvents>b__3_1(SteamRemotePlaySessionDisconnected_t x) { }

}

public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage> // TypeDefIndex: 5218
{	// Methods

	// RVA: 0x19D8CF0 Offset: 0x19D72F0 VA: 0x1819D8CF0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8D70 Offset: 0x19D7370 VA: 0x1819D8D70
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

	// RVA: 0x19D90D0 Offset: 0x19D76D0 VA: 0x1819D90D0
	internal static ISteamScreenshots get_Internal() { }

	// RVA: 0x19D8DB0 Offset: 0x19D73B0 VA: 0x1819D8DB0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8E30 Offset: 0x19D7430 VA: 0x1819D8E30
	internal static void InstallEvents() { }

	// RVA: 0x19D9000 Offset: 0x19D7600 VA: 0x1819D9000
	public static void TriggerScreenshot() { }

	// RVA: 0x19D9090 Offset: 0x19D7690 VA: 0x1819D9090
	public void .ctor() { }

}

private sealed class SteamScreenshots.<>c // TypeDefIndex: 5220
{	// Fields
	public static readonly SteamScreenshots.<>c <>9; // 0x0
	public static Action<ScreenshotRequested_t> <>9__3_0; // 0x8
	public static Action<ScreenshotReady_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19DFF60 Offset: 0x19DE560 VA: 0x1819DFF60
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DEFB0 Offset: 0x19DD5B0 VA: 0x1819DEFB0
	internal void <InstallEvents>b__3_0(ScreenshotRequested_t x) { }

	// RVA: 0x19DF060 Offset: 0x19DD660 VA: 0x1819DF060
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

	// RVA: 0x19D96C0 Offset: 0x19D7CC0 VA: 0x1819D96C0
	internal static ISteamUGC get_Internal() { }

	// RVA: 0x19D91A0 Offset: 0x19D77A0 VA: 0x1819D91A0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D9230 Offset: 0x19D7830 VA: 0x1819D9230
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D9160 Offset: 0x19D7760 VA: 0x1819D9160
	public static bool Download(PublishedFileId fileId, bool highPriority = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x94C70 Offset: 0x94070 VA: 0x180094C70
	// RVA: 0x19D95C0 Offset: 0x19D7BC0 VA: 0x1819D95C0
	public static Task<Nullable<Item>> QueryFileAsync(PublishedFileId fileId) { }

	// RVA: 0x19D9680 Offset: 0x19D7C80 VA: 0x1819D9680
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

	// RVA: 0x19DFD80 Offset: 0x19DE380 VA: 0x1819DFD80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF000 Offset: 0x19DD600 VA: 0x1819DF000
	internal void <InstallEvents>b__3_0(DownloadItemResult_t x) { }

	// RVA: 0x19DF170 Offset: 0x19DD770 VA: 0x1819DF170
	internal void <InstallEvents>b__3_1(RemoteStoragePublishedFileSubscribed_t x) { }

	// RVA: 0x19DF390 Offset: 0x19DD990 VA: 0x1819DF390
	internal void <InstallEvents>b__3_2(RemoteStoragePublishedFileUnsubscribed_t x) { }

	// RVA: 0x19DF410 Offset: 0x19DDA10 VA: 0x1819DF410
	internal void <InstallEvents>b__3_3(ItemInstalled_t x) { }

}

private struct SteamUGC.<QueryFileAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5223
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Item>> <>t__builder; // 0x8
	public PublishedFileId fileId; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28

	// Methods

	// RVA: 0x224E70 Offset: 0x224270 VA: 0x180224E70 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224E80 Offset: 0x224280 VA: 0x180224E80 Slot: 5
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

	// RVA: 0x19DB630 Offset: 0x19D9C30 VA: 0x1819DB630
	internal static ISteamUser get_Internal() { }

	// RVA: 0x19DA4A0 Offset: 0x19D8AA0 VA: 0x1819DA4A0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19DA760 Offset: 0x19D8D60 VA: 0x1819DA760
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DB390 Offset: 0x19D9990 VA: 0x1819DB390
	internal static void add_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DB840 Offset: 0x19D9E40 VA: 0x1819DB840
	internal static void remove_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DB490 Offset: 0x19D9A90 VA: 0x1819DB490
	public static void add_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DB940 Offset: 0x19D9F40 VA: 0x1819DB940
	public static void remove_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	// RVA: 0x19DB7E0 Offset: 0x19D9DE0 VA: 0x1819DB7E0
	public static bool get_VoiceRecord() { }

	// RVA: 0x19DBBE0 Offset: 0x19DA1E0 VA: 0x1819DBBE0
	public static void set_VoiceRecord(bool value) { }

	// RVA: 0x19DB590 Offset: 0x19D9B90 VA: 0x1819DB590
	public static bool get_HasVoiceData() { }

	// RVA: 0x19DAFB0 Offset: 0x19D95B0 VA: 0x1819DAFB0
	public static byte[] ReadVoiceDataBytes() { }

	// RVA: 0x19DB780 Offset: 0x19D9D80 VA: 0x1819DB780
	public static uint get_SampleRate() { }

	// RVA: 0x19DBA40 Offset: 0x19DA040 VA: 0x1819DBA40
	public static void set_SampleRate(uint value) { }

	// RVA: 0x19DB720 Offset: 0x19D9D20 VA: 0x1819DB720
	public static uint get_OptimalSampleRate() { }

	// RVA: 0x19DA090 Offset: 0x19D8690 VA: 0x1819DA090
	public static int DecompressVoice(byte[] from, Stream output) { }

	// RVA: 0x19DA340 Offset: 0x19D8940 VA: 0x1819DA340
	public static AuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0x958F0 Offset: 0x94CF0 VA: 0x1800958F0
	// RVA: 0x19DA260 Offset: 0x19D8860 VA: 0x1819DA260
	public static Task<AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10) { }

	// RVA: 0x19DB6C0 Offset: 0x19D9CC0 VA: 0x1819DB6C0
	public static bool get_IsTwoFactorEnabled() { }

	[AsyncStateMachineAttribute] // RVA: 0x95A60 Offset: 0x94E60 VA: 0x180095A60
	// RVA: 0x19DB220 Offset: 0x19D9820 VA: 0x1819DB220
	public static Task<byte[]> RequestEncryptedAppTicketAsync() { }

	// RVA: 0x19DB350 Offset: 0x19D9950 VA: 0x1819DB350
	public void .ctor() { }

	// RVA: 0x19DB2E0 Offset: 0x19D98E0 VA: 0x1819DB2E0
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

	// RVA: 0x19DFE40 Offset: 0x19DE440 VA: 0x1819DFE40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF510 Offset: 0x19DDB10 VA: 0x1819DF510
	internal void <InstallEvents>b__4_0(SteamServersConnected_t x) { }

	// RVA: 0x19DF580 Offset: 0x19DDB80 VA: 0x1819DF580
	internal void <InstallEvents>b__4_1(SteamServerConnectFailure_t x) { }

	// RVA: 0x19DF5F0 Offset: 0x19DDBF0 VA: 0x1819DF5F0
	internal void <InstallEvents>b__4_2(SteamServersDisconnected_t x) { }

	// RVA: 0x19DF660 Offset: 0x19DDC60 VA: 0x1819DF660
	internal void <InstallEvents>b__4_3(ClientGameServerDeny_t x) { }

	// RVA: 0x19DF6D0 Offset: 0x19DDCD0 VA: 0x1819DF6D0
	internal void <InstallEvents>b__4_4(LicensesUpdated_t x) { }

	// RVA: 0x19DF740 Offset: 0x19DDD40 VA: 0x1819DF740
	internal void <InstallEvents>b__4_5(ValidateAuthTicketResponse_t x) { }

	// RVA: 0x19DF810 Offset: 0x19DDE10 VA: 0x1819DF810
	internal void <InstallEvents>b__4_6(MicroTxnAuthorizationResponse_t x) { }

	// RVA: 0x19DF8D0 Offset: 0x19DDED0 VA: 0x1819DF8D0
	internal void <InstallEvents>b__4_7(GameWebCallback_t x) { }

	// RVA: 0x19DF960 Offset: 0x19DDF60 VA: 0x1819DF960
	internal void <InstallEvents>b__4_8(GetAuthSessionTicketResponse_t x) { }

	// RVA: 0x19DF9E0 Offset: 0x19DDFE0 VA: 0x1819DF9E0
	internal void <InstallEvents>b__4_9(DurationControl_t x) { }

}

private sealed class SteamUser.<>c__DisplayClass54_0 // TypeDefIndex: 5226
{	// Fields
	public AuthTicket ticket; // 0x10
	public Result result; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DFD50 Offset: 0x19DE350 VA: 0x1819DFD50
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

	// RVA: 0x224DB0 Offset: 0x2241B0 VA: 0x180224DB0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224DC0 Offset: 0x2241C0 VA: 0x180224DC0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamUser.<RequestEncryptedAppTicketAsync>d__71 : IAsyncStateMachine // TypeDefIndex: 5228
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	private CallResult<EncryptedAppTicketResponse_t> <>u__1; // 0x20

	// Methods

	// RVA: 0x224ED0 Offset: 0x2242D0 VA: 0x180224ED0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224EE0 Offset: 0x2242E0 VA: 0x180224EE0 Slot: 5
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

	// RVA: 0x19D9F10 Offset: 0x19D8510 VA: 0x1819D9F10
	internal static ISteamUserStats get_Internal() { }

	// RVA: 0x19D97D0 Offset: 0x19D7DD0 VA: 0x1819D97D0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DA050 Offset: 0x19D8650 VA: 0x1819DA050
	internal static void set_StatsRecieved(bool value) { }

	// RVA: 0x19D9870 Offset: 0x19D7E70 VA: 0x1819D9870
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D9E00 Offset: 0x19D8400 VA: 0x1819D9E00
	public static void add_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D9FA0 Offset: 0x19D85A0 VA: 0x1819D9FA0
	public static void remove_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[IteratorStateMachineAttribute] // RVA: 0x96620 Offset: 0x95A20 VA: 0x180096620
	// RVA: 0x19D9EB0 Offset: 0x19D84B0 VA: 0x1819D9EB0
	public static IEnumerable<Achievement> get_Achievements() { }

	// RVA: 0x19D9D90 Offset: 0x19D8390 VA: 0x1819D9D90
	public static bool StoreStats() { }

	// RVA: 0x19D9CB0 Offset: 0x19D82B0 VA: 0x1819D9CB0
	public static bool RequestCurrentStats() { }

	// RVA: 0x19D9D10 Offset: 0x19D8310 VA: 0x1819D9D10
	public static bool SetStat(string name, int value) { }

	// RVA: 0x19D9D50 Offset: 0x19D8350 VA: 0x1819D9D50
	public static bool SetStat(string name, float value) { }

	// RVA: 0x19D9790 Offset: 0x19D7D90 VA: 0x1819D9790
	public static int GetStatInt(string name) { }

	// RVA: 0x19D9740 Offset: 0x19D7D40 VA: 0x1819D9740
	public static float GetStatFloat(string name) { }

	// RVA: 0x19D9CE0 Offset: 0x19D82E0 VA: 0x1819D9CE0
	public static bool ResetAll(bool includeAchievements) { }

	// RVA: 0x19D9DC0 Offset: 0x19D83C0 VA: 0x1819D9DC0
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

	// RVA: 0x19DFDE0 Offset: 0x19DE3E0 VA: 0x1819DFDE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DFA70 Offset: 0x19DE070 VA: 0x1819DFA70
	internal void <InstallEvents>b__7_0(UserStatsReceived_t x) { }

	// RVA: 0x19DFB60 Offset: 0x19DE160 VA: 0x1819DFB60
	internal void <InstallEvents>b__7_1(UserStatsStored_t x) { }

	// RVA: 0x19DFBC0 Offset: 0x19DE1C0 VA: 0x1819DFBC0
	internal void <InstallEvents>b__7_2(UserAchievementStored_t x) { }

	// RVA: 0x19DFC60 Offset: 0x19DE260 VA: 0x1819DFC60
	internal void <InstallEvents>b__7_3(UserStatsUnloaded_t x) { }

	// RVA: 0x19DFCD0 Offset: 0x19DE2D0 VA: 0x1819DFCD0
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
	// RVA: 0xD87490 Offset: 0xD85A90 VA: 0x180D87490
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19E02E0 Offset: 0x19DE8E0 VA: 0x1819E02E0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0430 Offset: 0x19DEA30 VA: 0x1819E0430 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0480 Offset: 0x19DEA80 VA: 0x1819E0480 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E03A0 Offset: 0x19DE9A0 VA: 0x1819E03A0 Slot: 4
	private IEnumerator<Achievement> System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E03A0 Offset: 0x19DE9A0 VA: 0x1819E03A0 Slot: 5
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

	// RVA: 0x19DC650 Offset: 0x19DAC50 VA: 0x1819DC650
	internal static ISteamUtils get_Internal() { }

	// RVA: 0x19DC100 Offset: 0x19DA700 VA: 0x1819DC100 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19DC1B0 Offset: 0x19DA7B0 VA: 0x1819DC1B0
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19DC540 Offset: 0x19DAB40 VA: 0x1819DC540
	private static void SteamClosed() { }

	// RVA: 0x19DC6D0 Offset: 0x19DACD0 VA: 0x1819DC6D0
	public static string get_IpCountry() { }

	// RVA: 0x19DBDC0 Offset: 0x19DA3C0 VA: 0x1819DBDC0
	public static bool GetImageSize(int image, out uint width, out uint height) { }

	// RVA: 0x19DBE60 Offset: 0x19DA460 VA: 0x1819DBE60
	public static Nullable<Image> GetImage(int image) { }

	// RVA: 0x19DC730 Offset: 0x19DAD30 VA: 0x1819DC730
	public static bool get_IsOverlayEnabled() { }

	// RVA: 0x19DC0A0 Offset: 0x19DA6A0 VA: 0x1819DC0A0
	public static bool InitFilterText() { }

	// RVA: 0x19DBD10 Offset: 0x19DA310 VA: 0x1819DBD10
	public static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage) { }

	// RVA: 0x19DC610 Offset: 0x19DAC10 VA: 0x1819DC610
	public void .ctor() { }

	// RVA: 0x19DC5D0 Offset: 0x19DABD0 VA: 0x1819DC5D0
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

	// RVA: 0x19DFF00 Offset: 0x19DE500 VA: 0x1819DFF00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DEF40 Offset: 0x19DD540 VA: 0x1819DEF40
	internal void <InstallEvents>b__3_0(IPCountry_t x) { }

	// RVA: 0x19DF240 Offset: 0x19DD840 VA: 0x1819DF240
	internal void <InstallEvents>b__3_1(LowBatteryPower_t x) { }

	// RVA: 0x19DF2C0 Offset: 0x19DD8C0 VA: 0x1819DF2C0
	internal void <InstallEvents>b__3_2(SteamShutdown_t x) { }

	// RVA: 0x19DF490 Offset: 0x19DDA90 VA: 0x1819DF490
	internal void <InstallEvents>b__3_3(GamepadTextInputDismissed_t x) { }

}

public class SteamVideo : SteamClientClass<SteamVideo> // TypeDefIndex: 5234
{	// Methods

	// RVA: 0x19DC790 Offset: 0x19DAD90 VA: 0x1819DC790 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InstallEvents() { }

	// RVA: 0x19DC810 Offset: 0x19DAE10 VA: 0x1819DC810
	public void .ctor() { }

}

public struct SteamId // TypeDefIndex: 5252
{	// Fields
	public ulong Value; // 0x0

	// Properties
	public uint AccountId { get; }

	// Methods

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static SteamId op_Implicit(ulong value) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static ulong op_Implicit(SteamId value) { }

	// RVA: 0x1231C0 Offset: 0x1225C0 VA: 0x1801231C0 Slot: 3
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

	// RVA: 0xDE6860 Offset: 0xDE4E60 VA: 0x180DE6860 Slot: 4
	public virtual IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDE6830 Offset: 0xDE4E30 VA: 0x180DE6830 Slot: 5
	public virtual IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDE6800 Offset: 0xDE4E00 VA: 0x180DE6800 Slot: 6
	public virtual IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDE6950 Offset: 0xDE4F50 VA: 0x180DE6950
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BC90 Offset: 0x82A290 VA: 0x18082BC90
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BCC0 Offset: 0x82A2C0 VA: 0x18082BCC0
	private void set_IsServer(bool value) { }

	// RVA: 0xDE6890 Offset: 0xDE4E90 VA: 0x180DE6890
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
	|-RVA: 0x1A509D0 Offset: 0x1A4EFD0 VA: 0x181A509D0
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
	|-RVA: 0x1A50960 Offset: 0x1A4EF60 VA: 0x181A50960
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
	|-RVA: 0x1A508F0 Offset: 0x1A4EEF0 VA: 0x181A508F0
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
	|-RVA: 0xD50CE0 Offset: 0xD4F2E0 VA: 0x180D50CE0
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
	|-RVA: 0x1A50850 Offset: 0x1A4EE50 VA: 0x181A50850
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
	|-RVA: 0x1A50810 Offset: 0x1A4EE10 VA: 0x181A50810
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
	|-RVA: 0xD50CE0 Offset: 0xD4F2E0 VA: 0x180D50CE0
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

	// RVA: 0x19D8290 Offset: 0x19D6890 VA: 0x1819D8290
	public static SteamParamStringArray From(string[] array) { }

	// RVA: 0x224CD0 Offset: 0x2240D0 VA: 0x180224CD0 Slot: 4
	public void Dispose() { }

}

internal struct SteamServersConnected_t : ICallbackData // TypeDefIndex: 5293
{	// Fields
	public static int _datasize; // 0x138C8

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA070 Offset: 0x1D9470 VA: 0x1801DA070 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA060 Offset: 0x1D9460 VA: 0x1801DA060 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290A50 Offset: 0x128F050 VA: 0x181290A50
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

	// RVA: 0x1DA000 Offset: 0x1D9400 VA: 0x1801DA000 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9FF0 Offset: 0x1D93F0 VA: 0x1801D9FF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12909A0 Offset: 0x128EFA0 VA: 0x1812909A0
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

	// RVA: 0x1DA0E0 Offset: 0x1D94E0 VA: 0x1801DA0E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA0D0 Offset: 0x1D94D0 VA: 0x1801DA0D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290B00 Offset: 0x128F100 VA: 0x181290B00
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

	// RVA: 0x1D8AC0 Offset: 0x1D7EC0 VA: 0x1801D8AC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8AB0 Offset: 0x1D7EB0 VA: 0x1801D8AB0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FB60 Offset: 0x128E160 VA: 0x18128FB60
	private static void .cctor() { }

}

internal struct SteamShutdown_t : ICallbackData // TypeDefIndex: 5330
{	// Fields
	public static int _datasize; // 0x2B101A0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA150 Offset: 0x1D9550 VA: 0x1801DA150 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA140 Offset: 0x1D9540 VA: 0x1801DA140 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290BB0 Offset: 0x128F1B0 VA: 0x181290BB0
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

	// RVA: 0x1D8D20 Offset: 0x1D8120 VA: 0x1801D8D20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8D10 Offset: 0x1D8110 VA: 0x1801D8D10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FDE0 Offset: 0x128E3E0 VA: 0x18128FDE0
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

	// RVA: 0x1D8D90 Offset: 0x1D8190 VA: 0x1801D8D90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8D80 Offset: 0x1D8180 VA: 0x1801D8D80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FE80 Offset: 0x128E480 VA: 0x18128FE80
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

	// RVA: 0x1D8CB0 Offset: 0x1D80B0 VA: 0x1801D8CB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8CA0 Offset: 0x1D80A0 VA: 0x1801D8CA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FD40 Offset: 0x128E340 VA: 0x18128FD40
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

	// RVA: 0x1DAA90 Offset: 0x1D9E90 VA: 0x1801DAA90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DAA80 Offset: 0x1D9E80 VA: 0x1801DAA80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290DE0 Offset: 0x128F3E0 VA: 0x181290DE0
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

	// RVA: 0x1DAC70 Offset: 0x1DA070 VA: 0x1801DAC70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DAC60 Offset: 0x1DA060 VA: 0x1801DAC60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290E90 Offset: 0x128F490 VA: 0x181290E90
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

	// RVA: 0x1D8BD0 Offset: 0x1D7FD0 VA: 0x1801D8BD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8BC0 Offset: 0x1D7FC0 VA: 0x1801D8BC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FC00 Offset: 0x128E200 VA: 0x18128FC00
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

	// RVA: 0x1D8C40 Offset: 0x1D8040 VA: 0x1801D8C40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8C30 Offset: 0x1D8030 VA: 0x1801D8C30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FCA0 Offset: 0x128E2A0 VA: 0x18128FCA0
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

	// RVA: 0x1D9140 Offset: 0x1D8540 VA: 0x1801D9140 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9130 Offset: 0x1D8530 VA: 0x1801D9130 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290250 Offset: 0x128E850 VA: 0x181290250
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

	// RVA: 0x1D8EE0 Offset: 0x1D82E0 VA: 0x1801D8EE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8ED0 Offset: 0x1D82D0 VA: 0x1801D8ED0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290070 Offset: 0x128E670 VA: 0x181290070
	private static void .cctor() { }

}

internal struct SteamInventoryDefinitionUpdate_t : ICallbackData // TypeDefIndex: 5476
{	// Fields
	public static int _datasize; // 0x13BB3

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8E00 Offset: 0x1D8200 VA: 0x1801D8E00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8DF0 Offset: 0x1D81F0 VA: 0x1801D8DF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FF20 Offset: 0x128E520 VA: 0x18128FF20
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

	// RVA: 0x1D8E70 Offset: 0x1D8270 VA: 0x1801D8E70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8E60 Offset: 0x1D8260 VA: 0x1801D8E60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128FFD0 Offset: 0x128E5D0 VA: 0x18128FFD0
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

	// RVA: 0x1D9240 Offset: 0x1D8640 VA: 0x1801D9240 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9230 Offset: 0x1D8630 VA: 0x1801D9230 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12902F0 Offset: 0x128E8F0 VA: 0x1812902F0
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

	// RVA: 0x1D8F40 Offset: 0x1D8340 VA: 0x1801D8F40
	internal string CurrencyUTF8() { }

	// RVA: 0x1D8FD0 Offset: 0x1D83D0 VA: 0x1801D8FD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8FC0 Offset: 0x1D83C0 VA: 0x1801D8FC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12901A0 Offset: 0x128E7A0 VA: 0x1812901A0
	private static void .cctor() { }

}

internal struct SteamParentalSettingsChanged_t : ICallbackData // TypeDefIndex: 5482
{	// Fields
	public static int _datasize; // 0x2B101BC

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9CD0 Offset: 0x1D90D0 VA: 0x1801D9CD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9CC0 Offset: 0x1D90C0 VA: 0x1801D9CC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12906E0 Offset: 0x128ECE0 VA: 0x1812906E0
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

	// RVA: 0x1D9F20 Offset: 0x1D9320 VA: 0x1801D9F20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9F10 Offset: 0x1D9310 VA: 0x1801D9F10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290840 Offset: 0x128EE40 VA: 0x181290840
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

	// RVA: 0x1D9F90 Offset: 0x1D9390 VA: 0x1801D9F90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9F80 Offset: 0x1D9380 VA: 0x1801D9F80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12908F0 Offset: 0x128EEF0 VA: 0x1812908F0
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

	// RVA: 0x1D9BF0 Offset: 0x1D8FF0 VA: 0x1801D9BF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9BE0 Offset: 0x1D8FE0 VA: 0x1801D9BE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290640 Offset: 0x128EC40 VA: 0x181290640
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

	// RVA: 0x1D99F0 Offset: 0x1D8DF0 VA: 0x1801D99F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D99E0 Offset: 0x1D8DE0 VA: 0x1801D99E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12905A0 Offset: 0x128EBA0 VA: 0x1812905A0
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

	// RVA: 0x1D94D0 Offset: 0x1D88D0 VA: 0x1801D94D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D94C0 Offset: 0x1D88C0 VA: 0x1801D94C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290440 Offset: 0x128EA40 VA: 0x181290440
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

	// RVA: 0x1D9320 Offset: 0x1D8720 VA: 0x1801D9320 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9310 Offset: 0x1D8710 VA: 0x1801D9310 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12903A0 Offset: 0x128E9A0 VA: 0x1812903A0
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

	// RVA: 0x1D9D40 Offset: 0x1D9140 VA: 0x1801D9D40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9D30 Offset: 0x1D9130 VA: 0x1801D9D30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290790 Offset: 0x128ED90 VA: 0x181290790
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

	// RVA: 0x1D9720 Offset: 0x1D8B20 VA: 0x1801D9720 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9710 Offset: 0x1D8B10 VA: 0x1801D9710 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12904F0 Offset: 0x128EAF0 VA: 0x1812904F0
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

	// RVA: 0x1DA2B0 Offset: 0x1D96B0 VA: 0x1801DA2B0
	internal string TitleUTF8() { }

	// RVA: 0x1DA1B0 Offset: 0x1D95B0 VA: 0x1801DA1B0
	internal string DescriptionUTF8() { }

	// RVA: 0x1DA230 Offset: 0x1D9630 VA: 0x1801DA230
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

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static SteamAPICall_t op_Implicit(ulong value) { }

	// RVA: 0x1231C0 Offset: 0x1225C0 VA: 0x1801231C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8BB0 Offset: 0x1D7FB0 VA: 0x1801D8BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D8B40 Offset: 0x1D7F40 VA: 0x1801D8B40 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D8B30 Offset: 0x1D7F30 VA: 0x1801D8B30 Slot: 4
	public bool Equals(SteamAPICall_t p) { }

	// RVA: 0x1D8B20 Offset: 0x1D7F20 VA: 0x1801D8B20 Slot: 5
	public int CompareTo(SteamAPICall_t other) { }

}

internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t> // TypeDefIndex: 5539
{	// Fields
	public int Value; // 0x0

	// Methods

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static SteamInventoryResult_t op_Implicit(int value) { }

	// RVA: 0x1D9220 Offset: 0x1D8620 VA: 0x1801D9220 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D91B0 Offset: 0x1D85B0 VA: 0x1801D91B0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7CB0 Offset: 0x1D70B0 VA: 0x1801D7CB0 Slot: 4
	public bool Equals(SteamInventoryResult_t p) { }

	// RVA: 0x1D91A0 Offset: 0x1D85A0 VA: 0x1801D91A0 Slot: 5
	public int CompareTo(SteamInventoryResult_t other) { }

}

internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t> // TypeDefIndex: 5540
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0
	public static SteamInventoryUpdateHandle_t op_Implicit(ulong value) { }

	// RVA: 0x1231C0 Offset: 0x1225C0 VA: 0x1801231C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8BB0 Offset: 0x1D7FB0 VA: 0x1801D8BB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D92A0 Offset: 0x1D86A0 VA: 0x1801D92A0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D8B30 Offset: 0x1D7F30 VA: 0x1801D8B30 Slot: 4
	public bool Equals(SteamInventoryUpdateHandle_t p) { }

	// RVA: 0x1D8B20 Offset: 0x1D7F20 VA: 0x1801D8B20 Slot: 5
	public int CompareTo(SteamInventoryUpdateHandle_t other) { }

}

internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID> // TypeDefIndex: 5542
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x68A6C0 Offset: 0x688CC0 VA: 0x18068A6C0
	public static SteamNetworkingPOPID op_Implicit(uint value) { }

	// RVA: 0x1D7CC0 Offset: 0x1D70C0 VA: 0x1801D7CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9C50 Offset: 0x1D9050 VA: 0x1801D9C50 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7CB0 Offset: 0x1D70B0 VA: 0x1801D7CB0 Slot: 4
	public bool Equals(SteamNetworkingPOPID p) { }

	// RVA: 0x1D7C30 Offset: 0x1D7030 VA: 0x1801D7C30 Slot: 5
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

	// RVA: 0x21EA670 Offset: 0x21E8C70 VA: 0x1821EA670 Slot: 4
	public string get_Key() { }

	// RVA: 0x21EA660 Offset: 0x21E8C60 VA: 0x1821EA660 Slot: 5
	public bool get_IsUnlocked() { }

	// RVA: 0x21EA630 Offset: 0x21E8C30 VA: 0x1821EA630
	internal void .ctor(Achievement achievement) { }

	// RVA: 0x21EA620 Offset: 0x21E8C20 VA: 0x1821EA620 Slot: 6
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

	// RVA: 0x21EA6A0 Offset: 0x21E8CA0 VA: 0x1821EA6A0
	internal void .ctor(AuthTicket ticket) { }

	// RVA: 0x21EA680 Offset: 0x21E8C80 VA: 0x1821EA680 Slot: 6
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

	// RVA: 0x21EA7B0 Offset: 0x21E8DB0 VA: 0x1821EA7B0 Slot: 5
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public InventoryResult get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 5
	public IReadOnlyList<IPlayerItem> get_Items() { }

	// RVA: 0x21EA840 Offset: 0x21E8E40 VA: 0x1821EA840
	internal void .ctor(InventoryResult inventory) { }

	// RVA: 0x21EA800 Offset: 0x21E8E00 VA: 0x1821EA800 Slot: 7
	public void Dispose() { }

	// RVA: 0x21EA7D0 Offset: 0x21E8DD0 VA: 0x1821EA7D0 Slot: 4
	public bool BelongsTo(ulong userId) { }

	// RVA: 0x21EA820 Offset: 0x21E8E20 VA: 0x1821EA820 Slot: 6
	public byte[] Serialize() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5714
{	// Fields
	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Func<InventoryItem, SteamItem> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x21F0A60 Offset: 0x21EF060 VA: 0x1821F0A60
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F0650 Offset: 0x21EEC50 VA: 0x1821F0650
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

	// RVA: 0x21EAFE0 Offset: 0x21E95E0 VA: 0x1821EAFE0
	public void .ctor(InventoryItem item) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x12FA5F0 Offset: 0x12F8BF0 VA: 0x1812FA5F0 Slot: 5
	public int get_Quantity() { }

	// RVA: 0x21EB020 Offset: 0x21E9620 VA: 0x1821EB020 Slot: 6
	public DateTimeOffset get_Acquired() { }

	// RVA: 0x21EB120 Offset: 0x21E9720 VA: 0x1821EB120 Slot: 7
	public ulong get_WorkshopId() { }

	// RVA: 0x21EB0B0 Offset: 0x21E96B0 VA: 0x1821EB0B0 Slot: 8
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public InventoryDef get_Value() { }

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(InventoryDef value) { }

	// RVA: 0x21EAD60 Offset: 0x21E9360 VA: 0x1821EAD60 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x21EAE90 Offset: 0x21E9490 VA: 0x1821EAE90 Slot: 5
	public string get_Name() { }

	// RVA: 0x21EAD80 Offset: 0x21E9380 VA: 0x1821EAD80 Slot: 6
	public string get_Description() { }

	// RVA: 0x21EAF20 Offset: 0x21E9520 VA: 0x1821EAF20 Slot: 7
	public string get_Type() { }

	// RVA: 0x21EADA0 Offset: 0x21E93A0 VA: 0x1821EADA0 Slot: 8
	public string get_IconUrl() { }

	// RVA: 0x21EAE70 Offset: 0x21E9470 VA: 0x1821EAE70 Slot: 9
	public int get_LocalPrice() { }

	// RVA: 0x21EAE50 Offset: 0x21E9450 VA: 0x1821EAE50 Slot: 10
	public string get_LocalPriceFormatted() { }

	// RVA: 0x21EAEB0 Offset: 0x21E94B0 VA: 0x1821EAEB0 Slot: 11
	public string get_PriceCategory() { }

	// RVA: 0x21EADC0 Offset: 0x21E93C0 VA: 0x1821EADC0 Slot: 12
	public bool get_IsGenerator() { }

	// RVA: 0x21EADE0 Offset: 0x21E93E0 VA: 0x1821EADE0 Slot: 13
	public bool get_IsMarketable() { }

	// RVA: 0x21EAED0 Offset: 0x21E94D0 VA: 0x1821EAED0 Slot: 14
	public string get_StoreTags() { }

	// RVA: 0x21EAE00 Offset: 0x21E9400 VA: 0x1821EAE00 Slot: 15
	public string get_ItemShortName() { }

	// RVA: 0x21EAF90 Offset: 0x21E9590 VA: 0x1821EAF90 Slot: 16
	public ulong get_WorkshopId() { }

	// RVA: 0x21EAF40 Offset: 0x21E9540 VA: 0x1821EAF40 Slot: 17
	public ulong get_WorkshopDownload() { }

	// RVA: 0x21EAB70 Offset: 0x21E9170 VA: 0x1821EAB70 Slot: 18
	public IEnumerable<PlayerItemRecipe> GetRecipesContainingThis() { }

	// RVA: 0x21EAC00 Offset: 0x21E9200 VA: 0x1821EAC00
	private static PlayerItemRecipe SteamToPlatformRecipe(InventoryRecipe recipe) { }

	// RVA: 0x155E3F0 Offset: 0x155C9F0 VA: 0x18155E3F0 Slot: 19
	public bool Equals(IPlayerItemDefinition other) { }

	// RVA: 0x21EA9B0 Offset: 0x21E8FB0 VA: 0x1821EA9B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21EAB20 Offset: 0x21E9120 VA: 0x1821EAB20 Slot: 2
	public override int GetHashCode() { }

}

private sealed class SteamItemDefinition.<>c // TypeDefIndex: 5717
{	// Fields
	public static readonly SteamItemDefinition.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x21F0B20 Offset: 0x21EF120 VA: 0x1821F0B20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F0610 Offset: 0x21EEC10 VA: 0x1821F0610
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
	// RVA: 0x21ECF00 Offset: 0x21EB500 VA: 0x1821ECF00
	private static void LoadAvatarFromSteamAsync(ulong userId, Texture2D texture) { }

	// RVA: 0x21EBE40 Offset: 0x21EA440 VA: 0x1821EBE40 Slot: 19
	public Texture2D GetAvatarTexture(ulong userId) { }

	// RVA: 0x21EBEB0 Offset: 0x21EA4B0 VA: 0x1821EBEB0 Slot: 45
	public IDownloadableContent GetDownloadableContent(int appId) { }

	// RVA: 0x21EC580 Offset: 0x21EAB80 VA: 0x1821EC580 Slot: 46
	public IWorkshopContent GetWorkshopContent(ulong workshopId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 36
	public IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	private void set_ItemDefinitions(IReadOnlyList<IPlayerItemDefinition> value) { }

	// RVA: 0x364A70 Offset: 0x363070 VA: 0x180364A70 Slot: 37
	public void RefreshItemDefinitions() { }

	// RVA: 0x21EBFF0 Offset: 0x21EA5F0 VA: 0x1821EBFF0 Slot: 38
	public IPlayerItemDefinition GetItemDefinition(int definitionId) { }

	// RVA: 0x21ECFE0 Offset: 0x21EB5E0 VA: 0x1821ECFE0
	private void OnDefinitionsUpdated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 39
	public IReadOnlyList<IPlayerItem> get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_Items(IReadOnlyList<IPlayerItem> value) { }

	// RVA: 0x21ED330 Offset: 0x21EB930 VA: 0x1821ED330 Slot: 40
	public void RefreshItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB410 Offset: 0xCA810 VA: 0x1800CB410
	// RVA: 0x21ED260 Offset: 0x21EB860 VA: 0x1821ED260 Slot: 41
	public Task<IPlayerInventory> RefreshAndGetItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB650 Offset: 0xCAA50 VA: 0x1800CB650
	// RVA: 0x21EB5B0 Offset: 0x21E9BB0 VA: 0x1821EB5B0 Slot: 42
	public Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output) { }

	[AsyncStateMachineAttribute] // RVA: 0xCB8F0 Offset: 0xCACF0 VA: 0x1800CB8F0
	// RVA: 0x21EC220 Offset: 0x21EA820 VA: 0x1821EC220 Slot: 43
	public Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices() { }

	// RVA: 0x21EBB50 Offset: 0x21EA150 VA: 0x1821EBB50 Slot: 44
	public string FormatPrice(int price) { }

	// RVA: 0x21ED150 Offset: 0x21EB750 VA: 0x1821ED150
	private void OnInventoryUpdated(InventoryResult result) { }

	// RVA: 0x21EB3B0 Offset: 0x21E99B0 VA: 0x1821EB3B0
	private void ConfiscatedItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCBBA0 Offset: 0xCAFA0 VA: 0x1800CBBA0
	// RVA: 0x21ECE30 Offset: 0x21EB430 VA: 0x1821ECE30
	private Task InventoryDropAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 8
	public ulong get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE6420 Offset: 0xEE4A20 VA: 0x180EE6420
	private void set_UserId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 9
	public string get_UserName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	private void set_UserName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 10
	public string get_Country() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	private void set_Country(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 11
	public string get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	private void set_Language(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 12
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	private void set_Version(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 13
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	private void set_Branch(string value) { }

	// RVA: 0x21EBDB0 Offset: 0x21EA3B0 VA: 0x1821EBDB0 Slot: 14
	public IAuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0xCCAB0 Offset: 0xCBEB0 VA: 0x1800CCAB0
	// RVA: 0x21EBCE0 Offset: 0x21EA2E0 VA: 0x1821EBCE0 Slot: 15
	public Task<IAuthTicket> GetAuthSessionTicketAsync() { }

	// RVA: 0x21EDB40 Offset: 0x21EC140 VA: 0x1821EDB40 Slot: 16
	public IEnumerable<IPlayerInfo> get_Friends() { }

	// RVA: 0x21EC4F0 Offset: 0x21EAAF0 VA: 0x1821EC4F0 Slot: 17
	public IPlayerInfo GetPlayerInformation(ulong userId) { }

	[AsyncStateMachineAttribute] // RVA: 0xCCC40 Offset: 0xCC040 VA: 0x1800CCC40
	// RVA: 0x21EC3D0 Offset: 0x21EA9D0 VA: 0x1821EC3D0 Slot: 18
	public Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId) { }

	// RVA: 0x21EC2F0 Offset: 0x21EA8F0 VA: 0x1821EC2F0
	private SteamPlayer GetOrAddPlayer(ulong userId) { }

	// RVA: 0x21EB9E0 Offset: 0x21E9FE0 VA: 0x1821EB9E0 Slot: 27
	public string FilterChat(ulong userId, string message) { }

	// RVA: 0x21EBAD0 Offset: 0x21EA0D0 VA: 0x1821EBAD0 Slot: 28
	public string FilterName(ulong userId, string message) { }

	// RVA: 0x21EBA60 Offset: 0x21EA060 VA: 0x1821EBA60 Slot: 29
	public string FilterGeneric(string message) { }

	// RVA: 0x21EB3A0 Offset: 0x21E99A0 VA: 0x1821EB3A0 Slot: 47
	public void ClearRichPresence() { }

	// RVA: 0x21EC570 Offset: 0x21EAB70 VA: 0x1821EC570 Slot: 48
	public string GetRichPresence(string key) { }

	// RVA: 0x21ED5C0 Offset: 0x21EBBC0 VA: 0x1821ED5C0 Slot: 49
	public void SetRichPresence(string key, string value) { }

	// RVA: 0x21EB6D0 Offset: 0x21E9CD0 VA: 0x1821EB6D0 Slot: 20
	public IServerQuery CreateServerQuery(ServerQuerySet querySet) { }

	// RVA: 0x21EB830 Offset: 0x21E9E30 VA: 0x1821EB830 Slot: 21
	public IServerQuery CreateServerQuery(IEnumerable<string> endpoints) { }

	// RVA: 0x21EB2A0 Offset: 0x21E98A0 VA: 0x1821EB2A0 Slot: 22
	public void AddServerToHistory(ServerInfo server) { }

	// RVA: 0x21ED480 Offset: 0x21EBA80 VA: 0x1821ED480 Slot: 23
	public void RemoveServerFromHistory(ServerInfo server) { }

	// RVA: 0x21EDAB0 Offset: 0x21EC0B0 VA: 0x1821EDAB0 Slot: 24
	public IReadOnlyList<ServerInfo> get_FavoriteServers() { }

	// RVA: 0x21EB1A0 Offset: 0x21E97A0 VA: 0x1821EB1A0 Slot: 25
	public void AddServerToFavorites(ServerInfo server) { }

	// RVA: 0x21ED380 Offset: 0x21EB980 VA: 0x1821ED380 Slot: 26
	public void RemoveServerFromFavorites(ServerInfo server) { }

	// RVA: 0x21ED780 Offset: 0x21EBD80 VA: 0x1821ED780
	internal static ServerInfo ToPlatformServer(ServerInfo info) { }

	// RVA: 0x21ED830 Offset: 0x21EBE30 VA: 0x1821ED830
	internal static ServerInfo ToSteamServer(ServerInfo server) { }

	// RVA: 0x21EBBF0 Offset: 0x21EA1F0 VA: 0x1821EBBF0 Slot: 50
	public IAchievement GetAchievement(string key) { }

	// RVA: 0x21ED580 Offset: 0x21EBB80 VA: 0x1821ED580 Slot: 51
	public void RequestCurrentStats() { }

	// RVA: 0x21EBFB0 Offset: 0x21EA5B0 VA: 0x1821EBFB0 Slot: 52
	public long GetGlobalStatInt(string key) { }

	// RVA: 0x21EC550 Offset: 0x21EAB50 VA: 0x1821EC550 Slot: 53
	public long GetPlayerStatInt(string key) { }

	// RVA: 0x21ED5B0 Offset: 0x21EBBB0 VA: 0x1821ED5B0 Slot: 54
	public void SetPlayerStatInt(string key, long value) { }

	// RVA: 0x21EBF70 Offset: 0x21EA570 VA: 0x1821EBF70 Slot: 55
	public double GetGlobalStatFloat(string key) { }

	// RVA: 0x21EC530 Offset: 0x21EAB30 VA: 0x1821EC530 Slot: 56
	public double GetPlayerStatFloat(string key) { }

	// RVA: 0x21ED590 Offset: 0x21EBB90 VA: 0x1821ED590 Slot: 57
	public void SetPlayerStatFloat(string key, double value) { }

	// RVA: 0x21EDCB0 Offset: 0x21EC2B0 VA: 0x1821EDCB0 Slot: 30
	public uint get_OptimalSampleRate() { }

	// RVA: 0x21EDD00 Offset: 0x21EC300 VA: 0x1821EDD00 Slot: 31
	public bool get_VoiceRecord() { }

	// RVA: 0x21EDDA0 Offset: 0x21EC3A0 VA: 0x1821EDDA0 Slot: 32
	public void set_VoiceRecord(bool value) { }

	// RVA: 0x21EDBC0 Offset: 0x21EC1C0 VA: 0x1821EDBC0 Slot: 33
	public bool get_HasVoiceData() { }

	// RVA: 0x21EBE60 Offset: 0x21EA460 VA: 0x1821EBE60 Slot: 34
	public byte[] GetCompressedVoiceData() { }

	// RVA: 0x21EB970 Offset: 0x21E9F70 VA: 0x1821EB970 Slot: 35
	public int DecompressVoiceData(byte[] data, MemoryStream outputStream) { }

	// RVA: 0x21EDC10 Offset: 0x21EC210 VA: 0x1821EDC10 Slot: 7
	public bool get_IsValid() { }

	// RVA: 0x21EC7C0 Offset: 0x21EADC0 VA: 0x1821EC7C0 Slot: 4
	public bool Initialize(IPlatformHooks hooks) { }

	// RVA: 0x21ED5E0 Offset: 0x21EBBE0 VA: 0x1821ED5E0 Slot: 5
	public void Shutdown() { }

	// RVA: 0x21ED8A0 Offset: 0x21EBEA0 VA: 0x1821ED8A0 Slot: 6
	public void Update() { }

	// RVA: 0x21ED340 Offset: 0x21EB940 VA: 0x1821ED340
	private static AuthResponse RemapAuthResponse(AuthResponse response) { }

	// RVA: 0x21EB8B0 Offset: 0x21E9EB0 VA: 0x1821EB8B0
	private static void DebugPrintSteamCallback(CallbackType type, string content, bool isServer) { }

	// RVA: 0x21ED960 Offset: 0x21EBF60 VA: 0x1821ED960
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21ED890 Offset: 0x21EBE90 VA: 0x1821ED890
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

	// RVA: 0x21F0AC0 Offset: 0x21EF0C0 VA: 0x1821F0AC0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F05B0 Offset: 0x21EEBB0 VA: 0x1821F05B0
	internal SteamItemDefinition <OnDefinitionsUpdated>b__13_0(InventoryDef d) { }

	// RVA: 0x21F04C0 Offset: 0x21EEAC0 VA: 0x1821F04C0
	internal InventoryItem <CraftItem>b__20_0(SteamItem i) { }

	// RVA: 0x21F04F0 Offset: 0x21EEAF0 VA: 0x1821F04F0
	internal IPlayerItemDefinition <GetItemDefinitionsWithPrices>b__21_0(InventoryDef d) { }

	// RVA: 0x21F0550 Offset: 0x21EEB50 VA: 0x1821F0550
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public Friend get_Value() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	public ulong get_UserId() { }

	// RVA: 0x21EE000 Offset: 0x21EC600 VA: 0x1821EE000 Slot: 5
	public string get_UserName() { }

	// RVA: 0x21EDE40 Offset: 0x21EC440 VA: 0x1821EDE40 Slot: 6
	public bool get_IsOnline() { }

	// RVA: 0x21EDE20 Offset: 0x21EC420 VA: 0x1821EDE20 Slot: 7
	public bool get_IsMe() { }

	// RVA: 0x21EDE00 Offset: 0x21EC400 VA: 0x1821EDE00 Slot: 8
	public bool get_IsFriend() { }

	// RVA: 0x21EDE60 Offset: 0x21EC460 VA: 0x1821EDE60 Slot: 9
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x21EDE80 Offset: 0x21EC480 VA: 0x1821EDE80 Slot: 10
	public string get_ServerEndpoint() { }

	// RVA: 0x139FB30 Offset: 0x139E130 VA: 0x18139FB30
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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Query(Base value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 5
	public IReadOnlyList<ServerInfo> get_Servers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EE2A0 Offset: 0x21EC8A0 VA: 0x1821EE2A0 Slot: 6
	public void add_OnServerFound(Action<ServerInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EE340 Offset: 0x21EC940 VA: 0x1821EE340 Slot: 7
	public void remove_OnServerFound(Action<ServerInfo> value) { }

	// RVA: 0x21EE140 Offset: 0x21EC740 VA: 0x1821EE140
	public void .ctor(ServerQuerySet set, Base query) { }

	// RVA: 0x21EE040 Offset: 0x21EC640 VA: 0x1821EE040 Slot: 10
	public void Dispose() { }

	// RVA: 0x21EE020 Offset: 0x21EC620 VA: 0x1821EE020 Slot: 8
	public void AddFilter(string key, string value) { }

	// RVA: 0x21EE110 Offset: 0x21EC710 VA: 0x1821EE110 Slot: 9
	public Task RunQueryAsync(double timeoutInSeconds) { }

}

private sealed class SteamServerQuery.<>c__DisplayClass13_0 // TypeDefIndex: 5729
{	// Fields
	public List<ServerInfo> serverList; // 0x10
	public SteamServerQuery <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F06C0 Offset: 0x21EECC0 VA: 0x1821F06C0
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

	// RVA: 0x21EE870 Offset: 0x21ECE70 VA: 0x1821EE870
	public static string get_betaName() { }

	// RVA: 0x21EE820 Offset: 0x21ECE20 VA: 0x1821EE820
	public static string get_betaBranch() { }

	// RVA: 0x21EE3E0 Offset: 0x21EC9E0 VA: 0x1821EE3E0
	private static string GetBetaName(bool full) { }

	// RVA: 0x21EE7B0 Offset: 0x21ECDB0 VA: 0x1821EE7B0
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
	// RVA: 0x21EF1F0 Offset: 0x21ED7F0 VA: 0x1821EF1F0
	public Item get_Value() { }

	// RVA: 0x21EF280 Offset: 0x21ED880 VA: 0x1821EF280 Slot: 4
	public ulong get_WorkshopId() { }

	// RVA: 0x21EF090 Offset: 0x21ED690 VA: 0x1821EF090 Slot: 5
	public string get_Title() { }

	// RVA: 0x21EEA20 Offset: 0x21ED020 VA: 0x1821EEA20 Slot: 6
	public string get_Description() { }

	// RVA: 0x21EEFE0 Offset: 0x21ED5E0 VA: 0x1821EEFE0 Slot: 7
	public IEnumerable<string> get_Tags() { }

	// RVA: 0x21EF140 Offset: 0x21ED740 VA: 0x1821EF140 Slot: 8
	public string get_Url() { }

	// RVA: 0x21EEF30 Offset: 0x21ED530 VA: 0x1821EEF30 Slot: 9
	public string get_PreviewImageUrl() { }

	// RVA: 0x21EED90 Offset: 0x21ED390 VA: 0x1821EED90 Slot: 10
	public ulong get_OwnerId() { }

	// RVA: 0x21EEE40 Offset: 0x21ED440 VA: 0x1821EEE40 Slot: 11
	public IPlayerInfo get_Owner() { }

	// RVA: 0x21EECE0 Offset: 0x21ED2E0 VA: 0x1821EECE0 Slot: 12
	public bool get_IsInstalled() { }

	// RVA: 0x21EEB80 Offset: 0x21ED180 VA: 0x1821EEB80 Slot: 13
	public bool get_IsDownloadPending() { }

	// RVA: 0x21EEC30 Offset: 0x21ED230 VA: 0x1821EEC30 Slot: 14
	public bool get_IsDownloading() { }

	// RVA: 0x21EEAD0 Offset: 0x21ED0D0 VA: 0x1821EEAD0 Slot: 15
	public string get_Directory() { }

	// RVA: 0x21EE970 Offset: 0x21ECF70 VA: 0x1821EE970
	public void .ctor(Item item) { }

	// RVA: 0x21EE8C0 Offset: 0x21ECEC0 VA: 0x1821EE8C0 Slot: 16
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

	// RVA: 0x22D9F40 Offset: 0x22D8540 VA: 0x1822D9F40
	public static SendType ToSteamSendType(SendMethod method, Priority priority) { }

	// RVA: 0x22D9F20 Offset: 0x22D8520 VA: 0x1822D9F20
	public static ushort ToSteamLaneIndexServer(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22D9F10 Offset: 0x22D8510 VA: 0x1822D9F10
	public static ushort ToSteamLaneIndexClient(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22D9DB0 Offset: 0x22D83B0 VA: 0x1822D9DB0
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x22D9E00 Offset: 0x22D8400 VA: 0x1822D9E00
	public static void SetDebugFunction() { }

	// RVA: 0x22D9E80 Offset: 0x22D8480 VA: 0x1822D9E80
	private static void SteamNetworkingUtils_OnDebugOutput(NetDebugOutput type, string str) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x22DA4D0 Offset: 0x22D8AD0 VA: 0x1822DA4D0
	public static string steamstatus() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x22D9DB0 Offset: 0x22D83B0 VA: 0x1822D9DB0
	public static void steamrelayinit() { }

	// RVA: 0x22DA020 Offset: 0x22D8620 VA: 0x1822DA020
	public static int get_steamnetdebug() { }

	// RVA: 0x22DA2F0 Offset: 0x22D88F0 VA: 0x1822DA2F0
	public static void set_steamnetdebug(int value) { }

	// RVA: 0x22D9FD0 Offset: 0x22D85D0 VA: 0x1822D9FD0
	public static int get_steamnetdebug_ackrtt() { }

	// RVA: 0x22DA2A0 Offset: 0x22D88A0 VA: 0x1822DA2A0
	public static void set_steamnetdebug_ackrtt(int value) { }

	// RVA: 0x22DA160 Offset: 0x22D8760 VA: 0x1822DA160
	public static int get_steamnetdebug_packetdecode() { }

	// RVA: 0x22DA3E0 Offset: 0x22D89E0 VA: 0x1822DA3E0
	public static void set_steamnetdebug_packetdecode(int value) { }

	// RVA: 0x22DA0C0 Offset: 0x22D86C0 VA: 0x1822DA0C0
	public static int get_steamnetdebug_message() { }

	// RVA: 0x22DA340 Offset: 0x22D8940 VA: 0x1822DA340
	public static void set_steamnetdebug_message(int value) { }

	// RVA: 0x22DA1B0 Offset: 0x22D87B0 VA: 0x1822DA1B0
	public static int get_steamnetdebug_packetgaps() { }

	// RVA: 0x22DA430 Offset: 0x22D8A30 VA: 0x1822DA430
	public static void set_steamnetdebug_packetgaps(int value) { }

	// RVA: 0x22DA110 Offset: 0x22D8710 VA: 0x1822DA110
	public static int get_steamnetdebug_p2prendezvous() { }

	// RVA: 0x22DA390 Offset: 0x22D8990 VA: 0x1822DA390
	public static void set_steamnetdebug_p2prendezvous(int value) { }

	// RVA: 0x22DA200 Offset: 0x22D8800 VA: 0x1822DA200
	public static int get_steamnetdebug_sdrrelaypings() { }

	// RVA: 0x22DA480 Offset: 0x22D8A80 VA: 0x1822DA480
	public static void set_steamnetdebug_sdrrelaypings(int value) { }

	// RVA: 0x22D9F80 Offset: 0x22D8580 VA: 0x1822D9F80
	public static int get_steamconnectiontimeout() { }

	// RVA: 0x22DA250 Offset: 0x22D8850 VA: 0x1822DA250
	public static void set_steamconnectiontimeout(int value) { }

}

public class SteamNetworking.Client : Client, IConnectionManager // TypeDefIndex: 7363
{	// Fields
	private ConnectionManager manager; // 0x70
	private const int bufferSize = 32;

	// Methods

	// RVA: 0x22CC5D0 Offset: 0x22CABD0 VA: 0x1822CC5D0 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22D7B10 Offset: 0x22D6110 VA: 0x1822D7B10 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22D7C70 Offset: 0x22D6270 VA: 0x1822D7C70 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22D7DE0 Offset: 0x22D63E0 VA: 0x1822D7DE0 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22D81A0 Offset: 0x22D67A0 VA: 0x1822D81A0 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	private void Steamworks.IConnectionManager.OnConnecting(ConnectionInfo info) { }

	// RVA: 0x22D82B0 Offset: 0x22D68B0 VA: 0x1822D82B0 Slot: 14
	private void Steamworks.IConnectionManager.OnConnected(ConnectionInfo info) { }

	// RVA: 0x22D82E0 Offset: 0x22D68E0 VA: 0x1822D82E0 Slot: 15
	private void Steamworks.IConnectionManager.OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x22D8360 Offset: 0x22D6960 VA: 0x1822D8360 Slot: 16
	private void Steamworks.IConnectionManager.OnMessage(IntPtr data, int datasize, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D7F60 Offset: 0x22D6560 VA: 0x1822D7F60 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D7FE0 Offset: 0x22D65E0 VA: 0x1822D7FE0 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22D8040 Offset: 0x22D6640 VA: 0x1822D8040 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22D8960 Offset: 0x22D6F60 VA: 0x1822D8960
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

	// RVA: 0x22D9D80 Offset: 0x22D8380 VA: 0x1822D9D80 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x22D9C60 Offset: 0x22D8260 VA: 0x1822D9C60
	public void .ctor(bool enableSteamDatagramRelay) { }

	// RVA: 0xEE6D10 Offset: 0xEE5310 VA: 0x180EE6D10 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22D97C0 Offset: 0x22D7DC0 VA: 0x1822D97C0 Slot: 10
	public override bool Start() { }

	// RVA: 0x22D9B90 Offset: 0x22D8190 VA: 0x1822D9B90 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22D8B30 Offset: 0x22D7130 VA: 0x1822D8B30 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22D8E10 Offset: 0x22D7410 VA: 0x1822D8E10 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22D89C0 Offset: 0x22D6FC0 VA: 0x1822D89C0 Slot: 12
	public override void Cycle() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22D9470 Offset: 0x22D7A70 VA: 0x1822D9470 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22D9650 Offset: 0x22D7C50 VA: 0x1822D9650
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22D9130 Offset: 0x22D7730 VA: 0x1822D9130 Slot: 19
	public void OnConnecting(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9000 Offset: 0x22D7600 VA: 0x1822D9000 Slot: 20
	public void OnConnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9150 Offset: 0x22D7750 VA: 0x1822D9150 Slot: 21
	public void OnDisconnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D91D0 Offset: 0x22D77D0 VA: 0x1822D91D0 Slot: 22
	public void OnMessage(Connection cn, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D8C10 Offset: 0x22D7210 VA: 0x1822D8C10 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D8BC0 Offset: 0x22D71C0 VA: 0x1822D8BC0 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22D8C70 Offset: 0x22D7270 VA: 0x1822D8C70 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

private sealed class SteamNetworking.Server.<>c // TypeDefIndex: 7365
{	// Fields
	public static readonly SteamNetworking.Server.<>c <>9; // 0x0
	public static Action<NetAddress> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x22DA7C0 Offset: 0x22D8DC0 VA: 0x1822DA7C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22DA730 Offset: 0x22D8D30 VA: 0x1822DA730
	internal void <Start>b__9_0(NetAddress fakeAddressCallback) { }

}

public class SteamInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8653
{	// Fields
	private IPlayerItem[] Items; // 0x20

	// Methods

	// RVA: 0x79C2F0 Offset: 0x79A8F0 VA: 0x18079C2F0 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79C1C0 Offset: 0x79A7C0 VA: 0x18079C1C0
	public bool HasItem(int itemid) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79BF10 Offset: 0x79A510 VA: 0x18079BF10
	private void ClientUpdateSteamInventory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x79BFB0 Offset: 0x79A5B0 VA: 0x18079BFB0
	public void ClientUpdate(IPlayerInventory result) { }

	// RVA: 0x79C7B0 Offset: 0x79ADB0 VA: 0x18079C7B0
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

	// RVA: 0xA8E4D0 Offset: 0xA8CAD0 VA: 0x180A8E4D0
	public bool IsInstalled() { }

	// RVA: 0xA8E330 Offset: 0xA8C930 VA: 0x180A8E330
	public bool CanUse(BasePlayer player) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
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

	// RVA: 0x79BE50 Offset: 0x79A450 VA: 0x18079BE50
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

	// RVA: 0x79BF00 Offset: 0x79A500 VA: 0x18079BF00
	public ItemDefinition get_itemDefinition() { }

	// RVA: 0x79BE60 Offset: 0x79A460 VA: 0x18079BE60 Slot: 4
	public virtual bool HasUnlocked(ulong playerId) { }

	// RVA: 0x79BEF0 Offset: 0x79A4F0 VA: 0x18079BEF0
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

	// RVA: 0xA8DB70 Offset: 0xA8C170 VA: 0x180A8DB70
	public Texture GetAvatarTexture(ulong steamid) { }

	// RVA: 0xA8DD80 Offset: 0xA8C380 VA: 0x180A8DD80
	public string GetUserName(ulong steamid) { }

	// RVA: 0xA8DFF0 Offset: 0xA8C5F0 VA: 0x180A8DFF0
	public static void SetPlayerPresence(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA8DA90 Offset: 0xA8C090 VA: 0x180A8DA90
	public static void ClearPlayerPresence() { }

	// RVA: 0xA8DCC0 Offset: 0xA8C2C0 VA: 0x180A8DCC0
	private static string GetLocalizationKey(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA8DE70 Offset: 0xA8C470 VA: 0x180A8DE70
	public static void Init() { }

	// RVA: 0xA8D9C0 Offset: 0xA8BFC0 VA: 0x180A8D9C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA8E260 Offset: 0xA8C860 VA: 0x180A8E260
	public void Update() { }

	// RVA: 0xA8DF80 Offset: 0xA8C580 VA: 0x180A8DF80
	public void OnDisable() { }

	// RVA: 0xA8E2D0 Offset: 0xA8C8D0 VA: 0x180A8E2D0
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
	public static SteamNewsSource.Story[] Stories; // 0x2B10180

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x992C0 Offset: 0x986C0 VA: 0x1800992C0
	// RVA: 0x79C7F0 Offset: 0x79ADF0 VA: 0x18079C7F0
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

	// RVA: 0x7B4900 Offset: 0x7B2F00 VA: 0x1807B4900 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B4DC0 Offset: 0x7B33C0 VA: 0x1807B4DC0 Slot: 8
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

	// RVA: 0xA8F120 Offset: 0xA8D720 VA: 0x180A8F120
	private void OnEnable() { }

	// RVA: 0xA8F470 Offset: 0xA8DA70 VA: 0x180A8F470
	public void Refresh() { }

	// RVA: 0xA8E640 Offset: 0xA8CC40 VA: 0x180A8E640
	public void AddPlayer(IPlayerInfo f) { }

	// RVA: 0xA8F130 Offset: 0xA8D730 VA: 0x180A8F130
	public int Priority(IPlayerInfo f) { }

	// RVA: 0xA8EC90 Offset: 0xA8D290 VA: 0x180A8EC90
	public void FilterSearch(string name) { }

	// RVA: 0xA8E750 Offset: 0xA8CD50 VA: 0x180A8E750
	public void AddToPanel(IEnumerable<IPlayerInfo> list, int count = -1) { }

	// RVA: 0xA8ED70 Offset: 0xA8D370 VA: 0x180A8ED70
	private void FriendSelected(ulong steamid, string steamName) { }

	// RVA: 0xA8EDE0 Offset: 0xA8D3E0 VA: 0x180A8EDE0
	public static void JustSeen(ulong steamid) { }

	// RVA: 0xA8FEE0 Offset: 0xA8E4E0 VA: 0x180A8FEE0
	public void .ctor() { }

	// RVA: 0xA8FE80 Offset: 0xA8E480 VA: 0x180A8FE80
	private static void .cctor() { }

}

public class SteamFriendsList.onFriendSelectedEvent : UnityEvent<ulong, string> // TypeDefIndex: 11222
{	// Methods

	// RVA: 0x7B56B0 Offset: 0x7B3CB0 VA: 0x1807B56B0
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass15_0 // TypeDefIndex: 11223
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E90 Offset: 0x7B3490 VA: 0x1807B4E90
	internal bool <AddPlayer>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass16_0 // TypeDefIndex: 11224
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F10 Offset: 0x7B3510 VA: 0x1807B4F10
	internal bool <Priority>b__0(PlayerTeam.TeamMember p) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass17_0 // TypeDefIndex: 11225
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F80 Offset: 0x7B3580 VA: 0x1807B4F80
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

	// RVA: 0x7B5080 Offset: 0x7B3680 VA: 0x1807B5080
	internal void <AddToPanel>b__1() { }

}

private sealed class SteamFriendsList.<>c // TypeDefIndex: 11228
{	// Fields
	public static readonly SteamFriendsList.<>c <>9; // 0x0
	public static Func<IPlayerInfo, string> <>9__18_0; // 0x8

	// Methods

	// RVA: 0x7B5210 Offset: 0x7B3810 VA: 0x1807B5210
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4E10 Offset: 0x7B3410 VA: 0x1807B4E10
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
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6E6D70 Offset: 0x6E5370 VA: 0x1806E6D70
	private void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	private void set_Username(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2590 Offset: 0xA1990 VA: 0x1800A2590
	// RVA: 0x79C840 Offset: 0x79AE40 VA: 0x18079C840
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

	// RVA: 0xF6650 Offset: 0xF5A50 VA: 0x1800F6650 Slot: 4
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
	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public IPlayerItemDefinition get_ResultItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF890 Offset: 0x4CDE90 VA: 0x1804CF890
	private void set_ResultItem(IPlayerItemDefinition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public Coroutine get_MarketCoroutine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	private void set_MarketCoroutine(Coroutine value) { }

	// RVA: 0x4CED80 Offset: 0x4CD380 VA: 0x1804CED80
	public void OnEnable() { }

	// RVA: 0x4CDAF0 Offset: 0x4CC0F0 VA: 0x1804CDAF0
	private void FillCraftingContainer() { }

	// RVA: 0x4CF750 Offset: 0x4CDD50 VA: 0x1804CF750
	public void Update() { }

	// RVA: 0x4CF350 Offset: 0x4CD950 VA: 0x1804CF350
	private void UpdateImpl(bool force) { }

	// RVA: 0x4CE280 Offset: 0x4CC880 VA: 0x1804CE280
	private void OnChanged(SteamInventoryItem[] items) { }

	// RVA: 0x4CF580 Offset: 0x4CDB80 VA: 0x1804CF580
	private void UpdateInfoText(int length, IPlayerItemDefinition definition, Nullable<double> totalValue) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1AF0 Offset: 0xD0EF0 VA: 0x1800D1AF0
	// RVA: 0x4CE0D0 Offset: 0x4CC6D0 VA: 0x1804CE0D0
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPrice(IPlayerItemDefinition definition) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1D70 Offset: 0xD1170 VA: 0x1800D1D70
	// RVA: 0x4CDFB0 Offset: 0x4CC5B0 VA: 0x1804CDFB0
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPriceImpl(IPlayerItemDefinition definition) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1E50 Offset: 0xD1250 VA: 0x1800D1E50
	// RVA: 0x4CE1F0 Offset: 0x4CC7F0 VA: 0x1804CE1F0
	private IEnumerator LoadMarketPrice(IPlayerItemDefinition definition) { }

	// RVA: 0x4CD6B0 Offset: 0x4CBCB0 VA: 0x1804CD6B0
	public void DoExchange() { }

	[AsyncStateMachineAttribute] // RVA: 0xD20C0 Offset: 0xD14C0 VA: 0x1800D20C0
	// RVA: 0x4CD9D0 Offset: 0x4CBFD0 VA: 0x1804CD9D0
	private Task ExchangeItems(SteamInventoryItem[] selected) { }

	// RVA: 0x4CEE10 Offset: 0x4CD410 VA: 0x1804CEE10
	public void OnRefreshed(IReadOnlyCollection<IPlayerItem> items) { }

	// RVA: 0x4CED90 Offset: 0x4CD390 VA: 0x1804CED90
	public void OnManualRefresh() { }

	// RVA: 0x4CF7C0 Offset: 0x4CDDC0 VA: 0x1804CF7C0
	public void .ctor() { }

	// RVA: 0x4CF760 Offset: 0x4CDD60 VA: 0x1804CF760
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

	// RVA: 0x4B3AB0 Offset: 0x4B20B0 VA: 0x1804B3AB0
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

	// RVA: 0x4D2680 Offset: 0x4D0C80 VA: 0x1804D2680
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1A60 Offset: 0x4D0060 VA: 0x1804D1A60
	internal bool <FillCraftingContainer>b__20_0(IPlayerItemDefinition x) { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <UpdateImpl>b__22_0(Toggle x) { }

	// RVA: 0x4D20D0 Offset: 0x4D06D0 VA: 0x1804D20D0
	internal SteamInventoryItem <UpdateImpl>b__22_1(Toggle x) { }

	// RVA: 0x4D1AC0 Offset: 0x4D00C0 VA: 0x1804D1AC0
	internal bool <OnChanged>b__23_0(SteamInventoryItem x) { }

	// RVA: 0x4D1AF0 Offset: 0x4D00F0 VA: 0x1804D1AF0
	internal bool <OnChanged>b__23_1(SteamInventoryItem x) { }

	// RVA: 0x4D1AC0 Offset: 0x4D00C0 VA: 0x1804D1AC0
	internal bool <OnChanged>b__23_2(SteamInventoryItem x) { }

	// RVA: 0x4D1B60 Offset: 0x4D0160 VA: 0x1804D1B60
	internal bool <OnChanged>b__23_3(SteamInventoryItem x) { }

	// RVA: 0x4D1AC0 Offset: 0x4D00C0 VA: 0x1804D1AC0
	internal bool <OnChanged>b__23_4(SteamInventoryItem x) { }

	// RVA: 0x4D1BD0 Offset: 0x4D01D0 VA: 0x1804D1BD0
	internal IEnumerable<PlayerItemRecipe> <OnChanged>b__23_5(SteamInventoryItem x) { }

	// RVA: 0x4D1C30 Offset: 0x4D0230 VA: 0x1804D1C30
	internal IPlayerItemDefinition <OnChanged>b__23_6(PlayerItemRecipe x) { }

	// RVA: 0x4D19F0 Offset: 0x4CFFF0 VA: 0x1804D19F0
	internal bool <DoExchange>b__32_0(Toggle x) { }

	// RVA: 0x4D1A10 Offset: 0x4D0010 VA: 0x1804D1A10
	internal SteamInventoryItem <DoExchange>b__32_1(Toggle x) { }

	// RVA: 0x4D1CA0 Offset: 0x4D02A0 VA: 0x1804D1CA0
	internal bool <OnRefreshed>b__34_0(IPlayerItem x) { }

	// RVA: 0x4D1CF0 Offset: 0x4D02F0 VA: 0x1804D1CF0
	internal int <OnRefreshed>b__34_1(IPlayerItem x) { }

	// RVA: 0x4D1D40 Offset: 0x4D0340 VA: 0x1804D1D40
	internal bool <OnRefreshed>b__34_2(IPlayerItem x) { }

	// RVA: 0x4D1D90 Offset: 0x4D0390 VA: 0x1804D1D90
	internal int <OnRefreshed>b__34_3(IPlayerItem x) { }

	// RVA: 0x4D1DE0 Offset: 0x4D03E0 VA: 0x1804D1DE0
	internal bool <OnRefreshed>b__34_4(IPlayerItem x) { }

	// RVA: 0x4D1E30 Offset: 0x4D0430 VA: 0x1804D1E30
	internal int <OnRefreshed>b__34_5(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass23_0 // TypeDefIndex: 12054
{	// Fields
	public IPlayerItemDefinition itemType; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3B20 Offset: 0x4B2120 VA: 0x1804B3B20
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

	// RVA: 0x4B3C10 Offset: 0x4B2210 VA: 0x1804B3C10
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

	// RVA: 0x4B1D80 Offset: 0x4B0380 VA: 0x1804B1D80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4B1F60 Offset: 0x4B0560 VA: 0x1804B1F60 Slot: 8
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

	// RVA: 0x4B3C30 Offset: 0x4B2230 VA: 0x1804B3C30
	internal bool <ExchangeItems>b__0(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_1 // TypeDefIndex: 12060
{	// Fields
	public IPlayerItemDefinition targetItem; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3D00 Offset: 0x4B2300 VA: 0x1804B3D00
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

	// RVA: 0x4AD670 Offset: 0x4ABC70 VA: 0x1804AD670
	public void Open(int ItemDefinition) { }

	// RVA: 0x4AD570 Offset: 0x4ABB70 VA: 0x1804AD570
	public void DoCraft() { }

	[AsyncStateMachineAttribute] // RVA: 0xD5F60 Offset: 0xD5360 VA: 0x1800D5F60
	// RVA: 0x4AD570 Offset: 0x4ABB70 VA: 0x1804AD570
	private Task DoCraftAsync() { }

	// RVA: 0x4AD520 Offset: 0x4ABB20 VA: 0x1804AD520
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

	// RVA: 0x4B3990 Offset: 0x4B1F90 VA: 0x1804B3990
	internal bool <Open>b__1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c // TypeDefIndex: 12064
{	// Fields
	public static readonly SteamInventoryCrateOpen.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, string> <>9__10_0; // 0x8
	public static Func<InventoryItem, int> <>9__10_2; // 0x10
	public static Func<InventoryItem, int> <>9__12_1; // 0x18

	// Methods

	// RVA: 0x4B3E20 Offset: 0x4B2420 VA: 0x1804B3E20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3830 Offset: 0x4B1E30 VA: 0x1804B3830
	internal string <Open>b__10_0(InventoryRecipe.Ingredient x) { }

	// RVA: 0x4B3760 Offset: 0x4B1D60 VA: 0x1804B3760
	internal int <Open>b__10_2(InventoryItem x) { }

	// RVA: 0x4B3760 Offset: 0x4B1D60 VA: 0x1804B3760
	internal int <DoCraftAsync>b__12_1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_0 // TypeDefIndex: 12065
{	// Fields
	public List<InventoryItem.Amount> items; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B39C0 Offset: 0x4B1FC0 VA: 0x1804B39C0
	internal bool <DoCraftAsync>b__2(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_1 // TypeDefIndex: 12066
{	// Fields
	public InventoryRecipe.Ingredient i; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3990 Offset: 0x4B1F90 VA: 0x1804B3990
	internal bool <DoCraftAsync>b__0(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_2 // TypeDefIndex: 12067
{	// Fields
	public InventoryItem x; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3A90 Offset: 0x4B2090 VA: 0x1804B3A90
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

	// RVA: 0x4ADCF0 Offset: 0x4AC2F0 VA: 0x1804ADCF0
	public void Setup(IPlayerItem item, ItemSkinDirectory.Skin skin) { }

	// RVA: 0x4ADE00 Offset: 0x4AC400 VA: 0x1804ADE00
	internal void Setup(IPlayerItem item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class SteamInventoryItem : MonoBehaviour // TypeDefIndex: 12070
{	// Fields
	public IPlayerItem Item; // 0x18
	public HttpImage Image; // 0x20

	// Methods

	// RVA: 0x4ADFB0 Offset: 0x4AC5B0 VA: 0x1804ADFB0
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

	// RVA: 0x4AE0D0 Offset: 0x4AC6D0 VA: 0x1804AE0D0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4AE270 Offset: 0x4AC870 VA: 0x1804AE270
	public void ManualRefresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD64C0 Offset: 0xD58C0 VA: 0x1800D64C0
	// RVA: 0x4AE3F0 Offset: 0x4AC9F0 VA: 0x1804AE3F0
	public Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6620 Offset: 0xD5A20 VA: 0x1800D6620
	// RVA: 0x4AE140 Offset: 0x4AC740 VA: 0x1804AE140
	private Task FixStacks(IReadOnlyCollection<IPlayerItem> steamitems) { }

	// RVA: 0x4AE4F0 Offset: 0x4ACAF0 VA: 0x1804AE4F0
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

	// RVA: 0x4B3E80 Offset: 0x4B2480 VA: 0x1804B3E80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B38C0 Offset: 0x4B1EC0 VA: 0x1804B38C0
	internal DateTimeOffset <Refresh>b__8_0(IPlayerItem x) { }

	// RVA: 0x4B3770 Offset: 0x4B1D70 VA: 0x1804B3770
	internal bool <FixStacks>b__9_0(InventoryItem x) { }

	// RVA: 0x4B3790 Offset: 0x4B1D90 VA: 0x1804B3790
	internal bool <FixStacks>b__9_1(InventoryItem x) { }

	// RVA: 0x4B37C0 Offset: 0x4B1DC0 VA: 0x1804B37C0
	internal bool <FixStacks>b__9_2(InventoryItem x) { }

	// RVA: 0x4B3820 Offset: 0x4B1E20 VA: 0x1804B3820
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
	// RVA: 0x4AE550 Offset: 0x4ACB50 VA: 0x1804AE550
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

