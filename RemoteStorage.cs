internal enum RemoteStoragePublishedFileVisibility // TypeDefIndex: 5152
{	// Fields
	public int value__; // 0x0
	public const RemoteStoragePublishedFileVisibility Public = 0;
	public const RemoteStoragePublishedFileVisibility FriendsOnly = 1;
	public const RemoteStoragePublishedFileVisibility Private = 2;
	public const RemoteStoragePublishedFileVisibility Unlisted = 3;

}

internal struct RemoteStorageFileShareResult_t : ICallbackData // TypeDefIndex: 5361
{	// Fields
	internal Result Result; // 0x0
	internal ulong File; // 0x8
	internal byte[] Filename; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D6FD0 Offset: 0x1D63D0 VA: 0x1801D6FD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6FC0 Offset: 0x1D63C0 VA: 0x1801D6FC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E6D0 Offset: 0x128CCD0 VA: 0x18128E6D0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishFileResult_t : ICallbackData // TypeDefIndex: 5362
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7AE0 Offset: 0x1D6EE0 VA: 0x1801D7AE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7AD0 Offset: 0x1D6ED0 VA: 0x1801D7AD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EA90 Offset: 0x128D090 VA: 0x18128EA90
	private static void .cctor() { }

}

internal struct RemoteStorageDeletePublishedFileResult_t : ICallbackData // TypeDefIndex: 5363
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D37E0 Offset: 0x1D2BE0 VA: 0x1801D37E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D37D0 Offset: 0x1D2BD0 VA: 0x1801D37D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E1D0 Offset: 0x128C7D0 VA: 0x18128E1D0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserPublishedFilesResult_t : ICallbackData // TypeDefIndex: 5364
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D4830 Offset: 0x1D3C30 VA: 0x1801D4830 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4820 Offset: 0x1D3C20 VA: 0x1801D4820 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E3B0 Offset: 0x128C9B0 VA: 0x18128E3B0
	private static void .cctor() { }

}

internal struct RemoteStorageSubscribePublishedFileResult_t : ICallbackData // TypeDefIndex: 5365
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7D80 Offset: 0x1D7180 VA: 0x1801D7D80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7D70 Offset: 0x1D7170 VA: 0x1801D7D70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EE70 Offset: 0x128D470 VA: 0x18128EE70
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserSubscribedFilesResult_t : ICallbackData // TypeDefIndex: 5366
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	internal uint[] GRTimeSubscribed; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D53E0 Offset: 0x1D47E0 VA: 0x1801D53E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D53D0 Offset: 0x1D47D0 VA: 0x1801D53D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E4F0 Offset: 0x128CAF0 VA: 0x18128E4F0
	private static void .cctor() { }

}

internal struct RemoteStorageUnsubscribePublishedFileResult_t : ICallbackData // TypeDefIndex: 5367
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7DF0 Offset: 0x1D71F0 VA: 0x1801D7DF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7DE0 Offset: 0x1D71E0 VA: 0x1801D7DE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EF10 Offset: 0x128D510 VA: 0x18128EF10
	private static void .cctor() { }

}

internal struct RemoteStorageUpdatePublishedFileResult_t : ICallbackData // TypeDefIndex: 5368
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7E60 Offset: 0x1D7260 VA: 0x1801D7E60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7E50 Offset: 0x1D7250 VA: 0x1801D7E50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EFB0 Offset: 0x128D5B0 VA: 0x18128EFB0
	private static void .cctor() { }

}

internal struct RemoteStorageDownloadUGCResult_t : ICallbackData // TypeDefIndex: 5369
{	// Fields
	internal Result Result; // 0x0
	internal ulong File; // 0x8
	internal AppId AppID; // 0x10
	internal int SizeInBytes; // 0x14
	internal byte[] PchFileName; // 0x18
	internal ulong SteamIDOwner; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D3850 Offset: 0x1D2C50 VA: 0x1801D3850 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3840 Offset: 0x1D2C40 VA: 0x1801D3840 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E270 Offset: 0x128C870 VA: 0x18128E270
	private static void .cctor() { }

}

internal struct RemoteStorageGetPublishedFileDetailsResult_t : ICallbackData // TypeDefIndex: 5370
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal AppId CreatorAppID; // 0x10
	internal AppId ConsumerAppID; // 0x14
	internal byte[] Title; // 0x18
	internal byte[] Description; // 0x20
	internal ulong File; // 0x28
	internal ulong PreviewFile; // 0x30
	internal ulong SteamIDOwner; // 0x38
	internal uint TimeCreated; // 0x40
	internal uint TimeUpdated; // 0x44
	internal RemoteStoragePublishedFileVisibility Visibility; // 0x48
	internal bool Banned; // 0x4C
	internal byte[] Tags; // 0x50
	internal bool TagsTruncated; // 0x58
	internal byte[] PchFileName; // 0x60
	internal int FileSize; // 0x68
	internal int PreviewFileSize; // 0x6C
	internal byte[] URL; // 0x70
	internal WorkshopFileType FileType; // 0x78
	internal bool AcceptedForUse; // 0x7C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7220 Offset: 0x1D6620 VA: 0x1801D7220 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7210 Offset: 0x1D6610 VA: 0x1801D7210 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E810 Offset: 0x128CE10 VA: 0x18128E810
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateWorkshopFilesResult_t : ICallbackData // TypeDefIndex: 5371
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	internal float[] GScore; // 0x18
	internal AppId AppId; // 0x20
	internal uint StartIndex; // 0x24
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D6180 Offset: 0x1D5580 VA: 0x1801D6180 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6170 Offset: 0x1D5570 VA: 0x1801D6170 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E590 Offset: 0x128CB90 VA: 0x18128E590
	private static void .cctor() { }

}

internal struct RemoteStorageGetPublishedItemVoteDetailsResult_t : ICallbackData // TypeDefIndex: 5372
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal int VotesFor; // 0x10
	internal int VotesAgainst; // 0x14
	internal int Reports; // 0x18
	internal float FScore; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7990 Offset: 0x1D6D90 VA: 0x1801D7990 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7980 Offset: 0x1D6D80 VA: 0x1801D7980 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E8B0 Offset: 0x128CEB0 VA: 0x18128E8B0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileSubscribed_t : ICallbackData // TypeDefIndex: 5373
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7BC0 Offset: 0x1D6FC0 VA: 0x1801D7BC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7BB0 Offset: 0x1D6FB0 VA: 0x1801D7BB0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EBD0 Offset: 0x128D1D0 VA: 0x18128EBD0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileUnsubscribed_t : ICallbackData // TypeDefIndex: 5374
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7C30 Offset: 0x1D7030 VA: 0x1801D7C30 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7C20 Offset: 0x1D7020 VA: 0x1801D7C20 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EC80 Offset: 0x128D280 VA: 0x18128EC80
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileDeleted_t : ICallbackData // TypeDefIndex: 5375
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7B50 Offset: 0x1D6F50 VA: 0x1801D7B50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7B40 Offset: 0x1D6F40 VA: 0x1801D7B40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EB30 Offset: 0x128D130 VA: 0x18128EB30
	private static void .cctor() { }

}

internal struct RemoteStorageUpdateUserPublishedItemVoteResult_t : ICallbackData // TypeDefIndex: 5376
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7ED0 Offset: 0x1D72D0 VA: 0x1801D7ED0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7EC0 Offset: 0x1D72C0 VA: 0x1801D7EC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F050 Offset: 0x128D650 VA: 0x18128F050
	private static void .cctor() { }

}

internal struct RemoteStorageUserVoteDetails_t : ICallbackData // TypeDefIndex: 5377
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal WorkshopVote Vote; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7F40 Offset: 0x1D7340 VA: 0x1801D7F40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7F30 Offset: 0x1D7330 VA: 0x1801D7F30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128F0F0 Offset: 0x128D6F0 VA: 0x18128F0F0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ICallbackData // TypeDefIndex: 5378
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D4FD0 Offset: 0x1D43D0 VA: 0x1801D4FD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4FC0 Offset: 0x1D43C0 VA: 0x1801D4FC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E450 Offset: 0x128CA50 VA: 0x18128E450
	private static void .cctor() { }

}

internal struct RemoteStorageSetUserPublishedFileActionResult_t : ICallbackData // TypeDefIndex: 5379
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal WorkshopFileAction Action; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7D10 Offset: 0x1D7110 VA: 0x1801D7D10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7D00 Offset: 0x1D7100 VA: 0x1801D7D00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128EDD0 Offset: 0x128D3D0 VA: 0x18128EDD0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ICallbackData // TypeDefIndex: 5380
{	// Fields
	internal Result Result; // 0x0
	internal WorkshopFileAction Action; // 0x4
	internal int ResultsReturned; // 0x8
	internal int TotalResultCount; // 0xC
	internal PublishedFileId[] GPublishedFileId; // 0x10
	internal uint[] GRTimeUpdated; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D3A70 Offset: 0x1D2E70 VA: 0x1801D3A70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3A60 Offset: 0x1D2E60 VA: 0x1801D3A60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E310 Offset: 0x128C910 VA: 0x18128E310
	private static void .cctor() { }

}

internal struct RemoteStoragePublishFileProgress_t : ICallbackData // TypeDefIndex: 5381
{	// Fields
	internal double DPercentFile; // 0x0
	internal bool Preview; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7A70 Offset: 0x1D6E70 VA: 0x1801D7A70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7A60 Offset: 0x1D6E60 VA: 0x1801D7A60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E9F0 Offset: 0x128CFF0 VA: 0x18128E9F0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileUpdated_t : ICallbackData // TypeDefIndex: 5382
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	internal ulong Unused; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7CA0 Offset: 0x1D70A0 VA: 0x1801D7CA0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7C90 Offset: 0x1D7090 VA: 0x1801D7C90 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128ED30 Offset: 0x128D330 VA: 0x18128ED30
	private static void .cctor() { }

}

internal struct RemoteStorageFileWriteAsyncComplete_t : ICallbackData // TypeDefIndex: 5383
{	// Fields
	internal Result Result; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D71B0 Offset: 0x1D65B0 VA: 0x1801D71B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D71A0 Offset: 0x1D65A0 VA: 0x1801D71A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E770 Offset: 0x128CD70 VA: 0x18128E770
	private static void .cctor() { }

}

internal struct RemoteStorageFileReadAsyncComplete_t : ICallbackData // TypeDefIndex: 5384
{	// Fields
	internal ulong FileReadAsync; // 0x0
	internal Result Result; // 0x8
	internal uint Offset; // 0xC
	internal uint Read; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D6F60 Offset: 0x1D6360 VA: 0x1801D6F60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6F50 Offset: 0x1D6350 VA: 0x1801D6F50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E630 Offset: 0x128CC30 VA: 0x18128E630
	private static void .cctor() { }

}

internal struct RemoteStorageLocalFileChange_t : ICallbackData // TypeDefIndex: 5385
{	// Fields
	public static int _datasize; // 0x137E0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7A00 Offset: 0x1D6E00 VA: 0x1801D7A00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D79F0 Offset: 0x1D6DF0 VA: 0x1801D79F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E950 Offset: 0x128CF50 VA: 0x18128E950
	private static void .cctor() { }

}

