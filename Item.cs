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

	// RVA: 0x224150 Offset: 0x223550 VA: 0x180224150
	public void .ctor(PublishedFileId id) { }

	// RVA: 0x1D1050 Offset: 0x1D0450 VA: 0x1801D1050
	public PublishedFileId get_Id() { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x224320 Offset: 0x223720 VA: 0x180224320
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224560 Offset: 0x223960 VA: 0x180224560
	internal void set_Title(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1E13E0 Offset: 0x1E07E0 VA: 0x1801E13E0
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224440 Offset: 0x223840 VA: 0x180224440
	internal void set_Description(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xFD410 Offset: 0xFC810 VA: 0x1800FD410
	public string[] get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224550 Offset: 0x223950 VA: 0x180224550
	internal void set_Tags(string[] value) { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0xF13B0 Offset: 0xF07B0 VA: 0x1800F13B0
	public Dictionary<string, string> get_KeyValueTags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224450 Offset: 0x223850 VA: 0x180224450
	internal void set_KeyValueTags(Dictionary<string, string> value) { }

	// RVA: 0x2242C0 Offset: 0x2236C0 VA: 0x1802242C0
	public Friend get_Owner() { }

	// RVA: 0x224330 Offset: 0x223730 VA: 0x180224330
	public DateTime get_Updated() { }

	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x1D13F0 Offset: 0x1D07F0 VA: 0x1801D13F0
	public UgcAdditionalPreview[] get_AdditionalPreviews() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224430 Offset: 0x223830 VA: 0x180224430
	internal void set_AdditionalPreviews(UgcAdditionalPreview[] value) { }

	// RVA: 0x224280 Offset: 0x223680 VA: 0x180224280
	public bool get_IsInstalled() { }

	// RVA: 0x224240 Offset: 0x223640 VA: 0x180224240
	public bool get_IsDownloading() { }

	// RVA: 0x224200 Offset: 0x223600 VA: 0x180224200
	public bool get_IsDownloadPending() { }

	// RVA: 0x224190 Offset: 0x223590 VA: 0x180224190
	public string get_Directory() { }

	// RVA: 0x223F80 Offset: 0x223380 VA: 0x180223F80
	public bool Download(bool highPriority = False) { }

	// RVA: 0x2242E0 Offset: 0x2236E0 VA: 0x1802242E0
	private ItemState get_State() { }

	// RVA: 0x19D5B30 Offset: 0x19D4130 VA: 0x1819D5B30
	internal static Item From(SteamUGCDetails_t details) { }

	[AsyncStateMachineAttribute] // RVA: 0x9EB60 Offset: 0x9DF60 VA: 0x18009EB60
	// RVA: 0x223FD0 Offset: 0x2233D0 VA: 0x180223FD0
	public Task<Nullable<Result>> Vote(bool up) { }

	// RVA: 0x2243D0 Offset: 0x2237D0 VA: 0x1802243D0
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2244E0 Offset: 0x2238E0 VA: 0x1802244E0
	internal void set_NumSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224480 Offset: 0x223880 VA: 0x180224480
	internal void set_NumFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224490 Offset: 0x223890 VA: 0x180224490
	internal void set_NumFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224510 Offset: 0x223910 VA: 0x180224510
	internal void set_NumUniqueSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2244F0 Offset: 0x2238F0 VA: 0x1802244F0
	internal void set_NumUniqueFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224500 Offset: 0x223900 VA: 0x180224500
	internal void set_NumUniqueFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224520 Offset: 0x223920 VA: 0x180224520
	internal void set_NumUniqueWebsiteViews(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224540 Offset: 0x223940 VA: 0x180224540
	internal void set_ReportScore(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2244D0 Offset: 0x2238D0 VA: 0x1802244D0
	internal void set_NumSecondsPlayed(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2244B0 Offset: 0x2238B0 VA: 0x1802244B0
	internal void set_NumPlaytimeSessions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224470 Offset: 0x223870 VA: 0x180224470
	internal void set_NumComments(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2244C0 Offset: 0x2238C0 VA: 0x1802244C0
	internal void set_NumSecondsPlayedDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2244A0 Offset: 0x2238A0 VA: 0x1802244A0
	internal void set_NumPlaytimeSessionsDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	[IsReadOnlyAttribute] // RVA: 0x71750 Offset: 0x70B50 VA: 0x180071750
	// RVA: 0x2242D0 Offset: 0x2236D0 VA: 0x1802242D0
	public string get_PreviewImageUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224530 Offset: 0x223930 VA: 0x180224530
	internal void set_PreviewImageUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224460 Offset: 0x223860 VA: 0x180224460
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

	// RVA: 0x224F90 Offset: 0x224390 VA: 0x180224F90 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x224FA0 Offset: 0x2243A0 VA: 0x180224FA0 Slot: 5
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

	// RVA: 0x1EAEF0 Offset: 0x1EA2F0 VA: 0x1801EAEF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAEE0 Offset: 0x1EA2E0 VA: 0x1801EAEE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373500 Offset: 0x1371B00 VA: 0x181373500
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

	// RVA: 0x1F1A900 Offset: 0x1F18F00 VA: 0x181F1A900
	public static void ResetToPool(ItemContainer instance) { }

	// RVA: 0x1F1ABE0 Offset: 0x1F191E0 VA: 0x181F1ABE0
	public void ResetToPool() { }

	// RVA: 0x1F1A840 Offset: 0x1F18E40 VA: 0x181F1A840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F192E0 Offset: 0x1F178E0 VA: 0x181F192E0
	public void CopyTo(ItemContainer instance) { }

	// RVA: 0x1F195E0 Offset: 0x1F17BE0 VA: 0x181F195E0
	public ItemContainer Copy() { }

	// RVA: 0x1F1A6C0 Offset: 0x1F18CC0 VA: 0x181F1A6C0
	public static ItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1F19B70 Offset: 0x1F18170 VA: 0x181F19B70
	public static ItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F19BF0 Offset: 0x1F181F0 VA: 0x181F19BF0
	public static ItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1A5A0 Offset: 0x1F18BA0 VA: 0x181F1A5A0
	public static ItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1A8C0 Offset: 0x1F18EC0 VA: 0x181F1A8C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1B9F0 Offset: 0x1F19FF0 VA: 0x181F1B9F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1BA10 Offset: 0x1F1A010 VA: 0x181F1BA10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemContainer previous) { }

	// RVA: 0x1F1A8E0 Offset: 0x1F18EE0 VA: 0x181F1A8E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1A740 Offset: 0x1F18D40 VA: 0x181F1A740
	public static ItemContainer Deserialize(byte[] buffer, ItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1F1A170 Offset: 0x1F18770 VA: 0x181F1A170
	public static ItemContainer Deserialize(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F19660 Offset: 0x1F17C60 VA: 0x181F19660
	public static ItemContainer DeserializeLengthDelimited(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F19C80 Offset: 0x1F18280 VA: 0x181F19C80
	public static ItemContainer DeserializeLength(Stream stream, int length, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F1AEC0 Offset: 0x1F194C0 VA: 0x181F1AEC0
	public static void SerializeDelta(Stream stream, ItemContainer instance, ItemContainer previous) { }

	// RVA: 0x1F1B5D0 Offset: 0x1F19BD0 VA: 0x181F1B5D0
	public static void Serialize(Stream stream, ItemContainer instance) { }

	// RVA: 0x1F1B9E0 Offset: 0x1F19FE0 VA: 0x181F1B9E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1B9F0 Offset: 0x1F19FF0 VA: 0x181F1B9F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1B4C0 Offset: 0x1F19AC0 VA: 0x181F1B4C0
	public static byte[] SerializeToBytes(ItemContainer instance) { }

	// RVA: 0x1F1B410 Offset: 0x1F19A10 VA: 0x181F1B410
	public static void SerializeLengthDelimited(Stream stream, ItemContainer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1C0FEB0 Offset: 0x1C0E4B0 VA: 0x181C0FEB0
	public static void ResetToPool(Item instance) { }

	// RVA: 0x1C100D0 Offset: 0x1C0E6D0 VA: 0x181C100D0
	public void ResetToPool() { }

	// RVA: 0x1C0FDF0 Offset: 0x1C0E3F0 VA: 0x181C0FDF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0E750 Offset: 0x1C0CD50 VA: 0x181C0E750
	public void CopyTo(Item instance) { }

	// RVA: 0x1C0E8A0 Offset: 0x1C0CEA0 VA: 0x181C0E8A0
	public Item Copy() { }

	// RVA: 0x1C0FC50 Offset: 0x1C0E250 VA: 0x181C0FC50
	public static Item Deserialize(Stream stream) { }

	// RVA: 0x1C0EF20 Offset: 0x1C0D520 VA: 0x181C0EF20
	public static Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0F580 Offset: 0x1C0DB80 VA: 0x181C0F580
	public static Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0FCD0 Offset: 0x1C0E2D0 VA: 0x181C0FCD0
	public static Item Deserialize(byte[] buffer) { }

	// RVA: 0x1C0FE70 Offset: 0x1C0E470 VA: 0x181C0FE70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C11270 Offset: 0x1C0F870 VA: 0x181C11270 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C11290 Offset: 0x1C0F890 VA: 0x181C11290 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item previous) { }

	// RVA: 0x1C0FE90 Offset: 0x1C0E490 VA: 0x181C0FE90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0FB50 Offset: 0x1C0E150 VA: 0x181C0FB50
	public static Item Deserialize(byte[] buffer, Item instance, bool isDelta = False) { }

	// RVA: 0x1C0F610 Offset: 0x1C0DC10 VA: 0x181C0F610
	public static Item Deserialize(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C0E920 Offset: 0x1C0CF20 VA: 0x181C0E920
	public static Item DeserializeLengthDelimited(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C0EFA0 Offset: 0x1C0D5A0 VA: 0x181C0EFA0
	public static Item DeserializeLength(Stream stream, int length, Item instance, bool isDelta) { }

	// RVA: 0x1C102F0 Offset: 0x1C0E8F0 VA: 0x181C102F0
	public static void SerializeDelta(Stream stream, Item instance, Item previous) { }

	// RVA: 0x1C10C90 Offset: 0x1C0F290 VA: 0x181C10C90
	public static void Serialize(Stream stream, Item instance) { }

	// RVA: 0x1C11260 Offset: 0x1C0F860 VA: 0x181C11260
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C11270 Offset: 0x1C0F870 VA: 0x181C11270
	public void ToProto(Stream stream) { }

	// RVA: 0x1C10B80 Offset: 0x1C0F180 VA: 0x181C10B80
	public static byte[] SerializeToBytes(Item instance) { }

	// RVA: 0x1C10AD0 Offset: 0x1C0F0D0 VA: 0x181C10AD0
	public static void SerializeLengthDelimited(Stream stream, Item instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1F17340 Offset: 0x1F15940 VA: 0x181F17340
	public static void ResetToPool(Item.InstanceData instance) { }

	// RVA: 0x1F172A0 Offset: 0x1F158A0 VA: 0x181F172A0
	public void ResetToPool() { }

	// RVA: 0x1F16F50 Offset: 0x1F15550 VA: 0x181F16F50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C072E0 Offset: 0x1C058E0 VA: 0x181C072E0
	public void CopyTo(Item.InstanceData instance) { }

	// RVA: 0x1F15DC0 Offset: 0x1F143C0 VA: 0x181F15DC0
	public Item.InstanceData Copy() { }

	// RVA: 0x1F169F0 Offset: 0x1F14FF0 VA: 0x181F169F0
	public static Item.InstanceData Deserialize(Stream stream) { }

	// RVA: 0x1F16120 Offset: 0x1F14720 VA: 0x181F16120
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F16460 Offset: 0x1F14A60 VA: 0x181F16460
	public static Item.InstanceData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F16C40 Offset: 0x1F15240 VA: 0x181F16C40
	public static Item.InstanceData Deserialize(byte[] buffer) { }

	// RVA: 0x1F17070 Offset: 0x1F15670 VA: 0x181F17070
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F17920 Offset: 0x1F15F20 VA: 0x181F17920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F17940 Offset: 0x1F15F40 VA: 0x181F17940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.InstanceData previous) { }

	// RVA: 0x1F17280 Offset: 0x1F15880 VA: 0x181F17280 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F16700 Offset: 0x1F14D00 VA: 0x181F16700
	public static Item.InstanceData Deserialize(byte[] buffer, Item.InstanceData instance, bool isDelta = False) { }

	// RVA: 0x1F164F0 Offset: 0x1F14AF0 VA: 0x181F164F0
	public static Item.InstanceData Deserialize(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F15E40 Offset: 0x1F14440 VA: 0x181F15E40
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F161A0 Offset: 0x1F147A0 VA: 0x181F161A0
	public static Item.InstanceData DeserializeLength(Stream stream, int length, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F173E0 Offset: 0x1F159E0 VA: 0x181F173E0
	public static void SerializeDelta(Stream stream, Item.InstanceData instance, Item.InstanceData previous) { }

	// RVA: 0x1F177C0 Offset: 0x1F15DC0 VA: 0x181F177C0
	public static void Serialize(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x1F17910 Offset: 0x1F15F10 VA: 0x181F17910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F17920 Offset: 0x1F15F20 VA: 0x181F17920
	public void ToProto(Stream stream) { }

	// RVA: 0x1F176B0 Offset: 0x1F15CB0 VA: 0x181F176B0
	public static byte[] SerializeToBytes(Item.InstanceData instance) { }

	// RVA: 0x1F17600 Offset: 0x1F15C00 VA: 0x181F17600
	public static void SerializeLengthDelimited(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class Item.ConditionData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6442
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float condition; // 0x14
	public float maxCondition; // 0x18

	// Methods

	// RVA: 0x1F156C0 Offset: 0x1F13CC0 VA: 0x181F156C0
	public static void ResetToPool(Item.ConditionData instance) { }

	// RVA: 0x1F15740 Offset: 0x1F13D40 VA: 0x181F15740
	public void ResetToPool() { }

	// RVA: 0x1F15420 Offset: 0x1F13A20 VA: 0x181F15420 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEBA0 Offset: 0x1DBD1A0 VA: 0x181DBEBA0
	public void CopyTo(Item.ConditionData instance) { }

	// RVA: 0x1F14620 Offset: 0x1F12C20 VA: 0x181F14620
	public Item.ConditionData Copy() { }

	// RVA: 0x1F14C20 Offset: 0x1F13220 VA: 0x181F14C20
	public static Item.ConditionData Deserialize(Stream stream) { }

	// RVA: 0x1F14690 Offset: 0x1F12C90 VA: 0x181F14690
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F14960 Offset: 0x1F12F60 VA: 0x181F14960
	public static Item.ConditionData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F14DE0 Offset: 0x1F133E0 VA: 0x181F14DE0
	public static Item.ConditionData Deserialize(byte[] buffer) { }

	// RVA: 0x1F15520 Offset: 0x1F13B20 VA: 0x181F15520
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F15C10 Offset: 0x1F14210 VA: 0x181F15C10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F15C30 Offset: 0x1F14230 VA: 0x181F15C30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.ConditionData previous) { }

	// RVA: 0x1F156A0 Offset: 0x1F13CA0 VA: 0x181F156A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F15050 Offset: 0x1F13650 VA: 0x181F15050
	public static Item.ConditionData Deserialize(byte[] buffer, Item.ConditionData instance, bool isDelta = False) { }

	// RVA: 0x1F152A0 Offset: 0x1F138A0 VA: 0x181F152A0
	public static Item.ConditionData Deserialize(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F14710 Offset: 0x1F12D10 VA: 0x181F14710
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F149F0 Offset: 0x1F12FF0 VA: 0x181F149F0
	public static Item.ConditionData DeserializeLength(Stream stream, int length, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F157C0 Offset: 0x1F13DC0 VA: 0x181F157C0
	public static void SerializeDelta(Stream stream, Item.ConditionData instance, Item.ConditionData previous) { }

	// RVA: 0x1F15B00 Offset: 0x1F14100 VA: 0x181F15B00
	public static void Serialize(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x1F15C00 Offset: 0x1F14200 VA: 0x181F15C00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F15C10 Offset: 0x1F14210 VA: 0x181F15C10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F159F0 Offset: 0x1F13FF0 VA: 0x181F159F0
	public static byte[] SerializeToBytes(Item.ConditionData instance) { }

	// RVA: 0x1F15940 Offset: 0x1F13F40 VA: 0x181F15940
	public static void SerializeLengthDelimited(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ItemAmountList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6506
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemID; // 0x18
	public List<float> amount; // 0x20

	// Methods

	// RVA: 0x1F18B80 Offset: 0x1F17180 VA: 0x181F18B80
	public static void ResetToPool(ItemAmountList instance) { }

	// RVA: 0x1F18A30 Offset: 0x1F17030 VA: 0x181F18A30
	public void ResetToPool() { }

	// RVA: 0x1F18830 Offset: 0x1F16E30 VA: 0x181F18830 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F17960 Offset: 0x1F15F60 VA: 0x181F17960
	public void CopyTo(ItemAmountList instance) { }

	// RVA: 0x1F17B60 Offset: 0x1F16160 VA: 0x181F17B60
	public ItemAmountList Copy() { }

	// RVA: 0x1F18440 Offset: 0x1F16A40 VA: 0x181F18440
	public static ItemAmountList Deserialize(Stream stream) { }

	// RVA: 0x1F17BE0 Offset: 0x1F161E0 VA: 0x181F17BE0
	public static ItemAmountList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F17F90 Offset: 0x1F16590 VA: 0x181F17F90
	public static ItemAmountList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F18710 Offset: 0x1F16D10 VA: 0x181F18710
	public static ItemAmountList Deserialize(byte[] buffer) { }

	// RVA: 0x1F189F0 Offset: 0x1F16FF0 VA: 0x181F189F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F192A0 Offset: 0x1F178A0 VA: 0x181F192A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F192C0 Offset: 0x1F178C0 VA: 0x181F192C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemAmountList previous) { }

	// RVA: 0x1F18A10 Offset: 0x1F17010 VA: 0x181F18A10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F18340 Offset: 0x1F16940 VA: 0x181F18340
	public static ItemAmountList Deserialize(byte[] buffer, ItemAmountList instance, bool isDelta = False) { }

	// RVA: 0x1F184C0 Offset: 0x1F16AC0 VA: 0x181F184C0
	public static ItemAmountList Deserialize(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F17C60 Offset: 0x1F16260 VA: 0x181F17C60
	public static ItemAmountList DeserializeLengthDelimited(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F18020 Offset: 0x1F16620 VA: 0x181F18020
	public static ItemAmountList DeserializeLength(Stream stream, int length, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F18CD0 Offset: 0x1F172D0 VA: 0x181F18CD0
	public static void SerializeDelta(Stream stream, ItemAmountList instance, ItemAmountList previous) { }

	// RVA: 0x1F19090 Offset: 0x1F17690 VA: 0x181F19090
	public static void Serialize(Stream stream, ItemAmountList instance) { }

	// RVA: 0x1F19290 Offset: 0x1F17890 VA: 0x181F19290
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F192A0 Offset: 0x1F178A0 VA: 0x181F192A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F18F80 Offset: 0x1F17580 VA: 0x181F18F80
	public static byte[] SerializeToBytes(ItemAmountList instance) { }

	// RVA: 0x1F18ED0 Offset: 0x1F174D0 VA: 0x181F18ED0
	public static void SerializeLengthDelimited(Stream stream, ItemAmountList instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0xE74270 Offset: 0xE72870 VA: 0x180E74270
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

	// RVA: 0xA26380 Offset: 0xA24980 VA: 0x180A26380 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA26840 Offset: 0xA24E40 VA: 0x180A26840 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA266B0 Offset: 0xA24CB0 VA: 0x180A266B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Description] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.Icon] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E0A0 Offset: 0x8D4A0 VA: 0x18008E0A0
	// RVA: 0xA26670 Offset: 0xA24C70 VA: 0x180A26670
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xA268D0 Offset: 0xA24ED0 VA: 0x180A268D0 Slot: 159
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xA26830 Offset: 0xA24E30 VA: 0x180A26830 Slot: 160
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xA267A0 Offset: 0xA24DA0 VA: 0x180A267A0
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

	// RVA: 0x678B00 Offset: 0x677100 VA: 0x180678B00
	public void Setup(ItemDefinition info, AddSellOrderManager mgr) { }

	// RVA: 0x678AD0 Offset: 0x6770D0 VA: 0x180678AD0
	public void Clicked() { }

	// RVA: 0x678AA0 Offset: 0x6770A0 VA: 0x180678AA0
	public void ClickedBP() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModCrackOpen : ItemModUnwrap // TypeDefIndex: 8785
{	// Methods

	// RVA: 0xA331D0 Offset: 0xA317D0 VA: 0x180A331D0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA332E0 Offset: 0xA318E0 VA: 0x180A332E0
	public void .ctor() { }

}

public class ItemModOpenLootBag : ItemModUnwrap // TypeDefIndex: 8793
{	// Methods

	// RVA: 0xA33B40 Offset: 0xA32140 VA: 0x180A33B40 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA332E0 Offset: 0xA318E0 VA: 0x180A332E0
	public void .ctor() { }

}

public class ItemModPhoto : ItemModAssociatedEntity<PhotoEntity> // TypeDefIndex: 8814
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA344E0 Offset: 0xA32AE0 VA: 0x180A344E0
	public void .ctor() { }

}

public class ItemModUnwrap : ItemMod // TypeDefIndex: 8823
{	// Fields
	public LootSpawn revealList; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int minTries; // 0x30
	public int maxTries; // 0x34

	// Methods

	// RVA: 0xA35610 Offset: 0xA33C10 VA: 0x180A35610 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA332E0 Offset: 0xA318E0 VA: 0x180A332E0
	public void .ctor() { }

}

public class ItemModOpenWrapped : ItemMod // TypeDefIndex: 8829
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public static Translate.Phrase open_wrapped_gift; // 0x0
	public static Translate.Phrase open_wrapped_gift_desc; // 0x8

	// Methods

	// RVA: 0xA33C50 Offset: 0xA32250 VA: 0x180A33C50 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xA33DB0 Offset: 0xA323B0 VA: 0x180A33DB0
	private static void .cctor() { }

}

public class ItemModWrap : ItemMod // TypeDefIndex: 8830
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public ItemDefinition wrappedDefinition; // 0x28
	public static Translate.Phrase wrap_gift; // 0x0
	public static Translate.Phrase wrap_gift_desc; // 0x8

	// Methods

	// RVA: 0xA36980 Offset: 0xA34F80 VA: 0x180A36980 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xA36B10 Offset: 0xA35110 VA: 0x180A36B10
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

	// RVA: 0xA34AA0 Offset: 0xA330A0 VA: 0x180A34AA0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA348E0 Offset: 0xA32EE0 VA: 0x180A348E0
	public void ConfigureClicked(BasePlayer player) { }

	// RVA: 0xA34F10 Offset: 0xA33510 VA: 0x180A34F10
	public void .ctor() { }

}

public class ItemButtonTools : MonoBehaviour // TypeDefIndex: 9282
{	// Fields
	public Image image; // 0x18
	public ItemDefinition itemDef; // 0x20

	// Methods

	// RVA: 0xA26FF0 Offset: 0xA255F0 VA: 0x180A26FF0
	public void GiveSelf(int amount) { }

	// RVA: 0xA26ED0 Offset: 0xA254D0 VA: 0x180A26ED0
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

	// RVA: 0xA301C0 Offset: 0xA2E7C0 VA: 0x180A301C0
	public void OnPanelOpened() { }

	// RVA: 0xA30190 Offset: 0xA2E790 VA: 0x180A30190
	private void OnOpenDevTools() { }

	// RVA: 0xA2FAC0 Offset: 0xA2E0C0 VA: 0x180A2FAC0
	private void CacheAllItems() { }

	// RVA: 0xA309E0 Offset: 0xA2EFE0 VA: 0x180A309E0
	public void Refresh() { }

	// RVA: 0xA30350 Offset: 0xA2E950 VA: 0x180A30350
	private void RebuildCategories() { }

	// RVA: 0xA309F0 Offset: 0xA2EFF0 VA: 0x180A309F0
	private void SwitchItemCategory(ItemDefinition[] defs) { }

	// RVA: 0xA2FC10 Offset: 0xA2E210 VA: 0x180A2FC10
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

	// RVA: 0xA3B500 Offset: 0xA39B00 VA: 0x180A3B500
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA39F90 Offset: 0xA38590 VA: 0x180A39F90
	internal string <CacheAllItems>b__8_0(ItemDefinition x) { }

	// RVA: 0xA3A240 Offset: 0xA38840 VA: 0x180A3A240
	internal ItemCategory <RebuildCategories>b__10_0(ItemDefinition x) { }

	// RVA: 0xA3A260 Offset: 0xA38860 VA: 0x180A3A260
	internal ItemCategory <RebuildCategories>b__10_1(IGrouping<ItemCategory, ItemDefinition> x) { }

	// RVA: 0xA39F90 Offset: 0xA38590 VA: 0x180A39F90
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

	// RVA: 0xA3A430 Offset: 0xA38A30 VA: 0x180A3A430
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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA32090 Offset: 0xA30690 VA: 0x180A32090 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA322A0 Offset: 0xA308A0 VA: 0x180A322A0
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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 17
	protected override bool get_AllowHeldEntityParenting() { }

	// RVA: 0xA32540 Offset: 0xA30B40 VA: 0x180A32540
	public void .ctor() { }

}

public class ItemModSign : ItemModAssociatedEntity<SignContent> // TypeDefIndex: 9514
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA35550 Offset: 0xA33B50 VA: 0x180A35550
	public void .ctor() { }

}

public class ItemPickup : DroppedItem // TypeDefIndex: 9792
{	// Fields
	public ItemDefinition itemDef; // 0x188
	public int amount; // 0x190
	public ulong skinOverride; // 0x198

	// Methods

	// RVA: 0x6781E0 Offset: 0x6767E0 VA: 0x1806781E0
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

	// RVA: 0xA29AD0 Offset: 0xA280D0 VA: 0x180A29AD0
	public void .ctor() { }

}

public class ItemCrafter : EntityComponent<BasePlayer> // TypeDefIndex: 10104
{	// Fields
	public List<ItemContainer> containers; // 0x20
	public LinkedList<ItemCraftTask> queue; // 0x28
	public int taskUID; // 0x30

	// Methods

	// RVA: 0xA29AF0 Offset: 0xA280F0 VA: 0x180A29AF0
	public void AddContainer(ItemContainer container) { }

	// RVA: 0xA2A170 Offset: 0xA28770 VA: 0x180A2A170
	public static float GetScaledDuration(ItemBlueprint bp, float workbenchLevel) { }

	// RVA: 0xA2A010 Offset: 0xA28610 VA: 0x180A2A010
	private bool DoesHaveUsableItem(int item, int iAmount) { }

	// RVA: 0xA29B50 Offset: 0xA28150 VA: 0x180A29B50
	public bool CanCraft(ItemBlueprint bp, int amount = 1, bool free = False) { }

	// RVA: 0xA29F80 Offset: 0xA28580 VA: 0x180A29F80
	public bool CanCraft(ItemDefinition def, int amount = 1, bool free = False) { }

	// RVA: 0xA2A1D0 Offset: 0xA287D0 VA: 0x180A2A1D0
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

	// RVA: 0xA2B160 Offset: 0xA29760 VA: 0x180A2B160 Slot: 5
	public virtual void OnItemUpdate(Item item) { }

	// RVA: 0xA2B1C0 Offset: 0xA297C0 VA: 0x180A2B1C0
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

	// RVA: 0xA386D0 Offset: 0xA36CD0 VA: 0x180A386D0
	public void UpdateAmountDisplay(Text text) { }

	// RVA: 0xA38750 Offset: 0xA36D50 VA: 0x180A38750
	public static void UpdateAmountDisplay(Text text, Item item, Nullable<int> amountOverride, ItemDefinition infoOverride) { }

	// RVA: 0xA37190 Offset: 0xA35790 VA: 0x180A37190
	private static string FormatAmount(ItemDefinition.AmountType type, int amount) { }

	// RVA: 0xA396A0 Offset: 0xA37CA0 VA: 0x180A396A0
	public void set_condition(float value) { }

	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_condition() { }

	// RVA: 0xA39720 Offset: 0xA37D20 VA: 0x180A39720
	public void set_maxCondition(float value) { }

	// RVA: 0x774790 Offset: 0x772D90 VA: 0x180774790
	public float get_maxCondition() { }

	// RVA: 0xA39450 Offset: 0xA37A50 VA: 0x180A39450
	public float get_maxConditionNormalized() { }

	// RVA: 0xA38FE0 Offset: 0xA375E0 VA: 0x180A38FE0
	public float get_conditionNormalized() { }

	// RVA: 0xA39600 Offset: 0xA37C00 VA: 0x180A39600
	public void set_conditionNormalized(float value) { }

	// RVA: 0xA390E0 Offset: 0xA376E0 VA: 0x180A390E0
	public bool get_hasCondition() { }

	// RVA: 0xA39320 Offset: 0xA37920 VA: 0x180A39320
	public bool get_isBroken() { }

	// RVA: 0xA39020 Offset: 0xA37620 VA: 0x180A39020
	public int get_despawnMultiplier() { }

	// RVA: 0xA38FB0 Offset: 0xA375B0 VA: 0x180A38FB0
	public ItemDefinition get_blueprintTargetDef() { }

	// RVA: 0xA38FD0 Offset: 0xA375D0 VA: 0x180A38FD0
	public int get_blueprintTarget() { }

	// RVA: 0xA39570 Offset: 0xA37B70 VA: 0x180A39570
	public void set_blueprintTarget(int value) { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	public int get_blueprintAmount() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	public void set_blueprintAmount(int value) { }

	// RVA: 0xA376C0 Offset: 0xA35CC0 VA: 0x180A376C0
	public bool IsBlueprint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA38EE0 Offset: 0xA374E0 VA: 0x180A38EE0
	public void add_OnDirty(Action<Item> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA394C0 Offset: 0xA37AC0 VA: 0x180A394C0
	public void remove_OnDirty(Action<Item> value) { }

	// RVA: 0xA376B0 Offset: 0xA35CB0 VA: 0x180A376B0
	public bool HasFlag(Item.Flag f) { }

	// RVA: 0xA381D0 Offset: 0xA367D0 VA: 0x180A381D0
	public void SetFlag(Item.Flag f, bool b) { }

	// RVA: 0xA378F0 Offset: 0xA35EF0 VA: 0x180A378F0
	public bool IsOn() { }

	// RVA: 0xA378E0 Offset: 0xA35EE0 VA: 0x180A378E0
	public bool IsOnFire() { }

	// RVA: 0xA378A0 Offset: 0xA35EA0 VA: 0x180A378A0
	public bool IsCooking() { }

	// RVA: 0xA378B0 Offset: 0xA35EB0 VA: 0x180A378B0
	public bool IsLocked() { }

	// RVA: 0xA39480 Offset: 0xA37A80 VA: 0x180A39480
	public Item get_parentItem() { }

	// RVA: 0xA37D20 Offset: 0xA36320 VA: 0x180A37D20
	public void MarkDirty() { }

	// RVA: 0xA37E10 Offset: 0xA36410 VA: 0x180A37E10
	public void OnChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CollectedForCrafting(BasePlayer crafter) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ReturnedFromCancelledCraft(BasePlayer crafter) { }

	// RVA: 0xA37710 Offset: 0xA35D10 VA: 0x180A37710
	public bool IsChildContainer(ItemContainer c) { }

	// RVA: 0xA376E0 Offset: 0xA35CE0 VA: 0x180A376E0
	public bool IsBusy() { }

	// RVA: 0xA36D40 Offset: 0xA35340 VA: 0x180A36D40
	public void BusyFor(float fTime) { }

	// RVA: 0xA37FC0 Offset: 0xA365C0 VA: 0x180A37FC0
	public void Remove(float fTime = 0) { }

	// RVA: 0xA36FF0 Offset: 0xA355F0 VA: 0x180A36FF0
	internal void DoRemove() { }

	// RVA: 0xA38360 Offset: 0xA36960 VA: 0x180A38360
	public void SwitchOnOff(bool bNewState) { }

	// RVA: 0xA37CA0 Offset: 0xA362A0 VA: 0x180A37CA0
	public void LockUnlock(bool bNewState) { }

	// RVA: 0xA394A0 Offset: 0xA37AA0 VA: 0x180A394A0
	public float get_temperature() { }

	// RVA: 0xA374C0 Offset: 0xA35AC0 VA: 0x180A374C0
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA36D70 Offset: 0xA35370 VA: 0x180A36D70
	public bool CanBeHeld() { }

	// RVA: 0xA36DB0 Offset: 0xA353B0 VA: 0x180A36DB0
	public bool CanStack(Item item) { }

	// RVA: 0xA37900 Offset: 0xA35F00 VA: 0x180A37900
	public bool IsValid() { }

	// RVA: 0xA381F0 Offset: 0xA367F0 VA: 0x180A381F0
	public void SetWorldEntity(BaseEntity ent) { }

	// RVA: 0xA37F30 Offset: 0xA36530 VA: 0x180A37F30
	public void OnMovedToWorld() { }

	// RVA: 0xA37570 Offset: 0xA35B70 VA: 0x180A37570
	public BaseEntity GetWorldEntity() { }

	// RVA: 0xA374A0 Offset: 0xA35AA0 VA: 0x180A374A0
	public BaseEntity GetHeldEntity() { }

	// RVA: 0xA36CA0 Offset: 0xA352A0 VA: 0x180A36CA0
	public bool BeltBarSelect(BasePlayer player) { }

	// RVA: 0xA374E0 Offset: 0xA35AE0 VA: 0x180A374E0 Slot: 4
	public virtual int GetTotalUISlots() { }

	// RVA: 0xA37410 Offset: 0xA35A10 VA: 0x180A37410 Slot: 5
	public virtual int GetFilledUISlots() { }

	// RVA: 0xA37590 Offset: 0xA35B90 VA: 0x180A37590
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA37040 Offset: 0xA35640 VA: 0x180A37040
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA372F0 Offset: 0xA358F0 VA: 0x180A372F0
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA383E0 Offset: 0xA369E0 VA: 0x180A383E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xA37170 Offset: 0xA35770 VA: 0x180A37170
	public Item FindItem(uint iUID) { }

	// RVA: 0xA37D80 Offset: 0xA36380 VA: 0x180A37D80
	public int MaxStackable() { }

	// RVA: 0xA39180 Offset: 0xA37780 VA: 0x180A39180
	internal Sprite get_iconSprite() { }

	// RVA: 0xA39350 Offset: 0xA37950 VA: 0x180A39350
	internal bool get_isLoadingIconSprite() { }

	// RVA: 0xA38F80 Offset: 0xA37580 VA: 0x180A38F80
	public BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0xA38020 Offset: 0xA36620 VA: 0x180A38020 Slot: 6
	public virtual Item Save(bool bIncludeContainer = False, bool bIncludeOwners = True) { }

	// RVA: 0xA37910 Offset: 0xA35F10 VA: 0x180A37910 Slot: 7
	public virtual void Load(Item load) { }

	// RVA: 0xA38EC0 Offset: 0xA374C0 VA: 0x180A38EC0
	public void .ctor() { }

	// RVA: 0xA38DD0 Offset: 0xA373D0 VA: 0x180A38DD0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA386C0 Offset: 0xA36CC0 VA: 0x180A386C0
	private bool <get_iconSprite>b__95_0(ItemSkinDirectory.Skin x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA386C0 Offset: 0xA36CC0 VA: 0x180A386C0
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
	public static readonly Item.<>c <>9; // 0x2D40

	// Methods

	// RVA: 0xA3B4A0 Offset: 0xA39AA0 VA: 0x180A3B4A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3A2B0 Offset: 0xA388B0 VA: 0x180A3A2B0
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

	// RVA: 0xA28610 Offset: 0xA26C10 VA: 0x180A28610
	public bool HasFlag(ItemContainer.Flag f) { }

	// RVA: 0xA296C0 Offset: 0xA27CC0 VA: 0x180A296C0
	public void SetFlag(ItemContainer.Flag f, bool b) { }

	// RVA: 0xA287E0 Offset: 0xA26DE0 VA: 0x180A287E0
	public bool IsLocked() { }

	// RVA: 0xA29300 Offset: 0xA27900 VA: 0x180A29300
	public bool PlayerItemInputBlocked() { }

	// RVA: 0xA29AB0 Offset: 0xA280B0 VA: 0x180A29AB0
	public bool get_HasLimitedAllowedItems() { }

	// RVA: 0xA29260 Offset: 0xA27860 VA: 0x180A29260
	public void OnChanged() { }

	// RVA: 0xA27740 Offset: 0xA25D40 VA: 0x180A27740
	public void ClientInitialize(Item parentItem, int iMaxCapacity) { }

	// RVA: 0xA27CF0 Offset: 0xA262F0 VA: 0x180A27CF0
	public Item FindItemByUID(uint iUID) { }

	// RVA: 0xA28790 Offset: 0xA26D90 VA: 0x180A28790
	public bool IsFull() { }

	// RVA: 0xA28750 Offset: 0xA26D50 VA: 0x180A28750
	public bool IsEmpty() { }

	// RVA: 0xA27610 Offset: 0xA25C10 VA: 0x180A27610
	public bool CanAccept(Item item) { }

	// RVA: 0xA282B0 Offset: 0xA268B0 VA: 0x180A282B0
	public int GetMaxTransferAmount(ItemDefinition def) { }

	// RVA: 0xA296E0 Offset: 0xA27CE0 VA: 0x180A296E0
	public void SetOnlyAllowedItem(ItemDefinition def) { }

	// RVA: 0xA297A0 Offset: 0xA27DA0 VA: 0x180A297A0
	public void SetOnlyAllowedItems(ItemDefinition[] defs) { }

	// RVA: 0xA28620 Offset: 0xA26C20 VA: 0x180A28620
	internal bool Insert(Item item) { }

	// RVA: 0xA29930 Offset: 0xA27F30 VA: 0x180A29930
	public bool SlotTaken(Item item, int i) { }

	// RVA: 0xA28470 Offset: 0xA26A70 VA: 0x180A28470
	public Item GetSlot(int slot) { }

	// RVA: 0xA27FE0 Offset: 0xA265E0 VA: 0x180A27FE0
	internal bool FindPosition(Item item) { }

	// RVA: 0xA27660 Offset: 0xA25C60 VA: 0x180A27660
	internal void Clear() { }

	// RVA: 0xA287F0 Offset: 0xA26DF0 VA: 0x180A287F0
	public void Kill() { }

	// RVA: 0xA28130 Offset: 0xA26730 VA: 0x180A28130
	public int GetAmount(int itemid, bool onlyUsableAmounts) { }

	// RVA: 0xA27B80 Offset: 0xA26180 VA: 0x180A27B80
	public Item FindItemByItemID(int itemid) { }

	// RVA: 0xA27E90 Offset: 0xA26490 VA: 0x180A27E90
	public Item FindItemsByItemName(string name) { }

	// RVA: 0xA27920 Offset: 0xA25F20 VA: 0x180A27920
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xA27DE0 Offset: 0xA263E0 VA: 0x180A27DE0
	public List<Item> FindItemsByItemID(int itemid) { }

	// RVA: 0xA29310 Offset: 0xA27910 VA: 0x180A29310
	public ItemContainer Save() { }

	// RVA: 0xA28AB0 Offset: 0xA270B0 VA: 0x180A28AB0
	public void Load(ItemContainer container) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA27780 Offset: 0xA25D80 VA: 0x180A27780
	public int ContainerMaxStackSize() { }

	// RVA: 0xA27860 Offset: 0xA25E60 VA: 0x180A27860
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA28540 Offset: 0xA26B40 VA: 0x180A28540
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA28070 Offset: 0xA26670 VA: 0x180A28070
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA29950 Offset: 0xA27F50 VA: 0x180A29950
	public int TotalItemAmount() { }

	// RVA: 0xA27790 Offset: 0xA25D90 VA: 0x180A27790
	public uint ContentsHash() { }

	// RVA: 0xA27A90 Offset: 0xA26090 VA: 0x180A27A90
	internal ItemContainer FindContainer(uint id) { }

	// RVA: 0xA271A0 Offset: 0xA257A0 VA: 0x180A271A0
	public ItemContainer.CanAcceptResult CanAcceptItem(Item item, int targetPos) { }

	// RVA: 0xA29A00 Offset: 0xA28000 VA: 0x180A29A00
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

	// RVA: 0xA3A5E0 Offset: 0xA38BE0 VA: 0x180A3A5E0
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

	// RVA: 0xA26E90 Offset: 0xA25490 VA: 0x180A26E90
	public ItemDefinition get_targetItem() { }

	// RVA: 0xA26E00 Offset: 0xA25400 VA: 0x180A26E00
	public bool get_NeedsSteamDLC() { }

	// RVA: 0xA268E0 Offset: 0xA24EE0 VA: 0x180A268E0
	public string GetIngredientString(bool colorMissing) { }

	// RVA: 0xA26D40 Offset: 0xA25340 VA: 0x180A26D40
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

	// RVA: 0xA2ACD0 Offset: 0xA292D0 VA: 0x180A2ACD0
	public IPlayerItemDefinition[] get_skins2() { }

	// RVA: 0xA2AA20 Offset: 0xA29020 VA: 0x180A2AA20
	public void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA2AB30 Offset: 0xA29130 VA: 0x180A2AB30
	public ItemBlueprint get_Blueprint() { }

	// RVA: 0xA2ABF0 Offset: 0xA291F0 VA: 0x180A2ABF0
	public int get_craftingStackable() { }

	// RVA: 0xA2A7A0 Offset: 0xA28DA0 VA: 0x180A2A7A0
	public bool HasFlag(ItemDefinition.Flag f) { }

	// RVA: 0xA2A7B0 Offset: 0xA28DB0 VA: 0x180A2A7B0
	public void Initialize(List<ItemDefinition> itemList) { }

	// RVA: 0xA2A6A0 Offset: 0xA28CA0 VA: 0x180A2A6A0 Slot: 4
	public virtual string GetDisplayName(Item item) { }

	// RVA: 0xA2A5D0 Offset: 0xA28BD0 VA: 0x180A2A5D0 Slot: 5
	public virtual string GetDescriptionText(Item item) { }

	// RVA: 0xA2A660 Offset: 0xA28C60 VA: 0x180A2A660 Slot: 6
	public virtual string GetDescriptionText() { }

	// RVA: 0xA2A270 Offset: 0xA28870 VA: 0x180A2A270
	public Sprite FindIconSprite(int skinid) { }

	// RVA: 0xA2AC70 Offset: 0xA29270 VA: 0x180A2AC70
	public bool get_isWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2ABE0 Offset: 0xA291E0 VA: 0x180A2ABE0
	public ItemModWearable get_ItemModWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AEE0 Offset: 0xA294E0 VA: 0x180A2AEE0
	private void set_ItemModWearable(ItemModWearable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AC50 Offset: 0xA29250 VA: 0x180A2AC50
	public bool get_isHoldable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AEF0 Offset: 0xA294F0 VA: 0x180A2AEF0
	private void set_isHoldable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AC60 Offset: 0xA29260 VA: 0x180A2AC60
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AF00 Offset: 0xA29500 VA: 0x180A2AF00
	private void set_isUsable(bool value) { }

	// RVA: 0xA2AB80 Offset: 0xA29180 VA: 0x180A2AB80
	public bool get_HasSkins() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AB70 Offset: 0xA29170 VA: 0x180A2AB70
	public bool get_CraftableWithSkin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AED0 Offset: 0xA294D0 VA: 0x180A2AED0
	private void set_CraftableWithSkin(bool value) { }

	// RVA: 0xA2AAC0 Offset: 0xA290C0 VA: 0x180A2AAC0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2AA40 Offset: 0xA29040 VA: 0x180A2AA40
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

	// RVA: 0xA3B7F0 Offset: 0xA39DF0 VA: 0x180A3B7F0
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

	// RVA: 0xA3A510 Offset: 0xA38B10 VA: 0x180A3A510
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

	// RVA: 0x678CC0 Offset: 0x6772C0 VA: 0x180678CC0
	public void .ctor(ItemCategory category = 11) { }

}

public class ItemMod : MonoBehaviour // TypeDefIndex: 10128
{	// Fields
	protected ItemMod[] siblingMods; // 0x18

	// Methods

	// RVA: 0xA36C50 Offset: 0xA35250 VA: 0x180A36C50 Slot: 4
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

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public virtual int GetTotalUISlots(Item item) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 11
	public virtual int GetFilledUISlots(Item item) { }

	// RVA: 0xA36BC0 Offset: 0xA351C0 VA: 0x180A36BC0 Slot: 12
	public virtual bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 13
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

	// RVA: 0xA31F90 Offset: 0xA30590 VA: 0x180A31F90
	private void OnValidate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModActionContainerChange : ItemMod // TypeDefIndex: 10130
{	// Fields
	public ItemMod[] actions; // 0x20

	// Methods

	// RVA: 0xA32010 Offset: 0xA30610 VA: 0x180A32010
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
	|-RVA: 0x17F3D80 Offset: 0x17F2380 VA: 0x1817F3D80
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
	|-RVA: 0x15E5DA0 Offset: 0x15E43A0 VA: 0x1815E5DA0
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

	// RVA: 0xA322E0 Offset: 0xA308E0 VA: 0x180A322E0
	public void .ctor() { }

}

public class ItemModBlueprintCraft : ItemMod // TypeDefIndex: 10136
{	// Fields
	public GameObjectRef successEffect; // 0x20

	// Methods

	// RVA: 0xA322F0 Offset: 0xA308F0 VA: 0x180A322F0 Slot: 6
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

	// RVA: 0xA32520 Offset: 0xA30B20 VA: 0x180A32520
	public void .ctor() { }

}

public class ItemModCassetteContainer : ItemModContainer // TypeDefIndex: 10138
{	// Fields
	public ItemDefinition[] CassetteItems; // 0x58

	// Methods

	// RVA: 0xA322E0 Offset: 0xA308E0 VA: 0x180A322E0
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

	// RVA: 0xA32580 Offset: 0xA30B80 VA: 0x180A32580
	public void .ctor() { }

}

public class ItemModConditionContainerFlag : ItemMod // TypeDefIndex: 10141
{	// Fields
	public ItemContainer.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA325A0 Offset: 0xA30BA0 VA: 0x180A325A0 Slot: 13
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

	// RVA: 0xA325F0 Offset: 0xA30BF0 VA: 0x180A325F0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0xA32700 Offset: 0xA30D00 VA: 0x180A32700
	public void .ctor() { }

}

public class ItemModConditionHasContents : ItemMod // TypeDefIndex: 10143
{	// Fields
	[TooltipAttribute] // RVA: 0xB9710 Offset: 0xB8B10 VA: 0x1800B9710
	public ItemDefinition itemDef; // 0x20
	public bool requiredState; // 0x28

	// Methods

	// RVA: 0xA32720 Offset: 0xA30D20 VA: 0x180A32720 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA32830 Offset: 0xA30E30 VA: 0x180A32830
	private bool <Passes>b__2_0(Item x) { }

}

public class ItemModConditionHasFlag : ItemMod // TypeDefIndex: 10144
{	// Fields
	public Item.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA328B0 Offset: 0xA30EB0 VA: 0x180A328B0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionInWater : ItemMod // TypeDefIndex: 10145
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA328E0 Offset: 0xA30EE0 VA: 0x180A328E0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionIsSleeping : ItemMod // TypeDefIndex: 10146
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA32990 Offset: 0xA30F90 VA: 0x180A32990 Slot: 13
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

	// RVA: 0xA32A40 Offset: 0xA31040 VA: 0x180A32A40
	public float GetIfType(MetabolismAttribute.Type typeToPick) { }

	// RVA: 0xA32B20 Offset: 0xA31120 VA: 0x180A32B20
	public void .ctor() { }

}

public class ItemModConsumable.ConsumableEffect // TypeDefIndex: 10148
{	// Fields
	public MetabolismAttribute.Type type; // 0x10
	public float amount; // 0x14
	public float time; // 0x18
	public float onlyIfHealthLessThan; // 0x1C

	// Methods

	// RVA: 0xA234E0 Offset: 0xA21AE0 VA: 0x180A234E0
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

	// RVA: 0xA32E40 Offset: 0xA31440 VA: 0x180A32E40 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0xA32E70 Offset: 0xA31470 VA: 0x180A32E70
	public void .ctor() { }

}

public class ItemModConsumeChance : ItemModConsume // TypeDefIndex: 10150
{	// Fields
	public float chanceForSecondaryConsume; // 0x40
	public GameObjectRef secondaryConsumeEffect; // 0x48
	public ItemModConsumable secondaryConsumable; // 0x50

	// Methods

	// RVA: 0xA32BC0 Offset: 0xA311C0 VA: 0x180A32BC0
	public void .ctor() { }

}

public class ItemModConsumeContents : ItemMod // TypeDefIndex: 10151
{	// Fields
	public GameObjectRef consumeEffect; // 0x20

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA32C10 Offset: 0xA31210 VA: 0x180A32C10 Slot: 12
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

	// RVA: 0xA32FC0 Offset: 0xA315C0 VA: 0x180A32FC0 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0xA32F50 Offset: 0xA31550 VA: 0x180A32F50 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0xA33000 Offset: 0xA31600 VA: 0x180A33000
	public void .ctor() { }

}

public class ItemModContainerRestriction : ItemMod // TypeDefIndex: 10153
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public ItemModContainerRestriction.SlotFlags slotFlags; // 0x20

	// Methods

	// RVA: 0xA32EC0 Offset: 0xA314C0 VA: 0x180A32EC0
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

	// RVA: 0xA330D0 Offset: 0xA316D0 VA: 0x180A330D0
	public void OnValidate() { }

	// RVA: 0xA331B0 Offset: 0xA317B0 VA: 0x180A331B0
	public void .ctor() { }

}

public class ItemModCycle : ItemMod // TypeDefIndex: 10156
{	// Fields
	public ItemMod[] actions; // 0x20
	public float timeBetweenCycles; // 0x28
	public float timerStart; // 0x2C
	public bool onlyAdvanceTimerWhenPass; // 0x30

	// Methods

	// RVA: 0xA33300 Offset: 0xA31900 VA: 0x180A33300
	private void OnValidate() { }

	// RVA: 0xA33380 Offset: 0xA31980 VA: 0x180A33380
	public void .ctor() { }

}

public class ItemModDeployable : MonoBehaviour // TypeDefIndex: 10157
{	// Fields
	public GameObjectRef entityPrefab; // 0x18
	[HeaderAttribute] // RVA: 0xB9E20 Offset: 0xB9220 VA: 0x1800B9E20
	public bool showCrosshair; // 0x20
	public string UnlockAchievement; // 0x28

	// Methods

	// RVA: 0xA33390 Offset: 0xA31990 VA: 0x180A33390
	public Deployable GetDeployable(BaseEntity entity) { }

	// RVA: 0xA334A0 Offset: 0xA31AA0 VA: 0x180A334A0
	public void .ctor() { }

}

public class ItemModEntity : ItemMod // TypeDefIndex: 10158
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	public string defaultBone; // 0x28

	// Methods

	// RVA: 0xA33510 Offset: 0xA31B10 VA: 0x180A33510
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

	// RVA: 0xA33580 Offset: 0xA31B80 VA: 0x180A33580
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

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0 Slot: 16
	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60 Slot: 17
	public float GetAirTimeRemaining() { }

	// RVA: 0xA335B0 Offset: 0xA31BB0 VA: 0x180A335B0 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA336C0 Offset: 0xA31CC0 VA: 0x180A336C0 Slot: 5
	public override void OnChanged(Item item) { }

	// RVA: 0xA33720 Offset: 0xA31D20 VA: 0x180A33720
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

	// RVA: 0xA33830 Offset: 0xA31E30 VA: 0x180A33830 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA33740 Offset: 0xA31D40 VA: 0x180A33740 Slot: 7
	public override bool BeltSelect(Item item, BasePlayer player) { }

	// RVA: 0xA339A0 Offset: 0xA31FA0 VA: 0x180A339A0
	private void OnValidate() { }

	// RVA: 0xA33B30 Offset: 0xA32130 VA: 0x180A33B30
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

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA341A0 Offset: 0xA327A0 VA: 0x180A341A0 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB7A0 Offset: 0xBABA0 VA: 0x1800BB7A0
	// RVA: 0xA33E60 Offset: 0xA32460 VA: 0x180A33E60
	private IEnumerator DeferredSetup(Item item, PaintableItem paintable) { }

	// RVA: 0xA33F00 Offset: 0xA32500 VA: 0x180A33F00 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA343F0 Offset: 0xA329F0 VA: 0x180A343F0
	private void PaintClicked(BasePlayer player) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB900 Offset: 0xBAD00 VA: 0x1800BB900
	// RVA: 0xA34360 Offset: 0xA32960 VA: 0x180A34360
	private IEnumerator OpenPaintUI(EntityRef<PaintedItemStorageEntity> paintStorage) { }

	// RVA: 0xA344A0 Offset: 0xA32AA0 VA: 0x180A344A0
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

	// RVA: 0xA397B0 Offset: 0xA37DB0 VA: 0x180A397B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39930 Offset: 0xA37F30 VA: 0x180A39930 Slot: 8
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

	// RVA: 0xA3B410 Offset: 0xA39A10 VA: 0x180A3B410
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

	// RVA: 0xA39980 Offset: 0xA37F80 VA: 0x180A39980 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39C70 Offset: 0xA38270 VA: 0x180A39C70 Slot: 8
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

	// RVA: 0xA346D0 Offset: 0xA32CD0 VA: 0x180A346D0
	public float GetRandomVelocity() { }

	// RVA: 0xA34710 Offset: 0xA32D10 VA: 0x180A34710
	public float GetSpreadScalar() { }

	// RVA: 0xA34640 Offset: 0xA32C40 VA: 0x180A34640
	public float GetIndexedSpreadScalar(int shotIndex, int maxShots) { }

	// RVA: 0xA34630 Offset: 0xA32C30 VA: 0x180A34630
	public float GetAverageVelocity() { }

	// RVA: 0xA346C0 Offset: 0xA32CC0 VA: 0x180A346C0
	public float GetMinVelocity() { }

	// RVA: 0xA346B0 Offset: 0xA32CB0 VA: 0x180A346B0
	public float GetMaxVelocity() { }

	// RVA: 0xA34770 Offset: 0xA32D70 VA: 0x180A34770
	public bool IsAmmo(AmmoTypes ammo) { }

	// RVA: 0xA34780 Offset: 0xA32D80 VA: 0x180A34780 Slot: 4
	public virtual void ServerProjectileHit(HitInfo info) { }

	// RVA: 0xA34850 Offset: 0xA32E50 VA: 0x180A34850
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

	// RVA: 0xA34520 Offset: 0xA32B20 VA: 0x180A34520
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

	// RVA: 0xA34540 Offset: 0xA32B40 VA: 0x180A34540
	public void .ctor() { }

}

public class ItemModRecycleInto : ItemMod // TypeDefIndex: 10175
{	// Fields
	public ItemDefinition recycleIntoItem; // 0x20
	public int numRecycledItemMin; // 0x28
	public int numRecycledItemMax; // 0x2C
	public GameObjectRef successEffect; // 0x30

	// Methods

	// RVA: 0xA34F50 Offset: 0xA33550 VA: 0x180A34F50 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35060 Offset: 0xA33660 VA: 0x180A35060
	public void .ctor() { }

}

public class ItemModRepair : ItemMod // TypeDefIndex: 10176
{	// Fields
	public float conditionLost; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int workbenchLvlRequired; // 0x30

	// Methods

	// RVA: 0xA352D0 Offset: 0xA338D0 VA: 0x180A352D0
	public bool HasCraftLevel(BasePlayer player) { }

	// RVA: 0xA35080 Offset: 0xA33680 VA: 0x180A35080 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA353E0 Offset: 0xA339E0 VA: 0x180A353E0
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

	// RVA: 0xA353F0 Offset: 0xA339F0 VA: 0x180A353F0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35530 Offset: 0xA33B30 VA: 0x180A35530
	public void .ctor() { }

}

public class ItemModSound : ItemMod // TypeDefIndex: 10178
{	// Fields
	public GameObjectRef effect; // 0x20
	public ItemModSound.Type actionType; // 0x28

	// Methods

	// RVA: 0xA35590 Offset: 0xA33B90 VA: 0x180A35590
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

	// RVA: 0xA35600 Offset: 0xA33C00 VA: 0x180A35600
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

	// RVA: 0xA35720 Offset: 0xA33D20 VA: 0x180A35720 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35860 Offset: 0xA33E60 VA: 0x180A35860
	public void .ctor() { }

}

public class ItemModUseContent : ItemMod // TypeDefIndex: 10185
{	// Fields
	public int amountToConsume; // 0x20

	// Methods

	// RVA: 0x7D6D30 Offset: 0x7D5330 VA: 0x1807D6D30
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

	// RVA: 0xA36900 Offset: 0xA34F00 VA: 0x180A36900
	public Wearable get_targetWearable() { }

	// RVA: 0xA35A60 Offset: 0xA34060 VA: 0x180A35A60
	private void DoPrepare() { }

	// RVA: 0xA35E80 Offset: 0xA34480 VA: 0x180A35E80 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA367A0 Offset: 0xA34DA0 VA: 0x180A367A0
	public bool ProtectsArea(HitArea area) { }

	// RVA: 0xA35CD0 Offset: 0xA342D0 VA: 0x180A35CD0
	public bool HasProtections() { }

	// RVA: 0xA35BE0 Offset: 0xA341E0 VA: 0x180A35BE0
	internal float GetProtection(Item item, DamageType damageType) { }

	// RVA: 0xA35A10 Offset: 0xA34010 VA: 0x180A35A10
	public float ConditionProtectionScale(Item item) { }

	// RVA: 0xA35940 Offset: 0xA33F40 VA: 0x180A35940
	public void CollectProtection(Item item, ProtectionProperties protection) { }

	// RVA: 0xA35DE0 Offset: 0xA343E0 VA: 0x180A35DE0
	private bool IsHeadgear() { }

	// RVA: 0xA35D30 Offset: 0xA34330 VA: 0x180A35D30
	public bool IsFootwear() { }

	// RVA: 0xA35F30 Offset: 0xA34530 VA: 0x180A35F30
	public void OnDressModel(Item item, PlayerModel model) { }

	// RVA: 0xA36590 Offset: 0xA34B90 VA: 0x180A36590 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	// RVA: 0xA35890 Offset: 0xA33E90 VA: 0x180A35890
	public bool CanExistWith(ItemModWearable wearable) { }

	// RVA: 0xA36840 Offset: 0xA34E40 VA: 0x180A36840
	public void .ctor() { }

}

private sealed class ItemModWearable.<>c__DisplayClass28_0 // TypeDefIndex: 10187
{	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7F0080 Offset: 0x7EE680 VA: 0x1807F0080
	internal bool <OnObjectSetup>b__0(ItemSkinDirectory.Skin x) { }

}

public class ItemModXPWhenUsed : ItemMod // TypeDefIndex: 10188
{	// Fields
	public float xpPerUnit; // 0x20
	public int unitSize; // 0x24

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void GiveConsumeXP(Item item) { }

	// RVA: 0x4BE5F0 Offset: 0x4BCBF0 VA: 0x1804BE5F0
	public void .ctor() { }

}

public class ItemFootstepSounds : MonoBehaviour // TypeDefIndex: 10189
{	// Fields
	public string effectFolder; // 0x18

	// Methods

	// RVA: 0xA2B250 Offset: 0xA29850 VA: 0x180A2B250
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

	// RVA: 0xA262A0 Offset: 0xA248A0 VA: 0x180A262A0
	public void .ctor(ItemDefinition item, float amt = 0) { }

	// RVA: 0xA262F0 Offset: 0xA248F0 VA: 0x180A262F0
	public int get_itemid() { }

	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0 Slot: 6
	public virtual float GetAmount() { }

	// RVA: 0xA26030 Offset: 0xA24630 VA: 0x180A26030 Slot: 7
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void OnBeforeSerialize() { }

	// RVA: 0xA26040 Offset: 0xA24640 VA: 0x180A26040
	public static ItemAmountList SerialiseList(List<ItemAmount> list) { }

	// RVA: 0xA25E50 Offset: 0xA24450 VA: 0x180A25E50
	public static void DeserialiseList(List<ItemAmount> target, ItemAmountList source) { }

}

public class ItemAmountRandom // TypeDefIndex: 10191
{	// Fields
	[ItemSelector] // RVA: 0xA7690 Offset: 0xA6A90 VA: 0x1800A7690
	public ItemDefinition itemDef; // 0x10
	public AnimationCurve amount; // 0x18

	// Methods

	// RVA: 0xA25BC0 Offset: 0xA241C0 VA: 0x180A25BC0
	public int RandomAmount() { }

	// RVA: 0xA25C50 Offset: 0xA24250 VA: 0x180A25C50
	public void .ctor() { }

}

public class ItemAmountRanged : ItemAmount // TypeDefIndex: 10192
{	// Fields
	public float maxAmount; // 0x20

	// Methods

	// RVA: 0xA25DD0 Offset: 0xA243D0 VA: 0x180A25DD0 Slot: 7
	public override void OnAfterDeserialize() { }

	// RVA: 0xA25DE0 Offset: 0xA243E0 VA: 0x180A25DE0
	public void .ctor(ItemDefinition item, float amt = 0, float max = -1) { }

	// RVA: 0xA25DA0 Offset: 0xA243A0 VA: 0x180A25DA0 Slot: 6
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

	// RVA: 0xA31CB0 Offset: 0xA302B0 VA: 0x180A31CB0
	public static void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA30D00 Offset: 0xA2F300 VA: 0x180A30D00
	public static void Initialize() { }

	// RVA: 0x51B650 Offset: 0x519C50 VA: 0x18051B650
	public static void UpdateUnlockedSkins() { }

	// RVA: 0xA31DD0 Offset: 0xA303D0 VA: 0x180A31DD0
	public static Item Load(Item load, Item created, bool isServer) { }

	// RVA: 0xA30B80 Offset: 0xA2F180 VA: 0x180A30B80
	public static ItemDefinition FindItemDefinition(int itemID) { }

	// RVA: 0xA30C00 Offset: 0xA2F200 VA: 0x180A30C00
	public static ItemDefinition FindItemDefinition(string shortName) { }

	// RVA: 0xA30B30 Offset: 0xA2F130 VA: 0x180A30B30
	public static ItemBlueprint FindBlueprint(ItemDefinition item) { }

	// RVA: 0xA30CC0 Offset: 0xA2F2C0 VA: 0x180A30CC0
	public static List<ItemDefinition> GetItemDefinitions() { }

	// RVA: 0xA30C80 Offset: 0xA2F280 VA: 0x180A30C80
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

	// RVA: 0xA3B560 Offset: 0xA39B60 VA: 0x180A3B560
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA39FC0 Offset: 0xA385C0 VA: 0x180A39FC0
	internal ItemDefinition <Initialize>b__7_0(GameObject x) { }

	// RVA: 0xA3A010 Offset: 0xA38610 VA: 0x180A3A010
	internal bool <Initialize>b__7_1(ItemDefinition x) { }

	// RVA: 0xA3A070 Offset: 0xA38670 VA: 0x180A3A070
	internal ItemBlueprint <Initialize>b__7_2(GameObject x) { }

	// RVA: 0xA3A0C0 Offset: 0xA386C0 VA: 0x180A3A0C0
	internal bool <Initialize>b__7_3(ItemBlueprint x) { }

	// RVA: 0xA3A130 Offset: 0xA38730 VA: 0x180A3A130
	internal bool <Initialize>b__7_4(ItemBlueprint x) { }

	// RVA: 0xA3A1F0 Offset: 0xA387F0 VA: 0x180A3A1F0
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

	// RVA: 0x679050 Offset: 0x677650 VA: 0x180679050
	public void ApplySkin(GameObject obj) { }

	// RVA: 0x6790E0 Offset: 0x6776E0 VA: 0x1806790E0 Slot: 4
	public override bool HasUnlocked(ulong playerId) { }

	// RVA: 0x6794C0 Offset: 0x677AC0 VA: 0x1806794C0
	public void .ctor() { }

}

public class ItemSkinDirectory : ScriptableObject // TypeDefIndex: 10739
{	// Fields
	private static ItemSkinDirectory _Instance; // 0x0
	public ItemSkinDirectory.Skin[] skins; // 0x18

	// Properties
	public static ItemSkinDirectory Instance { get; }

	// Methods

	// RVA: 0x678EB0 Offset: 0x6774B0 VA: 0x180678EB0
	public static ItemSkinDirectory get_Instance() { }

	// RVA: 0x678DE0 Offset: 0x6773E0 VA: 0x180678DE0
	public static ItemSkinDirectory.Skin[] ForItem(ItemDefinition item) { }

	// RVA: 0x678CF0 Offset: 0x6772F0 VA: 0x180678CF0
	public static ItemSkinDirectory.Skin FindByInventoryDefinitionId(int id) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
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

	// RVA: 0x691000 Offset: 0x68F600 VA: 0x180691000
	internal bool <ForItem>b__0(ItemSkinDirectory.Skin x) { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass6_0 // TypeDefIndex: 10742
{	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4B3BA0 Offset: 0x4B21A0 VA: 0x1804B3BA0
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

	// RVA: 0xA2AF10 Offset: 0xA29510 VA: 0x180A2AF10
	private void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA2B110 Offset: 0xA29710 VA: 0x180A2B110
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

	// RVA: 0xA2B2A0 Offset: 0xA298A0 VA: 0x180A2B2A0
	protected void Awake() { }

	// RVA: 0xA2CAC0 Offset: 0xA2B0C0 VA: 0x180A2CAC0
	protected void OnEnable() { }

	// RVA: 0xA2B4D0 Offset: 0xA29AD0 VA: 0x180A2B4D0
	public static void ClearLootTimers() { }

	// RVA: 0xA2B5B0 Offset: 0xA29BB0 VA: 0x180A2B5B0
	public void ClearProgressImage() { }

	// RVA: 0xA2C510 Offset: 0xA2AB10 VA: 0x180A2C510
	protected void OnDisable() { }

	// RVA: 0xA2DBC0 Offset: 0xA2C1C0 VA: 0x180A2DBC0
	public void OnShow() { }

	// RVA: 0xA2CCE0 Offset: 0xA2B2E0 VA: 0x180A2CCE0
	public void OnHide() { }

	// RVA: 0xA2B590 Offset: 0xA29B90 VA: 0x180A2B590
	public void ClearLooting() { }

	// RVA: 0xA2F780 Offset: 0xA2DD80 VA: 0x180A2F780
	private void Update() { }

	// RVA: 0xA2BE80 Offset: 0xA2A480 VA: 0x180A2BE80
	public Sprite GetItemSprite(out Color tint) { }

	// RVA: 0xA2D4F0 Offset: 0xA2BAF0 VA: 0x180A2D4F0 Slot: 13
	public void OnItemAmountChanged() { }

	// RVA: 0xA2D530 Offset: 0xA2BB30 VA: 0x180A2D530 Slot: 14
	public void OnItemIconChanged() { }

	// RVA: 0xA2CD80 Offset: 0xA2B380 VA: 0x180A2CD80 Slot: 12
	public void OnInventoryChanged() { }

	// RVA: 0xA2F2C0 Offset: 0xA2D8C0 VA: 0x180A2F2C0
	private void UpdateHoverText() { }

	// RVA: 0xA2F480 Offset: 0xA2DA80 VA: 0x180A2F480
	private void UpdateItemIcon() { }

	// RVA: 0xA2DE90 Offset: 0xA2C490 VA: 0x180A2DE90
	private void SetBackgroundUnderlayVisible(bool flag) { }

	// RVA: 0xA2F1B0 Offset: 0xA2D7B0 VA: 0x180A2F1B0
	private void UpdateCornerIcon() { }

	// RVA: 0xA2F4C0 Offset: 0xA2DAC0 VA: 0x180A2F4C0
	private void UpdateSlots() { }

	// RVA: 0xA2F950 Offset: 0xA2DF50 VA: 0x180A2F950
	private Item get_iconValue() { }

	// RVA: 0xA2DDB0 Offset: 0xA2C3B0 VA: 0x180A2DDB0
	public void Select() { }

	// RVA: 0xA2DDA0 Offset: 0xA2C3A0 VA: 0x180A2DDA0
	public void SelectSilent() { }

	// RVA: 0xA2C3C0 Offset: 0xA2A9C0 VA: 0x180A2C3C0
	private void InternalSelect(bool silent = False) { }

	// RVA: 0xA2B8B0 Offset: 0xA29EB0 VA: 0x180A2B8B0
	public void Deselect() { }

	// RVA: 0xA2DDC0 Offset: 0xA2C3C0 VA: 0x180A2DDC0
	public void SetActive(bool active) { }

	// RVA: 0xA2C6A0 Offset: 0xA2ACA0 VA: 0x180A2C6A0 Slot: 15
	public virtual void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA2E340 Offset: 0xA2C940 VA: 0x180A2E340
	private bool TryToDropInsideItem(ItemIcon.DragInfo dropInfo, Item item) { }

	// RVA: 0xA2DFF0 Offset: 0xA2C5F0 VA: 0x180A2DFF0
	public void SetTimedLootAction(uint sourceContainer, Action action) { }

	// RVA: 0xA2B370 Offset: 0xA29970 VA: 0x180A2B370
	private float CalculateLootDelay(uint sourceContainer) { }

	[IteratorStateMachineAttribute] // RVA: 0x8EAE0 Offset: 0x8DEE0 VA: 0x18008EAE0
	// RVA: 0xA2E2C0 Offset: 0xA2C8C0 VA: 0x180A2E2C0
	private IEnumerator StartTimedLootAction(float delay) { }

	// RVA: 0xA2DD70 Offset: 0xA2C370 VA: 0x180A2DD70
	public void RunTimedAction() { }

	// RVA: 0xA2B680 Offset: 0xA29C80 VA: 0x180A2B680
	public void ClearTimedAction() { }

	// RVA: 0xA2DBD0 Offset: 0xA2C1D0 VA: 0x180A2DBD0
	private void RemoveFromLootQueue() { }

	[IteratorStateMachineAttribute] // RVA: 0x8EBE0 Offset: 0x8DFE0 VA: 0x18008EBE0
	// RVA: 0xA2F710 Offset: 0xA2DD10 VA: 0x180A2F710
	private IEnumerator UpdateTimedActionIcon() { }

	// RVA: 0xA2EC10 Offset: 0xA2D210 VA: 0x180A2EC10
	private void TryToQuickMove() { }

	// RVA: 0xA2E4C0 Offset: 0xA2CAC0 VA: 0x180A2E4C0 Slot: 16
	public virtual void TryToMove() { }

	// RVA: 0xA2B940 Offset: 0xA29F40 VA: 0x180A2B940
	public void EquipAsClothingItem() { }

	// RVA: 0xA2D640 Offset: 0xA2BC40 VA: 0x180A2D640 Slot: 17
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xA2D720 Offset: 0xA2BD20 VA: 0x180A2D720 Slot: 7
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA2DAF0 Offset: 0xA2C0F0 VA: 0x180A2DAF0 Slot: 8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA2BB20 Offset: 0xA2A120 VA: 0x180A2BB20 Slot: 9
	public object GetDragData() { }

	// RVA: 0xA2BE50 Offset: 0xA2A450 VA: 0x180A2BE50 Slot: 10
	public string GetDragType() { }

	// RVA: 0xA2BE20 Offset: 0xA2A420 VA: 0x180A2BE20 Slot: 11
	public Sprite GetDragSprite() { }

	// RVA: 0xA2F930 Offset: 0xA2DF30 VA: 0x180A2F930
	public void .ctor() { }

	// RVA: 0xA2F820 Offset: 0xA2DE20 VA: 0x180A2F820
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA2EE30 Offset: 0xA2D430 VA: 0x180A2EE30
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

	// RVA: 0xA39CC0 Offset: 0xA382C0 VA: 0x180A39CC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA39F40 Offset: 0xA38540 VA: 0x180A39F40 Slot: 8
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

	// RVA: 0xA3B5C0 Offset: 0xA39BC0 VA: 0x180A3B5C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA3B7A0 Offset: 0xA39DA0 VA: 0x180A3B7A0 Slot: 8
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

	// RVA: 0xA3A610 Offset: 0xA38C10 VA: 0x180A3A610
	internal void <TryToMove>b__0() { }

	// RVA: 0xA3A980 Offset: 0xA38F80 VA: 0x180A3A980
	internal void <TryToMove>b__1() { }

	// RVA: 0xA3ACB0 Offset: 0xA392B0 VA: 0x180A3ACB0
	internal void <TryToMove>b__2() { }

	// RVA: 0xA3B0A0 Offset: 0xA396A0 VA: 0x180A3B0A0
	internal void <TryToMove>b__3() { }

}

public class ItemInformationPanel : MonoBehaviour // TypeDefIndex: 11014
{	// Methods

	// RVA: 0xA2FA10 Offset: 0xA2E010 VA: 0x180A2FA10 Slot: 4
	public virtual bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xA2FA70 Offset: 0xA2E070 VA: 0x180A2FA70 Slot: 5
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

	// RVA: 0x677350 Offset: 0x675950 VA: 0x180677350
	public void Setup(Item item, Option option) { }

	// RVA: 0x677230 Offset: 0x675830 VA: 0x180677230
	public void Pressed() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemPanel : SingletonComponent<ItemPanel> // TypeDefIndex: 11016
{	// Fields
	private ItemIcon item; // 0x18

	// Methods

	// RVA: 0x677920 Offset: 0x675F20 VA: 0x180677920
	private void Start() { }

	// RVA: 0x677930 Offset: 0x675F30 VA: 0x180677930
	public void Update() { }

	// RVA: 0x6775C0 Offset: 0x675BC0 VA: 0x1806775C0
	private void OnChanged() { }

	// RVA: 0x6779F0 Offset: 0x675FF0 VA: 0x1806779F0
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

	// RVA: 0x678170 Offset: 0x676770 VA: 0x180678170
	public void set_itemInfo(ItemDefinition value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public ItemDefinition get_itemInfo() { }

	// RVA: 0x6780F0 Offset: 0x6766F0 VA: 0x1806780F0
	public void set_amount(int value) { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	public int get_amount() { }

	// RVA: 0x677A80 Offset: 0x676080 VA: 0x180677A80
	public void AppendTotal(int amount) { }

	// RVA: 0x677B40 Offset: 0x676140 VA: 0x180677B40
	public void OnEnable() { }

	// RVA: 0x677B10 Offset: 0x676110 VA: 0x180677B10
	public void BlockLayoutUpdates() { }

	// RVA: 0x677A50 Offset: 0x676050 VA: 0x180677A50
	public void AllowLayoutUpdates() { }

	// RVA: 0x677CD0 Offset: 0x6762D0 VA: 0x180677CD0
	public bool ProcessAnimation(AnimationCurve sizeCurve, AnimationCurve alphaCurve, AnimationCurve reuseSizeCurve, AnimationCurve reuseAlphaCurve) { }

	// RVA: 0x677C40 Offset: 0x676240 VA: 0x180677C40
	public void PopupNoticeEnd() { }

	// RVA: 0x678090 Offset: 0x676690 VA: 0x180678090
	public void UpdateItemCount(int amountAdded, int totalAmount) { }

	// RVA: 0x677FD0 Offset: 0x6765D0 VA: 0x180677FD0
	public void ScheduleTotalUpdate(int currentTotal) { }

	// RVA: 0x677F20 Offset: 0x676520 VA: 0x180677F20
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

	// RVA: 0x678620 Offset: 0x676C20 VA: 0x180678620
	protected void OnEnable() { }

	// RVA: 0x678520 Offset: 0x676B20 VA: 0x180678520
	protected void OnDisable() { }

	// RVA: 0x678200 Offset: 0x676800 VA: 0x180678200
	public Sprite GetItemSprite() { }

	// RVA: 0x6788A0 Offset: 0x676EA0 VA: 0x1806788A0 Slot: 7
	public void OnItemAmountChanged() { }

	// RVA: 0x6788C0 Offset: 0x676EC0 VA: 0x1806788C0 Slot: 8
	public void OnItemIconChanged() { }

	// RVA: 0x678750 Offset: 0x676D50 VA: 0x180678750 Slot: 6
	public void OnInventoryChanged() { }

	// RVA: 0x678990 Offset: 0x676F90 VA: 0x180678990
	private void UpdateItemIcon() { }

	// RVA: 0x6789E0 Offset: 0x676FE0 VA: 0x1806789E0
	private Item get_iconValue() { }

	// RVA: 0x6789D0 Offset: 0x676FD0 VA: 0x1806789D0
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

	// RVA: 0x679890 Offset: 0x677E90 VA: 0x180679890
	public static bool IsInputFieldOpen() { }

	// RVA: 0x679E20 Offset: 0x678420 VA: 0x180679E20
	private void Start() { }

	// RVA: 0x67A030 Offset: 0x678630 VA: 0x18067A030
	public ItemIcon.DragInfo get_dragInfo() { }

	// RVA: 0x679C00 Offset: 0x678200 VA: 0x180679C00
	public void RefreshValue() { }

	// RVA: 0x679F10 Offset: 0x678510 VA: 0x180679F10
	public void Update() { }

	// RVA: 0x6797D0 Offset: 0x677DD0 VA: 0x1806797D0
	private string FormatValueString(float value) { }

	// RVA: 0x6798F0 Offset: 0x677EF0 VA: 0x1806798F0
	private void OnAmountInputFieldValueChanged() { }

	// RVA: 0x679A60 Offset: 0x678060 VA: 0x180679A60
	public void OnSliderLeftMouseDown() { }

	// RVA: 0x679B90 Offset: 0x678190 VA: 0x180679B90
	public void OnSliderRightMouseUp() { }

	// RVA: 0x679A70 Offset: 0x678070 VA: 0x180679A70
	public void OnSliderMiddleMouseDown() { }

	// RVA: 0x679CA0 Offset: 0x6782A0 VA: 0x180679CA0
	private void SetAmountInputFieldVisible(bool flag) { }

	// RVA: 0x679810 Offset: 0x677E10 VA: 0x180679810
	public static int GetSplitAmount(int itemAmount) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6798F0 Offset: 0x677EF0 VA: 0x1806798F0
	private void <Start>b__6_0(string <p0>) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x679A60 Offset: 0x678060 VA: 0x180679A60
	private void <Start>b__6_1(string <p0>) { }

}

public class ItemSplitterDragOut : MonoBehaviour, IDraggable // TypeDefIndex: 11020
{	// Fields
	public ItemSplitter rootSplitter; // 0x18

	// Methods

	// RVA: 0x6794D0 Offset: 0x677AD0 VA: 0x1806794D0 Slot: 4
	public object GetDragData() { }

	// RVA: 0x6795B0 Offset: 0x677BB0 VA: 0x1806795B0 Slot: 5
	public string GetDragType() { }

	// RVA: 0x679570 Offset: 0x677B70 VA: 0x180679570 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemSplitterSlider : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler // TypeDefIndex: 11021
{	// Fields
	public ItemSplitter Splitter; // 0x18

	// Methods

	// RVA: 0x6795E0 Offset: 0x677BE0 VA: 0x1806795E0 Slot: 5
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x679740 Offset: 0x677D40 VA: 0x180679740 Slot: 4
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

	// RVA: 0x67A0D0 Offset: 0x6786D0 VA: 0x18067A0D0
	private void OnDisable() { }

	// RVA: 0x67A120 Offset: 0x678720 VA: 0x18067A120
	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemSubmitPanel : LootPanel // TypeDefIndex: 11023
{	// Methods

	// RVA: 0x67BED0 Offset: 0x67A4D0 VA: 0x18067BED0
	public void SubmitClicked() { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
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

	// RVA: 0x67BF60 Offset: 0x67A560 VA: 0x18067BF60
	public void SetValue(float val, int numDecimals = 0, string overrideText = "") { }

	// RVA: 0x67C180 Offset: 0x67A780 VA: 0x18067C180
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

	// RVA: 0x67AFE0 Offset: 0x6795E0 VA: 0x18067AFE0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x67B2B0 Offset: 0x6798B0 VA: 0x18067B2B0
	private void OnPurchaseFinished(AppId appid, ulong orderid, bool success) { }

	[AsyncStateMachineAttribute] // RVA: 0x96710 Offset: 0x95B10 VA: 0x180096710
	// RVA: 0x67B7A0 Offset: 0x679DA0 VA: 0x18067B7A0
	private void RefreshList() { }

	// RVA: 0x67AE30 Offset: 0x679430 VA: 0x18067AE30
	private void AddItem(IPlayerItemDefinition item) { }

	// RVA: 0x67B9E0 Offset: 0x679FE0 VA: 0x18067B9E0
	internal void ShowModal(IPlayerItemDefinition item) { }

	// RVA: 0x67AF40 Offset: 0x679540 VA: 0x18067AF40
	internal void AddToCart(IPlayerItemDefinition item) { }

	// RVA: 0x67B220 Offset: 0x679820 VA: 0x18067B220
	public void EmptyCart() { }

	// RVA: 0x67BA00 Offset: 0x67A000 VA: 0x18067BA00
	private void UpdateShoppingList() { }

	// RVA: 0x67B870 Offset: 0x679E70 VA: 0x18067B870
	public void RemoveFromCart(int index) { }

	[AsyncStateMachineAttribute] // RVA: 0x96910 Offset: 0x95D10 VA: 0x180096910
	// RVA: 0x67B150 Offset: 0x679750 VA: 0x18067B150
	public void Checkout() { }

	// RVA: 0x67B270 Offset: 0x679870 VA: 0x18067B270 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x67B8D0 Offset: 0x679ED0 VA: 0x18067B8D0 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x67BE40 Offset: 0x67A440 VA: 0x18067BE40
	public void .ctor() { }

	// RVA: 0x67BD40 Offset: 0x67A340 VA: 0x18067BD40
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

	// RVA: 0x691050 Offset: 0x68F650 VA: 0x180691050
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690DC0 Offset: 0x68F3C0 VA: 0x180690DC0
	internal int <OnPurchaseFinished>b__16_0(IPlayerItemDefinition x) { }

	// RVA: 0x690E10 Offset: 0x68F410 VA: 0x180690E10
	internal int <RefreshList>b__17_0(IPlayerItemDefinition x) { }

	// RVA: 0x690E60 Offset: 0x68F460 VA: 0x180690E60
	internal int <UpdateShoppingList>b__22_0(IPlayerItemDefinition x) { }

	// RVA: 0x690DA0 Offset: 0x68F3A0 VA: 0x180690DA0
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

	// RVA: 0x67A360 Offset: 0x678960 VA: 0x18067A360
	public void Show(ulong orderid) { }

	// RVA: 0x67A290 Offset: 0x678890 VA: 0x18067A290
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void <Hide>b__1_0() { }

}

public class ItemStoreBuySuccessModal : MonoBehaviour // TypeDefIndex: 11111
{	// Methods

	// RVA: 0x67A4F0 Offset: 0x678AF0 VA: 0x18067A4F0
	public void Show(ulong orderId) { }

	// RVA: 0x67A420 Offset: 0x678A20 VA: 0x18067A420
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void <Hide>b__1_0() { }

}

public class ItemStoreCartItem : MonoBehaviour // TypeDefIndex: 11112
{	// Fields
	public int Index; // 0x18
	public TextMeshProUGUI Name; // 0x20
	public TextMeshProUGUI Price; // 0x28

	// Methods

	// RVA: 0x67A660 Offset: 0x678C60 VA: 0x18067A660
	public void Init(int index, IPlayerItemDefinition def) { }

	// RVA: 0x67A710 Offset: 0x678D10 VA: 0x18067A710
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

	// RVA: 0x67ABF0 Offset: 0x6791F0 VA: 0x18067ABF0
	internal void Init(IPlayerItemDefinition item, bool inCart) { }

	// RVA: 0x67ADB0 Offset: 0x6793B0 VA: 0x18067ADB0
	public void ShowModal() { }

	// RVA: 0x67AB70 Offset: 0x679170 VA: 0x18067AB70
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

	// RVA: 0x67A9C0 Offset: 0x678FC0 VA: 0x18067A9C0
	public void Show(IPlayerItemDefinition item) { }

	// RVA: 0x67A7C0 Offset: 0x678DC0 VA: 0x18067A7C0
	public void AddToCart() { }

	// RVA: 0x67A8F0 Offset: 0x678EF0 VA: 0x18067A8F0
	public void Hide() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void <Hide>b__7_0() { }

}

public class ItemModEngineItem : ItemMod // TypeDefIndex: 12112
{	// Fields
	public EngineStorage.EngineItemTypes engineItemType; // 0x20
	[RangeAttribute] // RVA: 0xDBF30 Offset: 0xDB330 VA: 0x1800DBF30
	public int tier; // 0x24

	// Methods

	// RVA: 0x4BE5F0 Offset: 0x4BCBF0 VA: 0x1804BE5F0
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

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 16
	public int get_SocketsTaken() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0x4BE610 Offset: 0x4BCC10 VA: 0x1804BE610
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

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 16
	public int get_SocketsTaken() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0x4BE610 Offset: 0x4BCC10 VA: 0x1804BE610
	public void .ctor() { }

}

