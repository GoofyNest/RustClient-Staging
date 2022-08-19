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

	// RVA: 0x1D69E0 Offset: 0x1D5DE0 VA: 0x1801D69E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D69D0 Offset: 0x1D5DD0 VA: 0x1801D69D0 Slot: 4
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

	// RVA: 0x1D74F0 Offset: 0x1D68F0 VA: 0x1801D74F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D74E0 Offset: 0x1D68E0 VA: 0x1801D74E0 Slot: 4
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

	// RVA: 0x1D31F0 Offset: 0x1D25F0 VA: 0x1801D31F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D31E0 Offset: 0x1D25E0 VA: 0x1801D31E0 Slot: 4
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

	// RVA: 0x1D4240 Offset: 0x1D3640 VA: 0x1801D4240 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4230 Offset: 0x1D3630 VA: 0x1801D4230 Slot: 4
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

	// RVA: 0x1D7790 Offset: 0x1D6B90 VA: 0x1801D7790 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7780 Offset: 0x1D6B80 VA: 0x1801D7780 Slot: 4
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

	// RVA: 0x1D4DF0 Offset: 0x1D41F0 VA: 0x1801D4DF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4DE0 Offset: 0x1D41E0 VA: 0x1801D4DE0 Slot: 4
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

	// RVA: 0x1D7800 Offset: 0x1D6C00 VA: 0x1801D7800 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D77F0 Offset: 0x1D6BF0 VA: 0x1801D77F0 Slot: 4
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

	// RVA: 0x1D7870 Offset: 0x1D6C70 VA: 0x1801D7870 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7860 Offset: 0x1D6C60 VA: 0x1801D7860 Slot: 4
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

	// RVA: 0x1D3260 Offset: 0x1D2660 VA: 0x1801D3260 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3250 Offset: 0x1D2650 VA: 0x1801D3250 Slot: 4
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

	// RVA: 0x1D6C30 Offset: 0x1D6030 VA: 0x1801D6C30 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6C20 Offset: 0x1D6020 VA: 0x1801D6C20 Slot: 4
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

	// RVA: 0x1D5B90 Offset: 0x1D4F90 VA: 0x1801D5B90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D5B80 Offset: 0x1D4F80 VA: 0x1801D5B80 Slot: 4
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

	// RVA: 0x1D73A0 Offset: 0x1D67A0 VA: 0x1801D73A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7390 Offset: 0x1D6790 VA: 0x1801D7390 Slot: 4
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

	// RVA: 0x1D75D0 Offset: 0x1D69D0 VA: 0x1801D75D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D75C0 Offset: 0x1D69C0 VA: 0x1801D75C0 Slot: 4
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

	// RVA: 0x1D7640 Offset: 0x1D6A40 VA: 0x1801D7640 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7630 Offset: 0x1D6A30 VA: 0x1801D7630 Slot: 4
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

	// RVA: 0x1D7560 Offset: 0x1D6960 VA: 0x1801D7560 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7550 Offset: 0x1D6950 VA: 0x1801D7550 Slot: 4
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

	// RVA: 0x1D78E0 Offset: 0x1D6CE0 VA: 0x1801D78E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D78D0 Offset: 0x1D6CD0 VA: 0x1801D78D0 Slot: 4
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

	// RVA: 0x1D7950 Offset: 0x1D6D50 VA: 0x1801D7950 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7940 Offset: 0x1D6D40 VA: 0x1801D7940 Slot: 4
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

	// RVA: 0x1D49E0 Offset: 0x1D3DE0 VA: 0x1801D49E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D49D0 Offset: 0x1D3DD0 VA: 0x1801D49D0 Slot: 4
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

	// RVA: 0x1D7720 Offset: 0x1D6B20 VA: 0x1801D7720 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7710 Offset: 0x1D6B10 VA: 0x1801D7710 Slot: 4
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

	// RVA: 0x1D3480 Offset: 0x1D2880 VA: 0x1801D3480 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3470 Offset: 0x1D2870 VA: 0x1801D3470 Slot: 4
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

	// RVA: 0x1D7480 Offset: 0x1D6880 VA: 0x1801D7480 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7470 Offset: 0x1D6870 VA: 0x1801D7470 Slot: 4
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

	// RVA: 0x1D76B0 Offset: 0x1D6AB0 VA: 0x1801D76B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D76A0 Offset: 0x1D6AA0 VA: 0x1801D76A0 Slot: 4
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

	// RVA: 0x1D6BC0 Offset: 0x1D5FC0 VA: 0x1801D6BC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6BB0 Offset: 0x1D5FB0 VA: 0x1801D6BB0 Slot: 4
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

	// RVA: 0x1D6970 Offset: 0x1D5D70 VA: 0x1801D6970 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6960 Offset: 0x1D5D60 VA: 0x1801D6960 Slot: 4
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

	// RVA: 0x1D7410 Offset: 0x1D6810 VA: 0x1801D7410 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7400 Offset: 0x1D6800 VA: 0x1801D7400 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128DFF0 Offset: 0x128C5F0 VA: 0x18128DFF0
	private static void .cctor() { }

}

