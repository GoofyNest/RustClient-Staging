internal class ISteamUGC : SteamInterface // TypeDefIndex: 5130
{	// Methods

	// RVA: 0xDD91B0 Offset: 0xDD77B0 VA: 0x180DD91B0
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDAC30 Offset: 0xDD9230 VA: 0x180DDAC30
	internal static extern IntPtr SteamAPI_SteamUGC_v016() { }

	// RVA: 0xDDAC30 Offset: 0xDD9230 VA: 0x180DDAC30 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDABC0 Offset: 0xDD91C0 VA: 0x180DDABC0
	internal static extern IntPtr SteamAPI_SteamGameServerUGC_v016() { }

	// RVA: 0xDDABC0 Offset: 0xDD91C0 VA: 0x180DDABC0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDDC410 Offset: 0xDDAA10 VA: 0x180DDC410
	private static extern UGCQueryHandle_t _CreateQueryUserUGCRequest(IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD9AB0 Offset: 0xDD80B0 VA: 0x180DD9AB0
	internal UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDDC2B0 Offset: 0xDDA8B0 VA: 0x180DDC2B0
	private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD9950 Offset: 0xDD7F50 VA: 0x180DD9950
	internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDDC370 Offset: 0xDDA970 VA: 0x180DDC370
	private static extern UGCQueryHandle_t _CreateQueryUGCDetailsRequest(IntPtr self, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDD9A10 Offset: 0xDD8010 VA: 0x180DD9A10
	internal UGCQueryHandle_t CreateQueryUGCDetailsRequest([In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDDD070 Offset: 0xDDB670 VA: 0x180DDD070
	private static extern SteamAPICall_t _SendQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDDADF0 Offset: 0xDD93F0 VA: 0x180DDADF0
	internal CallResult<SteamUGCQueryCompleted_t> SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDDCCE0 Offset: 0xDDB2E0 VA: 0x180DDCCE0
	private static extern bool _GetQueryUGCResult(IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDDAAE0 Offset: 0xDD90E0 VA: 0x180DDAAE0
	internal bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDDCC20 Offset: 0xDDB220 VA: 0x180DDCC20
	private static extern bool _GetQueryUGCPreviewURL(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	// RVA: 0xDDA8E0 Offset: 0xDD8EE0 VA: 0x180DDA8E0
	internal bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL) { }

	// RVA: 0xDDCA20 Offset: 0xDDB020 VA: 0x180DDCA20
	private static extern bool _GetQueryUGCMetadata(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	// RVA: 0xDDA5A0 Offset: 0xDD8BA0 VA: 0x180DDA5A0
	internal bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata) { }

	// RVA: 0xDDC880 Offset: 0xDDAE80 VA: 0x180DDC880
	private static extern bool _GetQueryUGCChildren(IntPtr self, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDDA230 Offset: 0xDD8830 VA: 0x180DDA230
	internal bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDDCE70 Offset: 0xDDB470 VA: 0x180DDCE70
	private static extern bool _GetQueryUGCStatistic(IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDDAB00 Offset: 0xDD9100 VA: 0x180DDAB00
	internal bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDDCAE0 Offset: 0xDDB0E0 VA: 0x180DDCAE0
	private static extern uint _GetQueryUGCNumAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDA7A0 Offset: 0xDD8DA0 VA: 0x180DDA7A0
	internal uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDC790 Offset: 0xDDAD90 VA: 0x180DDC790
	private static extern bool _GetQueryUGCAdditionalPreview(IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDD9F70 Offset: 0xDD8570 VA: 0x180DD9F70
	internal bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDDCB80 Offset: 0xDDB180 VA: 0x180DDCB80
	private static extern uint _GetQueryUGCNumKeyValueTags(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDA840 Offset: 0xDD8E40 VA: 0x180DDA840
	internal uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDC940 Offset: 0xDDAF40 VA: 0x180DDC940
	private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0xDDA2F0 Offset: 0xDD88F0 VA: 0x180DDA2F0
	internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue) { }

	// RVA: 0xDDCF30 Offset: 0xDDB530 VA: 0x180DDCF30
	private static extern bool _ReleaseQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDDACA0 Offset: 0xDD92A0 VA: 0x180DDACA0
	internal bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDDC160 Offset: 0xDDA760 VA: 0x180DDC160
	private static extern bool _AddRequiredTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD9790 Offset: 0xDD7D90 VA: 0x180DD9790
	internal bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDDBEF0 Offset: 0xDDA4F0 VA: 0x180DDBEF0
	private static extern bool _AddExcludedTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD9510 Offset: 0xDD7B10 VA: 0x180DD9510
	internal bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDDDB60 Offset: 0xDDC160 VA: 0x180DDDB60
	private static extern bool _SetReturnOnlyIDs(IntPtr self, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDDB9A0 Offset: 0xDD9FA0 VA: 0x180DDB9A0
	internal bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDDD980 Offset: 0xDDBF80 VA: 0x180DDD980
	private static extern bool _SetReturnKeyValueTags(IntPtr self, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDDB7C0 Offset: 0xDD9DC0 VA: 0x180DDB7C0
	internal bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDDDA20 Offset: 0xDDC020 VA: 0x180DDDA20
	private static extern bool _SetReturnLongDescription(IntPtr self, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDDB860 Offset: 0xDD9E60 VA: 0x180DDB860
	internal bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDDDAC0 Offset: 0xDDC0C0 VA: 0x180DDDAC0
	private static extern bool _SetReturnMetadata(IntPtr self, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDDB900 Offset: 0xDD9F00 VA: 0x180DDB900
	internal bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDDD8E0 Offset: 0xDDBEE0 VA: 0x180DDD8E0
	private static extern bool _SetReturnChildren(IntPtr self, UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDDB720 Offset: 0xDD9D20 VA: 0x180DDB720
	internal bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDDD840 Offset: 0xDDBE40 VA: 0x180DDD840
	private static extern bool _SetReturnAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDDB680 Offset: 0xDD9C80 VA: 0x180DDB680
	internal bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDDDCA0 Offset: 0xDDC2A0 VA: 0x180DDDCA0
	private static extern bool _SetReturnTotalOnly(IntPtr self, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDDBAE0 Offset: 0xDDA0E0 VA: 0x180DDBAE0
	internal bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDDDC00 Offset: 0xDDC200 VA: 0x180DDDC00
	private static extern bool _SetReturnPlaytimeStats(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDBA40 Offset: 0xDDA040 VA: 0x180DDBA40
	internal bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDD100 Offset: 0xDDB700 VA: 0x180DDD100
	private static extern bool _SetAllowCachedResponse(IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDDAEE0 Offset: 0xDD94E0 VA: 0x180DDAEE0
	internal bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDDD700 Offset: 0xDDBD00 VA: 0x180DDD700
	private static extern bool _SetMatchAnyTag(IntPtr self, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDDB540 Offset: 0xDD9B40 VA: 0x180DDB540
	internal bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDDDD40 Offset: 0xDDC340 VA: 0x180DDDD40
	private static extern bool _SetSearchText(IntPtr self, UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDDBB80 Offset: 0xDDA180 VA: 0x180DDBB80
	internal bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDDD7A0 Offset: 0xDDBDA0 VA: 0x180DDD7A0
	private static extern bool _SetRankedByTrendDays(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDB5E0 Offset: 0xDD9BE0 VA: 0x180DDB5E0
	internal bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDC080 Offset: 0xDDA680 VA: 0x180DDC080
	private static extern bool _AddRequiredKeyValueTag(IntPtr self, UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDD96B0 Offset: 0xDD7CB0 VA: 0x180DD96B0
	internal bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDDC210 Offset: 0xDDA810 VA: 0x180DDC210
	private static extern SteamAPICall_t _CreateItem(IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDD9850 Offset: 0xDD7E50 VA: 0x180DD9850
	internal CallResult<CreateItemResult_t> CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDDDE90 Offset: 0xDDC490 VA: 0x180DDDE90
	private static extern UGCUpdateHandle_t _StartItemUpdate(IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDBD40 Offset: 0xDDA340 VA: 0x180DDBD40
	internal UGCUpdateHandle_t StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDD500 Offset: 0xDDBB00 VA: 0x180DDD500
	private static extern bool _SetItemTitle(IntPtr self, UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDDB320 Offset: 0xDD9920 VA: 0x180DDB320
	internal bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDDD250 Offset: 0xDDB850 VA: 0x180DDD250
	private static extern bool _SetItemDescription(IntPtr self, UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDDB040 Offset: 0xDD9640 VA: 0x180DDB040
	internal bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDDD5B0 Offset: 0xDDBBB0 VA: 0x180DDD5B0
	private static extern bool _SetItemUpdateLanguage(IntPtr self, UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDDB3E0 Offset: 0xDD99E0 VA: 0x180DDB3E0
	internal bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDDD300 Offset: 0xDDB900 VA: 0x180DDD300
	private static extern bool _SetItemMetadata(IntPtr self, UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDDB100 Offset: 0xDD9700 VA: 0x180DDB100
	internal bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDDD660 Offset: 0xDDBC60 VA: 0x180DDD660
	private static extern bool _SetItemVisibility(IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDDB4A0 Offset: 0xDD9AA0 VA: 0x180DDB4A0
	internal bool SetItemVisibility(UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDDD460 Offset: 0xDDBA60 VA: 0x180DDD460
	private static extern bool _SetItemTags(IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDDB280 Offset: 0xDD9880 VA: 0x180DDB280
	internal bool SetItemTags(UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDDD1A0 Offset: 0xDDB7A0 VA: 0x180DDD1A0
	private static extern bool _SetItemContent(IntPtr self, UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDDAF80 Offset: 0xDD9580 VA: 0x180DDAF80
	internal bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDDD3B0 Offset: 0xDDB9B0 VA: 0x180DDD3B0
	private static extern bool _SetItemPreview(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDDB1C0 Offset: 0xDD97C0 VA: 0x180DDB1C0
	internal bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDDCFC0 Offset: 0xDDB5C0 VA: 0x180DDCFC0
	private static extern bool _RemoveItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDDAD30 Offset: 0xDD9330 VA: 0x180DDAD30
	internal bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDDBFA0 Offset: 0xDDA5A0 VA: 0x180DDBFA0
	private static extern bool _AddItemKeyValueTag(IntPtr self, UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDD95D0 Offset: 0xDD7BD0 VA: 0x180DD95D0
	internal bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDDDF30 Offset: 0xDDC530 VA: 0x180DDDF30
	private static extern SteamAPICall_t _SubmitItemUpdate(IntPtr self, UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDDBDE0 Offset: 0xDDA3E0 VA: 0x180DDBDE0
	internal CallResult<SubmitItemUpdateResult_t> SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDDC6E0 Offset: 0xDDACE0 VA: 0x180DDC6E0
	private static extern ItemUpdateStatus _GetItemUpdateProgress(IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDD9EC0 Offset: 0xDD84C0 VA: 0x180DD9EC0
	internal ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDDDDF0 Offset: 0xDDC3F0 VA: 0x180DDDDF0
	private static extern SteamAPICall_t _SetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDDBC40 Offset: 0xDDA240 VA: 0x180DDBC40
	internal CallResult<SetUserItemVoteResult_t> SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDDC650 Offset: 0xDDAC50 VA: 0x180DDC650
	private static extern uint _GetItemState(IntPtr self, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD9E30 Offset: 0xDD8430 VA: 0x180DD9E30
	internal uint GetItemState(PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDC580 Offset: 0xDDAB80 VA: 0x180DDC580
	private static extern bool _GetItemInstallInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp) { }

	// RVA: 0xDD9C20 Offset: 0xDD8220 VA: 0x180DD9C20
	internal bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp) { }

	// RVA: 0xDDC4E0 Offset: 0xDDAAE0 VA: 0x180DDC4E0
	private static extern bool _DownloadItem(IntPtr self, PublishedFileId nPublishedFileID, bool bHighPriority) { }

	// RVA: 0xDD9B80 Offset: 0xDD8180 VA: 0x180DD9B80
	internal bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) { }

}

