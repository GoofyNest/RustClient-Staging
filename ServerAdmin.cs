public class ServerAdminConvarInfo : MonoBehaviour // TypeDefIndex: 12077
{	// Fields
	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20
	public RustInput VariableInput; // 0x28
	public Tooltip TooltipComponent; // 0x30

	// Methods

	// RVA: 0x4C8C70 Offset: 0x4C7270 VA: 0x1804C8C70
	public void Populate(Admin.ServerConvarInfo convarInfo) { }

	// RVA: 0x4C8AA0 Offset: 0x4C70A0 VA: 0x1804C8AA0
	public void OnSubmitVariable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminPlayerEntry : MonoBehaviour // TypeDefIndex: 12078
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText Ping; // 0x20
	public RustButton Button; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Admin.PlayerInfo <CachedInfo>k__BackingField; // 0x30
	private Action selectedAction; // 0x70
	private Action deselectedAction; // 0x78

	// Properties
	public Admin.PlayerInfo CachedInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C8E90 Offset: 0x4C7490 VA: 0x1804C8E90
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C8EC0 Offset: 0x4C74C0 VA: 0x1804C8EC0
	private void set_CachedInfo(Admin.PlayerInfo value) { }

	// RVA: 0x4C8DC0 Offset: 0x4C73C0 VA: 0x1804C8DC0
	public void Populate(Admin.PlayerInfo info, Action onSelected, Action onDeselected) { }

	// RVA: 0x4C8D70 Offset: 0x4C7370 VA: 0x1804C8D70
	public void OnToggled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminPlayerId : MonoBehaviour // TypeDefIndex: 12079
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText PlayerId; // 0x20

	// Methods

	// RVA: 0x4C8EF0 Offset: 0x4C74F0 VA: 0x1804C8EF0
	public void Populate(ulong playerId) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminPlayerInfo : MonoBehaviour // TypeDefIndex: 12080
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText SteamID; // 0x20
	public RustText OwnerSteamID; // 0x28
	public RustText Ping; // 0x30
	public RustText Address; // 0x38
	public RustText ConnectedTime; // 0x40
	public RustText ViolationLevel; // 0x48
	public RustText Health; // 0x50
	public RustInput KickReasonInput; // 0x58
	public RustInput BanReasonInput; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Admin.PlayerInfo <CachedInfo>k__BackingField; // 0x68

	// Properties
	public Admin.PlayerInfo CachedInfo { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9420 Offset: 0x4C7A20 VA: 0x1804C9420
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9450 Offset: 0x4C7A50 VA: 0x1804C9450
	public void set_CachedInfo(Admin.PlayerInfo value) { }

	// RVA: 0x4C9230 Offset: 0x4C7830 VA: 0x1804C9230
	public void Populate(Admin.PlayerInfo info) { }

	// RVA: 0x4C90C0 Offset: 0x4C76C0 VA: 0x1804C90C0
	public void OnClickedKick() { }

	// RVA: 0x4C9020 Offset: 0x4C7620 VA: 0x1804C9020
	public void OnClickedBan() { }

	// RVA: 0x4C9160 Offset: 0x4C7760 VA: 0x1804C9160
	public void OnClickedSpectate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminServerInfo : MonoBehaviour // TypeDefIndex: 12081
{	// Fields
	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20

	// Methods

	// RVA: 0x4C9480 Offset: 0x4C7A80 VA: 0x1804C9480
	public void Populate(string variableName, string variableValue) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminUGCEntry : MonoBehaviour // TypeDefIndex: 12082
{	// Fields
	protected Admin.ServerUGCInfo cachedInfo; // 0x18
	private Action<byte[]> receivedCallback; // 0x40

	// Methods

	// RVA: 0x4CB120 Offset: 0x4C9720 VA: 0x1804CB120
	public void Populate(Admin.ServerUGCInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CAD60 Offset: 0x4C9360 VA: 0x1804CAD60
	protected void GetData(Action<byte[]> callback, int index = 0) { }

	// RVA: 0x4CAD50 Offset: 0x4C9350 VA: 0x1804CAD50
	public bool EntityMatches(uint entityId) { }

	// RVA: 0x4CACF0 Offset: 0x4C92F0 VA: 0x1804CACF0
	public bool DataMatches(uint crc) { }

	// RVA: 0x4CB1A0 Offset: 0x4C97A0 VA: 0x1804CB1A0
	public void ReceivedDataFromServer(byte[] data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminUGCEntryAudio : ServerAdminUGCEntry // TypeDefIndex: 12083
{	// Fields
	public AudioSource AudioSpeaker; // 0x48
	public RustText DurationText; // 0x50
	public RustSlider ProgressSlider; // 0x58
	public RustIcon PlayIcon; // 0x60
	private bool blockSeek; // 0x68

	// Methods

	// RVA: 0x4C9600 Offset: 0x4C7C00 VA: 0x1804C9600 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C9950 Offset: 0x4C7F50 VA: 0x1804C9950
	protected void Update() { }

	// RVA: 0x4C9570 Offset: 0x4C7B70 VA: 0x1804C9570
	public void OnClickedPlay() { }

	// RVA: 0x4C9670 Offset: 0x4C7C70 VA: 0x1804C9670
	public void SeekToAudioPosition(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C97D0 Offset: 0x4C7DD0 VA: 0x1804C97D0
	private void <OnVisible>b__5_0(byte[] bytes) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9870 Offset: 0x4C7E70 VA: 0x1804C9870
	private void <OnVisible>b__5_1(AudioClip clip, bool b) { }

}

public class ServerAdminUGCEntryImage : ServerAdminUGCEntry // TypeDefIndex: 12084
{	// Fields
	public RawImage Image; // 0x48
	public RectTransform Backing; // 0x50
	public GameObject MultiImageRoot; // 0x58
	public RustText ImageIndex; // 0x60
	public Vector2 OriginalImageSize; // 0x68
	private int currentIndex; // 0x70

	// Methods

	// RVA: 0x4C9EE0 Offset: 0x4C84E0 VA: 0x1804C9EE0 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C9A30 Offset: 0x4C8030 VA: 0x1804C9A30
	private void GetDataForCurrentIndex() { }

	// RVA: 0x4C9CF0 Offset: 0x4C82F0 VA: 0x1804C9CF0
	private void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x4C9AB0 Offset: 0x4C80B0 VA: 0x1804C9AB0
	public void IncrementImage(int direction) { }

	// RVA: 0x4C9BE0 Offset: 0x4C81E0 VA: 0x1804C9BE0
	public void OnClickedExpand() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9F70 Offset: 0x4C8570 VA: 0x1804C9F70
	private void <GetDataForCurrentIndex>b__7_0(byte[] bytes) { }

}

public class ServerAdminUGCEntryPattern : ServerAdminUGCEntry // TypeDefIndex: 12085
{	// Fields
	public GameObjectRef StarPrefab; // 0x48
	public RectTransform StarRoot; // 0x50

	// Methods

	// RVA: 0x4CA2A0 Offset: 0x4C88A0 VA: 0x1804CA2A0 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CA060 Offset: 0x4C8660 VA: 0x1804CA060
	public void OnLoadedPattern(List<PatternFirework.Star> stars) { }

	// RVA: 0x4C9FF0 Offset: 0x4C85F0 VA: 0x1804C9FF0
	private void ClearStars() { }

	// RVA: 0x4CA410 Offset: 0x4C8A10 VA: 0x1804CA410
	private void PlaceStar(Vector2 localPosition, Color color) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminUGCEntryStub : MonoBehaviour // TypeDefIndex: 12086
{	// Fields
	public ServerAdminUGCEntryAudio AudioWidget; // 0x18
	public ServerAdminUGCEntryImage ImageWidget; // 0x20
	public ServerAdminUGCEntryPattern PatternWidget; // 0x28
	public RustText PrefabName; // 0x30
	public RustButton HistoryButton; // 0x38
	public ServerAdminPlayerId[] HistoryIds; // 0x40
	protected Admin.ServerUGCInfo cachedInfo; // 0x48

	// Methods

	// RVA: 0x4CA7E0 Offset: 0x4C8DE0 VA: 0x1804CA7E0
	public void Populate(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CA5B0 Offset: 0x4C8BB0 VA: 0x1804CA5B0
	public void DeleteUGC() { }

	// RVA: 0x4CACA0 Offset: 0x4C92A0 VA: 0x1804CACA0
	public void .ctor() { }

}

public class ServerAdminUI : SingletonComponent<ServerAdminUI> // TypeDefIndex: 12087
{	// Fields
	public GameObjectRef PlayerEntry; // 0x18
	public RectTransform PlayerInfoParent; // 0x20
	public RustText PlayerCount; // 0x28
	public RustInput PlayerNameFilter; // 0x30
	public GameObjectRef ServerInfoEntry; // 0x38
	public RectTransform ServerInfoParent; // 0x40
	public GameObjectRef ConvarInfoEntry; // 0x48
	public GameObjectRef ConvarInfoLongEntry; // 0x50
	public RectTransform ConvarInfoParent; // 0x58
	public ServerAdminPlayerInfo PlayerInfo; // 0x60
	public RustInput UgcNameFilter; // 0x68
	public GameObjectRef ImageEntry; // 0x70
	public GameObjectRef PatternEntry; // 0x78
	public GameObjectRef SoundEntry; // 0x80
	public VirtualScroll UgcVirtualScroll; // 0x88
	public GameObject ExpandedUgcRoot; // 0x90
	public RawImage ExpandedImage; // 0x98
	public RectTransform ExpandedImageBacking; // 0xA0
	private Vector2 initialExpandedImageSize; // 0xA8
	private List<ServerAdminPlayerEntry> playerEntries; // 0xB0
	private List<ServerAdminUGCEntry> ugcEntries; // 0xB8
	private ServerAdminUI.UGCDataSource UgcSource; // 0xC0

	// Properties
	public static bool ShouldReceiveMessages { get; }

	// Methods

	// RVA: 0x4CD5D0 Offset: 0x4CBBD0 VA: 0x1804CD5D0
	public static bool get_ShouldReceiveMessages() { }

	// RVA: 0x4CB1F0 Offset: 0x4C97F0 VA: 0x1804CB1F0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4CB980 Offset: 0x4C9F80 VA: 0x1804CB980
	private void OnEnable() { }

	// RVA: 0x4CB8F0 Offset: 0x4C9EF0 VA: 0x1804CB8F0
	private void OnDisable() { }

	// RVA: 0x4CCB00 Offset: 0x4CB100 VA: 0x1804CCB00
	public void RefreshPlayerList() { }

	// RVA: 0x4CCB70 Offset: 0x4CB170 VA: 0x1804CCB70
	public void RefreshServerInfo() { }

	// RVA: 0x4CCA90 Offset: 0x4CB090 VA: 0x1804CCA90
	public void RefreshConvars() { }

	// RVA: 0x4CCBE0 Offset: 0x4CB1E0 VA: 0x1804CCBE0
	public void RefreshUGC() { }

	// RVA: 0x4CC650 Offset: 0x4CAC50 VA: 0x1804CC650
	public void ReceivePlayerList(string result) { }

	// RVA: 0x4CC850 Offset: 0x4CAE50 VA: 0x1804CC850
	public void ReceiveServerInfo(string result) { }

	// RVA: 0x4CC6C0 Offset: 0x4CACC0 VA: 0x1804CC6C0
	public void ReceiveServerConvars(string result) { }

	// RVA: 0x4CC980 Offset: 0x4CAF80 VA: 0x1804CC980
	public void ReceiveUGCList(string result) { }

	// RVA: 0x4CBE80 Offset: 0x4CA480 VA: 0x1804CBE80
	private void PopulatePlayerInfo(List<Admin.PlayerInfo> info) { }

	// RVA: 0x4CD210 Offset: 0x4CB810 VA: 0x1804CD210
	public void UpdatePlayerFilter(string newFilter) { }

	// RVA: 0x4CCC50 Offset: 0x4CB250 VA: 0x1804CCC50
	private bool ShouldShowPlayer(ServerAdminPlayerEntry entry, string filter) { }

	// RVA: -1 Offset: -1
	private void PopulateInfo<T, U>(List<T> contentArray, Func<T, GameObjectRef> getContent, RectTransform contentParent, Action<T, U> populateCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFEB10 Offset: 0xCFD110 VA: 0x180CFEB10
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, ServerAdminPlayerEntry>
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, object>
	|
	|-RVA: 0xCFF240 Offset: 0xCFD840 VA: 0x180CFF240
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, ServerAdminConvarInfo>
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, object>
	|
	|-RVA: 0xCFEF10 Offset: 0xCFD510 VA: 0x180CFEF10
	|-ServerAdminUI.PopulateInfo<object, object>
	*/

	// RVA: 0x4CC090 Offset: 0x4CA690 VA: 0x1804CC090
	private void PopulateServerInfo(Admin.ServerInfoOutput info) { }

	// RVA: 0x4CBD30 Offset: 0x4CA330 VA: 0x1804CBD30
	private void PopulateConvarInfo(List<Admin.ServerConvarInfo> info) { }

	// RVA: 0x4CCD50 Offset: 0x4CB350 VA: 0x1804CCD50
	private static bool ShouldShowUGC(string filter, Admin.ServerUGCInfo info) { }

	// RVA: 0x4CC3C0 Offset: 0x4CA9C0 VA: 0x1804CC3C0
	private void PopulateUgcInfo(List<Admin.ServerUGCInfo> info) { }

	// RVA: 0x4CB530 Offset: 0x4C9B30 VA: 0x1804CB530
	public void KickPlayer(string playerName, string kickReason) { }

	// RVA: 0x4CB2B0 Offset: 0x4C98B0 VA: 0x1804CB2B0
	public void BanPlayer(string playerName, string banReason) { }

	// RVA: 0x4CD130 Offset: 0x4CB730 VA: 0x1804CD130
	public void SpectatePlayer(string playerName) { }

	// RVA: 0x4CB7B0 Offset: 0x4C9DB0 VA: 0x1804CB7B0
	public void ModifyConvar(string convar, string newValue) { }

	// RVA: 0x4CBA20 Offset: 0x4CA020 VA: 0x1804CBA20
	public void OnReceivedAdminUGC(uint crc, byte[] data) { }

	// RVA: 0x4CC480 Offset: 0x4CAA80 VA: 0x1804CC480
	public void ReceiveFireworkPattern(uint entityId, PatternFirework.Design design) { }

	// RVA: 0x4CD420 Offset: 0x4CBA20 VA: 0x1804CD420
	public void UpdateUGCFilter(string newFilter) { }

	// RVA: 0x4CBC30 Offset: 0x4CA230 VA: 0x1804CBC30
	public void OnUGCDeleted(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CCF30 Offset: 0x4CB530 VA: 0x1804CCF30
	public void ShowExpandedImage(Texture2D tex, Admin.ServerUGCInfo forInfo) { }

	// RVA: 0x4CD460 Offset: 0x4CBA60 VA: 0x1804CD460
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CD190 Offset: 0x4CB790 VA: 0x1804CD190
	private GameObjectRef <PopulateConvarInfo>b__38_0(Admin.ServerConvarInfo convarInfo) { }

}

private class ServerAdminUI.UGCDataSource : VirtualScroll.IDataSource // TypeDefIndex: 12088
{	// Fields
	private List<Admin.ServerUGCInfo> rawInfo; // 0x10
	private List<Admin.ServerUGCInfo> filteredInfo; // 0x18
	private string lastFilter; // 0x20

	// Methods

	// RVA: 0x4D2740 Offset: 0x4D0D40 VA: 0x1804D2740 Slot: 4
	public int GetItemCount() { }

	// RVA: 0x4D2A80 Offset: 0x4D1080 VA: 0x1804D2A80 Slot: 5
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void SetInfo(List<Admin.ServerUGCInfo> newInfo) { }

	// RVA: 0x4D2860 Offset: 0x4D0E60 VA: 0x1804D2860
	public void SetFilter(string filter) { }

	// RVA: 0x4D2790 Offset: 0x4D0D90 VA: 0x1804D2790
	public void RemoveEntry(Admin.ServerUGCInfo info) { }

	// RVA: 0x4D2B60 Offset: 0x4D1160 VA: 0x1804D2B60
	public void .ctor() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_0 // TypeDefIndex: 12089
{	// Fields
	public ServerAdminUI <>4__this; // 0x10
	public string oldSelectedPlayer; // 0x18
	public Action <>9__3; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D2120 Offset: 0x4D0720 VA: 0x1804D2120
	internal GameObjectRef <PopulatePlayerInfo>b__0(Admin.PlayerInfo playerInfo) { }

	// RVA: 0x4D2140 Offset: 0x4D0740 VA: 0x1804D2140
	internal void <PopulatePlayerInfo>b__1(Admin.PlayerInfo playerInfo, ServerAdminPlayerEntry entry) { }

	// RVA: 0x4D2400 Offset: 0x4D0A00 VA: 0x1804D2400
	internal void <PopulatePlayerInfo>b__3() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_1 // TypeDefIndex: 12090
{	// Fields
	public Admin.PlayerInfo playerInfo; // 0x10
	public ServerAdminUI.<>c__DisplayClass33_0 CS$<>8__locals1; // 0x50

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D2440 Offset: 0x4D0A40 VA: 0x1804D2440
	internal void <PopulatePlayerInfo>b__2() { }

}

private sealed class ServerAdminUI.<>c // TypeDefIndex: 12091
{	// Fields
	public static readonly ServerAdminUI.<>c <>9; // 0x0
	public static Action<Admin.ServerConvarInfo, ServerAdminConvarInfo> <>9__38_1; // 0x8

	// Methods

	// RVA: 0x4D25C0 Offset: 0x4D0BC0 VA: 0x1804D25C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1E80 Offset: 0x4D0480 VA: 0x1804D1E80
	internal void <PopulateConvarInfo>b__38_1(Admin.ServerConvarInfo convarInfo, ServerAdminConvarInfo adminConvarInfo) { }

}

