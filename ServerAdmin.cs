public class ServerAdminConvarInfo : MonoBehaviour // TypeDefIndex: 12077
{	// Fields
	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20
	public RustInput VariableInput; // 0x28
	public Tooltip TooltipComponent; // 0x30

	// Methods

	// RVA: 0x4C8C00 Offset: 0x4C7200 VA: 0x1804C8C00
	public void Populate(Admin.ServerConvarInfo convarInfo) { }

	// RVA: 0x4C8A30 Offset: 0x4C7030 VA: 0x1804C8A30
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
	// RVA: 0x4C8E20 Offset: 0x4C7420 VA: 0x1804C8E20
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C8E50 Offset: 0x4C7450 VA: 0x1804C8E50
	private void set_CachedInfo(Admin.PlayerInfo value) { }

	// RVA: 0x4C8D50 Offset: 0x4C7350 VA: 0x1804C8D50
	public void Populate(Admin.PlayerInfo info, Action onSelected, Action onDeselected) { }

	// RVA: 0x4C8D00 Offset: 0x4C7300 VA: 0x1804C8D00
	public void OnToggled() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminPlayerId : MonoBehaviour // TypeDefIndex: 12079
{	// Fields
	public RustText PlayerName; // 0x18
	public RustText PlayerId; // 0x20

	// Methods

	// RVA: 0x4C8E80 Offset: 0x4C7480 VA: 0x1804C8E80
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
	// RVA: 0x4C93B0 Offset: 0x4C79B0 VA: 0x1804C93B0
	public Admin.PlayerInfo get_CachedInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C93E0 Offset: 0x4C79E0 VA: 0x1804C93E0
	public void set_CachedInfo(Admin.PlayerInfo value) { }

	// RVA: 0x4C91C0 Offset: 0x4C77C0 VA: 0x1804C91C0
	public void Populate(Admin.PlayerInfo info) { }

	// RVA: 0x4C9050 Offset: 0x4C7650 VA: 0x1804C9050
	public void OnClickedKick() { }

	// RVA: 0x4C8FB0 Offset: 0x4C75B0 VA: 0x1804C8FB0
	public void OnClickedBan() { }

	// RVA: 0x4C90F0 Offset: 0x4C76F0 VA: 0x1804C90F0
	public void OnClickedSpectate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminServerInfo : MonoBehaviour // TypeDefIndex: 12081
{	// Fields
	public RustText InfoName; // 0x18
	public RustText InfoValue; // 0x20

	// Methods

	// RVA: 0x4C9410 Offset: 0x4C7A10 VA: 0x1804C9410
	public void Populate(string variableName, string variableValue) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ServerAdminUGCEntry : MonoBehaviour // TypeDefIndex: 12082
{	// Fields
	protected Admin.ServerUGCInfo cachedInfo; // 0x18
	private Action<byte[]> receivedCallback; // 0x40

	// Methods

	// RVA: 0x4CB0B0 Offset: 0x4C96B0 VA: 0x1804CB0B0
	public void Populate(Admin.ServerUGCInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	protected virtual void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CACF0 Offset: 0x4C92F0 VA: 0x1804CACF0
	protected void GetData(Action<byte[]> callback, int index = 0) { }

	// RVA: 0x4CACE0 Offset: 0x4C92E0 VA: 0x1804CACE0
	public bool EntityMatches(uint entityId) { }

	// RVA: 0x4CAC80 Offset: 0x4C9280 VA: 0x1804CAC80
	public bool DataMatches(uint crc) { }

	// RVA: 0x4CB130 Offset: 0x4C9730 VA: 0x1804CB130
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

	// RVA: 0x4C9590 Offset: 0x4C7B90 VA: 0x1804C9590 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C98E0 Offset: 0x4C7EE0 VA: 0x1804C98E0
	protected void Update() { }

	// RVA: 0x4C9500 Offset: 0x4C7B00 VA: 0x1804C9500
	public void OnClickedPlay() { }

	// RVA: 0x4C9600 Offset: 0x4C7C00 VA: 0x1804C9600
	public void SeekToAudioPosition(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9760 Offset: 0x4C7D60 VA: 0x1804C9760
	private void <OnVisible>b__5_0(byte[] bytes) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9800 Offset: 0x4C7E00 VA: 0x1804C9800
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

	// RVA: 0x4C9E70 Offset: 0x4C8470 VA: 0x1804C9E70 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C99C0 Offset: 0x4C7FC0 VA: 0x1804C99C0
	private void GetDataForCurrentIndex() { }

	// RVA: 0x4C9C80 Offset: 0x4C8280 VA: 0x1804C9C80
	private void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x4C9A40 Offset: 0x4C8040 VA: 0x1804C9A40
	public void IncrementImage(int direction) { }

	// RVA: 0x4C9B70 Offset: 0x4C8170 VA: 0x1804C9B70
	public void OnClickedExpand() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C9F00 Offset: 0x4C8500 VA: 0x1804C9F00
	private void <GetDataForCurrentIndex>b__7_0(byte[] bytes) { }

}

public class ServerAdminUGCEntryPattern : ServerAdminUGCEntry // TypeDefIndex: 12085
{	// Fields
	public GameObjectRef StarPrefab; // 0x48
	public RectTransform StarRoot; // 0x50

	// Methods

	// RVA: 0x4CA230 Offset: 0x4C8830 VA: 0x1804CA230 Slot: 4
	protected override void OnVisible(Admin.ServerUGCInfo info) { }

	// RVA: 0x4C9FF0 Offset: 0x4C85F0 VA: 0x1804C9FF0
	public void OnLoadedPattern(List<PatternFirework.Star> stars) { }

	// RVA: 0x4C9F80 Offset: 0x4C8580 VA: 0x1804C9F80
	private void ClearStars() { }

	// RVA: 0x4CA3A0 Offset: 0x4C89A0 VA: 0x1804CA3A0
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

	// RVA: 0x4CA770 Offset: 0x4C8D70 VA: 0x1804CA770
	public void Populate(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CA540 Offset: 0x4C8B40 VA: 0x1804CA540
	public void DeleteUGC() { }

	// RVA: 0x4CAC30 Offset: 0x4C9230 VA: 0x1804CAC30
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

	// RVA: 0x4CD560 Offset: 0x4CBB60 VA: 0x1804CD560
	public static bool get_ShouldReceiveMessages() { }

	// RVA: 0x4CB180 Offset: 0x4C9780 VA: 0x1804CB180 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4CB910 Offset: 0x4C9F10 VA: 0x1804CB910
	private void OnEnable() { }

	// RVA: 0x4CB880 Offset: 0x4C9E80 VA: 0x1804CB880
	private void OnDisable() { }

	// RVA: 0x4CCA90 Offset: 0x4CB090 VA: 0x1804CCA90
	public void RefreshPlayerList() { }

	// RVA: 0x4CCB00 Offset: 0x4CB100 VA: 0x1804CCB00
	public void RefreshServerInfo() { }

	// RVA: 0x4CCA20 Offset: 0x4CB020 VA: 0x1804CCA20
	public void RefreshConvars() { }

	// RVA: 0x4CCB70 Offset: 0x4CB170 VA: 0x1804CCB70
	public void RefreshUGC() { }

	// RVA: 0x4CC5E0 Offset: 0x4CABE0 VA: 0x1804CC5E0
	public void ReceivePlayerList(string result) { }

	// RVA: 0x4CC7E0 Offset: 0x4CADE0 VA: 0x1804CC7E0
	public void ReceiveServerInfo(string result) { }

	// RVA: 0x4CC650 Offset: 0x4CAC50 VA: 0x1804CC650
	public void ReceiveServerConvars(string result) { }

	// RVA: 0x4CC910 Offset: 0x4CAF10 VA: 0x1804CC910
	public void ReceiveUGCList(string result) { }

	// RVA: 0x4CBE10 Offset: 0x4CA410 VA: 0x1804CBE10
	private void PopulatePlayerInfo(List<Admin.PlayerInfo> info) { }

	// RVA: 0x4CD1A0 Offset: 0x4CB7A0 VA: 0x1804CD1A0
	public void UpdatePlayerFilter(string newFilter) { }

	// RVA: 0x4CCBE0 Offset: 0x4CB1E0 VA: 0x1804CCBE0
	private bool ShouldShowPlayer(ServerAdminPlayerEntry entry, string filter) { }

	// RVA: -1 Offset: -1
	private void PopulateInfo<T, U>(List<T> contentArray, Func<T, GameObjectRef> getContent, RectTransform contentParent, Action<T, U> populateCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF270 Offset: 0xCFD870 VA: 0x180CFF270
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, ServerAdminPlayerEntry>
	|-ServerAdminUI.PopulateInfo<Admin.PlayerInfo, object>
	|
	|-RVA: 0xCFF9A0 Offset: 0xCFDFA0 VA: 0x180CFF9A0
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, ServerAdminConvarInfo>
	|-ServerAdminUI.PopulateInfo<Admin.ServerConvarInfo, object>
	|
	|-RVA: 0xCFF670 Offset: 0xCFDC70 VA: 0x180CFF670
	|-ServerAdminUI.PopulateInfo<object, object>
	*/

	// RVA: 0x4CC020 Offset: 0x4CA620 VA: 0x1804CC020
	private void PopulateServerInfo(Admin.ServerInfoOutput info) { }

	// RVA: 0x4CBCC0 Offset: 0x4CA2C0 VA: 0x1804CBCC0
	private void PopulateConvarInfo(List<Admin.ServerConvarInfo> info) { }

	// RVA: 0x4CCCE0 Offset: 0x4CB2E0 VA: 0x1804CCCE0
	private static bool ShouldShowUGC(string filter, Admin.ServerUGCInfo info) { }

	// RVA: 0x4CC350 Offset: 0x4CA950 VA: 0x1804CC350
	private void PopulateUgcInfo(List<Admin.ServerUGCInfo> info) { }

	// RVA: 0x4CB4C0 Offset: 0x4C9AC0 VA: 0x1804CB4C0
	public void KickPlayer(string playerName, string kickReason) { }

	// RVA: 0x4CB240 Offset: 0x4C9840 VA: 0x1804CB240
	public void BanPlayer(string playerName, string banReason) { }

	// RVA: 0x4CD0C0 Offset: 0x4CB6C0 VA: 0x1804CD0C0
	public void SpectatePlayer(string playerName) { }

	// RVA: 0x4CB740 Offset: 0x4C9D40 VA: 0x1804CB740
	public void ModifyConvar(string convar, string newValue) { }

	// RVA: 0x4CB9B0 Offset: 0x4C9FB0 VA: 0x1804CB9B0
	public void OnReceivedAdminUGC(uint crc, byte[] data) { }

	// RVA: 0x4CC410 Offset: 0x4CAA10 VA: 0x1804CC410
	public void ReceiveFireworkPattern(uint entityId, PatternFirework.Design design) { }

	// RVA: 0x4CD3B0 Offset: 0x4CB9B0 VA: 0x1804CD3B0
	public void UpdateUGCFilter(string newFilter) { }

	// RVA: 0x4CBBC0 Offset: 0x4CA1C0 VA: 0x1804CBBC0
	public void OnUGCDeleted(Admin.ServerUGCInfo info) { }

	// RVA: 0x4CCEC0 Offset: 0x4CB4C0 VA: 0x1804CCEC0
	public void ShowExpandedImage(Texture2D tex, Admin.ServerUGCInfo forInfo) { }

	// RVA: 0x4CD3F0 Offset: 0x4CB9F0 VA: 0x1804CD3F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4CD120 Offset: 0x4CB720 VA: 0x1804CD120
	private GameObjectRef <PopulateConvarInfo>b__38_0(Admin.ServerConvarInfo convarInfo) { }

}

private class ServerAdminUI.UGCDataSource : VirtualScroll.IDataSource // TypeDefIndex: 12088
{	// Fields
	private List<Admin.ServerUGCInfo> rawInfo; // 0x10
	private List<Admin.ServerUGCInfo> filteredInfo; // 0x18
	private string lastFilter; // 0x20

	// Methods

	// RVA: 0x4D26D0 Offset: 0x4D0CD0 VA: 0x1804D26D0 Slot: 4
	public int GetItemCount() { }

	// RVA: 0x4D2A10 Offset: 0x4D1010 VA: 0x1804D2A10 Slot: 5
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void SetInfo(List<Admin.ServerUGCInfo> newInfo) { }

	// RVA: 0x4D27F0 Offset: 0x4D0DF0 VA: 0x1804D27F0
	public void SetFilter(string filter) { }

	// RVA: 0x4D2720 Offset: 0x4D0D20 VA: 0x1804D2720
	public void RemoveEntry(Admin.ServerUGCInfo info) { }

	// RVA: 0x4D2AF0 Offset: 0x4D10F0 VA: 0x1804D2AF0
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

	// RVA: 0x4D20B0 Offset: 0x4D06B0 VA: 0x1804D20B0
	internal GameObjectRef <PopulatePlayerInfo>b__0(Admin.PlayerInfo playerInfo) { }

	// RVA: 0x4D20D0 Offset: 0x4D06D0 VA: 0x1804D20D0
	internal void <PopulatePlayerInfo>b__1(Admin.PlayerInfo playerInfo, ServerAdminPlayerEntry entry) { }

	// RVA: 0x4D2390 Offset: 0x4D0990 VA: 0x1804D2390
	internal void <PopulatePlayerInfo>b__3() { }

}

private sealed class ServerAdminUI.<>c__DisplayClass33_1 // TypeDefIndex: 12090
{	// Fields
	public Admin.PlayerInfo playerInfo; // 0x10
	public ServerAdminUI.<>c__DisplayClass33_0 CS$<>8__locals1; // 0x50

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D23D0 Offset: 0x4D09D0 VA: 0x1804D23D0
	internal void <PopulatePlayerInfo>b__2() { }

}

private sealed class ServerAdminUI.<>c // TypeDefIndex: 12091
{	// Fields
	public static readonly ServerAdminUI.<>c <>9; // 0x0
	public static Action<Admin.ServerConvarInfo, ServerAdminConvarInfo> <>9__38_1; // 0x8

	// Methods

	// RVA: 0x4D2550 Offset: 0x4D0B50 VA: 0x1804D2550
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1E10 Offset: 0x4D0410 VA: 0x1804D1E10
	internal void <PopulateConvarInfo>b__38_1(Admin.ServerConvarInfo convarInfo, ServerAdminConvarInfo adminConvarInfo) { }

}

