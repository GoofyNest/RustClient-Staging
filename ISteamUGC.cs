internal class ISteamUGC : SteamInterface // TypeDefIndex: 5130
{	// Methods

	// RVA: 0xDD8700 Offset: 0xDD6D00 VA: 0x180DD8700
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDA180 Offset: 0xDD8780 VA: 0x180DDA180
	internal static extern IntPtr SteamAPI_SteamUGC_v016() { }

	// RVA: 0xDDA180 Offset: 0xDD8780 VA: 0x180DDA180 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDA110 Offset: 0xDD8710 VA: 0x180DDA110
	internal static extern IntPtr SteamAPI_SteamGameServerUGC_v016() { }

	// RVA: 0xDDA110 Offset: 0xDD8710 VA: 0x180DDA110 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDDB960 Offset: 0xDD9F60 VA: 0x180DDB960
	private static extern UGCQueryHandle_t _CreateQueryUserUGCRequest(IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD9000 Offset: 0xDD7600 VA: 0x180DD9000
	internal UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDDB800 Offset: 0xDD9E00 VA: 0x180DDB800
	private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD8EA0 Offset: 0xDD74A0 VA: 0x180DD8EA0
	internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDDB8C0 Offset: 0xDD9EC0 VA: 0x180DDB8C0
	private static extern UGCQueryHandle_t _CreateQueryUGCDetailsRequest(IntPtr self, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDD8F60 Offset: 0xDD7560 VA: 0x180DD8F60
	internal UGCQueryHandle_t CreateQueryUGCDetailsRequest([In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDDC5C0 Offset: 0xDDABC0 VA: 0x180DDC5C0
	private static extern SteamAPICall_t _SendQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDDA340 Offset: 0xDD8940 VA: 0x180DDA340
	internal CallResult<SteamUGCQueryCompleted_t> SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDDC230 Offset: 0xDDA830 VA: 0x180DDC230
	private static extern bool _GetQueryUGCResult(IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDDA030 Offset: 0xDD8630 VA: 0x180DDA030
	internal bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDDC170 Offset: 0xDDA770 VA: 0x180DDC170
	private static extern bool _GetQueryUGCPreviewURL(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	// RVA: 0xDD9E30 Offset: 0xDD8430 VA: 0x180DD9E30
	internal bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL) { }

	// RVA: 0xDDBF70 Offset: 0xDDA570 VA: 0x180DDBF70
	private static extern bool _GetQueryUGCMetadata(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	// RVA: 0xDD9AF0 Offset: 0xDD80F0 VA: 0x180DD9AF0
	internal bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata) { }

	// RVA: 0xDDBDD0 Offset: 0xDDA3D0 VA: 0x180DDBDD0
	private static extern bool _GetQueryUGCChildren(IntPtr self, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDD9780 Offset: 0xDD7D80 VA: 0x180DD9780
	internal bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDDC3C0 Offset: 0xDDA9C0 VA: 0x180DDC3C0
	private static extern bool _GetQueryUGCStatistic(IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDDA050 Offset: 0xDD8650 VA: 0x180DDA050
	internal bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDDC030 Offset: 0xDDA630 VA: 0x180DDC030
	private static extern uint _GetQueryUGCNumAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD9CF0 Offset: 0xDD82F0 VA: 0x180DD9CF0
	internal uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDBCE0 Offset: 0xDDA2E0 VA: 0x180DDBCE0
	private static extern bool _GetQueryUGCAdditionalPreview(IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDD94C0 Offset: 0xDD7AC0 VA: 0x180DD94C0
	internal bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDDC0D0 Offset: 0xDDA6D0 VA: 0x180DDC0D0
	private static extern uint _GetQueryUGCNumKeyValueTags(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD9D90 Offset: 0xDD8390 VA: 0x180DD9D90
	internal uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDDBE90 Offset: 0xDDA490 VA: 0x180DDBE90
	private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0xDD9840 Offset: 0xDD7E40 VA: 0x180DD9840
	internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue) { }

	// RVA: 0xDDC480 Offset: 0xDDAA80 VA: 0x180DDC480
	private static extern bool _ReleaseQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDDA1F0 Offset: 0xDD87F0 VA: 0x180DDA1F0
	internal bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDDB6B0 Offset: 0xDD9CB0 VA: 0x180DDB6B0
	private static extern bool _AddRequiredTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD8CE0 Offset: 0xDD72E0 VA: 0x180DD8CE0
	internal bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDDB440 Offset: 0xDD9A40 VA: 0x180DDB440
	private static extern bool _AddExcludedTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD8A60 Offset: 0xDD7060 VA: 0x180DD8A60
	internal bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDDD0B0 Offset: 0xDDB6B0 VA: 0x180DDD0B0
	private static extern bool _SetReturnOnlyIDs(IntPtr self, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDDAEF0 Offset: 0xDD94F0 VA: 0x180DDAEF0
	internal bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDDCED0 Offset: 0xDDB4D0 VA: 0x180DDCED0
	private static extern bool _SetReturnKeyValueTags(IntPtr self, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDDAD10 Offset: 0xDD9310 VA: 0x180DDAD10
	internal bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDDCF70 Offset: 0xDDB570 VA: 0x180DDCF70
	private static extern bool _SetReturnLongDescription(IntPtr self, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDDADB0 Offset: 0xDD93B0 VA: 0x180DDADB0
	internal bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDDD010 Offset: 0xDDB610 VA: 0x180DDD010
	private static extern bool _SetReturnMetadata(IntPtr self, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDDAE50 Offset: 0xDD9450 VA: 0x180DDAE50
	internal bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDDCE30 Offset: 0xDDB430 VA: 0x180DDCE30
	private static extern bool _SetReturnChildren(IntPtr self, UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDDAC70 Offset: 0xDD9270 VA: 0x180DDAC70
	internal bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDDCD90 Offset: 0xDDB390 VA: 0x180DDCD90
	private static extern bool _SetReturnAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDDABD0 Offset: 0xDD91D0 VA: 0x180DDABD0
	internal bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDDD1F0 Offset: 0xDDB7F0 VA: 0x180DDD1F0
	private static extern bool _SetReturnTotalOnly(IntPtr self, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDDB030 Offset: 0xDD9630 VA: 0x180DDB030
	internal bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDDD150 Offset: 0xDDB750 VA: 0x180DDD150
	private static extern bool _SetReturnPlaytimeStats(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDAF90 Offset: 0xDD9590 VA: 0x180DDAF90
	internal bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDC650 Offset: 0xDDAC50 VA: 0x180DDC650
	private static extern bool _SetAllowCachedResponse(IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDDA430 Offset: 0xDD8A30 VA: 0x180DDA430
	internal bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDDCC50 Offset: 0xDDB250 VA: 0x180DDCC50
	private static extern bool _SetMatchAnyTag(IntPtr self, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDDAA90 Offset: 0xDD9090 VA: 0x180DDAA90
	internal bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDDD290 Offset: 0xDDB890 VA: 0x180DDD290
	private static extern bool _SetSearchText(IntPtr self, UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDDB0D0 Offset: 0xDD96D0 VA: 0x180DDB0D0
	internal bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDDCCF0 Offset: 0xDDB2F0 VA: 0x180DDCCF0
	private static extern bool _SetRankedByTrendDays(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDAB30 Offset: 0xDD9130 VA: 0x180DDAB30
	internal bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDDB5D0 Offset: 0xDD9BD0 VA: 0x180DDB5D0
	private static extern bool _AddRequiredKeyValueTag(IntPtr self, UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDD8C00 Offset: 0xDD7200 VA: 0x180DD8C00
	internal bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDDB760 Offset: 0xDD9D60 VA: 0x180DDB760
	private static extern SteamAPICall_t _CreateItem(IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDD8DA0 Offset: 0xDD73A0 VA: 0x180DD8DA0
	internal CallResult<CreateItemResult_t> CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDDD3E0 Offset: 0xDDB9E0 VA: 0x180DDD3E0
	private static extern UGCUpdateHandle_t _StartItemUpdate(IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDB290 Offset: 0xDD9890 VA: 0x180DDB290
	internal UGCUpdateHandle_t StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDCA50 Offset: 0xDDB050 VA: 0x180DDCA50
	private static extern bool _SetItemTitle(IntPtr self, UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDDA870 Offset: 0xDD8E70 VA: 0x180DDA870
	internal bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDDC7A0 Offset: 0xDDADA0 VA: 0x180DDC7A0
	private static extern bool _SetItemDescription(IntPtr self, UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDDA590 Offset: 0xDD8B90 VA: 0x180DDA590
	internal bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDDCB00 Offset: 0xDDB100 VA: 0x180DDCB00
	private static extern bool _SetItemUpdateLanguage(IntPtr self, UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDDA930 Offset: 0xDD8F30 VA: 0x180DDA930
	internal bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDDC850 Offset: 0xDDAE50 VA: 0x180DDC850
	private static extern bool _SetItemMetadata(IntPtr self, UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDDA650 Offset: 0xDD8C50 VA: 0x180DDA650
	internal bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDDCBB0 Offset: 0xDDB1B0 VA: 0x180DDCBB0
	private static extern bool _SetItemVisibility(IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDDA9F0 Offset: 0xDD8FF0 VA: 0x180DDA9F0
	internal bool SetItemVisibility(UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDDC9B0 Offset: 0xDDAFB0 VA: 0x180DDC9B0
	private static extern bool _SetItemTags(IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDDA7D0 Offset: 0xDD8DD0 VA: 0x180DDA7D0
	internal bool SetItemTags(UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDDC6F0 Offset: 0xDDACF0 VA: 0x180DDC6F0
	private static extern bool _SetItemContent(IntPtr self, UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDDA4D0 Offset: 0xDD8AD0 VA: 0x180DDA4D0
	internal bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDDC900 Offset: 0xDDAF00 VA: 0x180DDC900
	private static extern bool _SetItemPreview(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDDA710 Offset: 0xDD8D10 VA: 0x180DDA710
	internal bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDDC510 Offset: 0xDDAB10 VA: 0x180DDC510
	private static extern bool _RemoveItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDDA280 Offset: 0xDD8880 VA: 0x180DDA280
	internal bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDDB4F0 Offset: 0xDD9AF0 VA: 0x180DDB4F0
	private static extern bool _AddItemKeyValueTag(IntPtr self, UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDD8B20 Offset: 0xDD7120 VA: 0x180DD8B20
	internal bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDDD480 Offset: 0xDDBA80 VA: 0x180DDD480
	private static extern SteamAPICall_t _SubmitItemUpdate(IntPtr self, UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDDB330 Offset: 0xDD9930 VA: 0x180DDB330
	internal CallResult<SubmitItemUpdateResult_t> SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDDBC30 Offset: 0xDDA230 VA: 0x180DDBC30
	private static extern ItemUpdateStatus _GetItemUpdateProgress(IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDD9410 Offset: 0xDD7A10 VA: 0x180DD9410
	internal ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDDD340 Offset: 0xDDB940 VA: 0x180DDD340
	private static extern SteamAPICall_t _SetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDDB190 Offset: 0xDD9790 VA: 0x180DDB190
	internal CallResult<SetUserItemVoteResult_t> SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDDBBA0 Offset: 0xDDA1A0 VA: 0x180DDBBA0
	private static extern uint _GetItemState(IntPtr self, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD9380 Offset: 0xDD7980 VA: 0x180DD9380
	internal uint GetItemState(PublishedFileId nPublishedFileID) { }

	// RVA: 0xDDBAD0 Offset: 0xDDA0D0 VA: 0x180DDBAD0
	private static extern bool _GetItemInstallInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp) { }

	// RVA: 0xDD9170 Offset: 0xDD7770 VA: 0x180DD9170
	internal bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp) { }

	// RVA: 0xDDBA30 Offset: 0xDDA030 VA: 0x180DDBA30
	private static extern bool _DownloadItem(IntPtr self, PublishedFileId nPublishedFileID, bool bHighPriority) { }

	// RVA: 0xDD90D0 Offset: 0xDD76D0 VA: 0x180DD90D0
	internal bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) { }

}

