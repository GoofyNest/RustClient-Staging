internal class ISteamUGC : SteamInterface // TypeDefIndex: 5130
{	// Methods

	// RVA: 0xDD8440 Offset: 0xDD6A40 VA: 0x180DD8440
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD9EC0 Offset: 0xDD84C0 VA: 0x180DD9EC0
	internal static extern IntPtr SteamAPI_SteamUGC_v016() { }

	// RVA: 0xDD9EC0 Offset: 0xDD84C0 VA: 0x180DD9EC0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD9E50 Offset: 0xDD8450 VA: 0x180DD9E50
	internal static extern IntPtr SteamAPI_SteamGameServerUGC_v016() { }

	// RVA: 0xDD9E50 Offset: 0xDD8450 VA: 0x180DD9E50 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDDB6A0 Offset: 0xDD9CA0 VA: 0x180DDB6A0
	private static extern UGCQueryHandle_t _CreateQueryUserUGCRequest(IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD8D40 Offset: 0xDD7340 VA: 0x180DD8D40
	internal UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDDB540 Offset: 0xDD9B40 VA: 0x180DDB540
	private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD8BE0 Offset: 0xDD71E0 VA: 0x180DD8BE0
	internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDDB600 Offset: 0xDD9C00 VA: 0x180DDB600
	private static extern UGCQueryHandle_t _CreateQueryUGCDetailsRequest(IntPtr self, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDD8CA0 Offset: 0xDD72A0 VA: 0x180DD8CA0
	internal UGCQueryHandle_t CreateQueryUGCDetailsRequest([In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDDC300 Offset: 0xDDA900 VA: 0x180DDC300
	private static extern SteamAPICall_t _SendQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDDA080 Offset: 0xDD8680 VA: 0x180DDA080
	internal CallResult<SteamUGCQueryCompleted_t> SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDDBF70 Offset: 0xDDA570 VA: 0x180DDBF70
	private static extern bool _GetQueryUGCResult(IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDD9D70 Offset: 0xDD8370 VA: 0x180DD9D70
	internal bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDDBEB0 Offset: 0xDDA4B0 VA: 0x180DDBEB0
	private static extern bool _GetQueryUGCPreviewURL(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	// RVA: 0xDD9B70 Offset: 0xDD8170 VA: 0x180DD9B70
	internal bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL) { }

	// RVA: 0xDDBCB0 Offset: 0xDDA2B0 VA: 0x180DDBCB0
	private static extern bool _GetQueryUGCMetadata(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	// RVA: 0xDD9830 Offset: 0xDD7E30 VA: 0x180DD9830
	internal bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata) { }

	// RVA: 0xDDBB10 Offset: 0xDDA110 VA: 0x180DDBB10
	private static extern bool _GetQueryUGCChildren(IntPtr self, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDD94C0 Offset: 0xDD7AC0 VA: 0x180DD94C0
	internal bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDDC100 Offset: 0xDDA700 VA: 0x180DDC100
	private static extern bool _GetQueryUGCStatistic(IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDD9D90 Offset: 0xDD8390 VA: 0x180DD9D90
	internal bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDDBD70 Offset: 0xDDA370 VA: 0x180DDBD70
	private static extern uint _GetQueryUGCNumAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD9A30 Offset: 0xDD8030 VA: 0x180DD9A30
	internal uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDBA20 Offset: 0xDDA020 VA: 0x180DDBA20
	private static extern bool _GetQueryUGCAdditionalPreview(IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDD9200 Offset: 0xDD7800 VA: 0x180DD9200
	internal bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDDBE10 Offset: 0xDDA410 VA: 0x180DDBE10
	private static extern uint _GetQueryUGCNumKeyValueTags(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD9AD0 Offset: 0xDD80D0 VA: 0x180DD9AD0
	internal uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDBBD0 Offset: 0xDDA1D0 VA: 0x180DDBBD0
	private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0xDD9580 Offset: 0xDD7B80 VA: 0x180DD9580
	internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue) { }

	// RVA: 0xDDC1C0 Offset: 0xDDA7C0 VA: 0x180DDC1C0
	private static extern bool _ReleaseQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDD9F30 Offset: 0xDD8530 VA: 0x180DD9F30
	internal bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDDB3F0 Offset: 0xDD99F0 VA: 0x180DDB3F0
	private static extern bool _AddRequiredTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD8A20 Offset: 0xDD7020 VA: 0x180DD8A20
	internal bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDDB180 Offset: 0xDD9780 VA: 0x180DDB180
	private static extern bool _AddExcludedTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD87A0 Offset: 0xDD6DA0 VA: 0x180DD87A0
	internal bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDDCDF0 Offset: 0xDDB3F0 VA: 0x180DDCDF0
	private static extern bool _SetReturnOnlyIDs(IntPtr self, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDDAC30 Offset: 0xDD9230 VA: 0x180DDAC30
	internal bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDDCC10 Offset: 0xDDB210 VA: 0x180DDCC10
	private static extern bool _SetReturnKeyValueTags(IntPtr self, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDDAA50 Offset: 0xDD9050 VA: 0x180DDAA50
	internal bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDDCCB0 Offset: 0xDDB2B0 VA: 0x180DDCCB0
	private static extern bool _SetReturnLongDescription(IntPtr self, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDDAAF0 Offset: 0xDD90F0 VA: 0x180DDAAF0
	internal bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDDCD50 Offset: 0xDDB350 VA: 0x180DDCD50
	private static extern bool _SetReturnMetadata(IntPtr self, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDDAB90 Offset: 0xDD9190 VA: 0x180DDAB90
	internal bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDDCB70 Offset: 0xDDB170 VA: 0x180DDCB70
	private static extern bool _SetReturnChildren(IntPtr self, UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDDA9B0 Offset: 0xDD8FB0 VA: 0x180DDA9B0
	internal bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDDCAD0 Offset: 0xDDB0D0 VA: 0x180DDCAD0
	private static extern bool _SetReturnAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDDA910 Offset: 0xDD8F10 VA: 0x180DDA910
	internal bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDDCF30 Offset: 0xDDB530 VA: 0x180DDCF30
	private static extern bool _SetReturnTotalOnly(IntPtr self, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDDAD70 Offset: 0xDD9370 VA: 0x180DDAD70
	internal bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDDCE90 Offset: 0xDDB490 VA: 0x180DDCE90
	private static extern bool _SetReturnPlaytimeStats(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDACD0 Offset: 0xDD92D0 VA: 0x180DDACD0
	internal bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDC390 Offset: 0xDDA990 VA: 0x180DDC390
	private static extern bool _SetAllowCachedResponse(IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDDA170 Offset: 0xDD8770 VA: 0x180DDA170
	internal bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDDC990 Offset: 0xDDAF90 VA: 0x180DDC990
	private static extern bool _SetMatchAnyTag(IntPtr self, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDDA7D0 Offset: 0xDD8DD0 VA: 0x180DDA7D0
	internal bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDDCFD0 Offset: 0xDDB5D0 VA: 0x180DDCFD0
	private static extern bool _SetSearchText(IntPtr self, UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDDAE10 Offset: 0xDD9410 VA: 0x180DDAE10
	internal bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDDCA30 Offset: 0xDDB030 VA: 0x180DDCA30
	private static extern bool _SetRankedByTrendDays(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDA870 Offset: 0xDD8E70 VA: 0x180DDA870
	internal bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDB310 Offset: 0xDD9910 VA: 0x180DDB310
	private static extern bool _AddRequiredKeyValueTag(IntPtr self, UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDD8940 Offset: 0xDD6F40 VA: 0x180DD8940
	internal bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDDB4A0 Offset: 0xDD9AA0 VA: 0x180DDB4A0
	private static extern SteamAPICall_t _CreateItem(IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDD8AE0 Offset: 0xDD70E0 VA: 0x180DD8AE0
	internal CallResult<CreateItemResult_t> CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDDD120 Offset: 0xDDB720 VA: 0x180DDD120
	private static extern UGCUpdateHandle_t _StartItemUpdate(IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDAFD0 Offset: 0xDD95D0 VA: 0x180DDAFD0
	internal UGCUpdateHandle_t StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDC790 Offset: 0xDDAD90 VA: 0x180DDC790
	private static extern bool _SetItemTitle(IntPtr self, UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDDA5B0 Offset: 0xDD8BB0 VA: 0x180DDA5B0
	internal bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDDC4E0 Offset: 0xDDAAE0 VA: 0x180DDC4E0
	private static extern bool _SetItemDescription(IntPtr self, UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDDA2D0 Offset: 0xDD88D0 VA: 0x180DDA2D0
	internal bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDDC840 Offset: 0xDDAE40 VA: 0x180DDC840
	private static extern bool _SetItemUpdateLanguage(IntPtr self, UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDDA670 Offset: 0xDD8C70 VA: 0x180DDA670
	internal bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDDC590 Offset: 0xDDAB90 VA: 0x180DDC590
	private static extern bool _SetItemMetadata(IntPtr self, UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDDA390 Offset: 0xDD8990 VA: 0x180DDA390
	internal bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDDC8F0 Offset: 0xDDAEF0 VA: 0x180DDC8F0
	private static extern bool _SetItemVisibility(IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDDA730 Offset: 0xDD8D30 VA: 0x180DDA730
	internal bool SetItemVisibility(UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDDC6F0 Offset: 0xDDACF0 VA: 0x180DDC6F0
	private static extern bool _SetItemTags(IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDDA510 Offset: 0xDD8B10 VA: 0x180DDA510
	internal bool SetItemTags(UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDDC430 Offset: 0xDDAA30 VA: 0x180DDC430
	private static extern bool _SetItemContent(IntPtr self, UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDDA210 Offset: 0xDD8810 VA: 0x180DDA210
	internal bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDDC640 Offset: 0xDDAC40 VA: 0x180DDC640
	private static extern bool _SetItemPreview(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDDA450 Offset: 0xDD8A50 VA: 0x180DDA450
	internal bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDDC250 Offset: 0xDDA850 VA: 0x180DDC250
	private static extern bool _RemoveItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDD9FC0 Offset: 0xDD85C0 VA: 0x180DD9FC0
	internal bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDDB230 Offset: 0xDD9830 VA: 0x180DDB230
	private static extern bool _AddItemKeyValueTag(IntPtr self, UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDD8860 Offset: 0xDD6E60 VA: 0x180DD8860
	internal bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDDD1C0 Offset: 0xDDB7C0 VA: 0x180DDD1C0
	private static extern SteamAPICall_t _SubmitItemUpdate(IntPtr self, UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDDB070 Offset: 0xDD9670 VA: 0x180DDB070
	internal CallResult<SubmitItemUpdateResult_t> SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDDB970 Offset: 0xDD9F70 VA: 0x180DDB970
	private static extern ItemUpdateStatus _GetItemUpdateProgress(IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDD9150 Offset: 0xDD7750 VA: 0x180DD9150
	internal ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDDD080 Offset: 0xDDB680 VA: 0x180DDD080
	private static extern SteamAPICall_t _SetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDDAED0 Offset: 0xDD94D0 VA: 0x180DDAED0
	internal CallResult<SetUserItemVoteResult_t> SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDDB8E0 Offset: 0xDD9EE0 VA: 0x180DDB8E0
	private static extern uint _GetItemState(IntPtr self, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD90C0 Offset: 0xDD76C0 VA: 0x180DD90C0
	internal uint GetItemState(PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDB810 Offset: 0xDD9E10 VA: 0x180DDB810
	private static extern bool _GetItemInstallInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp) { }

	// RVA: 0xDD8EB0 Offset: 0xDD74B0 VA: 0x180DD8EB0
	internal bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp) { }

	// RVA: 0xDDB770 Offset: 0xDD9D70 VA: 0x180DDB770
	private static extern bool _DownloadItem(IntPtr self, PublishedFileId nPublishedFileID, bool bHighPriority) { }

	// RVA: 0xDD8E10 Offset: 0xDD7410 VA: 0x180DD8E10
	internal bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) { }

}

