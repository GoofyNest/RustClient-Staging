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

	// RVA: 0x1D6960 Offset: 0x1D5D60 VA: 0x1801D6960 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6950 Offset: 0x1D5D50 VA: 0x1801D6950 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DD70 Offset: 0x128C370 VA: 0x18128DD70
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

	// RVA: 0x1D7470 Offset: 0x1D6870 VA: 0x1801D7470 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7460 Offset: 0x1D6860 VA: 0x1801D7460 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E130 Offset: 0x128C730 VA: 0x18128E130
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

	// RVA: 0x1D3170 Offset: 0x1D2570 VA: 0x1801D3170 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3160 Offset: 0x1D2560 VA: 0x1801D3160 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128D870 Offset: 0x128BE70 VA: 0x18128D870
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

	// RVA: 0x1D41C0 Offset: 0x1D35C0 VA: 0x1801D41C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D41B0 Offset: 0x1D35B0 VA: 0x1801D41B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DA50 Offset: 0x128C050 VA: 0x18128DA50
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

	// RVA: 0x1D7710 Offset: 0x1D6B10 VA: 0x1801D7710 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7700 Offset: 0x1D6B00 VA: 0x1801D7700 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E510 Offset: 0x128CB10 VA: 0x18128E510
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

	// RVA: 0x1D4D70 Offset: 0x1D4170 VA: 0x1801D4D70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4D60 Offset: 0x1D4160 VA: 0x1801D4D60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DB90 Offset: 0x128C190 VA: 0x18128DB90
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

	// RVA: 0x1D7780 Offset: 0x1D6B80 VA: 0x1801D7780 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7770 Offset: 0x1D6B70 VA: 0x1801D7770 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E5B0 Offset: 0x128CBB0 VA: 0x18128E5B0
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

	// RVA: 0x1D77F0 Offset: 0x1D6BF0 VA: 0x1801D77F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D77E0 Offset: 0x1D6BE0 VA: 0x1801D77E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E650 Offset: 0x128CC50 VA: 0x18128E650
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

	// RVA: 0x1D31E0 Offset: 0x1D25E0 VA: 0x1801D31E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D31D0 Offset: 0x1D25D0 VA: 0x1801D31D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128D910 Offset: 0x128BF10 VA: 0x18128D910
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

	// RVA: 0x1D6BB0 Offset: 0x1D5FB0 VA: 0x1801D6BB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6BA0 Offset: 0x1D5FA0 VA: 0x1801D6BA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DEB0 Offset: 0x128C4B0 VA: 0x18128DEB0
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

	// RVA: 0x1D5B10 Offset: 0x1D4F10 VA: 0x1801D5B10 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D5B00 Offset: 0x1D4F00 VA: 0x1801D5B00 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DC30 Offset: 0x128C230 VA: 0x18128DC30
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

	// RVA: 0x1D7320 Offset: 0x1D6720 VA: 0x1801D7320 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7310 Offset: 0x1D6710 VA: 0x1801D7310 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DF50 Offset: 0x128C550 VA: 0x18128DF50
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

	// RVA: 0x1D7550 Offset: 0x1D6950 VA: 0x1801D7550 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7540 Offset: 0x1D6940 VA: 0x1801D7540 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E270 Offset: 0x128C870 VA: 0x18128E270
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

	// RVA: 0x1D75C0 Offset: 0x1D69C0 VA: 0x1801D75C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D75B0 Offset: 0x1D69B0 VA: 0x1801D75B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E320 Offset: 0x128C920 VA: 0x18128E320
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

	// RVA: 0x1D74E0 Offset: 0x1D68E0 VA: 0x1801D74E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D74D0 Offset: 0x1D68D0 VA: 0x1801D74D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E1D0 Offset: 0x128C7D0 VA: 0x18128E1D0
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

	// RVA: 0x1D7860 Offset: 0x1D6C60 VA: 0x1801D7860 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7850 Offset: 0x1D6C50 VA: 0x1801D7850 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E6F0 Offset: 0x128CCF0 VA: 0x18128E6F0
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

	// RVA: 0x1D78D0 Offset: 0x1D6CD0 VA: 0x1801D78D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D78C0 Offset: 0x1D6CC0 VA: 0x1801D78C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E790 Offset: 0x128CD90 VA: 0x18128E790
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

	// RVA: 0x1D4960 Offset: 0x1D3D60 VA: 0x1801D4960 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4950 Offset: 0x1D3D50 VA: 0x1801D4950 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DAF0 Offset: 0x128C0F0 VA: 0x18128DAF0
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

	// RVA: 0x1D76A0 Offset: 0x1D6AA0 VA: 0x1801D76A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7690 Offset: 0x1D6A90 VA: 0x1801D7690 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E470 Offset: 0x128CA70 VA: 0x18128E470
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

	// RVA: 0x1D3400 Offset: 0x1D2800 VA: 0x1801D3400 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D33F0 Offset: 0x1D27F0 VA: 0x1801D33F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128D9B0 Offset: 0x128BFB0 VA: 0x18128D9B0
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

	// RVA: 0x1D7400 Offset: 0x1D6800 VA: 0x1801D7400 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D73F0 Offset: 0x1D67F0 VA: 0x1801D73F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E090 Offset: 0x128C690 VA: 0x18128E090
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

	// RVA: 0x1D7630 Offset: 0x1D6A30 VA: 0x1801D7630 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7620 Offset: 0x1D6A20 VA: 0x1801D7620 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128E3D0 Offset: 0x128C9D0 VA: 0x18128E3D0
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

	// RVA: 0x1D6B40 Offset: 0x1D5F40 VA: 0x1801D6B40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6B30 Offset: 0x1D5F30 VA: 0x1801D6B30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DE10 Offset: 0x128C410 VA: 0x18128DE10
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

	// RVA: 0x1D68F0 Offset: 0x1D5CF0 VA: 0x1801D68F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D68E0 Offset: 0x1D5CE0 VA: 0x1801D68E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DCD0 Offset: 0x128C2D0 VA: 0x18128DCD0
	private static void .cctor() { }

}

internal struct RemoteStorageLocalFileChange_t : ICallbackData // TypeDefIndex: 5385
{	// Fields
	public static int _datasize; // 0x139A7

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7390 Offset: 0x1D6790 VA: 0x1801D7390 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7380 Offset: 0x1D6780 VA: 0x1801D7380 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DFF0 Offset: 0x128C5F0 VA: 0x18128DFF0
	private static void .cctor() { }

}

