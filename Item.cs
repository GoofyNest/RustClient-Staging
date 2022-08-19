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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Title>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Description>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string[] <Tags>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Dictionary<string, string> <KeyValueTags>k__BackingField; // 0xA8
	public PublishedFileId[] Children; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private UgcAdditionalPreview[] <AdditionalPreviews>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumSubscriptions>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumFavorites>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumFollowers>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumUniqueSubscriptions>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumUniqueFavorites>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumUniqueFollowers>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumUniqueWebsiteViews>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <ReportScore>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumSecondsPlayed>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumPlaytimeSessions>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumComments>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumSecondsPlayedDuringTimePeriod>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ulong <NumPlaytimeSessionsDuringTimePeriod>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <PreviewImageUrl>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x2241D0 Offset: 0x2235D0 VA: 0x1802241D0
	public void .ctor(PublishedFileId id) { }

	// RVA: 0x1D10D0 Offset: 0x1D04D0 VA: 0x1801D10D0
	public PublishedFileId get_Id() { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x2243A0 Offset: 0x2237A0 VA: 0x1802243A0
	public string get_Title() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2245E0 Offset: 0x2239E0 VA: 0x1802245E0
	internal void set_Title(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1E1460 Offset: 0x1E0860 VA: 0x1801E1460
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2244C0 Offset: 0x2238C0 VA: 0x1802244C0
	internal void set_Description(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xFD490 Offset: 0xFC890 VA: 0x1800FD490
	public string[] get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2245D0 Offset: 0x2239D0 VA: 0x1802245D0
	internal void set_Tags(string[] value) { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0xF1430 Offset: 0xF0830 VA: 0x1800F1430
	public Dictionary<string, string> get_KeyValueTags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2244D0 Offset: 0x2238D0 VA: 0x1802244D0
	internal void set_KeyValueTags(Dictionary<string, string> value) { }

	// RVA: 0x224340 Offset: 0x223740 VA: 0x180224340
	public Friend get_Owner() { }

	// RVA: 0x2243B0 Offset: 0x2237B0 VA: 0x1802243B0
	public DateTime get_Updated() { }

	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x1D1470 Offset: 0x1D0870 VA: 0x1801D1470
	public UgcAdditionalPreview[] get_AdditionalPreviews() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2244B0 Offset: 0x2238B0 VA: 0x1802244B0
	internal void set_AdditionalPreviews(UgcAdditionalPreview[] value) { }

	// RVA: 0x224300 Offset: 0x223700 VA: 0x180224300
	public bool get_IsInstalled() { }

	// RVA: 0x2242C0 Offset: 0x2236C0 VA: 0x1802242C0
	public bool get_IsDownloading() { }

	// RVA: 0x224280 Offset: 0x223680 VA: 0x180224280
	public bool get_IsDownloadPending() { }

	// RVA: 0x224210 Offset: 0x223610 VA: 0x180224210
	public string get_Directory() { }

	// RVA: 0x224000 Offset: 0x223400 VA: 0x180224000
	public bool Download(bool highPriority = False) { }

	// RVA: 0x224360 Offset: 0x223760 VA: 0x180224360
	private ItemState get_State() { }

	// RVA: 0x19D58B0 Offset: 0x19D3EB0 VA: 0x1819D58B0
	internal static Item From(SteamUGCDetails_t details) { }

	[AsyncStateMachineAttribute] // RVA: 0x9EAD0 Offset: 0x9DED0 VA: 0x18009EAD0
	// RVA: 0x224050 Offset: 0x223450 VA: 0x180224050
	public Task<Nullable<Result>> Vote(bool up) { }

	// RVA: 0x224450 Offset: 0x223850 VA: 0x180224450
	public string get_Url() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224560 Offset: 0x223960 VA: 0x180224560
	internal void set_NumSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224500 Offset: 0x223900 VA: 0x180224500
	internal void set_NumFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224510 Offset: 0x223910 VA: 0x180224510
	internal void set_NumFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224590 Offset: 0x223990 VA: 0x180224590
	internal void set_NumUniqueSubscriptions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224570 Offset: 0x223970 VA: 0x180224570
	internal void set_NumUniqueFavorites(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224580 Offset: 0x223980 VA: 0x180224580
	internal void set_NumUniqueFollowers(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2245A0 Offset: 0x2239A0 VA: 0x1802245A0
	internal void set_NumUniqueWebsiteViews(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2245C0 Offset: 0x2239C0 VA: 0x1802245C0
	internal void set_ReportScore(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224550 Offset: 0x223950 VA: 0x180224550
	internal void set_NumSecondsPlayed(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224530 Offset: 0x223930 VA: 0x180224530
	internal void set_NumPlaytimeSessions(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2244F0 Offset: 0x2238F0 VA: 0x1802244F0
	internal void set_NumComments(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224540 Offset: 0x223940 VA: 0x180224540
	internal void set_NumSecondsPlayedDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x224520 Offset: 0x223920 VA: 0x180224520
	internal void set_NumPlaytimeSessionsDuringTimePeriod(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	[IsReadOnlyAttribute] // RVA: 0x71650 Offset: 0x70A50 VA: 0x180071650
	// RVA: 0x224350 Offset: 0x223750 VA: 0x180224350
	public string get_PreviewImageUrl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2245B0 Offset: 0x2239B0 VA: 0x1802245B0
	internal void set_PreviewImageUrl(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2244E0 Offset: 0x2238E0 VA: 0x1802244E0
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

	// RVA: 0x225010 Offset: 0x224410 VA: 0x180225010 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x225020 Offset: 0x224420 VA: 0x180225020 Slot: 5
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

	// RVA: 0x1EAF70 Offset: 0x1EA370 VA: 0x1801EAF70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAF60 Offset: 0x1EA360 VA: 0x1801EAF60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1373240 Offset: 0x1371840 VA: 0x181373240
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

	// RVA: 0x1F1A800 Offset: 0x1F18E00 VA: 0x181F1A800
	public static void ResetToPool(ItemContainer instance) { }

	// RVA: 0x1F1AAE0 Offset: 0x1F190E0 VA: 0x181F1AAE0
	public void ResetToPool() { }

	// RVA: 0x1F1A740 Offset: 0x1F18D40 VA: 0x181F1A740 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F191E0 Offset: 0x1F177E0 VA: 0x181F191E0
	public void CopyTo(ItemContainer instance) { }

	// RVA: 0x1F194E0 Offset: 0x1F17AE0 VA: 0x181F194E0
	public ItemContainer Copy() { }

	// RVA: 0x1F1A5C0 Offset: 0x1F18BC0 VA: 0x181F1A5C0
	public static ItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1F19A70 Offset: 0x1F18070 VA: 0x181F19A70
	public static ItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F19AF0 Offset: 0x1F180F0 VA: 0x181F19AF0
	public static ItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1A4A0 Offset: 0x1F18AA0 VA: 0x181F1A4A0
	public static ItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1A7C0 Offset: 0x1F18DC0 VA: 0x181F1A7C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1B8F0 Offset: 0x1F19EF0 VA: 0x181F1B8F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1B910 Offset: 0x1F19F10 VA: 0x181F1B910 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemContainer previous) { }

	// RVA: 0x1F1A7E0 Offset: 0x1F18DE0 VA: 0x181F1A7E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1A640 Offset: 0x1F18C40 VA: 0x181F1A640
	public static ItemContainer Deserialize(byte[] buffer, ItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1F1A070 Offset: 0x1F18670 VA: 0x181F1A070
	public static ItemContainer Deserialize(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F19560 Offset: 0x1F17B60 VA: 0x181F19560
	public static ItemContainer DeserializeLengthDelimited(Stream stream, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F19B80 Offset: 0x1F18180 VA: 0x181F19B80
	public static ItemContainer DeserializeLength(Stream stream, int length, ItemContainer instance, bool isDelta) { }

	// RVA: 0x1F1ADC0 Offset: 0x1F193C0 VA: 0x181F1ADC0
	public static void SerializeDelta(Stream stream, ItemContainer instance, ItemContainer previous) { }

	// RVA: 0x1F1B4D0 Offset: 0x1F19AD0 VA: 0x181F1B4D0
	public static void Serialize(Stream stream, ItemContainer instance) { }

	// RVA: 0x1F1B8E0 Offset: 0x1F19EE0 VA: 0x181F1B8E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1B8F0 Offset: 0x1F19EF0 VA: 0x181F1B8F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1B3C0 Offset: 0x1F199C0 VA: 0x181F1B3C0
	public static byte[] SerializeToBytes(ItemContainer instance) { }

	// RVA: 0x1F1B310 Offset: 0x1F19910 VA: 0x181F1B310
	public static void SerializeLengthDelimited(Stream stream, ItemContainer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1C0FDB0 Offset: 0x1C0E3B0 VA: 0x181C0FDB0
	public static void ResetToPool(Item instance) { }

	// RVA: 0x1C0FFD0 Offset: 0x1C0E5D0 VA: 0x181C0FFD0
	public void ResetToPool() { }

	// RVA: 0x1C0FCF0 Offset: 0x1C0E2F0 VA: 0x181C0FCF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0E650 Offset: 0x1C0CC50 VA: 0x181C0E650
	public void CopyTo(Item instance) { }

	// RVA: 0x1C0E7A0 Offset: 0x1C0CDA0 VA: 0x181C0E7A0
	public Item Copy() { }

	// RVA: 0x1C0FB50 Offset: 0x1C0E150 VA: 0x181C0FB50
	public static Item Deserialize(Stream stream) { }

	// RVA: 0x1C0EE20 Offset: 0x1C0D420 VA: 0x181C0EE20
	public static Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0F480 Offset: 0x1C0DA80 VA: 0x181C0F480
	public static Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0FBD0 Offset: 0x1C0E1D0 VA: 0x181C0FBD0
	public static Item Deserialize(byte[] buffer) { }

	// RVA: 0x1C0FD70 Offset: 0x1C0E370 VA: 0x181C0FD70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C11170 Offset: 0x1C0F770 VA: 0x181C11170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C11190 Offset: 0x1C0F790 VA: 0x181C11190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item previous) { }

	// RVA: 0x1C0FD90 Offset: 0x1C0E390 VA: 0x181C0FD90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0FA50 Offset: 0x1C0E050 VA: 0x181C0FA50
	public static Item Deserialize(byte[] buffer, Item instance, bool isDelta = False) { }

	// RVA: 0x1C0F510 Offset: 0x1C0DB10 VA: 0x181C0F510
	public static Item Deserialize(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C0E820 Offset: 0x1C0CE20 VA: 0x181C0E820
	public static Item DeserializeLengthDelimited(Stream stream, Item instance, bool isDelta) { }

	// RVA: 0x1C0EEA0 Offset: 0x1C0D4A0 VA: 0x181C0EEA0
	public static Item DeserializeLength(Stream stream, int length, Item instance, bool isDelta) { }

	// RVA: 0x1C101F0 Offset: 0x1C0E7F0 VA: 0x181C101F0
	public static void SerializeDelta(Stream stream, Item instance, Item previous) { }

	// RVA: 0x1C10B90 Offset: 0x1C0F190 VA: 0x181C10B90
	public static void Serialize(Stream stream, Item instance) { }

	// RVA: 0x1C11160 Offset: 0x1C0F760 VA: 0x181C11160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C11170 Offset: 0x1C0F770 VA: 0x181C11170
	public void ToProto(Stream stream) { }

	// RVA: 0x1C10A80 Offset: 0x1C0F080 VA: 0x181C10A80
	public static byte[] SerializeToBytes(Item instance) { }

	// RVA: 0x1C109D0 Offset: 0x1C0EFD0 VA: 0x181C109D0
	public static void SerializeLengthDelimited(Stream stream, Item instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1F17240 Offset: 0x1F15840 VA: 0x181F17240
	public static void ResetToPool(Item.InstanceData instance) { }

	// RVA: 0x1F171A0 Offset: 0x1F157A0 VA: 0x181F171A0
	public void ResetToPool() { }

	// RVA: 0x1F16E50 Offset: 0x1F15450 VA: 0x181F16E50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C071E0 Offset: 0x1C057E0 VA: 0x181C071E0
	public void CopyTo(Item.InstanceData instance) { }

	// RVA: 0x1F15CC0 Offset: 0x1F142C0 VA: 0x181F15CC0
	public Item.InstanceData Copy() { }

	// RVA: 0x1F168F0 Offset: 0x1F14EF0 VA: 0x181F168F0
	public static Item.InstanceData Deserialize(Stream stream) { }

	// RVA: 0x1F16020 Offset: 0x1F14620 VA: 0x181F16020
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F16360 Offset: 0x1F14960 VA: 0x181F16360
	public static Item.InstanceData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F16B40 Offset: 0x1F15140 VA: 0x181F16B40
	public static Item.InstanceData Deserialize(byte[] buffer) { }

	// RVA: 0x1F16F70 Offset: 0x1F15570 VA: 0x181F16F70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F17820 Offset: 0x1F15E20 VA: 0x181F17820 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F17840 Offset: 0x1F15E40 VA: 0x181F17840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.InstanceData previous) { }

	// RVA: 0x1F17180 Offset: 0x1F15780 VA: 0x181F17180 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F16600 Offset: 0x1F14C00 VA: 0x181F16600
	public static Item.InstanceData Deserialize(byte[] buffer, Item.InstanceData instance, bool isDelta = False) { }

	// RVA: 0x1F163F0 Offset: 0x1F149F0 VA: 0x181F163F0
	public static Item.InstanceData Deserialize(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F15D40 Offset: 0x1F14340 VA: 0x181F15D40
	public static Item.InstanceData DeserializeLengthDelimited(Stream stream, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F160A0 Offset: 0x1F146A0 VA: 0x181F160A0
	public static Item.InstanceData DeserializeLength(Stream stream, int length, Item.InstanceData instance, bool isDelta) { }

	// RVA: 0x1F172E0 Offset: 0x1F158E0 VA: 0x181F172E0
	public static void SerializeDelta(Stream stream, Item.InstanceData instance, Item.InstanceData previous) { }

	// RVA: 0x1F176C0 Offset: 0x1F15CC0 VA: 0x181F176C0
	public static void Serialize(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x1F17810 Offset: 0x1F15E10 VA: 0x181F17810
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F17820 Offset: 0x1F15E20 VA: 0x181F17820
	public void ToProto(Stream stream) { }

	// RVA: 0x1F175B0 Offset: 0x1F15BB0 VA: 0x181F175B0
	public static byte[] SerializeToBytes(Item.InstanceData instance) { }

	// RVA: 0x1F17500 Offset: 0x1F15B00 VA: 0x181F17500
	public static void SerializeLengthDelimited(Stream stream, Item.InstanceData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class Item.ConditionData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6442
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float condition; // 0x14
	public float maxCondition; // 0x18

	// Methods

	// RVA: 0x1F155C0 Offset: 0x1F13BC0 VA: 0x181F155C0
	public static void ResetToPool(Item.ConditionData instance) { }

	// RVA: 0x1F15640 Offset: 0x1F13C40 VA: 0x181F15640
	public void ResetToPool() { }

	// RVA: 0x1F15320 Offset: 0x1F13920 VA: 0x181F15320 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DBEAA0 Offset: 0x1DBD0A0 VA: 0x181DBEAA0
	public void CopyTo(Item.ConditionData instance) { }

	// RVA: 0x1F14520 Offset: 0x1F12B20 VA: 0x181F14520
	public Item.ConditionData Copy() { }

	// RVA: 0x1F14B20 Offset: 0x1F13120 VA: 0x181F14B20
	public static Item.ConditionData Deserialize(Stream stream) { }

	// RVA: 0x1F14590 Offset: 0x1F12B90 VA: 0x181F14590
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F14860 Offset: 0x1F12E60 VA: 0x181F14860
	public static Item.ConditionData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F14CE0 Offset: 0x1F132E0 VA: 0x181F14CE0
	public static Item.ConditionData Deserialize(byte[] buffer) { }

	// RVA: 0x1F15420 Offset: 0x1F13A20 VA: 0x181F15420
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F15B10 Offset: 0x1F14110 VA: 0x181F15B10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F15B30 Offset: 0x1F14130 VA: 0x181F15B30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Item.ConditionData previous) { }

	// RVA: 0x1F155A0 Offset: 0x1F13BA0 VA: 0x181F155A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F14F50 Offset: 0x1F13550 VA: 0x181F14F50
	public static Item.ConditionData Deserialize(byte[] buffer, Item.ConditionData instance, bool isDelta = False) { }

	// RVA: 0x1F151A0 Offset: 0x1F137A0 VA: 0x181F151A0
	public static Item.ConditionData Deserialize(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F14610 Offset: 0x1F12C10 VA: 0x181F14610
	public static Item.ConditionData DeserializeLengthDelimited(Stream stream, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F148F0 Offset: 0x1F12EF0 VA: 0x181F148F0
	public static Item.ConditionData DeserializeLength(Stream stream, int length, Item.ConditionData instance, bool isDelta) { }

	// RVA: 0x1F156C0 Offset: 0x1F13CC0 VA: 0x181F156C0
	public static void SerializeDelta(Stream stream, Item.ConditionData instance, Item.ConditionData previous) { }

	// RVA: 0x1F15A00 Offset: 0x1F14000 VA: 0x181F15A00
	public static void Serialize(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x1F15B00 Offset: 0x1F14100 VA: 0x181F15B00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F15B10 Offset: 0x1F14110 VA: 0x181F15B10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F158F0 Offset: 0x1F13EF0 VA: 0x181F158F0
	public static byte[] SerializeToBytes(Item.ConditionData instance) { }

	// RVA: 0x1F15840 Offset: 0x1F13E40 VA: 0x181F15840
	public static void SerializeLengthDelimited(Stream stream, Item.ConditionData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class ItemAmountList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6506
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> itemID; // 0x18
	public List<float> amount; // 0x20

	// Methods

	// RVA: 0x1F18A80 Offset: 0x1F17080 VA: 0x181F18A80
	public static void ResetToPool(ItemAmountList instance) { }

	// RVA: 0x1F18930 Offset: 0x1F16F30 VA: 0x181F18930
	public void ResetToPool() { }

	// RVA: 0x1F18730 Offset: 0x1F16D30 VA: 0x181F18730 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F17860 Offset: 0x1F15E60 VA: 0x181F17860
	public void CopyTo(ItemAmountList instance) { }

	// RVA: 0x1F17A60 Offset: 0x1F16060 VA: 0x181F17A60
	public ItemAmountList Copy() { }

	// RVA: 0x1F18340 Offset: 0x1F16940 VA: 0x181F18340
	public static ItemAmountList Deserialize(Stream stream) { }

	// RVA: 0x1F17AE0 Offset: 0x1F160E0 VA: 0x181F17AE0
	public static ItemAmountList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F17E90 Offset: 0x1F16490 VA: 0x181F17E90
	public static ItemAmountList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F18610 Offset: 0x1F16C10 VA: 0x181F18610
	public static ItemAmountList Deserialize(byte[] buffer) { }

	// RVA: 0x1F188F0 Offset: 0x1F16EF0 VA: 0x181F188F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F191A0 Offset: 0x1F177A0 VA: 0x181F191A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F191C0 Offset: 0x1F177C0 VA: 0x181F191C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ItemAmountList previous) { }

	// RVA: 0x1F18910 Offset: 0x1F16F10 VA: 0x181F18910 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F18240 Offset: 0x1F16840 VA: 0x181F18240
	public static ItemAmountList Deserialize(byte[] buffer, ItemAmountList instance, bool isDelta = False) { }

	// RVA: 0x1F183C0 Offset: 0x1F169C0 VA: 0x181F183C0
	public static ItemAmountList Deserialize(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F17B60 Offset: 0x1F16160 VA: 0x181F17B60
	public static ItemAmountList DeserializeLengthDelimited(Stream stream, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F17F20 Offset: 0x1F16520 VA: 0x181F17F20
	public static ItemAmountList DeserializeLength(Stream stream, int length, ItemAmountList instance, bool isDelta) { }

	// RVA: 0x1F18BD0 Offset: 0x1F171D0 VA: 0x181F18BD0
	public static void SerializeDelta(Stream stream, ItemAmountList instance, ItemAmountList previous) { }

	// RVA: 0x1F18F90 Offset: 0x1F17590 VA: 0x181F18F90
	public static void Serialize(Stream stream, ItemAmountList instance) { }

	// RVA: 0x1F19190 Offset: 0x1F17790 VA: 0x181F19190
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F191A0 Offset: 0x1F177A0 VA: 0x181F191A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F18E80 Offset: 0x1F17480 VA: 0x181F18E80
	public static byte[] SerializeToBytes(ItemAmountList instance) { }

	// RVA: 0x1F18DD0 Offset: 0x1F173D0 VA: 0x181F18DD0
	public static void SerializeLengthDelimited(Stream stream, ItemAmountList instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[JsonIgnoreAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public double Price { get; }

	// Methods

	// RVA: 0xE73FB0 Offset: 0xE725B0 VA: 0x180E73FB0
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

	// RVA: 0xA260C0 Offset: 0xA246C0 VA: 0x180A260C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA26580 Offset: 0xA24B80 VA: 0x180A26580 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA263F0 Offset: 0xA249F0 VA: 0x180A263F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Description] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.Icon] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	[BaseEntity.Menu.ShowIf] // RVA: 0x8E020 Offset: 0x8D420 VA: 0x18008E020
	// RVA: 0xA263B0 Offset: 0xA249B0 VA: 0x180A263B0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xA26610 Offset: 0xA24C10 VA: 0x180A26610 Slot: 159
	public SoundDefinition get_OpenSound() { }

	// RVA: 0xA26570 Offset: 0xA24B70 VA: 0x180A26570 Slot: 160
	public SoundDefinition get_CloseSound() { }

	// RVA: 0xA264E0 Offset: 0xA24AE0 VA: 0x180A264E0
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

	// RVA: 0xA32F10 Offset: 0xA31510 VA: 0x180A32F10 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA33020 Offset: 0xA31620 VA: 0x180A33020
	public void .ctor() { }

}

public class ItemModOpenLootBag : ItemModUnwrap // TypeDefIndex: 8793
{	// Methods

	// RVA: 0xA33880 Offset: 0xA31E80 VA: 0x180A33880 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA33020 Offset: 0xA31620 VA: 0x180A33020
	public void .ctor() { }

}

public class ItemModPhoto : ItemModAssociatedEntity<PhotoEntity> // TypeDefIndex: 8814
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA34220 Offset: 0xA32820 VA: 0x180A34220
	public void .ctor() { }

}

public class ItemModUnwrap : ItemMod // TypeDefIndex: 8823
{	// Fields
	public LootSpawn revealList; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int minTries; // 0x30
	public int maxTries; // 0x34

	// Methods

	// RVA: 0xA35350 Offset: 0xA33950 VA: 0x180A35350 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA33020 Offset: 0xA31620 VA: 0x180A33020
	public void .ctor() { }

}

public class ItemModOpenWrapped : ItemMod // TypeDefIndex: 8829
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public static Translate.Phrase open_wrapped_gift; // 0x0
	public static Translate.Phrase open_wrapped_gift_desc; // 0x8

	// Methods

	// RVA: 0xA33990 Offset: 0xA31F90 VA: 0x180A33990 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xA33AF0 Offset: 0xA320F0 VA: 0x180A33AF0
	private static void .cctor() { }

}

public class ItemModWrap : ItemMod // TypeDefIndex: 8830
{	// Fields
	public GameObjectRef successEffect; // 0x20
	public ItemDefinition wrappedDefinition; // 0x28
	public static Translate.Phrase wrap_gift; // 0x0
	public static Translate.Phrase wrap_gift_desc; // 0x8

	// Methods

	// RVA: 0xA366C0 Offset: 0xA34CC0 VA: 0x180A366C0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0xA36850 Offset: 0xA34E50 VA: 0x180A36850
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

	// RVA: 0xA347E0 Offset: 0xA32DE0 VA: 0x180A347E0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA34620 Offset: 0xA32C20 VA: 0x180A34620
	public void ConfigureClicked(BasePlayer player) { }

	// RVA: 0xA34C50 Offset: 0xA33250 VA: 0x180A34C50
	public void .ctor() { }

}

public class ItemButtonTools : MonoBehaviour // TypeDefIndex: 9282
{	// Fields
	public Image image; // 0x18
	public ItemDefinition itemDef; // 0x20

	// Methods

	// RVA: 0xA26D30 Offset: 0xA25330 VA: 0x180A26D30
	public void GiveSelf(int amount) { }

	// RVA: 0xA26C10 Offset: 0xA25210 VA: 0x180A26C10
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

	// RVA: 0xA2FF00 Offset: 0xA2E500 VA: 0x180A2FF00
	public void OnPanelOpened() { }

	// RVA: 0xA2FED0 Offset: 0xA2E4D0 VA: 0x180A2FED0
	private void OnOpenDevTools() { }

	// RVA: 0xA2F800 Offset: 0xA2DE00 VA: 0x180A2F800
	private void CacheAllItems() { }

	// RVA: 0xA30720 Offset: 0xA2ED20 VA: 0x180A30720
	public void Refresh() { }

	// RVA: 0xA30090 Offset: 0xA2E690 VA: 0x180A30090
	private void RebuildCategories() { }

	// RVA: 0xA30730 Offset: 0xA2ED30 VA: 0x180A30730
	private void SwitchItemCategory(ItemDefinition[] defs) { }

	// RVA: 0xA2F950 Offset: 0xA2DF50 VA: 0x180A2F950
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

	// RVA: 0xA3B240 Offset: 0xA39840 VA: 0x180A3B240
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA39CD0 Offset: 0xA382D0 VA: 0x180A39CD0
	internal string <CacheAllItems>b__8_0(ItemDefinition x) { }

	// RVA: 0xA39F80 Offset: 0xA38580 VA: 0x180A39F80
	internal ItemCategory <RebuildCategories>b__10_0(ItemDefinition x) { }

	// RVA: 0xA39FA0 Offset: 0xA385A0 VA: 0x180A39FA0
	internal ItemCategory <RebuildCategories>b__10_1(IGrouping<ItemCategory, ItemDefinition> x) { }

	// RVA: 0xA39CD0 Offset: 0xA382D0 VA: 0x180A39CD0
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

	// RVA: 0xA3A170 Offset: 0xA38770 VA: 0x180A3A170
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

	// RVA: 0xA31DD0 Offset: 0xA303D0 VA: 0x180A31DD0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA31FE0 Offset: 0xA305E0 VA: 0x180A31FE0
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

	// RVA: 0xA32280 Offset: 0xA30880 VA: 0x180A32280
	public void .ctor() { }

}

public class ItemModSign : ItemModAssociatedEntity<SignContent> // TypeDefIndex: 9514
{	// Properties
	protected override bool AllowNullParenting { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	protected override bool get_AllowNullParenting() { }

	// RVA: 0xA35290 Offset: 0xA33890 VA: 0x180A35290
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

	// RVA: 0xA29810 Offset: 0xA27E10 VA: 0x180A29810
	public void .ctor() { }

}

public class ItemCrafter : EntityComponent<BasePlayer> // TypeDefIndex: 10104
{	// Fields
	public List<ItemContainer> containers; // 0x20
	public LinkedList<ItemCraftTask> queue; // 0x28
	public int taskUID; // 0x30

	// Methods

	// RVA: 0xA29830 Offset: 0xA27E30 VA: 0x180A29830
	public void AddContainer(ItemContainer container) { }

	// RVA: 0xA29EB0 Offset: 0xA284B0 VA: 0x180A29EB0
	public static float GetScaledDuration(ItemBlueprint bp, float workbenchLevel) { }

	// RVA: 0xA29D50 Offset: 0xA28350 VA: 0x180A29D50
	private bool DoesHaveUsableItem(int item, int iAmount) { }

	// RVA: 0xA29890 Offset: 0xA27E90 VA: 0x180A29890
	public bool CanCraft(ItemBlueprint bp, int amount = 1, bool free = False) { }

	// RVA: 0xA29CC0 Offset: 0xA282C0 VA: 0x180A29CC0
	public bool CanCraft(ItemDefinition def, int amount = 1, bool free = False) { }

	// RVA: 0xA29F10 Offset: 0xA28510 VA: 0x180A29F10
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

	// RVA: 0xA2AEA0 Offset: 0xA294A0 VA: 0x180A2AEA0 Slot: 5
	public virtual void OnItemUpdate(Item item) { }

	// RVA: 0xA2AF00 Offset: 0xA29500 VA: 0x180A2AF00
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xA38410 Offset: 0xA36A10 VA: 0x180A38410
	public void UpdateAmountDisplay(Text text) { }

	// RVA: 0xA38490 Offset: 0xA36A90 VA: 0x180A38490
	public static void UpdateAmountDisplay(Text text, Item item, Nullable<int> amountOverride, ItemDefinition infoOverride) { }

	// RVA: 0xA36ED0 Offset: 0xA354D0 VA: 0x180A36ED0
	private static string FormatAmount(ItemDefinition.AmountType type, int amount) { }

	// RVA: 0xA393E0 Offset: 0xA379E0 VA: 0x180A393E0
	public void set_condition(float value) { }

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_condition() { }

	// RVA: 0xA39460 Offset: 0xA37A60 VA: 0x180A39460
	public void set_maxCondition(float value) { }

	// RVA: 0x774680 Offset: 0x772C80 VA: 0x180774680
	public float get_maxCondition() { }

	// RVA: 0xA39190 Offset: 0xA37790 VA: 0x180A39190
	public float get_maxConditionNormalized() { }

	// RVA: 0xA38D20 Offset: 0xA37320 VA: 0x180A38D20
	public float get_conditionNormalized() { }

	// RVA: 0xA39340 Offset: 0xA37940 VA: 0x180A39340
	public void set_conditionNormalized(float value) { }

	// RVA: 0xA38E20 Offset: 0xA37420 VA: 0x180A38E20
	public bool get_hasCondition() { }

	// RVA: 0xA39060 Offset: 0xA37660 VA: 0x180A39060
	public bool get_isBroken() { }

	// RVA: 0xA38D60 Offset: 0xA37360 VA: 0x180A38D60
	public int get_despawnMultiplier() { }

	// RVA: 0xA38CF0 Offset: 0xA372F0 VA: 0x180A38CF0
	public ItemDefinition get_blueprintTargetDef() { }

	// RVA: 0xA38D10 Offset: 0xA37310 VA: 0x180A38D10
	public int get_blueprintTarget() { }

	// RVA: 0xA392B0 Offset: 0xA378B0 VA: 0x180A392B0
	public void set_blueprintTarget(int value) { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public int get_blueprintAmount() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	public void set_blueprintAmount(int value) { }

	// RVA: 0xA37400 Offset: 0xA35A00 VA: 0x180A37400
	public bool IsBlueprint() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA38C20 Offset: 0xA37220 VA: 0x180A38C20
	public void add_OnDirty(Action<Item> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA39200 Offset: 0xA37800 VA: 0x180A39200
	public void remove_OnDirty(Action<Item> value) { }

	// RVA: 0xA373F0 Offset: 0xA359F0 VA: 0x180A373F0
	public bool HasFlag(Item.Flag f) { }

	// RVA: 0xA37F10 Offset: 0xA36510 VA: 0x180A37F10
	public void SetFlag(Item.Flag f, bool b) { }

	// RVA: 0xA37630 Offset: 0xA35C30 VA: 0x180A37630
	public bool IsOn() { }

	// RVA: 0xA37620 Offset: 0xA35C20 VA: 0x180A37620
	public bool IsOnFire() { }

	// RVA: 0xA375E0 Offset: 0xA35BE0 VA: 0x180A375E0
	public bool IsCooking() { }

	// RVA: 0xA375F0 Offset: 0xA35BF0 VA: 0x180A375F0
	public bool IsLocked() { }

	// RVA: 0xA391C0 Offset: 0xA377C0 VA: 0x180A391C0
	public Item get_parentItem() { }

	// RVA: 0xA37A60 Offset: 0xA36060 VA: 0x180A37A60
	public void MarkDirty() { }

	// RVA: 0xA37B50 Offset: 0xA36150 VA: 0x180A37B50
	public void OnChanged() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CollectedForCrafting(BasePlayer crafter) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void ReturnedFromCancelledCraft(BasePlayer crafter) { }

	// RVA: 0xA37450 Offset: 0xA35A50 VA: 0x180A37450
	public bool IsChildContainer(ItemContainer c) { }

	// RVA: 0xA37420 Offset: 0xA35A20 VA: 0x180A37420
	public bool IsBusy() { }

	// RVA: 0xA36A80 Offset: 0xA35080 VA: 0x180A36A80
	public void BusyFor(float fTime) { }

	// RVA: 0xA37D00 Offset: 0xA36300 VA: 0x180A37D00
	public void Remove(float fTime = 0) { }

	// RVA: 0xA36D30 Offset: 0xA35330 VA: 0x180A36D30
	internal void DoRemove() { }

	// RVA: 0xA380A0 Offset: 0xA366A0 VA: 0x180A380A0
	public void SwitchOnOff(bool bNewState) { }

	// RVA: 0xA379E0 Offset: 0xA35FE0 VA: 0x180A379E0
	public void LockUnlock(bool bNewState) { }

	// RVA: 0xA391E0 Offset: 0xA377E0 VA: 0x180A391E0
	public float get_temperature() { }

	// RVA: 0xA37200 Offset: 0xA35800 VA: 0x180A37200
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA36AB0 Offset: 0xA350B0 VA: 0x180A36AB0
	public bool CanBeHeld() { }

	// RVA: 0xA36AF0 Offset: 0xA350F0 VA: 0x180A36AF0
	public bool CanStack(Item item) { }

	// RVA: 0xA37640 Offset: 0xA35C40 VA: 0x180A37640
	public bool IsValid() { }

	// RVA: 0xA37F30 Offset: 0xA36530 VA: 0x180A37F30
	public void SetWorldEntity(BaseEntity ent) { }

	// RVA: 0xA37C70 Offset: 0xA36270 VA: 0x180A37C70
	public void OnMovedToWorld() { }

	// RVA: 0xA372B0 Offset: 0xA358B0 VA: 0x180A372B0
	public BaseEntity GetWorldEntity() { }

	// RVA: 0xA371E0 Offset: 0xA357E0 VA: 0x180A371E0
	public BaseEntity GetHeldEntity() { }

	// RVA: 0xA369E0 Offset: 0xA34FE0 VA: 0x180A369E0
	public bool BeltBarSelect(BasePlayer player) { }

	// RVA: 0xA37220 Offset: 0xA35820 VA: 0x180A37220 Slot: 4
	public virtual int GetTotalUISlots() { }

	// RVA: 0xA37150 Offset: 0xA35750 VA: 0x180A37150 Slot: 5
	public virtual int GetFilledUISlots() { }

	// RVA: 0xA372D0 Offset: 0xA358D0 VA: 0x180A372D0
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA36D80 Offset: 0xA35380 VA: 0x180A36D80
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA37030 Offset: 0xA35630 VA: 0x180A37030
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA38120 Offset: 0xA36720 VA: 0x180A38120 Slot: 3
	public override string ToString() { }

	// RVA: 0xA36EB0 Offset: 0xA354B0 VA: 0x180A36EB0
	public Item FindItem(uint iUID) { }

	// RVA: 0xA37AC0 Offset: 0xA360C0 VA: 0x180A37AC0
	public int MaxStackable() { }

	// RVA: 0xA38EC0 Offset: 0xA374C0 VA: 0x180A38EC0
	internal Sprite get_iconSprite() { }

	// RVA: 0xA39090 Offset: 0xA37690 VA: 0x180A39090
	internal bool get_isLoadingIconSprite() { }

	// RVA: 0xA38CC0 Offset: 0xA372C0 VA: 0x180A38CC0
	public BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0xA37D60 Offset: 0xA36360 VA: 0x180A37D60 Slot: 6
	public virtual Item Save(bool bIncludeContainer = False, bool bIncludeOwners = True) { }

	// RVA: 0xA37650 Offset: 0xA35C50 VA: 0x180A37650 Slot: 7
	public virtual void Load(Item load) { }

	// RVA: 0xA38C00 Offset: 0xA37200 VA: 0x180A38C00
	public void .ctor() { }

	// RVA: 0xA38B10 Offset: 0xA37110 VA: 0x180A38B10
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA38400 Offset: 0xA36A00 VA: 0x180A38400
	private bool <get_iconSprite>b__95_0(ItemSkinDirectory.Skin x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA38400 Offset: 0xA36A00 VA: 0x180A38400
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

	// RVA: 0xA3B1E0 Offset: 0xA397E0 VA: 0x180A3B1E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA39FF0 Offset: 0xA385F0 VA: 0x180A39FF0
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

	// RVA: 0xA28350 Offset: 0xA26950 VA: 0x180A28350
	public bool HasFlag(ItemContainer.Flag f) { }

	// RVA: 0xA29400 Offset: 0xA27A00 VA: 0x180A29400
	public void SetFlag(ItemContainer.Flag f, bool b) { }

	// RVA: 0xA28520 Offset: 0xA26B20 VA: 0x180A28520
	public bool IsLocked() { }

	// RVA: 0xA29040 Offset: 0xA27640 VA: 0x180A29040
	public bool PlayerItemInputBlocked() { }

	// RVA: 0xA297F0 Offset: 0xA27DF0 VA: 0x180A297F0
	public bool get_HasLimitedAllowedItems() { }

	// RVA: 0xA28FA0 Offset: 0xA275A0 VA: 0x180A28FA0
	public void OnChanged() { }

	// RVA: 0xA27480 Offset: 0xA25A80 VA: 0x180A27480
	public void ClientInitialize(Item parentItem, int iMaxCapacity) { }

	// RVA: 0xA27A30 Offset: 0xA26030 VA: 0x180A27A30
	public Item FindItemByUID(uint iUID) { }

	// RVA: 0xA284D0 Offset: 0xA26AD0 VA: 0x180A284D0
	public bool IsFull() { }

	// RVA: 0xA28490 Offset: 0xA26A90 VA: 0x180A28490
	public bool IsEmpty() { }

	// RVA: 0xA27350 Offset: 0xA25950 VA: 0x180A27350
	public bool CanAccept(Item item) { }

	// RVA: 0xA27FF0 Offset: 0xA265F0 VA: 0x180A27FF0
	public int GetMaxTransferAmount(ItemDefinition def) { }

	// RVA: 0xA29420 Offset: 0xA27A20 VA: 0x180A29420
	public void SetOnlyAllowedItem(ItemDefinition def) { }

	// RVA: 0xA294E0 Offset: 0xA27AE0 VA: 0x180A294E0
	public void SetOnlyAllowedItems(ItemDefinition[] defs) { }

	// RVA: 0xA28360 Offset: 0xA26960 VA: 0x180A28360
	internal bool Insert(Item item) { }

	// RVA: 0xA29670 Offset: 0xA27C70 VA: 0x180A29670
	public bool SlotTaken(Item item, int i) { }

	// RVA: 0xA281B0 Offset: 0xA267B0 VA: 0x180A281B0
	public Item GetSlot(int slot) { }

	// RVA: 0xA27D20 Offset: 0xA26320 VA: 0x180A27D20
	internal bool FindPosition(Item item) { }

	// RVA: 0xA273A0 Offset: 0xA259A0 VA: 0x180A273A0
	internal void Clear() { }

	// RVA: 0xA28530 Offset: 0xA26B30 VA: 0x180A28530
	public void Kill() { }

	// RVA: 0xA27E70 Offset: 0xA26470 VA: 0x180A27E70
	public int GetAmount(int itemid, bool onlyUsableAmounts) { }

	// RVA: 0xA278C0 Offset: 0xA25EC0 VA: 0x180A278C0
	public Item FindItemByItemID(int itemid) { }

	// RVA: 0xA27BD0 Offset: 0xA261D0 VA: 0x180A27BD0
	public Item FindItemsByItemName(string name) { }

	// RVA: 0xA27660 Offset: 0xA25C60 VA: 0x180A27660
	public Item FindBySubEntityID(uint subEntityID) { }

	// RVA: 0xA27B20 Offset: 0xA26120 VA: 0x180A27B20
	public List<Item> FindItemsByItemID(int itemid) { }

	// RVA: 0xA29050 Offset: 0xA27650 VA: 0x180A29050
	public ItemContainer Save() { }

	// RVA: 0xA287F0 Offset: 0xA26DF0 VA: 0x180A287F0
	public void Load(ItemContainer container) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0xA274C0 Offset: 0xA25AC0 VA: 0x180A274C0
	public int ContainerMaxStackSize() { }

	// RVA: 0xA275A0 Offset: 0xA25BA0 VA: 0x180A275A0
	public void FindAmmo(List<Item> list, AmmoTypes ammoType) { }

	// RVA: 0xA28280 Offset: 0xA26880 VA: 0x180A28280
	public bool HasAmmo(AmmoTypes ammoType) { }

	// RVA: 0xA27DB0 Offset: 0xA263B0 VA: 0x180A27DB0
	public int GetAmmoAmount(AmmoTypes ammoType) { }

	// RVA: 0xA29690 Offset: 0xA27C90 VA: 0x180A29690
	public int TotalItemAmount() { }

	// RVA: 0xA274D0 Offset: 0xA25AD0 VA: 0x180A274D0
	public uint ContentsHash() { }

	// RVA: 0xA277D0 Offset: 0xA25DD0 VA: 0x180A277D0
	internal ItemContainer FindContainer(uint id) { }

	// RVA: 0xA26EE0 Offset: 0xA254E0 VA: 0x180A26EE0
	public ItemContainer.CanAcceptResult CanAcceptItem(Item item, int targetPos) { }

	// RVA: 0xA29740 Offset: 0xA27D40 VA: 0x180A29740
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

	// RVA: 0xA3A320 Offset: 0xA38920 VA: 0x180A3A320
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
	[HeaderAttribute] // RVA: 0xB62E0 Offset: 0xB56E0 VA: 0x1800B62E0
	public int workbenchLevelRequired; // 0x30
	[HeaderAttribute] // RVA: 0xB6440 Offset: 0xB5840 VA: 0x1800B6440
	public int scrapRequired; // 0x34
	public int scrapFromRecycle; // 0x38
	[HeaderAttribute] // RVA: 0xB6670 Offset: 0xB5A70 VA: 0x1800B6670
	[TooltipAttribute] // RVA: 0xB6670 Offset: 0xB5A70 VA: 0x1800B6670
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

	// RVA: 0xA26BD0 Offset: 0xA251D0 VA: 0x180A26BD0
	public ItemDefinition get_targetItem() { }

	// RVA: 0xA26B40 Offset: 0xA25140 VA: 0x180A26B40
	public bool get_NeedsSteamDLC() { }

	// RVA: 0xA26620 Offset: 0xA24C20 VA: 0x180A26620
	public string GetIngredientString(bool colorMissing) { }

	// RVA: 0xA26A80 Offset: 0xA25080 VA: 0x180A26A80
	public void .ctor() { }

}

public class ItemDefinition : MonoBehaviour // TypeDefIndex: 10117
{	// Fields
	[HeaderAttribute] // RVA: 0xB6800 Offset: 0xB5C00 VA: 0x1800B6800
	[ReadOnlyAttribute] // RVA: 0xB6800 Offset: 0xB5C00 VA: 0x1800B6800
	public int itemid; // 0x18
	[TooltipAttribute] // RVA: 0xB68D0 Offset: 0xB5CD0 VA: 0x1800B68D0
	public string shortname; // 0x20
	[HeaderAttribute] // RVA: 0xB6A40 Offset: 0xB5E40 VA: 0x1800B6A40
	public Translate.Phrase displayName; // 0x28
	public Translate.Phrase displayDescription; // 0x30
	public Sprite iconSprite; // 0x38
	public ItemCategory category; // 0x40
	public ItemSelectionPanel selectionPanel; // 0x44
	[HeaderAttribute] // RVA: 0xB6B40 Offset: 0xB5F40 VA: 0x1800B6B40
	public int maxDraggable; // 0x48
	public ItemContainer.ContentsType itemType; // 0x4C
	public ItemDefinition.AmountType amountType; // 0x50
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public ItemSlot occupySlots; // 0x54
	public int stackable; // 0x58
	public bool quickDespawn; // 0x5C
	[HeaderAttribute] // RVA: 0xB6D60 Offset: 0xB6160 VA: 0x1800B6D60
	[TooltipAttribute] // RVA: 0xB6D60 Offset: 0xB6160 VA: 0x1800B6D60
	public Rarity rarity; // 0x60
	public bool spawnAsBlueprint; // 0x64
	[HeaderAttribute] // RVA: 0xA9FF0 Offset: 0xA93F0 VA: 0x1800A9FF0
	public SoundDefinition inventorySelectSound; // 0x68
	public SoundDefinition inventoryGrabSound; // 0x70
	public SoundDefinition inventoryDropSound; // 0x78
	public SoundDefinition physImpactSoundDef; // 0x80
	public ItemDefinition.Condition condition; // 0x88
	[HeaderAttribute] // RVA: 0x71E00 Offset: 0x71200 VA: 0x180071E00
	public bool hidden; // 0xA0
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public ItemDefinition.Flag flags; // 0xA4
	[TooltipAttribute] // RVA: 0x7B630 Offset: 0x7AA30 VA: 0x18007B630
	public SteamInventoryItem steamItem; // 0xA8
	[TooltipAttribute] // RVA: 0x7B760 Offset: 0x7AB60 VA: 0x18007B760
	public SteamDLCItem steamDlc; // 0xB0
	[TooltipAttribute] // RVA: 0xB7340 Offset: 0xB6740 VA: 0x1800B7340
	public ItemDefinition Parent; // 0xB8
	public GameObjectRef worldModelPrefab; // 0xC0
	public ItemDefinition isRedirectOf; // 0xC8
	public ItemDefinition.RedirectVendingBehaviour redirectVendingBehaviour; // 0xD0
	public ItemMod[] itemMods; // 0xD8
	public BaseEntity.TraitFlag Traits; // 0xE0
	public ItemSkinDirectory.Skin[] skins; // 0xE8
	private IPlayerItemDefinition[] _skins2; // 0xF0
	[TooltipAttribute] // RVA: 0xB8710 Offset: 0xB7B10 VA: 0x1800B8710
	public GameObject panel; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ItemModWearable <ItemModWearable>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <isHoldable>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <isUsable>k__BackingField; // 0x109
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xA2AA10 Offset: 0xA29010 VA: 0x180A2AA10
	public IPlayerItemDefinition[] get_skins2() { }

	// RVA: 0xA2A760 Offset: 0xA28D60 VA: 0x180A2A760
	public void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA2A870 Offset: 0xA28E70 VA: 0x180A2A870
	public ItemBlueprint get_Blueprint() { }

	// RVA: 0xA2A930 Offset: 0xA28F30 VA: 0x180A2A930
	public int get_craftingStackable() { }

	// RVA: 0xA2A4E0 Offset: 0xA28AE0 VA: 0x180A2A4E0
	public bool HasFlag(ItemDefinition.Flag f) { }

	// RVA: 0xA2A4F0 Offset: 0xA28AF0 VA: 0x180A2A4F0
	public void Initialize(List<ItemDefinition> itemList) { }

	// RVA: 0xA2A3E0 Offset: 0xA289E0 VA: 0x180A2A3E0 Slot: 4
	public virtual string GetDisplayName(Item item) { }

	// RVA: 0xA2A310 Offset: 0xA28910 VA: 0x180A2A310 Slot: 5
	public virtual string GetDescriptionText(Item item) { }

	// RVA: 0xA2A3A0 Offset: 0xA289A0 VA: 0x180A2A3A0 Slot: 6
	public virtual string GetDescriptionText() { }

	// RVA: 0xA29FB0 Offset: 0xA285B0 VA: 0x180A29FB0
	public Sprite FindIconSprite(int skinid) { }

	// RVA: 0xA2A9B0 Offset: 0xA28FB0 VA: 0x180A2A9B0
	public bool get_isWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2A920 Offset: 0xA28F20 VA: 0x180A2A920
	public ItemModWearable get_ItemModWearable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2AC20 Offset: 0xA29220 VA: 0x180A2AC20
	private void set_ItemModWearable(ItemModWearable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2A990 Offset: 0xA28F90 VA: 0x180A2A990
	public bool get_isHoldable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2AC30 Offset: 0xA29230 VA: 0x180A2AC30
	private void set_isHoldable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2A9A0 Offset: 0xA28FA0 VA: 0x180A2A9A0
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2AC40 Offset: 0xA29240 VA: 0x180A2AC40
	private void set_isUsable(bool value) { }

	// RVA: 0xA2A8C0 Offset: 0xA28EC0 VA: 0x180A2A8C0
	public bool get_HasSkins() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2A8B0 Offset: 0xA28EB0 VA: 0x180A2A8B0
	public bool get_CraftableWithSkin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2AC10 Offset: 0xA29210 VA: 0x180A2AC10
	private void set_CraftableWithSkin(bool value) { }

	// RVA: 0xA2A800 Offset: 0xA28E00 VA: 0x180A2A800
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2A780 Offset: 0xA28D80 VA: 0x180A2A780
	private bool <Initialize>b__45_0(ItemDefinition x) { }

}

public struct ItemDefinition.Condition // TypeDefIndex: 10118
{	// Fields
	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xB8F60 Offset: 0xB8360 VA: 0x1800B8F60
	public float max; // 0x4
	[TooltipAttribute] // RVA: 0xB90A0 Offset: 0xB84A0 VA: 0x1800B90A0
	public bool repairable; // 0x8
	[TooltipAttribute] // RVA: 0xB9100 Offset: 0xB8500 VA: 0x1800B9100
	public bool maintainMaxCondition; // 0x9
	public ItemDefinition.Condition.WorldSpawnCondition foundCondition; // 0x10

}

public class ItemDefinition.Condition.WorldSpawnCondition // TypeDefIndex: 10119
{	// Fields
	public float fractionMin; // 0x10
	public float fractionMax; // 0x14

	// Methods

	// RVA: 0xA3B530 Offset: 0xA39B30 VA: 0x180A3B530
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

	// RVA: 0xA3A250 Offset: 0xA38850 VA: 0x180A3A250
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

	// RVA: 0xA36990 Offset: 0xA34F90 VA: 0x180A36990 Slot: 4
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

	// RVA: 0xA36900 Offset: 0xA34F00 VA: 0x180A36900 Slot: 12
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

	// RVA: 0xA31CD0 Offset: 0xA302D0 VA: 0x180A31CD0
	private void OnValidate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModActionContainerChange : ItemMod // TypeDefIndex: 10130
{	// Fields
	public ItemMod[] actions; // 0x20

	// Methods

	// RVA: 0xA31D50 Offset: 0xA30350 VA: 0x180A31D50
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
	|-RVA: 0x17F3AC0 Offset: 0x17F20C0 VA: 0x1817F3AC0
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
	|-RVA: 0x15E5AE0 Offset: 0x15E40E0 VA: 0x1815E5AE0
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

	// RVA: 0xA32020 Offset: 0xA30620 VA: 0x180A32020
	public void .ctor() { }

}

public class ItemModBlueprintCraft : ItemMod // TypeDefIndex: 10136
{	// Fields
	public GameObjectRef successEffect; // 0x20

	// Methods

	// RVA: 0xA32030 Offset: 0xA30630 VA: 0x180A32030 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModBurnable : ItemMod // TypeDefIndex: 10137
{	// Fields
	public float fuelAmount; // 0x20
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition byproductItem; // 0x28
	public int byproductAmount; // 0x30
	public float byproductChance; // 0x34

	// Methods

	// RVA: 0xA32260 Offset: 0xA30860 VA: 0x180A32260
	public void .ctor() { }

}

public class ItemModCassetteContainer : ItemModContainer // TypeDefIndex: 10138
{	// Fields
	public ItemDefinition[] CassetteItems; // 0x58

	// Methods

	// RVA: 0xA32020 Offset: 0xA30620 VA: 0x180A32020
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

	// RVA: 0xA322C0 Offset: 0xA308C0 VA: 0x180A322C0
	public void .ctor() { }

}

public class ItemModConditionContainerFlag : ItemMod // TypeDefIndex: 10141
{	// Fields
	public ItemContainer.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA322E0 Offset: 0xA308E0 VA: 0x180A322E0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionHasCondition : ItemMod // TypeDefIndex: 10142
{	// Fields
	public float conditionTarget; // 0x20
	[TooltipAttribute] // RVA: 0xB9320 Offset: 0xB8720 VA: 0x1800B9320
	public float conditionFractionTarget; // 0x24
	public bool lessThan; // 0x28

	// Methods

	// RVA: 0xA32330 Offset: 0xA30930 VA: 0x180A32330 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0xA32440 Offset: 0xA30A40 VA: 0x180A32440
	public void .ctor() { }

}

public class ItemModConditionHasContents : ItemMod // TypeDefIndex: 10143
{	// Fields
	[TooltipAttribute] // RVA: 0xB9620 Offset: 0xB8A20 VA: 0x1800B9620
	public ItemDefinition itemDef; // 0x20
	public bool requiredState; // 0x28

	// Methods

	// RVA: 0xA32460 Offset: 0xA30A60 VA: 0x180A32460 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA32570 Offset: 0xA30B70 VA: 0x180A32570
	private bool <Passes>b__2_0(Item x) { }

}

public class ItemModConditionHasFlag : ItemMod // TypeDefIndex: 10144
{	// Fields
	public Item.Flag flag; // 0x20
	public bool requiredState; // 0x24

	// Methods

	// RVA: 0xA325F0 Offset: 0xA30BF0 VA: 0x180A325F0 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionInWater : ItemMod // TypeDefIndex: 10145
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA32620 Offset: 0xA30C20 VA: 0x180A32620 Slot: 13
	public override bool Passes(Item item) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModConditionIsSleeping : ItemMod // TypeDefIndex: 10146
{	// Fields
	public bool requiredState; // 0x20

	// Methods

	// RVA: 0xA326D0 Offset: 0xA30CD0 VA: 0x180A326D0 Slot: 13
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

	// RVA: 0xA32780 Offset: 0xA30D80 VA: 0x180A32780
	public float GetIfType(MetabolismAttribute.Type typeToPick) { }

	// RVA: 0xA32860 Offset: 0xA30E60 VA: 0x180A32860
	public void .ctor() { }

}

public class ItemModConsumable.ConsumableEffect // TypeDefIndex: 10148
{	// Fields
	public MetabolismAttribute.Type type; // 0x10
	public float amount; // 0x14
	public float time; // 0x18
	public float onlyIfHealthLessThan; // 0x1C

	// Methods

	// RVA: 0xA23220 Offset: 0xA21820 VA: 0x180A23220
	public void .ctor() { }

}

public class ItemModConsume : ItemMod // TypeDefIndex: 10149
{	// Fields
	public GameObjectRef consumeEffect; // 0x20
	public string eatGesture; // 0x28
	[TooltipAttribute] // RVA: 0xB9A00 Offset: 0xB8E00 VA: 0x1800B9A00
	public ItemAmountRandom[] product; // 0x30
	public ItemModConsumable primaryConsumable; // 0x38

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA32B80 Offset: 0xA31180 VA: 0x180A32B80 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0xA32BB0 Offset: 0xA311B0 VA: 0x180A32BB0
	public void .ctor() { }

}

public class ItemModConsumeChance : ItemModConsume // TypeDefIndex: 10150
{	// Fields
	public float chanceForSecondaryConsume; // 0x40
	public GameObjectRef secondaryConsumeEffect; // 0x48
	public ItemModConsumable secondaryConsumable; // 0x50

	// Methods

	// RVA: 0xA32900 Offset: 0xA30F00 VA: 0x180A32900
	public void .ctor() { }

}

public class ItemModConsumeContents : ItemMod // TypeDefIndex: 10151
{	// Fields
	public GameObjectRef consumeEffect; // 0x20

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void CL_DoAction(Item item, BasePlayer player) { }

	// RVA: 0xA32950 Offset: 0xA30F50 VA: 0x180A32950 Slot: 12
	public override bool CanDoAction(Item item, BasePlayer player) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class ItemModContainer : ItemMod // TypeDefIndex: 10152
{	// Fields
	public int capacity; // 0x20
	public int maxStackSize; // 0x24
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public ItemContainer.Flag containerFlags; // 0x28
	public ItemContainer.ContentsType onlyAllowedContents; // 0x2C
	public ItemDefinition onlyAllowedItemType; // 0x30
	public List<ItemSlot> availableSlots; // 0x38
	public ItemDefinition[] validItemWhitelist; // 0x40
	public bool openInDeployed; // 0x48
	public bool openInInventory; // 0x49
	public List<ItemAmount> defaultContents; // 0x50

	// Methods

	// RVA: 0xA32D00 Offset: 0xA31300 VA: 0x180A32D00 Slot: 10
	public override int GetTotalUISlots(Item item) { }

	// RVA: 0xA32C90 Offset: 0xA31290 VA: 0x180A32C90 Slot: 11
	public override int GetFilledUISlots(Item item) { }

	// RVA: 0xA32D40 Offset: 0xA31340 VA: 0x180A32D40
	public void .ctor() { }

}

public class ItemModContainerRestriction : ItemMod // TypeDefIndex: 10153
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public ItemModContainerRestriction.SlotFlags slotFlags; // 0x20

	// Methods

	// RVA: 0xA32C00 Offset: 0xA31200 VA: 0x180A32C00
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
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition becomeOnCooked; // 0x20
	public float cookTime; // 0x28
	public int amountOfBecome; // 0x2C
	public int lowTemp; // 0x30
	public int highTemp; // 0x34
	public bool setCookingFlag; // 0x38

	// Methods

	// RVA: 0xA32E10 Offset: 0xA31410 VA: 0x180A32E10
	public void OnValidate() { }

	// RVA: 0xA32EF0 Offset: 0xA314F0 VA: 0x180A32EF0
	public void .ctor() { }

}

public class ItemModCycle : ItemMod // TypeDefIndex: 10156
{	// Fields
	public ItemMod[] actions; // 0x20
	public float timeBetweenCycles; // 0x28
	public float timerStart; // 0x2C
	public bool onlyAdvanceTimerWhenPass; // 0x30

	// Methods

	// RVA: 0xA33040 Offset: 0xA31640 VA: 0x180A33040
	private void OnValidate() { }

	// RVA: 0xA330C0 Offset: 0xA316C0 VA: 0x180A330C0
	public void .ctor() { }

}

public class ItemModDeployable : MonoBehaviour // TypeDefIndex: 10157
{	// Fields
	public GameObjectRef entityPrefab; // 0x18
	[HeaderAttribute] // RVA: 0xB9D80 Offset: 0xB9180 VA: 0x1800B9D80
	public bool showCrosshair; // 0x20
	public string UnlockAchievement; // 0x28

	// Methods

	// RVA: 0xA330D0 Offset: 0xA316D0 VA: 0x180A330D0
	public Deployable GetDeployable(BaseEntity entity) { }

	// RVA: 0xA331E0 Offset: 0xA317E0 VA: 0x180A331E0
	public void .ctor() { }

}

public class ItemModEntity : ItemMod // TypeDefIndex: 10158
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	public string defaultBone; // 0x28

	// Methods

	// RVA: 0xA33250 Offset: 0xA31850 VA: 0x180A33250
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
	[HeaderAttribute] // RVA: 0xB9DB0 Offset: 0xB91B0 VA: 0x1800B9DB0
	public float StrainModifier; // 0x24
	public float MoveMultiplier; // 0x28
	public float ReelInSpeedMultiplier; // 0x2C
	public float CatchWaitTimeMultiplier; // 0x30
	[HeaderAttribute] // RVA: 0xB9E50 Offset: 0xB9250 VA: 0x1800B9E50
	public float MinimumBaitLevel; // 0x34
	public float MaximumBaitLevel; // 0x38
	public float MinimumWaterDepth; // 0x3C
	public float MaximumWaterDepth; // 0x40
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public WaterBody.FishingTag RequiredTag; // 0x44
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float Chance; // 0x48
	public string SteamStatName; // 0x50

	// Methods

	// RVA: 0xA332C0 Offset: 0xA318C0 VA: 0x180A332C0
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

	// RVA: 0xA332F0 Offset: 0xA318F0 VA: 0x180A332F0 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA33400 Offset: 0xA31A00 VA: 0x180A33400 Slot: 5
	public override void OnChanged(Item item) { }

	// RVA: 0xA33460 Offset: 0xA31A60 VA: 0x180A33460
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
	[TooltipAttribute] // RVA: 0xBB3B0 Offset: 0xBA7B0 VA: 0x1800BB3B0
	public bool isPrimaryOption; // 0x50

	// Methods

	// RVA: 0xA33570 Offset: 0xA31B70 VA: 0x180A33570 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA33480 Offset: 0xA31A80 VA: 0x180A33480 Slot: 7
	public override bool BeltSelect(Item item, BasePlayer player) { }

	// RVA: 0xA336E0 Offset: 0xA31CE0 VA: 0x180A336E0
	private void OnValidate() { }

	// RVA: 0xA33870 Offset: 0xA31E70 VA: 0x180A33870
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

	// RVA: 0xA33EE0 Offset: 0xA324E0 VA: 0x180A33EE0 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB6C0 Offset: 0xBAAC0 VA: 0x1800BB6C0
	// RVA: 0xA33BA0 Offset: 0xA321A0 VA: 0x180A33BA0
	private IEnumerator DeferredSetup(Item item, PaintableItem paintable) { }

	// RVA: 0xA33C40 Offset: 0xA32240 VA: 0x180A33C40 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA34130 Offset: 0xA32730 VA: 0x180A34130
	private void PaintClicked(BasePlayer player) { }

	[IteratorStateMachineAttribute] // RVA: 0xBB860 Offset: 0xBAC60 VA: 0x1800BB860
	// RVA: 0xA340A0 Offset: 0xA326A0 VA: 0x180A340A0
	private IEnumerator OpenPaintUI(EntityRef<PaintedItemStorageEntity> paintStorage) { }

	// RVA: 0xA341E0 Offset: 0xA327E0 VA: 0x180A341E0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA394F0 Offset: 0xA37AF0 VA: 0x180A394F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA39670 Offset: 0xA37C70 VA: 0x180A39670 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ItemModPaintable.<>c__DisplayClass9_0 // TypeDefIndex: 10168
{	// Fields
	public PaintedItemStorageEntity entity; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA3B150 Offset: 0xA39750 VA: 0x180A3B150
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA396C0 Offset: 0xA37CC0 VA: 0x180A396C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA399B0 Offset: 0xA37FB0 VA: 0x180A399B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ItemModPetStats : ItemMod // TypeDefIndex: 10170
{	// Fields
	[TooltipAttribute] // RVA: 0xBC1D0 Offset: 0xBB5D0 VA: 0x1800BC1D0
	public float SpeedModifier; // 0x20
	[TooltipAttribute] // RVA: 0xBC230 Offset: 0xBB630 VA: 0x1800BC230
	public float MaxHealthModifier; // 0x24
	[TooltipAttribute] // RVA: 0xBC410 Offset: 0xBB810 VA: 0x1800BC410
	public float AttackDamageModifier; // 0x28
	[TooltipAttribute] // RVA: 0xBC520 Offset: 0xBB920 VA: 0x1800BC520
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

	// RVA: 0xA34410 Offset: 0xA32A10 VA: 0x180A34410
	public float GetRandomVelocity() { }

	// RVA: 0xA34450 Offset: 0xA32A50 VA: 0x180A34450
	public float GetSpreadScalar() { }

	// RVA: 0xA34380 Offset: 0xA32980 VA: 0x180A34380
	public float GetIndexedSpreadScalar(int shotIndex, int maxShots) { }

	// RVA: 0xA34370 Offset: 0xA32970 VA: 0x180A34370
	public float GetAverageVelocity() { }

	// RVA: 0xA34400 Offset: 0xA32A00 VA: 0x180A34400
	public float GetMinVelocity() { }

	// RVA: 0xA343F0 Offset: 0xA329F0 VA: 0x180A343F0
	public float GetMaxVelocity() { }

	// RVA: 0xA344B0 Offset: 0xA32AB0 VA: 0x180A344B0
	public bool IsAmmo(AmmoTypes ammo) { }

	// RVA: 0xA344C0 Offset: 0xA32AC0 VA: 0x180A344C0 Slot: 4
	public virtual void ServerProjectileHit(HitInfo info) { }

	// RVA: 0xA34590 Offset: 0xA32B90 VA: 0x180A34590
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

	// RVA: 0xA34260 Offset: 0xA32860 VA: 0x180A34260
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

	// RVA: 0xA34280 Offset: 0xA32880 VA: 0x180A34280
	public void .ctor() { }

}

public class ItemModRecycleInto : ItemMod // TypeDefIndex: 10175
{	// Fields
	public ItemDefinition recycleIntoItem; // 0x20
	public int numRecycledItemMin; // 0x28
	public int numRecycledItemMax; // 0x2C
	public GameObjectRef successEffect; // 0x30

	// Methods

	// RVA: 0xA34C90 Offset: 0xA33290 VA: 0x180A34C90 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA34DA0 Offset: 0xA333A0 VA: 0x180A34DA0
	public void .ctor() { }

}

public class ItemModRepair : ItemMod // TypeDefIndex: 10176
{	// Fields
	public float conditionLost; // 0x20
	public GameObjectRef successEffect; // 0x28
	public int workbenchLvlRequired; // 0x30

	// Methods

	// RVA: 0xA35010 Offset: 0xA33610 VA: 0x180A35010
	public bool HasCraftLevel(BasePlayer player) { }

	// RVA: 0xA34DC0 Offset: 0xA333C0 VA: 0x180A34DC0 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35120 Offset: 0xA33720 VA: 0x180A35120
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

	// RVA: 0xA35130 Offset: 0xA33730 VA: 0x180A35130 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA35270 Offset: 0xA33870 VA: 0x180A35270
	public void .ctor() { }

}

public class ItemModSound : ItemMod // TypeDefIndex: 10178
{	// Fields
	public GameObjectRef effect; // 0x20
	public ItemModSound.Type actionType; // 0x28

	// Methods

	// RVA: 0xA352D0 Offset: 0xA338D0 VA: 0x180A352D0
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

	// RVA: 0xA35340 Offset: 0xA33940 VA: 0x180A35340
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

	// RVA: 0xA35460 Offset: 0xA33A60 VA: 0x180A35460 Slot: 6
	public override void GetMenuOptions(Item item, List<Option> list, BasePlayer player) { }

	// RVA: 0xA355A0 Offset: 0xA33BA0 VA: 0x180A355A0
	public void .ctor() { }

}

public class ItemModUseContent : ItemMod // TypeDefIndex: 10185
{	// Fields
	public int amountToConsume; // 0x20

	// Methods

	// RVA: 0x7D6C20 Offset: 0x7D5220 VA: 0x1807D6C20
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

	// RVA: 0xA36640 Offset: 0xA34C40 VA: 0x180A36640
	public Wearable get_targetWearable() { }

	// RVA: 0xA357A0 Offset: 0xA33DA0 VA: 0x180A357A0
	private void DoPrepare() { }

	// RVA: 0xA35BC0 Offset: 0xA341C0 VA: 0x180A35BC0 Slot: 4
	public override void ModInit() { }

	// RVA: 0xA364E0 Offset: 0xA34AE0 VA: 0x180A364E0
	public bool ProtectsArea(HitArea area) { }

	// RVA: 0xA35A10 Offset: 0xA34010 VA: 0x180A35A10
	public bool HasProtections() { }

	// RVA: 0xA35920 Offset: 0xA33F20 VA: 0x180A35920
	internal float GetProtection(Item item, DamageType damageType) { }

	// RVA: 0xA35750 Offset: 0xA33D50 VA: 0x180A35750
	public float ConditionProtectionScale(Item item) { }

	// RVA: 0xA35680 Offset: 0xA33C80 VA: 0x180A35680
	public void CollectProtection(Item item, ProtectionProperties protection) { }

	// RVA: 0xA35B20 Offset: 0xA34120 VA: 0x180A35B20
	private bool IsHeadgear() { }

	// RVA: 0xA35A70 Offset: 0xA34070 VA: 0x180A35A70
	public bool IsFootwear() { }

	// RVA: 0xA35C70 Offset: 0xA34270 VA: 0x180A35C70
	public void OnDressModel(Item item, PlayerModel model) { }

	// RVA: 0xA362D0 Offset: 0xA348D0 VA: 0x180A362D0 Slot: 9
	public override void OnObjectSetup(Item item, GameObject obj) { }

	// RVA: 0xA355D0 Offset: 0xA33BD0 VA: 0x180A355D0
	public bool CanExistWith(ItemModWearable wearable) { }

	// RVA: 0xA36580 Offset: 0xA34B80 VA: 0x180A36580
	public void .ctor() { }

}

private sealed class ItemModWearable.<>c__DisplayClass28_0 // TypeDefIndex: 10187
{	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EFF70 Offset: 0x7EE570 VA: 0x1807EFF70
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

	// RVA: 0xA2AF90 Offset: 0xA29590 VA: 0x180A2AF90
	public void .ctor() { }

}

public class ItemAmount : ISerializationCallbackReceiver // TypeDefIndex: 10190
{	// Fields
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition itemDef; // 0x10
	public float amount; // 0x18
	public float startAmount; // 0x1C

	// Properties
	public int itemid { get; }

	// Methods

	// RVA: 0xA25FE0 Offset: 0xA245E0 VA: 0x180A25FE0
	public void .ctor(ItemDefinition item, float amt = 0) { }

	// RVA: 0xA26030 Offset: 0xA24630 VA: 0x180A26030
	public int get_itemid() { }

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0 Slot: 6
	public virtual float GetAmount() { }

	// RVA: 0xA25D70 Offset: 0xA24370 VA: 0x180A25D70 Slot: 7
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void OnBeforeSerialize() { }

	// RVA: 0xA25D80 Offset: 0xA24380 VA: 0x180A25D80
	public static ItemAmountList SerialiseList(List<ItemAmount> list) { }

	// RVA: 0xA25B90 Offset: 0xA24190 VA: 0x180A25B90
	public static void DeserialiseList(List<ItemAmount> target, ItemAmountList source) { }

}

public class ItemAmountRandom // TypeDefIndex: 10191
{	// Fields
	[ItemSelector] // RVA: 0xA7560 Offset: 0xA6960 VA: 0x1800A7560
	public ItemDefinition itemDef; // 0x10
	public AnimationCurve amount; // 0x18

	// Methods

	// RVA: 0xA25900 Offset: 0xA23F00 VA: 0x180A25900
	public int RandomAmount() { }

	// RVA: 0xA25990 Offset: 0xA23F90 VA: 0x180A25990
	public void .ctor() { }

}

public class ItemAmountRanged : ItemAmount // TypeDefIndex: 10192
{	// Fields
	public float maxAmount; // 0x20

	// Methods

	// RVA: 0xA25B10 Offset: 0xA24110 VA: 0x180A25B10 Slot: 7
	public override void OnAfterDeserialize() { }

	// RVA: 0xA25B20 Offset: 0xA24120 VA: 0x180A25B20
	public void .ctor(ItemDefinition item, float amt = 0, float max = -1) { }

	// RVA: 0xA25AE0 Offset: 0xA240E0 VA: 0x180A25AE0 Slot: 6
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

	// RVA: 0xA319F0 Offset: 0xA2FFF0 VA: 0x180A319F0
	public static void InvalidateWorkshopSkinCache() { }

	// RVA: 0xA30A40 Offset: 0xA2F040 VA: 0x180A30A40
	public static void Initialize() { }

	// RVA: 0x51B650 Offset: 0x519C50 VA: 0x18051B650
	public static void UpdateUnlockedSkins() { }

	// RVA: 0xA31B10 Offset: 0xA30110 VA: 0x180A31B10
	public static Item Load(Item load, Item created, bool isServer) { }

	// RVA: 0xA308C0 Offset: 0xA2EEC0 VA: 0x180A308C0
	public static ItemDefinition FindItemDefinition(int itemID) { }

	// RVA: 0xA30940 Offset: 0xA2EF40 VA: 0x180A30940
	public static ItemDefinition FindItemDefinition(string shortName) { }

	// RVA: 0xA30870 Offset: 0xA2EE70 VA: 0x180A30870
	public static ItemBlueprint FindBlueprint(ItemDefinition item) { }

	// RVA: 0xA30A00 Offset: 0xA2F000 VA: 0x180A30A00
	public static List<ItemDefinition> GetItemDefinitions() { }

	// RVA: 0xA309C0 Offset: 0xA2EFC0 VA: 0x180A309C0
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

	// RVA: 0xA3B2A0 Offset: 0xA398A0 VA: 0x180A3B2A0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xA39D00 Offset: 0xA38300 VA: 0x180A39D00
	internal ItemDefinition <Initialize>b__7_0(GameObject x) { }

	// RVA: 0xA39D50 Offset: 0xA38350 VA: 0x180A39D50
	internal bool <Initialize>b__7_1(ItemDefinition x) { }

	// RVA: 0xA39DB0 Offset: 0xA383B0 VA: 0x180A39DB0
	internal ItemBlueprint <Initialize>b__7_2(GameObject x) { }

	// RVA: 0xA39E00 Offset: 0xA38400 VA: 0x180A39E00
	internal bool <Initialize>b__7_3(ItemBlueprint x) { }

	// RVA: 0xA39E70 Offset: 0xA38470 VA: 0x180A39E70
	internal bool <Initialize>b__7_4(ItemBlueprint x) { }

	// RVA: 0xA39F30 Offset: 0xA38530 VA: 0x180A39F30
	internal int <Initialize>b__7_5(ItemBlueprint x) { }

}

public class ItemSkin : SteamInventoryItem // TypeDefIndex: 10738
{	// Fields
	public Skinnable Skinnable; // 0x70
	public Material[] Materials; // 0x78
	[TooltipAttribute] // RVA: 0x77120 Offset: 0x76520 VA: 0x180077120
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

	// RVA: 0xF3940 Offset: 0xF2D40 VA: 0x1800F3940
	public SteamInventoryItem get_invItem() { }

}

private sealed class ItemSkinDirectory.<>c__DisplayClass5_0 // TypeDefIndex: 10741
{	// Fields
	public ItemDefinition item; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690EF0 Offset: 0x68F4F0 VA: 0x180690EF0
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

	// RVA: 0xA2AC50 Offset: 0xA29250 VA: 0x180A2AC50
	private void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA2AE50 Offset: 0xA29450 VA: 0x180A2AE50
	public void .ctor() { }

}

public class ItemIcon : BaseMonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IDraggable, IInventoryChanged, IItemAmountChanged, IItemIconChanged // TypeDefIndex: 11009
{	// Fields
	public static Color defaultBackgroundColor; // 0x0
	public static Color selectedBackgroundColor; // 0x10
	public ItemContainerSource containerSource; // 0x18
	public int slotOffset; // 0x20
	[RangeAttribute] // RVA: 0x8E8D0 Offset: 0x8DCD0 VA: 0x18008E8D0
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

	// RVA: 0xA2AFE0 Offset: 0xA295E0 VA: 0x180A2AFE0
	protected void Awake() { }

	// RVA: 0xA2C800 Offset: 0xA2AE00 VA: 0x180A2C800
	protected void OnEnable() { }

	// RVA: 0xA2B210 Offset: 0xA29810 VA: 0x180A2B210
	public static void ClearLootTimers() { }

	// RVA: 0xA2B2F0 Offset: 0xA298F0 VA: 0x180A2B2F0
	public void ClearProgressImage() { }

	// RVA: 0xA2C250 Offset: 0xA2A850 VA: 0x180A2C250
	protected void OnDisable() { }

	// RVA: 0xA2D900 Offset: 0xA2BF00 VA: 0x180A2D900
	public void OnShow() { }

	// RVA: 0xA2CA20 Offset: 0xA2B020 VA: 0x180A2CA20
	public void OnHide() { }

	// RVA: 0xA2B2D0 Offset: 0xA298D0 VA: 0x180A2B2D0
	public void ClearLooting() { }

	// RVA: 0xA2F4C0 Offset: 0xA2DAC0 VA: 0x180A2F4C0
	private void Update() { }

	// RVA: 0xA2BBC0 Offset: 0xA2A1C0 VA: 0x180A2BBC0
	public Sprite GetItemSprite(out Color tint) { }

	// RVA: 0xA2D230 Offset: 0xA2B830 VA: 0x180A2D230 Slot: 13
	public void OnItemAmountChanged() { }

	// RVA: 0xA2D270 Offset: 0xA2B870 VA: 0x180A2D270 Slot: 14
	public void OnItemIconChanged() { }

	// RVA: 0xA2CAC0 Offset: 0xA2B0C0 VA: 0x180A2CAC0 Slot: 12
	public void OnInventoryChanged() { }

	// RVA: 0xA2F000 Offset: 0xA2D600 VA: 0x180A2F000
	private void UpdateHoverText() { }

	// RVA: 0xA2F1C0 Offset: 0xA2D7C0 VA: 0x180A2F1C0
	private void UpdateItemIcon() { }

	// RVA: 0xA2DBD0 Offset: 0xA2C1D0 VA: 0x180A2DBD0
	private void SetBackgroundUnderlayVisible(bool flag) { }

	// RVA: 0xA2EEF0 Offset: 0xA2D4F0 VA: 0x180A2EEF0
	private void UpdateCornerIcon() { }

	// RVA: 0xA2F200 Offset: 0xA2D800 VA: 0x180A2F200
	private void UpdateSlots() { }

	// RVA: 0xA2F690 Offset: 0xA2DC90 VA: 0x180A2F690
	private Item get_iconValue() { }

	// RVA: 0xA2DAF0 Offset: 0xA2C0F0 VA: 0x180A2DAF0
	public void Select() { }

	// RVA: 0xA2DAE0 Offset: 0xA2C0E0 VA: 0x180A2DAE0
	public void SelectSilent() { }

	// RVA: 0xA2C100 Offset: 0xA2A700 VA: 0x180A2C100
	private void InternalSelect(bool silent = False) { }

	// RVA: 0xA2B5F0 Offset: 0xA29BF0 VA: 0x180A2B5F0
	public void Deselect() { }

	// RVA: 0xA2DB00 Offset: 0xA2C100 VA: 0x180A2DB00
	public void SetActive(bool active) { }

	// RVA: 0xA2C3E0 Offset: 0xA2A9E0 VA: 0x180A2C3E0 Slot: 15
	public virtual void OnDroppedValue(ItemIcon.DragInfo dropInfo) { }

	// RVA: 0xA2E080 Offset: 0xA2C680 VA: 0x180A2E080
	private bool TryToDropInsideItem(ItemIcon.DragInfo dropInfo, Item item) { }

	// RVA: 0xA2DD30 Offset: 0xA2C330 VA: 0x180A2DD30
	public void SetTimedLootAction(uint sourceContainer, Action action) { }

	// RVA: 0xA2B0B0 Offset: 0xA296B0 VA: 0x180A2B0B0
	private float CalculateLootDelay(uint sourceContainer) { }

	[IteratorStateMachineAttribute] // RVA: 0x8E920 Offset: 0x8DD20 VA: 0x18008E920
	// RVA: 0xA2E000 Offset: 0xA2C600 VA: 0x180A2E000
	private IEnumerator StartTimedLootAction(float delay) { }

	// RVA: 0xA2DAB0 Offset: 0xA2C0B0 VA: 0x180A2DAB0
	public void RunTimedAction() { }

	// RVA: 0xA2B3C0 Offset: 0xA299C0 VA: 0x180A2B3C0
	public void ClearTimedAction() { }

	// RVA: 0xA2D910 Offset: 0xA2BF10 VA: 0x180A2D910
	private void RemoveFromLootQueue() { }

	[IteratorStateMachineAttribute] // RVA: 0x8EB60 Offset: 0x8DF60 VA: 0x18008EB60
	// RVA: 0xA2F450 Offset: 0xA2DA50 VA: 0x180A2F450
	private IEnumerator UpdateTimedActionIcon() { }

	// RVA: 0xA2E950 Offset: 0xA2CF50 VA: 0x180A2E950
	private void TryToQuickMove() { }

	// RVA: 0xA2E200 Offset: 0xA2C800 VA: 0x180A2E200 Slot: 16
	public virtual void TryToMove() { }

	// RVA: 0xA2B680 Offset: 0xA29C80 VA: 0x180A2B680
	public void EquipAsClothingItem() { }

	// RVA: 0xA2D380 Offset: 0xA2B980 VA: 0x180A2D380 Slot: 17
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xA2D460 Offset: 0xA2BA60 VA: 0x180A2D460 Slot: 7
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0xA2D830 Offset: 0xA2BE30 VA: 0x180A2D830 Slot: 8
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0xA2B860 Offset: 0xA29E60 VA: 0x180A2B860 Slot: 9
	public object GetDragData() { }

	// RVA: 0xA2BB90 Offset: 0xA2A190 VA: 0x180A2BB90 Slot: 10
	public string GetDragType() { }

	// RVA: 0xA2BB60 Offset: 0xA2A160 VA: 0x180A2BB60 Slot: 11
	public Sprite GetDragSprite() { }

	// RVA: 0xA2F670 Offset: 0xA2DC70 VA: 0x180A2F670
	public void .ctor() { }

	// RVA: 0xA2F560 Offset: 0xA2DB60 VA: 0x180A2F560
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA2EB70 Offset: 0xA2D170 VA: 0x180A2EB70
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA39A00 Offset: 0xA38000 VA: 0x180A39A00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA39C80 Offset: 0xA38280 VA: 0x180A39C80 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xA3B300 Offset: 0xA39900 VA: 0x180A3B300 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA3B4E0 Offset: 0xA39AE0 VA: 0x180A3B4E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0xA3A350 Offset: 0xA38950 VA: 0x180A3A350
	internal void <TryToMove>b__0() { }

	// RVA: 0xA3A6C0 Offset: 0xA38CC0 VA: 0x180A3A6C0
	internal void <TryToMove>b__1() { }

	// RVA: 0xA3A9F0 Offset: 0xA38FF0 VA: 0x180A3A9F0
	internal void <TryToMove>b__2() { }

	// RVA: 0xA3ADE0 Offset: 0xA393E0 VA: 0x180A3ADE0
	internal void <TryToMove>b__3() { }

}

public class ItemInformationPanel : MonoBehaviour // TypeDefIndex: 11014
{	// Methods

	// RVA: 0xA2F750 Offset: 0xA2DD50 VA: 0x180A2F750 Slot: 4
	public virtual bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xA2F7B0 Offset: 0xA2DDB0 VA: 0x180A2F7B0 Slot: 5
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
	[RangeAttribute] // RVA: 0x8E8D0 Offset: 0x8DCD0 VA: 0x18008E8D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6798F0 Offset: 0x677EF0 VA: 0x1806798F0
	private void <Start>b__6_0(string <p0>) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[FormerlySerializedAsAttribute] // RVA: 0x96570 Offset: 0x95970 VA: 0x180096570
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

	[AsyncStateMachineAttribute] // RVA: 0x96660 Offset: 0x95A60 VA: 0x180096660
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

	[AsyncStateMachineAttribute] // RVA: 0x96840 Offset: 0x95C40 VA: 0x180096840
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

	// RVA: 0x690F40 Offset: 0x68F540 VA: 0x180690F40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x690CB0 Offset: 0x68F2B0 VA: 0x180690CB0
	internal int <OnPurchaseFinished>b__16_0(IPlayerItemDefinition x) { }

	// RVA: 0x690D00 Offset: 0x68F300 VA: 0x180690D00
	internal int <RefreshList>b__17_0(IPlayerItemDefinition x) { }

	// RVA: 0x690D50 Offset: 0x68F350 VA: 0x180690D50
	internal int <UpdateShoppingList>b__22_0(IPlayerItemDefinition x) { }

	// RVA: 0x690C90 Offset: 0x68F290 VA: 0x180690C90
	internal InventoryDef <Checkout>b__24_0(SteamItemDefinition i) { }

}

private struct ItemStore.<RefreshList>d__17 : IAsyncStateMachine // TypeDefIndex: 11108
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<List<IPlayerItemDefinition>> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3A40 Offset: 0xF2E40 VA: 0x1800F3A40 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ItemStore.<Checkout>d__24 : IAsyncStateMachine // TypeDefIndex: 11109
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ItemStore <>4__this; // 0x28
	private TaskAwaiter<Nullable<InventoryPurchaseResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3A30 Offset: 0xF2E30 VA: 0x1800F3A30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF15B0 Offset: 0xF09B0 VA: 0x1800F15B0 Slot: 5
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void <Hide>b__7_0() { }

}

public class ItemModEngineItem : ItemMod // TypeDefIndex: 12112
{	// Fields
	public EngineStorage.EngineItemTypes engineItemType; // 0x20
	[RangeAttribute] // RVA: 0xDBED0 Offset: 0xDB2D0 VA: 0x1800DBED0
	public int tier; // 0x24

	// Methods

	// RVA: 0x4BE5F0 Offset: 0x4BCBF0 VA: 0x1804BE5F0
	public void .ctor() { }

}

public class ItemModVehicleChassis : ItemMod, VehicleModuleInformationPanel.IVehicleModuleInfo // TypeDefIndex: 12113
{	// Fields
	public GameObjectRef entityPrefab; // 0x20
	[RangeAttribute] // RVA: 0xDC040 Offset: 0xDB440 VA: 0x1800DC040
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
	[RangeAttribute] // RVA: 0xA43E0 Offset: 0xA37E0 VA: 0x1800A43E0
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

