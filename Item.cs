internal enum ItemUpdateStatus // TypeDefIndex: 5163
{	// Fields
	public int value__; // 0x0
	public const ItemUpdateStatus Invalid = 0;
	public const ItemUpdateStatus PreparingConfig = 1;
	public const ItemUpdateStatus PreparingContent = 2;
	public const ItemUpdateStatus UploadingContent = 3;
	public const ItemUpdateStatus UploadingPreviewFile = 4;
	public const ItemUpdateStatus CommittingChanges = 5;

}

internal enum ItemState // TypeDefIndex: 5164
{	// Fields
	public int value__; // 0x0
	public const ItemState None = 0;
	public const ItemState Subscribed = 1;
	public const ItemState LegacyItem = 2;
	public const ItemState Installed = 4;
	public const ItemState NeedsUpdate = 8;
	public const ItemState Downloading = 16;
	public const ItemState DownloadPending = 32;

}

internal enum ItemStatistic // TypeDefIndex: 5165
{	// Fields
	public int value__; // 0x0
	public const ItemStatistic NumSubscriptions = 0;
	public const ItemStatistic NumFavorites = 1;
	public const ItemStatistic NumFollowers = 2;
	public const ItemStatistic NumUniqueSubscriptions = 3;
	public const ItemStatistic NumUniqueFavorites = 4;
	public const ItemStatistic NumUniqueFollowers = 5;
	public const ItemStatistic NumUniqueWebsiteViews = 6;
	public const ItemStatistic ReportScore = 7;
	public const ItemStatistic NumSecondsPlayed = 8;
	public const ItemStatistic NumPlaytimeSessions = 9;
	public const ItemStatistic NumComments = 10;
	public const ItemStatistic NumSecondsPlayedDuringTimePeriod = 11;
	public const ItemStatistic NumPlaytimeSessionsDuringTimePeriod = 12;

}

public enum ItemPreviewType // TypeDefIndex: 5166
{	// Fields
	public int value__; // 0x0
	public const ItemPreviewType Image = 0;
	public const ItemPreviewType YouTubeVideo = 1;
	public const ItemPreviewType Sketchfab = 2;
	public const ItemPreviewType EnvironmentMap_HorizontalCross = 3;
	public const ItemPreviewType EnvironmentMap_LatLong = 4;
	public const ItemPreviewType ReservedMax = 255;

}

public struct Item // TypeDefIndex: 5277
{	// Fields
	internal SteamUGCDetails_t details; // 0x0
	internal PublishedFileId _id; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Title>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Description>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string[] <Tags>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Dictionary<string, string> <KeyValueTags>k__BackingField; // 0xA8
	public PublishedFileId[] Children; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private UgcAdditionalPreview[] <AdditionalPreviews>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumSubscriptions>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumFavorites>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumFollowers>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumUniqueSubscriptions>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumUniqueFavorites>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumUniqueFollowers>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumUniqueWebsiteViews>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <ReportScore>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumSecondsPlayed>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumPlaytimeSessions>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumComments>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumSecondsPlayedDuringTimePeriod>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <NumPlaytimeSessionsDuringTimePeriod>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <PreviewImageUrl>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Metadata>k__BackingField; // 0x130

	// Properties
	public PublishedFileId Id { get; }
	public string Title { get; set; }
	public string Description { get; set; }
	public string[] Tags { get; set; }
	public Dictionary<string, string> KeyValueTags { get; set; }
	public Friend Owner { get; }
	public DateTime Updated { get; }
	public UgcAdditionalPreview[] AdditionalPreviews { get; set; }
	public bool IsInstalled { get; }
	public bool IsDownloading { get; }
	public bool IsDownloadPending { get; }
	public string Directory { get; }
	private ItemState State { get; }
	public string Url { get; }
	internal ulong NumSubscriptions { set; }
	internal ulong NumFavorites { set; }
	internal ulong NumFollowers { set; }
	internal ulong NumUniqueSubscriptions { set; }
	internal ulong NumUniqueFavorites { set; }
	internal ulong NumUniqueFollowers { set; }
	internal ulong NumUniqueWebsiteViews { set; }
	internal ulong ReportScore { set; }
	internal ulong NumSecondsPlayed { set; }
	internal ulong NumPlaytimeSessions { set; }
	internal ulong NumComments { set; }
	internal ulong NumSecondsPlayedDuringTimePeriod { set; }
	internal ulong NumPlaytimeSessionsDuringTimePeriod { set; }
	public string PreviewImageUrl { get; set; }
	internal string Metadata { set; }

	// Methods

	// RVA: 0x21F6D0 Offset: 0x21EAD0 VA: 0x18021F6D0
	public void .ctor(PublishedFileId id) { }

	// RVA: 0x1D16C0 Offset: 0x1D0AC0 VA: 0x1801D16C0
	public PublishedFileId get_Id() { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x21F8A0 Offset: 0x21ECA0 VA: 0x18021F8A0
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FAE0 Offset: 0x21EEE0 VA: 0x18021FAE0
	internal void set_Title(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1E1800 Offset: 0x1E0C00 VA: 0x1801E1800
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21F9C0 Offset: 0x21EDC0 VA: 0x18021F9C0
	internal void set_Description(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xFD410 Offset: 0xFC810 VA: 0x1800FD410
	public string[] get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FAD0 Offset: 0x21EED0 VA: 0x18021FAD0
	internal void set_Tags(string[] value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xF13B0 Offset: 0xF07B0 VA: 0x1800F13B0
	public Dictionary<string, string> get_KeyValueTags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21F9D0 Offset: 0x21EDD0 VA: 0x18021F9D0
	internal void set_KeyValueTags(Dictionary<string, string> value) { }

	// RVA: 0x21F840 Offset: 0x21EC40 VA: 0x18021F840
	public Friend get_Owner() { }

	// RVA: 0x21F8B0 Offset: 0x21ECB0 VA: 0x18021F8B0
	public DateTime get_Updated() { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D1A60 Offset: 0x1D0E60 VA: 0x1801D1A60
	public UgcAdditionalPreview[] get_AdditionalPreviews() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21F9B0 Offset: 0x21EDB0 VA: 0x18021F9B0
	internal void set_AdditionalPreviews(UgcAdditionalPreview[] value) { }

	// RVA: 0x21F800 Offset: 0x21EC00 VA: 0x18021F800
	public bool get_IsInstalled() { }

	// RVA: 0x21F7C0 Offset: 0x21EBC0 VA: 0x18021F7C0
	public bool get_IsDownloading() { }

	// RVA: 0x21F780 Offset: 0x21EB80 VA: 0x18021F780
	public bool get_IsDownloadPending() { }

	// RVA: 0x21F710 Offset: 0x21EB10 VA: 0x18021F710
	public string get_Directory() { }

	// RVA: 0x21F500 Offset: 0x21E900 VA: 0x18021F500
	public bool Download(bool highPriority = False) { }

	// RVA: 0x21F860 Offset: 0x21EC60 VA: 0x18021F860
	private ItemState get_State() { }

	// RVA: 0x19C2F30 Offset: 0x19C1530 VA: 0x1819C2F30
	internal static Item From(SteamUGCDetails_t details) { }

	[AsyncStateMachineAttribute] // RVA: 0x9EB60 Offset: 0x9DF60 VA: 0x18009EB60
	// RVA: 0x21F550 Offset: 0x21E950 VA: 0x18021F550
	public Task<Nullable<Result>> Vote(bool up) { }

	// RVA: 0x21F950 Offset: 0x21ED50 VA: 0x18021F950
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA60 Offset: 0x21EE60 VA: 0x18021FA60
	internal void set_NumSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA00 Offset: 0x21EE00 VA: 0x18021FA00
	internal void set_NumFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA10 Offset: 0x21EE10 VA: 0x18021FA10
	internal void set_NumFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA90 Offset: 0x21EE90 VA: 0x18021FA90
	internal void set_NumUniqueSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA70 Offset: 0x21EE70 VA: 0x18021FA70
	internal void set_NumUniqueFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA80 Offset: 0x21EE80 VA: 0x18021FA80
	internal void set_NumUniqueFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FAA0 Offset: 0x21EEA0 VA: 0x18021FAA0
	internal void set_NumUniqueWebsiteViews(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FAC0 Offset: 0x21EEC0 VA: 0x18021FAC0
	internal void set_ReportScore(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA50 Offset: 0x21EE50 VA: 0x18021FA50
	internal void set_NumSecondsPlayed(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA30 Offset: 0x21EE30 VA: 0x18021FA30
	internal void set_NumPlaytimeSessions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21F9F0 Offset: 0x21EDF0 VA: 0x18021F9F0
	internal void set_NumComments(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA40 Offset: 0x21EE40 VA: 0x18021FA40
	internal void set_NumSecondsPlayedDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FA20 Offset: 0x21EE20 VA: 0x18021FA20
	internal void set_NumPlaytimeSessionsDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x21F850 Offset: 0x21EC50 VA: 0x18021F850
	public string get_PreviewImageUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21FAB0 Offset: 0x21EEB0 VA: 0x18021FAB0
	internal void set_PreviewImageUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21F9E0 Offset: 0x21EDE0 VA: 0x18021F9E0
	internal void set_Metadata(string value) { }

}

private struct Item.<Vote>d__83 : IAsyncStateMachine // TypeDefIndex: 5278
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Result>> <>t__builder; // 0x8
	public Item <>4__this; // 0x20
	public bool up; // 0x158
	private CallResult<SetUserItemVoteResult_t> <>u__1; // 0x160

	// Methods

	// RVA: 0x220510 Offset: 0x21F910 VA: 0x180220510 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x220520 Offset: 0x21F920 VA: 0x180220520 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

internal struct ItemInstalled_t : ICallbackData // TypeDefIndex: 5434
{	// Fields
	internal AppId AppID; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB310 Offset: 0x1EA710 VA: 0x1801EB310 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB300 Offset: 0x1EA700 VA: 0x1801EB300 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1372600 Offset: 0x1370C00 VA: 0x181372600
	private static void .cctor() { }

}

public class ItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6439
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint UID; // 0x14
	public int slots; // 0x18
	public float temperature; // 0x1C
	public int flags; // 0x20
	public int allowedContents; // 0x24
	public int maxStackSize; // 0x28
	public List<int> allowedItems; // 0x30
	public List<int> availableSlots; // 0x38
	public List<Item> contents; // 0x40

	// Methods

	// RVA: 0x1F1B120 Offset: 0x1F19720 VA: 0x181F1B120
	public static void ResetToPool(ItemContainer instance) { }

	// RVA: 0x1F1B400 Offset: 0x1F19A00 VA: 0x181F1B400
	public void ResetToPool() { }

	// RVA: 0x1F1B060 Offset: 0x1F19660 VA: 0x181F1B060 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F19B00 Offset: 0x1F18100 VA: 0x181F19B00
	public void CopyTo(ItemContainer instance) { }

	// RVA: 0x1F19E00 Offset: 0x1F18400 VA: 0x181F19E00
	public ItemContainer Copy() { }

	// RVA: 0x1F1AEE0 Offset: 0x1F194E0 VA: 0x181F1AEE0
	public static ItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1F1A390 Offset: 0x1F18990 VA: 0x181F1A390
	public static ItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1A410 Offset: 0x1F18A10 VA: 0x181F1A410
	public static ItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1ADC0 Offset: 0x1F193C0 VA: 0x181F1ADC0
	public static ItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1B0E0 Offset: 0x1F196E0 VA: 0x181F1B0E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1C210 Offset: 0x1F1A810 VA: 0x181F1C210 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1C230 Offset: 0x1F1A830 VA: 0x181F1C230 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemContainer previous) { }

	// RVA: 0x1F1B100 Offset: 0x1F19700 VA: 0x181F1B100 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1AF60 Offset: 0x1F19560 VA: 0x181F1AF60
	public static ItemContainer Deserialize(byte[] buffer, ItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1F1A990 Offset: 0x1F18F90 VA: 0x181F1A990
	public static ItemContainer Deserialize(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F19E80 Offset: 0x1F18480 VA: 0x181F19E80
	public static ItemContainer DeserializeLengthDelimited(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F1A4A0 Offset: 0x1F18AA0 VA: 0x181F1A4A0
	public static ItemContainer DeserializeLength(Stream stream, int length, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F1B6E0 Offset: 0x1F19CE0 VA: 0x181F1B6E0
	public static void SerializeDelta(Stream stream, ItemContainer instance, ItemContainer previous) { }

	// RVA: 0x1F1BDF0 Offset: 0x1F1A3F0 VA: 0x181F1BDF0
	public static void Serialize(Stream stream, ItemContainer instance) { }

	// RVA: 0x1F1C200 Offset: 0x1F1A800 VA: 0x181F1C200
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1C210 Offset: 0x1F1A810 VA: 0x181F1C210
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1BCE0 Offset: 0x1F1A2E0 VA: 0x181F1BCE0
	public static byte[] SerializeToBytes(ItemContainer instance) { }

	// RVA: 0x1F1BC30 Offset: 0x1F1A230 VA: 0x181F1BC30
	public static void SerializeLengthDelimited(Stream stream, ItemContainer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6440
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint UID; // 0x14
	public int itemid; // 0x18
	public int slot; // 0x1C
	public int amount; // 0x20
	public int flags; // 0x24
	public float removetime; // 0x28
	public float locktime; // 0x2C
	public uint worldEntity; // 0x30
	public Item.InstanceData instanceData; // 0x38
	public uint heldEntity; // 0x40
	public Item.ConditionData conditionData; // 0x48
	public string name; // 0x50
	public string text; // 0x58
	public ulong skinid; // 0x60
	public ItemContainer contents; // 0x68

	// Methods

	// RVA: 0x1C106A0 Offset: 0x1C0ECA0 VA: 0x181C106A0
	public static void ResetToPool(Item instance) { }

	// RVA: 0x1C108C0 Offset: 0x1C0EEC0 VA: 0x181C108C0
	public void ResetToPool() { }

	// RVA: 0x1C105E0 Offset: 0x1C0EBE0 VA: 0x181C105E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0EF40 Offset: 0x1C0D540 VA: 0x181C0EF40
	public void CopyTo(Item instance) { }

	// RVA: 0x1C0F090 Offset: 0x1C0D690 VA: 0x181C0F090
	public Item Copy() { }

	// RVA: 0x1C10440 Offset: 0x1C0EA40 VA: 0x181C10440
	public static Item Deserialize(Stream stream) { }

	// RVA: 0x1C0F710 Offset: 0x1C0DD10 VA: 0x181C0F710
	public static Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0FD70 Offset: 0x1C0E370 VA: 0x181C0FD70
	public static Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C104C0 Offset: 0x1C0EAC0 VA: 0x181C104C0
	public static Item Deserialize(byte[] buffer) { }

	// RVA: 0x1C10660 Offset: 0x1C0EC60 VA: 0x181C10660
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C11A60 Offset: 0x1C10060 VA: 0x181C11A60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C11A80 Offset: 0x1C10080 VA: 0x181C11A80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item previous) { }

	// RVA: 0x1C10680 Offset: 0x1C0EC80 VA: 0x181C10680 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C10340 Offset: 0x1C0E940 VA: 0x181C10340
	public static Item Deserialize(byte[] buffer, Item instance, bool isDelta = False) { }

	// RVA: 0x1C0FE00 Offset: 0x1C0E400 VA: 0x181C0FE00
	public static Item Deserialize(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C0F110 Offset: 0x1C0D710 VA: 0x181C0F110
	public static Item DeserializeLengthDelimited(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C0F790 Offset: 0x1C0DD90 VA: 0x181C0F790
	public static Item DeserializeLength(Stream stream, int length, Item instance, bool isDelta) { }

	// RVA: 0x1C10AE0 Offset: 0x1C0F0E0 VA: 0x181C10AE0
	public static void SerializeDelta(Stream stream, Item instance, Item previous) { }

	// RVA: 0x1C11480 Offset: 0x1C0FA80 VA: 0x181C11480
	public static void Serialize(Stream stream, Item instance) { }

	// RVA: 0x1C11A50 Offset: 0x1C10050 VA: 0x181C11A50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C11A60 Offset: 0x1C10060 VA: 0x181C11A60
	public void ToProto(Stream stream) { }

	// RVA: 0x1C11370 Offset: 0x1C0F970 VA: 0x181C11370
	public static byte[] SerializeToBytes(Item instance) { }

	// RVA: 0x1C112C0 Offset: 0x1C0F8C0 VA: 0x181C112C0
	public static void SerializeLengthDelimited(Stream stream, Item instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Item.InstanceData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6441
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int dataInt; // 0x14
	public int blueprintTarget; // 0x18
	public int blueprintAmount; // 0x1C
	public uint subEntity; // 0x20

	// Methods

	// RVA: 0x1F17B60 Offset: 0x1F16160 VA: 0x181F17B60
	public static void ResetToPool(Item.InstanceData instance) { }

	// RVA: 0x1F17AC0 Offset: 0x1F160C0 VA: 0x181F17AC0
	public void ResetToPool() { }

	// RVA: 0x1F17770 Offset: 0x1F15D70 VA: 0x181F17770 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07AD0 Offset: 0x1C060D0 VA: 0x181C07AD0
	public void CopyTo(Item.InstanceData instance) { }

	// RVA: 0x1F165E0 Offset: 0x1F14BE0 VA: 0x181F165E0
	public Item.InstanceData Copy() { }

	// RVA: 0x1F17210 Offset: 0x1F15810 VA: 0x181F17210
	public static Item.InstanceData Deserialize(Stream stream) { }

	// RVA: 0x1F16940 Offset: 0x1F14F40 VA: 0x181F16940
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F16C80 Offset: 0x1F15280 VA: 0x181F16C80
	public static Item.InstanceData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F17460 Offset: 0x1F15A60 VA: 0x181F17460
	public static Item.InstanceData Deserialize(byte[] buffer) { }

	// RVA: 0x1F17890 Offset: 0x1F15E90 VA: 0x181F17890
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F18140 Offset: 0x1F16740 VA: 0x181F18140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F18160 Offset: 0x1F16760 VA: 0x181F18160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.InstanceData previous) { }

	// RVA: 0x1F17AA0 Offset: 0x1F160A0 VA: 0x181F17AA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F16F20 Offset: 0x1F15520 VA: 0x181F16F20
	public static Item.InstanceData Deserialize(byte[] buffer, Item.InstanceData instance, bool isDelta = False) { }

	// RVA: 0x1F16D10 Offset: 0x1F15310 VA: 0x181F16D10
	public static Item.InstanceData Deserialize(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F16660 Offset: 0x1F14C60 VA: 0x181F16660
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F169C0 Offset: 0x1F14FC0 VA: 0x181F169C0
	public static Item.InstanceData DeserializeLength(Stream stream, int length, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F17C00 Offset: 0x1F16200 VA: 0x181F17C00
	public static void SerializeDelta(Stream stream, Item.InstanceData instance, Item.InstanceData previous) { }

	// RVA: 0x1F17FE0 Offset: 0x1F165E0 VA: 0x181F17FE0
	public static void Serialize(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x1F18130 Offset: 0x1F16730 VA: 0x181F18130
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F18140 Offset: 0x1F16740 VA: 0x181F18140
	public void ToProto(Stream stream) { }

	// RVA: 0x1F17ED0 Offset: 0x1F164D0 VA: 0x181F17ED0
	public static byte[] SerializeToBytes(Item.InstanceData instance) { }

	// RVA: 0x1F17E20 Offset: 0x1F16420 VA: 0x181F17E20
	public static void SerializeLengthDelimited(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Item.ConditionData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6442
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float condition; // 0x14
	public float maxCondition; // 0x18

	// Methods

	// RVA: 0x1F15EE0 Offset: 0x1F144E0 VA: 0x181F15EE0
	public static void ResetToPool(Item.ConditionData instance) { }

	// RVA: 0x1F15F60 Offset: 0x1F14560 VA: 0x181F15F60
	public void ResetToPool() { }

	// RVA: 0x1F15C40 Offset: 0x1F14240 VA: 0x181F15C40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBF390 Offset: 0x1DBD990 VA: 0x181DBF390
	public void CopyTo(Item.ConditionData instance) { }

	// RVA: 0x1F14E40 Offset: 0x1F13440 VA: 0x181F14E40
	public Item.ConditionData Copy() { }

	// RVA: 0x1F15440 Offset: 0x1F13A40 VA: 0x181F15440
	public static Item.ConditionData Deserialize(Stream stream) { }

	// RVA: 0x1F14EB0 Offset: 0x1F134B0 VA: 0x181F14EB0
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F15180 Offset: 0x1F13780 VA: 0x181F15180
	public static Item.ConditionData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F15600 Offset: 0x1F13C00 VA: 0x181F15600
	public static Item.ConditionData Deserialize(byte[] buffer) { }

	// RVA: 0x1F15D40 Offset: 0x1F14340 VA: 0x181F15D40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F16430 Offset: 0x1F14A30 VA: 0x181F16430 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F16450 Offset: 0x1F14A50 VA: 0x181F16450 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.ConditionData previous) { }

	// RVA: 0x1F15EC0 Offset: 0x1F144C0 VA: 0x181F15EC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F15870 Offset: 0x1F13E70 VA: 0x181F15870
	public static Item.ConditionData Deserialize(byte[] buffer, Item.ConditionData instance, bool isDelta = False) { }

	// RVA: 0x1F15AC0 Offset: 0x1F140C0 VA: 0x181F15AC0
	public static Item.ConditionData Deserialize(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F14F30 Offset: 0x1F13530 VA: 0x181F14F30
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F15210 Offset: 0x1F13810 VA: 0x181F15210
	public static Item.ConditionData DeserializeLength(Stream stream, int length, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F15FE0 Offset: 0x1F145E0 VA: 0x181F15FE0
	public static void SerializeDelta(Stream stream, Item.ConditionData instance, Item.ConditionData previous) { }

	// RVA: 0x1F16320 Offset: 0x1F14920 VA: 0x181F16320
	public static void Serialize(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x1F16420 Offset: 0x1F14A20 VA: 0x181F16420
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F16430 Offset: 0x1F14A30 VA: 0x181F16430
	public void ToProto(Stream stream) { }

	// RVA: 0x1F16210 Offset: 0x1F14810 VA: 0x181F16210
	public static byte[] SerializeToBytes(Item.ConditionData instance) { }

	// RVA: 0x1F16160 Offset: 0x1F14760 VA: 0x181F16160
	public static void SerializeLengthDelimited(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ItemAmountList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6506
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemID; // 0x18
	public List<float> amount; // 0x20

	// Methods

	// RVA: 0x1F193A0 Offset: 0x1F179A0 VA: 0x181F193A0
	public static void ResetToPool(ItemAmountList instance) { }

	// RVA: 0x1F19250 Offset: 0x1F17850 VA: 0x181F19250
	public void ResetToPool() { }

	// RVA: 0x1F19050 Offset: 0x1F17650 VA: 0x181F19050 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F18180 Offset: 0x1F16780 VA: 0x181F18180
	public void CopyTo(ItemAmountList instance) { }

	// RVA: 0x1F18380 Offset: 0x1F16980 VA: 0x181F18380
	public ItemAmountList Copy() { }

	// RVA: 0x1F18C60 Offset: 0x1F17260 VA: 0x181F18C60
	public static ItemAmountList Deserialize(Stream stream) { }

	// RVA: 0x1F18400 Offset: 0x1F16A00 VA: 0x181F18400
	public static ItemAmountList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F187B0 Offset: 0x1F16DB0 VA: 0x181F187B0
	public static ItemAmountList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F18F30 Offset: 0x1F17530 VA: 0x181F18F30
	public static ItemAmountList Deserialize(byte[] buffer) { }

	// RVA: 0x1F19210 Offset: 0x1F17810 VA: 0x181F19210
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F19AC0 Offset: 0x1F180C0 VA: 0x181F19AC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F19AE0 Offset: 0x1F180E0 VA: 0x181F19AE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemAmountList previous) { }

	// RVA: 0x1F19230 Offset: 0x1F17830 VA: 0x181F19230 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F18B60 Offset: 0x1F17160 VA: 0x181F18B60
	public static ItemAmountList Deserialize(byte[] buffer, ItemAmountList instance, bool isDelta = False) { }

	// RVA: 0x1F18CE0 Offset: 0x1F172E0 VA: 0x181F18CE0
	public static ItemAmountList Deserialize(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F18480 Offset: 0x1F16A80 VA: 0x181F18480
	public static ItemAmountList DeserializeLengthDelimited(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F18840 Offset: 0x1F16E40 VA: 0x181F18840
	public static ItemAmountList DeserializeLength(Stream stream, int length, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F194F0 Offset: 0x1F17AF0 VA: 0x181F194F0
	public static void SerializeDelta(Stream stream, ItemAmountList instance, ItemAmountList previous) { }

	// RVA: 0x1F198B0 Offset: 0x1F17EB0 VA: 0x181F198B0
	public static void Serialize(Stream stream, ItemAmountList instance) { }

	// RVA: 0x1F19AB0 Offset: 0x1F180B0 VA: 0x181F19AB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F19AC0 Offset: 0x1F180C0 VA: 0x181F19AC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F197A0 Offset: 0x1F17DA0 VA: 0x181F197A0
	public static byte[] SerializeToBytes(ItemAmountList instance) { }

	// RVA: 0x1F196F0 Offset: 0x1F17CF0 VA: 0x181F196F0
	public static void SerializeLengthDelimited(Stream stream, ItemAmountList instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class ItemSchema // TypeDefIndex: 7740
{	// Fields
	public int appid; // 0x10
	public ItemSchema.Item[] items; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ItemSchema.Item // TypeDefIndex: 7741
{	// Fields
	public string name; // 0x10
	public uint itemdefid; // 0x18
	public string type; // 0x20
	public string price_category; // 0x28
	public string icon_url; // 0x30
	public string icon_url_large; // 0x38
	public bool marketable; // 0x40
	public bool tradable; // 0x41
	public bool commodity; // 0x42
	public string market_hash_name; // 0x48
	public string market_name; // 0x50
	public string bundle; // 0x58
	public string description; // 0x60
	public string workshopid; // 0x68
	public string itemshortname; // 0x70
	public string tags; // 0x78
	public string store_tags; // 0x80
	public string exchange; // 0x88
	public bool store_hidden; // 0x90
	public string background_color; // 0x98
	public string name_color; // 0xA0
	public DropChance dropChance; // 0xA8
	public Price priceCategory; // 0xAC
	public string workshopdownload; // 0xB0

	// Properties
	[JsonIgnoreAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public double Price { get; }

	// Methods

	// RVA: 0xE74D20 Offset: 0xE73320 VA: 0x180E74D20
	public double get_Price() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class ItemBasedFlowRestrictor : IOEntity, IContainerSounds // TypeDefIndex: 8400
{	// Fields
	private Option __menuOption_Menu_Open; // 0x288
	public ItemDefinition passthroughItem; // 0x2E0
	public ItemContainer.ContentsType allowedContents; // 0x2E8
	public int maxStackSize; // 0x2EC
	public int numSlots; // 0x2F0
	public string lootPanelName; // 0x2F8
	public const BaseEntity.Flags HasPassthrough = 128;
	public const BaseEntity.Flags Sparks = 256;
	public float passthroughItemConditionLossPerSec; // 0x300
	public SoundDefinition openSound; // 0x308
	public SoundDefinition closeSound; // 0x310

	// Properties
	public override bool HasMenuOptions { get; }
	public SoundDefinition OpenSound { get; }
	public SoundDefinition CloseSound { get; }

	// Methods

	// RVA: 0xA26870 Offset: 0xA24E70 VA: 0x180A26870 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA26D30 Offset: 0xA25330 VA: 0x180A26D30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA26BA0 Offset: 0xA251A0 VA: 0x180A26BA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0xA26B60 Offset: 0xA25160 VA: 0x180A26B60
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xA26DC0 Offset: 0xA253C0 VA: 0x180A26DC0 Slot: 159
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xA26D20 Offset: 0xA25320 VA: 0x180A26D20 Slot: 160
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xA26C90 Offset: 0xA25290 VA: 0x180A26C90
	public void .ctor() { }

}

public class ItemSearchEntry : MonoBehaviour // TypeDefIndex: 8731
{	// Fields
	public Button button; // 0x18
	public Text text; // 0x20
	public RawImage image; // 0x28
	public RawImage bpImage; // 0x30
	private ItemDefinition itemInfo; // 0x38
	private AddSellOrderManager manager; // 0x40

	// Methods

	// RVA: 0x678A90 Offset: 0x677090 VA: 0x180678A90
	public void Setup(ItemDefinition info, AddSellOrderManager mgr) { }

	// RVA: 0x678A60 Offset: 0x677060 VA: 0x180678A60
	public void Clicked() { }

	// RVA: 0x678A30 Offset: 0x677030 VA: 0x180678A30
	public void ClickedBP() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModCrackOpen : ItemModUnwrap // TypeDefIndex: 8785
{	// Methods

	// RVA: 0xA336C0 Offset: 0xA31CC0 VA: 0x180A336C0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA337D0 Offset: 0xA31DD0 VA: 0x180A337D0
	public void .ctor() { }

}

public class ItemModOpenLootBag : ItemModUnwrap // TypeDefIndex: 8793
{	// Methods

	// RVA: 0xA34030 Offset: 0xA32630 VA: 0x180A34030 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA337D0 Offset: 0xA31DD0 VA: 0x180A337D0
	public void .ctor() { }

}

public class ItemModPhoto : ItemModAssociatedEntity<PhotoEntity> // TypeDefIndex: 8814
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA349D0 Offset: 0xA32FD0 VA: 0x180A349D0
	public void .ctor() { }

}

public class ItemModUnwrap : ItemMod // TypeDefIndex: 8823
{	// Fields
	public LootSpawn revealList; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int minTries; // 0x30
	public int maxTries; // 0x34

	// Methods

	// RVA: 0xA35B00 Offset: 0xA34100 VA: 0x180A35B00 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA337D0 Offset: 0xA31DD0 VA: 0x180A337D0
	public void .ctor() { }

}

public class ItemModOpenWrapped : ItemMod // TypeDefIndex: 8829
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public static Translate.Phrase open_wrapped_gift; // 0x0
	public static Translate.Phrase open_wrapped_gift_desc; // 0x8

	// Methods

	// RVA: 0xA34140 Offset: 0xA32740 VA: 0x180A34140 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xA342A0 Offset: 0xA328A0 VA: 0x180A342A0
	private static void .cctor() { }

}

public class ItemModWrap : ItemMod // TypeDefIndex: 8830
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public ItemDefinition wrappedDefinition; // 0x28
	public static Translate.Phrase wrap_gift; // 0x0
	public static Translate.Phrase wrap_gift_desc; // 0x8

	// Methods

	// RVA: 0xA36E70 Offset: 0xA35470 VA: 0x180A36E70 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xA37000 Offset: 0xA35600 VA: 0x180A37000
	private static void .cctor() { }

}

public class ItemModXMasTreeDecoration : ItemMod // TypeDefIndex: 8832
{	// Fields
	public ItemModXMasTreeDecoration.xmasFlags flagsToChange; // 0x20

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum ItemModXMasTreeDecoration.xmasFlags // TypeDefIndex: 8833
{	// Fields
	public int value__; // 0x0
	public const ItemModXMasTreeDecoration.xmasFlags pineCones = 128;
	public const ItemModXMasTreeDecoration.xmasFlags candyCanes = 256;
	public const ItemModXMasTreeDecoration.xmasFlags gingerbreadMen = 512;
	public const ItemModXMasTreeDecoration.xmasFlags Tinsel = 1024;
	public const ItemModXMasTreeDecoration.xmasFlags Balls = 2048;
	public const ItemModXMasTreeDecoration.xmasFlags Star = 16384;
	public const ItemModXMasTreeDecoration.xmasFlags Lights = 32768;

}

public class ItemModRFListener : ItemModAssociatedEntity<PagerEntity> // TypeDefIndex: 8874
{	// Fields
	public GameObjectRef frequencyPanelPrefab; // 0x28
	private uint pendingPagerID; // 0x30

	// Methods

	// RVA: 0xA34F90 Offset: 0xA33590 VA: 0x180A34F90 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA34DD0 Offset: 0xA333D0 VA: 0x180A34DD0
	public void ConfigureClicked(BasePlayer player) { }

	// RVA: 0xA35400 Offset: 0xA33A00 VA: 0x180A35400
	public void .ctor() { }

}

public class ItemButtonTools : MonoBehaviour // TypeDefIndex: 9282
{	// Fields
	public Image image; // 0x18
	public ItemDefinition itemDef; // 0x20

	// Methods

	// RVA: 0xA274E0 Offset: 0xA25AE0 VA: 0x180A274E0
	public void GiveSelf(int amount) { }

	// RVA: 0xA273C0 Offset: 0xA259C0 VA: 0x180A273C0
	public void GiveArmed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void GiveBlueprint() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemListTools : MonoBehaviour // TypeDefIndex: 9283
{	// Fields
	public GameObject categoryButton; // 0x18
	public GameObject itemButton; // 0x20
	public RustInput searchInputText; // 0x28
	internal Button lastCategory; // 0x30
	private IOrderedEnumerable<ItemDefinition> currentItems; // 0x38
	private IOrderedEnumerable<ItemDefinition> allItems; // 0x40

	// Methods

	// RVA: 0xA306B0 Offset: 0xA2ECB0 VA: 0x180A306B0
	public void OnPanelOpened() { }

	// RVA: 0xA30680 Offset: 0xA2EC80 VA: 0x180A30680
	private void OnOpenDevTools() { }

	// RVA: 0xA2FFB0 Offset: 0xA2E5B0 VA: 0x180A2FFB0
	private void CacheAllItems() { }

	// RVA: 0xA30ED0 Offset: 0xA2F4D0 VA: 0x180A30ED0
	public void Refresh() { }

	// RVA: 0xA30840 Offset: 0xA2EE40 VA: 0x180A30840
	private void RebuildCategories() { }

	// RVA: 0xA30EE0 Offset: 0xA2F4E0 VA: 0x180A30EE0
	private void SwitchItemCategory(ItemDefinition[] defs) { }

	// RVA: 0xA30100 Offset: 0xA2E700 VA: 0x180A30100
	public void FilterItems(string searchText) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class ItemListTools.<>c // TypeDefIndex: 9284
{	// Fields
	public static readonly ItemListTools.<>c <>9; // 0x0
	public static Func<ItemDefinition, string> <>9__8_0; // 0x8
	public static Func<ItemDefinition, ItemCategory> <>9__10_0; // 0x10
	public static Func<IGrouping<ItemCategory, ItemDefinition>, ItemCategory> <>9__10_1; // 0x18
	public static Func<ItemDefinition, string> <>9__11_0; // 0x20

	// Methods

	// RVA: 0xA3B9F0 Offset: 0xA39FF0 VA: 0x180A3B9F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3A480 Offset: 0xA38A80 VA: 0x180A3A480
	internal string <CacheAllItems>b__8_0(ItemDefinition x) { }

	// RVA: 0xA3A730 Offset: 0xA38D30 VA: 0x180A3A730
	internal ItemCategory <RebuildCategories>b__10_0(ItemDefinition x) { }

	// RVA: 0xA3A750 Offset: 0xA38D50 VA: 0x180A3A750
	internal ItemCategory <RebuildCategories>b__10_1(IGrouping<ItemCategory, ItemDefinition> x) { }

	// RVA: 0xA3A480 Offset: 0xA38A80 VA: 0x180A3A480
	internal string <SwitchItemCategory>b__11_0(ItemDefinition x) { }

}

private sealed class ItemListTools.<>c__DisplayClass10_0 // TypeDefIndex: 9285
{	// Fields
	public Button btn; // 0x10
	public ItemDefinition[] itemArray; // 0x18
	public ItemListTools <>4__this; // 0x20

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3A920 Offset: 0xA38F20 VA: 0x180A3A920
	internal void <RebuildCategories>b__2() { }

}

public class ItemTools : MonoBehaviour // TypeDefIndex: 9312
{
// Namespace: 
public class ItemTools : MonoBehaviour // TypeDefIndex: 9312
	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModAssociatedEntityMobile : ItemModAssociatedEntity<MobileInventoryEntity> // TypeDefIndex: 9445
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA32580 Offset: 0xA30B80 VA: 0x180A32580 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA32790 Offset: 0xA30D90 VA: 0x180A32790
	public void .ctor() { }

}

public class ItemModCassette : ItemModAssociatedEntity<Cassette> // TypeDefIndex: 9446
{	// Fields
	public int noteSpriteIndex; // 0x28
	public PreloadedCassetteContent PreloadedContent; // 0x30

	// Properties
	protected override bool AllowNullParenting { get; }
	protected override bool AllowHeldEntityParenting { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 17
	protected override bool get_AllowHeldEntityParenting() { }

	// RVA: 0xA32A30 Offset: 0xA31030 VA: 0x180A32A30
	public void .ctor() { }

}

public class ItemModSign : ItemModAssociatedEntity<SignContent> // TypeDefIndex: 9514
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA35A40 Offset: 0xA34040 VA: 0x180A35A40
	public void .ctor() { }

}

public class ItemPickup : DroppedItem // TypeDefIndex: 9792
{	// Fields
	public ItemDefinition itemDef; // 0x188
	public int amount; // 0x190
	public ulong skinOverride; // 0x198

	// Methods

	// RVA: 0x678170 Offset: 0x676770 VA: 0x180678170
	public void .ctor() { }

}

public class ItemCraftTask // TypeDefIndex: 10103
{	// Fields
	public ItemBlueprint blueprint; // 0x10
	public float endTime; // 0x18
	public int taskUID; // 0x1C
	public BasePlayer owner; // 0x20
	public bool cancelled; // 0x28
	public Item.InstanceData instanceData; // 0x30
	public int amount; // 0x38
	public int skinID; // 0x3C
	public List<ulong> potentialOwners; // 0x40
	public List<Item> takenItems; // 0x48
	public int numCrafted; // 0x50
	public float conditionScale; // 0x54
	public float workSecondsComplete; // 0x58
	public float worksecondsRequired; // 0x5C

	// Methods

	// RVA: 0xA29FC0 Offset: 0xA285C0 VA: 0x180A29FC0
	public void .ctor() { }

}

public class ItemCrafter : EntityComponent<BasePlayer> // TypeDefIndex: 10104
{	// Fields
	public List<ItemContainer> containers; // 0x20
	public LinkedList<ItemCraftTask> queue; // 0x28
	public int taskUID; // 0x30

	// Methods

	// RVA: 0xA29FE0 Offset: 0xA285E0 VA: 0x180A29FE0
	public void AddContainer(ItemContainer container) { }

	// RVA: 0xA2A660 Offset: 0xA28C60 VA: 0x180A2A660
	public static float GetScaledDuration(ItemBlueprint bp, float workbenchLevel) { }

	// RVA: 0xA2A500 Offset: 0xA28B00 VA: 0x180A2A500
	private bool DoesHaveUsableItem(int item, int iAmount) { }

	// RVA: 0xA2A040 Offset: 0xA28640 VA: 0x180A2A040
	public bool CanCraft(ItemBlueprint bp, int amount = 1, bool free = False) { }

	// RVA: 0xA2A470 Offset: 0xA28A70 VA: 0x180A2A470
	public bool CanCraft(ItemDefinition def, int amount = 1, bool free = False) { }

	// RVA: 0xA2A6C0 Offset: 0xA28CC0 VA: 0x180A2A6C0
	public void .ctor() { }

}

public class ItemEventFlag : MonoBehaviour, IItemUpdate // TypeDefIndex: 10105
{	// Fields
	public Item.Flag flag; // 0x18
	public UnityEvent onEnabled; // 0x20
	public UnityEvent onDisable; // 0x28
	internal bool firstRun; // 0x30
	internal bool lastState; // 0x31

	// Methods

	// RVA: 0xA2B650 Offset: 0xA29C50 VA: 0x180A2B650 Slot: 5
	public virtual void OnItemUpdate(Item item) { }

	// RVA: 0xA2B6B0 Offset: 0xA29CB0 VA: 0x180A2B6B0
	public void .ctor() { }

}

public class Item // TypeDefIndex: 10106
{	// Fields
	public Nullable<int> amountOverride; // 0x10
	private static readonly Memoized<string, ValueTuple<ItemDefinition.AmountType, int>> FormatAmountMemoized; // 0x0
	private static string DefaultArmourBreakEffectPath; // 0x8
	private float _condition; // 0x18
	private float _maxCondition; // 0x1C
	public ItemDefinition info; // 0x20
	public uint uid; // 0x28
	public bool dirty; // 0x2C
	public int amount; // 0x30
	public int position; // 0x34
	public float busyTime; // 0x38
	public float removeTime; // 0x3C
	public float fuel; // 0x40
	public bool isServer; // 0x44
	public Item.InstanceData instanceData; // 0x48
	public ulong skin; // 0x50
	public string name; // 0x58
	public string text; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Action<Item> OnDirty; // 0x68
	public Item.Flag flags; // 0x70
	public ItemContainer contents; // 0x78
	public ItemContainer parent; // 0x80
	private EntityRef worldEnt; // 0x88
	private EntityRef heldEntity; // 0x98

	// Properties
	public float condition { get; set; }
	public float maxCondition { get; set; }
	public float maxConditionNormalized { get; }
	public float conditionNormalized { get; set; }
	public bool hasCondition { get; }
	public bool isBroken { get; }
	public int despawnMultiplier { get; }
	public ItemDefinition blueprintTargetDef { get; }
	public int blueprintTarget { get; set; }
	public int blueprintAmount { get; set; }
	public Item parentItem { get; }
	public float temperature { get; }
	internal Sprite iconSprite { get; }
	internal bool isLoadingIconSprite { get; }
	public BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0xA38BC0 Offset: 0xA371C0 VA: 0x180A38BC0
	public void UpdateAmountDisplay(Text text) { }

	// RVA: 0xA38C40 Offset: 0xA37240 VA: 0x180A38C40
	public static void UpdateAmountDisplay(Text text, Item item, Nullable<int> amountOverride, ItemDefinition infoOverride) { }

	// RVA: 0xA37680 Offset: 0xA35C80 VA: 0x180A37680
	private static string FormatAmount(ItemDefinition.AmountType type, int amount) { }

	// RVA: 0xA39B90 Offset: 0xA38190 VA: 0x180A39B90
	public void set_condition(float value) { }

	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_condition() { }

	// RVA: 0xA39C10 Offset: 0xA38210 VA: 0x180A39C10
	public void set_maxCondition(float value) { }

	// RVA: 0x7746E0 Offset: 0x772CE0 VA: 0x1807746E0
	public float get_maxCondition() { }

	// RVA: 0xA39940 Offset: 0xA37F40 VA: 0x180A39940
	public float get_maxConditionNormalized() { }

	// RVA: 0xA394D0 Offset: 0xA37AD0 VA: 0x180A394D0
	public float get_conditionNormalized() { }

	// RVA: 0xA39AF0 Offset: 0xA380F0 VA: 0x180A39AF0
	public void set_conditionNormalized(float value) { }

	// RVA: 0xA395D0 Offset: 0xA37BD0 VA: 0x180A395D0
	public bool get_hasCondition() { }

	// RVA: 0xA39810 Offset: 0xA37E10 VA: 0x180A39810
	public bool get_isBroken() { }

	// RVA: 0xA39510 Offset: 0xA37B10 VA: 0x180A39510
	public int get_despawnMultiplier() { }

	// RVA: 0xA394A0 Offset: 0xA37AA0 VA: 0x180A394A0
	public ItemDefinition get_blueprintTargetDef() { }

	// RVA: 0xA394C0 Offset: 0xA37AC0 VA: 0x180A394C0
	public int get_blueprintTarget() { }

	// RVA: 0xA39A60 Offset: 0xA38060 VA: 0x180A39A60
	public void set_blueprintTarget(int value) { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public int get_blueprintAmount() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	public void set_blueprintAmount(int value) { }

	// RVA: 0xA37BB0 Offset: 0xA361B0 VA: 0x180A37BB0
	public bool IsBlueprint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA393D0 Offset: 0xA379D0 VA: 0x180A393D0
	public void add_OnDirty(Action<Item> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA399B0 Offset: 0xA37FB0 VA: 0x180A399B0
	public void remove_OnDirty(Action<Item> value) { }

	// RVA: 0xA37BA0 Offset: 0xA361A0 VA: 0x180A37BA0
	public bool HasFlag(Item.Flag f) { }

	// RVA: 0xA386C0 Offset: 0xA36CC0 VA: 0x180A386C0
	public void SetFlag(Item.Flag f, bool b) { }

	// RVA: 0xA37DE0 Offset: 0xA363E0 VA: 0x180A37DE0
	public bool IsOn() { }

	// RVA: 0xA37DD0 Offset: 0xA363D0 VA: 0x180A37DD0
	public bool IsOnFire() { }

	// RVA: 0xA37D90 Offset: 0xA36390 VA: 0x180A37D90
	public bool IsCooking() { }

	// RVA: 0xA37DA0 Offset: 0xA363A0 VA: 0x180A37DA0
	public bool IsLocked() { }

	// RVA: 0xA39970 Offset: 0xA37F70 VA: 0x180A39970
	public Item get_parentItem() { }

	// RVA: 0xA38210 Offset: 0xA36810 VA: 0x180A38210
	public void MarkDirty() { }

	// RVA: 0xA38300 Offset: 0xA36900 VA: 0x180A38300
	public void OnChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CollectedForCrafting(BasePlayer crafter) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ReturnedFromCancelledCraft(BasePlayer crafter) { }

	// RVA: 0xA37C00 Offset: 0xA36200 VA: 0x180A37C00
	public bool IsChildContainer(ItemContainer c) { }

	// RVA: 0xA37BD0 Offset: 0xA361D0 VA: 0x180A37BD0
	public bool IsBusy() { }

	// RVA: 0xA37230 Offset: 0xA35830 VA: 0x180A37230
	public void BusyFor(float fTime) { }

	// RVA: 0xA384B0 Offset: 0xA36AB0 VA: 0x180A384B0
	public void Remove(float fTime = 0) { }

	// RVA: 0xA374E0 Offset: 0xA35AE0 VA: 0x180A374E0
	internal void DoRemove() { }

	// RVA: 0xA38850 Offset: 0xA36E50 VA: 0x180A38850
	public void SwitchOnOff(bool bNewState) { }

	// RVA: 0xA38190 Offset: 0xA36790 VA: 0x180A38190
	public void LockUnlock(bool bNewState) { }

	// RVA: 0xA39990 Offset: 0xA37F90 VA: 0x180A39990
	public float get_temperature() { }

	// RVA: 0xA379B0 Offset: 0xA35FB0 VA: 0x180A379B0
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA37260 Offset: 0xA35860 VA: 0x180A37260
	public bool CanBeHeld() { }

	// RVA: 0xA372A0 Offset: 0xA358A0 VA: 0x180A372A0
	public bool CanStack(Item item) { }

	// RVA: 0xA37DF0 Offset: 0xA363F0 VA: 0x180A37DF0
	public bool IsValid() { }

	// RVA: 0xA386E0 Offset: 0xA36CE0 VA: 0x180A386E0
	public void SetWorldEntity(BaseEntity ent) { }

	// RVA: 0xA38420 Offset: 0xA36A20 VA: 0x180A38420
	public void OnMovedToWorld() { }

	// RVA: 0xA37A60 Offset: 0xA36060 VA: 0x180A37A60
	public BaseEntity GetWorldEntity() { }

	// RVA: 0xA37990 Offset: 0xA35F90 VA: 0x180A37990
	public BaseEntity GetHeldEntity() { }

	// RVA: 0xA37190 Offset: 0xA35790 VA: 0x180A37190
	public bool BeltBarSelect(BasePlayer player) { }

	// RVA: 0xA379D0 Offset: 0xA35FD0 VA: 0x180A379D0 Slot: 4
	public virtual int GetTotalUISlots() { }

	// RVA: 0xA37900 Offset: 0xA35F00 VA: 0x180A37900 Slot: 5
	public virtual int GetFilledUISlots() { }

	// RVA: 0xA37A80 Offset: 0xA36080 VA: 0x180A37A80
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA37530 Offset: 0xA35B30 VA: 0x180A37530
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA377E0 Offset: 0xA35DE0 VA: 0x180A377E0
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA388D0 Offset: 0xA36ED0 VA: 0x180A388D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xA37660 Offset: 0xA35C60 VA: 0x180A37660
	public Item FindItem(uint iUID) { }

	// RVA: 0xA38270 Offset: 0xA36870 VA: 0x180A38270
	public int MaxStackable() { }

	// RVA: 0xA39670 Offset: 0xA37C70 VA: 0x180A39670
	internal Sprite get_iconSprite() { }

	// RVA: 0xA39840 Offset: 0xA37E40 VA: 0x180A39840
	internal bool get_isLoadingIconSprite() { }

	// RVA: 0xA39470 Offset: 0xA37A70 VA: 0x180A39470
	public BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0xA38510 Offset: 0xA36B10 VA: 0x180A38510 Slot: 6
	public virtual Item Save(bool bIncludeContainer = False, bool bIncludeOwners = True) { }

	// RVA: 0xA37E00 Offset: 0xA36400 VA: 0x180A37E00 Slot: 7
	public virtual void Load(Item load) { }

	// RVA: 0xA393B0 Offset: 0xA379B0 VA: 0x180A393B0
	public void .ctor() { }

	// RVA: 0xA392C0 Offset: 0xA378C0 VA: 0x180A392C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA38BB0 Offset: 0xA371B0 VA: 0x180A38BB0
	private bool <get_iconSprite>b__95_0(ItemSkinDirectory.Skin x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA38BB0 Offset: 0xA371B0 VA: 0x180A38BB0
	private bool <get_isLoadingIconSprite>b__97_0(ItemSkinDirectory.Skin x) { }

}

public enum Item.Flag // TypeDefIndex: 10107
{	// Fields
	public int value__; // 0x0
	public const Item.Flag None = 0;
	public const Item.Flag Placeholder = 1;
	public const Item.Flag IsOn = 2;
	public const Item.Flag OnFire = 4;
	public const Item.Flag IsLocked = 8;
	public const Item.Flag Cooking = 16;

}

private sealed class Item.<>c // TypeDefIndex: 10108
{	// Fields
	public static readonly Item.<>c <>9; // 0x2B10368

	// Methods

	// RVA: 0xA3B990 Offset: 0xA39F90 VA: 0x180A3B990
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3A7A0 Offset: 0xA38DA0 VA: 0x180A3A7A0
	internal string <.cctor>b__103_0(ValueTuple<ItemDefinition.AmountType, int> t) { }

}

public sealed class ItemContainer // TypeDefIndex: 10111
{	// Fields
	public ItemContainer.Flag flags; // 0x10
	public ItemContainer.ContentsType allowedContents; // 0x14
	public ItemDefinition[] onlyAllowedItems; // 0x18
	public List<ItemSlot> availableSlots; // 0x20
	public int capacity; // 0x28
	public uint uid; // 0x2C
	public bool dirty; // 0x30
	public List<Item> itemList; // 0x38
	public float temperature; // 0x40
	public Item parent; // 0x48
	public BasePlayer playerOwner; // 0x50
	public BaseEntity entityOwner; // 0x58
	public bool isServer; // 0x60
	public int maxStackSize; // 0x64

	// Properties
	public bool HasLimitedAllowedItems { get; }

	// Methods

	// RVA: 0xA28B00 Offset: 0xA27100 VA: 0x180A28B00
	public bool HasFlag(ItemContainer.Flag f) { }

	// RVA: 0xA29BB0 Offset: 0xA281B0 VA: 0x180A29BB0
	public void SetFlag(ItemContainer.Flag f, bool b) { }

	// RVA: 0xA28CD0 Offset: 0xA272D0 VA: 0x180A28CD0
	public bool IsLocked() { }

	// RVA: 0xA297F0 Offset: 0xA27DF0 VA: 0x180A297F0
	public bool PlayerItemInputBlocked() { }

	// RVA: 0xA29FA0 Offset: 0xA285A0 VA: 0x180A29FA0
	public bool get_HasLimitedAllowedItems() { }

	// RVA: 0xA29750 Offset: 0xA27D50 VA: 0x180A29750
	public void OnChanged() { }

	// RVA: 0xA27C30 Offset: 0xA26230 VA: 0x180A27C30
	public void ClientInitialize(Item parentItem, int iMaxCapacity) { }

	// RVA: 0xA281E0 Offset: 0xA267E0 VA: 0x180A281E0
	public Item FindItemByUID(uint iUID) { }

	// RVA: 0xA28C80 Offset: 0xA27280 VA: 0x180A28C80
	public bool IsFull() { }

	// RVA: 0xA28C40 Offset: 0xA27240 VA: 0x180A28C40
	public bool IsEmpty() { }

	// RVA: 0xA27B00 Offset: 0xA26100 VA: 0x180A27B00
	public bool CanAccept(Item item) { }

	// RVA: 0xA287A0 Offset: 0xA26DA0 VA: 0x180A287A0
	public int GetMaxTransferAmount(ItemDefinition def) { }

	// RVA: 0xA29BD0 Offset: 0xA281D0 VA: 0x180A29BD0
	public void SetOnlyAllowedItem(ItemDefinition def) { }

	// RVA: 0xA29C90 Offset: 0xA28290 VA: 0x180A29C90
	public void SetOnlyAllowedItems(ItemDefinition[] defs) { }

	// RVA: 0xA28B10 Offset: 0xA27110 VA: 0x180A28B10
	internal bool Insert(Item item) { }

	// RVA: 0xA29E20 Offset: 0xA28420 VA: 0x180A29E20
	public bool SlotTaken(Item item, int i) { }

	// RVA: 0xA28960 Offset: 0xA26F60 VA: 0x180A28960
	public Item GetSlot(int slot) { }

	// RVA: 0xA284D0 Offset: 0xA26AD0 VA: 0x180A284D0
	internal bool FindPosition(Item item) { }

	// RVA: 0xA27B50 Offset: 0xA26150 VA: 0x180A27B50
	internal void Clear() { }

	// RVA: 0xA28CE0 Offset: 0xA272E0 VA: 0x180A28CE0
	public void Kill() { }

	// RVA: 0xA28620 Offset: 0xA26C20 VA: 0x180A28620
	public int GetAmount(int itemid, bool onlyUsableAmounts) { }

	// RVA: 0xA28070 Offset: 0xA26670 VA: 0x180A28070
	public Item FindItemByItemID(int itemid) { }

	// RVA: 0xA28380 Offset: 0xA26980 VA: 0x180A28380
	public Item FindItemsByItemName(string name) { }

	// RVA: 0xA27E10 Offset: 0xA26410 VA: 0x180A27E10
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xA282D0 Offset: 0xA268D0 VA: 0x180A282D0
	public List<Item> FindItemsByItemID(int itemid) { }

	// RVA: 0xA29800 Offset: 0xA27E00 VA: 0x180A29800
	public ItemContainer Save() { }

	// RVA: 0xA28FA0 Offset: 0xA275A0 VA: 0x180A28FA0
	public void Load(ItemContainer container) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA27C70 Offset: 0xA26270 VA: 0x180A27C70
	public int ContainerMaxStackSize() { }

	// RVA: 0xA27D50 Offset: 0xA26350 VA: 0x180A27D50
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA28A30 Offset: 0xA27030 VA: 0x180A28A30
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA28560 Offset: 0xA26B60 VA: 0x180A28560
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA29E40 Offset: 0xA28440 VA: 0x180A29E40
	public int TotalItemAmount() { }

	// RVA: 0xA27C80 Offset: 0xA26280 VA: 0x180A27C80
	public uint ContentsHash() { }

	// RVA: 0xA27F80 Offset: 0xA26580 VA: 0x180A27F80
	internal ItemContainer FindContainer(uint id) { }

	// RVA: 0xA27690 Offset: 0xA25C90 VA: 0x180A27690
	public ItemContainer.CanAcceptResult CanAcceptItem(Item item, int targetPos) { }

	// RVA: 0xA29EF0 Offset: 0xA284F0 VA: 0x180A29EF0
	public void .ctor() { }

}

public enum ItemContainer.Flag // TypeDefIndex: 10112
{	// Fields
	public int value__; // 0x0
	public const ItemContainer.Flag IsPlayer = 1;
	public const ItemContainer.Flag Clothing = 2;
	public const ItemContainer.Flag Belt = 4;
	public const ItemContainer.Flag SingleType = 8;
	public const ItemContainer.Flag IsLocked = 16;
	public const ItemContainer.Flag ShowSlotsOnIcon = 32;
	public const ItemContainer.Flag NoBrokenItems = 64;
	public const ItemContainer.Flag NoItemInput = 128;
	public const ItemContainer.Flag ContentsHidden = 256;

}

public enum ItemContainer.ContentsType // TypeDefIndex: 10113
{	// Fields
	public int value__; // 0x0
	public const ItemContainer.ContentsType Generic = 1;
	public const ItemContainer.ContentsType Liquid = 2;

}

public enum ItemContainer.CanAcceptResult // TypeDefIndex: 10114
{	// Fields
	public int value__; // 0x0
	public const ItemContainer.CanAcceptResult CanAccept = 0;
	public const ItemContainer.CanAcceptResult CannotAccept = 1;
	public const ItemContainer.CanAcceptResult CannotAcceptRightNow = 2;

}

private sealed class ItemContainer.<>c__DisplayClass41_0 // TypeDefIndex: 10115
{	// Fields
	public int itemid; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3AAD0 Offset: 0xA390D0 VA: 0x180A3AAD0
	internal bool <FindItemsByItemID>b__0(Item x) { }

}

public class ItemBlueprint : MonoBehaviour // TypeDefIndex: 10116
{	// Fields
	public List<ItemAmount> ingredients; // 0x18
	public List<ItemDefinition> additionalUnlocks; // 0x20
	public bool defaultBlueprint; // 0x28
	public bool userCraftable; // 0x29
	public bool isResearchable; // 0x2A
	public Rarity rarity; // 0x2C
	[HeaderAttribute] // RVA: 0xB6380 Offset: 0xB5780 VA: 0x1800B6380
	public int workbenchLevelRequired; // 0x30
	[HeaderAttribute] // RVA: 0xB65C0 Offset: 0xB59C0 VA: 0x1800B65C0
	public int scrapRequired; // 0x34
	public int scrapFromRecycle; // 0x38
	[HeaderAttribute] // RVA: 0xB6770 Offset: 0xB5B70 VA: 0x1800B6770
	[TooltipAttribute] // RVA: 0xB6770 Offset: 0xB5B70 VA: 0x1800B6770
	public bool NeedsSteamItem; // 0x3C
	public int blueprintStackSize; // 0x40
	public float time; // 0x44
	public int amountToCreate; // 0x48
	public string UnlockAchievment; // 0x50
	public string RecycleStat; // 0x58

	// Properties
	public ItemDefinition targetItem { get; }
	public bool NeedsSteamDLC { get; }

	// Methods

	// RVA: 0xA27380 Offset: 0xA25980 VA: 0x180A27380
	public ItemDefinition get_targetItem() { }

	// RVA: 0xA272F0 Offset: 0xA258F0 VA: 0x180A272F0
	public bool get_NeedsSteamDLC() { }

	// RVA: 0xA26DD0 Offset: 0xA253D0 VA: 0x180A26DD0
	public string GetIngredientString(bool colorMissing) { }

	// RVA: 0xA27230 Offset: 0xA25830 VA: 0x180A27230
	public void .ctor() { }

}

public class ItemDefinition : MonoBehaviour // TypeDefIndex: 10117
{	// Fields
	[HeaderAttribute] // RVA: 0xB68A0 Offset: 0xB5CA0 VA: 0x1800B68A0
	[ReadOnlyAttribute] // RVA: 0xB68A0 Offset: 0xB5CA0 VA: 0x1800B68A0
	public int itemid; // 0x18
	[TooltipAttribute] // RVA: 0xB6A20 Offset: 0xB5E20 VA: 0x1800B6A20
	public string shortname; // 0x20
	[HeaderAttribute] // RVA: 0xB6AE0 Offset: 0xB5EE0 VA: 0x1800B6AE0
	public Translate.Phrase displayName; // 0x28
	public Translate.Phrase displayDescription; // 0x30
	public Sprite iconSprite; // 0x38
	public ItemCategory category; // 0x40
	public ItemSelectionPanel selectionPanel; // 0x44
	[HeaderAttribute] // RVA: 0xB6C30 Offset: 0xB6030 VA: 0x1800B6C30
	public int maxDraggable; // 0x48
	public ItemContainer.ContentsType itemType; // 0x4C
	public ItemDefinition.AmountType amountType; // 0x50
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ItemSlot occupySlots; // 0x54
	public int stackable; // 0x58
	public bool quickDespawn; // 0x5C
	[HeaderAttribute] // RVA: 0xB6E80 Offset: 0xB6280 VA: 0x1800B6E80
	[TooltipAttribute] // RVA: 0xB6E80 Offset: 0xB6280 VA: 0x1800B6E80
	public Rarity rarity; // 0x60
	public bool spawnAsBlueprint; // 0x64
	[HeaderAttribute] // RVA: 0xAA090 Offset: 0xA9490 VA: 0x1800AA090
	public SoundDefinition inventorySelectSound; // 0x68
	public SoundDefinition inventoryGrabSound; // 0x70
	public SoundDefinition inventoryDropSound; // 0x78
	public SoundDefinition physImpactSoundDef; // 0x80
	public ItemDefinition.Condition condition; // 0x88
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	public bool hidden; // 0xA0
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ItemDefinition.Flag flags; // 0xA4
	[TooltipAttribute] // RVA: 0x7B760 Offset: 0x7AB60 VA: 0x18007B760
	public SteamInventoryItem steamItem; // 0xA8
	[TooltipAttribute] // RVA: 0x7B860 Offset: 0x7AC60 VA: 0x18007B860
	public SteamDLCItem steamDlc; // 0xB0
	[TooltipAttribute] // RVA: 0xB7410 Offset: 0xB6810 VA: 0x1800B7410
	public ItemDefinition Parent; // 0xB8
	public GameObjectRef worldModelPrefab; // 0xC0
	public ItemDefinition isRedirectOf; // 0xC8
	public ItemDefinition.RedirectVendingBehaviour redirectVendingBehaviour; // 0xD0
	public ItemMod[] itemMods; // 0xD8
	public BaseEntity.TraitFlag Traits; // 0xE0
	public ItemSkinDirectory.Skin[] skins; // 0xE8
	private IPlayerItemDefinition[] _skins2; // 0xF0
	[TooltipAttribute] // RVA: 0xB87B0 Offset: 0xB7BB0 VA: 0x1800B87B0
	public GameObject panel; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ItemModWearable <ItemModWearable>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isHoldable>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isUsable>k__BackingField; // 0x109
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CraftableWithSkin>k__BackingField; // 0x10A
	public ItemDefinition[] Children; // 0x110

	// Properties
	public IPlayerItemDefinition[] skins2 { get; }
	public ItemBlueprint Blueprint { get; }
	public int craftingStackable { get; }
	public bool isWearable { get; }
	public ItemModWearable ItemModWearable { get; set; }
	public bool isHoldable { get; set; }
	public bool isUsable { get; set; }
	public bool HasSkins { get; }
	public bool CraftableWithSkin { get; set; }

	// Methods

	// RVA: 0xA2B1C0 Offset: 0xA297C0 VA: 0x180A2B1C0
	public IPlayerItemDefinition[] get_skins2() { }

	// RVA: 0xA2AF10 Offset: 0xA29510 VA: 0x180A2AF10
	public void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA2B020 Offset: 0xA29620 VA: 0x180A2B020
	public ItemBlueprint get_Blueprint() { }

	// RVA: 0xA2B0E0 Offset: 0xA296E0 VA: 0x180A2B0E0
	public int get_craftingStackable() { }

	// RVA: 0xA2AC90 Offset: 0xA29290 VA: 0x180A2AC90
	public bool HasFlag(ItemDefinition.Flag f) { }

	// RVA: 0xA2ACA0 Offset: 0xA292A0 VA: 0x180A2ACA0
	public void Initialize(List<ItemDefinition> itemList) { }

	// RVA: 0xA2AB90 Offset: 0xA29190 VA: 0x180A2AB90 Slot: 4
	public virtual string GetDisplayName(Item item) { }

	// RVA: 0xA2AAC0 Offset: 0xA290C0 VA: 0x180A2AAC0 Slot: 5
	public virtual string GetDescriptionText(Item item) { }

	// RVA: 0xA2AB50 Offset: 0xA29150 VA: 0x180A2AB50 Slot: 6
	public virtual string GetDescriptionText() { }

	// RVA: 0xA2A760 Offset: 0xA28D60 VA: 0x180A2A760
	public Sprite FindIconSprite(int skinid) { }

	// RVA: 0xA2B160 Offset: 0xA29760 VA: 0x180A2B160
	public bool get_isWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B0D0 Offset: 0xA296D0 VA: 0x180A2B0D0
	public ItemModWearable get_ItemModWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B3D0 Offset: 0xA299D0 VA: 0x180A2B3D0
	private void set_ItemModWearable(ItemModWearable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B140 Offset: 0xA29740 VA: 0x180A2B140
	public bool get_isHoldable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B3E0 Offset: 0xA299E0 VA: 0x180A2B3E0
	private void set_isHoldable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B150 Offset: 0xA29750 VA: 0x180A2B150
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B3F0 Offset: 0xA299F0 VA: 0x180A2B3F0
	private void set_isUsable(bool value) { }

	// RVA: 0xA2B070 Offset: 0xA29670 VA: 0x180A2B070
	public bool get_HasSkins() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B060 Offset: 0xA29660 VA: 0x180A2B060
	public bool get_CraftableWithSkin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2B3C0 Offset: 0xA299C0 VA: 0x180A2B3C0
	private void set_CraftableWithSkin(bool value) { }

	// RVA: 0xA2AFB0 Offset: 0xA295B0 VA: 0x180A2AFB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AF30 Offset: 0xA29530 VA: 0x180A2AF30
	private bool <Initialize>b__45_0(ItemDefinition x) { }

}

public struct ItemDefinition.Condition // TypeDefIndex: 10118
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xB9030 Offset: 0xB8430 VA: 0x1800B9030
	public float max; // 0x4
	[TooltipAttribute] // RVA: 0xB9140 Offset: 0xB8540 VA: 0x1800B9140
	public bool repairable; // 0x8
	[TooltipAttribute] // RVA: 0xB91A0 Offset: 0xB85A0 VA: 0x1800B91A0
	public bool maintainMaxCondition; // 0x9
	public ItemDefinition.Condition.WorldSpawnCondition foundCondition; // 0x10

}

public class ItemDefinition.Condition.WorldSpawnCondition // TypeDefIndex: 10119
{	// Fields
	public float fractionMin; // 0x10
	public float fractionMax; // 0x14

	// Methods

	// RVA: 0xA3BCE0 Offset: 0xA3A2E0 VA: 0x180A3BCE0
	public void .ctor() { }

}

public enum ItemDefinition.RedirectVendingBehaviour // TypeDefIndex: 10120
{	// Fields
	public int value__; // 0x0
	public const ItemDefinition.RedirectVendingBehaviour NoListing = 0;
	public const ItemDefinition.RedirectVendingBehaviour ListAsUniqueItem = 1;

}

public enum ItemDefinition.Flag // TypeDefIndex: 10121
{	// Fields
	public int value__; // 0x0
	public const ItemDefinition.Flag NoDropping = 1;
	public const ItemDefinition.Flag NotStraightToBelt = 2;

}

public enum ItemDefinition.AmountType // TypeDefIndex: 10122
{	// Fields
	public int value__; // 0x0
	public const ItemDefinition.AmountType Count = 0;
	public const ItemDefinition.AmountType Millilitre = 1;
	public const ItemDefinition.AmountType Feet = 2;
	public const ItemDefinition.AmountType Genetics = 3;
	public const ItemDefinition.AmountType OxygenSeconds = 4;
	public const ItemDefinition.AmountType Frequency = 5;
	public const ItemDefinition.AmountType Generic = 6;

}

private sealed class ItemDefinition.<>c__DisplayClass35_0 // TypeDefIndex: 10123
{	// Fields
	public string prefabname; // 0x10
	public ItemDefinition <>4__this; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3AA00 Offset: 0xA39000 VA: 0x180A3AA00
	internal bool <get_skins2>b__0(IPlayerItemDefinition x) { }

}

public enum ItemCategory // TypeDefIndex: 10124
{	// Fields
	public int value__; // 0x0
	public const ItemCategory Weapon = 0;
	public const ItemCategory Construction = 1;
	public const ItemCategory Items = 2;
	public const ItemCategory Resources = 3;
	public const ItemCategory Attire = 4;
	public const ItemCategory Tool = 5;
	public const ItemCategory Medical = 6;
	public const ItemCategory Food = 7;
	public const ItemCategory Ammunition = 8;
	public const ItemCategory Traps = 9;
	public const ItemCategory Misc = 10;
	public const ItemCategory All = 11;
	public const ItemCategory Common = 12;
	public const ItemCategory Component = 13;
	public const ItemCategory Search = 14;
	public const ItemCategory Favourite = 15;
	public const ItemCategory Electrical = 16;
	public const ItemCategory Fun = 17;

}

public enum ItemSlot // TypeDefIndex: 10125
{	// Fields
	public int value__; // 0x0
	public const ItemSlot None = 1;
	public const ItemSlot Barrel = 2;
	public const ItemSlot Silencer = 4;
	public const ItemSlot Scope = 8;
	public const ItemSlot UnderBarrel = 16;
	public const ItemSlot Magazine = 32;

}

public enum ItemSelectionPanel // TypeDefIndex: 10126
{	// Fields
	public int value__; // 0x0
	public const ItemSelectionPanel None = 0;
	public const ItemSelectionPanel Vessel = 1;
	public const ItemSelectionPanel Modifications = 2;
	public const ItemSelectionPanel GunInformation = 3;

}

public class ItemSelector : PropertyAttribute // TypeDefIndex: 10127
{	// Fields
	public ItemCategory category; // 0x10

	// Methods

	// RVA: 0x678C50 Offset: 0x677250 VA: 0x180678C50
	public void .ctor(ItemCategory category = 11) { }

}

public class ItemMod : MonoBehaviour // TypeDefIndex: 10128
{	// Fields
	protected ItemMod[] siblingMods; // 0x18

	// Methods

	// RVA: 0xA37140 Offset: 0xA35740 VA: 0x180A37140 Slot: 4
	public virtual void ModInit() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void OnChanged(Item item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public virtual void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 7
	public virtual bool BeltSelect(Item item, BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void OnObjectSetup(Item item, GameObject obj) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public virtual int GetTotalUISlots(Item item) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 11
	public virtual int GetFilledUISlots(Item item) { }

	// RVA: 0xA370B0 Offset: 0xA356B0 VA: 0x180A370B0 Slot: 12
	public virtual bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 13
	public virtual bool Passes(Item item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	public virtual void OnRemovedFromWorld(Item item) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void OnMovedToWorld(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModActionChange : ItemMod // TypeDefIndex: 10129
{	// Fields
	public ItemMod[] actions; // 0x20

	// Methods

	// RVA: 0xA32480 Offset: 0xA30A80 VA: 0x180A32480
	private void OnValidate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModActionContainerChange : ItemMod // TypeDefIndex: 10130
{	// Fields
	public ItemMod[] actions; // 0x20

	// Methods

	// RVA: 0xA32500 Offset: 0xA30B00 VA: 0x180A32500
	private void OnValidate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModAlterCondition : ItemMod // TypeDefIndex: 10131
{	// Fields
	public float conditionChange; // 0x20

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModAnimalEquipment : ItemMod // TypeDefIndex: 10132
{	// Fields
	public BaseEntity.Flags WearableFlag; // 0x20
	public bool hideHair; // 0x24
	public ProtectionProperties animalProtection; // 0x28
	public ProtectionProperties riderProtection; // 0x30
	public int additionalInventorySlots; // 0x38
	public float speedModifier; // 0x3C
	public float staminaUseModifier; // 0x40
	public ItemModAnimalEquipment.SlotType slot; // 0x44

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum ItemModAnimalEquipment.SlotType // TypeDefIndex: 10133
{	// Fields
	public int value__; // 0x0
	public const ItemModAnimalEquipment.SlotType Basic = 0;
	public const ItemModAnimalEquipment.SlotType Armor = 1;
	public const ItemModAnimalEquipment.SlotType Saddle = 2;
	public const ItemModAnimalEquipment.SlotType Bit = 3;
	public const ItemModAnimalEquipment.SlotType Feet = 4;

}

public abstract class ItemModAssociatedEntity<T> : ItemMod // TypeDefIndex: 10134
{	// Fields
	public GameObjectRef entityPrefab; // 0x0

	// Properties
	protected virtual bool AllowNullParenting { get; }
	protected virtual bool AllowHeldEntityParenting { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual bool get_AllowNullParenting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	|-ItemModAssociatedEntity<PagerEntity>.get_AllowNullParenting
	|-ItemModAssociatedEntity<object>.get_AllowNullParenting
	*/

	// RVA: -1 Offset: -1 Slot: 17
	protected virtual bool get_AllowHeldEntityParenting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	|-ItemModAssociatedEntity<MobileInventoryEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PagerEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<PhotoEntity>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<SignContent>.get_AllowHeldEntityParenting
	|-ItemModAssociatedEntity<object>.get_AllowHeldEntityParenting
	*/

	// RVA: -1 Offset: -1
	public static T GetAssociatedEntity(Item item, bool isServer = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1647220 Offset: 0x1645820 VA: 0x181647220
	|-ItemModAssociatedEntity<MobileInventoryEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<PagerEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>.GetAssociatedEntity
	|-ItemModAssociatedEntity<SignContent>.GetAssociatedEntity
	|-ItemModAssociatedEntity<object>.GetAssociatedEntity
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1647380 Offset: 0x1645980 VA: 0x181647380
	|-ItemModAssociatedEntity<Cassette>..ctor
	|-ItemModAssociatedEntity<MobileInventoryEntity>..ctor
	|-ItemModAssociatedEntity<PagerEntity>..ctor
	|-ItemModAssociatedEntity<PaintedItemStorageEntity>..ctor
	|-ItemModAssociatedEntity<PhotoEntity>..ctor
	|-ItemModAssociatedEntity<SignContent>..ctor
	|-ItemModAssociatedEntity<object>..ctor
	*/

}

public class ItemModBaitContainer : ItemModContainer // TypeDefIndex: 10135
{	// Methods

	// RVA: 0xA327D0 Offset: 0xA30DD0 VA: 0x180A327D0
	public void .ctor() { }

}

public class ItemModBlueprintCraft : ItemMod // TypeDefIndex: 10136
{	// Fields
	public GameObjectRef successEffect; // 0x20

	// Methods

	// RVA: 0xA327E0 Offset: 0xA30DE0 VA: 0x180A327E0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModBurnable : ItemMod // TypeDefIndex: 10137
{	// Fields
	public float fuelAmount; // 0x20
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition byproductItem; // 0x28
	public int byproductAmount; // 0x30
	public float byproductChance; // 0x34

	// Methods

	// RVA: 0xA32A10 Offset: 0xA31010 VA: 0x180A32A10
	public void .ctor() { }

}

public class ItemModCassetteContainer : ItemModContainer // TypeDefIndex: 10138
{	// Fields
	public ItemDefinition[] CassetteItems; // 0x58

	// Methods

	// RVA: 0xA327D0 Offset: 0xA30DD0 VA: 0x180A327D0
	public void .ctor() { }

}

public class ItemModChildIO : ItemMod // TypeDefIndex: 10139
{	// Fields
	public GameObjectRef TargetChildIO; // 0x20

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModCompostable : MonoBehaviour // TypeDefIndex: 10140
{	// Fields
	public float TotalFertilizerProduced; // 0x18
	public float BaitValue; // 0x1C

	// Methods

	// RVA: 0xA32A70 Offset: 0xA31070 VA: 0x180A32A70
	public void .ctor() { }

}

public class ItemModConditionContainerFlag : ItemMod // TypeDefIndex: 10141
{	// Fields
	public ItemContainer.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA32A90 Offset: 0xA31090 VA: 0x180A32A90 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionHasCondition : ItemMod // TypeDefIndex: 10142
{	// Fields
	public float conditionTarget; // 0x20
	[TooltipAttribute] // RVA: 0xB9610 Offset: 0xB8A10 VA: 0x1800B9610
	public float conditionFractionTarget; // 0x24
	public bool lessThan; // 0x28

	// Methods

	// RVA: 0xA32AE0 Offset: 0xA310E0 VA: 0x180A32AE0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0xA32BF0 Offset: 0xA311F0 VA: 0x180A32BF0
	public void .ctor() { }

}

public class ItemModConditionHasContents : ItemMod // TypeDefIndex: 10143
{	// Fields
	[TooltipAttribute] // RVA: 0xB9710 Offset: 0xB8B10 VA: 0x1800B9710
	public ItemDefinition itemDef; // 0x20
	public bool requiredState; // 0x28

	// Methods

	// RVA: 0xA32C10 Offset: 0xA31210 VA: 0x180A32C10 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA32D20 Offset: 0xA31320 VA: 0x180A32D20
	private bool <Passes>b__2_0(Item x) { }

}

public class ItemModConditionHasFlag : ItemMod // TypeDefIndex: 10144
{	// Fields
	public Item.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA32DA0 Offset: 0xA313A0 VA: 0x180A32DA0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionInWater : ItemMod // TypeDefIndex: 10145
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA32DD0 Offset: 0xA313D0 VA: 0x180A32DD0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionIsSleeping : ItemMod // TypeDefIndex: 10146
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA32E80 Offset: 0xA31480 VA: 0x180A32E80 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConsumable : MonoBehaviour // TypeDefIndex: 10147
{	// Fields
	public int amountToConsume; // 0x18
	public float conditionFractionToLose; // 0x1C
	public string achievementWhenEaten; // 0x20
	public List<ItemModConsumable.ConsumableEffect> effects; // 0x28
	public List<ModifierDefintion> modifiers; // 0x30

	// Methods

	// RVA: 0xA32F30 Offset: 0xA31530 VA: 0x180A32F30
	public float GetIfType(MetabolismAttribute.Type typeToPick) { }

	// RVA: 0xA33010 Offset: 0xA31610 VA: 0x180A33010
	public void .ctor() { }

}

public class ItemModConsumable.ConsumableEffect // TypeDefIndex: 10148
{	// Fields
	public MetabolismAttribute.Type type; // 0x10
	public float amount; // 0x14
	public float time; // 0x18
	public float onlyIfHealthLessThan; // 0x1C

	// Methods

	// RVA: 0xA239D0 Offset: 0xA21FD0 VA: 0x180A239D0
	public void .ctor() { }

}

public class ItemModConsume : ItemMod // TypeDefIndex: 10149
{	// Fields
	public GameObjectRef consumeEffect; // 0x20
	public string eatGesture; // 0x28
	[TooltipAttribute] // RVA: 0xB9AE0 Offset: 0xB8EE0 VA: 0x1800B9AE0
	public ItemAmountRandom[] product; // 0x30
	public ItemModConsumable primaryConsumable; // 0x38

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA33330 Offset: 0xA31930 VA: 0x180A33330 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0xA33360 Offset: 0xA31960 VA: 0x180A33360
	public void .ctor() { }

}

public class ItemModConsumeChance : ItemModConsume // TypeDefIndex: 10150
{	// Fields
	public float chanceForSecondaryConsume; // 0x40
	public GameObjectRef secondaryConsumeEffect; // 0x48
	public ItemModConsumable secondaryConsumable; // 0x50

	// Methods

	// RVA: 0xA330B0 Offset: 0xA316B0 VA: 0x180A330B0
	public void .ctor() { }

}

public class ItemModConsumeContents : ItemMod // TypeDefIndex: 10151
{	// Fields
	public GameObjectRef consumeEffect; // 0x20

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA33100 Offset: 0xA31700 VA: 0x180A33100 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModContainer : ItemMod // TypeDefIndex: 10152
{	// Fields
	public int capacity; // 0x20
	public int maxStackSize; // 0x24
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ItemContainer.Flag containerFlags; // 0x28
	public ItemContainer.ContentsType onlyAllowedContents; // 0x2C
	public ItemDefinition onlyAllowedItemType; // 0x30
	public List<ItemSlot> availableSlots; // 0x38
	public ItemDefinition[] validItemWhitelist; // 0x40
	public bool openInDeployed; // 0x48
	public bool openInInventory; // 0x49
	public List<ItemAmount> defaultContents; // 0x50

	// Methods

	// RVA: 0xA334B0 Offset: 0xA31AB0 VA: 0x180A334B0 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0xA33440 Offset: 0xA31A40 VA: 0x180A33440 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0xA334F0 Offset: 0xA31AF0 VA: 0x180A334F0
	public void .ctor() { }

}

public class ItemModContainerRestriction : ItemMod // TypeDefIndex: 10153
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ItemModContainerRestriction.SlotFlags slotFlags; // 0x20

	// Methods

	// RVA: 0xA333B0 Offset: 0xA319B0 VA: 0x180A333B0
	public bool CanExistWith(ItemModContainerRestriction other) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public enum ItemModContainerRestriction.SlotFlags // TypeDefIndex: 10154
{	// Fields
	public int value__; // 0x0
	public const ItemModContainerRestriction.SlotFlags Map = 1;

}

public class ItemModCookable : ItemMod // TypeDefIndex: 10155
{	// Fields
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition becomeOnCooked; // 0x20
	public float cookTime; // 0x28
	public int amountOfBecome; // 0x2C
	public int lowTemp; // 0x30
	public int highTemp; // 0x34
	public bool setCookingFlag; // 0x38

	// Methods

	// RVA: 0xA335C0 Offset: 0xA31BC0 VA: 0x180A335C0
	public void OnValidate() { }

	// RVA: 0xA336A0 Offset: 0xA31CA0 VA: 0x180A336A0
	public void .ctor() { }

}

public class ItemModCycle : ItemMod // TypeDefIndex: 10156
{	// Fields
	public ItemMod[] actions; // 0x20
	public float timeBetweenCycles; // 0x28
	public float timerStart; // 0x2C
	public bool onlyAdvanceTimerWhenPass; // 0x30

	// Methods

	// RVA: 0xA337F0 Offset: 0xA31DF0 VA: 0x180A337F0
	private void OnValidate() { }

	// RVA: 0xA33870 Offset: 0xA31E70 VA: 0x180A33870
	public void .ctor() { }

}

public class ItemModDeployable : MonoBehaviour // TypeDefIndex: 10157
{	// Fields
	public GameObjectRef entityPrefab; // 0x18
	[HeaderAttribute] // RVA: 0xB9E20 Offset: 0xB9220 VA: 0x1800B9E20
	public bool showCrosshair; // 0x20
	public string UnlockAchievement; // 0x28

	// Methods

	// RVA: 0xA33880 Offset: 0xA31E80 VA: 0x180A33880
	public Deployable GetDeployable(BaseEntity entity) { }

	// RVA: 0xA33990 Offset: 0xA31F90 VA: 0x180A33990
	public void .ctor() { }

}

public class ItemModEntity : ItemMod // TypeDefIndex: 10158
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	public string defaultBone; // 0x28

	// Methods

	// RVA: 0xA33A00 Offset: 0xA32000 VA: 0x180A33A00
	public void .ctor() { }

}

public class ItemModEntityReference : MonoBehaviour // TypeDefIndex: 10159
{	// Fields
	public GameObjectRef entityPrefab; // 0x18

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModFishable : ItemMod // TypeDefIndex: 10160
{	// Fields
	public bool CanBeFished; // 0x20
	[HeaderAttribute] // RVA: 0xB9E50 Offset: 0xB9250 VA: 0x1800B9E50
	public float StrainModifier; // 0x24
	public float MoveMultiplier; // 0x28
	public float ReelInSpeedMultiplier; // 0x2C
	public float CatchWaitTimeMultiplier; // 0x30
	[HeaderAttribute] // RVA: 0xB9EF0 Offset: 0xB92F0 VA: 0x1800B9EF0
	public float MinimumBaitLevel; // 0x34
	public float MaximumBaitLevel; // 0x38
	public float MinimumWaterDepth; // 0x3C
	public float MaximumWaterDepth; // 0x40
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public WaterBody.FishingTag RequiredTag; // 0x44
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Chance; // 0x48
	public string SteamStatName; // 0x50

	// Methods

	// RVA: 0xA33A70 Offset: 0xA32070 VA: 0x180A33A70
	public void .ctor() { }

}

public class ItemModGiveOxygen : ItemMod, IAirSupply // TypeDefIndex: 10162
{	// Fields
	public ItemModGiveOxygen.AirSupplyType airType; // 0x20
	public int amountToConsume; // 0x24
	public GameObjectRef inhaleEffect; // 0x28
	public GameObjectRef exhaleEffect; // 0x30
	public GameObjectRef bubblesEffect; // 0x38
	private float timeRemaining; // 0x40
	private float cycleTime; // 0x44

	// Properties
	public ItemModGiveOxygen.AirSupplyType AirType { get; }

	// Methods

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760 Slot: 16
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x533DF0 Offset: 0x5323F0 VA: 0x180533DF0 Slot: 17
	public float GetAirTimeRemaining() { }

	// RVA: 0xA33AA0 Offset: 0xA320A0 VA: 0x180A33AA0 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA33BB0 Offset: 0xA321B0 VA: 0x180A33BB0 Slot: 5
	public override void OnChanged(Item item) { }

	// RVA: 0xA33C10 Offset: 0xA32210 VA: 0x180A33C10
	public void .ctor() { }

}

public enum ItemModGiveOxygen.AirSupplyType // TypeDefIndex: 10163
{	// Fields
	public int value__; // 0x0
	public const ItemModGiveOxygen.AirSupplyType Lungs = 0;
	public const ItemModGiveOxygen.AirSupplyType ScubaTank = 1;
	public const ItemModGiveOxygen.AirSupplyType Submarine = 2;

}

public class ItemModKeycard : ItemMod // TypeDefIndex: 10164
{	// Fields
	public int accessLevel; // 0x20

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModMenuOption : ItemMod // TypeDefIndex: 10165
{	// Fields
	public string commandName; // 0x20
	public ItemMod actionTarget; // 0x28
	public BaseEntity.Menu.Option option; // 0x30
	[TooltipAttribute] // RVA: 0xBB450 Offset: 0xBA850 VA: 0x1800BB450
	public bool isPrimaryOption; // 0x50

	// Methods

	// RVA: 0xA33D20 Offset: 0xA32320 VA: 0x180A33D20 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA33C30 Offset: 0xA32230 VA: 0x180A33C30 Slot: 7
	public override bool BeltSelect(Item item, BasePlayer player) { }

	// RVA: 0xA33E90 Offset: 0xA32490 VA: 0x180A33E90
	private void OnValidate() { }

	// RVA: 0xA34020 Offset: 0xA32620 VA: 0x180A34020
	public void .ctor() { }

}

public class ItemModPaintable : ItemModAssociatedEntity<PaintedItemStorageEntity> // TypeDefIndex: 10166
{	// Fields
	public GameObjectRef ChangeSignTextDialog; // 0x28
	public MeshPaintableSource[] PaintableSources; // 0x30
	private EntityRef<PaintedItemStorageEntity> _paintStorage; // 0x38

	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA34690 Offset: 0xA32C90 VA: 0x180A34690 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB7A0 Offset: 0xBABA0 VA: 0x1800BB7A0
	// RVA: 0xA34350 Offset: 0xA32950 VA: 0x180A34350
	private IEnumerator DeferredSetup(Item item, PaintableItem paintable) { }

	// RVA: 0xA343F0 Offset: 0xA329F0 VA: 0x180A343F0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA348E0 Offset: 0xA32EE0 VA: 0x180A348E0
	private void PaintClicked(BasePlayer player) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB900 Offset: 0xBAD00 VA: 0x1800BB900
	// RVA: 0xA34850 Offset: 0xA32E50 VA: 0x180A34850
	private IEnumerator OpenPaintUI(EntityRef<PaintedItemStorageEntity> paintStorage) { }

	// RVA: 0xA34990 Offset: 0xA32F90 VA: 0x180A34990
	public void .ctor() { }

}

private sealed class ItemModPaintable.<DeferredSetup>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10167
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Item item; // 0x20
	public PaintableItem paintable; // 0x28
	public ItemModPaintable <>4__this; // 0x30
	private int <count>5__2; // 0x38

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

	// RVA: 0xA39CA0 Offset: 0xA382A0 VA: 0x180A39CA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39E20 Offset: 0xA38420 VA: 0x180A39E20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemModPaintable.<>c__DisplayClass9_0 // TypeDefIndex: 10168
{	// Fields
	public PaintedItemStorageEntity entity; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3B900 Offset: 0xA39F00 VA: 0x180A3B900
	internal void <OpenPaintUI>b__0(int frame, Texture2D texture) { }

}

private sealed class ItemModPaintable.<OpenPaintUI>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10169
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public EntityRef<PaintedItemStorageEntity> paintStorage; // 0x20
	public ItemModPaintable <>4__this; // 0x30
	private int <i>5__2; // 0x38

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

	// RVA: 0xA39E70 Offset: 0xA38470 VA: 0x180A39E70 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3A160 Offset: 0xA38760 VA: 0x180A3A160 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ItemModPetStats : ItemMod // TypeDefIndex: 10170
{	// Fields
	[TooltipAttribute] // RVA: 0xBC280 Offset: 0xBB680 VA: 0x1800BC280
	public float SpeedModifier; // 0x20
	[TooltipAttribute] // RVA: 0xBC390 Offset: 0xBB790 VA: 0x1800BC390
	public float MaxHealthModifier; // 0x24
	[TooltipAttribute] // RVA: 0xBC560 Offset: 0xBB960 VA: 0x1800BC560
	public float AttackDamageModifier; // 0x28
	[TooltipAttribute] // RVA: 0xBC7D0 Offset: 0xBBBD0 VA: 0x1800BC7D0
	public float AttackRateModifier; // 0x2C

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModProjectile : MonoBehaviour // TypeDefIndex: 10171
{	// Fields
	public GameObjectRef projectileObject; // 0x18
	public ItemModProjectileMod[] mods; // 0x20
	public AmmoTypes ammoType; // 0x28
	public int numProjectiles; // 0x2C
	public float projectileSpread; // 0x30
	public float projectileVelocity; // 0x34
	public float projectileVelocitySpread; // 0x38
	public bool useCurve; // 0x3C
	public AnimationCurve spreadScalar; // 0x40
	public GameObjectRef attackEffectOverride; // 0x48
	public float barrelConditionLoss; // 0x50
	public string category; // 0x58

	// Methods

	// RVA: 0xA34BC0 Offset: 0xA331C0 VA: 0x180A34BC0
	public float GetRandomVelocity() { }

	// RVA: 0xA34C00 Offset: 0xA33200 VA: 0x180A34C00
	public float GetSpreadScalar() { }

	// RVA: 0xA34B30 Offset: 0xA33130 VA: 0x180A34B30
	public float GetIndexedSpreadScalar(int shotIndex, int maxShots) { }

	// RVA: 0xA34B20 Offset: 0xA33120 VA: 0x180A34B20
	public float GetAverageVelocity() { }

	// RVA: 0xA34BB0 Offset: 0xA331B0 VA: 0x180A34BB0
	public float GetMinVelocity() { }

	// RVA: 0xA34BA0 Offset: 0xA331A0 VA: 0x180A34BA0
	public float GetMaxVelocity() { }

	// RVA: 0xA34C60 Offset: 0xA33260 VA: 0x180A34C60
	public bool IsAmmo(AmmoTypes ammo) { }

	// RVA: 0xA34C70 Offset: 0xA33270 VA: 0x180A34C70 Slot: 4
	public virtual void ServerProjectileHit(HitInfo info) { }

	// RVA: 0xA34D40 Offset: 0xA33340 VA: 0x180A34D40
	public void .ctor() { }

}

public class ItemModProjectileMod : MonoBehaviour // TypeDefIndex: 10172
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 4
	public virtual void ServerProjectileHit(HitInfo info) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModProjectileRadialDamage : ItemModProjectileMod // TypeDefIndex: 10173
{	// Fields
	public float radius; // 0x18
	public DamageTypeEntry damage; // 0x20
	public GameObjectRef effect; // 0x28
	public bool ignoreHitObject; // 0x30

	// Methods

	// RVA: 0xA34A10 Offset: 0xA33010 VA: 0x180A34A10
	public void .ctor() { }

}

public class ItemModProjectileSpawn : ItemModProjectile // TypeDefIndex: 10174
{	// Fields
	public float createOnImpactChance; // 0x60
	public GameObjectRef createOnImpact; // 0x68
	public float spreadAngle; // 0x70
	public float spreadVelocityMin; // 0x74
	public float spreadVelocityMax; // 0x78
	public int numToCreateChances; // 0x7C

	// Methods

	// RVA: 0xA34A30 Offset: 0xA33030 VA: 0x180A34A30
	public void .ctor() { }

}

public class ItemModRecycleInto : ItemMod // TypeDefIndex: 10175
{	// Fields
	public ItemDefinition recycleIntoItem; // 0x20
	public int numRecycledItemMin; // 0x28
	public int numRecycledItemMax; // 0x2C
	public GameObjectRef successEffect; // 0x30

	// Methods

	// RVA: 0xA35440 Offset: 0xA33A40 VA: 0x180A35440 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35550 Offset: 0xA33B50 VA: 0x180A35550
	public void .ctor() { }

}

public class ItemModRepair : ItemMod // TypeDefIndex: 10176
{	// Fields
	public float conditionLost; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int workbenchLvlRequired; // 0x30

	// Methods

	// RVA: 0xA357C0 Offset: 0xA33DC0 VA: 0x180A357C0
	public bool HasCraftLevel(BasePlayer player) { }

	// RVA: 0xA35570 Offset: 0xA33B70 VA: 0x180A35570 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA358D0 Offset: 0xA33ED0 VA: 0x180A358D0
	public void .ctor() { }

}

public class ItemModReveal : ItemMod // TypeDefIndex: 10177
{	// Fields
	public int numForReveal; // 0x20
	public ItemDefinition revealedItemOverride; // 0x28
	public int revealedItemAmount; // 0x30
	public LootSpawn revealList; // 0x38
	public GameObjectRef successEffect; // 0x40

	// Methods

	// RVA: 0xA358E0 Offset: 0xA33EE0 VA: 0x180A358E0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35A20 Offset: 0xA34020 VA: 0x180A35A20
	public void .ctor() { }

}

public class ItemModSound : ItemMod // TypeDefIndex: 10178
{	// Fields
	public GameObjectRef effect; // 0x20
	public ItemModSound.Type actionType; // 0x28

	// Methods

	// RVA: 0xA35A80 Offset: 0xA34080 VA: 0x180A35A80
	public void .ctor() { }

}

public enum ItemModSound.Type // TypeDefIndex: 10179
{	// Fields
	public int value__; // 0x0
	public const ItemModSound.Type OnAttachToWeapon = 0;

}

public class ItemModStudyBlueprint : ItemMod // TypeDefIndex: 10180
{	// Fields
	public GameObjectRef studyEffect; // 0x20

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModSummerSunglassesEquip : ItemMod // TypeDefIndex: 10181
{	// Fields
	public float SunsetTime; // 0x20
	public float SunriseTime; // 0x24
	public string AchivementName; // 0x28

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModSwap : ItemMod // TypeDefIndex: 10182
{	// Fields
	public GameObjectRef actionEffect; // 0x20
	public ItemAmount[] becomeItem; // 0x28
	public bool sendPlayerPickupNotification; // 0x30
	public bool sendPlayerDropNotification; // 0x31
	public float xpScale; // 0x34
	public ItemAmount[] RandomOptions; // 0x38

	// Methods

	// RVA: 0xA35AF0 Offset: 0xA340F0 VA: 0x180A35AF0
	public void .ctor() { }

}

public class ItemModSwitchFlag : ItemMod // TypeDefIndex: 10183
{	// Fields
	public Item.Flag flag; // 0x20
	public bool state; // 0x24

	// Methods

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModUpgrade : ItemMod // TypeDefIndex: 10184
{	// Fields
	public int numForUpgrade; // 0x20
	public float upgradeSuccessChance; // 0x24
	public int numToLoseOnFail; // 0x28
	public ItemDefinition upgradedItem; // 0x30
	public int numUpgradedItem; // 0x38
	public GameObjectRef successEffect; // 0x40
	public GameObjectRef failEffect; // 0x48

	// Methods

	// RVA: 0xA35C10 Offset: 0xA34210 VA: 0x180A35C10 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35D50 Offset: 0xA34350 VA: 0x180A35D50
	public void .ctor() { }

}

public class ItemModUseContent : ItemMod // TypeDefIndex: 10185
{	// Fields
	public int amountToConsume; // 0x20

	// Methods

	// RVA: 0x7A2650 Offset: 0x7A0C50 VA: 0x1807A2650
	public void .ctor() { }

}

public class ItemModWearable : ItemMod // TypeDefIndex: 10186
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	public GameObjectRef entityPrefabFemale; // 0x28
	public ProtectionProperties protectionProperties; // 0x30
	public ArmorProperties armorProperties; // 0x38
	public ClothingMovementProperties movementProperties; // 0x40
	public UIBlackoutOverlay.blackoutType occlusionType; // 0x48
	public bool blocksAiming; // 0x4C
	public bool emissive; // 0x4D
	public float accuracyBonus; // 0x50
	public bool blocksEquipping; // 0x54
	public float eggVision; // 0x58
	public float weight; // 0x5C
	public bool equipOnRightClick; // 0x60
	public bool npcOnly; // 0x61
	public GameObjectRef breakEffect; // 0x68
	public GameObjectRef viewmodelAddition; // 0x70

	// Properties
	public Wearable targetWearable { get; }

	// Methods

	// RVA: 0xA36DF0 Offset: 0xA353F0 VA: 0x180A36DF0
	public Wearable get_targetWearable() { }

	// RVA: 0xA35F50 Offset: 0xA34550 VA: 0x180A35F50
	private void DoPrepare() { }

	// RVA: 0xA36370 Offset: 0xA34970 VA: 0x180A36370 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA36C90 Offset: 0xA35290 VA: 0x180A36C90
	public bool ProtectsArea(HitArea area) { }

	// RVA: 0xA361C0 Offset: 0xA347C0 VA: 0x180A361C0
	public bool HasProtections() { }

	// RVA: 0xA360D0 Offset: 0xA346D0 VA: 0x180A360D0
	internal float GetProtection(Item item, DamageType damageType) { }

	// RVA: 0xA35F00 Offset: 0xA34500 VA: 0x180A35F00
	public float ConditionProtectionScale(Item item) { }

	// RVA: 0xA35E30 Offset: 0xA34430 VA: 0x180A35E30
	public void CollectProtection(Item item, ProtectionProperties protection) { }

	// RVA: 0xA362D0 Offset: 0xA348D0 VA: 0x180A362D0
	private bool IsHeadgear() { }

	// RVA: 0xA36220 Offset: 0xA34820 VA: 0x180A36220
	public bool IsFootwear() { }

	// RVA: 0xA36420 Offset: 0xA34A20 VA: 0x180A36420
	public void OnDressModel(Item item, PlayerModel model) { }

	// RVA: 0xA36A80 Offset: 0xA35080 VA: 0x180A36A80 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	// RVA: 0xA35D80 Offset: 0xA34380 VA: 0x180A35D80
	public bool CanExistWith(ItemModWearable wearable) { }

	// RVA: 0xA36D30 Offset: 0xA35330 VA: 0x180A36D30
	public void .ctor() { }

}

private sealed class ItemModWearable.<>c__DisplayClass28_0 // TypeDefIndex: 10187
{	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7F0610 Offset: 0x7EEC10 VA: 0x1807F0610
	internal bool <OnObjectSetup>b__0(ItemSkinDirectory.Skin x) { }

}

public class ItemModXPWhenUsed : ItemMod // TypeDefIndex: 10188
{	// Fields
	public float xpPerUnit; // 0x20
	public int unitSize; // 0x24

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void GiveConsumeXP(Item item) { }

	// RVA: 0x4BE580 Offset: 0x4BCB80 VA: 0x1804BE580
	public void .ctor() { }

}

public class ItemFootstepSounds : MonoBehaviour // TypeDefIndex: 10189
{	// Fields
	public string effectFolder; // 0x18

	// Methods

	// RVA: 0xA2B740 Offset: 0xA29D40 VA: 0x180A2B740
	public void .ctor() { }

}

public class ItemAmount : ISerializationCallbackReceiver // TypeDefIndex: 10190
{	// Fields
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemDef; // 0x10
	public float amount; // 0x18
	public float startAmount; // 0x1C

	// Properties
	public int itemid { get; }

	// Methods

	// RVA: 0xA26790 Offset: 0xA24D90 VA: 0x180A26790
	public void .ctor(ItemDefinition item, float amt = 0) { }

	// RVA: 0xA267E0 Offset: 0xA24DE0 VA: 0x180A267E0
	public int get_itemid() { }

	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710 Slot: 6
	public virtual float GetAmount() { }

	// RVA: 0xA26520 Offset: 0xA24B20 VA: 0x180A26520 Slot: 7
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void OnBeforeSerialize() { }

	// RVA: 0xA26530 Offset: 0xA24B30 VA: 0x180A26530
	public static ItemAmountList SerialiseList(List<ItemAmount> list) { }

	// RVA: 0xA26340 Offset: 0xA24940 VA: 0x180A26340
	public static void DeserialiseList(List<ItemAmount> target, ItemAmountList source) { }

}

public class ItemAmountRandom // TypeDefIndex: 10191
{	// Fields
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemDef; // 0x10
	public AnimationCurve amount; // 0x18

	// Methods

	// RVA: 0xA260B0 Offset: 0xA246B0 VA: 0x180A260B0
	public int RandomAmount() { }

	// RVA: 0xA26140 Offset: 0xA24740 VA: 0x180A26140
	public void .ctor() { }

}

public class ItemAmountRanged : ItemAmount // TypeDefIndex: 10192
{	// Fields
	public float maxAmount; // 0x20

	// Methods

	// RVA: 0xA262C0 Offset: 0xA248C0 VA: 0x180A262C0 Slot: 7
	public override void OnAfterDeserialize() { }

	// RVA: 0xA262D0 Offset: 0xA248D0 VA: 0x180A262D0
	public void .ctor(ItemDefinition item, float amt = 0, float max = -1) { }

	// RVA: 0xA26290 Offset: 0xA24890 VA: 0x180A26290 Slot: 6
	public override float GetAmount() { }

}

public class ItemManager // TypeDefIndex: 10193
{	// Fields
	public static List<ItemDefinition> itemList; // 0x0
	public static Dictionary<int, ItemDefinition> itemDictionary; // 0x8
	public static Dictionary<string, ItemDefinition> itemDictionaryByName; // 0x10
	public static List<ItemBlueprint> bpList; // 0x18
	public static int[] defaultBlueprints; // 0x20
	public static ItemDefinition blueprintBaseDef; // 0x28

	// Methods

	// RVA: 0xA321A0 Offset: 0xA307A0 VA: 0x180A321A0
	public static void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA311F0 Offset: 0xA2F7F0 VA: 0x180A311F0
	public static void Initialize() { }

	// RVA: 0x51B5E0 Offset: 0x519BE0 VA: 0x18051B5E0
	public static void UpdateUnlockedSkins() { }

	// RVA: 0xA322C0 Offset: 0xA308C0 VA: 0x180A322C0
	public static Item Load(Item load, Item created, bool isServer) { }

	// RVA: 0xA31070 Offset: 0xA2F670 VA: 0x180A31070
	public static ItemDefinition FindItemDefinition(int itemID) { }

	// RVA: 0xA310F0 Offset: 0xA2F6F0 VA: 0x180A310F0
	public static ItemDefinition FindItemDefinition(string shortName) { }

	// RVA: 0xA31020 Offset: 0xA2F620 VA: 0x180A31020
	public static ItemBlueprint FindBlueprint(ItemDefinition item) { }

	// RVA: 0xA311B0 Offset: 0xA2F7B0 VA: 0x180A311B0
	public static List<ItemDefinition> GetItemDefinitions() { }

	// RVA: 0xA31170 Offset: 0xA2F770 VA: 0x180A31170
	public static List<ItemBlueprint> GetBlueprints() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class ItemManager.<>c // TypeDefIndex: 10194
{	// Fields
	public static readonly ItemManager.<>c <>9; // 0x0
	public static Func<GameObject, ItemDefinition> <>9__7_0; // 0x8
	public static Func<ItemDefinition, bool> <>9__7_1; // 0x10
	public static Func<GameObject, ItemBlueprint> <>9__7_2; // 0x18
	public static Func<ItemBlueprint, bool> <>9__7_3; // 0x20
	public static Func<ItemBlueprint, bool> <>9__7_4; // 0x28
	public static Func<ItemBlueprint, int> <>9__7_5; // 0x30

	// Methods

	// RVA: 0xA3BA50 Offset: 0xA3A050 VA: 0x180A3BA50
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3A4B0 Offset: 0xA38AB0 VA: 0x180A3A4B0
	internal ItemDefinition <Initialize>b__7_0(GameObject x) { }

	// RVA: 0xA3A500 Offset: 0xA38B00 VA: 0x180A3A500
	internal bool <Initialize>b__7_1(ItemDefinition x) { }

	// RVA: 0xA3A560 Offset: 0xA38B60 VA: 0x180A3A560
	internal ItemBlueprint <Initialize>b__7_2(GameObject x) { }

	// RVA: 0xA3A5B0 Offset: 0xA38BB0 VA: 0x180A3A5B0
	internal bool <Initialize>b__7_3(ItemBlueprint x) { }

	// RVA: 0xA3A620 Offset: 0xA38C20 VA: 0x180A3A620
	internal bool <Initialize>b__7_4(ItemBlueprint x) { }

	// RVA: 0xA3A6E0 Offset: 0xA38CE0 VA: 0x180A3A6E0
	internal int <Initialize>b__7_5(ItemBlueprint x) { }

}

public class ItemSkin : SteamInventoryItem // TypeDefIndex: 10738
{	// Fields
	public Skinnable Skinnable; // 0x70
	public Material[] Materials; // 0x78
	[TooltipAttribute] // RVA: 0x77230 Offset: 0x76630 VA: 0x180077230
	public ItemDefinition Redirect; // 0x80
	public SteamInventoryItem UnlockedViaSteamItem; // 0x88

	// Methods

	// RVA: 0x678FE0 Offset: 0x6775E0 VA: 0x180678FE0
	public void ApplySkin(GameObject obj) { }

	// RVA: 0x679070 Offset: 0x677670 VA: 0x180679070 Slot: 4
	public override bool HasUnlocked(ulong playerId) { }

	// RVA: 0x679450 Offset: 0x677A50 VA: 0x180679450
	public void .ctor() { }

}

public class ItemSkinDirectory : ScriptableObject // TypeDefIndex: 10739
{	// Fields
	private static ItemSkinDirectory _Instance; // 0x0
	public ItemSkinDirectory.Skin[] skins; // 0x18

	// Properties
	public static ItemSkinDirectory Instance { get; }

	// Methods

	// RVA: 0x678E40 Offset: 0x677440 VA: 0x180678E40
	public static ItemSkinDirectory get_Instance() { }

	// RVA: 0x678D70 Offset: 0x677370 VA: 0x180678D70
	public static ItemSkinDirectory.Skin[] ForItem(ItemDefinition item) { }

	// RVA: 0x678C80 Offset: 0x677280 VA: 0x180678C80
	public static ItemSkinDirectory.Skin FindByInventoryDefinitionId(int id) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

public struct ItemSkinDirectory.Skin // TypeDefIndex: 10740
{	// Fields
	public int id; // 0x0
	public int itemid; // 0x4
	public string name; // 0x8
	public bool isSkin; // 0x10
	private SteamInventoryItem _invItem; // 0x18

	// Properties
	public SteamInventoryItem invItem { get; }

	// Methods

	// RVA: 0xF38C0 Offset: 0xF2CC0 VA: 0x1800F38C0
	public SteamInventoryItem get_invItem() { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass5_0 // TypeDefIndex: 10741
{	// Fields
	public ItemDefinition item; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690F90 Offset: 0x68F590 VA: 0x180690F90
	internal bool <ForItem>b__0(ItemSkinDirectory.Skin x) { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass6_0 // TypeDefIndex: 10742
{	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3B30 Offset: 0x4B2130 VA: 0x1804B3B30
	internal bool <FindByInventoryDefinitionId>b__0(ItemSkinDirectory.Skin x) { }

}

public abstract class ItemContainerSource : MonoBehaviour // TypeDefIndex: 10852
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ItemContainer GetItemContainer();

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

public class ItemDropCommand : MonoBehaviour // TypeDefIndex: 11008
{	// Fields
	public string command; // 0x18

	// Methods

	// RVA: 0xA2B400 Offset: 0xA29A00 VA: 0x180A2B400
	private void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA2B600 Offset: 0xA29C00 VA: 0x180A2B600
	public void .ctor() { }

}

public class ItemIcon : BaseMonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IDraggable, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11009
{	// Fields
	public static Color defaultBackgroundColor; // 0x0
	public static Color selectedBackgroundColor; // 0x10
	public ItemContainerSource containerSource; // 0x18
	public int slotOffset; // 0x20
	[RangeAttribute] // RVA: 0x8E980 Offset: 0x8DD80 VA: 0x18008E980
	public int slot; // 0x24
	public bool setSlotFromSiblingIndex; // 0x28
	public GameObject slots; // 0x30
	public CanvasGroup iconContents; // 0x38
	public Image iconImage; // 0x40
	public Image underlayImage; // 0x48
	public Text amountText; // 0x50
	public Text hoverText; // 0x58
	public Image hoverOutline; // 0x60
	public Image cornerIcon; // 0x68
	public Image lockedImage; // 0x70
	public Image progressImage; // 0x78
	public Image backgroundImage; // 0x80
	public Image backgroundUnderlayImage; // 0x88
	public Sprite emptySlotBackgroundSprite; // 0x90
	public CanvasGroup conditionObject; // 0x98
	public Image conditionFill; // 0xA0
	public Image maxConditionFill; // 0xA8
	public bool allowSelection; // 0xB0
	public bool allowDropping; // 0xB1
	public bool allowMove; // 0xB2
	public Item item; // 0xB8
	public bool invalidSlot; // 0xC0
	public SoundDefinition hoverSound; // 0xC8
	internal Image[] slotImages; // 0xD0
	private static Dictionary<uint, float> containerLootStartTimes; // 0x20
	private bool queuedForLooting; // 0xD8
	private const float processLootQueueInterval = 0,2;
	private const float lootItemDuration = 0,2;
	private uint queuedQuickLootContainerID; // 0xDC
	private float queuedLootAtTime; // 0xE0
	private bool visible; // 0xE4
	private bool hovering; // 0xE5
	private CanvasGroup canvasGroupParent; // 0xE8
	private Coroutine currentCouroutine; // 0xF0
	public Action timedAction; // 0xF8
	public Nullable<Vector2> timedActionTime; // 0x100

	// Properties
	private Item iconValue { get; }

	// Methods

	// RVA: 0xA2B790 Offset: 0xA29D90 VA: 0x180A2B790
	protected void Awake() { }

	// RVA: 0xA2CFB0 Offset: 0xA2B5B0 VA: 0x180A2CFB0
	protected void OnEnable() { }

	// RVA: 0xA2B9C0 Offset: 0xA29FC0 VA: 0x180A2B9C0
	public static void ClearLootTimers() { }

	// RVA: 0xA2BAA0 Offset: 0xA2A0A0 VA: 0x180A2BAA0
	public void ClearProgressImage() { }

	// RVA: 0xA2CA00 Offset: 0xA2B000 VA: 0x180A2CA00
	protected void OnDisable() { }

	// RVA: 0xA2E0B0 Offset: 0xA2C6B0 VA: 0x180A2E0B0
	public void OnShow() { }

	// RVA: 0xA2D1D0 Offset: 0xA2B7D0 VA: 0x180A2D1D0
	public void OnHide() { }

	// RVA: 0xA2BA80 Offset: 0xA2A080 VA: 0x180A2BA80
	public void ClearLooting() { }

	// RVA: 0xA2FC70 Offset: 0xA2E270 VA: 0x180A2FC70
	private void Update() { }

	// RVA: 0xA2C370 Offset: 0xA2A970 VA: 0x180A2C370
	public Sprite GetItemSprite(out Color tint) { }

	// RVA: 0xA2D9E0 Offset: 0xA2BFE0 VA: 0x180A2D9E0 Slot: 13
	public void OnItemAmountChanged() { }

	// RVA: 0xA2DA20 Offset: 0xA2C020 VA: 0x180A2DA20 Slot: 14
	public void OnItemIconChanged() { }

	// RVA: 0xA2D270 Offset: 0xA2B870 VA: 0x180A2D270 Slot: 12
	public void OnInventoryChanged() { }

	// RVA: 0xA2F7B0 Offset: 0xA2DDB0 VA: 0x180A2F7B0
	private void UpdateHoverText() { }

	// RVA: 0xA2F970 Offset: 0xA2DF70 VA: 0x180A2F970
	private void UpdateItemIcon() { }

	// RVA: 0xA2E380 Offset: 0xA2C980 VA: 0x180A2E380
	private void SetBackgroundUnderlayVisible(bool flag) { }

	// RVA: 0xA2F6A0 Offset: 0xA2DCA0 VA: 0x180A2F6A0
	private void UpdateCornerIcon() { }

	// RVA: 0xA2F9B0 Offset: 0xA2DFB0 VA: 0x180A2F9B0
	private void UpdateSlots() { }

	// RVA: 0xA2FE40 Offset: 0xA2E440 VA: 0x180A2FE40
	private Item get_iconValue() { }

	// RVA: 0xA2E2A0 Offset: 0xA2C8A0 VA: 0x180A2E2A0
	public void Select() { }

	// RVA: 0xA2E290 Offset: 0xA2C890 VA: 0x180A2E290
	public void SelectSilent() { }

	// RVA: 0xA2C8B0 Offset: 0xA2AEB0 VA: 0x180A2C8B0
	private void InternalSelect(bool silent = False) { }

	// RVA: 0xA2BDA0 Offset: 0xA2A3A0 VA: 0x180A2BDA0
	public void Deselect() { }

	// RVA: 0xA2E2B0 Offset: 0xA2C8B0 VA: 0x180A2E2B0
	public void SetActive(bool active) { }

	// RVA: 0xA2CB90 Offset: 0xA2B190 VA: 0x180A2CB90 Slot: 15
	public virtual void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA2E830 Offset: 0xA2CE30 VA: 0x180A2E830
	private bool TryToDropInsideItem(ItemIcon.DragInfo dropInfo, Item item) { }

	// RVA: 0xA2E4E0 Offset: 0xA2CAE0 VA: 0x180A2E4E0
	public void SetTimedLootAction(uint sourceContainer, Action action) { }

	// RVA: 0xA2B860 Offset: 0xA29E60 VA: 0x180A2B860
	private float CalculateLootDelay(uint sourceContainer) { }

	[IteratorStateMachineAttribute] // RVA: 0x8EAE0 Offset: 0x8DEE0 VA: 0x18008EAE0
	// RVA: 0xA2E7B0 Offset: 0xA2CDB0 VA: 0x180A2E7B0
	private IEnumerator StartTimedLootAction(float delay) { }

	// RVA: 0xA2E260 Offset: 0xA2C860 VA: 0x180A2E260
	public void RunTimedAction() { }

	// RVA: 0xA2BB70 Offset: 0xA2A170 VA: 0x180A2BB70
	public void ClearTimedAction() { }

	// RVA: 0xA2E0C0 Offset: 0xA2C6C0 VA: 0x180A2E0C0
	private void RemoveFromLootQueue() { }

	[IteratorStateMachineAttribute] // RVA: 0x8EBE0 Offset: 0x8DFE0 VA: 0x18008EBE0
	// RVA: 0xA2FC00 Offset: 0xA2E200 VA: 0x180A2FC00
	private IEnumerator UpdateTimedActionIcon() { }

	// RVA: 0xA2F100 Offset: 0xA2D700 VA: 0x180A2F100
	private void TryToQuickMove() { }

	// RVA: 0xA2E9B0 Offset: 0xA2CFB0 VA: 0x180A2E9B0 Slot: 16
	public virtual void TryToMove() { }

	// RVA: 0xA2BE30 Offset: 0xA2A430 VA: 0x180A2BE30
	public void EquipAsClothingItem() { }

	// RVA: 0xA2DB30 Offset: 0xA2C130 VA: 0x180A2DB30 Slot: 17
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xA2DC10 Offset: 0xA2C210 VA: 0x180A2DC10 Slot: 7
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA2DFE0 Offset: 0xA2C5E0 VA: 0x180A2DFE0 Slot: 8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA2C010 Offset: 0xA2A610 VA: 0x180A2C010 Slot: 9
	public object GetDragData() { }

	// RVA: 0xA2C340 Offset: 0xA2A940 VA: 0x180A2C340 Slot: 10
	public string GetDragType() { }

	// RVA: 0xA2C310 Offset: 0xA2A910 VA: 0x180A2C310 Slot: 11
	public Sprite GetDragSprite() { }

	// RVA: 0xA2FE20 Offset: 0xA2E420 VA: 0x180A2FE20
	public void .ctor() { }

	// RVA: 0xA2FD10 Offset: 0xA2E310 VA: 0x180A2FD10
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2F320 Offset: 0xA2D920 VA: 0x180A2F320
	private void <EquipAsClothingItem>b__78_0() { }

}

public class ItemIcon.DragInfo // TypeDefIndex: 11010
{	// Fields
	public Item item; // 0x10
	public int amount; // 0x18
	public bool canDrop; // 0x1C

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private sealed class ItemIcon.<StartTimedLootAction>d__71 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11011
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemIcon <>4__this; // 0x20
	public float delay; // 0x28

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

	// RVA: 0xA3A1B0 Offset: 0xA387B0 VA: 0x180A3A1B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3A430 Offset: 0xA38A30 VA: 0x180A3A430 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<UpdateTimedActionIcon>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11012
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ItemIcon <>4__this; // 0x20

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

	// RVA: 0xA3BAB0 Offset: 0xA3A0B0 VA: 0x180A3BAB0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3BC90 Offset: 0xA3A290 VA: 0x180A3BC90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemIcon.<>c__DisplayClass77_0 // TypeDefIndex: 11013
{	// Fields
	public ItemIcon <>4__this; // 0x10
	public PlayerLoot loot; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3AB00 Offset: 0xA39100 VA: 0x180A3AB00
	internal void <TryToMove>b__0() { }

	// RVA: 0xA3AE70 Offset: 0xA39470 VA: 0x180A3AE70
	internal void <TryToMove>b__1() { }

	// RVA: 0xA3B1A0 Offset: 0xA397A0 VA: 0x180A3B1A0
	internal void <TryToMove>b__2() { }

	// RVA: 0xA3B590 Offset: 0xA39B90 VA: 0x180A3B590
	internal void <TryToMove>b__3() { }

}

public class ItemInformationPanel : MonoBehaviour // TypeDefIndex: 11014
{	// Methods

	// RVA: 0xA2FF00 Offset: 0xA2E500 VA: 0x180A2FF00 Slot: 4
	public virtual bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xA2FF60 Offset: 0xA2E560 VA: 0x180A2FF60 Slot: 5
	public virtual void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemOptionButton : MonoBehaviour // TypeDefIndex: 11015
{	// Fields
	public TextMeshProUGUI name; // 0x18
	public Image icon; // 0x20
	internal Item item; // 0x28
	internal Option option; // 0x30

	// Methods

	// RVA: 0x6772E0 Offset: 0x6758E0 VA: 0x1806772E0
	public void Setup(Item item, Option option) { }

	// RVA: 0x6771C0 Offset: 0x6757C0 VA: 0x1806771C0
	public void Pressed() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemPanel : SingletonComponent<ItemPanel> // TypeDefIndex: 11016
{	// Fields
	private ItemIcon item; // 0x18

	// Methods

	// RVA: 0x6778B0 Offset: 0x675EB0 VA: 0x1806778B0
	private void Start() { }

	// RVA: 0x6778C0 Offset: 0x675EC0 VA: 0x1806778C0
	public void Update() { }

	// RVA: 0x677550 Offset: 0x675B50 VA: 0x180677550
	private void OnChanged() { }

	// RVA: 0x677980 Offset: 0x675F80 VA: 0x180677980
	public void .ctor() { }

}

public class ItemPickupNotice : MonoBehaviour // TypeDefIndex: 11017
{	// Fields
	public TextMeshProUGUI Text; // 0x18
	public TextMeshProUGUI Amount; // 0x20
	private TimeSince enabledTime; // 0x28
	private RectTransform targetRect; // 0x30
	private CanvasGroup targetCanvas; // 0x38
	private ItemDefinition def; // 0x40
	private bool isReuse; // 0x48
	private int cachedAmount; // 0x4C
	private const float pickupNoticeTime = 4;
	private int scheduledTotal; // 0x50

	// Properties
	public ItemDefinition itemInfo { get; set; }
	public int amount { get; set; }

	// Methods

	// RVA: 0x678100 Offset: 0x676700 VA: 0x180678100
	public void set_itemInfo(ItemDefinition value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public ItemDefinition get_itemInfo() { }

	// RVA: 0x678080 Offset: 0x676680 VA: 0x180678080
	public void set_amount(int value) { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	public int get_amount() { }

	// RVA: 0x677A10 Offset: 0x676010 VA: 0x180677A10
	public void AppendTotal(int amount) { }

	// RVA: 0x677AD0 Offset: 0x6760D0 VA: 0x180677AD0
	public void OnEnable() { }

	// RVA: 0x677AA0 Offset: 0x6760A0 VA: 0x180677AA0
	public void BlockLayoutUpdates() { }

	// RVA: 0x6779E0 Offset: 0x675FE0 VA: 0x1806779E0
	public void AllowLayoutUpdates() { }

	// RVA: 0x677C60 Offset: 0x676260 VA: 0x180677C60
	public bool ProcessAnimation(AnimationCurve sizeCurve, AnimationCurve alphaCurve, AnimationCurve reuseSizeCurve, AnimationCurve reuseAlphaCurve) { }

	// RVA: 0x677BD0 Offset: 0x6761D0 VA: 0x180677BD0
	public void PopupNoticeEnd() { }

	// RVA: 0x678020 Offset: 0x676620 VA: 0x180678020
	public void UpdateItemCount(int amountAdded, int totalAmount) { }

	// RVA: 0x677F60 Offset: 0x676560 VA: 0x180677F60
	public void ScheduleTotalUpdate(int currentTotal) { }

	// RVA: 0x677EB0 Offset: 0x6764B0 VA: 0x180677EB0
	private void ProcessTotalUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemPreviewIcon : BaseMonoBehaviour, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11018
{	// Fields
	public ItemContainerSource containerSource; // 0x18
	[RangeAttribute] // RVA: 0x8E980 Offset: 0x8DD80 VA: 0x18008E980
	public int slot; // 0x20
	public bool setSlotFromSiblingIndex; // 0x24
	public CanvasGroup iconContents; // 0x28
	public Image iconImage; // 0x30
	public Text amountText; // 0x38
	public Item item; // 0x40
	private bool invalidSlot; // 0x48

	// Properties
	private Item iconValue { get; }

	// Methods

	// RVA: 0x6785B0 Offset: 0x676BB0 VA: 0x1806785B0
	protected void OnEnable() { }

	// RVA: 0x6784B0 Offset: 0x676AB0 VA: 0x1806784B0
	protected void OnDisable() { }

	// RVA: 0x678190 Offset: 0x676790 VA: 0x180678190
	public Sprite GetItemSprite() { }

	// RVA: 0x678830 Offset: 0x676E30 VA: 0x180678830 Slot: 7
	public void OnItemAmountChanged() { }

	// RVA: 0x678850 Offset: 0x676E50 VA: 0x180678850 Slot: 8
	public void OnItemIconChanged() { }

	// RVA: 0x6786E0 Offset: 0x676CE0 VA: 0x1806786E0 Slot: 6
	public void OnInventoryChanged() { }

	// RVA: 0x678920 Offset: 0x676F20 VA: 0x180678920
	private void UpdateItemIcon() { }

	// RVA: 0x678970 Offset: 0x676F70 VA: 0x180678970
	private Item get_iconValue() { }

	// RVA: 0x678960 Offset: 0x676F60 VA: 0x180678960
	public void .ctor() { }

}

public class ItemSplitter : MonoBehaviour // TypeDefIndex: 11019
{	// Fields
	public Slider slider; // 0x18
	public TextMeshProUGUI textValue; // 0x20
	public TextMeshProUGUI splitAmountText; // 0x28
	public TMP_InputField amountInputField; // 0x30
	private static bool isInputFieldOpen; // 0x0
	private float oldAmount; // 0x38

	// Properties
	public ItemIcon.DragInfo dragInfo { get; }

	// Methods

	// RVA: 0x679820 Offset: 0x677E20 VA: 0x180679820
	public static bool IsInputFieldOpen() { }

	// RVA: 0x679DB0 Offset: 0x6783B0 VA: 0x180679DB0
	private void Start() { }

	// RVA: 0x679FC0 Offset: 0x6785C0 VA: 0x180679FC0
	public ItemIcon.DragInfo get_dragInfo() { }

	// RVA: 0x679B90 Offset: 0x678190 VA: 0x180679B90
	public void RefreshValue() { }

	// RVA: 0x679EA0 Offset: 0x6784A0 VA: 0x180679EA0
	public void Update() { }

	// RVA: 0x679760 Offset: 0x677D60 VA: 0x180679760
	private string FormatValueString(float value) { }

	// RVA: 0x679880 Offset: 0x677E80 VA: 0x180679880
	private void OnAmountInputFieldValueChanged() { }

	// RVA: 0x6799F0 Offset: 0x677FF0 VA: 0x1806799F0
	public void OnSliderLeftMouseDown() { }

	// RVA: 0x679B20 Offset: 0x678120 VA: 0x180679B20
	public void OnSliderRightMouseUp() { }

	// RVA: 0x679A00 Offset: 0x678000 VA: 0x180679A00
	public void OnSliderMiddleMouseDown() { }

	// RVA: 0x679C30 Offset: 0x678230 VA: 0x180679C30
	private void SetAmountInputFieldVisible(bool flag) { }

	// RVA: 0x6797A0 Offset: 0x677DA0 VA: 0x1806797A0
	public static int GetSplitAmount(int itemAmount) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x679880 Offset: 0x677E80 VA: 0x180679880
	private void <Start>b__6_0(string <p0>) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6799F0 Offset: 0x677FF0 VA: 0x1806799F0
	private void <Start>b__6_1(string <p0>) { }

}

public class ItemSplitterDragOut : MonoBehaviour, IDraggable // TypeDefIndex: 11020
{	// Fields
	public ItemSplitter rootSplitter; // 0x18

	// Methods

	// RVA: 0x679460 Offset: 0x677A60 VA: 0x180679460 Slot: 4
	public object GetDragData() { }

	// RVA: 0x679540 Offset: 0x677B40 VA: 0x180679540 Slot: 5
	public string GetDragType() { }

	// RVA: 0x679500 Offset: 0x677B00 VA: 0x180679500 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemSplitterSlider : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler // TypeDefIndex: 11021
{	// Fields
	public ItemSplitter Splitter; // 0x18

	// Methods

	// RVA: 0x679570 Offset: 0x677B70 VA: 0x180679570 Slot: 5
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x6796D0 Offset: 0x677CD0 VA: 0x1806796D0 Slot: 4
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemStatValue : MonoBehaviour // TypeDefIndex: 11022
{	// Fields
	public Text text; // 0x18
	public Slider slider; // 0x20
	public bool selectedItem; // 0x28
	public bool smallerIsBetter; // 0x29
	public bool asPercentage; // 0x2A

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void OnEnable() { }

	// RVA: 0x67A060 Offset: 0x678660 VA: 0x18067A060
	private void OnDisable() { }

	// RVA: 0x67A0B0 Offset: 0x6786B0 VA: 0x18067A0B0
	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemSubmitPanel : LootPanel // TypeDefIndex: 11023
{	// Methods

	// RVA: 0x67BE60 Offset: 0x67A460 VA: 0x18067BE60
	public void SubmitClicked() { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
	public void .ctor() { }

}

public class ItemTextValue : MonoBehaviour // TypeDefIndex: 11024
{	// Fields
	public Text text; // 0x18
	public Color bad; // 0x20
	public Color good; // 0x30
	public bool negativestat; // 0x40
	public bool asPercentage; // 0x41
	public bool useColors; // 0x42
	public bool signed; // 0x43
	public string suffix; // 0x48
	public float multiplier; // 0x50

	// Methods

	// RVA: 0x67BEF0 Offset: 0x67A4F0 VA: 0x18067BEF0
	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	// RVA: 0x67C110 Offset: 0x67A710 VA: 0x18067C110
	public void .ctor() { }

}

public class ItemStore : SingletonComponent<ItemStore>, VirtualScroll.IDataSource // TypeDefIndex: 11106
{	// Fields
	public static readonly Translate.Phrase CartEmptyPhrase; // 0x0
	public static readonly Translate.Phrase CartSingularPhrase; // 0x8
	public static readonly Translate.Phrase CartPluralPhrase; // 0x10
	public GameObject ItemPrefab; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x965F0 Offset: 0x959F0 VA: 0x1800965F0
	public RectTransform LimitedItemParent; // 0x20
	public RectTransform GeneralItemParent; // 0x28
	public List<IPlayerItemDefinition> Cart; // 0x30
	public ItemStoreItemInfoModal ItemStoreInfoModal; // 0x38
	public GameObject BuyingModal; // 0x40
	public ItemStoreBuyFailedModal ItemStoreBuyFailedModal; // 0x48
	public ItemStoreBuySuccessModal ItemStoreBuySuccessModal; // 0x50
	public SoundDefinition AddToCartSound; // 0x58
	public RustText CartButtonLabel; // 0x60
	public RustText QuantityValue; // 0x68
	public RustText TotalValue; // 0x70

	// Methods

	// RVA: 0x67AF70 Offset: 0x679570 VA: 0x18067AF70 Slot: 6
	protected override void Awake() { }

	// RVA: 0x67B240 Offset: 0x679840 VA: 0x18067B240
	private void OnPurchaseFinished(AppId appid, ulong orderid, bool success) { }

	[AsyncStateMachineAttribute] // RVA: 0x96710 Offset: 0x95B10 VA: 0x180096710
	// RVA: 0x67B730 Offset: 0x679D30 VA: 0x18067B730
	private void RefreshList() { }

	// RVA: 0x67ADC0 Offset: 0x6793C0 VA: 0x18067ADC0
	private void AddItem(IPlayerItemDefinition item) { }

	// RVA: 0x67B970 Offset: 0x679F70 VA: 0x18067B970
	internal void ShowModal(IPlayerItemDefinition item) { }

	// RVA: 0x67AED0 Offset: 0x6794D0 VA: 0x18067AED0
	internal void AddToCart(IPlayerItemDefinition item) { }

	// RVA: 0x67B1B0 Offset: 0x6797B0 VA: 0x18067B1B0
	public void EmptyCart() { }

	// RVA: 0x67B990 Offset: 0x679F90 VA: 0x18067B990
	private void UpdateShoppingList() { }

	// RVA: 0x67B800 Offset: 0x679E00 VA: 0x18067B800
	public void RemoveFromCart(int index) { }

	[AsyncStateMachineAttribute] // RVA: 0x96910 Offset: 0x95D10 VA: 0x180096910
	// RVA: 0x67B0E0 Offset: 0x6796E0 VA: 0x18067B0E0
	public void Checkout() { }

	// RVA: 0x67B200 Offset: 0x679800 VA: 0x18067B200 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x67B860 Offset: 0x679E60 VA: 0x18067B860 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x67BDD0 Offset: 0x67A3D0 VA: 0x18067BDD0
	public void .ctor() { }

	// RVA: 0x67BCD0 Offset: 0x67A2D0 VA: 0x18067BCD0
	private static void .cctor() { }

}

private sealed class ItemStore.<>c // TypeDefIndex: 11107
{	// Fields
	public static readonly ItemStore.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, int> <>9__16_0; // 0x8
	public static Func<IPlayerItemDefinition, int> <>9__17_0; // 0x10
	public static Func<IPlayerItemDefinition, int> <>9__22_0; // 0x18
	public static Func<SteamItemDefinition, InventoryDef> <>9__24_0; // 0x20

	// Methods

	// RVA: 0x690FE0 Offset: 0x68F5E0 VA: 0x180690FE0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690D50 Offset: 0x68F350 VA: 0x180690D50
	internal int <OnPurchaseFinished>b__16_0(IPlayerItemDefinition x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
	internal int <RefreshList>b__17_0(IPlayerItemDefinition x) { }

	// RVA: 0x690DF0 Offset: 0x68F3F0 VA: 0x180690DF0
	internal int <UpdateShoppingList>b__22_0(IPlayerItemDefinition x) { }

	// RVA: 0x690D30 Offset: 0x68F330 VA: 0x180690D30
	internal InventoryDef <Checkout>b__24_0(SteamItemDefinition i) { }

}

private struct ItemStore.<RefreshList>d__17 : IAsyncStateMachine // TypeDefIndex: 11108
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<List<IPlayerItemDefinition>> <>u__1; // 0x30

	// Methods

	// RVA: 0xF39C0 Offset: 0xF2DC0 VA: 0x1800F39C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ItemStore.<Checkout>d__24 : IAsyncStateMachine // TypeDefIndex: 11109
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<Nullable<InventoryPurchaseResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0xF39B0 Offset: 0xF2DB0 VA: 0x1800F39B0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF1530 Offset: 0xF0930 VA: 0x1800F1530 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ItemStoreBuyFailedModal : MonoBehaviour // TypeDefIndex: 11110
{	// Methods

	// RVA: 0x67A2F0 Offset: 0x6788F0 VA: 0x18067A2F0
	public void Show(ulong orderid) { }

	// RVA: 0x67A220 Offset: 0x678820 VA: 0x18067A220
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void <Hide>b__1_0() { }

}

public class ItemStoreBuySuccessModal : MonoBehaviour // TypeDefIndex: 11111
{	// Methods

	// RVA: 0x67A480 Offset: 0x678A80 VA: 0x18067A480
	public void Show(ulong orderId) { }

	// RVA: 0x67A3B0 Offset: 0x6789B0 VA: 0x18067A3B0
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void <Hide>b__1_0() { }

}

public class ItemStoreCartItem : MonoBehaviour // TypeDefIndex: 11112
{	// Fields
	public int Index; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28

	// Methods

	// RVA: 0x67A5F0 Offset: 0x678BF0 VA: 0x18067A5F0
	public void Init(int index, IPlayerItemDefinition def) { }

	// RVA: 0x67A6A0 Offset: 0x678CA0 VA: 0x18067A6A0
	public void RemoveFromCart() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemStoreItem : MonoBehaviour // TypeDefIndex: 11113
{	// Fields
	public HttpImage Icon; // 0x18
	public RustText Name; // 0x20
	public TextMeshProUGUI Price; // 0x28
	public RustText ItemName; // 0x30
	public GameObject InCartTag; // 0x38
	private IPlayerItemDefinition item; // 0x40

	// Methods

	// RVA: 0x67AB80 Offset: 0x679180 VA: 0x18067AB80
	internal void Init(IPlayerItemDefinition item, bool inCart) { }

	// RVA: 0x67AD40 Offset: 0x679340 VA: 0x18067AD40
	public void ShowModal() { }

	// RVA: 0x67AB00 Offset: 0x679100 VA: 0x18067AB00
	public void AddToCart() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemStoreItemInfoModal : MonoBehaviour // TypeDefIndex: 11114
{	// Fields
	public HttpImage Icon; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28
	public TextMeshProUGUI Description; // 0x30
	private IPlayerItemDefinition item; // 0x38

	// Methods

	// RVA: 0x67A950 Offset: 0x678F50 VA: 0x18067A950
	public void Show(IPlayerItemDefinition item) { }

	// RVA: 0x67A750 Offset: 0x678D50 VA: 0x18067A750
	public void AddToCart() { }

	// RVA: 0x67A880 Offset: 0x678E80 VA: 0x18067A880
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E6380 Offset: 0x4E4980 VA: 0x1804E6380
	private void <Hide>b__7_0() { }

}

public class ItemModEngineItem : ItemMod // TypeDefIndex: 12112
{	// Fields
	public EngineStorage.EngineItemTypes engineItemType; // 0x20
	[RangeAttribute] // RVA: 0xDBF30 Offset: 0xDB330 VA: 0x1800DBF30
	public int tier; // 0x24

	// Methods

	// RVA: 0x4BE580 Offset: 0x4BCB80 VA: 0x1804BE580
	public void .ctor() { }

}

public class ItemModVehicleChassis : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12113
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xDC0A0 Offset: 0xDB4A0 VA: 0x1800DC0A0
	public int socketsTaken; // 0x28

	// Properties
	public int SocketsTaken { get; }

	// Methods

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 16
	public int get_SocketsTaken() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0x4BE5A0 Offset: 0x4BCBA0 VA: 0x1804BE5A0
	public void .ctor() { }

}

public class ItemModVehicleModule : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12114
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xA4560 Offset: 0xA3960 VA: 0x1800A4560
	public int socketsTaken; // 0x28
	public bool doNonUserSpawn; // 0x2C

	// Properties
	public int SocketsTaken { get; }

	// Methods

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 16
	public int get_SocketsTaken() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0x4BE5A0 Offset: 0x4BCBA0 VA: 0x1804BE5A0
	public void .ctor() { }

}

