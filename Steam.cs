internal static class SteamAPI // TypeDefIndex: 5111
{	// Methods

	// RVA: 0xDE29B0 Offset: 0xDE0FB0 VA: 0x180DE29B0
	internal static bool Init() { }

	// RVA: 0xDE2A20 Offset: 0xDE1020 VA: 0x180DE2A20
	internal static void Shutdown() { }

	// RVA: 0xDE2940 Offset: 0xDE0F40 VA: 0x180DE2940
	internal static HSteamPipe GetHSteamPipe() { }

}

internal static class SteamAPI.Native // TypeDefIndex: 5112
{	// Methods

	// RVA: 0xDE29B0 Offset: 0xDE0FB0 VA: 0x180DE29B0
	public static extern bool SteamAPI_Init() { }

	// RVA: 0xDE2A20 Offset: 0xDE1020 VA: 0x180DE2A20
	public static extern void SteamAPI_Shutdown() { }

	// RVA: 0xDE2940 Offset: 0xDE0F40 VA: 0x180DE2940
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

	// RVA: 0xDE48C0 Offset: 0xDE2EC0 VA: 0x180DE48C0
	internal static ISteamApps get_Internal() { }

	// RVA: 0xDE46C0 Offset: 0xDE2CC0 VA: 0x180DE46C0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE4890 Offset: 0xDE2E90 VA: 0x180DE4890
	public static string get_GameLanguage() { }

	// RVA: 0xDE4790 Offset: 0xDE2D90 VA: 0x180DE4790
	public static bool IsSubscribedToApp(AppId appid) { }

	// RVA: 0xDE4740 Offset: 0xDE2D40 VA: 0x180DE4740
	public static bool IsDlcInstalled(AppId appid) { }

	// RVA: 0xDE4850 Offset: 0xDE2E50 VA: 0x180DE4850
	public static string get_CurrentBetaName() { }

	// RVA: 0xDE4820 Offset: 0xDE2E20 VA: 0x180DE4820
	public static int get_BuildId() { }

	// RVA: 0xDE47E0 Offset: 0xDE2DE0 VA: 0x180DE47E0
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

	// RVA: 0xDE49D0 Offset: 0xDE2FD0 VA: 0x180DE49D0
	public static void Init(uint appid, bool asyncCallbacks = True) { }

	// RVA: -1 Offset: -1
	internal static void AddInterface<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF880 Offset: 0xCFDE80 VA: 0x180CFF880
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

	// RVA: 0xDE4F10 Offset: 0xDE3510 VA: 0x180DE4F10
	internal static void ShutdownInterfaces() { }

	// RVA: 0xDE5440 Offset: 0xDE3A40 VA: 0x180DE5440
	public static bool get_IsValid() { }

	// RVA: 0xDE50A0 Offset: 0xDE36A0 VA: 0x180DE50A0
	public static void Shutdown() { }

	// RVA: 0xDE4940 Offset: 0xDE2F40 VA: 0x180DE4940
	internal static void Cleanup() { }

	// RVA: 0xDE4DD0 Offset: 0xDE33D0 VA: 0x180DE4DD0
	public static void RunCallbacks() { }

	// RVA: 0xDE5360 Offset: 0xDE3960 VA: 0x180DE5360
	public static bool get_IsLoggedOn() { }

	// RVA: 0xDE54D0 Offset: 0xDE3AD0 VA: 0x180DE54D0
	public static SteamId get_SteamId() { }

	// RVA: 0xDE54A0 Offset: 0xDE3AA0 VA: 0x180DE54A0
	public static string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE52A0 Offset: 0xDE38A0 VA: 0x180DE52A0
	public static AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE55A0 Offset: 0xDE3BA0 VA: 0x180DE55A0
	internal static void set_AppId(AppId value) { }

	// RVA: 0xDE5230 Offset: 0xDE3830 VA: 0x180DE5230
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

	// RVA: 0xDE6840 Offset: 0xDE4E40 VA: 0x180DE6840
	internal static ISteamFriends get_Internal() { }

	// RVA: 0xDE5950 Offset: 0xDE3F50 VA: 0x180DE5950 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE5A10 Offset: 0xDE4010 VA: 0x180DE5A10
	internal void InstallEvents() { }

	// RVA: 0xDE6060 Offset: 0xDE4660 VA: 0x180DE6060
	private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data) { }

	// RVA: 0xDE6310 Offset: 0xDE4910 VA: 0x180DE6310
	private static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data) { }

	[IteratorStateMachineAttribute] // RVA: 0x8E180 Offset: 0x8D580 VA: 0x18008E180
	// RVA: 0xDE5740 Offset: 0xDE3D40 VA: 0x180DE5740
	private static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag) { }

	// RVA: 0xDE57B0 Offset: 0xDE3DB0 VA: 0x180DE57B0
	public static IEnumerable<Friend> GetFriends() { }

	// RVA: 0xDE6660 Offset: 0xDE4C60 VA: 0x180DE6660
	public static void OpenUserOverlay(SteamId id, string type) { }

	// RVA: 0xDE6610 Offset: 0xDE4C10 VA: 0x180DE6610
	public static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = 0) { }

	// RVA: 0xDE66A0 Offset: 0xDE4CA0 VA: 0x180DE66A0
	public static void OpenWebOverlay(string url, bool modal = False) { }

	// RVA: 0xDE6720 Offset: 0xDE4D20 VA: 0x180DE6720
	public static void SetPlayedWith(SteamId steamid) { }

	// RVA: 0xDE66E0 Offset: 0xDE4CE0 VA: 0x180DE66E0
	public static bool RequestUserInformation(SteamId steamid, bool nameonly = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E200 Offset: 0x8D600 VA: 0x18008E200
	// RVA: 0xDE5600 Offset: 0xDE3C00 VA: 0x180DE5600
	internal static Task CacheUserInformationAsync(SteamId steamid, bool nameonly) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E4C0 Offset: 0x8D8C0 VA: 0x18008E4C0
	// RVA: 0xDE5810 Offset: 0xDE3E10 VA: 0x180DE5810
	public static Task<Nullable<Image>> GetMediumAvatarAsync(SteamId steamid) { }

	// RVA: 0xDE58D0 Offset: 0xDE3ED0 VA: 0x180DE58D0
	public static string GetRichPresence(string key) { }

	// RVA: 0xDE6750 Offset: 0xDE4D50 VA: 0x180DE6750
	public static bool SetRichPresence(string key, string value) { }

	// RVA: 0xDE56D0 Offset: 0xDE3CD0 VA: 0x180DE56D0
	public static void ClearRichPresence() { }

	// RVA: 0xDE6800 Offset: 0xDE4E00 VA: 0x180DE6800
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

	// RVA: 0xDF05A0 Offset: 0xDEEBA0 VA: 0x180DF05A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEFA30 Offset: 0xDEE030 VA: 0x180DEFA30
	internal void <InstallEvents>b__4_0(PersonaStateChange_t x) { }

	// RVA: 0xDEFA90 Offset: 0xDEE090 VA: 0x180DEFA90
	internal void <InstallEvents>b__4_1(GameRichPresenceJoinRequested_t x) { }

	// RVA: 0xDEFB10 Offset: 0xDEE110 VA: 0x180DEFB10
	internal void <InstallEvents>b__4_2(GameOverlayActivated_t x) { }

	// RVA: 0xDEFB70 Offset: 0xDEE170 VA: 0x180DEFB70
	internal void <InstallEvents>b__4_3(GameServerChangeRequested_t x) { }

	// RVA: 0xDEFBF0 Offset: 0xDEE1F0 VA: 0x180DEFBF0
	internal void <InstallEvents>b__4_4(GameLobbyJoinRequested_t x) { }

	// RVA: 0xDEFC80 Offset: 0xDEE280 VA: 0x180DEFC80
	internal void <InstallEvents>b__4_5(FriendRichPresenceUpdate_t x) { }

	// RVA: 0xDEFCE0 Offset: 0xDEE2E0 VA: 0x180DEFCE0
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDEC4F0 Offset: 0xDEAAF0 VA: 0x180DEC4F0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC630 Offset: 0xDEAC30 VA: 0x180DEC630 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC680 Offset: 0xDEAC80 VA: 0x180DEC680 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC590 Offset: 0xDEAB90 VA: 0x180DEC590 Slot: 4
	private IEnumerator<Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC590 Offset: 0xDEAB90 VA: 0x180DEC590 Slot: 5
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

	// RVA: 0xDE68F0 Offset: 0xDE4EF0 VA: 0x180DE68F0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE6A80 Offset: 0xDE5080 VA: 0x180DE6A80
	public void .ctor() { }

	// RVA: 0xDE6970 Offset: 0xDE4F70 VA: 0x180DE6970
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

	// RVA: 0xDE7D50 Offset: 0xDE6350 VA: 0x180DE7D50
	internal static ISteamInventory get_Internal() { }

	// RVA: 0xDE7300 Offset: 0xDE5900 VA: 0x180DE7300 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE7390 Offset: 0xDE5990 VA: 0x180DE7390
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDE7580 Offset: 0xDE5B80 VA: 0x180DE7580
	private static void InventoryUpdated(SteamInventoryFullUpdate_t x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7C20 Offset: 0xDE6220 VA: 0x180DE7C20
	public static void add_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7EC0 Offset: 0xDE64C0 VA: 0x180DE7EC0
	public static void remove_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7B70 Offset: 0xDE6170 VA: 0x180DE7B70
	public static void add_OnDefinitionsUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7E10 Offset: 0xDE6410 VA: 0x180DE7E10
	public static void remove_OnDefinitionsUpdated(Action value) { }

	// RVA: 0xDE7640 Offset: 0xDE5C40 VA: 0x180DE7640
	private static void LoadDefinitions() { }

	// RVA: 0xDE7930 Offset: 0xDE5F30 VA: 0x180DE7930
	public static void LoadItemDefinitions() { }

	// RVA: 0xDE6E50 Offset: 0xDE5450 VA: 0x180DE6E50
	public static InventoryDef FindDefinition(InventoryDefId defId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7CD0 Offset: 0xDE62D0 VA: 0x180DE7CD0
	public static string get_Currency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7F70 Offset: 0xDE6570 VA: 0x180DE7F70
	internal static void set_Currency(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0x8FA60 Offset: 0x8EE60 VA: 0x18008FA60
	// RVA: 0xDE7000 Offset: 0xDE5600 VA: 0x180DE7000
	public static Task<InventoryDef[]> GetDefinitionsWithPricesAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7DD0 Offset: 0xDE63D0 VA: 0x180DE7DD0
	public static InventoryItem[] get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE8010 Offset: 0xDE6610 VA: 0x180DE8010
	internal static void set_Items(InventoryItem[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7D10 Offset: 0xDE6310 VA: 0x180DE7D10
	public static InventoryDef[] get_Definitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDE7FC0 Offset: 0xDE65C0 VA: 0x180DE7FC0
	internal static void set_Definitions(InventoryDef[] value) { }

	// RVA: 0xDE70C0 Offset: 0xDE56C0 VA: 0x180DE70C0
	internal static InventoryDef[] GetDefinitions() { }

	// RVA: 0xDE6F80 Offset: 0xDE5580 VA: 0x180DE6F80
	public static bool GetAllItems() { }

	[AsyncStateMachineAttribute] // RVA: 0x900D0 Offset: 0x8F4D0 VA: 0x1800900D0
	// RVA: 0xDE6ED0 Offset: 0xDE54D0 VA: 0x180DE6ED0
	public static Task<Nullable<InventoryResult>> GetAllItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90150 Offset: 0x8F550 VA: 0x180090150
	// RVA: 0xDE6C50 Offset: 0xDE5250 VA: 0x180DE6C50
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x90280 Offset: 0x8F680 VA: 0x180090280
	// RVA: 0xDE6D50 Offset: 0xDE5350 VA: 0x180DE6D50
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem.Amount[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x903A0 Offset: 0x8F7A0 VA: 0x1800903A0
	// RVA: 0xDE7250 Offset: 0xDE5850 VA: 0x180DE7250
	public static Task<Nullable<InventoryResult>> GrantPromoItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0xDE7A70 Offset: 0xDE6070 VA: 0x180DE7A70
	public static Task<Nullable<InventoryResult>> TriggerItemDropAsync(InventoryDefId id) { }

	[AsyncStateMachineAttribute] // RVA: 0x90770 Offset: 0x8FB70 VA: 0x180090770
	// RVA: 0xDE7990 Offset: 0xDE5F90 VA: 0x180DE7990
	public static Task<Nullable<InventoryPurchaseResult>> StartPurchaseAsync(InventoryDef[] items) { }

	// RVA: 0xDE7B30 Offset: 0xDE6130 VA: 0x180DE7B30
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

	// RVA: 0xDF0720 Offset: 0xDEED20 VA: 0x180DF0720
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF7E0 Offset: 0xDEDDE0 VA: 0x180DEF7E0
	internal void <InstallEvents>b__3_0(SteamInventoryFullUpdate_t x) { }

	// RVA: 0xDEF950 Offset: 0xDEDF50 VA: 0x180DEF950
	internal void <InstallEvents>b__3_1(SteamInventoryDefinitionUpdate_t x) { }

	// RVA: 0xDEF600 Offset: 0xDEDC00 VA: 0x180DEF600
	internal InventoryDef <GetDefinitionsWithPricesAsync>b__19_0(InventoryDefId x) { }

	// RVA: 0xDEF5A0 Offset: 0xDEDBA0 VA: 0x180DEF5A0
	internal InventoryDef <GetDefinitions>b__29_0(InventoryDefId x) { }

	// RVA: 0x820960 Offset: 0x81EF60 VA: 0x180820960
	internal InventoryItemId <CraftItemAsync>b__33_0(InventoryItem x) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0
	internal uint <CraftItemAsync>b__33_1(InventoryItem x) { }

	// RVA: 0x820960 Offset: 0x81EF60 VA: 0x180820960
	internal InventoryItemId <CraftItemAsync>b__34_0(InventoryItem.Amount x) { }

	// RVA: 0xDEF530 Offset: 0xDEDB30 VA: 0x180DEF530
	internal uint <CraftItemAsync>b__34_1(InventoryItem.Amount x) { }

	// RVA: 0x7B4F70 Offset: 0x7B3570 VA: 0x1807B4F70
	internal InventoryDefId <StartPurchaseAsync>b__39_0(InventoryDef x) { }

	// RVA: 0xDF02E0 Offset: 0xDEE8E0 VA: 0x180DF02E0
	internal InventoryDefId <StartPurchaseAsync>b__39_1(IGrouping<InventoryDefId, InventoryDef> x) { }

	// RVA: 0xDF0390 Offset: 0xDEE990 VA: 0x180DF0390
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

	// RVA: 0xDE89C0 Offset: 0xDE6FC0 VA: 0x180DE89C0
	internal static ISteamMatchmaking get_Internal() { }

	// RVA: 0xDE8180 Offset: 0xDE6780 VA: 0x180DE8180 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE8200 Offset: 0xDE6800 VA: 0x180DE8200
	internal static void InstallEvents() { }

	// RVA: 0xDE8750 Offset: 0xDE6D50 VA: 0x180DE8750
	private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x931C0 Offset: 0x925C0 VA: 0x1800931C0
	// RVA: 0xDE8120 Offset: 0xDE6720 VA: 0x180DE8120
	public static IEnumerable<ServerInfo> GetFavoriteServers() { }

	// RVA: 0xDE8980 Offset: 0xDE6F80 VA: 0x180DE8980
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

	// RVA: 0xDF0780 Offset: 0xDEED80 VA: 0x180DF0780
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEFD40 Offset: 0xDEE340 VA: 0x180DEFD40
	internal void <InstallEvents>b__5_0(LobbyInvite_t x) { }

	// RVA: 0xDEFDD0 Offset: 0xDEE3D0 VA: 0x180DEFDD0
	internal void <InstallEvents>b__5_1(LobbyEnter_t x) { }

	// RVA: 0xDEFE50 Offset: 0xDEE450 VA: 0x180DEFE50
	internal void <InstallEvents>b__5_2(LobbyCreated_t x) { }

	// RVA: 0xDEFEE0 Offset: 0xDEE4E0 VA: 0x180DEFEE0
	internal void <InstallEvents>b__5_3(LobbyGameCreated_t x) { }

	// RVA: 0xDEFFB0 Offset: 0xDEE5B0 VA: 0x180DEFFB0
	internal void <InstallEvents>b__5_4(LobbyDataUpdate_t x) { }

	// RVA: 0xDF00A0 Offset: 0xDEE6A0 VA: 0x180DF00A0
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
	// RVA: 0xDEC4B0 Offset: 0xDEAAB0 VA: 0x180DEC4B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDEC130 Offset: 0xDEA730 VA: 0x180DEC130 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC370 Offset: 0xDEA970 VA: 0x180DEC370 Slot: 6
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC3C0 Offset: 0xDEA9C0 VA: 0x180DEC3C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC410 Offset: 0xDEAA10 VA: 0x180DEC410 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC2E0 Offset: 0xDEA8E0 VA: 0x180DEC2E0 Slot: 4
	private IEnumerator<ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEC2E0 Offset: 0xDEA8E0 VA: 0x180DEC2E0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers> // TypeDefIndex: 5203
{	// Properties
	internal static ISteamMatchmakingServers Internal { get; }

	// Methods

	// RVA: 0xDD7980 Offset: 0xDD5F80 VA: 0x180DD7980
	internal static ISteamMatchmakingServers get_Internal() { }

	// RVA: 0xDE8060 Offset: 0xDE6660 VA: 0x180DE8060 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE80E0 Offset: 0xDE66E0 VA: 0x180DE80E0
	public void .ctor() { }

}

public class SteamMusic : SteamClientClass<SteamMusic> // TypeDefIndex: 5204
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnPlaybackChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<float> OnVolumeChanged; // 0x8

	// Methods

	// RVA: 0xDE8A50 Offset: 0xDE7050 VA: 0x180DE8A50 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE8AD0 Offset: 0xDE70D0 VA: 0x180DE8AD0
	internal static void InstallEvents() { }

	// RVA: 0xDE8CA0 Offset: 0xDE72A0 VA: 0x180DE8CA0
	public void .ctor() { }

}

private sealed class SteamMusic.<>c // TypeDefIndex: 5205
{	// Fields
	public static readonly SteamMusic.<>c <>9; // 0x0
	public static Action<PlaybackStatusHasChanged_t> <>9__3_0; // 0x8
	public static Action<VolumeHasChanged_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDF0540 Offset: 0xDEEB40 VA: 0x180DF0540
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF8A0 Offset: 0xDEDEA0 VA: 0x180DEF8A0
	internal void <InstallEvents>b__3_0(PlaybackStatusHasChanged_t x) { }

	// RVA: 0xDEF9D0 Offset: 0xDEDFD0 VA: 0x180DEF9D0
	internal void <InstallEvents>b__3_1(VolumeHasChanged_t x) { }

}

public class SteamNetworking : SteamSharedClass<SteamNetworking> // TypeDefIndex: 5206
{	// Fields
	public static Action<SteamId> OnP2PSessionRequest; // 0x0
	public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed; // 0x8

	// Methods

	// RVA: 0xDEA580 Offset: 0xDE8B80 VA: 0x180DEA580 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDEA610 Offset: 0xDE8C10 VA: 0x180DEA610
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDEA7F0 Offset: 0xDE8DF0 VA: 0x180DEA7F0
	public void .ctor() { }

}

private sealed class SteamNetworking.<>c // TypeDefIndex: 5207
{	// Fields
	public static readonly SteamNetworking.<>c <>9; // 0x0
	public static Action<P2PSessionRequest_t> <>9__3_0; // 0x8
	public static Action<P2PSessionConnectFail_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDF07E0 Offset: 0xDEEDE0 VA: 0x180DF07E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xDEF8F0 Offset: 0xDEDEF0 VA: 0x180DEF8F0
	internal void <InstallEvents>b__3_0(P2PSessionRequest_t x) { }

	// RVA: 0xDEF960 Offset: 0xDEDF60 VA: 0x180DEF960
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

	// RVA: 0xDEA400 Offset: 0xDE8A00 VA: 0x180DEA400
	internal static ISteamNetworkingSockets get_Internal() { }

	// RVA: 0xDEA360 Offset: 0xDE8960 VA: 0x180DEA360
	public static NetIdentity get_Identity() { }

	// RVA: 0xDE9E00 Offset: 0xDE8400 VA: 0x180DE9E00 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE9D00 Offset: 0xDE8300 VA: 0x180DE9D00
	internal static SocketManager GetSocketManager(uint id) { }

	// RVA: 0xDEA0C0 Offset: 0xDE86C0 VA: 0x180DEA0C0
	internal static void SetSocketManager(uint id, SocketManager manager) { }

	// RVA: 0xDE9AD0 Offset: 0xDE80D0 VA: 0x180DE9AD0
	internal static ConnectionManager GetConnectionManager(uint id) { }

	// RVA: 0xDEA000 Offset: 0xDE8600 VA: 0x180DEA000
	internal static void SetConnectionManager(uint id, ConnectionManager manager) { }

	// RVA: 0xDE9F30 Offset: 0xDE8530 VA: 0x180DE9F30
	internal void InstallEvents(bool server) { }

	// RVA: 0xDE8E60 Offset: 0xDE7460 VA: 0x180DE8E60
	private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data) { }

	// RVA: 0xDE9950 Offset: 0xDE7F50 VA: 0x180DE9950
	private static void FakeIPResult(SteamNetworkingFakeIPResult_t data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEA260 Offset: 0xDE8860 VA: 0x180DEA260
	public static void add_OnFakeIPResult(Action<NetAddress> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xDEA480 Offset: 0xDE8A80 VA: 0x180DEA480
	public static void remove_OnFakeIPResult(Action<NetAddress> value) { }

	// RVA: 0xDE96D0 Offset: 0xDE7CD0 VA: 0x180DE96D0
	public static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface) { }

	// RVA: 0xDE8CE0 Offset: 0xDE72E0 VA: 0x180DE8CE0
	public static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface) { }

	// RVA: 0xDE9BA0 Offset: 0xDE81A0 VA: 0x180DE9BA0
	public static Result GetFakeIP(int fakePortIndex, out NetAddress address) { }

	// RVA: 0xDE9810 Offset: 0xDE7E10 VA: 0x180DE9810
	public static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface) { }

	// RVA: 0xDEA220 Offset: 0xDE8820 VA: 0x180DEA220
	public void .ctor() { }

	// RVA: 0xDEA180 Offset: 0xDE8780 VA: 0x180DEA180
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

	// RVA: 0x19D7DA0 Offset: 0x19D63A0 VA: 0x1819D7DA0
	internal static ISteamNetworkingUtils get_Internal() { }

	// RVA: 0x19D7350 Offset: 0x19D5950 VA: 0x1819D7350 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D74E0 Offset: 0x19D5AE0 VA: 0x1819D74E0
	private static void InstallCallbacks(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D7A20 Offset: 0x19D6020 VA: 0x1819D7A20
	public static void add_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D7E80 Offset: 0x19D6480 VA: 0x1819D7E80
	public static void remove_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D7E20 Offset: 0x19D6420 VA: 0x1819D7E20
	public static SteamNetworkingAvailability get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D83B0 Offset: 0x19D69B0 VA: 0x1819D83B0
	private static void set_Status(SteamNetworkingAvailability value) { }

	// RVA: 0x19D72F0 Offset: 0x19D58F0 VA: 0x1819D72F0
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x19D7B10 Offset: 0x19D6110 VA: 0x1819D7B10
	public static int get_ConnectionTimeout() { }

	// RVA: 0x19D7FD0 Offset: 0x19D65D0 VA: 0x1819D7FD0
	public static void set_ConnectionTimeout(int value) { }

	// RVA: 0x19D8350 Offset: 0x19D6950 VA: 0x1819D8350
	public static void set_SendBufferSize(int value) { }

	// RVA: 0x19D7F70 Offset: 0x19D6570 VA: 0x1819D7F70
	public static void set_AllowWithoutAuth(int value) { }

	// RVA: 0x19D8410 Offset: 0x19D6A10 VA: 0x1819D8410
	public static void set_Unencrypted(int value) { }

	// RVA: 0x19D7B60 Offset: 0x19D6160 VA: 0x1819D7B60
	public static int get_DebugLevelAckRTT() { }

	// RVA: 0x19D8030 Offset: 0x19D6630 VA: 0x1819D8030
	public static void set_DebugLevelAckRTT(int value) { }

	// RVA: 0x19D7C50 Offset: 0x19D6250 VA: 0x1819D7C50
	public static int get_DebugLevelPacketDecode() { }

	// RVA: 0x19D8150 Offset: 0x19D6750 VA: 0x1819D8150
	public static void set_DebugLevelPacketDecode(int value) { }

	// RVA: 0x19D7BB0 Offset: 0x19D61B0 VA: 0x1819D7BB0
	public static int get_DebugLevelMessage() { }

	// RVA: 0x19D8090 Offset: 0x19D6690 VA: 0x1819D8090
	public static void set_DebugLevelMessage(int value) { }

	// RVA: 0x19D7CA0 Offset: 0x19D62A0 VA: 0x1819D7CA0
	public static int get_DebugLevelPacketGaps() { }

	// RVA: 0x19D81B0 Offset: 0x19D67B0 VA: 0x1819D81B0
	public static void set_DebugLevelPacketGaps(int value) { }

	// RVA: 0x19D7C00 Offset: 0x19D6200 VA: 0x1819D7C00
	public static int get_DebugLevelP2PRendezvous() { }

	// RVA: 0x19D80F0 Offset: 0x19D66F0 VA: 0x1819D80F0
	public static void set_DebugLevelP2PRendezvous(int value) { }

	// RVA: 0x19D7CF0 Offset: 0x19D62F0 VA: 0x1819D7CF0
	public static int get_DebugLevelSDRRelayPings() { }

	// RVA: 0x19D8210 Offset: 0x19D6810 VA: 0x1819D8210
	public static void set_DebugLevelSDRRelayPings(int value) { }

	// RVA: 0x19D7D40 Offset: 0x19D6340 VA: 0x1819D7D40
	public static NetDebugOutput get_DebugLevel() { }

	// RVA: 0x19D8270 Offset: 0x19D6870 VA: 0x1819D8270
	public static void set_DebugLevel(NetDebugOutput value) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19D76B0 Offset: 0x19D5CB0 VA: 0x1819D76B0
	private static void OnDebugMessage(NetDebugOutput nType, IntPtr str) { }

	// RVA: 0x19D75F0 Offset: 0x19D5BF0 VA: 0x1819D75F0
	internal static void LogDebugMessage(NetDebugOutput type, string message) { }

	// RVA: 0x19D77A0 Offset: 0x19D5DA0 VA: 0x1819D77A0
	internal static void OutputDebugMessages() { }

	// RVA: 0x19D71C0 Offset: 0x19D57C0 VA: 0x1819D71C0
	internal static NetMsg* AllocateMessage() { }

	// RVA: 0x19D78D0 Offset: 0x19D5ED0 VA: 0x1819D78D0
	internal static bool SetConfigInt(NetConfig type, int value) { }

	// RVA: 0x19D7220 Offset: 0x19D5820 VA: 0x1819D7220
	internal static int GetConfigInt(NetConfig type) { }

	// RVA: 0x19D79E0 Offset: 0x19D5FE0 VA: 0x1819D79E0
	public void .ctor() { }

	// RVA: 0x19D7970 Offset: 0x19D5F70 VA: 0x1819D7970
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

	// RVA: 0x19E0280 Offset: 0x19DE880 VA: 0x1819E0280
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF040 Offset: 0x19DD640 VA: 0x1819DF040
	internal void <InstallCallbacks>b__3_0(SteamRelayNetworkStatus_t x) { }

}

public class SteamParental : SteamSharedClass<SteamParental> // TypeDefIndex: 5212
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnSettingsChanged; // 0x13848

	// Methods

	// RVA: 0x19D8790 Offset: 0x19D6D90 VA: 0x1819D8790 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8900 Offset: 0x19D6F00 VA: 0x1819D8900
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D8A10 Offset: 0x19D7010 VA: 0x1819D8A10
	public void .ctor() { }

}

private sealed class SteamParental.<>c // TypeDefIndex: 5213
{	// Fields
	public static readonly SteamParental.<>c <>9; // 0x0
	public static Action<SteamParentalSettingsChanged_t> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x19E02E0 Offset: 0x19DE8E0 VA: 0x1819E02E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF0F0 Offset: 0x19DD6F0 VA: 0x1819DF0F0
	internal void <InstallEvents>b__3_0(SteamParentalSettingsChanged_t x) { }

}

public class SteamParties : SteamClientClass<SteamParties> // TypeDefIndex: 5214
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnBeaconLocationsUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action OnActiveBeaconsUpdated; // 0x8

	// Methods

	// RVA: 0x19D8A50 Offset: 0x19D7050 VA: 0x1819D8A50 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8AE0 Offset: 0x19D70E0 VA: 0x1819D8AE0
	internal void InstallEvents(bool server) { }

	// RVA: 0x19D8CC0 Offset: 0x19D72C0 VA: 0x1819D8CC0
	public void .ctor() { }

}

private sealed class SteamParties.<>c // TypeDefIndex: 5215
{	// Fields
	public static readonly SteamParties.<>c <>9; // 0x0
	public static Action<AvailableBeaconLocationsUpdated_t> <>9__3_0; // 0x8
	public static Action<ActiveBeaconsUpdated_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19E0340 Offset: 0x19DE940 VA: 0x1819E0340
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF1B0 Offset: 0x19DD7B0 VA: 0x1819DF1B0
	internal void <InstallEvents>b__3_0(AvailableBeaconLocationsUpdated_t x) { }

	// RVA: 0x19DF4B0 Offset: 0x19DDAB0 VA: 0x1819DF4B0
	internal void <InstallEvents>b__3_1(ActiveBeaconsUpdated_t x) { }

}

public class SteamRemotePlay : SteamClientClass<SteamRemotePlay> // TypeDefIndex: 5216
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<RemotePlaySession> OnSessionConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Action<RemotePlaySession> OnSessionDisconnected; // 0x8

	// Methods

	// RVA: 0x19D8D00 Offset: 0x19D7300 VA: 0x1819D8D00 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D8D90 Offset: 0x19D7390 VA: 0x1819D8D90
	internal void InstallEvents(bool server) { }

	// RVA: 0x19D8F70 Offset: 0x19D7570 VA: 0x1819D8F70
	public void .ctor() { }

}

private sealed class SteamRemotePlay.<>c // TypeDefIndex: 5217
{	// Fields
	public static readonly SteamRemotePlay.<>c <>9; // 0x0
	public static Action<SteamRemotePlaySessionConnected_t> <>9__3_0; // 0x8
	public static Action<SteamRemotePlaySessionDisconnected_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19E0160 Offset: 0x19DE760 VA: 0x1819E0160
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF140 Offset: 0x19DD740 VA: 0x1819DF140
	internal void <InstallEvents>b__3_0(SteamRemotePlaySessionConnected_t x) { }

	// RVA: 0x19DF3C0 Offset: 0x19DD9C0 VA: 0x1819DF3C0
	internal void <InstallEvents>b__3_1(SteamRemotePlaySessionDisconnected_t x) { }

}

public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage> // TypeDefIndex: 5218
{	// Methods

	// RVA: 0x19D8FB0 Offset: 0x19D75B0 VA: 0x1819D8FB0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D9030 Offset: 0x19D7630 VA: 0x1819D9030
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

	// RVA: 0x19D9390 Offset: 0x19D7990 VA: 0x1819D9390
	internal static ISteamScreenshots get_Internal() { }

	// RVA: 0x19D9070 Offset: 0x19D7670 VA: 0x1819D9070 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D90F0 Offset: 0x19D76F0 VA: 0x1819D90F0
	internal static void InstallEvents() { }

	// RVA: 0x19D92C0 Offset: 0x19D78C0 VA: 0x1819D92C0
	public static void TriggerScreenshot() { }

	// RVA: 0x19D9350 Offset: 0x19D7950 VA: 0x1819D9350
	public void .ctor() { }

}

private sealed class SteamScreenshots.<>c // TypeDefIndex: 5220
{	// Fields
	public static readonly SteamScreenshots.<>c <>9; // 0x0
	public static Action<ScreenshotRequested_t> <>9__3_0; // 0x8
	public static Action<ScreenshotReady_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19E0220 Offset: 0x19DE820 VA: 0x1819E0220
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF270 Offset: 0x19DD870 VA: 0x1819DF270
	internal void <InstallEvents>b__3_0(ScreenshotRequested_t x) { }

	// RVA: 0x19DF320 Offset: 0x19DD920 VA: 0x1819DF320
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

	// RVA: 0x19D9980 Offset: 0x19D7F80 VA: 0x1819D9980
	internal static ISteamUGC get_Internal() { }

	// RVA: 0x19D9460 Offset: 0x19D7A60 VA: 0x1819D9460 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D94F0 Offset: 0x19D7AF0 VA: 0x1819D94F0
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D9420 Offset: 0x19D7A20 VA: 0x1819D9420
	public static bool Download(PublishedFileId fileId, bool highPriority = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x94C70 Offset: 0x94070 VA: 0x180094C70
	// RVA: 0x19D9880 Offset: 0x19D7E80 VA: 0x1819D9880
	public static Task<Nullable<Item>> QueryFileAsync(PublishedFileId fileId) { }

	// RVA: 0x19D9940 Offset: 0x19D7F40 VA: 0x1819D9940
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

	// RVA: 0x19E0040 Offset: 0x19DE640 VA: 0x1819E0040
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF2C0 Offset: 0x19DD8C0 VA: 0x1819DF2C0
	internal void <InstallEvents>b__3_0(DownloadItemResult_t x) { }

	// RVA: 0x19DF430 Offset: 0x19DDA30 VA: 0x1819DF430
	internal void <InstallEvents>b__3_1(RemoteStoragePublishedFileSubscribed_t x) { }

	// RVA: 0x19DF650 Offset: 0x19DDC50 VA: 0x1819DF650
	internal void <InstallEvents>b__3_2(RemoteStoragePublishedFileUnsubscribed_t x) { }

	// RVA: 0x19DF6D0 Offset: 0x19DDCD0 VA: 0x1819DF6D0
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

	// RVA: 0x19DB8F0 Offset: 0x19D9EF0 VA: 0x1819DB8F0
	internal static ISteamUser get_Internal() { }

	// RVA: 0x19DA760 Offset: 0x19D8D60 VA: 0x1819DA760 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19DAA20 Offset: 0x19D9020 VA: 0x1819DAA20
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DB650 Offset: 0x19D9C50 VA: 0x1819DB650
	internal static void add_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DBB00 Offset: 0x19DA100 VA: 0x1819DBB00
	internal static void remove_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DB750 Offset: 0x19D9D50 VA: 0x1819DB750
	public static void add_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DBC00 Offset: 0x19DA200 VA: 0x1819DBC00
	public static void remove_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	// RVA: 0x19DBAA0 Offset: 0x19DA0A0 VA: 0x1819DBAA0
	public static bool get_VoiceRecord() { }

	// RVA: 0x19DBEA0 Offset: 0x19DA4A0 VA: 0x1819DBEA0
	public static void set_VoiceRecord(bool value) { }

	// RVA: 0x19DB850 Offset: 0x19D9E50 VA: 0x1819DB850
	public static bool get_HasVoiceData() { }

	// RVA: 0x19DB270 Offset: 0x19D9870 VA: 0x1819DB270
	public static byte[] ReadVoiceDataBytes() { }

	// RVA: 0x19DBA40 Offset: 0x19DA040 VA: 0x1819DBA40
	public static uint get_SampleRate() { }

	// RVA: 0x19DBD00 Offset: 0x19DA300 VA: 0x1819DBD00
	public static void set_SampleRate(uint value) { }

	// RVA: 0x19DB9E0 Offset: 0x19D9FE0 VA: 0x1819DB9E0
	public static uint get_OptimalSampleRate() { }

	// RVA: 0x19DA350 Offset: 0x19D8950 VA: 0x1819DA350
	public static int DecompressVoice(byte[] from, Stream output) { }

	// RVA: 0x19DA600 Offset: 0x19D8C00 VA: 0x1819DA600
	public static AuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0x958F0 Offset: 0x94CF0 VA: 0x1800958F0
	// RVA: 0x19DA520 Offset: 0x19D8B20 VA: 0x1819DA520
	public static Task<AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10) { }

	// RVA: 0x19DB980 Offset: 0x19D9F80 VA: 0x1819DB980
	public static bool get_IsTwoFactorEnabled() { }

	[AsyncStateMachineAttribute] // RVA: 0x95A60 Offset: 0x94E60 VA: 0x180095A60
	// RVA: 0x19DB4E0 Offset: 0x19D9AE0 VA: 0x1819DB4E0
	public static Task<byte[]> RequestEncryptedAppTicketAsync() { }

	// RVA: 0x19DB610 Offset: 0x19D9C10 VA: 0x1819DB610
	public void .ctor() { }

	// RVA: 0x19DB5A0 Offset: 0x19D9BA0 VA: 0x1819DB5A0
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

	// RVA: 0x19E0100 Offset: 0x19DE700 VA: 0x1819E0100
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF7D0 Offset: 0x19DDDD0 VA: 0x1819DF7D0
	internal void <InstallEvents>b__4_0(SteamServersConnected_t x) { }

	// RVA: 0x19DF840 Offset: 0x19DDE40 VA: 0x1819DF840
	internal void <InstallEvents>b__4_1(SteamServerConnectFailure_t x) { }

	// RVA: 0x19DF8B0 Offset: 0x19DDEB0 VA: 0x1819DF8B0
	internal void <InstallEvents>b__4_2(SteamServersDisconnected_t x) { }

	// RVA: 0x19DF920 Offset: 0x19DDF20 VA: 0x1819DF920
	internal void <InstallEvents>b__4_3(ClientGameServerDeny_t x) { }

	// RVA: 0x19DF990 Offset: 0x19DDF90 VA: 0x1819DF990
	internal void <InstallEvents>b__4_4(LicensesUpdated_t x) { }

	// RVA: 0x19DFA00 Offset: 0x19DE000 VA: 0x1819DFA00
	internal void <InstallEvents>b__4_5(ValidateAuthTicketResponse_t x) { }

	// RVA: 0x19DFAD0 Offset: 0x19DE0D0 VA: 0x1819DFAD0
	internal void <InstallEvents>b__4_6(MicroTxnAuthorizationResponse_t x) { }

	// RVA: 0x19DFB90 Offset: 0x19DE190 VA: 0x1819DFB90
	internal void <InstallEvents>b__4_7(GameWebCallback_t x) { }

	// RVA: 0x19DFC20 Offset: 0x19DE220 VA: 0x1819DFC20
	internal void <InstallEvents>b__4_8(GetAuthSessionTicketResponse_t x) { }

	// RVA: 0x19DFCA0 Offset: 0x19DE2A0 VA: 0x1819DFCA0
	internal void <InstallEvents>b__4_9(DurationControl_t x) { }

}

private sealed class SteamUser.<>c__DisplayClass54_0 // TypeDefIndex: 5226
{	// Fields
	public AuthTicket ticket; // 0x10
	public Result result; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19E0010 Offset: 0x19DE610 VA: 0x1819E0010
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

	// RVA: 0x19DA1D0 Offset: 0x19D87D0 VA: 0x1819DA1D0
	internal static ISteamUserStats get_Internal() { }

	// RVA: 0x19D9A90 Offset: 0x19D8090 VA: 0x1819D9A90 Slot: 4
	internal override void InitializeInterface(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DA310 Offset: 0x19D8910 VA: 0x1819DA310
	internal static void set_StatsRecieved(bool value) { }

	// RVA: 0x19D9B30 Offset: 0x19D8130 VA: 0x1819D9B30
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DA0C0 Offset: 0x19D86C0 VA: 0x1819DA0C0
	public static void add_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19DA260 Offset: 0x19D8860 VA: 0x1819DA260
	public static void remove_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[IteratorStateMachineAttribute] // RVA: 0x96620 Offset: 0x95A20 VA: 0x180096620
	// RVA: 0x19DA170 Offset: 0x19D8770 VA: 0x1819DA170
	public static IEnumerable<Achievement> get_Achievements() { }

	// RVA: 0x19DA050 Offset: 0x19D8650 VA: 0x1819DA050
	public static bool StoreStats() { }

	// RVA: 0x19D9F70 Offset: 0x19D8570 VA: 0x1819D9F70
	public static bool RequestCurrentStats() { }

	// RVA: 0x19D9FD0 Offset: 0x19D85D0 VA: 0x1819D9FD0
	public static bool SetStat(string name, int value) { }

	// RVA: 0x19DA010 Offset: 0x19D8610 VA: 0x1819DA010
	public static bool SetStat(string name, float value) { }

	// RVA: 0x19D9A50 Offset: 0x19D8050 VA: 0x1819D9A50
	public static int GetStatInt(string name) { }

	// RVA: 0x19D9A00 Offset: 0x19D8000 VA: 0x1819D9A00
	public static float GetStatFloat(string name) { }

	// RVA: 0x19D9FA0 Offset: 0x19D85A0 VA: 0x1819D9FA0
	public static bool ResetAll(bool includeAchievements) { }

	// RVA: 0x19DA080 Offset: 0x19D8680 VA: 0x1819DA080
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

	// RVA: 0x19E00A0 Offset: 0x19DE6A0 VA: 0x1819E00A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DFD30 Offset: 0x19DE330 VA: 0x1819DFD30
	internal void <InstallEvents>b__7_0(UserStatsReceived_t x) { }

	// RVA: 0x19DFE20 Offset: 0x19DE420 VA: 0x1819DFE20
	internal void <InstallEvents>b__7_1(UserStatsStored_t x) { }

	// RVA: 0x19DFE80 Offset: 0x19DE480 VA: 0x1819DFE80
	internal void <InstallEvents>b__7_2(UserAchievementStored_t x) { }

	// RVA: 0x19DFF20 Offset: 0x19DE520 VA: 0x1819DFF20
	internal void <InstallEvents>b__7_3(UserStatsUnloaded_t x) { }

	// RVA: 0x19DFF90 Offset: 0x19DE590 VA: 0x1819DFF90
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
	// RVA: 0xD87750 Offset: 0xD85D50 VA: 0x180D87750
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19E05A0 Offset: 0x19DEBA0 VA: 0x1819E05A0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 6
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E06F0 Offset: 0x19DECF0 VA: 0x1819E06F0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0740 Offset: 0x19DED40 VA: 0x1819E0740 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0660 Offset: 0x19DEC60 VA: 0x1819E0660 Slot: 4
	private IEnumerator<Achievement> System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19E0660 Offset: 0x19DEC60 VA: 0x1819E0660 Slot: 5
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

	// RVA: 0x19DC910 Offset: 0x19DAF10 VA: 0x1819DC910
	internal static ISteamUtils get_Internal() { }

	// RVA: 0x19DC3C0 Offset: 0x19DA9C0 VA: 0x1819DC3C0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19DC470 Offset: 0x19DAA70 VA: 0x1819DC470
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19DC800 Offset: 0x19DAE00 VA: 0x1819DC800
	private static void SteamClosed() { }

	// RVA: 0x19DC990 Offset: 0x19DAF90 VA: 0x1819DC990
	public static string get_IpCountry() { }

	// RVA: 0x19DC080 Offset: 0x19DA680 VA: 0x1819DC080
	public static bool GetImageSize(int image, out uint width, out uint height) { }

	// RVA: 0x19DC120 Offset: 0x19DA720 VA: 0x1819DC120
	public static Nullable<Image> GetImage(int image) { }

	// RVA: 0x19DC9F0 Offset: 0x19DAFF0 VA: 0x1819DC9F0
	public static bool get_IsOverlayEnabled() { }

	// RVA: 0x19DC360 Offset: 0x19DA960 VA: 0x1819DC360
	public static bool InitFilterText() { }

	// RVA: 0x19DBFD0 Offset: 0x19DA5D0 VA: 0x1819DBFD0
	public static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage) { }

	// RVA: 0x19DC8D0 Offset: 0x19DAED0 VA: 0x1819DC8D0
	public void .ctor() { }

	// RVA: 0x19DC890 Offset: 0x19DAE90 VA: 0x1819DC890
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

	// RVA: 0x19E01C0 Offset: 0x19DE7C0 VA: 0x1819E01C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x19DF200 Offset: 0x19DD800 VA: 0x1819DF200
	internal void <InstallEvents>b__3_0(IPCountry_t x) { }

	// RVA: 0x19DF500 Offset: 0x19DDB00 VA: 0x1819DF500
	internal void <InstallEvents>b__3_1(LowBatteryPower_t x) { }

	// RVA: 0x19DF580 Offset: 0x19DDB80 VA: 0x1819DF580
	internal void <InstallEvents>b__3_2(SteamShutdown_t x) { }

	// RVA: 0x19DF750 Offset: 0x19DDD50 VA: 0x1819DF750
	internal void <InstallEvents>b__3_3(GamepadTextInputDismissed_t x) { }

}

public class SteamVideo : SteamClientClass<SteamVideo> // TypeDefIndex: 5234
{	// Methods

	// RVA: 0x19DCA50 Offset: 0x19DB050 VA: 0x1819DCA50 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal static void InstallEvents() { }

	// RVA: 0x19DCAD0 Offset: 0x19DB0D0 VA: 0x1819DCAD0
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

	// RVA: 0xDE6B20 Offset: 0xDE5120 VA: 0x180DE6B20 Slot: 4
	public virtual IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDE6AF0 Offset: 0xDE50F0 VA: 0x180DE6AF0 Slot: 5
	public virtual IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDE6AC0 Offset: 0xDE50C0 VA: 0x180DE6AC0 Slot: 6
	public virtual IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDE6C10 Offset: 0xDE5210 VA: 0x180DE6C10
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDA0 Offset: 0x82A3A0 VA: 0x18082BDA0
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x82BDD0 Offset: 0x82A3D0 VA: 0x18082BDD0
	private void set_IsServer(bool value) { }

	// RVA: 0xDE6B50 Offset: 0xDE5150 VA: 0x180DE6B50
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
	|-RVA: 0x1A50C90 Offset: 0x1A4F290 VA: 0x181A50C90
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
	|-RVA: 0x1A50C20 Offset: 0x1A4F220 VA: 0x181A50C20
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
	|-RVA: 0x1A50BB0 Offset: 0x1A4F1B0 VA: 0x181A50BB0
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
	|-RVA: 0xD50FA0 Offset: 0xD4F5A0 VA: 0x180D50FA0
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
	|-RVA: 0x1A50B10 Offset: 0x1A4F110 VA: 0x181A50B10
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
	|-RVA: 0x1A50AD0 Offset: 0x1A4F0D0 VA: 0x181A50AD0
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
	|-RVA: 0xD50FA0 Offset: 0xD4F5A0 VA: 0x180D50FA0
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

	// RVA: 0x19D8550 Offset: 0x19D6B50 VA: 0x1819D8550
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

	// RVA: 0x1290D10 Offset: 0x128F310 VA: 0x181290D10
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

	// RVA: 0x1290C60 Offset: 0x128F260 VA: 0x181290C60
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

	// RVA: 0x1290DC0 Offset: 0x128F3C0 VA: 0x181290DC0
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

	// RVA: 0x128FE20 Offset: 0x128E420 VA: 0x18128FE20
	private static void .cctor() { }

}

internal struct SteamShutdown_t : ICallbackData // TypeDefIndex: 5330
{	// Fields
	public static int _datasize; // 0x2B111E0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA150 Offset: 0x1D9550 VA: 0x1801DA150 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA140 Offset: 0x1D9540 VA: 0x1801DA140 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1290E70 Offset: 0x128F470 VA: 0x181290E70
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

	// RVA: 0x12900A0 Offset: 0x128E6A0 VA: 0x1812900A0
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

	// RVA: 0x1290140 Offset: 0x128E740 VA: 0x181290140
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

	// RVA: 0x1290000 Offset: 0x128E600 VA: 0x181290000
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

	// RVA: 0x12910A0 Offset: 0x128F6A0 VA: 0x1812910A0
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

	// RVA: 0x1291150 Offset: 0x128F750 VA: 0x181291150
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

	// RVA: 0x128FEC0 Offset: 0x128E4C0 VA: 0x18128FEC0
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

	// RVA: 0x128FF60 Offset: 0x128E560 VA: 0x18128FF60
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

	// RVA: 0x1290510 Offset: 0x128EB10 VA: 0x181290510
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

	// RVA: 0x1290330 Offset: 0x128E930 VA: 0x181290330
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

	// RVA: 0x12901E0 Offset: 0x128E7E0 VA: 0x1812901E0
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

	// RVA: 0x1290290 Offset: 0x128E890 VA: 0x181290290
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

	// RVA: 0x12905B0 Offset: 0x128EBB0 VA: 0x1812905B0
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

	// RVA: 0x1290460 Offset: 0x128EA60 VA: 0x181290460
	private static void .cctor() { }

}

internal struct SteamParentalSettingsChanged_t : ICallbackData // TypeDefIndex: 5482
{	// Fields
	public static int _datasize; // 0x2B111FC

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9CD0 Offset: 0x1D90D0 VA: 0x1801D9CD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9CC0 Offset: 0x1D90C0 VA: 0x1801D9CC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12909A0 Offset: 0x128EFA0 VA: 0x1812909A0
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

	// RVA: 0x1290B00 Offset: 0x128F100 VA: 0x181290B00
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

	// RVA: 0x1290BB0 Offset: 0x128F1B0 VA: 0x181290BB0
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

	// RVA: 0x1290900 Offset: 0x128EF00 VA: 0x181290900
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

	// RVA: 0x1290860 Offset: 0x128EE60 VA: 0x181290860
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

	// RVA: 0x1290700 Offset: 0x128ED00 VA: 0x181290700
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

	// RVA: 0x1290660 Offset: 0x128EC60 VA: 0x181290660
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

	// RVA: 0x1290A50 Offset: 0x128F050 VA: 0x181290A50
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

	// RVA: 0x12907B0 Offset: 0x128EDB0 VA: 0x1812907B0
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

	// RVA: 0x21EA930 Offset: 0x21E8F30 VA: 0x1821EA930 Slot: 4
	public string get_Key() { }

	// RVA: 0x21EA920 Offset: 0x21E8F20 VA: 0x1821EA920 Slot: 5
	public bool get_IsUnlocked() { }

	// RVA: 0x21EA8F0 Offset: 0x21E8EF0 VA: 0x1821EA8F0
	internal void .ctor(Achievement achievement) { }

	// RVA: 0x21EA8E0 Offset: 0x21E8EE0 VA: 0x1821EA8E0 Slot: 6
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

	// RVA: 0x21EA960 Offset: 0x21E8F60 VA: 0x1821EA960
	internal void .ctor(AuthTicket ticket) { }

	// RVA: 0x21EA940 Offset: 0x21E8F40 VA: 0x1821EA940 Slot: 6
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

	// RVA: 0x21EAA70 Offset: 0x21E9070 VA: 0x1821EAA70 Slot: 5
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

	// RVA: 0x21EAB00 Offset: 0x21E9100 VA: 0x1821EAB00
	internal void .ctor(InventoryResult inventory) { }

	// RVA: 0x21EAAC0 Offset: 0x21E90C0 VA: 0x1821EAAC0 Slot: 7
	public void Dispose() { }

	// RVA: 0x21EAA90 Offset: 0x21E9090 VA: 0x1821EAA90 Slot: 4
	public bool BelongsTo(ulong userId) { }

	// RVA: 0x21EAAE0 Offset: 0x21E90E0 VA: 0x1821EAAE0 Slot: 6
	public byte[] Serialize() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5714
{	// Fields
	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Func<InventoryItem, SteamItem> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x21F0D20 Offset: 0x21EF320 VA: 0x1821F0D20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F0910 Offset: 0x21EEF10 VA: 0x1821F0910
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

	// RVA: 0x21EB2A0 Offset: 0x21E98A0 VA: 0x1821EB2A0
	public void .ctor(InventoryItem item) { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x12FA8B0 Offset: 0x12F8EB0 VA: 0x1812FA8B0 Slot: 5
	public int get_Quantity() { }

	// RVA: 0x21EB2E0 Offset: 0x21E98E0 VA: 0x1821EB2E0 Slot: 6
	public DateTimeOffset get_Acquired() { }

	// RVA: 0x21EB3E0 Offset: 0x21E99E0 VA: 0x1821EB3E0 Slot: 7
	public ulong get_WorkshopId() { }

	// RVA: 0x21EB370 Offset: 0x21E9970 VA: 0x1821EB370 Slot: 8
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

	// RVA: 0x21EB020 Offset: 0x21E9620 VA: 0x1821EB020 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x21EB150 Offset: 0x21E9750 VA: 0x1821EB150 Slot: 5
	public string get_Name() { }

	// RVA: 0x21EB040 Offset: 0x21E9640 VA: 0x1821EB040 Slot: 6
	public string get_Description() { }

	// RVA: 0x21EB1E0 Offset: 0x21E97E0 VA: 0x1821EB1E0 Slot: 7
	public string get_Type() { }

	// RVA: 0x21EB060 Offset: 0x21E9660 VA: 0x1821EB060 Slot: 8
	public string get_IconUrl() { }

	// RVA: 0x21EB130 Offset: 0x21E9730 VA: 0x1821EB130 Slot: 9
	public int get_LocalPrice() { }

	// RVA: 0x21EB110 Offset: 0x21E9710 VA: 0x1821EB110 Slot: 10
	public string get_LocalPriceFormatted() { }

	// RVA: 0x21EB170 Offset: 0x21E9770 VA: 0x1821EB170 Slot: 11
	public string get_PriceCategory() { }

	// RVA: 0x21EB080 Offset: 0x21E9680 VA: 0x1821EB080 Slot: 12
	public bool get_IsGenerator() { }

	// RVA: 0x21EB0A0 Offset: 0x21E96A0 VA: 0x1821EB0A0 Slot: 13
	public bool get_IsMarketable() { }

	// RVA: 0x21EB190 Offset: 0x21E9790 VA: 0x1821EB190 Slot: 14
	public string get_StoreTags() { }

	// RVA: 0x21EB0C0 Offset: 0x21E96C0 VA: 0x1821EB0C0 Slot: 15
	public string get_ItemShortName() { }

	// RVA: 0x21EB250 Offset: 0x21E9850 VA: 0x1821EB250 Slot: 16
	public ulong get_WorkshopId() { }

	// RVA: 0x21EB200 Offset: 0x21E9800 VA: 0x1821EB200 Slot: 17
	public ulong get_WorkshopDownload() { }

	// RVA: 0x21EAE30 Offset: 0x21E9430 VA: 0x1821EAE30 Slot: 18
	public IEnumerable<PlayerItemRecipe> GetRecipesContainingThis() { }

	// RVA: 0x21EAEC0 Offset: 0x21E94C0 VA: 0x1821EAEC0
	private static PlayerItemRecipe SteamToPlatformRecipe(InventoryRecipe recipe) { }

	// RVA: 0x155E6B0 Offset: 0x155CCB0 VA: 0x18155E6B0 Slot: 19
	public bool Equals(IPlayerItemDefinition other) { }

	// RVA: 0x21EAC70 Offset: 0x21E9270 VA: 0x1821EAC70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21EADE0 Offset: 0x21E93E0 VA: 0x1821EADE0 Slot: 2
	public override int GetHashCode() { }

}

private sealed class SteamItemDefinition.<>c // TypeDefIndex: 5717
{	// Fields
	public static readonly SteamItemDefinition.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x21F0DE0 Offset: 0x21EF3E0 VA: 0x1821F0DE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F08D0 Offset: 0x21EEED0 VA: 0x1821F08D0
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
	// RVA: 0x21ED1C0 Offset: 0x21EB7C0 VA: 0x1821ED1C0
	private static void LoadAvatarFromSteamAsync(ulong userId, Texture2D texture) { }

	// RVA: 0x21EC100 Offset: 0x21EA700 VA: 0x1821EC100 Slot: 19
	public Texture2D GetAvatarTexture(ulong userId) { }

	// RVA: 0x21EC170 Offset: 0x21EA770 VA: 0x1821EC170 Slot: 45
	public IDownloadableContent GetDownloadableContent(int appId) { }

	// RVA: 0x21EC840 Offset: 0x21EAE40 VA: 0x1821EC840 Slot: 46
	public IWorkshopContent GetWorkshopContent(ulong workshopId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 36
	public IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	private void set_ItemDefinitions(IReadOnlyList<IPlayerItemDefinition> value) { }

	// RVA: 0x364A70 Offset: 0x363070 VA: 0x180364A70 Slot: 37
	public void RefreshItemDefinitions() { }

	// RVA: 0x21EC2B0 Offset: 0x21EA8B0 VA: 0x1821EC2B0 Slot: 38
	public IPlayerItemDefinition GetItemDefinition(int definitionId) { }

	// RVA: 0x21ED2A0 Offset: 0x21EB8A0 VA: 0x1821ED2A0
	private void OnDefinitionsUpdated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 39
	public IReadOnlyList<IPlayerItem> get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_Items(IReadOnlyList<IPlayerItem> value) { }

	// RVA: 0x21ED5F0 Offset: 0x21EBBF0 VA: 0x1821ED5F0 Slot: 40
	public void RefreshItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB410 Offset: 0xCA810 VA: 0x1800CB410
	// RVA: 0x21ED520 Offset: 0x21EBB20 VA: 0x1821ED520 Slot: 41
	public Task<IPlayerInventory> RefreshAndGetItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB650 Offset: 0xCAA50 VA: 0x1800CB650
	// RVA: 0x21EB870 Offset: 0x21E9E70 VA: 0x1821EB870 Slot: 42
	public Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output) { }

	[AsyncStateMachineAttribute] // RVA: 0xCB8F0 Offset: 0xCACF0 VA: 0x1800CB8F0
	// RVA: 0x21EC4E0 Offset: 0x21EAAE0 VA: 0x1821EC4E0 Slot: 43
	public Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices() { }

	// RVA: 0x21EBE10 Offset: 0x21EA410 VA: 0x1821EBE10 Slot: 44
	public string FormatPrice(int price) { }

	// RVA: 0x21ED410 Offset: 0x21EBA10 VA: 0x1821ED410
	private void OnInventoryUpdated(InventoryResult result) { }

	// RVA: 0x21EB670 Offset: 0x21E9C70 VA: 0x1821EB670
	private void ConfiscatedItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCBBA0 Offset: 0xCAFA0 VA: 0x1800CBBA0
	// RVA: 0x21ED0F0 Offset: 0x21EB6F0 VA: 0x1821ED0F0
	private Task InventoryDropAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450 Slot: 8
	public ulong get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE66E0 Offset: 0xEE4CE0 VA: 0x180EE66E0
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

	// RVA: 0x21EC070 Offset: 0x21EA670 VA: 0x1821EC070 Slot: 14
	public IAuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0xCCAB0 Offset: 0xCBEB0 VA: 0x1800CCAB0
	// RVA: 0x21EBFA0 Offset: 0x21EA5A0 VA: 0x1821EBFA0 Slot: 15
	public Task<IAuthTicket> GetAuthSessionTicketAsync() { }

	// RVA: 0x21EDE00 Offset: 0x21EC400 VA: 0x1821EDE00 Slot: 16
	public IEnumerable<IPlayerInfo> get_Friends() { }

	// RVA: 0x21EC7B0 Offset: 0x21EADB0 VA: 0x1821EC7B0 Slot: 17
	public IPlayerInfo GetPlayerInformation(ulong userId) { }

	[AsyncStateMachineAttribute] // RVA: 0xCCC40 Offset: 0xCC040 VA: 0x1800CCC40
	// RVA: 0x21EC690 Offset: 0x21EAC90 VA: 0x1821EC690 Slot: 18
	public Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId) { }

	// RVA: 0x21EC5B0 Offset: 0x21EABB0 VA: 0x1821EC5B0
	private SteamPlayer GetOrAddPlayer(ulong userId) { }

	// RVA: 0x21EBCA0 Offset: 0x21EA2A0 VA: 0x1821EBCA0 Slot: 27
	public string FilterChat(ulong userId, string message) { }

	// RVA: 0x21EBD90 Offset: 0x21EA390 VA: 0x1821EBD90 Slot: 28
	public string FilterName(ulong userId, string message) { }

	// RVA: 0x21EBD20 Offset: 0x21EA320 VA: 0x1821EBD20 Slot: 29
	public string FilterGeneric(string message) { }

	// RVA: 0x21EB660 Offset: 0x21E9C60 VA: 0x1821EB660 Slot: 47
	public void ClearRichPresence() { }

	// RVA: 0x21EC830 Offset: 0x21EAE30 VA: 0x1821EC830 Slot: 48
	public string GetRichPresence(string key) { }

	// RVA: 0x21ED880 Offset: 0x21EBE80 VA: 0x1821ED880 Slot: 49
	public void SetRichPresence(string key, string value) { }

	// RVA: 0x21EB990 Offset: 0x21E9F90 VA: 0x1821EB990 Slot: 20
	public IServerQuery CreateServerQuery(ServerQuerySet querySet) { }

	// RVA: 0x21EBAF0 Offset: 0x21EA0F0 VA: 0x1821EBAF0 Slot: 21
	public IServerQuery CreateServerQuery(IEnumerable<string> endpoints) { }

	// RVA: 0x21EB560 Offset: 0x21E9B60 VA: 0x1821EB560 Slot: 22
	public void AddServerToHistory(ServerInfo server) { }

	// RVA: 0x21ED740 Offset: 0x21EBD40 VA: 0x1821ED740 Slot: 23
	public void RemoveServerFromHistory(ServerInfo server) { }

	// RVA: 0x21EDD70 Offset: 0x21EC370 VA: 0x1821EDD70 Slot: 24
	public IReadOnlyList<ServerInfo> get_FavoriteServers() { }

	// RVA: 0x21EB460 Offset: 0x21E9A60 VA: 0x1821EB460 Slot: 25
	public void AddServerToFavorites(ServerInfo server) { }

	// RVA: 0x21ED640 Offset: 0x21EBC40 VA: 0x1821ED640 Slot: 26
	public void RemoveServerFromFavorites(ServerInfo server) { }

	// RVA: 0x21EDA40 Offset: 0x21EC040 VA: 0x1821EDA40
	internal static ServerInfo ToPlatformServer(ServerInfo info) { }

	// RVA: 0x21EDAF0 Offset: 0x21EC0F0 VA: 0x1821EDAF0
	internal static ServerInfo ToSteamServer(ServerInfo server) { }

	// RVA: 0x21EBEB0 Offset: 0x21EA4B0 VA: 0x1821EBEB0 Slot: 50
	public IAchievement GetAchievement(string key) { }

	// RVA: 0x21ED840 Offset: 0x21EBE40 VA: 0x1821ED840 Slot: 51
	public void RequestCurrentStats() { }

	// RVA: 0x21EC270 Offset: 0x21EA870 VA: 0x1821EC270 Slot: 52
	public long GetGlobalStatInt(string key) { }

	// RVA: 0x21EC810 Offset: 0x21EAE10 VA: 0x1821EC810 Slot: 53
	public long GetPlayerStatInt(string key) { }

	// RVA: 0x21ED870 Offset: 0x21EBE70 VA: 0x1821ED870 Slot: 54
	public void SetPlayerStatInt(string key, long value) { }

	// RVA: 0x21EC230 Offset: 0x21EA830 VA: 0x1821EC230 Slot: 55
	public double GetGlobalStatFloat(string key) { }

	// RVA: 0x21EC7F0 Offset: 0x21EADF0 VA: 0x1821EC7F0 Slot: 56
	public double GetPlayerStatFloat(string key) { }

	// RVA: 0x21ED850 Offset: 0x21EBE50 VA: 0x1821ED850 Slot: 57
	public void SetPlayerStatFloat(string key, double value) { }

	// RVA: 0x21EDF70 Offset: 0x21EC570 VA: 0x1821EDF70 Slot: 30
	public uint get_OptimalSampleRate() { }

	// RVA: 0x21EDFC0 Offset: 0x21EC5C0 VA: 0x1821EDFC0 Slot: 31
	public bool get_VoiceRecord() { }

	// RVA: 0x21EE060 Offset: 0x21EC660 VA: 0x1821EE060 Slot: 32
	public void set_VoiceRecord(bool value) { }

	// RVA: 0x21EDE80 Offset: 0x21EC480 VA: 0x1821EDE80 Slot: 33
	public bool get_HasVoiceData() { }

	// RVA: 0x21EC120 Offset: 0x21EA720 VA: 0x1821EC120 Slot: 34
	public byte[] GetCompressedVoiceData() { }

	// RVA: 0x21EBC30 Offset: 0x21EA230 VA: 0x1821EBC30 Slot: 35
	public int DecompressVoiceData(byte[] data, MemoryStream outputStream) { }

	// RVA: 0x21EDED0 Offset: 0x21EC4D0 VA: 0x1821EDED0 Slot: 7
	public bool get_IsValid() { }

	// RVA: 0x21ECA80 Offset: 0x21EB080 VA: 0x1821ECA80 Slot: 4
	public bool Initialize(IPlatformHooks hooks) { }

	// RVA: 0x21ED8A0 Offset: 0x21EBEA0 VA: 0x1821ED8A0 Slot: 5
	public void Shutdown() { }

	// RVA: 0x21EDB60 Offset: 0x21EC160 VA: 0x1821EDB60 Slot: 6
	public void Update() { }

	// RVA: 0x21ED600 Offset: 0x21EBC00 VA: 0x1821ED600
	private static AuthResponse RemapAuthResponse(AuthResponse response) { }

	// RVA: 0x21EBB70 Offset: 0x21EA170 VA: 0x1821EBB70
	private static void DebugPrintSteamCallback(CallbackType type, string content, bool isServer) { }

	// RVA: 0x21EDC20 Offset: 0x21EC220 VA: 0x1821EDC20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EDB50 Offset: 0x21EC150 VA: 0x1821EDB50
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

	// RVA: 0x21F0D80 Offset: 0x21EF380 VA: 0x1821F0D80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F0870 Offset: 0x21EEE70 VA: 0x1821F0870
	internal SteamItemDefinition <OnDefinitionsUpdated>b__13_0(InventoryDef d) { }

	// RVA: 0x21F0780 Offset: 0x21EED80 VA: 0x1821F0780
	internal InventoryItem <CraftItem>b__20_0(SteamItem i) { }

	// RVA: 0x21F07B0 Offset: 0x21EEDB0 VA: 0x1821F07B0
	internal IPlayerItemDefinition <GetItemDefinitionsWithPrices>b__21_0(InventoryDef d) { }

	// RVA: 0x21F0810 Offset: 0x21EEE10 VA: 0x1821F0810
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

	// RVA: 0x21EE2C0 Offset: 0x21EC8C0 VA: 0x1821EE2C0 Slot: 5
	public string get_UserName() { }

	// RVA: 0x21EE100 Offset: 0x21EC700 VA: 0x1821EE100 Slot: 6
	public bool get_IsOnline() { }

	// RVA: 0x21EE0E0 Offset: 0x21EC6E0 VA: 0x1821EE0E0 Slot: 7
	public bool get_IsMe() { }

	// RVA: 0x21EE0C0 Offset: 0x21EC6C0 VA: 0x1821EE0C0 Slot: 8
	public bool get_IsFriend() { }

	// RVA: 0x21EE120 Offset: 0x21EC720 VA: 0x1821EE120 Slot: 9
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x21EE140 Offset: 0x21EC740 VA: 0x1821EE140 Slot: 10
	public string get_ServerEndpoint() { }

	// RVA: 0x139FDF0 Offset: 0x139E3F0 VA: 0x18139FDF0
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
	// RVA: 0x21EE560 Offset: 0x21ECB60 VA: 0x1821EE560 Slot: 6
	public void add_OnServerFound(Action<ServerInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21EE600 Offset: 0x21ECC00 VA: 0x1821EE600 Slot: 7
	public void remove_OnServerFound(Action<ServerInfo> value) { }

	// RVA: 0x21EE400 Offset: 0x21ECA00 VA: 0x1821EE400
	public void .ctor(ServerQuerySet set, Base query) { }

	// RVA: 0x21EE300 Offset: 0x21EC900 VA: 0x1821EE300 Slot: 10
	public void Dispose() { }

	// RVA: 0x21EE2E0 Offset: 0x21EC8E0 VA: 0x1821EE2E0 Slot: 8
	public void AddFilter(string key, string value) { }

	// RVA: 0x21EE3D0 Offset: 0x21EC9D0 VA: 0x1821EE3D0 Slot: 9
	public Task RunQueryAsync(double timeoutInSeconds) { }

}

private sealed class SteamServerQuery.<>c__DisplayClass13_0 // TypeDefIndex: 5729
{	// Fields
	public List<ServerInfo> serverList; // 0x10
	public SteamServerQuery <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x21F0980 Offset: 0x21EEF80 VA: 0x1821F0980
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

	// RVA: 0x21EEB30 Offset: 0x21ED130 VA: 0x1821EEB30
	public static string get_betaName() { }

	// RVA: 0x21EEAE0 Offset: 0x21ED0E0 VA: 0x1821EEAE0
	public static string get_betaBranch() { }

	// RVA: 0x21EE6A0 Offset: 0x21ECCA0 VA: 0x1821EE6A0
	private static string GetBetaName(bool full) { }

	// RVA: 0x21EEA70 Offset: 0x21ED070 VA: 0x1821EEA70
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
	// RVA: 0x21EF4B0 Offset: 0x21EDAB0 VA: 0x1821EF4B0
	public Item get_Value() { }

	// RVA: 0x21EF540 Offset: 0x21EDB40 VA: 0x1821EF540 Slot: 4
	public ulong get_WorkshopId() { }

	// RVA: 0x21EF350 Offset: 0x21ED950 VA: 0x1821EF350 Slot: 5
	public string get_Title() { }

	// RVA: 0x21EECE0 Offset: 0x21ED2E0 VA: 0x1821EECE0 Slot: 6
	public string get_Description() { }

	// RVA: 0x21EF2A0 Offset: 0x21ED8A0 VA: 0x1821EF2A0 Slot: 7
	public IEnumerable<string> get_Tags() { }

	// RVA: 0x21EF400 Offset: 0x21EDA00 VA: 0x1821EF400 Slot: 8
	public string get_Url() { }

	// RVA: 0x21EF1F0 Offset: 0x21ED7F0 VA: 0x1821EF1F0 Slot: 9
	public string get_PreviewImageUrl() { }

	// RVA: 0x21EF050 Offset: 0x21ED650 VA: 0x1821EF050 Slot: 10
	public ulong get_OwnerId() { }

	// RVA: 0x21EF100 Offset: 0x21ED700 VA: 0x1821EF100 Slot: 11
	public IPlayerInfo get_Owner() { }

	// RVA: 0x21EEFA0 Offset: 0x21ED5A0 VA: 0x1821EEFA0 Slot: 12
	public bool get_IsInstalled() { }

	// RVA: 0x21EEE40 Offset: 0x21ED440 VA: 0x1821EEE40 Slot: 13
	public bool get_IsDownloadPending() { }

	// RVA: 0x21EEEF0 Offset: 0x21ED4F0 VA: 0x1821EEEF0 Slot: 14
	public bool get_IsDownloading() { }

	// RVA: 0x21EED90 Offset: 0x21ED390 VA: 0x1821EED90 Slot: 15
	public string get_Directory() { }

	// RVA: 0x21EEC30 Offset: 0x21ED230 VA: 0x1821EEC30
	public void .ctor(Item item) { }

	// RVA: 0x21EEB80 Offset: 0x21ED180 VA: 0x1821EEB80 Slot: 16
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

	// RVA: 0x22DA200 Offset: 0x22D8800 VA: 0x1822DA200
	public static SendType ToSteamSendType(SendMethod method, Priority priority) { }

	// RVA: 0x22DA1E0 Offset: 0x22D87E0 VA: 0x1822DA1E0
	public static ushort ToSteamLaneIndexServer(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22DA1D0 Offset: 0x22D87D0 VA: 0x1822DA1D0
	public static ushort ToSteamLaneIndexClient(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22DA070 Offset: 0x22D8670 VA: 0x1822DA070
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x22DA0C0 Offset: 0x22D86C0 VA: 0x1822DA0C0
	public static void SetDebugFunction() { }

	// RVA: 0x22DA140 Offset: 0x22D8740 VA: 0x1822DA140
	private static void SteamNetworkingUtils_OnDebugOutput(NetDebugOutput type, string str) { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x22DA790 Offset: 0x22D8D90 VA: 0x1822DA790
	public static string steamstatus() { }

	[ClientVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	[ServerVar] // RVA: 0x936C0 Offset: 0x92AC0 VA: 0x1800936C0
	// RVA: 0x22DA070 Offset: 0x22D8670 VA: 0x1822DA070
	public static void steamrelayinit() { }

	// RVA: 0x22DA2E0 Offset: 0x22D88E0 VA: 0x1822DA2E0
	public static int get_steamnetdebug() { }

	// RVA: 0x22DA5B0 Offset: 0x22D8BB0 VA: 0x1822DA5B0
	public static void set_steamnetdebug(int value) { }

	// RVA: 0x22DA290 Offset: 0x22D8890 VA: 0x1822DA290
	public static int get_steamnetdebug_ackrtt() { }

	// RVA: 0x22DA560 Offset: 0x22D8B60 VA: 0x1822DA560
	public static void set_steamnetdebug_ackrtt(int value) { }

	// RVA: 0x22DA420 Offset: 0x22D8A20 VA: 0x1822DA420
	public static int get_steamnetdebug_packetdecode() { }

	// RVA: 0x22DA6A0 Offset: 0x22D8CA0 VA: 0x1822DA6A0
	public static void set_steamnetdebug_packetdecode(int value) { }

	// RVA: 0x22DA380 Offset: 0x22D8980 VA: 0x1822DA380
	public static int get_steamnetdebug_message() { }

	// RVA: 0x22DA600 Offset: 0x22D8C00 VA: 0x1822DA600
	public static void set_steamnetdebug_message(int value) { }

	// RVA: 0x22DA470 Offset: 0x22D8A70 VA: 0x1822DA470
	public static int get_steamnetdebug_packetgaps() { }

	// RVA: 0x22DA6F0 Offset: 0x22D8CF0 VA: 0x1822DA6F0
	public static void set_steamnetdebug_packetgaps(int value) { }

	// RVA: 0x22DA3D0 Offset: 0x22D89D0 VA: 0x1822DA3D0
	public static int get_steamnetdebug_p2prendezvous() { }

	// RVA: 0x22DA650 Offset: 0x22D8C50 VA: 0x1822DA650
	public static void set_steamnetdebug_p2prendezvous(int value) { }

	// RVA: 0x22DA4C0 Offset: 0x22D8AC0 VA: 0x1822DA4C0
	public static int get_steamnetdebug_sdrrelaypings() { }

	// RVA: 0x22DA740 Offset: 0x22D8D40 VA: 0x1822DA740
	public static void set_steamnetdebug_sdrrelaypings(int value) { }

	// RVA: 0x22DA240 Offset: 0x22D8840 VA: 0x1822DA240
	public static int get_steamconnectiontimeout() { }

	// RVA: 0x22DA510 Offset: 0x22D8B10 VA: 0x1822DA510
	public static void set_steamconnectiontimeout(int value) { }

}

public class SteamNetworking.Client : Client, IConnectionManager // TypeDefIndex: 7363
{	// Fields
	private ConnectionManager manager; // 0x70
	private const int bufferSize = 32;

	// Methods

	// RVA: 0x22CC890 Offset: 0x22CAE90 VA: 0x1822CC890 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22D7DD0 Offset: 0x22D63D0 VA: 0x1822D7DD0 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22D7F30 Offset: 0x22D6530 VA: 0x1822D7F30 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22D80A0 Offset: 0x22D66A0 VA: 0x1822D80A0 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22D8460 Offset: 0x22D6A60 VA: 0x1822D8460 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 13
	private void Steamworks.IConnectionManager.OnConnecting(ConnectionInfo info) { }

	// RVA: 0x22D8570 Offset: 0x22D6B70 VA: 0x1822D8570 Slot: 14
	private void Steamworks.IConnectionManager.OnConnected(ConnectionInfo info) { }

	// RVA: 0x22D85A0 Offset: 0x22D6BA0 VA: 0x1822D85A0 Slot: 15
	private void Steamworks.IConnectionManager.OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x22D8620 Offset: 0x22D6C20 VA: 0x1822D8620 Slot: 16
	private void Steamworks.IConnectionManager.OnMessage(IntPtr data, int datasize, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D8220 Offset: 0x22D6820 VA: 0x1822D8220 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D82A0 Offset: 0x22D68A0 VA: 0x1822D82A0 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22D8300 Offset: 0x22D6900 VA: 0x1822D8300 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22D8C20 Offset: 0x22D7220 VA: 0x1822D8C20
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

	// RVA: 0x22DA040 Offset: 0x22D8640 VA: 0x1822DA040 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x22D9F20 Offset: 0x22D8520 VA: 0x1822D9F20
	public void .ctor(bool enableSteamDatagramRelay) { }

	// RVA: 0xEE6FD0 Offset: 0xEE55D0 VA: 0x180EE6FD0 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22D9A80 Offset: 0x22D8080 VA: 0x1822D9A80 Slot: 10
	public override bool Start() { }

	// RVA: 0x22D9E50 Offset: 0x22D8450 VA: 0x1822D9E50 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22D8DF0 Offset: 0x22D73F0 VA: 0x1822D8DF0 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22D90D0 Offset: 0x22D76D0 VA: 0x1822D90D0 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22D8C80 Offset: 0x22D7280 VA: 0x1822D8C80 Slot: 12
	public override void Cycle() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22D9730 Offset: 0x22D7D30 VA: 0x1822D9730 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22D9910 Offset: 0x22D7F10 VA: 0x1822D9910
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22D93F0 Offset: 0x22D79F0 VA: 0x1822D93F0 Slot: 19
	public void OnConnecting(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D92C0 Offset: 0x22D78C0 VA: 0x1822D92C0 Slot: 20
	public void OnConnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9410 Offset: 0x22D7A10 VA: 0x1822D9410 Slot: 21
	public void OnDisconnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D9490 Offset: 0x22D7A90 VA: 0x1822D9490 Slot: 22
	public void OnMessage(Connection cn, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D8ED0 Offset: 0x22D74D0 VA: 0x1822D8ED0 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D8E80 Offset: 0x22D7480 VA: 0x1822D8E80 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22D8F30 Offset: 0x22D7530 VA: 0x1822D8F30 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

private sealed class SteamNetworking.Server.<>c // TypeDefIndex: 7365
{	// Fields
	public static readonly SteamNetworking.Server.<>c <>9; // 0x0
	public static Action<NetAddress> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x22DAA80 Offset: 0x22D9080 VA: 0x1822DAA80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x22DA9F0 Offset: 0x22D8FF0 VA: 0x1822DA9F0
	internal void <Start>b__9_0(NetAddress fakeAddressCallback) { }

}

public class SteamInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8653
{	// Fields
	private IPlayerItem[] Items; // 0x20

	// Methods

	// RVA: 0x79C400 Offset: 0x79AA00 VA: 0x18079C400 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x79C2D0 Offset: 0x79A8D0 VA: 0x18079C2D0
	public bool HasItem(int itemid) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C020 Offset: 0x79A620 VA: 0x18079C020
	private void ClientUpdateSteamInventory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x79C0C0 Offset: 0x79A6C0 VA: 0x18079C0C0
	public void ClientUpdate(IPlayerInventory result) { }

	// RVA: 0x79C8C0 Offset: 0x79AEC0 VA: 0x18079C8C0
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

	// RVA: 0xA8E790 Offset: 0xA8CD90 VA: 0x180A8E790
	public bool IsInstalled() { }

	// RVA: 0xA8E5F0 Offset: 0xA8CBF0 VA: 0x180A8E5F0
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

	// RVA: 0x79BF60 Offset: 0x79A560 VA: 0x18079BF60
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

	// RVA: 0x79C010 Offset: 0x79A610 VA: 0x18079C010
	public ItemDefinition get_itemDefinition() { }

	// RVA: 0x79BF70 Offset: 0x79A570 VA: 0x18079BF70 Slot: 4
	public virtual bool HasUnlocked(ulong playerId) { }

	// RVA: 0x79C000 Offset: 0x79A600 VA: 0x18079C000
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

	// RVA: 0xA8DE30 Offset: 0xA8C430 VA: 0x180A8DE30
	public Texture GetAvatarTexture(ulong steamid) { }

	// RVA: 0xA8E040 Offset: 0xA8C640 VA: 0x180A8E040
	public string GetUserName(ulong steamid) { }

	// RVA: 0xA8E2B0 Offset: 0xA8C8B0 VA: 0x180A8E2B0
	public static void SetPlayerPresence(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA8DD50 Offset: 0xA8C350 VA: 0x180A8DD50
	public static void ClearPlayerPresence() { }

	// RVA: 0xA8DF80 Offset: 0xA8C580 VA: 0x180A8DF80
	private static string GetLocalizationKey(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA8E130 Offset: 0xA8C730 VA: 0x180A8E130
	public static void Init() { }

	// RVA: 0xA8DC80 Offset: 0xA8C280 VA: 0x180A8DC80 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA8E520 Offset: 0xA8CB20 VA: 0x180A8E520
	public void Update() { }

	// RVA: 0xA8E240 Offset: 0xA8C840 VA: 0x180A8E240
	public void OnDisable() { }

	// RVA: 0xA8E590 Offset: 0xA8CB90 VA: 0x180A8E590
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
	public static SteamNewsSource.Story[] Stories; // 0x2B111C0

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x992C0 Offset: 0x986C0 VA: 0x1800992C0
	// RVA: 0x79C900 Offset: 0x79AF00 VA: 0x18079C900
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

	// RVA: 0x7B4A10 Offset: 0x7B3010 VA: 0x1807B4A10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B4ED0 Offset: 0x7B34D0 VA: 0x1807B4ED0 Slot: 8
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

	// RVA: 0xA8F3E0 Offset: 0xA8D9E0 VA: 0x180A8F3E0
	private void OnEnable() { }

	// RVA: 0xA8F730 Offset: 0xA8DD30 VA: 0x180A8F730
	public void Refresh() { }

	// RVA: 0xA8E900 Offset: 0xA8CF00 VA: 0x180A8E900
	public void AddPlayer(IPlayerInfo f) { }

	// RVA: 0xA8F3F0 Offset: 0xA8D9F0 VA: 0x180A8F3F0
	public int Priority(IPlayerInfo f) { }

	// RVA: 0xA8EF50 Offset: 0xA8D550 VA: 0x180A8EF50
	public void FilterSearch(string name) { }

	// RVA: 0xA8EA10 Offset: 0xA8D010 VA: 0x180A8EA10
	public void AddToPanel(IEnumerable<IPlayerInfo> list, int count = -1) { }

	// RVA: 0xA8F030 Offset: 0xA8D630 VA: 0x180A8F030
	private void FriendSelected(ulong steamid, string steamName) { }

	// RVA: 0xA8F0A0 Offset: 0xA8D6A0 VA: 0x180A8F0A0
	public static void JustSeen(ulong steamid) { }

	// RVA: 0xA901A0 Offset: 0xA8E7A0 VA: 0x180A901A0
	public void .ctor() { }

	// RVA: 0xA90140 Offset: 0xA8E740 VA: 0x180A90140
	private static void .cctor() { }

}

public class SteamFriendsList.onFriendSelectedEvent : UnityEvent<ulong, string> // TypeDefIndex: 11222
{	// Methods

	// RVA: 0x7B57C0 Offset: 0x7B3DC0 VA: 0x1807B57C0
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass15_0 // TypeDefIndex: 11223
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4FA0 Offset: 0x7B35A0 VA: 0x1807B4FA0
	internal bool <AddPlayer>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass16_0 // TypeDefIndex: 11224
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B5020 Offset: 0x7B3620 VA: 0x1807B5020
	internal bool <Priority>b__0(PlayerTeam.TeamMember p) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass17_0 // TypeDefIndex: 11225
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B5090 Offset: 0x7B3690 VA: 0x1807B5090
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

	// RVA: 0x7B5190 Offset: 0x7B3790 VA: 0x1807B5190
	internal void <AddToPanel>b__1() { }

}

private sealed class SteamFriendsList.<>c // TypeDefIndex: 11228
{	// Fields
	public static readonly SteamFriendsList.<>c <>9; // 0x0
	public static Func<IPlayerInfo, string> <>9__18_0; // 0x8

	// Methods

	// RVA: 0x7B5320 Offset: 0x7B3920 VA: 0x1807B5320
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B4F20 Offset: 0x7B3520 VA: 0x1807B4F20
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
	// RVA: 0x6E6E80 Offset: 0x6E5480 VA: 0x1806E6E80
	private void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50
	private void set_Username(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2590 Offset: 0xA1990 VA: 0x1800A2590
	// RVA: 0x79C950 Offset: 0x79AF50 VA: 0x18079C950
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

